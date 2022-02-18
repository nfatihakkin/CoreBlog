using CoreBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Fatih"
                },
                new UserComment
                {
                    ID=2,
                    Username="Nurettin"
                },
                new UserComment
                {
                    ID=3,
                    Username="AKKIN"
                },
            };
            return View(cValues);
        }
    }
}
