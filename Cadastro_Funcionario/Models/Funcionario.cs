using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro_Funcionário_Funcional.Models;

[Table ("FUNCIONARIO")]
public class Funcionario
{

    [Key]
    public int Id { get; set; }

    [Required]
    public string? Cpf { get; set; }

    [Required(ErrorMessage = "O campo nome é obrigatório.")]
    public string? Nome { get; set; }     

    [Required]
    public string? Rg { get; set; }

    [Required]
    public string? OrgaoEmissor { get; set; }

    [Required]
    public string? TituloEleitor { get; set; }

    public string? Cnh { get; set; }

    public bool Gestor { get; set; }

    public Endereco? endereco { get; set; }

}
