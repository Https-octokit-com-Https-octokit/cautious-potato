// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesArchivedStickers : TLObject 
	{
		public Int32 Count { get; set; }
		public TLVector<TLStickerSetCoveredBase> Sets { get; set; }

		public TLMessagesArchivedStickers() { }
		public TLMessagesArchivedStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesArchivedStickers; } }

		public override void Read(TLBinaryReader from)
		{
			Count = from.ReadInt32();
			Sets = TLFactory.Read<TLVector<TLStickerSetCoveredBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4FCBA9C8);
			to.Write(Count);
			to.WriteObject(Sets);
		}
	}
}