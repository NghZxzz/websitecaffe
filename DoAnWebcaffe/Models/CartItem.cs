﻿using Newtonsoft.Json.Linq;

namespace DoAnWebcaffe.Models
{
	public class CartItem
	{
		public int ProductId { get; set; }
		public string Name { get; set; }

		public string ImageUrl { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		public int Total => Convert.ToInt32(Price) * Quantity;

	}
}