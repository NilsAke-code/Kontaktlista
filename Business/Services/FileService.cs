using Business.Interfaces;
using System.Text.Json;
using Business.Models;

namespace Business.Services;

public class FileService : IFileService
{
    public void SaveToFile(string filePath, List<ContactModel> contacts)
    {

        //  Detta är genererat av Chat GPT 4.0 - Denna kod gör att listan med kontakter omvandlas till en Json sträng som
        //  sparas på en angiven filplats som man sedan kan öppna med olika program för att läsa.

        var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public List<ContactModel> LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {

            // Detta är generert av Chat GPT 4.0 - Denna kod gör att en tom lista returneras om filen inte existerar, vilket förhindrar appen från att krascha.
            return new List<ContactModel>();
        }
        var json = File.ReadAllText(filePath);


        // Detta är genererat av Chat GPT 4.0 - Denna kod gör att Json strängen läses in från filen och omvandlas tillbaka till en lista med kontakter.
        // Går något fel eller om filen är tom så returneras en tom lista istället.
        return JsonSerializer.Deserialize<List<ContactModel>>(json) ?? new List<ContactModel>();

    }
}
