// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputPeerChat : TLInputPeerBase 
	{
		public Int32 ChatId { get; set; }

		public TLInputPeerChat() { }
		public TLInputPeerChat(TLBinaryReader from, TLType type = TLType.InputPeerChat)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputPeerChat; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputPeerChat)
		{
			ChatId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x179BE863);
			to.Write(ChatId);
		}
	}
}