// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockPhoto : TLPageBlockBase 
	{
		public Int64 PhotoId { get; set; }
		public TLRichTextBase Caption { get; set; }

		public TLPageBlockPhoto() { }
		public TLPageBlockPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			PhotoId = from.ReadInt64();
			Caption = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE9C69982);
			to.Write(PhotoId);
			to.WriteObject(Caption);
		}
	}
}