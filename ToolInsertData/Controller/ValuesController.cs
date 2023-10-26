using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToolInsertData.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            string text = "";

            return text;
        }

        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            return Ok();
        }

        [HttpPost, Route("/webhook")]
        public IActionResult GetWebhook(string id)
        {
            return new JsonResult(new
            {
                id
            });
        }
    }
}
