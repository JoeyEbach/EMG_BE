using System.ComponentModel.DataAnnotations;

namespace EMG.Models;

	public class Project
	{
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public User Customer { get; set; }
        public int ProducerId { get; set; }
        public User Producer { get; set; }
        public ICollection<ProducerService> ProducerServices { get; set; }
        public DateTime StartDate { get; set; }
        public string CompleteDate { get; set; }
        public bool IsComplete { get; set; }
        public int KeyId { get; set; }
        public Key Key { get; set; }
        public int Bpm { get; set; }
        public string Notes { get; set; }
        public string Lyric { get; set; }
        public string Worktape { get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }
    }

