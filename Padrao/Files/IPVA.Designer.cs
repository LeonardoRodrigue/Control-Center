/*
 * Created by SharpDevelop.
 * User: e01desis
 * Date: 10/10/2023
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Central_de_Controle
{
	partial class IPVA
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button bntsair;
		private System.Windows.Forms.Label Anter;
		private System.Windows.Forms.Button bntnovo;
		private System.Windows.Forms.TextBox txtvalor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdonibus;
		private System.Windows.Forms.RadioButton rdmoto;
		private System.Windows.Forms.RadioButton rdfurgao;
		private System.Windows.Forms.RadioButton rdpasseio;
		private System.Windows.Forms.PictureBox imagens;
		private System.Windows.Forms.Button bntcalculo;
		private System.Windows.Forms.TextBox txtipva;
		private System.Windows.Forms.Label label3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPVA));
			this.bntsair = new System.Windows.Forms.Button();
			this.Anter = new System.Windows.Forms.Label();
			this.bntnovo = new System.Windows.Forms.Button();
			this.txtvalor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdonibus = new System.Windows.Forms.RadioButton();
			this.rdmoto = new System.Windows.Forms.RadioButton();
			this.rdfurgao = new System.Windows.Forms.RadioButton();
			this.rdpasseio = new System.Windows.Forms.RadioButton();
			this.imagens = new System.Windows.Forms.PictureBox();
			this.bntcalculo = new System.Windows.Forms.Button();
			this.txtipva = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagens)).BeginInit();
			this.SuspendLayout();
			// 
			// bntsair
			// 
			this.bntsair.BackColor = System.Drawing.Color.Transparent;
			this.bntsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntsair.BackgroundImage")));
			this.bntsair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntsair.Location = new System.Drawing.Point(762, 497);
			this.bntsair.Name = "bntsair";
			this.bntsair.Size = new System.Drawing.Size(78, 30);
			this.bntsair.TabIndex = 22;
			this.bntsair.Text = "Voltar";
			this.bntsair.UseVisualStyleBackColor = false;
			this.bntsair.Click += new System.EventHandler(this.BntsairClick);
			// 
			// Anter
			// 
			this.Anter.BackColor = System.Drawing.Color.Transparent;
			this.Anter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Anter.ForeColor = System.Drawing.Color.White;
			this.Anter.Location = new System.Drawing.Point(12, 12);
			this.Anter.Name = "Anter";
			this.Anter.Size = new System.Drawing.Size(23, 28);
			this.Anter.TabIndex = 21;
			this.Anter.Text = "ᐸ";
			this.Anter.Click += new System.EventHandler(this.AnterClick);
			// 
			// bntnovo
			// 
			this.bntnovo.BackColor = System.Drawing.Color.Transparent;
			this.bntnovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntnovo.BackgroundImage")));
			this.bntnovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntnovo.Location = new System.Drawing.Point(12, 497);
			this.bntnovo.Name = "bntnovo";
			this.bntnovo.Size = new System.Drawing.Size(78, 30);
			this.bntnovo.TabIndex = 20;
			this.bntnovo.Text = "Novo";
			this.bntnovo.UseVisualStyleBackColor = false;
			this.bntnovo.Click += new System.EventHandler(this.BntnovoClick);
			// 
			// txtvalor
			// 
			this.txtvalor.Location = new System.Drawing.Point(408, 69);
			this.txtvalor.Name = "txtvalor";
			this.txtvalor.Size = new System.Drawing.Size(193, 20);
			this.txtvalor.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(235, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 25);
			this.label1.TabIndex = 18;
			this.label1.Text = "Digite o valor do carro:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(324, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 25);
			this.label2.TabIndex = 23;
			this.label2.Text = "Selecione a categoria:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.rdonibus);
			this.groupBox1.Controls.Add(this.rdmoto);
			this.groupBox1.Controls.Add(this.rdfurgao);
			this.groupBox1.Controls.Add(this.rdpasseio);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.groupBox1.Location = new System.Drawing.Point(164, 169);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(238, 171);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opções";
			// 
			// rdonibus
			// 
			this.rdonibus.Location = new System.Drawing.Point(15, 123);
			this.rdonibus.Name = "rdonibus";
			this.rdonibus.Size = new System.Drawing.Size(188, 26);
			this.rdonibus.TabIndex = 3;
			this.rdonibus.TabStop = true;
			this.rdonibus.Text = "Ônibus";
			this.rdonibus.UseVisualStyleBackColor = true;
			this.rdonibus.CheckedChanged += new System.EventHandler(this.RdonibusCheckedChanged);
			// 
			// rdmoto
			// 
			this.rdmoto.Location = new System.Drawing.Point(15, 91);
			this.rdmoto.Name = "rdmoto";
			this.rdmoto.Size = new System.Drawing.Size(188, 26);
			this.rdmoto.TabIndex = 2;
			this.rdmoto.TabStop = true;
			this.rdmoto.Text = "Moto";
			this.rdmoto.UseVisualStyleBackColor = true;
			this.rdmoto.CheckedChanged += new System.EventHandler(this.RdmotoCheckedChanged);
			// 
			// rdfurgao
			// 
			this.rdfurgao.Location = new System.Drawing.Point(15, 59);
			this.rdfurgao.Name = "rdfurgao";
			this.rdfurgao.Size = new System.Drawing.Size(188, 26);
			this.rdfurgao.TabIndex = 1;
			this.rdfurgao.TabStop = true;
			this.rdfurgao.Text = "Furgão";
			this.rdfurgao.UseVisualStyleBackColor = true;
			this.rdfurgao.CheckedChanged += new System.EventHandler(this.RdfurgaoCheckedChanged);
			// 
			// rdpasseio
			// 
			this.rdpasseio.Location = new System.Drawing.Point(15, 27);
			this.rdpasseio.Name = "rdpasseio";
			this.rdpasseio.Size = new System.Drawing.Size(188, 26);
			this.rdpasseio.TabIndex = 0;
			this.rdpasseio.TabStop = true;
			this.rdpasseio.Text = "Passeio";
			this.rdpasseio.UseVisualStyleBackColor = true;
			this.rdpasseio.CheckedChanged += new System.EventHandler(this.RdpasseioCheckedChanged);
			// 
			// imagens
			// 
			this.imagens.BackColor = System.Drawing.Color.Transparent;
			this.imagens.Location = new System.Drawing.Point(472, 173);
			this.imagens.Name = "imagens";
			this.imagens.Size = new System.Drawing.Size(241, 166);
			this.imagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imagens.TabIndex = 25;
			this.imagens.TabStop = false;
			// 
			// bntcalculo
			// 
			this.bntcalculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntcalculo.BackgroundImage")));
			this.bntcalculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntcalculo.Location = new System.Drawing.Point(370, 364);
			this.bntcalculo.Name = "bntcalculo";
			this.bntcalculo.Size = new System.Drawing.Size(104, 30);
			this.bntcalculo.TabIndex = 26;
			this.bntcalculo.Text = "Calcular";
			this.bntcalculo.UseVisualStyleBackColor = true;
			this.bntcalculo.Click += new System.EventHandler(this.BntcalculoClick);
			// 
			// txtipva
			// 
			this.txtipva.Location = new System.Drawing.Point(408, 426);
			this.txtipva.Name = "txtipva";
			this.txtipva.Size = new System.Drawing.Size(193, 20);
			this.txtipva.TabIndex = 28;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(235, 421);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 25);
			this.label3.TabIndex = 27;
			this.label3.Text = "O valor do IPVA é:";
			// 
			// IPVA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(852, 538);
			this.Controls.Add(this.txtipva);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bntcalculo);
			this.Controls.Add(this.imagens);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bntsair);
			this.Controls.Add(this.Anter);
			this.Controls.Add(this.bntnovo);
			this.Controls.Add(this.txtvalor);
			this.Controls.Add(this.label1);
			this.Name = "IPVA";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IPVA";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imagens)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
