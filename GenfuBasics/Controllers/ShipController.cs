using GenFu;
using GenfuBasics.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenfuBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipController : ControllerBase
    {
        [HttpGet("GetAllShips")]
        public IActionResult GetAllShips()
        {
            
            var fakeId = 1;
            A.Configure<Ships>()
                .Fill(x => x.GrossTonnage).WithinRange(10, 100)
                .Fill(x => x.Id, () => { return fakeId++; })
                .Fill(x => x.TypeOf).WithRandom(new string[] { "Container", "Bulk", "Tanker", "Naval", "OffShore", "Special Purpose" })
                .Fill(x => x.ImoNumber).WithinRange(100000, 999999);
           
            return Ok(A.ListOf<Ships>(100));

        }
    }
}
