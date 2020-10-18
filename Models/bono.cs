using System;
using System.ComponentModel.DataAnnotations;

namespace BONO.Models
{
    public class bono
    {
        [Required(ErrorMessage = "Por favor, ingrese el Nombre")]
        [Display(Name="Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el Apellido")]
        [Display(Name="Apellido")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el Distrito")]
        [Display(Name="Distrito")]
        public String Distrito { get; set; }
        
        public String Acccion { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su Edad")]
        [Display(Name="Edad")]
        public int Edad { get; set; }

        public String Acccion2 { get; set; }

        public String Response { get; set; }

    }
}