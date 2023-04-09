namespace DESAFIO_1
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCerrar = new Button();
            button3 = new Button();
            button1 = new Button();
            tbPacientes = new DataGridView();
            txtNombre = new TextBox();
            cmbGenero = new ComboBox();
            cmbTipoSangre = new ComboBox();
            cmbPresionArterial = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Buscar = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)tbPacientes).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Highlight;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(800, 528);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(181, 52);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar Programa";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(27, 436);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(109, 52);
            button3.TabIndex = 10;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += agregarPaciente;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(142, 436);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(107, 52);
            button1.TabIndex = 11;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += eliminarPaciente;
            // 
            // tbPacientes
            // 
            tbPacientes.BackgroundColor = SystemColors.ActiveCaption;
            tbPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbPacientes.Location = new Point(330, 48);
            tbPacientes.Name = "tbPacientes";
            tbPacientes.RowHeadersWidth = 51;
            tbPacientes.RowTemplate.Height = 29;
            tbPacientes.Size = new Size(569, 341);
            tbPacientes.TabIndex = 6;
            tbPacientes.CellClick += tbPacientes_CellClick;
            tbPacientes.CellFormatting += tbPacientes_CellFormatting;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 14;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbGenero.Location = new Point(27, 146);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(151, 28);
            cmbGenero.TabIndex = 15;
            // 
            // cmbTipoSangre
            // 
            cmbTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoSangre.FormattingEnabled = true;
            cmbTipoSangre.Items.AddRange(new object[] { "A", "B ", "AB", "O" });
            cmbTipoSangre.Location = new Point(27, 221);
            cmbTipoSangre.Name = "cmbTipoSangre";
            cmbTipoSangre.Size = new Size(151, 28);
            cmbTipoSangre.TabIndex = 16;
            // 
            // cmbPresionArterial
            // 
            cmbPresionArterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPresionArterial.FormattingEnabled = true;
            cmbPresionArterial.Items.AddRange(new object[] { "Alta", "Media ", "Baja\t" });
            cmbPresionArterial.Location = new Point(27, 303);
            cmbPresionArterial.Name = "cmbPresionArterial";
            cmbPresionArterial.Size = new Size(151, 28);
            cmbPresionArterial.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 48);
            label1.Name = "label1";
            label1.Size = new Size(215, 20);
            label1.TabIndex = 18;
            label1.Text = "Ingrese el nombre del paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 112);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 19;
            label2.Text = "Ingrese el genero del Paciente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 189);
            label3.Name = "label3";
            label3.Size = new Size(257, 20);
            label3.TabIndex = 20;
            label3.Text = "Ingrese el tipo de sangre del Paciente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 263);
            label4.Name = "label4";
            label4.Size = new Size(230, 20);
            label4.TabIndex = 21;
            label4.Text = "Ingrese el tipo de Presion Arterial";
            // 
            // Buscar
            // 
            Buscar.BackColor = SystemColors.Highlight;
            Buscar.Cursor = Cursors.Hand;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Buscar.ForeColor = Color.White;
            Buscar.Location = new Point(255, 436);
            Buscar.Margin = new Padding(3, 4, 3, 4);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(107, 52);
            Buscar.TabIndex = 22;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += txtBusqueda_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(368, 436);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(186, 52);
            button2.TabIndex = 23;
            button2.Text = "Limpiar Formulario";
            button2.UseVisualStyleBackColor = false;
            button2.Click += limpiarForm_click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(27, 528);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(109, 52);
            button4.TabIndex = 24;
            button4.Text = "Riesgos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += pacienteRiesgo;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(142, 528);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(127, 52);
            button5.TabIndex = 25;
            button5.Text = "Porcentajes";
            button5.UseVisualStyleBackColor = false;
            button5.Click += porcentajes_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(993, 593);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(Buscar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPresionArterial);
            Controls.Add(cmbTipoSangre);
            Controls.Add(cmbGenero);
            Controls.Add(txtNombre);
            Controls.Add(tbPacientes);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(btnCerrar);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Form1_load;
            ((System.ComponentModel.ISupportInitialize)tbPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrar;
        private Button button3;
        private Button button1;
        private DataGridView tbPacientes;
        private TextBox txtNombre;
        private ComboBox cmbGenero;
        private ComboBox cmbTipoSangre;
        private ComboBox cmbPresionArterial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Buscar;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}