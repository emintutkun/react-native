using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedRepository.Controllers
{
    public class FatDetailController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly FatDetailModel _model;

        public FatDetailController(IUnitOfWork unitOfWork,FatDetailModel model)
        {
            _unitOfWork = unitOfWork;
            _model = model;
        }
        
        public IActionResult Create(int id)
        {
            _model.FatDetailList = _unitOfWork._fatDetailRepos.GetFatDetailLists(id);
            _model.FatMaster=_unitOfWork._fatMasterRepos.Find(id);
            _model.BtnHead = "Create";
            _model.BtnVal = "Create";
            _model.BtnClass = "btn btn-primary";
            _model.ProductSelects = _unitOfWork._proRepos.GetProductSelects();
            return View(_model);
        }
        [HttpPost]
        public IActionResult Create(int id,FatDetailModel model)
        {
            model.FatDetail.Id = id;
            _unitOfWork._fatDetailRepos.Create(model.FatDetail);
            _unitOfWork.Commit();
            model.FatMaster = _unitOfWork._fatMasterRepos.Find(id);
            model.ProductSelects=_unitOfWork._proRepos.GetProductSelects();
            
           
            return View(model);

        }
    }
}
