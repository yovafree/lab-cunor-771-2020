using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcEjemplo1.Models
{
    public class Usuario
    {
        public Usuario()
        {
            this.Id = Guid.NewGuid();
            this.Creado = DateTime.Now;
        }

        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public DateTime Creado { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(50, ErrorMessage = "Logitud máxima 50")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido es requerido")]
        [StringLength(50, ErrorMessage = "Logitud máxima 50")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Email es requerido")]
        [StringLength(100, ErrorMessage = "Logitud máxima 100")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email error")]
        [EmailAddress(ErrorMessage = "Correo electrónico incorrecto")]
        public string Email { get; set; }
    }
}