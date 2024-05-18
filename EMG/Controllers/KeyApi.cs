using Microsoft.EntityFrameworkCore;
using EMG.Models;


namespace EMG.Controllers
{
	public class KeyApi
	{
		 public static void Map(WebApplication app)
		{
			//get all keys
			app.MapGet("/keys", (EMGDbContext db) =>
			{
				return db.Keys.ToList();
			});
		}
	}
}

