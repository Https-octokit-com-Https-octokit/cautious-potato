// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.updatePasswordSettings.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLAccountUpdatePasswordSettings : TLObject
	{
		public Byte[] CurrentPasswordHash { get; set; }
		public TLAccountPasswordInputSettings NewSettings { get; set; }

		public TLAccountUpdatePasswordSettings() { }
		public TLAccountUpdatePasswordSettings(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountUpdatePasswordSettings; } }

		public override void Read(TLBinaryReader from)
		{
			CurrentPasswordHash = from.ReadByteArray();
			NewSettings = TLFactory.Read<TLAccountPasswordInputSettings>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xFA7C4B86);
			to.WriteByteArray(CurrentPasswordHash);
			to.WriteObject(NewSettings);
		}
	}
}