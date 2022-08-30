// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTextFixed : TLRichTextBase 
	{
		public TLRichTextBase Text { get; set; }

		public TLTextFixed() { }
		public TLTextFixed(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TextFixed; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6C3F19B9);
			to.WriteObject(Text);
		}
	}
}