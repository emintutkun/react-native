using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class SuppliersModel
    {
        public SuppliersModel()
        {
            Suppliers = new Suppliers();
        }
        public Suppliers Suppliers { get; set; }
        public string BtnClass { get; set; }
        public string BtnValue { get; set; }
        public string BtnHeader { get; set; }
        public List<CategoriesList> CategoriesList { get; set; }
        public List<SuppliersList> SuppliersList { get; set; }
        public List<UnitList> UnitList { get; set; }
    }
}
