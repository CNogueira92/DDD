using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        [EmailAddress (ErrorMessage = "Preencha um e-mail valido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

      //  public IEnumerable<ProdutosViewModel> Produtos { get; set; }

    }
}