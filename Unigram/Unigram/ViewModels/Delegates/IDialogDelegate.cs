﻿using System.Collections.Generic;
using Telegram.Td.Api;
using Unigram.ViewModels.Chats;
using Windows.UI.Xaml;

namespace Unigram.ViewModels.Delegates
{
    public interface IDialogDelegate : IProfileDelegate
    {
        void UpdateChatActions(Chat chat, IDictionary<int, ChatAction> actions);

        void UpdateChatPermissions(Chat chat);
        void UpdateChatActionBar(Chat chat);
        void UpdateChatHasScheduledMessages(Chat chat);
        void UpdateChatReplyMarkup(Chat chat, MessageViewModel message);
        void UpdateChatUnreadMentionCount(Chat chat, int unreadMentionCount);
        void UpdateChatDefaultDisableNotification(Chat chat, bool defaultDisableNotification);
        void UpdateChatOnlineMemberCount(Chat chat, int count);

        void UpdatePinnedMessage(Chat chat, MessageViewModel message, bool loading);
        void UpdateCallbackQueryAnswer(Chat chat, MessageViewModel answer);

        void UpdateComposerHeader(Chat chat, MessageComposerHeader header);
        void UpdateSearchMask(Chat chat, ChatSearchViewModel search);



        void PlayMessage(MessageViewModel message, FrameworkElement target);



        void HideStickers();
    }
}
