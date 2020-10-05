using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_HW
{
    public partial class TriangleCounter : Form
    {
        private void Reset()
        {
            tbSideA.Text = "0";
            tbSideB.Text = "0";
            tbSideC.Text = "0";

            ResetResults();
        }

        private void ResetResults()
        {
            lbPerimetr.Text = "Perimeter ";
            lbArea.Text = "Area ";
            lbNTriangle.Text = "";
            lbAngles.Text = "Angles ";
        }
        EquilTriangle eqtriangle;
        public TriangleCounter()
        {
            InitializeComponent();
        }
        private void Result_Click(object sender, EventArgs e)
        {
            eqtriangle = new EquilTriangle(float.Parse(tbSideA.Text), float.Parse(tbSideB.Text),
                float.Parse(tbSideC.Text));
            if (eqtriangle.A + eqtriangle.B > eqtriangle.C && eqtriangle.B + eqtriangle.C > eqtriangle.A
                && eqtriangle.C + eqtriangle.A > eqtriangle.B)
            {
                lbPerimetr.Text = "Perymetr is " + eqtriangle.Perymetr().ToString();

                if (eqtriangle.A == eqtriangle.B && eqtriangle.B == eqtriangle.C && eqtriangle.C == eqtriangle.A)
                {
                    lbArea.Text = "Area is " + eqtriangle.GetArea().ToString();
                }
                else
                {
                    lbArea.Text = "Your triangle is not equilateral";
                }

                lbAngles.Text = ("AB angle is " + eqtriangle.Angle()[1] + "\n" +
                    "BC angle is " + eqtriangle.Angle()[2] + "\n" +
                    "AC angle is " + eqtriangle.Angle()[0] + "\n");
            }
            else
            {
                lbNTriangle.BackColor = Color.Red;
                lbNTriangle.Text = ("It is not triangle!");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Reset();
        }

        
    }
}
