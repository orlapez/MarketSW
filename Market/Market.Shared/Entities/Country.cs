using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Market.Shared.Entities
{
    public class Country
    {

        public int Id { get; set; }// primary key, identity(1,1)

        [Display (Name="Pais")] // Son etiquetas del nombre del campo
       [MaxLength (100,ErrorMessage ="El campo {0} debe contener únicamente 100 caracteres")] // Es la longitud de caracteres del campo}
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Name { get; set; }    // ?(indica que hace un salto de nulos)

        [JsonIgnore]
        public ICollection<State> States { get; set;}
    }
}
