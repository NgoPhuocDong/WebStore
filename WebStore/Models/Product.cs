using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebStore.Models
{
	public class Product
	{
		[Key]
		public int ID { get; set; }
		public string ?Name { get; set; }
		public string? Description { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }
		public string ?Image { get; set; }
		public bool Active { get; set; }

        [ForeignKey("Category")]
        public int idCategory { get; set; }
        public Category? Category { get; set; }
    }
}

