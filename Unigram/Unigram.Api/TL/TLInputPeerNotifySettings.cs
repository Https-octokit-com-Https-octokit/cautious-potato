// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputPeerNotifySettings : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			ShowPreviews = (1 << 0),
			Silent = (1 << 1),
		}

		public bool IsShowPreviews { get { return Flags.HasFlag(Flag.ShowPreviews); } set { Flags = value ? (Flags | Flag.ShowPreviews) : (Flags & ~Flag.ShowPreviews); } }
		public bool IsSilent { get { return Flags.HasFlag(Flag.Silent); } set { Flags = value ? (Flags | Flag.Silent) : (Flags & ~Flag.Silent); } }

		public Flag Flags { get; set; }
		public Int32 MuteUntil { get; set; }
		public String Sound { get; set; }

		public TLInputPeerNotifySettings() { }
		public TLInputPeerNotifySettings(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPeerNotifySettings; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			MuteUntil = from.ReadInt32();
			Sound = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x38935EB2);
			to.Write((Int32)Flags);
			to.Write(MuteUntil);
			to.Write(Sound);
		}
	}
}