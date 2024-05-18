using Microsoft.EntityFrameworkCore;
using EMG.Models;

namespace EMG.Controllers
{
	public class PaymentTypeApi
	{
		public static void Map(WebApplication app)
		{
			//get all payment types
			app.MapGet("/payment-types", (EMGDbContext db) =>
			{
				return db.PaymentTypes.ToList();
			});

		}
	}
}

