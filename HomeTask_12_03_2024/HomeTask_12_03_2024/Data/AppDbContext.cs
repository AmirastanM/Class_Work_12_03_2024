using ClassPractice_11_03_2024.Models;
using HomeTask_12_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_12_03_2024.Data
{
    internal class AppDbContext
    {
        public static List<Customer> customers;
        static AppDbContext()
        {
            customers = new List<Customer>
            {
                 new Customer
                {
                    Id = 1,
                    FullName = "Fatime Qayxanova",
                    Address = "Yasamal",
                    Age = 21,
                },
                new Customer
                {
                    Id = 2,
                    FullName = "Faxriyye Tagizade",
                    Address = "28 May",
                    Age = 21
                },
                new Customer
                {
                    Id = 3,
                    FullName = "Afide Veliyeva",
                    Address = "Nizami",
                    Age = 26
                },
                new Customer
                {
                    Id = 4,
                    FullName = "Elmir Qafarzade",
                    Address = "Sahil",
                    Age = 21
                },
                new Customer
                {
                    Id = 5,
                    FullName = "Sirac Memmedov",
                    Address = "Masazir",
                    Age = 23
                },
                 new Customer
                {
                    Id = 6,
                    FullName = "Reshad Agayev",
                    Address = "Neftchiler",
                    Age = 21
                }, new Customer
                {
                    Id = 7,
                    FullName = "Behruz Eliyev",
                    Address = "Kurdaxani",
                    Age = 33
                },

            };
        }
    }
}
