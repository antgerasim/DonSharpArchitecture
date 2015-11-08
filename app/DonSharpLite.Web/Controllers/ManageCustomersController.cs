using System.Linq;
using System.Web.Mvc;
using DonSharpLite.Domain;
using DonSharpLite.Tasks;
using SharpLite.Domain.DataInterfaces;

namespace DonSharpLite.Web.Controllers
{
    public class ManageCustomersController : Controller
    {
        private readonly CustomerCudTasks _customerMgmtTasks;
        private readonly IRepository<Customer> _customerRepository;
        //
        // GET: /ManageCustomers/
        public ManageCustomersController(IRepository<Customer> customerRepository, CustomerCudTasks customerMgmtTasks)
        {
            _customerRepository = customerRepository;
            _customerMgmtTasks = customerMgmtTasks;
        }

        public ActionResult Index()
        {
            return View(_customerRepository.GetAll().OrderBy(c => c.LastName).ThenBy(c => c.FirstName));
        }

        public ActionResult Details(int id)
        {
            return View(_customerRepository.Get(id));
        }

        public ActionResult Create()
        {
            return View("Edit", _customerMgmtTasks.CreateEditViewModel());
        }

        public ActionResult Edit(int id)
        {
            return View(_customerMgmtTasks.CreateEditViewModel(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var confirmation = _customerMgmtTasks.SaveOrUpdate(customer);

                if (confirmation.WasSuccessful)
                {
                    TempData["message"] = confirmation.Message;
                    return RedirectToAction("Index");
                }

                ViewData["message"] = confirmation.Message;
            }

            return View(_customerMgmtTasks.CreateEditViewModel(customer));
        }
    }

}