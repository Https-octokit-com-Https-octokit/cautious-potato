// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLSendMessageRecordAudioAction : TLSendMessageActionBase 
	{
		public TLSendMessageRecordAudioAction() { }
		public TLSendMessageRecordAudioAction(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.SendMessageRecordAudioAction; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xD52F73F7);
		}
	}
}