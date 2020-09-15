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

            // Guardando os valores nas váriaveis
            public void aplpyValue(string a, string b, string c)
            {
                this.cateto[0] = double.Parse(a); this.cateto[1] = double.Parse(b);
                this.hipotenusa = double.Parse(c);
            }

            // Testando se é triângulo
            public bool testTriangulo()
            {
                double[] add = new double[3];
                add[0] = this.cateto[0] + this.cateto[1];
                add[1] = this.cateto[1] + this.hipotenusa;
                add[2] = this.hipotenusa + this.cateto[0];
                if (add[0] > this.hipotenusa && add[1] > this.cateto[0] && add[2] > this.cateto[1]) { return true; } else { return false; }
            }

            // Classificando o tipo do triangulo em relação aos lados
            public int TriangleTypeSide()
            {
                if (this.cateto[0] == this.cateto[1] && this.cateto[1] == this.hipotenusa && this.hipotenusa == this.cateto[0]) return 0;
                else if (this.cateto[0] == this.cateto[1] || this.cateto[1] == this.hipotenusa || this.hipotenusa == this.cateto[0]) return 1;
                else return 2;
            }

            // Classificando o tipo do triangulo em relação aos ângulos
            public int TriangleTypeAngle ()
            {
                if (this.equalityTest()) return 0; else if (this.numberBigger()) return 1; else return 2;
            }

            // Verificando se é triângulo retangulo através da raiz da soma dos quadrados dos catetos
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

        // Operação realizada toda vez que clicamos no botão Verificar
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string txtTypeTriangle = "";
            int typeTriangle = 0;
            Triangulo triangulo = new Triangulo();
            triangulo.aplpyValue(txtSide1.Text, txtSide2.Text, txtSide3.Text); typeTriangle = triangulo.TriangleTypeSide();

            if (triangulo.testTriangulo())
            {
                switch (typeTriangle)
                {
                    case 0:
                        txtTypeTriangle = "É um triangulo equilátero, e actângulo";
                        break;
                    case 1:
                        txtTypeTriangle = "É um triangulo isósceles, e actângulo";
                        break;
                    default:
                        txtTypeTriangle = "É um triangulo escaleno";
                        switch (triangulo.TriangleTypeAngle())
                        {
                            case 0:
                                txtTypeTriangle += " e triângulo retângulo";
                                break;
                            case 1:
                                txtTypeTriangle += " e triângulo actângulo";
                                break;
                            default:
                                txtTypeTriangle += " e triângulo obtusângulo";
                                break;
                        }
                        break;
                }
                MessageBox.Show(txtTypeTriangle);
            }
            else MessageBox.Show("Isso não é um Triangulo");
        }

        private void sobreOProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrAbout about = new DS_Triangulo_15092020_15H37.fmrAbout();
            about.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
