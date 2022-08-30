// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesAffectedMessages : TLObject 
	{
		public Int32 Pts { get; set; }
		public Int32 PtsCount { get; set; }

		public TLMessagesAffectedMessages() { }
		public TLMessagesAffectedMessages(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesAffectedMessages; } }

		public override void Read(TLBinaryReader from)
		{
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x84D19185);
			to.Write(Pts);
			to.Write(PtsCount);
		}
	}
}