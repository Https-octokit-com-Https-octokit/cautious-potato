// <auto-generated/>
using System;

namespace Telegram.Api.TL.Contacts.Methods
{
	/// <summary>
	/// RCP method contacts.importContacts.
	/// Returns <see cref="Telegram.Api.TL.TLContactsImportedContacts"/>
	/// </summary>
	public partial class TLContactsImportContacts : TLObject
	{
		public TLVector<TLInputContactBase> Contacts { get; set; }

		public TLContactsImportContacts() { }
		public TLContactsImportContacts(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsImportContacts; } }

		public override void Read(TLBinaryReader from)
		{
			Contacts = TLFactory.Read<TLVector<TLInputContactBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2C800BE5);
			to.WriteObject(Contacts);
		}
	}
}