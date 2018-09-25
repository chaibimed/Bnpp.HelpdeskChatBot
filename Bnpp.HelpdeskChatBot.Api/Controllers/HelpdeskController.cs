using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Bnpp.HelpdeskChatBot.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.HelpdeskChatBot.Api.Controllers
{
    [Route("api/helpdesk/")]
    public class HelpdeskController : Controller
    {
        private IRepository _db;

        public HelpdeskController(IRepository data)
        {
            this._db = data;
        }
        [HttpGet("{feature}")]
        public IActionResult ChooseFeature(string feature)
        {
            if (string.IsNullOrEmpty(feature))
                return StatusCode(StatusCodes.Status400BadRequest);
            return  Ok(_db.GetApplications());
        }
    }
}