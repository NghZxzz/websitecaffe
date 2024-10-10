using DoAnWebcaffe.Models;
using DoAnWebcaffe.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
namespace DoAnWebcaffe.Controllers
{
	public class ShopController : Controller
	{
		private readonly IProductRepository _productRepository;
		private readonly ICategoryRepository _categoryRepository;

		public ShopController(IProductRepository productRepository, ICategoryRepository categoryRepository)
		{
			_productRepository = productRepository;
			_categoryRepository = categoryRepository;
		}
		public async Task<IActionResult> Index()
		{
			var product = await _productRepository.GetAllAsync();
			return View(product);
		}

		public async Task<IActionResult> Detail(int id)
		{
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
	}
}
