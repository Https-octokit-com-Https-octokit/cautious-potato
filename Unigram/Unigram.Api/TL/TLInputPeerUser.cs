// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputPeerUser : TLInputPeerBase 
	{
		public Int32 UserId { get; set; }
		public Int64 AccessHash { get; set; }

		public TLInputPeerUser() { }
		public TLInputPeerUser(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPeerUser; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
			AccessHash = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x7B8E7DE6);
			to.Write(UserId);
			to.Write(AccessHash);
		}
	}
}