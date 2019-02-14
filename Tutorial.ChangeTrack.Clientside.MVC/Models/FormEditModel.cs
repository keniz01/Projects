using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tutorial.ChangeTrack.Clientside.MVC.Models
{
    public class EmployeeDropdownMenuViewModel
    {
        public int DefaultEmpValue { get { return 2; } }

        [Display(Name = "Select Employee:")]
        public List<EmployeeViewModel> Employees { get; set; }

        public class EmployeeViewModel
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }
    }

    public class FormEditModel
    {
        public int DefaultEmpValue { get; set; }
        public string DefaultEmpText { get; set; }
        public int CurrentEmpValue { get; set; }
        public string CurrentEmpText { get; set; }
        public string EmpFieldName { get; set; }
    }
}