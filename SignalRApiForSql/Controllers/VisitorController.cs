﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRApiForSql.Models;
using SignalRApiForSql.DAL;
using System;
using System.Linq;

namespace SignalRApiForSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorService _visitorService;
        public VisitorController(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        [HttpGet]
        public IActionResult CreateVisitor()
        {
            Random random = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECity item in Enum.GetValues(typeof(ECity)))
                {
                    var newVisitor = new Visitor
                    {
                        City = item,
                        CityVisitCount = random.Next(100, 2000),
                        VisitDate = DateTime.Now.AddDays(x)
                    };
                    _visitorService.SaveVisitor(newVisitor).Wait();
                    System.Threading.Thread.Sleep(10);
                }
            });
            return Ok("Ziyaretçiler başarılı bir şekilde eklendi");
        }
    }
}
