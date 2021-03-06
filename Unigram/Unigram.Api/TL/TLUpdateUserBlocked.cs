// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateUserBlocked : TLUpdateBase 
	{
		public Int32 UserId { get; set; }
		public Boolean Blocked { get; set; }

		public TLUpdateUserBlocked() { }
		public TLUpdateUserBlocked(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateUserBlocked; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			UserId = from.ReadInt32();
			Blocked = from.ReadBoolean();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x80ECE81A);
			to.Write(UserId);
			to.Write(Blocked);
			if (cache) WriteToCache(to);
		}
	}
}