// <auto-generated/>
using System;


namespace Telegram.Api.TL.Payments
{
	public partial class TLPaymentsPaymentForm : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			CanSaveCredentials = (1 << 2),
			PasswordMissing = (1 << 3),
			NativeProvider = (1 << 4),
			NativeParams = (1 << 4),
			SavedInfo = (1 << 0),
			SavedCredentials = (1 << 1),
		}

		public bool IsCanSaveCredentials { get { return Flags.HasFlag(Flag.CanSaveCredentials); } set { Flags = value ? (Flags | Flag.CanSaveCredentials) : (Flags & ~Flag.CanSaveCredentials); } }
		public bool IsPasswordMissing { get { return Flags.HasFlag(Flag.PasswordMissing); } set { Flags = value ? (Flags | Flag.PasswordMissing) : (Flags & ~Flag.PasswordMissing); } }
		public bool HasNativeProvider { get { return Flags.HasFlag(Flag.NativeProvider); } set { Flags = value ? (Flags | Flag.NativeProvider) : (Flags & ~Flag.NativeProvider); } }
		public bool HasNativeParams { get { return Flags.HasFlag(Flag.NativeParams); } set { Flags = value ? (Flags | Flag.NativeParams) : (Flags & ~Flag.NativeParams); } }
		public bool HasSavedInfo { get { return Flags.HasFlag(Flag.SavedInfo); } set { Flags = value ? (Flags | Flag.SavedInfo) : (Flags & ~Flag.SavedInfo); } }
		public bool HasSavedCredentials { get { return Flags.HasFlag(Flag.SavedCredentials); } set { Flags = value ? (Flags | Flag.SavedCredentials) : (Flags & ~Flag.SavedCredentials); } }

		public Flag Flags { get; set; }
		public Int32 BotId { get; set; }
		public TLInvoice Invoice { get; set; }
		public Int32 ProviderId { get; set; }
		public String Url { get; set; }
		public String NativeProvider { get; set; }
		public TLDataJSON NativeParams { get; set; }
		public TLPaymentRequestedInfo SavedInfo { get; set; }
		public TLPaymentSavedCredentialsBase SavedCredentials { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLPaymentsPaymentForm() { }

		

	}
}