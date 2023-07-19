using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        // atributo privado
        private DateTime _nacimiento;
        public string getNacimiento()
        {
            return _nacimiento.ToString();
        }
        public void setNacimiento(DateTime naci)
        {
            _nacimiento = naci;
        }

        private int _dni;
        public int getDNI()
        {
            return _dni;
        }
        public void setDNI(int dni)
        {
            _dni = dni;
        }

        private int _telefono;
        public int getTelefono()
        {
            return _telefono;
        }
        public void setTelefono(int tel)
        {
            _telefono = tel;
        }

        // propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad
        {
            get { return CalculoEdad(); }
        }
        public string Nacionalidad
        {
            get { return CalculoPais(); }
        }
        
        // Metodo para calcular edad
        private int CalculoEdad()
        {
            int edad = DateTime.Now.Year - _nacimiento.Year;
            if (DateTime.Now.Month < _nacimiento.Month)
            {
                edad -= 1;
            }
            if (DateTime.Now.Month == _nacimiento.Month && DateTime.Now.Day < _nacimiento.Day)
            {
                edad -= 1;
            }
            return edad;
        }
        
        // metodo para calcular pais
        private string CalculoPais()
        {
            string pais;
            if (_dni > 0 && _dni < 99999999)
            {
                pais = "Argentino";
                return pais;
            }
            else
            {
                pais = "Extranjero";
                return pais;
            }
        }
    }
}
