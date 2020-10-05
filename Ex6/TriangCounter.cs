using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    public partial class TriangCounter : Form
    {
        private void ShowResults(Triangle triangle)
        {
            lbPerim.Text = $"Perimetr is {Math.Round(triangle.GetPerimeter(), 2)} cm";
            lbArea.Text = $"Area is {Math.Round(triangle.GetArea(), 2)} cm²";
        }
        public TriangCounter()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            float sideA = float.Parse(tbSideA.Text);
            float sideB = float.Parse(tbSideB.Text);
            float angleAB = float.Parse(tbAngle.Text);

            if (sideA <= 0 || sideB <= 0 || angleAB <= 0)
            {
                lbError.BackColor = Color.Red;
                lbError.Text = "Not a triangle!";
            }
            else
            {
                Triangle triangle;

                if (angleAB == 90)
                {
                    triangle = new RightTriangle(sideA, sideB, angleAB);
                    ShowResults(triangle);
                }
                else
                {
                    triangle = new EquilateralTriangle(sideA, sideB, angleAB);
                    ShowResults(triangle);
                }
            }
        }
    }
}
