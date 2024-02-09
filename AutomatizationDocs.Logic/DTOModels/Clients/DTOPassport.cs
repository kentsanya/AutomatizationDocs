using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizationDocs.Logic.DTOModels.Clients
{
    public class DTOPassport
    {
        public Guid Id { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public string? Series { get; set; }

        public string Number { get; set; }

        public DateOnly Date { get; set; }

        public string Organization { get; set; }
    }
}
