using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11_Diego
{
    public class Constructor
    {
        private string Codigo;
        private string Apellidos;
        private string Nombres;
        private string CondicionC;
        private string Especialidad;
        private int sueldoBase;
        private double descuento;
        private double bonificacion;


        public double SueldoBruto()
        {
            return sueldoBase + bonificacion;
        }
        public virtual double SueldoNeto()
        {
            return SueldoBruto()-descuento;
        }
        public void setSueldo(int sueldoBase)
        {
            if (sueldoBase == 4000 || sueldoBase == 6000 || sueldoBase == 2000 || sueldoBase == 4500 || sueldoBase == 0)
            {
                this.sueldoBase = sueldoBase;
            }
        }
        public int getSueldoBase()
        {
            return sueldoBase;
        }
        public void setDescuento(double Descuento)
        {
            this.descuento = Descuento;
        }
        public double getDescuento()
        {
            return descuento;
        }
        public void setBonificacion(double Bonificacion)
        {
            bonificacion = Bonificacion;
        }
        public double getBonificacion()
        {
            return bonificacion;
        }
        public void setCodigo(string codigo)
        {
            Codigo = codigo;
        }
        public string getCodigo()
        {
            return Codigo;
        }
        public string getApellidos()
        {
            return Apellidos;
        }
        public void setApellidos(string Apellidos)
        {
            this.Apellidos = Apellidos;
        }
        public string getNombres()
        {
            return Nombres;
        }
        public void setNombres(string Nombres)
        {
            this.Nombres = Nombres;
        }
        public string getCondicionC()
        {
            return CondicionC;
        }
        public void setCondicionC(string CondicionC)
        {
            this.CondicionC = CondicionC;
        }
        public string getEspecialidad()
        {
            return Especialidad;
        }
        public void setEspecialidad(string Especialidad)
        {
            this.Especialidad = Especialidad;
        }
    }
}
