﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11_Diego
{
    public class Arquitecto : Constructor
    {
        private int proyectos;
        private static int countArqui = 0;
        public Arquitecto(string Apellidos, string Nombres, string CondicionC, string Especialidad, int proyectos, string seguro, string cargo)
        {
            setApellidos(Apellidos);
            setNombres(Nombres);
            setCondicionC(CondicionC);
            setEspecialidad(Especialidad);
            setSeguro(seguro);
            setCargo(cargo);
            this.proyectos = proyectos;
            countArqui++;
            Codigo();
            SueldoBase();
            Descuento();
            Bonificacion();
        }
        public int getProyectos()
        {
            return proyectos;
        }
        public void Codigo()
        {
            if (countArqui < 10)
                setCodigo("ARQ0000" + countArqui);
            if (countArqui >= 10 && countArqui < 100)
                setCodigo("ARQC000" + countArqui);
        }
        public void SueldoBase()
        {
            switch (getCondicionC())
            {
                case "Estable":
                    if (getEspecialidad() == "Restauración y Rehabilitación")
                    {
                        setSueldo(4600);
                    }
                    if (getEspecialidad() == "Materiales de Construcción")
                    {
                        setSueldo(7500);
                    }
                    if (getEspecialidad() == "Paísajismo y Jardinería")
                    {
                        setSueldo(4860);
                    }
                    break;
                case "Contratado":
                    if (getEspecialidad() == "Restauración y Rehabilitación")
                    {
                        setSueldo(3980);
                    }
                    if (getEspecialidad() == "Materiales de Construcción")
                    {
                        setSueldo(4600);
                    }
                    if (getEspecialidad() == "Paisajismo y Jardinería")
                    {
                        setSueldo(4600);
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
                setDescuento(0);
        }
        public void Bonificacion()
        {
            if (getCargo() == "Director de Obras")
                setBonificacion(getSueldoBase() * 0.25);
            if (getCargo() == "Edificador Industrial")
                setBonificacion(getSueldoBase() * 0.29);
        }
    }
}
