using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using ProjectDb.Model;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService _personService)
        {
            this._personService = _personService;
        }

        [HttpPost]
        public IActionResult UpdatePerson(PersonInfo info)
        {
            var _person = _personService.GetById(info.Id);

            _person.Name = info.Name;
            _person.Login = info.Login;
            _person.Password = info.Password;

            _personService.UpdatePerson(_person);

            //return Redirect(Url.Action("GetAll", "Person"));

            return Json(new
            {
                //isDeleted = _person.IsDeleted,
                newData = new { success = "Успешно" },
                deletedTextMessage = new { yes = "Да", no = "Нет" }
            });

            //return Json(new{ success = "Operator is Unhire!!!"});
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var persons = _personService.GetAll();

            var model = new List<PersonInfo>();

            model = persons.Select(o => new PersonInfo
            {
                Id = o.Id,
                Name = o.Name,
                Email = o.Email,
     
            }).ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult GetFullInfo(int id)
        {
            var _person = _personService.GetById(id);

            var model = new PersonInfo
            {
                Id = _person.Id,
                Name = _person.Name,
                Email = _person.Email,
                Login = _person.Login,
                Password = _person.Password,
                //HireDate = _person.HireDate
            };

            return View(model);
            
        }

        public IActionResult CreatePerson(PersonInfo info)
        {
            Person person = new Person();
                       
            person.Login = info.Login;
            person.Name = info.Name;
            person.Password = info.Password;
            person.Email = info.Email; 

            _personService.CreatePerson(person);

            //return RedirectToAction("MainMenu", "MainMenu");
            return Json(new
            {
               
                emailMessage = "Пользователь зарегистрирован!",
                url = Url.Action("MainMenu", "MainMenu")
            
            });
        }

        public IActionResult CreatePage(PersonInfo info)
        {
            return View();
        }

    }
}
