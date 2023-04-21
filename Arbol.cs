using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1
{
    internal class Arbol
    {
        //La variable raiz es de tipo Nodo y representa el nodo raíz del árbol.
        private Nodo raiz;

        //El constructor de la clase Arbol inicializa la variable raiz con un nuevo objeto Nodo.
        public Arbol()
        {
            raiz = new Nodo();
        }

        //La propiedad Raiz es un getter y setter que permite acceder y modificar el valor de la variable raiz.
        public Nodo Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        //El método AgregarPaciente recibe un objeto Paciente como parámetro y lo agrega al árbol en la posición correspondiente.
        public void AgregarPaciente(Paciente paciente)
        {
            Nodo nodoActual = raiz;

            foreach (Nodo nodoHijo in nodoActual.NodosHijos)
            {
                if (nodoHijo.Pacientes.Any(p => p.TipoSangre == paciente.TipoSangre))
                {
                    nodoActual = nodoHijo;
                    break;
                }
            }

            foreach (Nodo nodoHijo in nodoActual.NodosHijos)
            {
                if (nodoHijo.Pacientes.Any(p => p.Genero == paciente.Genero))
                {
                    nodoActual = nodoHijo;
                    break;
                }
            }

            foreach (Nodo nodoHijo in nodoActual.NodosHijos)
            {
                if (nodoHijo.Pacientes.Any(p => p.PresionArterial == paciente.PresionArterial))
                {
                    nodoActual = nodoHijo;
                    break;
                }
            }

            nodoActual.AgregarPaciente(paciente);
        }

        //public List<Paciente> BuscarPacientes(string tipoSangre, string genero, string presionArterial)
        //{
        //    Nodo nodoActual = raiz;

        //    foreach (Nodo nodoHijo in nodoActual.NodosHijos)
        //    {
        //        if (nodoHijo.Pacientes.Any(p => p.TipoSangre == tipoSangre))
        //        {
        //            nodoActual = nodoHijo;
        //            break;
        //        }
        //    }

        //    foreach (Nodo nodoHijo in nodoActual.NodosHijos)
        //    {
        //        if (nodoHijo.Pacientes.Any(p => p.Genero == genero))
        //        {
        //            nodoActual = nodoHijo;
        //            break;
        //        }
        //    }

        //    foreach (Nodo nodoHijo in nodoActual.NodosHijos)
        //    {
        //        if (nodoHijo.Pacientes.Any(p => p.PresionArterial == presionArterial))
        //        {
        //            nodoActual = nodoHijo;
        //            break;
        //        }
        //    }

        //    return nodoActual.Pacientes;
        //}

        //Este fragmento de código define un método llamado BuscarPacientesNombre que recibe un parámetro nombre de tipo string y devuelve una lista de objetos Paciente.
        public List<Paciente> BuscarPacientesNombre(string nombre)
        {
            Nodo nodoActual = raiz;
            List<Paciente> pacientesCoincidentes = new List<Paciente>();

            // Recorrer el árbol para encontrar el nodo que contiene el paciente buscado
            while (nodoActual != null)
            {
                foreach (Paciente paciente in nodoActual.Pacientes)
                {
                    if (paciente.Nombre.ToLower().Contains(nombre.ToLower()))
                    {
                        pacientesCoincidentes.Add(paciente);
                    }
                }

                nodoActual = nodoActual.ObtenerNodoHijo(nombre);
            }

            return pacientesCoincidentes;
        }

        //El primer método Pacientes simplemente devuelve una lista de todos los pacientes del árbol,
        //accediendo a la lista de pacientes en el nodo raíz del árbol.
        public List<Paciente> Pacientes
        {
            get { return raiz.Pacientes; }
        }

        //El segundo método BuscarPaciente recorre todo el árbol y busca todos los pacientes cuyo nombre contiene la cadena de búsqueda especificada.
        //Para ello, se utiliza el método privado ObtenerPacientes que se encarga de recorrer todo el árbol y devolver una lista de todos los pacientes en el mismo.
        public List<Paciente> BuscarPaciente(string nombre)
        {
            List<Paciente> pacientesCoincidentes = new List<Paciente>();

            foreach (Paciente paciente in ObtenerPacientes())
            {
                if (paciente.Nombre.ToLower().Contains(nombre.ToLower()))
                {
                    pacientesCoincidentes.Add(paciente);
                }
            }

            return pacientesCoincidentes;
        }

        //Este fragmento de código define una propiedad de la clase Arbol llamada Pacientes.
        //La propiedad devuelve una lista de objetos Paciente
        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            ObtenerPacientes(raiz, ref pacientes);
            return pacientes;
        }

        //Este fragmento de código define un método privado llamado ObtenerPacientes que recibe dos parámetros: nodo de tipo Nodo y pacientes de tipo List<Paciente>.
        //Este método se utiliza para obtener todos los pacientes almacenados en el árbol, incluyendo aquellos que están en los nodos hijos del árbol.
        private void ObtenerPacientes(Nodo nodo, ref List<Paciente> pacientes)
        {
            if (nodo == null) return;

            foreach (var paciente in nodo.Pacientes)
            {
                pacientes.Add(paciente);
            }

            foreach (var hijo in nodo.NodosHijos)
            {
                ObtenerPacientes(hijo, ref pacientes);
            }
        }

        //Este fragmento de código define un método público llamado EliminarPaciente que recibe un parámetro de tipo string llamado nombre.
        //El método se utiliza para eliminar un paciente del árbol.
        public bool EliminarPaciente(string nombre)
        {
            Nodo nodoPadre = null;
            Nodo nodoHijo = this.raiz;
            bool eliminado = false;

            while (nodoHijo != null)
            {
                if (nodoHijo.Pacientes.Any(p => p.Nombre == nombre))
                {
                    // Encontramos el nodo que contiene al paciente a eliminar
                    Paciente paciente = nodoHijo.Pacientes.Single(p => p.Nombre == nombre);
                    nodoHijo.Pacientes.Remove(paciente);
                    eliminado = true;
                    break;
                }
                else
                {
                    nodoPadre = nodoHijo;
                    nodoHijo = nodoHijo.ObtenerNodoHijo(nombre);
                }
            }

            return eliminado;
        }

        //public bool ActualizarPaciente(string nombre, Paciente pacienteActualizado)
        //{
        //    Nodo nodoPadre = null;
        //    Nodo nodoHijo = this.raiz;
        //    bool actualizado = false;

        //    while (nodoHijo != null)
        //    {
        //        if (nodoHijo.Pacientes.Any(p => p.Nombre == nombre))
        //        {
        //            // Encontramos el nodo que contiene al paciente a actualizar
        //            Paciente paciente = nodoHijo.Pacientes.Single(p => p.Nombre == nombre);
        //            paciente.TipoSangre = pacienteActualizado.TipoSangre;
        //            paciente.Genero = pacienteActualizado.Genero;
        //            paciente.PresionArterial = pacienteActualizado.PresionArterial;
        //            actualizado = true;
        //            break;
        //        }
        //        else
        //        {
        //            nodoPadre = nodoHijo;
        //            nodoHijo = nodoHijo.ObtenerNodoHijo(nombre);
        //        }
        //    }

        //    return actualizado;
        //}


    }
}
