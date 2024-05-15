using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nkl.Lab04.Models; // Đảm bảo bạn đã khai báo đúng namespace cho các model

namespace Nkl.Lab04.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/CustomerDetail
        public ActionResult CustomerDetail()
        {
            Customer cus = new Customer()
            {
                CustomerId = "2210900035",
                FullName = "Nguyễn Khánh Linh",
                Address = "Hà Nội",
                Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889",
                Balance = 15200000
            };
            return View(cus);
        }

        // GET: Customer/CustomerList
        public ActionResult CustomerList()
        {
            // Tạo một danh sách khách hàng
            List<Customer> listcustomer = new List<Customer>()
            {
                new Customer()
                {
                    CustomerId = "2210900035",
                    FullName = "Nguyễn Khánh Linh",
                    Address = "Hà Nội",
                    Email = "devmaster.founder@gmail.com",
                    Phone = "0978.611.889",
                    Balance = 15200000
                },
                new Customer()
                {
                    CustomerId = "KH002",
                    FullName = "Đỗ Thị Cúc",
                    Address = "Hà Nội",
                    Email = "cucdt@gmail.com",
                    Phone = "0986.767.444",
                    Balance = 2200000
                },
                new Customer()
                {
                    CustomerId = "KH003",
                    FullName = "Nguyễn Tuấn Thắng",
                    Address = "Nam Định",
                    Email = "thangnt@gmail.com",
                    Phone = "0924.656.542",
                    Balance = 1200000
                },
                new Customer()
                {
                    CustomerId = "KH004",
                    FullName = "Lê Ngọc Hải",
                    Address = "Hà Nội",
                    Email = "hailn@gmail.com",
                    Phone = "0996.555.267",
                    Balance = 6200000
                }
            };

            // Gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}
