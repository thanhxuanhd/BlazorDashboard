using System.ComponentModel.DataAnnotations;

namespace BlazorDashboard.Models;

public class UserViewModel
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public string Language { get; set; }

    [Required]
    public List<UserRole> Roles { get; set; }
}

public class UserRole
{

    public string RoleId { get; set; }

    public string RoleName { get; set; }

    public bool IsChecked { get; set; }
}

public enum RoleEnum
{
    ROLE_ADMIN,
    ROLE_MANAGER,
    ROLE_USER
}