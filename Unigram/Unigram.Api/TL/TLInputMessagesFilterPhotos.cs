// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMessagesFilterPhotos : TLMessagesFilterBase 
	{
		public TLInputMessagesFilterPhotos() { }
		public TLInputMessagesFilterPhotos(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMessagesFilterPhotos; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9609A51C);
		}
	}
}