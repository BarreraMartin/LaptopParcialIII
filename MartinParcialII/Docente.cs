using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinParcialII
{
    public class Docente
    {
        [Key]
        public int DocenteId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [Required]
        public string Apellido { get; set; }
        [MaxLength(50)]
        [Required]
        public string Aula { get; set; }
        [Required]
        public int LaptopId { get; set; }

        public virtual Laptop Laptops { get; set; }


    }
}
