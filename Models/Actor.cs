using System.ComponentModel.DataAnnotations;

namespace MyCineTime.Models;

public class Actor
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Profil Resmi")]
    [Required(ErrorMessage = "Bu alan zorunludur.")]
    public string ProfilePictureURL { get; set; }
    [Display(Name = "Ad-Soyad")]
    [Required(ErrorMessage = "Bu alan zorunludur.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "En az 3, en fazla 50 karakter girilmelidir.")]
    public string FullName { get; set; }
    [Display(Name = "Biyografi")]
    [Required(ErrorMessage = "Bu alan zorunludur.")]
    public string Bio { get; set; }
    [Required(ErrorMessage = "Bu alan zorunludur.")]
    
    //Relationships
    public List<Actor_Movie> Actors_Movies { get; set; }
}