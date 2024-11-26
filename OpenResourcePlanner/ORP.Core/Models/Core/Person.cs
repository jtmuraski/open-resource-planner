using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORP.Core.Models.Interfaces;

namespace ORP.Core.Models.Core
{
    public class Person : IPerson
    {
        // --Properties---
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public string? CellPhoneNumber { get; set; }
        public string? WorkPhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
    }
}
