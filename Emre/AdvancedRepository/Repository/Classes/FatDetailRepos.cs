using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Repository.Classes
{
    public class FatDetailRepos:BaseRepository<FatDetail>,IFatDetailRepos
    {
        public FatDetailRepos( SirketContext db):base(db)
        {

        }

        public List<FatDetailList> GetFatDetailLists(int id)
        {
            var list = Set().Where(x => x.Id == id).ToList();
            var ls = Set().Select(z => new FatDetailList
            {
                ProductId = z.ProductId,
                Amount = z.Amount,
                ProductName ="",
                UnitPrice = z.UPrice,
                Total = z.UPrice*z.Amount,
                Id=id
            }).Where(x=>x.Id==id).ToList();
            return ls;
        }       
    }
}
