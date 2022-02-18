using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreBlog.Areas.Admin.ViewComponents.Widget
{
    public class Widget1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            string api = "72b96baae4b9b4daa24d1bf3e766e027";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=bursa&units=metric&mode=xml&appid=" + api;
            XDocument doc = XDocument.Load(connection);
            ViewBag.v4 = doc.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
