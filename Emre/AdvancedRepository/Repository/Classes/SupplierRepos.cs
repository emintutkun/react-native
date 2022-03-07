using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class SupplierRepos : BaseRepository<Suppliers>, ISupplierRepos
    {
        public SupplierRepos(SirketContext db) : base(db)
        {

        }

        public List<SuppliersList> GetCompanyList()
        {
            return Set().Select(x => new SuppliersList
            {
                Id=x.Id,
                CompanyName = x.CompanyName
            }).ToList();
        }
    }
}
