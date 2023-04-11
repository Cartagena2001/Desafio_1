namespace DESAFIO_1
{
    partial class pacienteRiesgo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pacienteRiesgo));
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 73);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(193, 418);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(252, 73);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(193, 418);
            richTextBox2.TabIndex = 16;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(480, 73);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(193, 418);
            richTextBox3.TabIndex = 17;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(714, 73);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(193, 418);
            richTextBox4.TabIndex = 18;
            richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 19;
            label1.Text = "Pacientes entre 18-25 años";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 38);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 20;
            label2.Text = "Pacientes entre 26-40 años";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 38);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 21;
            label3.Text = "Pacientes entre 41-50 años";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(714, 38);
            label4.Name = "label4";
            label4.Size = new Size(197, 20);
            label4.TabIndex = 22;
            label4.Text = "Pacientes mayores a 50 años";
            // 
            // pacienteRiesgo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 528);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "pacienteRiesgo";
            Text = "pacienteRiesgo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}