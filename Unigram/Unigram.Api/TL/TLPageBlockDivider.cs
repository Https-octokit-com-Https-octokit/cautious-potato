// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockDivider : TLPageBlockBase 
	{
		public TLPageBlockDivider() { }
		public TLPageBlockDivider(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockDivider; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDB20B188);
		}
	}
}