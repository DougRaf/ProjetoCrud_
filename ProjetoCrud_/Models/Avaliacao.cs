using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCrud_.Models
{
    [Table("Avaliacao")]
    public class Avaliacao
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Avaliação")]
        [Column("Avaliacao")]
        public string Avaliação { get; set; }


        [Display(Name = "Operadora")]
        [Column("Aoperadora")]
        public string Aoperadora { get; set; }


        [Display(Name = "Usuário")]
        [Column("Ouser")]
        public string Ouser { get; set; }

    }
}
