using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1
{
    internal class Nodo
    {
        //La clase tiene cuatro campos: paciente, pacientes, nodoPadre y nodosHijos.
        public Paciente paciente;
        private List<Paciente> pacientes;
        private Nodo nodoPadre;
        private List<Nodo> nodosHijos;

        public Nodo()
        {
            pacientes = new List<Paciente>();
            nodosHijos = new List<Nodo>();
        }

        //Este código define una propiedad Pacientes en la clase Nodo. La propiedad es del tipo List<Paciente> y tiene un getter y un setter.
        //El getter devuelve la lista de pacientes actualmente almacenados en el nodo y el setter establece la lista de pacientes en el nodo.
        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }

        //La propiedad es de tipo "Nodo", lo que significa que puede contener una referencia a otro objeto "Nodo".
        //El objetivo de esta propiedad es permitir que cada nodo de un árbol pueda acceder a su nodo padre.
        public Nodo NodoPadre
        {
            get { return nodoPadre; }
            set { nodoPadre = value; }
        }

        //La propiedad tiene un getter y un setter, lo que significa que se puede acceder y modificar la lista de nodos hijos desde fuera de la clase Nodo
        public List<Nodo> NodosHijos
        {
            get { return nodosHijos; }
            set { nodosHijos = value; }
        }

        //La función AgregarPaciente agrega un objeto Paciente a la lista de pacientes del nodo actual.
        public void AgregarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        //La función AgregarNodoHijo agrega un objeto Nodo como hijo del nodo actual. Para hacer esto, establece la referencia
        //NodoPadre del nodo hijo para apuntar al nodo actual y luego agrega el nodo hijo a la lista de NodosHijos del nodo actual.
        public void AgregarNodoHijo(Nodo nodoHijo)
        {
            nodoHijo.NodoPadre = this;
            nodosHijos.Add(nodoHijo);
        }

        //La función ObtenerNodoHijo busca un nodo hijo con el nombre de paciente especificado en la lista de NodosHijos del nodo actual y lo devuelve.
        //Si no se encuentra un nodo hijo con el nombre especificado, devuelve null. 
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
