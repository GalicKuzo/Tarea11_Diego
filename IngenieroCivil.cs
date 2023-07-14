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
        public IngenieroCivil(string Apellidos, string Nombres, string CondicionC, string Especialidad, int obras,string seguro, string cargo)
        {
            setApellidos(Apellidos);
            setNombres(Nombres);
            setCondicionC(CondicionC);
            setEspecialidad(Especialidad);
            setSeguro(seguro);
            setCargo(cargo);
            this.obras = obras;
            countIng++;
            Codigo();
            SueldoBase();
            Descuento();
            Bonificacion();
        }
        public void Codigo()
        {
            if (countIng < 10)
                setCodigo("INGC0000" + countIng);
            if (countIng >= 10 && countIng < 100)
                setCodigo("INGC000" + countIng);
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
        public void SueldoBase()
        {
            switch (getCondicionC())
            {
                case "Estable":
                    if (getCargo() == "Supervisión de Obras")
                    {
                        setSueldo(4000);
                    }
                    if (getCargo() == "Supervisión de Vías")
                    {
                        setSueldo(6000);
                    }
                    break;
                case "Contratado":
                    if (getCargo() == "Supervisión de Obras")
                    {
                        setSueldo(2000);
                    }
                    else if (getCargo() == "Supervisión de Vías")
                    {
                        setSueldo(4500);
                    }
                    break;
                default:
                    setSueldo(0);
                    break;
            }
        }
        public void Descuento()
        {
            if (getSeguro() == "AFP")
            {
                setDescuento(getSueldoBase() * 0.17);
            }
            if (getSeguro() == "Essalud")
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
