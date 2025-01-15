using Business.Interfaces;

namespace Kontaktlista.Dialogs
{

    public class MenuDialogs
    {
        private readonly IContactService _contactService;

        private const string FilePath = "contacts.json"; // Chatgpt 4o fick hjälpa mig, contacts.json är standardfilen för att lagra kontakter.
        public MenuDialogs(IContactService contactService)
        {
            _contactService = contactService;
        }

        public void MainMenu()
        {

            _contactService.LoadContacts(FilePath); // chatgpt 4o fick hjälpa mig, den laddar kontakter från filen vid start.
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
                        _contactService.SaveContacts(FilePath); // Chatgpt 4o fick hjälpa mig, den sparar kontakter vid avslut.
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

            // Chatgpt 4o hjälpte mig använda null-coalescing operator (??), Console.Readline() returnerade null och genom ?? string.Empty ger man ett standardvärde.

            Console.Write("Firstname: ");
            string firstName = Console.ReadLine() ?? string.Empty;

            Console.Write("Lastname: ");
            string lastName = Console.ReadLine() ?? string.Empty;

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? string.Empty;

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine() ?? string.Empty;

            Console.Write("Street Address: ");
            string streetAddress = Console.ReadLine() ?? string.Empty;

            Console.Write("Postal Code: ");
            string postalCode = Console.ReadLine() ?? string.Empty;

            Console.Write("City: ");
            string city = Console.ReadLine() ?? string.Empty;

            var result = _contactService.CreateContact(firstName, lastName, email, phoneNumber, streetAddress, postalCode, city);

            if (result)
            {
                Console.WriteLine("Contact was created succesfully.");
                _contactService.SaveContacts(FilePath); // chatgpt 4o fick hjälpa mig, den sparar kontakterna efter en kontakt lagts till.
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

            // använde Chatgpt 4o för att visa ett meddelande ifall listan är tom.

            var contacts = _contactService.GetAllContacts(); // Jag hämtar kontakter från contactService.

            if (contacts.Count == 0) // Den kontrollerar om listan är tom.
            {
                Console.WriteLine("No contacts to display."); // Visar ett meddelande ifall listan är tom.
            }
            else
            {
                foreach (var contact in contacts)  // om listan inte är tom, går programmet igenom varje kontakt och visar deras information.
                {
                    Console.WriteLine($"{contact.FirstName} {contact.LastName} ({contact.Id})");
                }

            }
            Console.ReadKey ();
        }

    }
}
