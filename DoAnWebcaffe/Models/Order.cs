﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnWebcaffe.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string UserId { get; set; }
		public DateTime OrderDate { get; set; }
		public int TotalPrice { get; set; }

		public string ShippingAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string Notes { get; set; }

		[ForeignKey("UserId")]
		[ValidateNever]
		public ApplicationUser ApplicationUser { get; set; }
		public List<OrderDetail> OrderDetails { get; set; }

	}
}
