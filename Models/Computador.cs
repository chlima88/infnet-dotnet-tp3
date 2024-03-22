using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TpMVC.Models
{
    public class Computador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Processador { get; set; }
        [Required]
        public string PlacaMae { get; set; }
        [Required]
        public string Memoria {  get; set; }
        [Required]
        [DisplayName("HD")]
        public string Hd { get; set; }
        [Required]
        [DisplayName("Patrimonio")]
        public string NumeroPatrimonio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Data de Compra")]
        public DateOnly DataCompra {  get; set; }

    }
}
