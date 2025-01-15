using Business.Interfaces;
using Business.Helpers;

namespace Kontaktlista.Dialogs
{

    public class MenuDialogs
    {
        private readonly IContactService _contactService;

        private const string FilePath = "contacts.json"; // Detta är genererat av Chat GPT 4.0 - Denna kod gör så att contacts.json är standardfilen för att lagra kontakter.
        public MenuDialogs(IContactService contactService)
        {
            _contactService = contactService;
        }

        public void MainMenu()
        {

            _contactService.LoadContacts(FilePath); //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att den laddar kontakter från filen vid start.
            while (true)
            {
                Console.Clear();
                Console.WriteLine("### MAIN MENU ###");
                Console.WriteLine("\n");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("2. View All Contacts");
                Console.WriteLine("3. Exit");
                Console.Write("Select Option:");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;

                    case "2":
                        ViewAllContacts();
                        break;

                    case "3":
                        Console.WriteLine("Saving and Exiting Application...");
                        _contactService.SaveContacts(FilePath); //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att den sparar kontakter vid avslut.
                        return;

                    default:
                        Console.WriteLine("Invalid answer, please try again.");
                        break;


                }
            }
        }



        private void AddContact()
        {
            Console.Clear();
            Console.WriteLine("#######################");
            Console.WriteLine("### ADD NEW CONTACT ###");
            Console.WriteLine("#######################");
            Console.WriteLine("\n");

            //  Detta är genererat av Chat GPT 4.0 - Denna kod använder null-coalescing operator (??) för att tilldela ett standardvärde om Console.ReadLine() returnerar null.
            //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att det krävs validering av ett förnamn för att fortsätta med hjälp av en do-loop.
            //  Do-loop använder jag för alla strängar i min AddContact-metod, de körs minst en gång innan de kontrolleras.

            string firstName;
            do
            {
                Console.Write("Firstname: ");
                firstName = Console.ReadLine() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.WriteLine("Firstname cannot be empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(firstName));

            //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att det krävs validering av ett efternamn för att fortsätta med hjälp av en do-loop.

            string lastName;
            do
            {
                Console.Write("Lastname: ");
                lastName = Console.ReadLine() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("Lastname cannot be empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(lastName));


            //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att det krävs validering av en epost för att fortsätta och att den är i rätt format med hjälp av en do-loop.

            string email;
            do
            {
                Console.Write("Email: ");
                email = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(email) || !ValidationHelper.IsValidEmail(email))
                {
                    Console.WriteLine("Please enter a valid email address.");
                }
            } while (string.IsNullOrWhiteSpace(email) || !ValidationHelper.IsValidEmail(email));


            //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att det krävs validering av ett svenskt telefonnummer för att fortsätta med hjälp av en do-loop.

            string phoneNumber;
            do
            {
                Console.Write("Phone Number: ");
                phoneNumber = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(phoneNumber) || !ValidationHelper.IsValidPhoneNumber(phoneNumber))
                {
                    Console.WriteLine("Please enter a valid Swedish phone number (e.g., +46701234567 or 0701234567).");
                }
            } while (string.IsNullOrWhiteSpace(phoneNumber) || !ValidationHelper.IsValidPhoneNumber(phoneNumber));


            //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att det krävs validering av en svensk gatuadress för att fortsätta med hjälp av en do-loop.

            string streetAddress;
            do
            {
                Console.Write("Street Address: ");
                streetAddress = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(streetAddress))
                {
                    Console.WriteLine("Street Address cannot be empty. Please try again.");
                }
                else if (!ValidationHelper.IsValidStreetAddress(streetAddress))
                {
                    Console.WriteLine("Invalid Street Address format. Please use a valid Swedish format (e.g., Storgatan 5 or Sveavägen 123A).");
                }
            } while (string.IsNullOrWhiteSpace(streetAddress) || !ValidationHelper.IsValidStreetAddress(streetAddress));


            //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att det krävs validering av ett svenskt postnummer för att fortsätta med hjälp av en do-loop.

            string postalCode;
            do
            {
                Console.Write("Postal Code: ");
                postalCode = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(postalCode))
                {
                    Console.WriteLine("Postal Code cannot be empty. Please try again.");
                }
                else if (!ValidationHelper.IsValidPostalCode(postalCode))
                {
                    Console.WriteLine("Invalid Postal Code format. Please use a Swedish format.");
                }
            } while (string.IsNullOrWhiteSpace(postalCode) || !ValidationHelper.IsValidPostalCode(postalCode));


            //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att det krävs validering av en svensk ort för att fortsätta med hjälp av en do-loop.

            string city;
            do
            {
                Console.Write("City: ");
                city = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(city))
                {
                    Console.WriteLine("City cannot be empty. Please try again.");
                }
                else if (!ValidationHelper.IsValidCity(city))
                {
                    Console.WriteLine("Invalid city name. Please use a valid Swedish city name (e.g., Stockholm, Göteborg).");
                }
            } while (string.IsNullOrWhiteSpace(city) || !ValidationHelper.IsValidCity(city));

            var result = _contactService.CreateContact(firstName, lastName, email, phoneNumber, streetAddress, postalCode, city);

            if (result)
            {
                Console.WriteLine("Contact was created succesfully.");
                _contactService.SaveContacts(FilePath); //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att den sparar kontakterna efter en kontakt lagts till.
            }
            else
            {
                Console.WriteLine("Unable to create new contact");
            }
            Console.ReadKey();
        }

        private void ViewAllContacts()
        {
            Console.Clear();
            Console.WriteLine("### VIEW ALL CONTACTS");

            //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att jag kan skicka iväg ett meddelande ifall listan är tom.

            var contacts = _contactService.GetAllContacts(); // Hämtar alla kontakter från _contactService.

            if (contacts.Count == 0) // Kontrollerar om listan är tom.
            {
                Console.WriteLine("No contacts to display."); // Visar ett meddelande ifall listan är tom.
            }
            else
            {
                foreach (var contact in contacts)  // Om listan inte är tom, går programmet igenom varje kontakt och visar deras information.
                {
                    Console.WriteLine($"{contact.FirstName} {contact.LastName} ({contact.Id})");
                }

            }
            Console.ReadKey ();
        }

    }
}
