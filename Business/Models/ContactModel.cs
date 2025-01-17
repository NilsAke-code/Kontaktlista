
namespace Business.Models;

public class ContactModel

    // Detta är genererat av Chat GPT 4.0 - Denna kod gör att required används för egenskaper som alltid måste ha ett värde, vilket tar bort varningar utan ytterligare kod.
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string StreetAddress { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }
    public Guid Id { get; set; } = Guid.NewGuid();
}
