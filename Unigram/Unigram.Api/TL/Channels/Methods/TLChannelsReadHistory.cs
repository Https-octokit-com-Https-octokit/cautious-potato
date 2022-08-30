// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Channels.Methods
{
	/// <summary>
	/// RCP method channels.readHistory.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLChannelsReadHistory : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public Int32 MaxId { get; set; }

		public TLChannelsReadHistory() { }
		public TLChannelsReadHistory(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsReadHistory; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			MaxId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
			to.WriteInt32(MaxId);
		}
	}
}