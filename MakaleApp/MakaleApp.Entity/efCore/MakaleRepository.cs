using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakaleApp.Entity.efCore
{
	public class MakaleRepository : IMakaleRepository
	{
		private MakaleContext context;
		public MakaleRepository(MakaleContext _context)
		{
			context = _context;
		}
		IQueryable<Makale> IMakaleRepository.Get => context.Makales;

		public void AddMakale([Bind(include: "Baslik, Icerik, AktifMi")] Makale makale)
		{
			makale.EklenmeTarihi = DateTime.Now;
			makale.GuncellenmeTarihi = DateTime.Now;
			context.Makales.Add(makale);
			context.SaveChanges();
		}

		public void DeleteMakale(int id)
		{
			var delete = context.Makales.FirstOrDefault(i => i.Id == id);
			context.Makales.Remove(delete);
			context.SaveChanges();
		}

		public Makale GetMakaleById(int id)
		{
			return context.Makales.FirstOrDefault(i => i.Id == id);
		}

		public void UpdateMakale([Bind(include: "Baslik,Icerik,AktifMi")] Makale makale)
		{
			//context.Entry(makale).State = EntityState.Modified;

			var db = context.Makales.FirstOrDefault(i => i.Id == makale.Id);
			db.GuncellenmeTarihi = DateTime.Now;
			db.Baslik = makale.Baslik;
			db.Icerik = makale.Icerik;
			db.AktifMi = makale.AktifMi;
			context.SaveChanges();

		}
	}
}

