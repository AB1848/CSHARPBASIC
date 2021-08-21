using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class Employeecontroller : Controller
{
    public ActionResult Index()
    {
        List<Person> employees = new List<Person>();
        // Object initializer syntact 
        Person emp1 = new Person() { Firstname = "Aashish", Surname = "Bhandari", Address = "Kathmandu", Gender = 'm' };
        Person emp2 = new Person() { Firstname = "jack", Surname = "Leach", Address = "Kathmandu", Gender = 'm' };
        Person emp3 = new Person() { Firstname = "Harry", Surname = "Maqguire", Address = "Kathmandu", Gender = 'm' };
        Person emp4 = new Person() { Firstname = "Tom", Surname = "Holland", Address = "Kathmandu", Gender = 'm' };
        Person emp5 = new Person() { Firstname = "Gary", Surname = "Kristen", Address = "Kathmandu", Gender = 'm' };
        Person emp6 = new Person() { Firstname = "Carry", Surname = "Alex", Address = "Kathmandu", Gender = 'm' };

      return View(employees);
    }
}
