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
    public partial class porcentaje : Form
    {
        private bool estado = false;
        private double A = 23, B = 11, AB = 1, O = 62;
        private double a = 1, b = 0.7, ab = 0.3, o = 1;

        public porcentaje()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void grafica_click(object sender, EventArgs e)
        {
            estado = true;
            Refresh();

        }

        private void porcentaje_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                Graphics graphics = CreateGraphics();
                double porcentajeTotal = A + B + AB + O + a + b + ab + o;

                double sangreA = (A * 360) / porcentajeTotal;
                double sangreB = (B * 360) / porcentajeTotal;
                double sangreAB = (AB * 360) / porcentajeTotal;
                double sangreO = (O * 360) / porcentajeTotal;
                double sangrea = (a * 360) / porcentajeTotal;
                double sangreb = (b * 360) / porcentajeTotal;
                double sangreab = (ab * 360) / porcentajeTotal;
                double sangreo = (o * 360) / porcentajeTotal;

                graphics.FillPie(new SolidBrush(Color.Red), 15, 60, 300, 300, 0, (float)sangreA);
                graphics.FillPie(new SolidBrush(Color.Purple), 15, 60, 300, 300, (float)sangreA, (float)sangreB);
                graphics.FillPie(new SolidBrush(Color.PowderBlue), 15, 60, 300, 300, (float)sangreA + (float)sangreB, (float)sangreAB);
                graphics.FillPie(new SolidBrush(Color.Pink), 15, 60, 300, 300, (float)sangreA + (float)sangreB + (float)sangreAB, (float)sangreO);
                graphics.FillPie(new SolidBrush(Color.PeachPuff), 15, 60, 300, 300, (float)sangreA + (float)sangreB + (float)sangreAB + (float)sangreO, (float)sangrea);
                graphics.FillPie(new SolidBrush(Color.PapayaWhip), 15, 60, 300, 300, (float)sangreA + (float)sangreB + (float)sangreAB + (float)sangreO + (float)sangrea, (float)sangreb);
                graphics.FillPie(new SolidBrush(Color.PaleGreen), 15, 60, 300, 300, (float)sangreA + (float)sangreB + (float)sangreAB + (float)sangreO + (float)sangrea + (float)sangreb, (float)sangreab);
                graphics.FillPie(new SolidBrush(Color.OrangeRed), 15, 60, 300, 300, (float)sangreA + (float)sangreB + (float)sangreAB + (float)sangreO + (float)sangrea + (float)sangreb + (float)sangreab, (float)sangreo);

                graphics.FillRectangle(new SolidBrush(Color.Red), 550, 55, 15, 15);
                graphics.FillRectangle(new SolidBrush(Color.Purple), 550, 95, 15, 15);
                graphics.FillRectangle(new SolidBrush(Color.PowderBlue), 550, 140, 15, 15);
                graphics.FillRectangle(new SolidBrush(Color.Pink), 550, 185, 15, 15);
                graphics.FillRectangle(new SolidBrush(Color.PeachPuff), 550, 230, 15, 15);
                graphics.FillRectangle(new SolidBrush(Color.PapayaWhip), 550, 275, 15, 15);
                graphics.FillRectangle(new SolidBrush(Color.PaleGreen), 550, 320, 15, 15);
                graphics.FillRectangle(new SolidBrush(Color.OrangeRed), 550, 365, 15, 15);
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
