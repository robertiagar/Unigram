// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLNotifyAll : TLNotifyPeerBase 
	{
		public TLNotifyAll() { }
		public TLNotifyAll(TLBinaryReader from, TLType type = TLType.NotifyAll)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.NotifyAll; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.NotifyAll)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x74D07C60);
		}
	}
}