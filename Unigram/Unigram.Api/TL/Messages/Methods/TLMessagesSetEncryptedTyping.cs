// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.setEncryptedTyping.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesSetEncryptedTyping : TLObject
	{
		public TLInputEncryptedChat Peer { get; set; }
		public Boolean Typing { get; set; }

		public TLMessagesSetEncryptedTyping() { }
		public TLMessagesSetEncryptedTyping(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSetEncryptedTyping; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputEncryptedChat>(from);
			Typing = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Peer);
			to.WriteBoolean(Typing);
		}
	}
}