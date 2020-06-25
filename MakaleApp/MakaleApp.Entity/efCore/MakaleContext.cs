using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakaleApp.Entity.efCore
{
	public class MakaleContext :DbContext
	{
		public MakaleContext(DbContextOptions<MakaleContext> options) : base(options)
		{

		}
		public DbSet<Makale> Makales { get; set; }
	}
}
