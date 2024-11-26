using ORP.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORP.Core.Models.Parts
{
    public class Component : IItem
    {
        public int Id { get; set; }
        public string? PartNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get ; set; }

        public string? ImageLink { get; set; }
        public UoM? UnitOfMeasure { get; set; }

    }
}
