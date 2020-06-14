using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiGenericOperationsHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathOperationsController : ControllerBase
    {
        [HttpGet("AddNumbers")]
        [Route("api/[controller]/AddNumbers")]
        public int AddNumbers(int a,int b)
        {
            return a + b;
        }
    }
}
