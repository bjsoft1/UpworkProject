using Microsoft.AspNetCore.Mvc;
using UpworkProject.Models.DynamicControls;
using UpworkProject.Services.Database;

namespace UpworkProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectDatabaseContext _dataBase;
        public HomeController(ProjectDatabaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public IActionResult Index()
        {
            var data = _dataBase.DynamicControls.Where(x=> x.Status == Commons.EnumClass.EDataStatus.Active).ToList();
            return View(model: data);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitForm(ParticipaintInformation participaintInformation)
        {
            try
            {
                var data = await _dataBase.ParticipaintInformations.AddAsync(participaintInformation);
                await _dataBase.SaveChangesAsync();
                TempData["Success"] = $"Successfully Submited.{data.Entity.Id}";
                return RedirectToAction("", "Home");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("", "Home");
            }
        }
    }
}
