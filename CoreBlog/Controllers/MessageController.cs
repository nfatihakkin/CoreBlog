using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        [AllowAnonymous]
        public IActionResult InBox()
        {
            int id = 4;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
        [AllowAnonymous]
        
        public IActionResult MessageDetails(int id)
        {
            var values = mm.TGetByID(id);
            return View(values);
        } 

    }
}
