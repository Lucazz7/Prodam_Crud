using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodam_Crud.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        public string NomePaciente { get; set; }

        public string sexo { get; set; }

        public string telefone { get; set; }

        public string tipo_telefone { get; set; }
    }

    
}
