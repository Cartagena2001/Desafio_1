using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1
{
    internal class Nodo
    {

        public Paciente paciente;
        private List<Paciente> pacientes;
        private Nodo nodoPadre;
        private List<Nodo> nodosHijos;

        public Nodo()
        {
            pacientes = new List<Paciente>();
            nodosHijos = new List<Nodo>();
        }

        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }

        public Nodo NodoPadre
        {
            get { return nodoPadre; }
            set { nodoPadre = value; }
        }

        public List<Nodo> NodosHijos
        {
            get { return nodosHijos; }
            set { nodosHijos = value; }
        }

        public void AgregarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public void AgregarNodoHijo(Nodo nodoHijo)
        {
            nodoHijo.NodoPadre = this;
            nodosHijos.Add(nodoHijo);
        }

        public Nodo ObtenerNodoHijo(string nombre)
        {
            foreach (Nodo nodoHijo in nodosHijos)
            {
                if (nodoHijo.paciente.Nombre == nombre)
                {
                    return nodoHijo;
                }
            }
            return null;
        }

    }
}
