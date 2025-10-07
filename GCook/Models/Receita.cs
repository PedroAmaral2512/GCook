using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;
[Table("Receita")]
public class Receita
{
     
    [Key]      
    public int Id {get; set;}
    [Display(Name ="Categoria")]
    [Required(ErrorMessage = "A Categoria é obrigatória")]
    
    public int CategoriaId {get; set;}
    [ForeignKey("CategoriaId")]
    [Display(Name ="Categoria")]

    [StringLength(300)]
    public string Nome
}