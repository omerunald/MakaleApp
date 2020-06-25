using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakaleApp.Entity.efCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MakaleApp.WebUI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private IMakaleRepository repository;
		public ValuesController(IMakaleRepository _repo)
		{
			repository = _repo;
		}

		[HttpGet]
		public IEnumerable<Makale> Get()
		{
			return repository.Get;
		}

		[HttpGet("{id}")]
		public Makale Get(int id)
		{
			return repository.GetMakaleById(id);
		}

		[HttpPut]
		public void Put(Makale _makale)
		{
			repository.UpdateMakale(_makale);

		}

		[HttpPost]
		public void Post([FromBody] Makale makale)
		{
			repository.AddMakale(makale);
		}

		// PUT api/<ValuesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Makale makale)
		{
			repository.UpdateMakale(makale);
		}

		// DELETE api/<ValuesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			repository.DeleteMakale(id);
		}
	}
}
