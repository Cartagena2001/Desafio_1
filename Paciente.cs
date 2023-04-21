using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1
{
    //Esta clase define un objeto Paciente con cuatro atributos: nombre, genero, tipoSangre y presionArterial.
    //La clase también tiene un constructor que acepta los valores para estos atributos y métodos getter y setter para cada atributo.

    //Cada instancia de la clase Paciente representa un paciente con su información personal y médica.
    //esta clase es utilizada en la estructura de datos Árbol para almacenar la información de los pacientes.
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
