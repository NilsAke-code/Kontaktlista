
namespace Business.Models
{
    public class ContactModel

         // Chatgpt 4o la som förslag att sätta required framför de egenskaper som alltid måste tilldelas ett värde.
    {   //  Det krävs ingen ytterligare kod och varningarna försvinner.
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string StreetAddress { get; set; }
        public required string City { get; set; }
        public required string PostalCode { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
