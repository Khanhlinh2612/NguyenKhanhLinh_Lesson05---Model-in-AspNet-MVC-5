using Nkl.Lession04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nkl.Lession04.Controllers
{
    public class NklCustomerController : Controller
    {
        // GET: NklCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: NklCustomerDetail
        public ActionResult NklCustomerDetail()
        {
            // Create customer data object
            var customer = new NklCustomer()
            {
                CustomerId = 1,
                FirstName = "Nguyen Khanh",
                LastName = "Linh",
                Address = "K22CNT3",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }

        // GET: NklListCustomer
        public ActionResult NklListCustomer()
        {
            var list = new List<NklCustomer>
            {
                new NklCustomer()
                {
                    CustomerId = 1,
                    FirstName = "Nguyen Khanh",
                    LastName = "Linh",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new NklCustomer()
                {
                    CustomerId = 2,
                    FirstName = "Nguyen Khanh",
                    LastName = "Linh 2",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new NklCustomer()
                {
                    CustomerId = 3,
                    FirstName = "Nguyen Khanh",
                    LastName = "Linh 3",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new NklCustomer()
                {
                    CustomerId = 4,
                    FirstName = "Nguyen Khanh",
                    LastName = "Linh 4",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
            };

            ViewBag.list = list;
            return View();
        }
    }
}
