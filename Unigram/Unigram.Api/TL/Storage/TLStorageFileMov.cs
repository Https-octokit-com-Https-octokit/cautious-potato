// <auto-generated/>
using System;

namespace Telegram.Api.TL.Storage
{
	public partial class TLStorageFileMov : TLStorageFileTypeBase 
	{
		public TLStorageFileMov() { }
		public TLStorageFileMov(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.StorageFileMov; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4B09EBBC);
		}
	}
}