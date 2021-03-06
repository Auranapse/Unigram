// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPhoneCallRequested : TLPhoneCallBase 
	{
		public Int64 AccessHash { get; set; }
		public Int32 Date { get; set; }
		public Int32 AdminId { get; set; }
		public Int32 ParticipantId { get; set; }
		public Byte[] GA { get; set; }
		public TLPhoneCallProtocol Protocol { get; set; }

		public TLPhoneCallRequested() { }
		public TLPhoneCallRequested(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PhoneCallRequested; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			Date = from.ReadInt32();
			AdminId = from.ReadInt32();
			ParticipantId = from.ReadInt32();
			GA = from.ReadByteArray();
			Protocol = TLFactory.Read<TLPhoneCallProtocol>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x6C448AE8);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Date);
			to.Write(AdminId);
			to.Write(ParticipantId);
			to.WriteByteArray(GA);
			to.WriteObject(Protocol, cache);
			if (cache) WriteToCache(to);
		}
	}
}