using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nkl.Lab04_2.Models
{
    public class CustomerRepository : ICustomerRepository
    {
       
        // Khởi tạo danh sách khách hàng
        static readonly List<Customer> data = new List<Customer>()
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

        // Phương thức lấy danh sách khách hàng
        public IList<Customer> GetCustomers()
        {
            return data;
        }

        // Phương thức tìm khách hàng theo tên
        public IList<Customer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }

        // Phương thức lấy khách hàng theo Id
        public Customer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }

        // Phương thức thêm khách hàng
        public void AddCustomer(Customer cus)
        {
            data.Add(cus);
        }

        // Phương thức cập nhật khách hàng
        public void UpdateCustomer(Customer cus)
        {
            // Lấy khách hàng theo id
            var customer = data.FirstOrDefault(c => c.CustomerId.Equals(cus.CustomerId));
            // Nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }

        // Phương thức xóa khách hàng
        public void DeleteCustomer(Customer cus)
        {
            data.Remove(cus);
        }      
    }
}