// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesChats : TLMessagesChatsBase 
	{
		public TLMessagesChats() { }
		public TLMessagesChats(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesChats; } }

		public override void Read(TLBinaryReader from)
		{
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x64FF9FD5);
			to.WriteObject(Chats);
		}
	}
}