// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaDocument : TLInputMediaBase, ITLMediaCaption 
	{
		public TLInputDocumentBase Id { get; set; }
		public String Caption { get; set; }

		public TLInputMediaDocument() { }
		public TLInputMediaDocument(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputMediaDocument; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = TLFactory.Read<TLInputDocumentBase>(from, cache);
			Caption = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x1A77F29C);
			to.WriteObject(Id, cache);
			to.Write(Caption);
			if (cache) WriteToCache(to);
		}
	}
}