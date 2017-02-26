using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jqueryObjectLoop.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UsersViewModel> Users { get; set; }

        public CompanyViewModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}