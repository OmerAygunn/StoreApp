using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components
{
    public class CategoriesMenuViewComponent:ViewComponent
    {
         private readonly IServiceManager _serviceManager;

        public CategoriesMenuViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke()
        {
            var category = _serviceManager.CategoryServices.GetAllCategories(false);
            return View(category);
        }
    }
}