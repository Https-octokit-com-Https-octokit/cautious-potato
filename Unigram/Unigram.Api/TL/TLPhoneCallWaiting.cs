// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPhoneCallWaiting : TLPhoneCallBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			ReceiveDate = (1 << 0),
		}

		public bool HasReceiveDate { get { return Flags.HasFlag(Flag.ReceiveDate); } set { Flags = value ? (Flags | Flag.ReceiveDate) : (Flags & ~Flag.ReceiveDate); } }

		public Flag Flags { get; set; }
		public Int64 AccessHash { get; set; }
		public Int32 Date { get; set; }
		public Int32 AdminId { get; set; }
		public Int32 ParticipantId { get; set; }
		public TLPhoneCallProtocol Protocol { get; set; }
		public Int32? ReceiveDate { get; set; }

		public TLPhoneCallWaiting() { }
		public TLPhoneCallWaiting(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhoneCallWaiting; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			Date = from.ReadInt32();
			AdminId = from.ReadInt32();
			ParticipantId = from.ReadInt32();
			Protocol = TLFactory.Read<TLPhoneCallProtocol>(from);
			if (HasReceiveDate) ReceiveDate = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x1B8F4AD1);
			to.Write((Int32)Flags);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Date);
			to.Write(AdminId);
			to.Write(ParticipantId);
			to.WriteObject(Protocol);
			if (HasReceiveDate) to.Write(ReceiveDate.Value);
		}

		private void UpdateFlags()
		{
			HasReceiveDate = ReceiveDate != null;
		}
	}
}