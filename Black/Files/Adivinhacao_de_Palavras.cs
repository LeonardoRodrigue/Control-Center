using System;
using System.Drawing;
using System.Windows.Forms;

namespace Central_de_Controle
{
	
	public partial class Adivinhacao_de_Palavras : Form
	{
		//Palavras possiveis
		string[] palavrasdev = { "PROGRAMACAO", "DESENVOLVIMENTO", "C", "C++", "PYTHON", "HTML", "ALGORITIMO", "VARIAVEL" };
		string[] palavrasfruit = { "BANANA", "MAÇA", "UVA", "ABACAXI", "LIMAO", "CAJU", "MANGA", "GOIABA", "ACEROLA", "KIWI", "PITAIA" };
		string[] palavrasmarcas = { "GOOGLE", "MICROSOFT", "NIKE", "ADIDAS", "FACEBOOK", "SPOTIFY", "FORD", "INSTAGRAM", "GUCCI", "NETFLIX" };
		string palavraSecreta;
		string palavraDigitada;
		int tentativaslimite;
		int tentativas;
		int tentativasRestantes;
		
		public Adivinhacao_de_Palavras()
		{
			InitializeComponent();
		}
		
		private void EscolhadeNivel()
		{
			//Escolha de Nivel
			label.Text = "Escolha um nível";
			labelResultado.Text = "";
			labeltentativasrest.Text = "";
			buttonTentar = null;
			msktentativas.Clear();
			bntnuivel1.Enabled = true;
			bntnivel2.Enabled = true;
			bntnivel3.Enabled = true;
			msktentativas.Enabled = false;
			buttonTentar = null;
			tentativas = 0;
		}
		private void IniciodeJogo()
		{
			msktentativas.Clear();
			bntnuivel1.Enabled = false;
			bntnivel2.Enabled = false;
			bntnivel3.Enabled = false;
			msktentativas.Enabled = true;
		}
		private void IniciarJogoDev()
		{
			//Jogo Desenvolvedor
			Random random = new Random();
			palavraSecreta = palavrasdev[random.Next(palavrasdev.Length)].ToLower();
			tentativaslimite = 12;
			tentativasRestantes = tentativaslimite;
			IniciodeJogo();
		}
		private void IniciarJogoFruit()
		{
			//Jogo das Frutas
			Random random = new Random();
			palavraSecreta = palavrasfruit[random.Next(palavrasfruit.Length)].ToLower();
			tentativaslimite = 10;
			tentativasRestantes = tentativaslimite;
			IniciodeJogo();
		}
		
		private void IniciarJogoMarcas()
		{
			//Jogo das Marcas
			Random random = new Random();
			palavraSecreta = palavrasmarcas[random.Next(palavrasmarcas.Length)].ToLower();
			tentativaslimite = 15;
			tentativasRestantes = tentativaslimite;
			IniciodeJogo();
		}
		
		void Bntnuivel1Click(object sender, EventArgs e)
		{
			//Inicio jogo 1
			try{
				IniciarJogoDev();
				label.Text = "Digite palavras relacionadas a Programação";
				labeltentativasrest.Text = "TentativasRestantes: " + tentativasRestantes;
				buttonTentar.Enabled = true;
			} catch (Exception E){
				if (MessageBox.Show("Erro ao iniciar o Jogo!","Erro",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation) == DialogResult.Cancel){
					EscolhadeNivel();
				}
			}
		}
		
		void Bntnivel2Click(object sender, EventArgs e)
		{
			//Inicio jogo 2
			try{
				IniciarJogoFruit();
				label.Text = "Digite palavras relacionadas a Frutas";
				labeltentativasrest.Text = "Tentativas restantes: " + tentativasRestantes;
				buttonTentar.Enabled = true;
			} catch (Exception E) {
				if (MessageBox.Show("Erro ao iniciar o Jogo!","Erro",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation) == DialogResult.Cancel){
					EscolhadeNivel();
				}
			}
		}
		
		void Bntnivel3Click(object sender, EventArgs e)
		{
			//Inicio jogo 3
			try{
				IniciarJogoMarcas();
				label.Text = "Digite palavras relacionadas a Marcas";
				labeltentativasrest.Text = "Tentativas restantes: " + tentativasRestantes;
				buttonTentar.Enabled = true;
			} catch (Exception E) {
				if (MessageBox.Show("Erro ao iniciar o Jogo!","Erro",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation) == DialogResult.Cancel){
					EscolhadeNivel();
				}
			}
		}
		
		void ButtonTentarClick(object sender, EventArgs e)
		{
			try{
				palavraDigitada = Convert.ToString(msktentativas.Text);
				palavraDigitada.ToLower();
				tentativas += 1;
				tentativasRestantes -= 1;
				if (tentativas == tentativaslimite){
					MessageBox.Show("Você atingiu o limite de tentativas! \n\nA palavra era " + palavraSecreta + "\n\nTente Novamente!","",MessageBoxButtons.OK);
					EscolhadeNivel();
				} else {
					labeltentativasrest.Text = "TentativasRestantes: " + tentativasRestantes;
					if(palavraDigitada != palavraSecreta){
						labelResultado.Text = "Tente outra palavra";
						msktentativas.Clear();
					}
					else if(palavraDigitada == " "){
						MessageBox.Show("Digite um valor válido!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);
						msktentativas.Clear();
					}
					else if(palavraDigitada == palavraSecreta){
						MessageBox.Show("Voce acertou a palavra em " + tentativas + " tentativas!\n\n" + palavraSecreta,"Acertou!", MessageBoxButtons.OK);
						msktentativas.Clear();
						EscolhadeNivel();
					}
				}
			} catch (Exception E) {
				MessageBox.Show("Erro ao executar o jogo escolhido!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void BntnewClick(object sender, EventArgs e)
		{
			//Novo
			try{
				if (MessageBox.Show("Deseja voltar a seleção de nível?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
					EscolhadeNivel();
				}
			} catch (Exception E) {
				MessageBox.Show("Erro ao voltar a seleção de nível!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
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