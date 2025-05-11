using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.ViewComponents
{
    public class _ComponentPortfolioPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
