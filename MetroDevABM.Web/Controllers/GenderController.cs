using MetroDevABM.Genders;
using MetroDevABM.Genders.Dto;
using MetroDevABM.Web.Models.Genders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MetroDevABM.Web.Controllers
{
    public class GenderController : MetroDevABMControllerBase
    {
        private readonly IGenderAppService _genderAppService;

        public GenderController(IGenderAppService genderAppService)
        {
            _genderAppService = genderAppService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var output = await _genderAppService.GetAll();

            var model = new IndexViewModel(output.Items);

            return View(model);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            var model = new CreateViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateGenderInput input)
        {
            await _genderAppService.Create(input);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _genderAppService.Get(id);
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(GenderDto gender)
        {
            await _genderAppService.Update(gender);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            await _genderAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}