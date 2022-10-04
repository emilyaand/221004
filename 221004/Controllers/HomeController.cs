using _221004.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _221004.ViewModels.Home;

namespace _221004.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student {ID = 1, Name = "Ali", Surname = "Aliyev", Age = 19},
                new Student {ID = 2, Name = "Vali", Surname = "Valiyev", Age = 19},
                new Student {ID = 3, Name = "Qurban", Surname = "Qurbanov", Age = 19}
            };

            var groups = new List<Group>
            {
                new Group {ID = 1, Name = "Muri"},
                new Group {ID = 2, Name = "Zita"}
            };

            var model = new HomeIndexViewModel
            {
                Students = students,
                Groups = groups,
            };
            return View(model);

        }

    }
        
}
