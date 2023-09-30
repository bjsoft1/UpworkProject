using Microsoft.AspNetCore.Mvc;
using UpworkProject.Commons.EnumClass;
using UpworkProject.Commons.Extensions;
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
                TempData["Success"] = $"Successfully Submited. ID:{data.Entity.Id}";
                return RedirectToAction("", "Home");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("", "Home");
            }
        }
        [HttpGet("/AddDynamicInput")]
        public async Task<IActionResult> AddDynamicInput()
        {
            TempData["ControlTypes"] = EnumExtensions.GetEnumVeriableList<EDynamicControlTypes>().OrderBy(x=> x.DisplayName).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDynamicControl(DynamicControl dynamicControl)
        {
            try
            {
                var data = await _dataBase.DynamicControls.AddAsync(dynamicControl);
                await _dataBase.SaveChangesAsync();
                TempData["Success"] = $"Successfully Submited. ID: {data.Entity.Id}";
                return RedirectToAction("AddDynamicInput", "Home");

            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("", "Home");
            }
        }
    }
}
