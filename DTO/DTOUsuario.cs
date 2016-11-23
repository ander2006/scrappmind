using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOUsuario
    {

        private string codigo;
        private string cedula;
        private string usuario;
        private string clave;
        private string administrador;
        private string operativo;

        public string Id
        {
            get { return codigo; }

            set { codigo = value; }
        }

        public string Nombre
        {
            get { return cedula; }

            set { cedula = value; }
        }

        public string Usuario
        {
            get { return usuario; }

            set { usuario = value; }
        }

        public string Clave
        {
            get { return clave; }

            set { clave = value; }
        }

        public string Administrador
        {
            get
            {
                return administrador;
            }

            set
            {
                administrador = value;
            }
        }

        public string Operativo
        {
            get
            {
                return operativo;
            }

            set
            {
                operativo = value;
            }
        }
    }
}
