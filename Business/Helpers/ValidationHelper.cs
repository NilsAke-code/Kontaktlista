
namespace Business.Helpers
{
    // Chatgpt 4.0 hjälpte mig skapa en till Helper klass för att hantera all validering av att skapa en ny kontakt.
    // Det blir en återanvändbar funktion som kan implenteras i andra sammanhang och det finns ingen risk för att logiken dupliceras.
    // Koden blir också renare i min MenuDialogs tack vare ValidationHelper.
    public static class ValidationHelper
    {
        public static bool IsValidEmail(string email) 
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email); // Jag använder klassen MailAddress för att kontrollera om strängen har ett giltigt e-postformat.
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPostalCode(string postalCode)
        {
            // Detta Regex är för svenska postnummer.

            return System.Text.RegularExpressions.Regex.IsMatch(postalCode, @"^\d{3}\s?\d{2}$");
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Detta Regex är för svenska telefonnummer.

            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^(\+46|0)\d{1,3}[-\s]?\d{3}[-\s]?\d{4}$");
        }

        public static bool IsValidStreetAddress(string streetAddress)
        {
            if (string.IsNullOrWhiteSpace(streetAddress))
                return false;

            // Detta Regex är för svenska gatuadresser.

            return System.Text.RegularExpressions.Regex.IsMatch(streetAddress, @"^[A-Za-zåäöÅÄÖ\s]+ \d{1,4}[A-Za-z]?$");
        }

        public static bool IsValidCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return false;

            // Detta Regex är för svenska orter.

            return System.Text.RegularExpressions.Regex.IsMatch(city, @"^[A-Za-zåäöÅÄÖ\s\-]+$");
        }
    }
}