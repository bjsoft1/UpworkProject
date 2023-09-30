using Microsoft.AspNetCore.Mvc;
using UpworkProject.Commons.EnumClass;
using UpworkProject.Commons.Extensions;
using UpworkProject.Dtos.DynamicControls;
using UpworkProject.Dtos.ParticipaintInformations;
using UpworkProject.Models.DynamicControls;
using UpworkProject.Repositories.DynamicControls;
using UpworkProject.Services.DynamicControls;
using UpworkProject.Services.ParticipaintInformations;

namespace UpworkProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDynamicControlsRepositories _dynamicControlsRepositories;
        private readonly IDynamicControlAppService _dynamicControlAppService;
        private readonly IParticipaintInformationsAppService _participaintInformationsAppService;
        public HomeController(IDynamicControlsRepositories dynamicControlsRepositories,
            IDynamicControlAppService dynamicControlAppService,
            IParticipaintInformationsAppService participaintInformationsAppService)
        {
            _dynamicControlsRepositories = dynamicControlsRepositories;
            _dynamicControlAppService = dynamicControlAppService;
            _participaintInformationsAppService = participaintInformationsAppService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _dynamicControlsRepositories.GetDynamicControlListing();
            return View(model: data);
        }
        [HttpPost]
        public async Task<IActionResult> AddParticipaint(ParticipaintInformationsAddUpdateDto participaintInformation)
        {
            try
            {
                var data = await _participaintInformationsAppService.AddParticipaintInformation(participaintInformation);
                await _participaintInformationsAppService.CurrentUnitSaveChangeAsync();
                
                TempData["Success"] = $"Successfully Submited. ID:{data.Id}";
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
        public async Task<IActionResult> AddDynamicControl(DynamicControlAddUpdateDto dynamicControl)
        {
            try
            {
                var data = await _dynamicControlAppService.AddDyanmicControl(dynamicControl);
                await _dynamicControlAppService.CurrentUnitSaveChangeAsync();

                TempData["Success"] = $"Successfully Submited. ID: {data.Id}";
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
