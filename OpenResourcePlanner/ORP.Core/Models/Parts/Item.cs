using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORP.Core.Models.Interfaces;

namespace ORP.Core.Models.Parts
{
    public class Item : IItem
    {
        public int Id { get; set; }
        public string? PartNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public UoM? UnitOfMeasure { get; set; }
        public string? ImageLink { get; set; }


    }
}
