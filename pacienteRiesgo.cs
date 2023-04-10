using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAFIO_1
{
    public partial class pacienteRiesgo : Form
    {
        card1825 card1 = new card1825();
        card2640 card2 = new card2640();
        card4150 card3 = new card4150();
        card50 card4 = new card50();

        public pacienteRiesgo()
        {
            InitializeComponent();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            card1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            card2.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            card3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            card4.Visible = true;

        }
    }
}
