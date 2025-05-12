using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
