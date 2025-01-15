using Business.Interfaces;
using System.Text.Json;
using Business.Models;

namespace Business.Services
{
    public class FileService : IFileService
    {
        public void SaveToFile(string filePath, List<ContactModel> contacts)
        {
            var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public List<ContactModel> LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<ContactModel>();
            }
            var json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<ContactModel>>(json) ?? new List<ContactModel>();

        }
    }
}
