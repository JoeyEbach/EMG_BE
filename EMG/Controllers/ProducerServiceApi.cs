using Microsoft.EntityFrameworkCore;
using EMG.Models;
using EMG.DTOs;

namespace EMG.Controllers
{
	public class ProducerServiceApi
	{
		public static void Map(WebApplication app)
		{

			//get producer services by producerId
			app.MapGet("/producer_services/{producerId}", (EMGDbContext db, int producerId) =>
			{
				return db.ProducerServices
						.Include(ps => ps.Service)
						.Include(ps => ps.Producer)
						.Where(ps => ps.Id == producerId && ps.Active == true)
						.ToList();
			});

			//create producer service
			app.MapPost("/producer_services/new", (EMGDbContext db, ProducerServiceDto dto) =>
			{
				var newProducerService = new ProducerService
				{
					ProducerId = dto.ProducerId,
					ServiceId = dto.ServiceId,
					Price = dto.Price,
					Active = true
				};

				db.ProducerServices.Add(newProducerService);
				db.SaveChanges();
				return Results.Created($"/producer_services/new/{newProducerService.Id}", newProducerService);
			});

			//remove producer service
			app.MapGet("/producer_services/remove/{producerServiceId}", (EMGDbContext db, int producerServiceId) =>
			{
				var thisProducerService = db.ProducerServices.FirstOrDefault(ps => ps.Id == producerServiceId);
				if (thisProducerService == null)
				{
					return Results.NotFound();
				}
				thisProducerService.Active = false;
				db.SaveChanges();
				return Results.NoContent();
			});
		}
	}
}

