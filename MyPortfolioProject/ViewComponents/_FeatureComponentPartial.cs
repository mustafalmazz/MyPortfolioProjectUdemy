using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
