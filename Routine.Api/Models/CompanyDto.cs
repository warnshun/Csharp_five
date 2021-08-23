using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Routine.Api.Entities;

namespace Routine.Api.Models
{
    public class CompanyDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
