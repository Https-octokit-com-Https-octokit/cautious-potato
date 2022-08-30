// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonCallback : TLKeyboardButtonBase 
	{
		public Byte[] Data { get; set; }

		public TLKeyboardButtonCallback() { }
		public TLKeyboardButtonCallback(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonCallback; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
			Data = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x683A5E46);
			to.Write(Text);
			to.WriteByteArray(Data);
		}
	}
}