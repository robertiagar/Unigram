// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLSendMessageRecordVideoAction : TLSendMessageActionBase 
	{
		public TLSendMessageRecordVideoAction() { }
		public TLSendMessageRecordVideoAction(TLBinaryReader from, TLType type = TLType.SendMessageRecordVideoAction)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.SendMessageRecordVideoAction; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.SendMessageRecordVideoAction)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA187D66F);
		}
	}
}