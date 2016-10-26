using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnakeEyesGame.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SnakeEyesGame.Controllers
{
    public class HomeController : Controller
    {
        private SnakeEyes _snakeEyes;

        // GET: /<controller>/
        public IActionResult Index()
        {
            _snakeEyes = new SnakeEyes();

            return View(_snakeEyes);
        }
    }
}
