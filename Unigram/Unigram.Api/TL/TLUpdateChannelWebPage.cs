// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChannelWebPage : TLUpdateBase, ITLMultiPts 
	{
		public Int32 ChannelId { get; set; }
		public TLWebPageBase Webpage { get; set; }
		public Int32 Pts { get; set; }
		public Int32 PtsCount { get; set; }

		public TLUpdateChannelWebPage() { }
		public TLUpdateChannelWebPage(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateChannelWebPage; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			ChannelId = from.ReadInt32();
			Webpage = TLFactory.Read<TLWebPageBase>(from, cache);
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x40771900);
			to.Write(ChannelId);
			to.WriteObject(Webpage, cache);
			to.Write(Pts);
			to.Write(PtsCount);
			if (cache) WriteToCache(to);
		}
	}
}