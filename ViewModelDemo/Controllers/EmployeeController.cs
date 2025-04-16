using Microsoft.AspNetCore.Mvc;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModel;

namespace ViewModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> emplst = new List<Employee>()
        {
            new Employee(){EmpId=11,EmpName = "Mano",Salary=75000,Dept="Developer",AddressId=1},
            new Employee(){EmpId=11,EmpName = "Mano",Salary=75000,Dept="Developer",AddressId=1}
        };

        List<Address> lstaddr = new List<Address>()
        {
            new Address(){DoorNO=1,StName="shfdhs"}
        };

        public IActionResult Index()
        {       
           
           return View(emplst);
        }
        public ViewResult Details()
        {
            //Employee basic details
            Employee emp = new Employee()
            {
                EmpId = 111,
                EmpName = "Dheepu",
                Salary = 80000,
                Dept = "HR",
                AddressId = 1
            };

            //Employee Address Details
            Address addr = new Address()
            {
                DoorNO = 1,
                StName = "Indira Nagar",
                City = "Bangalore",
                State = "Karnataka",
                Country = "India"
            };

            //EmployeeAddress Viewmodel
            EmployeeAddressVM empaddr = new EmployeeAddressVM()
            {
               employee=emp ,
               address=addr
            };

            return View(empaddr);
        }
    }
}
