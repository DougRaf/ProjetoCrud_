using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCrud_.Models
{
    [Table("Operadoras")]

    public class Operadoras
    {     
   
            [Display(Name = "Código")]
            [Column("Id")]
            public int Id { get; set; }

            [Display(Name = "Operadora")]
            [Column("Operadora")]
            public string Operadora { get; set; }     

    }

}
