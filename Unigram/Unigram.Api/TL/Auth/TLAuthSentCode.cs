// <auto-generated/>
using System;

using Telegram.Api.TL.Auth;

namespace Telegram.Api.TL.Auth
{
	public partial class TLAuthSentCode : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			PhoneRegistered = (1 << 0),
			NextType = (1 << 1),
			Timeout = (1 << 2),
		}

		public bool IsPhoneRegistered { get { return Flags.HasFlag(Flag.PhoneRegistered); } set { Flags = value ? (Flags | Flag.PhoneRegistered) : (Flags & ~Flag.PhoneRegistered); } }
		public bool HasNextType { get { return Flags.HasFlag(Flag.NextType); } set { Flags = value ? (Flags | Flag.NextType) : (Flags & ~Flag.NextType); } }
		public bool HasTimeout { get { return Flags.HasFlag(Flag.Timeout); } set { Flags = value ? (Flags | Flag.Timeout) : (Flags & ~Flag.Timeout); } }

		public Flag Flags { get; set; }
		public TLAuthSentCodeTypeBase Type { get; set; }
		public String PhoneCodeHash { get; set; }
		public TLAuthCodeTypeBase NextType { get; set; }
		public Int32? Timeout { get; set; }

		public TLAuthSentCode() { }

		

	}
}