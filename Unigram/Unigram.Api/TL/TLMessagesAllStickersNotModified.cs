// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesAllStickersNotModified : TLMessagesAllStickersBase 
	{
		public TLMessagesAllStickersNotModified() { }
		public TLMessagesAllStickersNotModified(TLBinaryReader from, TLType type = TLType.MessagesAllStickersNotModified)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesAllStickersNotModified; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesAllStickersNotModified)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE86602C3);
		}
	}
}