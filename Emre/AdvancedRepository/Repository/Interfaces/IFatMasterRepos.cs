using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IFatMasterRepos:IBaseRepository<FatMaster>
    {
        List<FatMasterList> GetFatMasterList();
        

    }

}
