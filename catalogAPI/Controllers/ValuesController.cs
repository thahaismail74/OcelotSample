﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace catalogAPI.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet , Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "usd", "inr", "Jpy","Euro" };
        }

        
    }
}
