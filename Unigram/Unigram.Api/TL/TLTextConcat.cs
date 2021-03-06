// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTextConcat : TLRichTextBase 
	{
		public TLVector<TLRichTextBase> Texts { get; set; }

		public TLTextConcat() { }
		public TLTextConcat(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.TextConcat; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Texts = TLFactory.Read<TLVector<TLRichTextBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x7E6260D7);
			to.WriteObject(Texts, cache);
			if (cache) WriteToCache(to);
		}
	}
}