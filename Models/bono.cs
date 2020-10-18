using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BONO.Models
{
    [Table ("registro_bono")]
    public class bono
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [Required(ErrorMessage = "Por favor, ingrese el Nombre")]
        [Display(Name="Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el Apellido")]
        [Display(Name="Apellido")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el Distrito")]
        [Display(Name="Distrito")]
        public String Distrito { get; set; }
        
        public String banco { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su Edad")]
        [Display(Name="Edad")]
        public int Edad { get; set; }

        public String genero { get; set; }

        public String Response { get; set; }

    }
}