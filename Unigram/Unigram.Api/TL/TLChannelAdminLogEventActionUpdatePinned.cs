// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelAdminLogEventActionUpdatePinned : TLChannelAdminLogEventActionBase 
	{
		public TLMessageBase Message { get; set; }

		public TLChannelAdminLogEventActionUpdatePinned() { }
		public TLChannelAdminLogEventActionUpdatePinned(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelAdminLogEventActionUpdatePinned; } }

		public override void Read(TLBinaryReader from)
		{
			Message = TLFactory.Read<TLMessageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE9E82C18);
			to.WriteObject(Message);
		}
	}
}