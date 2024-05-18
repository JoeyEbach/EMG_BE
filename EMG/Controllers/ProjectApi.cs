using Microsoft.EntityFrameworkCore;
using EMG.Models;
using EMG.DTOs;

namespace EMG.Controllers
{
	public class ProjectApi
	{
		public static void Map(WebApplication app)
		{
			//get projects by producerId
			app.MapGet("/projects/producer/{producerId}", (EMGDbContext db, int producerId) =>
			{
				return db.Projects
						.Include(p => p.Producer)
						.Include(p => p.ProducerServices)
						.ThenInclude(ps => ps.Service)
						.Include(p => p.Key)
						.Where(p => p.ProducerId == producerId)
						.ToList();
			});

			//get projects by customerId
			app.MapGet("/projects/customer/{customerId}", (EMGDbContext db, int customerId) =>
			{
				return db.Projects
						.Include(p => p.Producer)
						.Include(p => p.ProducerServices)
						.ThenInclude(ps => ps.Service)
						.Include(p => p.Key)
						.Where(p => p.CustomerId == customerId)
						.ToList();
			});

			//get single project
			app.MapGet("/projects/{projectId}", (EMGDbContext db, int projectId) =>
			{
				return db.Projects
						.Include(p => p.Producer)
						.Include(p => p.Customer)
						.Include(p => p.ProducerServices)
						.ThenInclude(ps => ps.Service)
						.Include(p => p.Key)
						.Include(p => p.PaymentType)
						.Where(p => p.Id == projectId)
						.FirstOrDefault();
			});

			//create project
			app.MapPost("projects/new", (EMGDbContext db, ProjectDto dto) =>
			{
				var newProject = new Project
				{
					Title = dto.Title,
					CustomerId = dto.CustomerId,
					ProducerId = dto.ProducerId,
					StartDate = DateTime.Now,
					IsComplete = false,
					KeyId = dto.KeyId,
					Bpm = dto.Bpm,
					Notes = dto.Notes,
					Lyric = dto.Lyric,
					Worktape = dto.Worktape,
					PaymentTypeId = dto.PaymentTypeId
				};

				db.Projects.Add(newProject);

				foreach (var psId in dto.ProducerServiceIds)
				{
					var Service = db.ProducerServices.Find(psId);
					if (Service != null)
					{
						newProject.ProducerServices.Add(Service);
					}	
				}

				db.SaveChanges();
				return Results.Created($"/projects/new/{newProject.Id}", newProject);
			});

			//update project
			app.MapPut("/projects/update/{projectId}", (EMGDbContext db, int projectId, ProjectDto dto) =>
			{
				var thisProject = db.Projects
								.Include(p => p.ProducerServices)
								.FirstOrDefault(p => p.Id == projectId);

				if (thisProject == null)
				{
					return Results.NotFound();
				}

				thisProject.CustomerId = dto.CustomerId;
				thisProject.Title = dto.Title;
				thisProject.ProducerId = dto.ProducerId;
				thisProject.KeyId = dto.KeyId;
				thisProject.Bpm = dto.Bpm;
				thisProject.Notes = dto.Notes;
				thisProject.Lyric = dto.Lyric;
				thisProject.Worktape = dto.Worktape;
				thisProject.PaymentTypeId = dto.PaymentTypeId;

				thisProject.ProducerServices.Clear();

				foreach (var psId in dto.ProducerServiceIds)
				{
					var service = db.ProducerServices.Find(psId);
					if (service != null)
					{
						thisProject.ProducerServices.Add(service);
					}
				}

				db.SaveChanges();
				return Results.Ok(thisProject);
			});

			//delete project
			app.MapDelete("/projects/delete/{projectId}", (EMGDbContext db, int projectId) =>
			{
				var thisProject = db.Projects
								.Include(p => p.ProducerServices)
								.FirstOrDefault(p => p.Id == projectId);
				if (thisProject == null)
				{
					return Results.NotFound();
				}
				db.Projects.Remove(thisProject);
				db.SaveChanges();
				return Results.NoContent();
			});
		}
	}
}

