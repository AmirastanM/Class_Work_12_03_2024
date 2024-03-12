
// 1- ededin faktorialini tapan method yazmaq. Eger menfi eded daxil 
//edilibse custom exception cixarsin.

using ClassPractice_11_03_2024.Controllers;
using HomeTask_12_03_2024.Controllers;
using HomeTask_12_03_2024.Data;
using HomeTask_12_03_2024.Models;

CalculationController calculation = new();
//calculation.GetFactorial();


AccountController accountController = new();

//accountController.SignIn();



//foreach(var item in AppDbContext.customers)
//{
//    Console.WriteLine(item.FullName);
//}

//AppDbContext.customers.Add(new Customer { FullName = "Abbasov Abdul" });





CustomerController customerController = new();

//customerController.GetAll();

//customerController.GetById();

//customerController.GetAllByAge();

//customerController.GetAllCountOfData();

customerController.SortByAge();