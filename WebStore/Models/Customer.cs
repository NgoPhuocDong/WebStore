using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebStore.Models
{
	public class Customer
	{
		[Key]
		public int ID { get; set; }
		public string ?Name { get; set; }
		public bool Gender { get; set; }
		public DateTime DateofBirth { get; set; }
		public string ?Phone { get; set; }
		public string ?Email { get; set; }
		public string ?Address { get; set; }
	}
}

