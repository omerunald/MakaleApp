using System;
using System.Collections.Generic;
using System.Text;

namespace MakaleApp.Entity.efCore
{
	public class Makale
	{
		public int Id { get; set; }
		public string Baslik { get; set; }
		public string Icerik { get; set; }
		public DateTime EklenmeTarihi { get; set; }
		public DateTime GuncellenmeTarihi { get; set; }
		public bool AktifMi { get; set; }
	}
}
