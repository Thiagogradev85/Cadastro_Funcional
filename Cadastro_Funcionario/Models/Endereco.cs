using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro_Funcionário_Funcional.Models;

[Table("Endereco")]
public class Endereco
{
    [Key]
    public int Id { get; set; }
    
    public string? Cep  { get; set; }
    public string? Logradouro { get; set; }
    public int Numero { get; set; }

    public string? Complemento { get; set; }

    public string? PontoReferencia { get; set; }
    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }    

    public bool Ativo { get; set; }

   
}
