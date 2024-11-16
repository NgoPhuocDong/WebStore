using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Models
{
	public class OrderDetail
	{
		[Key]
		public int ID { get; set; }
		public int Quantity { get; set; }
		public double UnitPrice { get; set; }
		public double TotalPrice { get; set; }

		[ForeignKey("Order")]
		public int idOrder { get; set; }
		public Order? Order { get; set; }

		[ForeignKey("Product")]
		public int idProduct { get; set; }
		public Product? Product { get; set; }
	}
}

