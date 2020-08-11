﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventCore.Interface;
using Microsoft.AspNetCore.Http;
using EventCore.Filters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventCore.Controllers
{
    [ValidateUserSession]
    public class UserProfileController : Controller
    {
        IRegistration _IRepository;
        public UserProfileController(IRegistration IRepository)
        {
            _IRepository = IRepository;
        }

        [HttpGet]
        public IActionResult Profile()
        {
            try
            {
                var profile = _IRepository.Userinformation(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                return View(profile);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
