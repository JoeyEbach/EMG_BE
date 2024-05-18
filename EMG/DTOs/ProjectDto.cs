using System.ComponentModel.DataAnnotations;

namespace EMG.DTOs;

	public class ProjectDto
	{
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public int ProducerId { get; set; }
        public List<int> ProducerServiceIds { get; set; }
        public int KeyId { get; set; }
        public int Bpm { get; set; }
        public string Notes { get; set; }
        public string Lyric { get; set; }
        public string Worktape { get; set; }
        public int PaymentTypeId { get; set; }
    }

