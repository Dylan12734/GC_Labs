using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShopRegistration.Models;

public class User
{
    public int Id { get; set; }
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string UserName { get; set; }
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    
    public string Password { get; set; }
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string FirstName { get; set; }
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string LastName { get; set; }
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
