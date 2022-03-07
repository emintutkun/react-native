﻿using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedRepository.Controllers
{
    public class FatMasterController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly FatMasterModel _model;

        public FatMasterController(IUnitOfWork unitOfWork,FatMasterModel model)
        {
            _unitOfWork = unitOfWork;
            _model = model;
        }
        public IActionResult List()
        {

            var x = _unitOfWork._fatMasterRepos.GetFatMasterList(); 
            return View(x);
        }
        public IActionResult Create()
        {
            _model.BtnClass = "btn btn primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            _model.Customers = _unitOfWork._custRepos.GetCustomerSelects();
            return View("Crud",_model);
        }
        [HttpPost]
        public IActionResult Create(FatMasterModel model)
        {
            _unitOfWork._fatMasterRepos.Create(model.FatMaster);
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToAction("Create","FatDetail",new { model.FatMaster.Id });
        }
    }
}
