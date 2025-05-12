using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
