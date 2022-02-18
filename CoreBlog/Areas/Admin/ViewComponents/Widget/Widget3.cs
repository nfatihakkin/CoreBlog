using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.ViewComponents.Widget
{
    public class Widget3 : ViewComponent 
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Writers.Count();
            ViewBag.v2 = c.BlogRaytings.OrderByDescending(x => x.BlogTotalScore).Select(x => x.BlogTotalScore).Take(1).FirstOrDefault();
            var blogID= c.BlogRaytings.OrderByDescending(x => x.BlogTotalScore).Select(x => x.BlogID).Take(1).FirstOrDefault();
            ViewBag.v3 = c.Blogs.OrderByDescending(x => x.BlogID==blogID).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
