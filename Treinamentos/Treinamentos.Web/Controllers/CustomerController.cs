using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treinamentos.Domain.Entities;
using Treinamentos.Domain.Repositories;
using Treinamentos.Infra.Repositories;

namespace Treinamentos.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }
        
        public ActionResult Index()
        {
            return View(_repository.GetByRange());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                _repository.Save(customer);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("DefaultErrorMessage", "Falha ao incluir o cliente");
                return View(customer);
            }
            
        }

        protected override void Dispose(bool disposing)
        {
            _repository.Dispose();
        }
    }
}