// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelParticipantsBots : TLChannelParticipantsFilterBase 
	{
		public TLChannelParticipantsBots() { }
		public TLChannelParticipantsBots(TLBinaryReader from, TLType type = TLType.ChannelParticipantsBots)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChannelParticipantsBots; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChannelParticipantsBots)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xB0D1865B);
		}
	}
}