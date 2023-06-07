using System.ComponentModel.DataAnnotations;

namespace MyCineTime.Models;

public class Cinema
{
    [Key]
    public int Id { get; set; }
    [Display(Name= "Sinema")]
    public string Logo { get; set; }
    [Display(Name= "İsim")]
    public string Name { get; set; }
    [Display(Name = "Hakkında")]
    public string Description { get; set; }
    
    //Relationships
    public List<Movie> Movies { get; set; }
}