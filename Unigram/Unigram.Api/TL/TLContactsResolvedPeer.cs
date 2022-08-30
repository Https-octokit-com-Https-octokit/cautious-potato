// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLContactsResolvedPeer : TLObject 
	{
		public TLPeerBase Peer { get; set; }
		public TLVector<TLChatBase> Chats { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLContactsResolvedPeer() { }
		public TLContactsResolvedPeer(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsResolvedPeer; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLPeerBase>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x7F077AD9);
			to.WriteObject(Peer);
			to.WriteObject(Chats);
			to.WriteObject(Users);
		}
	}
}