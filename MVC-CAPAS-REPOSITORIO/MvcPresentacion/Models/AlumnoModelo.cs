using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPresentacion.Models
{
    public class AlumnoModelo
    {

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} debe tener minimo 3 maximo 20 caracteres")]
        [DataType(DataType.Text)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} debe tener minimo 3 maximo 30 caracteres")]
        [DataType(DataType.Text)]
        public string primerApellido { get; set; }

        [DataType(DataType.Text)]
        public string segundoApellido { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", ErrorMessage = "El {0} no tiene el formato")]
       
        public string correo { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El {0} debe tener 10 caracteres")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Range(typeof(DateTime), "1995-01-01", "2010-12-01",ErrorMessage = "La  {0} debe estar en el rango de 1995 y 2010")]
        //[Range(1, 32, ErrorMessage = "El valor debe estar entre")]
        public DateTime fechaNacimiento { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression("^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$", ErrorMessage = "El {0} no tiene el formato")]
         public string curp { get; set; }
        //[Required(ErrorMessage = "El {0} es obligatorio")]
        //[StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} debe tener minimo 3 maximo 60 caracteres")]
        //[DataType(DataType.Text)]
        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        //[RegularExpression("^[A-Z]{1}[AEIOU]{1}[A-Z]{2}$", ErrorMessage = "El {0} no tiene el formato")]
        //[Range(1, 32, ErrorMessage = "El valor debe estar entre")]
        public int idEstadoOrigen { get; set; }
        public short idEstatus { get; set; }
    }
}