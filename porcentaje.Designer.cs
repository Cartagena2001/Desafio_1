namespace DESAFIO_1
{
    partial class porcentaje
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
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(468, 20);
            label1.TabIndex = 0;
            label1.Text = "Porcentaje de Tipos de Sangre en El Salvador (Estudio cruz roja 2016)";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(563, 403);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(173, 39);
            button3.TabIndex = 11;
            button3.Text = "Generar Grafica";
            button3.UseVisualStyleBackColor = false;
            button3.Click += grafica_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(563, 55);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 12;
            label2.Text = "Tipo de sangre A = 23%%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 99);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 13;
            label3.Text = "Tipo de sangre B = 11%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 138);
            label4.Name = "label4";
            label4.Size = new Size(169, 20);
            label4.TabIndex = 14;
            label4.Text = "Tipo de sangre AB = 1%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 184);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 15;
            label5.Text = "Tipo de sangre O = 62%";
            label5.Click += label5_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(560, 231);
            label6.Name = "label6";
            label6.Size = new Size(170, 20);
            label6.TabIndex = 16;
            label6.Text = "Tipo de sangre  -A = 1%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(563, 270);
            label7.Name = "label7";
            label7.Size = new Size(176, 20);
            label7.TabIndex = 17;
            label7.Text = "Tipo de sangre -B = 0.7%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(557, 316);
            label8.Name = "label8";
            label8.Size = new Size(186, 20);
            label8.TabIndex = 18;
            label8.Text = "Tipo de sangre -AB = 0.3%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(563, 359);
            label9.Name = "label9";
            label9.Size = new Size(171, 20);
            label9.TabIndex = 19;
            label9.Text = "Tipo de sangre  -O = 1%";
            // 
            // porcentaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 485);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "porcentaje";
            Text = "porcentaje";
            Paint += porcentaje_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}