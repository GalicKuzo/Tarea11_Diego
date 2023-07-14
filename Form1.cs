using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea11_Diego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_RegistrarInge_Click(object sender, EventArgs e)
        {
            IngenieroCivil inge = new IngenieroCivil(txt_apellidos.Text,txt_nombres.Text,cmbox_condicionC.SelectedItem.ToString(),
                cmbox_especialidadInge.SelectedItem.ToString(), Convert.ToInt32(txt_numeroObras.Text));
            inge.SueldoBase(cmbox_cargoInge.SelectedItem.ToString());
            inge.Descuento(cmbox_seguro.SelectedItem.ToString());
            inge.Bonificacion();
            rchtxt_Inge.AppendText("" + Environment.NewLine);
            rchtxt_Inge.AppendText("Nombre Completo: " + inge.getNombres() + " " + inge.getApellidos() + Environment.NewLine);
            rchtxt_Inge.AppendText("Sueldo Base: " + inge.getSueldoBase() + Environment.NewLine);
            rchtxt_Inge.AppendText("Descuento: " + inge.getDescuento() + Environment.NewLine);
            rchtxt_Inge.AppendText("Bonificacion: "+ inge.getBonificacion() + Environment.NewLine);
            rchtxt_Inge.AppendText("Movilidad: " + inge.Movilidad() + Environment.NewLine);
            rchtxt_Inge.AppendText("Sueldo Bruto: " + inge.SueldoBruto() + Environment.NewLine);
            rchtxt_Inge.AppendText("Sueldo Neto: " + inge.SueldoNeto() + Environment.NewLine);
            rchtxt_Inge.AppendText("Codigo: " + inge.getCodigo() + Environment.NewLine);
            txt_nombres.Text = "";
            txt_apellidos.Text = "";
            txt_numeroObras.Text = "";
        }
    }
}
