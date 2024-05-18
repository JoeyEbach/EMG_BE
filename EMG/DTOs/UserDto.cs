using System.ComponentModel.DataAnnotations;
using EMG.Models;

namespace EMG.DTOs;

	public class UserDto
	{
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public bool IsProducer { get; set; }
        public string Uid { get; set; }
}

