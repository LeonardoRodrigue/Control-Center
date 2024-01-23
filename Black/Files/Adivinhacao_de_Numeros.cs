using System;
using System.Drawing;
using System.Windows.Forms;

namespace Central_de_Controle
{
	public partial class Adivinhacao_de_Numeros : Form
	{
		public Adivinhacao_de_Numeros()
		{
			InitializeComponent();
			EscolherNivel();
		}
		int NumeroCorreto;
		int Tentativas;
		int num_digitado;
		int num_limite;
		int limite_tentativas;
		int tentativas_restantes;
		
		private void EscolherNivel(){
			//Escolha de nivel
			label.Text = "Escolha um nível";
			labelResultado.Text = "";
			labeltentativasrest.Text = "";
			buttonTentar = null;
			bntnuivel1.Enabled = true;
			bntnivel2.Enabled = true;
			bntnivel3.Enabled = true;
			msktentativas.Clear();
			msktentativas.Enabled = false;
		}
		private void IniciodeNivel(){
			bntnuivel1.Enabled = false;
			bntnivel2.Enabled = false;
			bntnivel3.Enabled = false;
			msktentativas.Enabled = true;
		}
		private void IniciarNvl1(){
			//Nivel 1
			Random random_nvl1 = new Random();
			NumeroCorreto = random_nvl1.Next(0, 100);
			Tentativas = 0;
			num_limite = 100;
			limite_tentativas = 50;
			labelResultado.Text = "Tente adivinhar o número entre 1 e 100.";
			tentativas_restantes = limite_tentativas;
			labeltentativasrest.Text = "Tentativas restantes: " + tentativas_restantes;
		}
		private void IniciarNvl2(){
			//Nivel 2
			Random random_nvl2 = new Random();
			NumeroCorreto = random_nvl2.Next(0, 250);
			Tentativas = 0;
			num_limite = 250;
			limite_tentativas = 12;
			labelResultado.Text = "Tente adivinhar o número entre 1 e 250.";
			tentativas_restantes = limite_tentativas;
			labeltentativasrest.Text = "Tentativas restantes: " + tentativas_restantes;
		}
		private void IniciarNvl3(){
			//Nivel 3
			Random random_nvl3 = new Random();
			NumeroCorreto = random_nvl3.Next(0, 500);
			Tentativas = 0;
			num_limite = 500
			;limite_tentativas = 5;
			labelResultado.Text = "Tente adivinhar o número entre 1 e 500.";
			tentativas_restantes = limite_tentativas;
			labeltentativasrest.Text = "Tentativas restantes: " + tentativas_restantes;
		}
		void Bntnuivel1Click(object sender, EventArgs e)
		{
			//Iniciar Nivel 1
			IniciarNvl1();
			label.Text = "Nivél 1";
			IniciodeNivel();
		}
		void Bntnivel2Click(object sender, EventArgs e)
		{
			//Iniciar Nivel 2
			IniciarNvl2();
			label.Text = "Nivél 2";
			IniciodeNivel();
		}
		void Bntnivel3Click(object sender, EventArgs e)
		{
			//Iniciar Nivel 3
			IniciarNvl3();
			label.Text = "Nivél 3";
			IniciodeNivel();
		}
		void ButtonTentarClick(object sender, EventArgs e)
		{
			try {
				num_digitado = Convert.ToInt32(msktentativas.Text);
				if (num_digitado >= 0 && num_digitado <= num_limite) {
					if (num_digitado < NumeroCorreto) {
						labelResultado.Text = "⇑ Tente um numero maior ⇑";
						Tentativas++;
						tentativas_restantes -= 1;
						labeltentativasrest.Text = "Tentativas restantes: " + tentativas_restantes;
					} else if (num_digitado > NumeroCorreto) {
						labelResultado.Text = "⇓ Tente um numero menor ⇓";
						Tentativas++;
						tentativas_restantes -= 1;
						labeltentativasrest.Text = "Tentativas restantes: " + tentativas_restantes;
					} else if (num_digitado == NumeroCorreto) {
						MessageBox.Show("Parabéns! Você acertou o número em " + Tentativas + " tentativa(s).");
						EscolherNivel();
					}
					msktentativas.Clear();
					if (Tentativas == limite_tentativas) {
						MessageBox.Show("Você atingiu o limite de tentativas!\n O numero correto era " + NumeroCorreto + ", tente novamente.");
						EscolherNivel();
					}
				}  else {
					MessageBox.Show("Digite um numero válido!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
					msktentativas.Clear();
				}
			} catch (Exception E) {
				MessageBox.Show("Erro ao executar o programa!\n\nTente inserir um NUMERO válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				EscolherNivel();
			}
		}
		void BntsairClick(object sender, EventArgs e)
		{
			//Sair
			try{
				if (MessageBox.Show("Deseja voltar?", "Voltar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
					Aplicacoes apli = new Aplicacoes();
					apli.Show();
					Close();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao Voltar","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void BntnewClick(object sender, EventArgs e)
		{
			//Novo
			try{
				if (MessageBox.Show("Deseja voltar a seleção de nível?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
					EscolherNivel();
				}
			} catch (Exception E) {
				MessageBox.Show("Erro ao voltar a seleção de nível!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
