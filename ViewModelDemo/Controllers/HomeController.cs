using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModel;

namespace ViewModelDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
                employee = emp,
                address = addr
            };


            return View(empaddr);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
