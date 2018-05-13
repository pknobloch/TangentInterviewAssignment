using AutoMapper;
using EmployeeWeb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace EmployeeWeb2.Controllers
{
    public class EmployeeController : BaseController
    {
        // GET: Employee
        public async Task<ActionResult> Index()
        {
            var employees = await GetTangentEmployeeService().FetchEmployeesAsync();
            var model = Mapper.Map<List<EmployeeViewModel>>(employees);
            return View(model);
        }

        // GET: Employee/MyDetails
        public async Task<ActionResult> MyDetails()
        {
            var employee = await GetTangentEmployeeService().FetchMyEmployeeProfileAsync();
            var model = Mapper.Map<EmployeeViewModel>(employee);
            return View("Details", model);
        }

        // GET: Employee/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var employee = await GetTangentEmployeeService().FetchEmployeeAsync(id);
            var model = Mapper.Map<EmployeeViewModel>(employee);
            return View(model);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
