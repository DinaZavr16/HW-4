using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Shapes : Form
    {
        public Shapes()
        {
            InitializeComponent();
        }

        private void btnResultCircle_Click(object sender, EventArgs e)
        {
            Shape circle = new Circle(float.Parse(tbRadius.Text));
            lbPerymCircle.Text = "Perimetr is " + circle.GetPerimeter();
            lbAreaCircle.Text = "Area is " + circle.GetArea();
        }

        private void btnResultSquare_Click(object sender, EventArgs e)
        {
            Shape square = new Square(float.Parse(tbSideSquare.Text));
            lbPerymSquare.Text = "Perimetr is " + square.GetPerimeter();
            lbAreaSquare.Text = "Area is " + square.GetArea();
        }

        private void btnResultRhomb_Click(object sender, EventArgs e)
        {
            Shape rhombus = new Rhombus(float.Parse(tbSideRhomb.Text));
            lbPerymRhomb.Text = "Perimetr is " + rhombus.GetPerimeter();
            lbAreaRhomb.Text = "Area is " + rhombus.GetArea();
        }

        private void btnResultRect_Click(object sender, EventArgs e)
        {
            Shape rectangle = new Rectangle(float.Parse(tbSideARec.Text),float.Parse(tbSideBRec.Text));
            lbPerymRect.Text = "Perimetr is " + rectangle.GetPerimeter();
            lbAreaRect.Text = "Area is " + rectangle.GetArea();
        }

        private void btnResultTriang_Click(object sender, EventArgs e)
        {
            Shape triangle = new Triangle(float.Parse(tbSideATriang.Text), float.Parse(tbSideBTriang.Text), 
                float.Parse(tbSideCTriang.Text));
            lbPerymTriang.Text = "Perimetr is " + triangle.GetPerimeter();
            lbAreaTriang.Text = "Area is " + triangle.GetArea();
        }

    }
}
