﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult results = validator.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Deneme";
                wm.TAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }

    }
}