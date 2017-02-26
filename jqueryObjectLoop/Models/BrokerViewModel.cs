using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jqueryObjectLoop.Models
{
    public class BrokerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CompanyViewModel> Companies { get; set; }

        public BrokerViewModel(int id, string name) {
            this.Id = id;
            this.Name = name;
        }
    }
}