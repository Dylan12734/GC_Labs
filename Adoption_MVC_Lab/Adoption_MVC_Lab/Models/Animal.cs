using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adoption_MVC_Lab.Models;

public class Animal
{
    public int Id { get; set; }
    [Required]
    public string Img { get; set; }
    [Required]
    [Column(TypeName = "varchar(50)")]
    public string Name { get; set; }
    [Required]
    [Column(TypeName = "varchar(200)")]
    public string Description { get; set; }
    [Required]
    [Column(TypeName = "varchar(50)")]
    public string Breed { get; set; }
    public int Age { get; set; }

}
