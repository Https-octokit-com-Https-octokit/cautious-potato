// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getPeerSettings.
	/// Returns <see cref="Telegram.Api.TL.TLPeerSettings"/>
	/// </summary>
	public partial class TLMessagesGetPeerSettings : TLObject
	{
		public TLInputPeerBase Peer { get; set; }

		public TLMessagesGetPeerSettings() { }
		public TLMessagesGetPeerSettings(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetPeerSettings; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3672E09C);
			to.WriteObject(Peer);
		}
	}
}