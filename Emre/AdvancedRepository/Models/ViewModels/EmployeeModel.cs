﻿using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {
            Employees = new Employees();
        }
        public Employees Employees { get; set; }
        public string BtnHead { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
        public List<ManagersList> ManagerList { get; set; }
        public List<Counties> CountriesList { get; set; }

    }
}
