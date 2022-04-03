using BlazorDashboard.Models;

namespace BlazorDashboard.Interfaces;
public interface IDataService
{
    public List<User> GetUsers();
}