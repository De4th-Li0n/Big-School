﻿using BigSchool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BigSchoolContext context = new BigSchoolContext();
            var upcomingcourse = context.Courses.Where(p => p.Datetime > DateTime.Now).OrderBy(p => p.Datetime).ToList();
            foreach(Course i in upcomingcourse)
            {
                ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(i.LeturerId);
                i.Name = user.Name;
            }
            return View(upcomingcourse);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}