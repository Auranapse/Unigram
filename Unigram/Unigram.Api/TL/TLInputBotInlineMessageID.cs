// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputBotInlineMessageID : TLObject 
	{
		public Int32 DCId { get; set; }
		public Int64 Id { get; set; }
		public Int64 AccessHash { get; set; }

		public TLInputBotInlineMessageID() { }
		public TLInputBotInlineMessageID(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineMessageID; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			DCId = from.ReadInt32();
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x890C3D89);
			to.Write(DCId);
			to.Write(Id);
			to.Write(AccessHash);
			if (cache) WriteToCache(to);
		}
	}
}