using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakaleApp.Entity.efCore
{
	public interface IMakaleRepository
	{
		IQueryable<Makale> Get { get; }
		Makale GetMakaleById(int id);
		void AddMakale(Makale makale);
		void UpdateMakale(Makale makale);
		void DeleteMakale(int id);
	}
}
