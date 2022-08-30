// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.requestEncryption.
	/// Returns <see cref="Telegram.Api.TL.TLEncryptedChatBase"/>
	/// </summary>
	public partial class TLMessagesRequestEncryption : TLObject
	{
		public TLInputUserBase UserId { get; set; }
		public Int32 RandomId { get; set; }
		public Byte[] GA { get; set; }

		public TLMessagesRequestEncryption() { }
		public TLMessagesRequestEncryption(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesRequestEncryption; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = TLFactory.Read<TLInputUserBase>(from);
			RandomId = from.ReadInt32();
			GA = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(UserId);
			to.WriteInt32(RandomId);
			to.WriteByteArray(GA);
		}
	}
}