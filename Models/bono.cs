using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BONO.Models
{
    [Table ("registro_bono")]
    public class bono
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        [Required(ErrorMessage = "Por favor, ingrese el Nombre")]
        [Display(Name="Nombre")]
        [Column("Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el Apellido")]
        [Display(Name="Apellido")]
        [Column("Apellido")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el Distrito")]
        [Display(Name="Distrito")]
        [Column("Distrito")]
        public String Distrito { get; set; }
        
        
        [Required(ErrorMessage = "Por favor, ingrese su banco")]
        [Display(Name="banco")]
        public String banco { get; set; }
        [Column("banco")]


        [Required(ErrorMessage = "Por favor, ingrese su Edad")]
        [Display(Name="Edad")]       
        public int Edad { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su genero")]
        [Display(Name="genero")]  
        public String genero { get; set; }

       [NotMapped]
        public String Response { get; set; }

    }
}