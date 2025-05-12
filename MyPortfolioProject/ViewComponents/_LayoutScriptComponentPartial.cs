using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProject.ViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
        
}
