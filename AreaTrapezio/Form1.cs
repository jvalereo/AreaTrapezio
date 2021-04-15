using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AreaTrapezio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            /*Treinamento , Calcule a area do trapezio, tipo double*/
            //Jonas valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double D, d, h, area;



            //Declarando entrada de dado no textbox

            D = double.Parse(textBoxBaseMaior.Text, CultureInfo.InvariantCulture);
            d = double.Parse(textBoxBaseMenor.Text, CultureInfo.InvariantCulture);
            h = double.Parse(textBoxAltura.Text, CultureInfo.InvariantCulture);


           //Declarando a variavel area do trapezio 

            area = (D + d) / 2.0 * h;


            //imprimir saida de dados no MessagemBox, concatenação

            MessageBox.Show("Area do Trapezio = " + area.ToString("F1", CultureInfo.InvariantCulture), 
             "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Teste de novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo limpar, textbox, focus

            textBoxBaseMaior.Text = " ";
            textBoxBaseMenor.Text = " ";
            textBoxAltura.Text = " ";
            textBoxBaseMaior.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            //Declarando o codigo sair do programa

            Close();
        }

        //Fim do programas

    }
}
