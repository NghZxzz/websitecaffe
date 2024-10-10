using DoAnWeb.Data;
using DoAnWebcaffe.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnWebcaffe.ViewComponents
{
	public class MenuLoaiViewComponent : ViewComponent
	{
		private readonly ApplicationDbContext _context;
		public MenuLoaiViewComponent(ApplicationDbContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			var data = _context.Categories.Select(x => new MenuLoaiCate
			{
				Maloai= x.Id,
				TenLoai= x.Name,
				sl =x.Products.Count()
			});
			return View(data);
		}
	}
}
