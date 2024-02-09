using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizationDocs.Logic.DTOModels.Clients
{
    public class DTOAdress
    {
        public Guid Id { get; set; }

        public string City { get; set; }
        public string Streat { get; set; }

        public int NumberOfHouse { get; set; }
    }
}
