namespace ORP.Core.Models.Interfaces
{
    public interface IPerson
    {
        string? CellPhoneNumber { get; set; }
        string? EmailAddress { get; set; }
        string? FirstName { get; set; }
        int Id { get; set; }
        string? LastName { get; set; }
        string? Title { get; set; }
        string? WorkPhoneNumber { get; set; }
    }
}