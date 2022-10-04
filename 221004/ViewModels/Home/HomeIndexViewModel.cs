using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _221004.Models;

namespace _221004.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
    }
}
