using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            HttpContext.Session.SetString("SnakeEye",JsonConvert.SerializeObject(_snakeEyes));

            return View(_snakeEyes);
        }

        public IActionResult Play()
        {
            _snakeEyes.Play();
            return View("Index",_snakeEyes);
        }
    }
}
