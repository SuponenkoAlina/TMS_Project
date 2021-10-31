using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers.MainMenu
{
    public class MainMenuController : Controller
    {
        private readonly IPersonService _personService;

        public MainMenuController(IPersonService _personService)
        {
            this._personService = _personService;
        }

        public IActionResult MainMenu()
        {
            return View();
        }
    }
}
