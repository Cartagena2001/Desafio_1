using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1
{
    internal class Paciente
    {
        private string nombre;
        private string genero;
        private string tipoSangre;
        private string presionArterial;

        public Paciente(string nombre, string genero, string tipoSangre, string presionArterial)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.tipoSangre = tipoSangre;
            this.presionArterial = presionArterial;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string TipoSangre
        {
            get { return tipoSangre; }
            set { tipoSangre = value; }
        }

        public string PresionArterial
        {
            get { return presionArterial; }
            set { presionArterial = value; }
        }
    }
}
