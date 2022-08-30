// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputMessageReplyTo : TLInputMessageBase 
	{
		public Int32 Id { get; set; }

		public TLInputMessageReplyTo() { }
		public TLInputMessageReplyTo(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMessageReplyTo; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Id);
		}
	}
}