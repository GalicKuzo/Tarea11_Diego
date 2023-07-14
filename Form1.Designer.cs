namespace Tarea11_Diego
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.cmbox_condicionC = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_cargoInge = new System.Windows.Forms.ComboBox();
            this.cmbox_especialidadInge = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numeroObras = new System.Windows.Forms.TextBox();
            this.btn_RegistrarInge = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbox_seguro = new System.Windows.Forms.ComboBox();
            this.rchtxt_Inge = new System.Windows.Forms.RichTextBox();
            this.rchtxt_Arqui = new System.Windows.Forms.RichTextBox();
            this.btn_registrarArqui = new System.Windows.Forms.Button();
            this.cmbox_especialidadArqui = new System.Windows.Forms.ComboBox();
            this.cmbox_cargoArqui = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_proyectosD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Condicion de Contrato:";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(93, 20);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(242, 22);
            this.txt_nombres.TabIndex = 3;
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(94, 59);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(242, 22);
            this.txt_apellidos.TabIndex = 4;
            this.txt_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidos_KeyPress);
            // 
            // cmbox_condicionC
            // 
            this.cmbox_condicionC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_condicionC.FormattingEnabled = true;
            this.cmbox_condicionC.Items.AddRange(new object[] {
            "Estable",
            "Contratado"});
            this.cmbox_condicionC.Location = new System.Drawing.Point(499, 20);
            this.cmbox_condicionC.Name = "cmbox_condicionC";
            this.cmbox_condicionC.Size = new System.Drawing.Size(168, 24);
            this.cmbox_condicionC.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 364);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rchtxt_Inge);
            this.tabPage1.Controls.Add(this.btn_RegistrarInge);
            this.tabPage1.Controls.Add(this.txt_numeroObras);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbox_especialidadInge);
            this.tabPage1.Controls.Add(this.cmbox_cargoInge);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingeniero Civil";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_proyectosD);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.rchtxt_Arqui);
            this.tabPage2.Controls.Add(this.btn_registrarArqui);
            this.tabPage2.Controls.Add(this.cmbox_especialidadArqui);
            this.tabPage2.Controls.Add(this.cmbox_cargoArqui);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arquitecto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cargo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Especialidad:";
            // 
            // cmbox_cargoInge
            // 
            this.cmbox_cargoInge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_cargoInge.FormattingEnabled = true;
            this.cmbox_cargoInge.Items.AddRange(new object[] {
            "Supervisión de Obras",
            "Supervisión de Vías"});
            this.cmbox_cargoInge.Location = new System.Drawing.Point(77, 20);
            this.cmbox_cargoInge.Name = "cmbox_cargoInge";
            this.cmbox_cargoInge.Size = new System.Drawing.Size(203, 24);
            this.cmbox_cargoInge.TabIndex = 2;
            // 
            // cmbox_especialidadInge
            // 
            this.cmbox_especialidadInge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_especialidadInge.FormattingEnabled = true;
            this.cmbox_especialidadInge.Items.AddRange(new object[] {
            "Estructuras",
            "Recursos Hídricos",
            "Ingeniería Vial"});
            this.cmbox_especialidadInge.Location = new System.Drawing.Point(120, 65);
            this.cmbox_especialidadInge.Name = "cmbox_especialidadInge";
            this.cmbox_especialidadInge.Size = new System.Drawing.Size(160, 24);
            this.cmbox_especialidadInge.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Numero de Obras:";
            // 
            // txt_numeroObras
            // 
            this.txt_numeroObras.Location = new System.Drawing.Point(458, 20);
            this.txt_numeroObras.Name = "txt_numeroObras";
            this.txt_numeroObras.Size = new System.Drawing.Size(224, 22);
            this.txt_numeroObras.TabIndex = 5;
            this.txt_numeroObras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_numeroObras_KeyDown);
            this.txt_numeroObras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeroObras_KeyPress);
            // 
            // btn_RegistrarInge
            // 
            this.btn_RegistrarInge.Location = new System.Drawing.Point(338, 58);
            this.btn_RegistrarInge.Name = "btn_RegistrarInge";
            this.btn_RegistrarInge.Size = new System.Drawing.Size(344, 31);
            this.btn_RegistrarInge.TabIndex = 7;
            this.btn_RegistrarInge.Text = "Registrar Ingeniero Civil";
            this.btn_RegistrarInge.UseVisualStyleBackColor = true;
            this.btn_RegistrarInge.Click += new System.EventHandler(this.btn_RegistrarInge_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Seguro:";
            // 
            // cmbox_seguro
            // 
            this.cmbox_seguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_seguro.FormattingEnabled = true;
            this.cmbox_seguro.Items.AddRange(new object[] {
            "AFP",
            "Essalud"});
            this.cmbox_seguro.Location = new System.Drawing.Point(411, 59);
            this.cmbox_seguro.Name = "cmbox_seguro";
            this.cmbox_seguro.Size = new System.Drawing.Size(256, 24);
            this.cmbox_seguro.TabIndex = 8;
            // 
            // rchtxt_Inge
            // 
            this.rchtxt_Inge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchtxt_Inge.Location = new System.Drawing.Point(27, 107);
            this.rchtxt_Inge.Name = "rchtxt_Inge";
            this.rchtxt_Inge.ReadOnly = true;
            this.rchtxt_Inge.Size = new System.Drawing.Size(655, 207);
            this.rchtxt_Inge.TabIndex = 8;
            this.rchtxt_Inge.Text = "";
            // 
            // rchtxt_Arqui
            // 
            this.rchtxt_Arqui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchtxt_Arqui.Location = new System.Drawing.Point(29, 107);
            this.rchtxt_Arqui.Name = "rchtxt_Arqui";
            this.rchtxt_Arqui.ReadOnly = true;
            this.rchtxt_Arqui.Size = new System.Drawing.Size(655, 207);
            this.rchtxt_Arqui.TabIndex = 16;
            this.rchtxt_Arqui.Text = "";
            // 
            // btn_registrarArqui
            // 
            this.btn_registrarArqui.Location = new System.Drawing.Point(338, 61);
            this.btn_registrarArqui.Name = "btn_registrarArqui";
            this.btn_registrarArqui.Size = new System.Drawing.Size(344, 31);
            this.btn_registrarArqui.TabIndex = 15;
            this.btn_registrarArqui.Text = "Registrar Arquitecto";
            this.btn_registrarArqui.UseVisualStyleBackColor = true;
            this.btn_registrarArqui.Click += new System.EventHandler(this.btn_registrarArqui_Click);
            // 
            // cmbox_especialidadArqui
            // 
            this.cmbox_especialidadArqui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_especialidadArqui.FormattingEnabled = true;
            this.cmbox_especialidadArqui.Items.AddRange(new object[] {
            "Restauración y Rehabilitacion",
            "Materiales de Construccion",
            "Paisajismo y Jardinería"});
            this.cmbox_especialidadArqui.Location = new System.Drawing.Point(122, 65);
            this.cmbox_especialidadArqui.Name = "cmbox_especialidadArqui";
            this.cmbox_especialidadArqui.Size = new System.Drawing.Size(160, 24);
            this.cmbox_especialidadArqui.TabIndex = 12;
            // 
            // cmbox_cargoArqui
            // 
            this.cmbox_cargoArqui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_cargoArqui.FormattingEnabled = true;
            this.cmbox_cargoArqui.Items.AddRange(new object[] {
            "Director de Obras",
            "Edificador Industrial"});
            this.cmbox_cargoArqui.Location = new System.Drawing.Point(79, 20);
            this.cmbox_cargoArqui.Name = "cmbox_cargoArqui";
            this.cmbox_cargoArqui.Size = new System.Drawing.Size(203, 24);
            this.cmbox_cargoArqui.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Especialidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cargo:";
            // 
            // txt_proyectosD
            // 
            this.txt_proyectosD.Location = new System.Drawing.Point(553, 20);
            this.txt_proyectosD.Name = "txt_proyectosD";
            this.txt_proyectosD.Size = new System.Drawing.Size(131, 22);
            this.txt_proyectosD.TabIndex = 18;
            this.txt_proyectosD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_proyectosD_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numero de Proyectos Diseñados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 473);
            this.Controls.Add(this.cmbox_seguro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmbox_condicionC);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.ComboBox cmbox_condicionC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_numeroObras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbox_especialidadInge;
        private System.Windows.Forms.ComboBox cmbox_cargoInge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rchtxt_Inge;
        private System.Windows.Forms.Button btn_RegistrarInge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbox_seguro;
        private System.Windows.Forms.RichTextBox rchtxt_Arqui;
        private System.Windows.Forms.Button btn_registrarArqui;
        private System.Windows.Forms.ComboBox cmbox_especialidadArqui;
        private System.Windows.Forms.ComboBox cmbox_cargoArqui;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_proyectosD;
        private System.Windows.Forms.Label label8;
    }
}

