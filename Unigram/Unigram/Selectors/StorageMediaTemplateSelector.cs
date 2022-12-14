using Unigram.Entities;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Unigram.Selectors
{
    public class StorageMediaTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PhotoTemplate { get; set; }
        public DataTemplate VideoTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is StoragePhoto)
            {
                return PhotoTemplate;
            }
            else if (item is StorageVideo)
            {
                return VideoTemplate;
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
