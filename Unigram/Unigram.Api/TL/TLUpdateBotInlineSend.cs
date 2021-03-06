// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateBotInlineSend : TLUpdateBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Geo = (1 << 0),
			MsgId = (1 << 1),
		}

		public bool HasGeo { get { return Flags.HasFlag(Flag.Geo); } set { Flags = value ? (Flags | Flag.Geo) : (Flags & ~Flag.Geo); } }
		public bool HasMsgId { get { return Flags.HasFlag(Flag.MsgId); } set { Flags = value ? (Flags | Flag.MsgId) : (Flags & ~Flag.MsgId); } }

		public Flag Flags { get; set; }
		public String Id { get; set; }

		public TLUpdateBotInlineSend() { }
		public TLUpdateBotInlineSend(TLBinaryReader from, TLType type = TLType.UpdateBotInlineSend)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateBotInlineSend; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateBotInlineSend)
		{
			Flags = (Flag)from.ReadInt32();
			UserId = from.ReadInt32();
			Query = from.ReadString();
			if (HasGeo) { Geo = TLFactory.Read<TLGeoPointBase>(from); }
			Id = from.ReadString();
			if (HasMsgId) { MsgId = TLFactory.Read<TLInputBotInlineMessageID>(from); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE48F964);
			to.Write((Int32)Flags);
			to.Write(UserId);
			to.Write(Query);
			if (HasGeo) to.WriteObject(Geo);
			to.Write(Id);
			if (HasMsgId) to.WriteObject(MsgId);
		}
	}
}