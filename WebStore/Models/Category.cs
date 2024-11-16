using System;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
	public class Category
	{
		[Key]
		public int ID { get; set; }
		public string? Name { get; set; }
		public string? Image { get; set; }
	}
}

