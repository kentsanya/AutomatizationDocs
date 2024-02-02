using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizationDocs.Data.Entity.Client
{
    public class Adress
    {
        public Guid Id { get; set; }
        public string Streat { get;set; }

        public int NumberOfHouse { get; set; }
    }
}
