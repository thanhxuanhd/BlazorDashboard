using BlazorDashboard.Interfaces;
using BlazorDashboard.Models;
using Newtonsoft.Json;

namespace BlazorDashboard.Services;

public class DataService : IDataService
{
    private readonly IWebHostEnvironment _env;

    private List<User> _users { get; set; }

    public List<User> Users
    {
        get { return _users; }
        set
        {
            _users = value;
        }
    }

    public DataService(IWebHostEnvironment env)
    {
        _env = env;
    }

    public List<User> GetUsers()
    {
        var filePath = Path.Combine(
                _env.WebRootPath, "datas", "users.json");

        var fileContent = File.ReadAllText(filePath);

        if (Users == null)
        {
            Users = JsonConvert.DeserializeObject<List<User>>(fileContent) ?? new List<User>();
        }

        return Users;
    }
}