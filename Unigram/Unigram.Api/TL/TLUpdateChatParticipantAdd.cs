// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChatParticipantAdd : TLUpdateBase 
	{
		public Int32 ChatId { get; set; }
		public Int32 UserId { get; set; }
		public Int32 InviterId { get; set; }
		public Int32 Date { get; set; }
		public Int32 Version { get; set; }

		public TLUpdateChatParticipantAdd() { }
		public TLUpdateChatParticipantAdd(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateChatParticipantAdd; } }

		public override void Read(TLBinaryReader from)
		{
			ChatId = from.ReadInt32();
			UserId = from.ReadInt32();
			InviterId = from.ReadInt32();
			Date = from.ReadInt32();
			Version = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(ChatId);
			to.WriteInt32(UserId);
			to.WriteInt32(InviterId);
			to.WriteInt32(Date);
			to.WriteInt32(Version);
		}
	}
}