// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.saveRecentSticker.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesSaveRecentSticker : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Attached = (1 << 0),
		}

		public bool IsAttached { get { return Flags.HasFlag(Flag.Attached); } set { Flags = value ? (Flags | Flag.Attached) : (Flags & ~Flag.Attached); } }

		public Flag Flags { get; set; }
		public TLInputDocumentBase Id { get; set; }
		public Boolean Unsave { get; set; }

		public TLMessagesSaveRecentSticker() { }
		public TLMessagesSaveRecentSticker(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSaveRecentSticker; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Id = TLFactory.Read<TLInputDocumentBase>(from);
			Unsave = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x392718F8);
			to.Write((Int32)Flags);
			to.WriteObject(Id);
			to.Write(Unsave);
		}
	}
}