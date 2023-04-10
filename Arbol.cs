using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1
{
    internal class Arbol
    {
        private Nodo raiz;

        public Arbol()
        {
            raiz = new Nodo();
        }

        public Nodo Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

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

        public List<Paciente> Pacientes
        {
            get { return raiz.Pacientes; }
        }

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

        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            ObtenerPacientes(raiz, ref pacientes);
            return pacientes;
        }
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
