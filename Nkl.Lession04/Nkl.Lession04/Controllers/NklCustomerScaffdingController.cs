using Nkl.Lession04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Nkl.Lession04.Controllers
{
    public class NklCustomerScaffdingController : Controller
    {
        //mockdata
        private List<NklCustomer> listCustomer =new List<NklCustomer>()
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
        // GET: NklCustomerScaffding
        //listcustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult NklCreate() 
        {
            var model = new NklCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NklCreate(NklCustomer model)
        {
            listCustomer.Add(model);
            return RedirectToAction("Index");
        }
        public ActionResult NklEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId == id);
            return View(customer);
        }
    }
    

}