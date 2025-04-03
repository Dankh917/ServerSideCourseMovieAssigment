using Microsoft.AspNetCore.Mvc;
using ServerSideHW1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerSideHW1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MovieController : ControllerBase
	{
		// GET: api/<MovieController>
		[HttpGet]
		public IEnumerable<Movie> Get()
		{
			return Movie.Read();
		}
		
		[HttpGet ("searchByTitle")]
		public IEnumerable<Movie> GetByTitle(string title)
		{
			return Movie.GetByTitle(title);
		}
		
		[HttpGet ("searchByReleaseDate/startDate/{startDate}/endDate/{endDate}")]
		public IEnumerable<Movie> GetByReleaseDate(DateTime startDate, DateTime endDate)
		{
			return Movie.GetByReleaseDate(startDate, endDate);
		}

		// GET api/<MovieController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<MovieController>
		[HttpPost]
		public bool Post([FromBody] Movie movie)
		{
			return movie.Insert();
		}

		// PUT api/<MovieController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<MovieController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			Movie.DeleteMovie(id);
		}
	}
}
