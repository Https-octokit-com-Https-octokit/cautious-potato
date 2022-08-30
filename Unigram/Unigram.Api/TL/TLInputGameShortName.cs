// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputGameShortName : TLInputGameBase 
	{
		public TLInputUserBase BotId { get; set; }
		public String ShortName { get; set; }

		public TLInputGameShortName() { }
		public TLInputGameShortName(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputGameShortName; } }

		public override void Read(TLBinaryReader from)
		{
			BotId = TLFactory.Read<TLInputUserBase>(from);
			ShortName = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(BotId);
			to.WriteString(ShortName ?? string.Empty);
		}
	}
}