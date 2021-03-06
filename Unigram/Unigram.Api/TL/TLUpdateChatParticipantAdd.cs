// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChatParticipantAdd : TLUpdateBase 
	{
		public Int32 InviterId { get; set; }

		public TLUpdateChatParticipantAdd() { }
		public TLUpdateChatParticipantAdd(TLBinaryReader from, TLType type = TLType.UpdateChatParticipantAdd)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateChatParticipantAdd; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateChatParticipantAdd)
		{
			ChatId = from.ReadInt32();
			UserId = from.ReadInt32();
			InviterId = from.ReadInt32();
			Date = from.ReadInt32();
			Version = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xEA4B0E5C);
			to.Write(ChatId);
			to.Write(UserId);
			to.Write(InviterId);
			to.Write(Date);
			to.Write(Version);
		}
	}
}