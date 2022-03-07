using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;

namespace AdvancedRepository.Models.ViewModels
{
    public class FatDetailModel
    {
       
        public List<ProductSelect> ProductSelects { get; set; }
        public FatMaster FatMaster { get; set; }
        public FatDetail FatDetail { get; set; }
        public List <FatDetailList> FatDetailList { get; set; }
        public string BtnHead { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
    }
}
