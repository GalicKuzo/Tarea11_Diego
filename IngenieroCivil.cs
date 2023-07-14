using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tarea11_Diego
{
    public class IngenieroCivil : Constructor
    {
        private int obras;
        private static int countIng = 0;
        public IngenieroCivil(string Apellidos, string Nombres, string CondicionC, string Especialidad, int obras)
        {
            setApellidos(Apellidos);
            setNombres(Nombres);
            setCondicionC(CondicionC);
            setEspecialidad(Especialidad);
            this.obras = obras;
            countIng++;
            Codigo();
        }
        public void Codigo()
        {
            if (countIng < 10)
                setCodigo("INGC0000" + countIng);
            if (countIng >= 10 && countIng < 100)
                setCodigo("INGC000" + countIng);
        }
        public int getContador()
        {
            return countIng;
        }
        public int getObras()
        {
            return obras;
        }
        public int Movilidad()
        {
            if (obras < 17)
                return 300;
            else
                return 600;
        }
        public override double SueldoNeto()
        {
            return (SueldoBruto() - getDescuento()) + Movilidad();
        }
        public void SueldoBase(string Cargo)
        {
            switch (getCondicionC())
            {
                case "Estable":
                    if (Cargo == "Supervisión de Obras")
                    {
                        setSueldo(4000);
                    }
                    if (Cargo == "Supervisión de Vías")
                    {
                        setSueldo(6000);
                    }
                    break;
                case "Contratado":
                    if (Cargo == "Supervisión de Obras")
                    {
                        setSueldo(2000);
                    }
                    else if (Cargo == "Supervisión de Vías")
                    {
                        setSueldo(4500);
                    }
                    break;
                default:
                    setSueldo(0);
                    break;
            }
        }
        public void Descuento(string Seguro)
        {
            if (Seguro == "AFP")
            {
                setDescuento(getSueldoBase() * 0.17);
            }
            if (Seguro == "Essalud")
                setDescuento(getSueldoBase() * 0.05);
        }
        public void Bonificacion()
        {
            if (getEspecialidad() == "Estructuras")
                setBonificacion(getSueldoBase()*0.16);
            if (getEspecialidad() == "Recursos Hídricos")
                setBonificacion(getSueldoBase() * 0.18);
            if (getEspecialidad() == "Ingeniería Vial")
                setBonificacion(getSueldoBase() * 0.22);
        }
    }
}
