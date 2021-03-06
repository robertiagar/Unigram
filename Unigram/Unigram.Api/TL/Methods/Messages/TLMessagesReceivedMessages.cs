// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.receivedMessages
	/// </summary>
	public partial class TLMessagesReceivedMessages : TLObject
	{
		public Int32 MaxId { get; set; }

		public TLMessagesReceivedMessages() { }
		public TLMessagesReceivedMessages(TLBinaryReader from, TLType type = TLType.MessagesReceivedMessages)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesReceivedMessages; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesReceivedMessages)
		{
			MaxId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5A954C0);
			to.Write(MaxId);
		}
	}
}