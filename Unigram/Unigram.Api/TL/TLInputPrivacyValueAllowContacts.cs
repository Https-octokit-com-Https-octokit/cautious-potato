// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputPrivacyValueAllowContacts : TLInputPrivacyRuleBase 
	{
		public TLInputPrivacyValueAllowContacts() { }
		public TLInputPrivacyValueAllowContacts(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPrivacyValueAllowContacts; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xD09E07B);
		}
	}
}