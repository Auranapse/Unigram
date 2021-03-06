// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.leaveChannel
	/// </summary>
	public partial class TLChannelsLeaveChannel : TLObject
	{
		public TLInputChannelBase Channel { get; set; }

		public TLChannelsLeaveChannel() { }
		public TLChannelsLeaveChannel(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ChannelsLeaveChannel; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xF836AA95);
			to.WriteObject(Channel, cache);
			if (cache) WriteToCache(to);
		}
	}
}