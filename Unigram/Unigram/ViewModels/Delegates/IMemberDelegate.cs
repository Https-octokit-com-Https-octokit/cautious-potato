﻿using Telegram.Td.Api;

namespace Unigram.ViewModels.Delegates
{
    public interface IMemberDelegate : IUserDelegate
    {
        void UpdateMember(Chat chat, Supergroup group, User user, ChatMember member);
    }
}
