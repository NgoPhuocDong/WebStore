using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Models
{
	public class Order
	{
		[Key]
		public int ID { get; set; }
		public DateTime OrderDate { get; set; }
		public double OrderTotal { get; set; }
		public int OrderStatus { get; set; }

		[ForeignKey("Customer")]
		public int idCustomer { get; set; }
		public Customer? Customer { get; set; }
	}
}

