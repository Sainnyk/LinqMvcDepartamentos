using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaMañanaMVCLinq.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [Column("DEPT_NO")]
        public int IdDept { get; set; }
        [Column("DNOMBRE")]
        public string NombreDept { get; set; }
        [Column("LOC")]
        public string LocalidadDept { get; set; }
    }
}
