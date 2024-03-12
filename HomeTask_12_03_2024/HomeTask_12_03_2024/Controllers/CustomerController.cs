using HomeTask_12_03_2024.Data;
using HomeTask_12_03_2024.Services;
using HomeTask_12_03_2024.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_12_03_2024.Controllers
{
    internal class CustomerController
    {
        private readonly ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService(); 
        }

        public void GetAll()
        {
            foreach( var item in AppDbContext.customers)
            {
                Console.WriteLine(item.FullName + "-" + item.Address +"-" + item.Age);
            }
        }
        public void GetById()
        {
            try
            {
                int id = 4;
                var result = _customerService.GetById(id);
                Console.WriteLine(result.FullName + "-" + result.Address + "-" + result.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void GetAllByAge() 
        {
            int age = 21;

            foreach(var item in _customerService.GetAllByAge(age))
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);
            }
        }

        public void GetAllCountOfData()
        {
            Console.WriteLine(_customerService.GetCount());
        }

        public void SortByAge()
        {
            foreach(var item in _customerService.SortByAge())
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);
            }
        }
    }
}
