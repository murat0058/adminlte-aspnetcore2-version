﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace motekarteknologi.Controllers
{
    public class TableController : Controller
    {
        public IActionResult SimpleTable()
        {
            return View();
        }

        public IActionResult DataTable()
        {
            return View();
        }
    }
}