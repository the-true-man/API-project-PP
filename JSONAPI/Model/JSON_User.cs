using Newtonsoft.Json;
using project_PP;
using System.IO;
namespace JSONAPI.Model
{
    public class JSON_User
    {
        public static string pathUsers = "C:\\Users\\evgenijmihajlov\\YandexDisk\\Проекты третьего курса\\project_PP\\project_PP\\bin\\Debug\\net8.0-windows\\allUsers1.json";
        public static List<Person> getUsers()
        {
            return JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(pathUsers));
        }
        public static void setUser(List<Person> persons)
        {
            File.WriteAllText(pathUsers, JsonConvert.SerializeObject(persons, Formatting.Indented));
        }
    }
}
