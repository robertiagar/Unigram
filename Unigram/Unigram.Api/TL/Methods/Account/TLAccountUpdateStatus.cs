// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.updateStatus
	/// </summary>
	public partial class TLAccountUpdateStatus : TLObject
	{
		public Boolean Offline { get; set; }

		public TLAccountUpdateStatus() { }
		public TLAccountUpdateStatus(TLBinaryReader from, TLType type = TLType.AccountUpdateStatus)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AccountUpdateStatus; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AccountUpdateStatus)
		{
			Offline = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6628562C);
			to.Write(Offline);
		}
	}
}