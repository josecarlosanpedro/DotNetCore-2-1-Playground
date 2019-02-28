using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarterKit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarterKit.Services;

namespace StarterKit.Controllers
{
    [Route("api")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleServices _services;

        public SampleController(ISampleServices services)
        {
            _services = services;
        }
        [HttpPost]
        [Route("Add")]
        public ActionResult<SampleItemModel> AddSampleItems(SampleItemModel items)
        {
            var sampleItem = _services.AddSampleItems(items);
            if (sampleItem == null)
            {
                return NotFound();
            }
            return Ok(sampleItem);
            
        }

        [HttpGet]
        [Route("Get")]
        public ActionResult<Dictionary<string, SampleItemModel>> GetSampleItems()
        {
            var sampleItems = _services.GetSampleItems();
            if (sampleItems.Count == 0)
            {
                return NotFound();
            }
            return sampleItems;
        }
    }
}