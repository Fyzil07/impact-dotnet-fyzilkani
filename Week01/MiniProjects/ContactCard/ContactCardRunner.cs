namespace Week01.MiniProjects.ContactCard;

public static class ContactCardRunner
{
    public static void Run()
    {
        ContactCard[] contacts =
        [
            new()
            {
                Name = "Alice",
                PhoneNumber = "1111111111",
                Email = "alice@test.com"
            },

            new()
            {
                Name = "Bob",
                PhoneNumber = "2222222222",
                Email = "bob@test.com"
            },

            new()
            {
                Name = "Charlie",
                PhoneNumber = "3333333333",
                Email = "charlie@test.com"
            },

            new()
            {
                Name = "David",
                PhoneNumber = "4444444444",
                Email = "david@test.com"
            },

            new()
            {
                Name = "Emma",
                PhoneNumber = "5555555555",
                Email = "emma@test.com"
            }
        ];

        Console.Write("Enter name to search: ");

        string searchName =
            Console.ReadLine()!;

        ContactCard? foundContact = null;

        foreach (ContactCard contact in contacts)
        {
            if (contact.Name.Equals(
                    searchName,
                    StringComparison.OrdinalIgnoreCase))
            {
                foundContact = contact;

                break;
            }
        }

        if (foundContact.HasValue)
        {
            Console.WriteLine("\nContact Found:");

            Console.WriteLine(
                $"Name: {foundContact.Value.Name}");

            Console.WriteLine(
                $"Phone: {foundContact.Value.PhoneNumber}");

            Console.WriteLine(
                $"Email: {foundContact.Value.Email}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}