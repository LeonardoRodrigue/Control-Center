using System;
using System.Drawing;
using System.Windows.Forms;

namespace Central_de_Controle
{
	public partial class Calculadora : Form
	{
		public Calculadora()
		{
			InitializeComponent();
		}
		void BntcalculoClick(object sender, EventArgs e)
		{
			double v1, v2, result=0;
			try{
			v1 = Convert.ToDouble(txtnum1.Text);
			v2 = Convert.ToDouble(txtnum2.Text);
			if (rdadicao.Checked == true) {
				result = v1 + v2;
			}
			else if (rdsubtracao.Checked == true) {
				result = v1 - v2;
			}
			else if (rddivisao.Checked == true) {
				result = v1 / v2;
			}
			else if (rdmultiplicacao.Checked == true) {
				result = v1 * v2;
			}
			txtresultado.Text = Convert.ToString(result);
			} catch (Exception E) {
				MessageBox.Show("Erro ao fazer o calculo.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void BntnovoClick(object sender, EventArgs e)
		{
			//Novo
			try{
				if (MessageBox.Show("Deseja fazer outro calculo?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
					txtnum1.Clear();
					txtnum2.Clear();
					txtresultado.Clear();
					rddivisao.Checked = false;
					rdmultiplicacao.Checked = false;
					rdsubtracao.Checked = false;
					rdadicao.Checked = false;
				}
			} catch (Exception E) {
				MessageBox.Show("Erro ao voltar!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		void BntsairClick(object sender, EventArgs e)
		{
			//Sair
			try{
			if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
				Aplicacoes apli = new Aplicacoes();
				apli.Show();
				Close();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao sair","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void AnterClick(object sender, EventArgs e)
		{
			Aplicacoes apli = new Aplicacoes();
			apli.Show();
			Close();
		}
	}
}

// Leonardo Rodrigues Reis Lopes