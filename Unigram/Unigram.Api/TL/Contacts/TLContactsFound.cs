// <auto-generated/>
using System;

namespace Telegram.Api.TL.Contacts
{
	public partial class TLContactsFound : TLObject 
	{
		public TLVector<TLPeerBase> Results { get; set; }
		public TLVector<TLChatBase> Chats { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLContactsFound() { }
		public TLContactsFound(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsFound; } }

		public override void Read(TLBinaryReader from)
		{
			Results = TLFactory.Read<TLVector<TLPeerBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1AA1F784);
			to.WriteObject(Results);
			to.WriteObject(Chats);
			to.WriteObject(Users);
		}
	}
}