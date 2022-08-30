// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.setBotCallbackAnswer.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesSetBotCallbackAnswer : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Alert = (1 << 1),
			Message = (1 << 0),
			Url = (1 << 2),
		}

		public bool IsAlert { get { return Flags.HasFlag(Flag.Alert); } set { Flags = value ? (Flags | Flag.Alert) : (Flags & ~Flag.Alert); } }
		public bool HasMessage { get { return Flags.HasFlag(Flag.Message); } set { Flags = value ? (Flags | Flag.Message) : (Flags & ~Flag.Message); } }
		public bool HasUrl { get { return Flags.HasFlag(Flag.Url); } set { Flags = value ? (Flags | Flag.Url) : (Flags & ~Flag.Url); } }

		public Flag Flags { get; set; }
		public Int64 QueryId { get; set; }
		public String Message { get; set; }
		public String Url { get; set; }
		public Int32 CacheTime { get; set; }

		public TLMessagesSetBotCallbackAnswer() { }
		public TLMessagesSetBotCallbackAnswer(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSetBotCallbackAnswer; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			QueryId = from.ReadInt64();
			if (HasMessage) Message = from.ReadString();
			if (HasUrl) Url = from.ReadString();
			CacheTime = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xD58F130A);
			to.Write((Int32)Flags);
			to.Write(QueryId);
			if (HasMessage) to.Write(Message);
			if (HasUrl) to.Write(Url);
			to.Write(CacheTime);
		}

		private void UpdateFlags()
		{
			HasMessage = Message != null;
			HasUrl = Url != null;
		}
	}
}