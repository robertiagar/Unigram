// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateReadMessagesContents : TLUpdateBase, ITLMultiPts 
	{

		public TLUpdateReadMessagesContents() { }
		public TLUpdateReadMessagesContents(TLBinaryReader from, TLType type = TLType.UpdateReadMessagesContents)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateReadMessagesContents; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateReadMessagesContents)
		{
			Messages = TLFactory.Read<TLVector<Int32>>(from);
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x68C13933);
			to.WriteObject(Messages);
			to.Write(Pts);
			to.Write(PtsCount);
		}
	}
}