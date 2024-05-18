using Microsoft.EntityFrameworkCore;
using EMG.Models;
using EMG.DTOs;

namespace EMG.Controllers
{
	public class UserApi
	{
		public static void Map(WebApplication app)
		{
			//check user
			app.MapPost("/checkuser/{uid}", (EMGDbContext db, string uid) =>
			{
				var user = db.Users.Where(u => u.Uid == uid).FirstOrDefault();

				if (user == null)
				{
					return Results.NotFound("User not registered");
				}

				return Results.Ok(user);
			});

			//get all users that are producers
			app.MapGet("/users/producers", (EMGDbContext db) =>
			{
				return db.Users
						.Include(u => u.ProducerServices)
						.ThenInclude(ps => ps.Service)
						.Where(u => u.IsProducer == true)
						.ToList();
			});

			//get a single user
			app.MapGet("/users/{userId}", (EMGDbContext db, int userId) =>
			{
				return db.Users
						.Include(u => u.ProducerServices)
						.ThenInclude(ps => ps.Service)
						.FirstOrDefault(u => u.Id == userId);
			});

			//create user
			app.MapPost("/users/new", (EMGDbContext db, UserDto dto) =>
			{
			var newUser = new User
			{
				Name = dto.Name,
				Phone = dto.Phone,
				Email = dto.Email,
				Image = dto.Image,
				IsProducer = dto.IsProducer,
				Uid = dto.Uid
			};

			db.Users.Add(newUser);
			db.SaveChanges();
			return Results.Created($"/users/new/{newUser.Id}", newUser);
			});

			//update user
			app.MapPut("/users/update/{userId}", (EMGDbContext db, int userId, UserDto dto) =>
			{
				var thisUser = db.Users.FirstOrDefault(u => u.Id == userId);
				if (thisUser == null)
				{
					return Results.NotFound();
				}

				thisUser.Name = dto.Name;
				thisUser.Phone = dto.Phone;
				thisUser.Email = dto.Email;
				thisUser.Image = dto.Image;
				thisUser.IsProducer = dto.IsProducer;

				db.SaveChanges();
				return Results.Ok(thisUser);
			});

		}
	}
}

