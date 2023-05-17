using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinParcialII
{
   public class Laptop
    {
        [Key]
        public int LaptopId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [Required]
        public string Marca { get; set; }
        [MaxLength(50)]
        [Required]
        public string MemoriaRam { get; set; }
        [MaxLength(50)]
        [Required]
        public string Procesador { get; set; }
        [MaxLength(50)]
        [Required]
        public string Disco { get; set; }

        public virtual ICollection<Docente> Docentes { get; set; }
    }

    
}
