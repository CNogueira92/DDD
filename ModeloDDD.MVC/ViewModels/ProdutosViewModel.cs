using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModeloDDD.MVC.ViewModels
{
    public class ProdutosViewModel
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
    }
}