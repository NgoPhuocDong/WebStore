using System;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
	public class Banner
	{
		[Key]
		public int ID { get; set; }
		public string? Title { get; set; }
		public string? Link { get; set; }
		public string? Image { get; set; }
		public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
    }
}

