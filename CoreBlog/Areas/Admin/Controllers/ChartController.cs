using CoreBlog.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {

            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Staj",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 7
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 5
            });
            list.Add(new CategoryClass
            {
                categoryname = "Projeler",
                categorycount = 5
            });



            return Json(new { jsonlist = list });
        }
    }
}
