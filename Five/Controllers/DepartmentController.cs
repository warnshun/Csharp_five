﻿using Five.Models;
using Five.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Five.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Department Index";
            var departments = await _departmentService.GetAll();
            return View(departments);
        }

        public IActionResult Add()
        {
            ViewBag.Title = "Add Department";
            return View(new Department());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Department model)
        {
            if (ModelState.IsValid)
            {
                await _departmentService.Add(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
