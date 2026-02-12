using Microsoft.AspNetCore.Mvc;
using Medwizrx.Models;

namespace Medwizrx.Controllers
{
    public class MedwizrxController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new FirstAloneCharVm());
        }

        [HttpPost]
        public IActionResult Index(FirstAloneCharVm vm)
        {
            var input = vm.Input ?? string.Empty;

            vm.Result = GetFirstUniqueChar.FirstUniqueChar(input).ToString();
            return View(vm);
        }
    }
}
