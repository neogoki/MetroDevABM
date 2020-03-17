using MetroDevABM.ClientTypes;
using MetroDevABM.ClientTypes.Dto;
using MetroDevABM.Web.Models.ClientTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MetroDevABM.Web.Controllers
{
    public class ClientTypeController : MetroDevABMControllerBase
    {
        private readonly IClientTypeAppService _ClientTypeAppService;

        public ClientTypeController(IClientTypeAppService ClientTypeAppService)
        {
            _ClientTypeAppService = ClientTypeAppService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var output = await _ClientTypeAppService.GetAll();

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
        public async Task<ActionResult> Create(CreateClientTypeInput input)
        {
            await _ClientTypeAppService.Create(input);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _ClientTypeAppService.Get(id);
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ClientTypeDto ClientType)
        {
            await _ClientTypeAppService.Update(ClientType);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            await _ClientTypeAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}