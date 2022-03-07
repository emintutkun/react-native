using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.Repository.Interfaces;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class SuppliersController : Controller
    {
        SuppliersModel _model;
        IUnitOfWork _uow;
        public SuppliersController(SuppliersModel model, IUnitOfWork uow)
        {
            _model = model;
            _uow = uow;
        }
        public IActionResult List()
        {
            var supplier = _uow._supRepos.GetCompanyList();
            return View(supplier);
        }

        [HttpGet]
        public IActionResult Create()
        {
            _model.Suppliers = new Suppliers();
            _model.BtnHeader = "Create Page";
            _model.BtnClass = "btn btn-primary";
            _model.BtnValue = "Create";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(SuppliersModel model)
        {
            _uow._supRepos.Create(model.Suppliers);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _model.Suppliers = _uow._supRepos.Find(id);
            _model.BtnHeader = "Update Page";
            _model.BtnClass = "btn btn-success";
            _model.BtnValue = "Update";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Update(SuppliersModel model)
        {
            _uow._supRepos.Update(model.Suppliers);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.Suppliers = _uow._supRepos.Find(id);
            _model.BtnHeader = "Delete Page";
            _model.BtnClass = "btn btn-danger";
            _model.BtnValue = "Delete";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(SuppliersModel model)
        {
            _uow._supRepos.Delete(model.Suppliers);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }
    }
}