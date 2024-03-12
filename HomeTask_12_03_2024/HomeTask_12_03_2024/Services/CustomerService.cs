using ClassPractice_11_03_2024.Models;
using HomeTask_12_03_2024.Data;
using HomeTask_12_03_2024.Models;
using HomeTask_12_03_2024.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_12_03_2024.Services
{
    internal class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int? id)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id); ;
        }

        public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age == age).ToList();
        }

        public int GetCount()
        {
            return AppDbContext.customers.Count();
        }

        public List<Customer> SortByAge()
        {
            return AppDbContext.customers.OrderBy(m => m.Age).ToList();

        }
    }
}
