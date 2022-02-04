using GTBankCustomerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GTBankCustomerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        GtbankDatabaseContext context = new GtbankDatabaseContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateCustomer()
        {
            return View();
        }


        
        [HttpPost]
        public IActionResult CreateCustomer(TblCustomerCreation customer)
        {
            if (ModelState.IsValid)
            {
                context.TblCustomerCreation.Add(customer);
                context.SaveChanges();
                //ViewBag.Message = "Customer details has been successfully created with Account Number: 000072770001";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult LoanApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoanApplication(TblLoanApplication loan)
        {
            if (ModelState.IsValid)
            {
                context.TblLoanApplication.Add(loan);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
