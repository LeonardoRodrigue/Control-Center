/*
 * Created by SharpDevelop.
 * User: e01desis
 * Date: 10/10/2023
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Central_de_Controle
{
	partial class Aplicacoes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculosToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iMCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iPVAToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bntCalculadora;
		private System.Windows.Forms.Button bntIMC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bntIPVA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bntAdivin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label Anter;
		private System.Windows.Forms.Button BNTSair;
		private System.Windows.Forms.Timer TrmRelogio;
		private System.Windows.Forms.Timer TrmData;
		private System.Windows.Forms.Label LBLHora;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ToolStripMenuItem calculadoraSistemaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adivinhaçãoDeNumerosToolStripMenuItem;
		private System.Windows.Forms.Label LblDat;
		private System.Windows.Forms.ToolStripMenuItem jogoFaForcaToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem desligarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem suspenderToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem monitorDeDesempenhoToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicacoes));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adivinhaçãoDeNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jogoFaForcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iPVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculadoraSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.desligarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.reiniciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.suspenderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.trocarUsuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bntCalculadora = new System.Windows.Forms.Button();
			this.bntIMC = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.bntIPVA = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.bntAdivin = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Anter = new System.Windows.Forms.Label();
			this.BNTSair = new System.Windows.Forms.Button();
			this.TrmRelogio = new System.Windows.Forms.Timer(this.components);
			this.TrmData = new System.Windows.Forms.Timer(this.components);
			this.LBLHora = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.LblDat = new System.Windows.Forms.Label();
			this.monitorDeDesempenhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.jogosToolStripMenuItem,
			this.calculosToolStripMenuItem,
			this.outrosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(852, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// jogosToolStripMenuItem
			// 
			this.jogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.adivinhaçãoDeNumerosToolStripMenuItem,
			this.jogoFaForcaToolStripMenuItem});
			this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
			this.jogosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.jogosToolStripMenuItem.Text = "Jogos";
			// 
			// adivinhaçãoDeNumerosToolStripMenuItem
			// 
			this.adivinhaçãoDeNumerosToolStripMenuItem.Name = "adivinhaçãoDeNumerosToolStripMenuItem";
			this.adivinhaçãoDeNumerosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.adivinhaçãoDeNumerosToolStripMenuItem.Text = "Adivinhação de Numeros";
			this.adivinhaçãoDeNumerosToolStripMenuItem.Click += new System.EventHandler(this.AdivinhaçãoDeNumerosToolStripMenuItemClick);
			// 
			// jogoFaForcaToolStripMenuItem
			// 
			this.jogoFaForcaToolStripMenuItem.Name = "jogoFaForcaToolStripMenuItem";
			this.jogoFaForcaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.jogoFaForcaToolStripMenuItem.Text = "Jogo da Forca";
			this.jogoFaForcaToolStripMenuItem.Click += new System.EventHandler(this.JogoFaForcaToolStripMenuItemClick);
			// 
			// calculosToolStripMenuItem
			// 
			this.calculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.calculadoraToolStripMenuItem,
			this.iMCToolStripMenuItem,
			this.iPVAToolStripMenuItem});
			this.calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
			this.calculosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.calculosToolStripMenuItem.Text = "Calculos";
			// 
			// calculadoraToolStripMenuItem
			// 
			this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
			this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.calculadoraToolStripMenuItem.Text = "Calculadora";
			this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.CalculadoraToolStripMenuItemClick);
			// 
			// iMCToolStripMenuItem
			// 
			this.iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
			this.iMCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.iMCToolStripMenuItem.Text = "IMC";
			this.iMCToolStripMenuItem.Click += new System.EventHandler(this.IMCToolStripMenuItemClick);
			// 
			// iPVAToolStripMenuItem
			// 
			this.iPVAToolStripMenuItem.Name = "iPVAToolStripMenuItem";
			this.iPVAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.iPVAToolStripMenuItem.Text = "IPVA";
			this.iPVAToolStripMenuItem.Click += new System.EventHandler(this.IPVAToolStripMenuItemClick);
			// 
			// outrosToolStripMenuItem
			// 
			this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.calculadoraSistemaToolStripMenuItem,
			this.monitorDeDesempenhoToolStripMenuItem});
			this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
			this.outrosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.outrosToolStripMenuItem.Text = "Outros";
			// 
			// calculadoraSistemaToolStripMenuItem
			// 
			this.calculadoraSistemaToolStripMenuItem.Name = "calculadoraSistemaToolStripMenuItem";
			this.calculadoraSistemaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.calculadoraSistemaToolStripMenuItem.Text = "Calculadora - Sistema";
			this.calculadoraSistemaToolStripMenuItem.Click += new System.EventHandler(this.CalculadoraSistemaToolStripMenuItemClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButton1,
			this.toolStripButton2,
			this.toolStripButton3,
			this.toolStripSeparator2,
			this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(852, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.desligarToolStripMenuItem1,
			this.reiniciarToolStripMenuItem1,
			this.suspenderToolStripMenuItem1,
			this.trocarUsuárioToolStripMenuItem1});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
			// 
			// desligarToolStripMenuItem1
			// 
			this.desligarToolStripMenuItem1.Name = "desligarToolStripMenuItem1";
			this.desligarToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.desligarToolStripMenuItem1.Text = "Desligar";
			this.desligarToolStripMenuItem1.Click += new System.EventHandler(this.DesligarToolStripMenuItem1Click);
			// 
			// reiniciarToolStripMenuItem1
			// 
			this.reiniciarToolStripMenuItem1.Name = "reiniciarToolStripMenuItem1";
			this.reiniciarToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.reiniciarToolStripMenuItem1.Text = "Reiniciar";
			this.reiniciarToolStripMenuItem1.Click += new System.EventHandler(this.ReiniciarToolStripMenuItem1Click);
			// 
			// suspenderToolStripMenuItem1
			// 
			this.suspenderToolStripMenuItem1.Name = "suspenderToolStripMenuItem1";
			this.suspenderToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.suspenderToolStripMenuItem1.Text = "Suspender";
			this.suspenderToolStripMenuItem1.Click += new System.EventHandler(this.SuspenderToolStripMenuItem1Click);
			// 
			// trocarUsuárioToolStripMenuItem1
			// 
			this.trocarUsuárioToolStripMenuItem1.Name = "trocarUsuárioToolStripMenuItem1";
			this.trocarUsuárioToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.trocarUsuárioToolStripMenuItem1.Text = "Trocar Usuário";
			this.trocarUsuárioToolStripMenuItem1.Click += new System.EventHandler(this.TrocarUsuárioToolStripMenuItem1Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(332, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 47);
			this.label1.TabIndex = 2;
			this.label1.Text = "Aplicações";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(113, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Calculadora";
			// 
			// bntCalculadora
			// 
			this.bntCalculadora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntCalculadora.BackgroundImage")));
			this.bntCalculadora.Location = new System.Drawing.Point(82, 221);
			this.bntCalculadora.Name = "bntCalculadora";
			this.bntCalculadora.Size = new System.Drawing.Size(157, 27);
			this.bntCalculadora.TabIndex = 4;
			this.bntCalculadora.Text = "Iniciar";
			this.bntCalculadora.UseVisualStyleBackColor = true;
			this.bntCalculadora.Click += new System.EventHandler(this.Button1Click);
			// 
			// bntIMC
			// 
			this.bntIMC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntIMC.BackgroundImage")));
			this.bntIMC.Location = new System.Drawing.Point(348, 221);
			this.bntIMC.Name = "bntIMC";
			this.bntIMC.Size = new System.Drawing.Size(157, 27);
			this.bntIMC.TabIndex = 6;
			this.bntIMC.Text = "Iniciar";
			this.bntIMC.UseVisualStyleBackColor = true;
			this.bntIMC.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(364, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "Calculo de IMC";
			// 
			// bntIPVA
			// 
			this.bntIPVA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntIPVA.BackgroundImage")));
			this.bntIPVA.Location = new System.Drawing.Point(612, 221);
			this.bntIPVA.Name = "bntIPVA";
			this.bntIPVA.Size = new System.Drawing.Size(157, 27);
			this.bntIPVA.TabIndex = 8;
			this.bntIPVA.Text = "Iniciar";
			this.bntIPVA.UseVisualStyleBackColor = true;
			this.bntIPVA.Click += new System.EventHandler(this.Button3Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(622, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 29);
			this.label4.TabIndex = 7;
			this.label4.Text = "Calculo de IPVA";
			// 
			// bntAdivin
			// 
			this.bntAdivin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntAdivin.BackgroundImage")));
			this.bntAdivin.Location = new System.Drawing.Point(82, 362);
			this.bntAdivin.Name = "bntAdivin";
			this.bntAdivin.Size = new System.Drawing.Size(157, 27);
			this.bntAdivin.TabIndex = 10;
			this.bntAdivin.Text = "Iniciar";
			this.bntAdivin.UseVisualStyleBackColor = true;
			this.bntAdivin.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Location = new System.Drawing.Point(348, 362);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(157, 27);
			this.button5.TabIndex = 12;
			this.button5.Text = "Iniciar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(337, 330);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(183, 29);
			this.label6.TabIndex = 11;
			this.label6.Text = "Adivinhação de Palavras";
			// 
			// button6
			// 
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.Location = new System.Drawing.Point(612, 362);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(157, 27);
			this.button6.TabIndex = 14;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(628, 330);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(127, 29);
			this.label7.TabIndex = 13;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(811, 60);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 28);
			this.label8.TabIndex = 16;
			this.label8.Text = "ᐳ";
			// 
			// Anter
			// 
			this.Anter.BackColor = System.Drawing.Color.Transparent;
			this.Anter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Anter.ForeColor = System.Drawing.Color.Black;
			this.Anter.Location = new System.Drawing.Point(12, 60);
			this.Anter.Name = "Anter";
			this.Anter.Size = new System.Drawing.Size(23, 28);
			this.Anter.TabIndex = 15;
			this.Anter.Text = "ᐸ";
			// 
			// BNTSair
			// 
			this.BNTSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNTSair.BackgroundImage")));
			this.BNTSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BNTSair.Location = new System.Drawing.Point(748, 491);
			this.BNTSair.Name = "BNTSair";
			this.BNTSair.Size = new System.Drawing.Size(92, 35);
			this.BNTSair.TabIndex = 17;
			this.BNTSair.Text = "Sair";
			this.BNTSair.UseVisualStyleBackColor = true;
			this.BNTSair.Click += new System.EventHandler(this.BNTSairClick);
			// 
			// TrmRelogio
			// 
			this.TrmRelogio.Enabled = true;
			this.TrmRelogio.Interval = 1000;
			this.TrmRelogio.Tick += new System.EventHandler(this.TrmRelogioTick);
			// 
			// TrmData
			// 
			this.TrmData.Enabled = true;
			this.TrmData.Interval = 1000;
			this.TrmData.Tick += new System.EventHandler(this.TrmDataTick);
			// 
			// LBLHora
			// 
			this.LBLHora.BackColor = System.Drawing.Color.Transparent;
			this.LBLHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLHora.ForeColor = System.Drawing.Color.White;
			this.LBLHora.Location = new System.Drawing.Point(12, 508);
			this.LBLHora.Name = "LBLHora";
			this.LBLHora.Size = new System.Drawing.Size(68, 21);
			this.LBLHora.TabIndex = 18;
			this.LBLHora.Text = "00:00:00";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(12, 58);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 28);
			this.label10.TabIndex = 20;
			this.label10.Text = "ᐸ";
			this.label10.Click += new System.EventHandler(this.Label10Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(72, 327);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(186, 29);
			this.label5.TabIndex = 21;
			this.label5.Text = "Adivinhação de Numeros";
			// 
			// LblDat
			// 
			this.LblDat.BackColor = System.Drawing.Color.Transparent;
			this.LblDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblDat.ForeColor = System.Drawing.Color.White;
			this.LblDat.Location = new System.Drawing.Point(86, 508);
			this.LblDat.Name = "LblDat";
			this.LblDat.Size = new System.Drawing.Size(83, 21);
			this.LblDat.TabIndex = 23;
			this.LblDat.Text = "00/00/0000";
			// 
			// monitorDeDesempenhoToolStripMenuItem
			// 
			this.monitorDeDesempenhoToolStripMenuItem.Name = "monitorDeDesempenhoToolStripMenuItem";
			this.monitorDeDesempenhoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.monitorDeDesempenhoToolStripMenuItem.Text = "Monitor de Desempenho";
			this.monitorDeDesempenhoToolStripMenuItem.Click += new System.EventHandler(this.MonitorDeDesempenhoToolStripMenuItemClick);
			// 
			// Aplicacoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(852, 538);
			this.Controls.Add(this.LblDat);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.LBLHora);
			this.Controls.Add(this.BNTSair);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Anter);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.bntAdivin);
			this.Controls.Add(this.bntIPVA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bntIMC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bntCalculadora);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.White;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Aplicacoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
