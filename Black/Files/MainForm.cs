﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Central_de_Controle
{
	//Caso for utilizar na sua Maquina altere as rotinas de TODAS as aplicações que estiverem acusando ERRO. 
	public partial class Central : Form
	{
		public Central()
		{
			InitializeComponent();
		}
		//Declarar as Funções
		static class Windows{
			private const int EWX_LOGOFF = 0;
			
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
			public static void Cmd(){
				var cmd = new ProcessStartInfo("cmd");
				Process.Start(cmd);
			}
			public static void Regedit(){
				var regedit = new ProcessStartInfo("regedit");
				Process.Start(regedit);
			}
		}
		private void CloseAll(){
			Close();
		}
		//SysPDV
		void ServerToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Syspdv/Syspdv_server");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o SysPDV Server \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void PDVToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Syspdv/Syspdv_pdv");
			} catch(Exception E){
				MessageBox.Show("Erro ao abir o PDV \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void PDAToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Syspdv/Syspdv_pda");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o PDA \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void ToolsToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Syspdv/SysPDVTools");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Tools \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//E-Conect
		void ConcentradorToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/socin/econect/conc/bin/iniciaconcentrador");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Concentrador \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void LiberaçãoToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/socin/econect/conc/bin/inicialiberacao");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir a Liberação \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//EasyAssist
		void RetaguardaToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files (x86)/EasyAssist/EasyAssistRetaguarda");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Retaguarda \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void PDVToolStripMenuItem1Click(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files (x86)/EasyAssist/EasyAssist-Windows_");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o PDV \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void EATotemToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files (x86)/Proabakus/EATOTEM");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o EATotem \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Saurus
		void SaurusToolStripMenuItem1Click(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Saurus/Saurus PDV/Saurus_PDV.Fit");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o PDV \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void AtualizadorToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Saurus/Saurus Atualizador/Saurus_V4.Atualizador");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Atualizador \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//MySQL
		void WorkBenchToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files/MySQL/MySQL Workbench 8.0 CE/MySQLWorkbench");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Workbench \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void ComandLineToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files (x86)/MySQL/MySQL Server 5.5/bin/mysql");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o MySQL \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Explorador de Arquivos
		void ExploradorDeArquivosToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Explorador de Arquivos \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Google Chrome
		void GoogleChromeToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files/Google/Chrome/Application/chrome");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Google Chrome \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Brave
		void BraveToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files/BraveSoftware/Brave-Browser/Application/brave.exe");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Brave\n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Discord
		void DiscordToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Users/e01desis/AppData/Local/Discord/Update");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Discord \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		
		//WhatsApp Web
		void WhatsAppClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Users/e01desis/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Chrome Apps/WhatsApp Web");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o WhatsApp Web \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Google Chrome
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files/Google/Chrome/Application/chrome");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Google Chrome \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Bloco de Notas
		void Bloco_de_NotasClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Windows/system32/notepad");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Bloco de Notas \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Virtual Box
		void RegeditToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files/Oracle/VirtualBox/VirtualBox");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Virtual Box \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		
		//OBS Studio
		void CmdToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/ProgramData/Microsoft/Windows/Start Menu/Programs/OBS Studio/OBS Studio (64bit)");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o OBS Studio \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//WinRAR
		void PainelDeControleToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files/WinRAR/WinRAR");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o WinRAR \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Cmd
		void PromptDeComandoToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				Windows.Cmd();
			} catch (Exception E) {
				MessageBox.Show("Erro ao abrir o Cmd","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void EditorDoRegistroToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				Windows.Regedit();
			} catch (Exception E) {
				MessageBox.Show("Erro ao abrir o regedit","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		//Acesso Remoto
		void AnyDeskToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files (x86)/EasyAssist/AnyDesk");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o AnyDesk \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void TeamViewer13ToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files (x86)/TeamViewer/TeamViewer");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o TeamViewer 13 \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void TeamViewerQSToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/ProgramData/Microsoft/Windows/Start Menu/Programs/EasyAssist/TeamViewerQS");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o TeamViewer QS \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Sair
		void BNTSairClick(object sender, EventArgs e)
		{
			try{
			if (MessageBox.Show("Deseja sair?", "Desligar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
					CloseAll();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao Sair","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void AnterClick(object sender, EventArgs e)
		{
			CloseAll();
		}
		//IDEs
		void SharpDevelopeToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Program Files (x86)/SharpDevelop/5.1/bin/SharpDevelop");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o SharpDevelop \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void EclipseToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Users/e01desis/eclipse/java-2023-06/eclipse/eclipse");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Eclipse \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void VisualStudioToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/Users/e01desis/AppData/Local/Programs/Microsoft VS Code/Code");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Visual Studio Code \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Botões - Tela
		void BNTChromeClick(object sender, EventArgs e)
		{
			try{
				Aplicacoes apli = new Aplicacoes();
				apli.Show();
			} catch (Exception E){
				MessageBox.Show("Erro ao abir as Aplicações","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void BNTTeamClick(object sender, EventArgs e)
		{
			try{
				Navegador nav = new Navegador();
				nav.Show();
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Navegador","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void BNTExplorClick(object sender, EventArgs e)
		{
			try{
			Process.Start("C:/");
			} catch (Exception E){
				MessageBox.Show("Erro ao abir o Explorador de Arquivos \n\nEspecifique o caminho correto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
		void TrocarUsuárioToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				if (MessageBox.Show("Deseja trocar de Usuário?", "Desligar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
					Windows.TrocarUsuario();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao trocar de Usuário","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Aplicações
		void AplicaçõesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Aplicacoes apli = new Aplicacoes();
			apli.Show();
		}
		void PósClick(object sender, EventArgs e)
		{
			Aplicacoes apli = new Aplicacoes();
			apli.Show();
		}
		//Timers
		void TmrRelogioTick(object sender, EventArgs e)
		{
			LBLHora.Text = DateTime.Now.ToLongTimeString();
		}
		void TmrDataTick(object sender, EventArgs e)
		{
			labeldata.Text = DateTime.Now.ToShortDateString();
		}
		
		
	}
}