using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Repaso-Net.Models;

namespace Repaso_Net.Controllers
{
    public class CursoController : Controller
    {
        public CursoController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}