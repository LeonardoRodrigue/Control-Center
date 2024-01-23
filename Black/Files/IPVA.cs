using System;
using System.Drawing;
using System.Windows.Forms;

namespace Central_de_Controle
{
	public partial class IPVA : Form
	{
		public IPVA()
		{
			InitializeComponent();
		}
		void BntcalculoClick(object sender, EventArgs e)
		{
			double vlrcar;
			double vlripva=0;
			try{
			vlrcar = Convert.ToDouble(txtvalor.Text);
			if (rdpasseio.Checked == true) {
				vlripva = vlrcar * 0.04;
			} 
			else if (rdfurgao.Checked == true) {
				vlripva = vlrcar * 0.03;		
			} 
			else if (rdmoto.Checked == true) {
				vlripva = vlrcar * 0.02;		
			} 
			else if (rdonibus.Checked == true) {
				vlripva = vlrcar * 0.01;
			}
			txtipva.Text = Convert.ToString(vlripva);
			} catch (Exception E) {
				MessageBox.Show("Erro ao fazer o calculo.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void RdpasseioCheckedChanged(object sender, EventArgs e)
		{
			//Imagem Carro
			try{
			imagens.Load ("C:/Central de Controle/Imagens/carro.png");
			} catch {
				MessageBox.Show("Erro ao carregar a imagem!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				imagens.Image = null;
				}
		}
		void RdfurgaoCheckedChanged(object sender, EventArgs e)
		{
			//Imagem Van
			try{
			imagens.Load ("C:/Central de Controle/Imagens/furgao.png");
			} catch {
				MessageBox.Show("Erro ao carregar a imagem!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				imagens.Image = null;
			}
		}
		void RdmotoCheckedChanged(object sender, EventArgs e)
		{
			//Imagem Moto
			try{
			imagens.Load ("C:/Central de Controle/Imagens/moto.jpg");
			} catch {
				MessageBox.Show("Erro ao carregar a imagem!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				imagens.Image = null;
			}			
		}
		void RdonibusCheckedChanged(object sender, EventArgs e)
		{
			//Imagem Onibus
			try{
			imagens.Load ("C:/Central de Controle/Imagens/onibus.jpg");
			} catch {
				MessageBox.Show("Erro ao carregar a imagem!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				imagens.Image = null;
			}
		}
		void BntnovoClick(object sender, EventArgs e)
		{
			//Novo
			try{
				if (MessageBox.Show("Deseja fazer outro calculo?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
					txtipva.Clear();
					txtvalor.Clear();
					rdmoto.Checked = false;
					rdonibus.Checked = false;
					rdpasseio.Checked = false;
					rdfurgao.Checked = false;
					imagens.Image = null;
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
