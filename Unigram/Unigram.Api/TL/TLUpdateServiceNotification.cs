// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateServiceNotification : TLUpdateBase 
	{
		public String Type { get; set; }
		public String Message { get; set; }
		public TLMessageMediaBase Media { get; set; }
		public Boolean Popup { get; set; }

		public TLUpdateServiceNotification() { }
		public TLUpdateServiceNotification(TLBinaryReader from, TLType type = TLType.UpdateServiceNotification)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateServiceNotification; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateServiceNotification)
		{
			Type = from.ReadString();
			Message = from.ReadString();
			Media = TLFactory.Read<TLMessageMediaBase>(from);
			Popup = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x382DD3E4);
			to.Write(Type);
			to.Write(Message);
			to.WriteObject(Media);
			to.Write(Popup);
		}
	}
}