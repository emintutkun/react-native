using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IFatDetailRepos:IBaseRepository<FatDetail>
    {
        List<FatDetailList> GetFatDetailLists(int id);
    }
}
