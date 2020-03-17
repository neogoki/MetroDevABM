using MetroDevABM.Clients;
using MetroDevABM.Clients.Dto;
using MetroDevABM.Common;
using MetroDevABM.Web.Models.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.Application.Services.Dto;

namespace MetroDevABM.Web.Controllers
{
    public class ClientController : MetroDevABMControllerBase
    {
        private readonly IClientAppService _ClientAppService;
        private readonly ILookupAppService _LookupAppService;

        public ClientController(IClientAppService ClientAppService, ILookupAppService LookupAppService)
        {
            _ClientAppService = ClientAppService;
            _LookupAppService = LookupAppService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var output = await _ClientAppService.GetAll();

            var model = new IndexViewModel(output.Items);

            return View(model);
        }
        
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var gendersSL = (await _LookupAppService.GetGenderComboboxItems()).Items.Select(s => s.ToSelectListItem()).ToList();
            var clientTypesSL = (await _LookupAppService.GetClientTypeComboboxItems()).Items.Select(s => s.ToSelectListItem()).ToList();
            var model = new CreateViewModel(gendersSL, clientTypesSL);
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateClientInput input)
        {
            await _ClientAppService.Create(input);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var dto = await _ClientAppService.Get(id);

            var gendersSL = (await _LookupAppService.GetGenderComboboxItems()).Items.Select(s => s.ToSelectListItem()).ToList();
            var clientTypesSL = (await _LookupAppService.GetClientTypeComboboxItems()).Items.Select(s => s.ToSelectListItem()).ToList();
            var model = ObjectMapper.Map(dto, new UpdateViewModel(gendersSL, clientTypesSL));

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ClientDto Client)
        {
            await _ClientAppService.Update(Client);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            await _ClientAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}