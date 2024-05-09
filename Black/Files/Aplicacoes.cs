using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Central_de_Controle
{
	public partial class Aplicacoes : Form
	{
		public Aplicacoes()
		{
			InitializeComponent();
		}
		//Declarar as Funções
		static class Windows{
			private const int EWX_LOGOFF = 0;
			private const int EWX_REBOOT = 2;
			
			[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
			private static extern bool ExitWindowsEx(int flg, int rea);
			
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
			public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
			
			public static void TrocarUsuario(){
				ExitWindowsEx(EWX_LOGOFF, 0);
			}
			public static void Reiniciar(){
				var processo = new ProcessStartInfo("shutdown", "/r /t 00");
				processo.CreateNoWindow = true;
				processo.UseShellExecute = false;
				Process.Start(processo);
			}
			public static void Suspender(){
				SetSuspendState(true, true, true);
			}
			public static void Desligar(){
				var processo = new ProcessStartInfo("shutdown", "/s /t 00");
				processo.CreateNoWindow = true;
				processo.UseShellExecute = false;
				Process.Start(processo);
			}
		}
		//Calculadora
		void CalculadoraToolStripMenuItemClick(object sender, EventArgs e)
		{
			Calculadora calc = new Calculadora();
			calc.Show();
			Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Calculadora calc = new Calculadora();
			calc.Show();
			Close();
		}
		//IMC
		void IMCToolStripMenuItemClick(object sender, EventArgs e)
		{
			IMC imc = new IMC();
			imc.Show();
			Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			IMC imc = new IMC();
			imc.Show();
			Close();
		}
		//IPVA
		void IPVAToolStripMenuItemClick(object sender, EventArgs e)
		{
			IPVA ipva = new IPVA();
			ipva.Show();
			Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			IPVA ipva = new IPVA();
			ipva.Show();
			Close();
		}
		//Timers
		void TrmRelogioTick(object sender, EventArgs e)
		{
			LBLHora.Text = DateTime.Now.ToLongTimeString();
		}
		void TrmDataTick(object sender, EventArgs e)
		{
			LblDat.Text = DateTime.Now.ToShortDateString();
		}
		//Jogo - Adivinhação de Numeros
		void AdivinhaçãoDeNumerosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Adivinhacao_de_Numeros adivinhacao = new Adivinhacao_de_Numeros();
			adivinhacao.Show();
			Close();
		}
		void Button4Click(object sender, EventArgs e)
		{
			Adivinhacao_de_Numeros adivinhacao = new Adivinhacao_de_Numeros();
			adivinhacao.Show();
			Close();
		}
		//Jogo - Jogo da Forca
		void JogoFaForcaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Adivinhacao_de_Palavras ap = new Adivinhacao_de_Palavras();
			ap.Show();
			Close();
		}
		void Button5Click(object sender, EventArgs e)
		{
			Adivinhacao_de_Palavras ad = new Adivinhacao_de_Palavras();
			ad.Show();
			Close();
		}
		//Monitor de Desempenho
		void MonitorDeDesempenhoToolStripMenuItemClick(object sender, EventArgs e)
		{
			Monitor_de_Desempenho MnDe = new Monitor_de_Desempenho();
			MnDe.Show();
			Close();
		}
		//Gestão Financeira
		void Button6Click(object sender, EventArgs e)
		{
			Gestao_Financeira gest_finan = new Gestao_Financeira();
			gest_finan.Show();
			Close();
		}
		//Sistema - Calculadora
		void CalculadoraSistemaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Process.Start("C:/Windows/System32/Calc.exe");
		}
		//WhatsApp
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Users/e01desis/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Chrome Apps/WhatsApp Web");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o WhatsApp Web \nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Google Chrome
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files/Google/Chrome/Application/chrome");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Google Chrome \nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Bloco de Notas
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Windows/system32/notepad");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Bloco de Notas \nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Funções
		void DesligarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			try{
				if (MessageBox.Show("Deseja desligar a máquina?", "Desligar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
					Windows.Desligar();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao Desligar","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void ReiniciarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			try{
				if (MessageBox.Show("Deseja reiniciar a máquina?", "Desligar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
					Windows.Reiniciar();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao reiniciar","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void SuspenderToolStripMenuItem1Click(object sender, EventArgs e)
		{
			try{
				if (MessageBox.Show("Deseja suspender a máquina?", "Desligar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
					Windows.Suspender();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao suspender","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void TrocarUsuárioToolStripMenuItem1Click(object sender, EventArgs e)
		{
			try{
				if (MessageBox.Show("Deseja trocar de Usuário?", "Desligar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
					Windows.TrocarUsuario();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao trocar de Usuário","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Fechar
		void BNTSairClick(object sender, EventArgs e)
		{
			try{
			if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
				Close();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao Sair","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void Label10Click(object sender, EventArgs e)
		{
			Close();
		}
		
	}
}

// Leonardo Rodrigues Reis Lopes