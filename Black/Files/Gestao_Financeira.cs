using System;
using System.Drawing;
using System.Windows.Forms;

namespace Central_de_Controle
{
	public partial class Gestao_Financeira : Form
	{
		public Gestao_Financeira()
		{
			InitializeComponent();
		}
		
		double vlr_receita, vlr_despesa, tot_receita, tot_despesa, tot_lucro, tot_dinheiro_movimentado;
		
		void BntguadarClick(object sender, EventArgs e)
		{
			try{
				vlr_despesa = Convert.ToDouble(despesa.Text);
				vlr_receita = Convert.ToDouble(receita.Text);
				
				if (vlr_despesa == null) {
					vlr_despesa = 0;
				}
				if (receita.Text == null){
					vlr_receita = 0;
				}
				
				tot_despesa = tot_despesa += vlr_despesa;
				tot_receita = tot_receita += vlr_receita;
				
				despesa.Clear();
				receita.Clear();
				
			} catch (Exception E) {
				MessageBox.Show("Erro ao salvar os valores","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void BntcalcularClick(object sender, EventArgs e)
		{
			try{
				tot_lucro = tot_receita - tot_despesa;
				tot_dinheiro_movimentado = tot_receita + tot_despesa;
				
				if (tot_lucro < 0) {
					lucro.Text = Convert.ToString(tot_lucro);
					lucro.Text = "-" + lucro.Text;
				}
				
				lucro.Text = Convert.ToString(tot_lucro);
				dinheiro_movimentado.Text = Convert.ToString(tot_dinheiro_movimentado);
				totpagar.Text = Convert.ToString(tot_despesa);
				totreceber.Text = Convert.ToString(tot_receita);
			} catch (Exception E) {
				MessageBox.Show("Erro ao fazer o calculo.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void BntnovoClick(object sender, EventArgs e)
		{
			try{
				vlr_receita = 0;
				vlr_despesa = 0;
				tot_receita = 0;
				tot_despesa = 0;
				tot_lucro = 0;
				tot_dinheiro_movimentado = 0;
				receita.Clear();
				despesa.Clear();
				lucro.Clear();
				totpagar.Clear();
				totreceber.Clear();
				dinheiro_movimentado.Clear();
			} catch (Exception E) {
				MessageBox.Show("Erro ao tentar fazer um novo calculo.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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