using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Td.Api;
using Unigram.Common;
using Unigram.Controls;
using Unigram.Controls.Views;
using Unigram.Services;
using Unigram.Services.Factories;
using Unigram.ViewModels.Delegates;
using Windows.ApplicationModel.DataTransfer;
using Windows.System;
using Windows.UI.Xaml.Navigation;

namespace Unigram.ViewModels
{
    public class InstantViewModel : TLViewModelBase
    {
        private readonly IMessageFactory _messageFactory;

        public InstantViewModel(IProtoService protoService, ICacheService cacheService, ISettingsService settingsService, IMessageFactory messageFactory, IEventAggregator aggregator) 
            : base(protoService, cacheService, settingsService, aggregator)
        {
            _messageFactory = messageFactory;
            _gallery = new InstantGalleryViewModel(protoService, aggregator);

            ShareCommand = new RelayCommand(ShareExecute);
            FeedbackCommand = new RelayCommand(FeedbackExecute);
            BrowserCommand = new RelayCommand(BrowserExecute);
            CopyCommand = new RelayCommand(CopyExecute);
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            var response = await ProtoService.SendAsync(new GetWebPagePreview(new FormattedText((string)parameter, new TextEntity[0])));
            if (response is WebPage webPage)
            {
                Title = webPage.SiteName;
            }
        }

        public Uri ShareLink { get; set; }
        public string ShareTitle { get; set; }

        public MessageViewModel CreateMessage(IMessageDelegate delegato, Message message)
        {
            return _messageFactory.Create(delegato, message);
        }

        private InstantGalleryViewModel _gallery;
        public InstantGalleryViewModel Gallery
        {
            get
            {
                return _gallery;
            }
            set
            {
                Set(ref _gallery, value);
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }

        public RelayCommand ShareCommand { get; }
        private async void ShareExecute()
        {
            if (ShareLink != null)
            {
                await ShareView.GetForCurrentView().ShowAsync(ShareLink, ShareTitle);
            }
        }

        public RelayCommand FeedbackCommand { get; }
        private async void FeedbackExecute()
        {
            var response = await ProtoService.SendAsync(new SearchPublicChat("previews"));
            if (response is Chat chat)
            {
                NavigationService.NavigateToChat(chat);
            }
        }

        public RelayCommand BrowserCommand { get; }
        private async void BrowserExecute()
        {
            await Launcher.LaunchUriAsync(ShareLink);
        }

        public RelayCommand CopyCommand { get; }
        private async void CopyExecute()
        {
            var dataPackage = new DataPackage();
            dataPackage.SetText(ShareLink.AbsoluteUri);
            ClipboardEx.TrySetContent(dataPackage);

            await TLMessageDialog.ShowAsync(Strings.Resources.LinkCopied, Strings.Resources.AppName, Strings.Resources.OK);
        }
    }
}
