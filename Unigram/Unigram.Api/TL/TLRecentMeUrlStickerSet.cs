// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLRecentMeUrlStickerSet : TLRecentMeUrlBase 
	{
		public TLStickerSetCoveredBase Set { get; set; }

		public TLRecentMeUrlStickerSet() { }
		public TLRecentMeUrlStickerSet(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.RecentMeUrlStickerSet; } }

		public override void Read(TLBinaryReader from)
		{
			Url = from.ReadString();
			Set = TLFactory.Read<TLStickerSetCoveredBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBC0A57DC);
			to.Write(Url);
			to.WriteObject(Set);
		}
	}
}