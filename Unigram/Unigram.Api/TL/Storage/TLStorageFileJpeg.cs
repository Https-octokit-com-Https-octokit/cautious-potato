// <auto-generated/>
using System;

namespace Telegram.Api.TL.Storage
{
	public partial class TLStorageFileJpeg : TLStorageFileTypeBase 
	{
		public TLStorageFileJpeg() { }
		public TLStorageFileJpeg(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.StorageFileJpeg; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x7EFE0E);
		}
	}
}