using System.ComponentModel.DataAnnotations;

namespace EMG.Models;

	public class User
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public bool IsProducer { get; set; }
        public string Uid { get; set; }
        public List<ProducerService> ProducerServices { get; set; }
    }

