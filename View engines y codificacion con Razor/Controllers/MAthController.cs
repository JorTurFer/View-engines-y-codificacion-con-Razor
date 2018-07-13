using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace View_engines_y_codificacion_con_Razor.Controllers
{
    [Route("math")]
    public class MathController : Controller
    {
        [Route("multiplication/{number:int}")]
        public IActionResult Multiplication(int number)
        {
            return View(number);
        }
    }
}