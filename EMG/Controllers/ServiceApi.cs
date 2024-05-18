using Microsoft.EntityFrameworkCore;
using EMG.Models;

namespace EMG.Controllers
{
	public class ServiceApi
	{
		public static void Map(WebApplication app)
		{
			//get all services
			app.MapGet("/services", (EMGDbContext db) =>
			{
				return db.Services.ToList();
			});

		}
	}
}

