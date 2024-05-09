using System;
using System.Drawing;
using System.Windows.Forms;

namespace Central_de_Controle
{
	public partial class IMC : Form
	{
		public IMC()
		{
			InitializeComponent();
		}
		void BntcalculoClick(object sender, EventArgs e)
		{
			double alt, pes, IMC;
			try{
			alt = Convert.ToDouble(txtaltura.Text);
			pes = Convert.ToDouble(txtpeso.Text);
			IMC = pes / ((alt/100)*(alt/100));
			txtimc.Text = Convert.ToString(IMC);
			if (IMC < 18.5){
				txtdescricao.Text = Convert.ToString("Abaixo do Peso");
				imagem.Load ("C:/Central de Controle/Imagens/Abaixo_do_peso.png");
			} else if (IMC > 18.5 && IMC < 24.9) {
				txtdescricao.Text = Convert.ToString("Peso Normal");
				imagem.Load ("C:/Central de Controle/Imagens/Peso_normal.png");
			} else if (IMC > 25 && IMC < 29.9) {
				txtdescricao.Text = Convert.ToString("Acima do Peso");
				imagem.Load ("C:/Central de Controle/Imagens/Acima_do_peso.png");
			} else if (IMC > 30 && IMC < 39.9) {
				txtdescricao.Text = Convert.ToString("Obesidade Grau I");
				imagem.Load ("C:/Central de Controle/Imagens/Obesidade_grau_1.png");
			} else {
				txtdescricao.Text = Convert.ToString("Obesidade Grau II");
				imagem.Load ("C:/Central de Controle/Imagens/Obesidade_grau_2.png");
				} 
			} catch (Exception E) {
				MessageBox.Show("Erro ao fazer o IMC.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void BntnovoClick(object sender, EventArgs e)
		{
			//Novo
			try{
				if (MessageBox.Show("Deseja fazer outro calculo?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
					txtaltura.Clear();
					txtdescricao.Clear();
					txtimc.Clear();
					txtpeso.Clear();
					imagem.Image = null;
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