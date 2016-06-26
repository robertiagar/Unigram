// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.updateUsername
	/// </summary>
	public partial class TLChannelsUpdateUsername : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public String Username { get; set; }

		public TLChannelsUpdateUsername() { }
		public TLChannelsUpdateUsername(TLBinaryReader from, TLType type = TLType.ChannelsUpdateUsername)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChannelsUpdateUsername; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChannelsUpdateUsername)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Username = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3514B3DE);
			to.WriteObject(Channel);
			to.Write(Username);
		}
	}
}