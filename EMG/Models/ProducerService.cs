using System.ComponentModel.DataAnnotations;

namespace EMG.Models;

	public class ProducerService
	{
        public int Id { get; set; }
        public int ProducerId { get; set; }
        public User Producer { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
        public ICollection<Project> Projects { get; set; }
    }

