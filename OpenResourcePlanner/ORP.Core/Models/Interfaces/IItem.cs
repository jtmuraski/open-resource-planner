using ORP.Core.Models.Parts;

namespace ORP.Core.Models.Interfaces
{
    public interface IItem
    {
        string? Description { get; set; }
        int Id { get; set; }
        string? ImageLink { get; set; }
        string? Name { get; set; }
        string? PartNumber { get; set; }
        UoM? UnitOfMeasure { get; set; }
    }
}