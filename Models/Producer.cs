using System.ComponentModel.DataAnnotations;

namespace MyCineTime.Models;

public class Producer
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Profil resmi")]
    public string ProfilePictureURL { get; set; }
    [Display(Name = "Ad-Soyad")]
    public string FullName { get; set; }
    [Display(Name = "Biyografi")]
    public string Bio { get; set; }
    
    //Relationships
    public List<Movie> Movies { get; set; }
}