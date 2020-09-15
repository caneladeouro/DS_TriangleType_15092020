using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_Triangulo_15092020_15H37
{
    public partial class fmrCalculate : Form
    {
        public fmrCalculate()
        {
            InitializeComponent();
        }

        public class Triangulo
        {
            public double hipotenusa;
            public double[] cateto = new double[2];
            public double quadradoCateto;

            public void aplpyValue(string a, string b, string c)
            {
                this.cateto[0] = double.Parse(a); this.cateto[1] = double.Parse(b);
                this.hipotenusa = double.Parse(c);
            }

            public bool testTriangulo()
            {
                double[] add = new double[3];
                add[0] = this.cateto[0] + this.cateto[1];
                add[1] = this.cateto[1] + this.hipotenusa;
                add[2] = this.hipotenusa + this.cateto[0];
                if (add[0] > this.hipotenusa && add[1] > this.cateto[0] && add[2] > this.cateto[1]) { return true; } else { return false; }
            }

            public int TriangleType()
            {
                if (this.cateto[0] == this.cateto[1] && this.cateto[1] == this.hipotenusa && this.hipotenusa == this.cateto[0]) return 0;
                else if (this.cateto[0] == this.cateto[1] || this.cateto[1] == this.hipotenusa || this.hipotenusa == this.cateto[0]) return 1;
                else return 2;
            }

            public bool equalityTest()
            {
                double QuadradoCateto = Math.Sqrt(Math.Pow(this.cateto[0], 2) + Math.Pow(this.cateto[1], 2));
                if (QuadradoCateto == this.hipotenusa) { this.quadradoCateto = QuadradoCateto; return true; } else { return false; };
            }

            public bool numberBigger()
            {
                if (this.quadradoCateto > this.hipotenusa) { return true; } else { return false; }
            }
        }

        public double Call(string side)
        {

            double result = double.Parse(side);

            return result;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int typeTriangle;
            Triangulo triangulo = new Triangulo();
            triangulo.aplpyValue(txtSide1.Text, txtSide2.Text, txtSide3.Text); typeTriangle = triangulo.TriangleType();

            if (triangulo.testTriangulo())
            {
                switch (typeTriangle)
                {
                    case 0:
                        MessageBox.Show("É um triangulo equilátero, e actângulo");
                        break;
                    case 1:
                        MessageBox.Show("É um triangulo isósceles");
                        break;
                    default:
                        MessageBox.Show("É um triangulo escaleno");
                        break;
                }
            }
            else MessageBox.Show("Isso não é um Triangulo");
        }
    }
}
