using Business.Models;

namespace Business.Interfaces
{
    public interface IFileService
    {
        void SaveToFile(string filePath, List<ContactModel> contacts);
        List<ContactModel> LoadFromFile(string filePath);
    }
}
