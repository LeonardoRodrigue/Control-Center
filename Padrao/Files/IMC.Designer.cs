/*
 * Created by SharpDevelop.
 * User: e01desis
 * Date: 10/10/2023
 * Time: 14:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Central_de_Controle
{
	partial class IMC
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bntcalculo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtimc;
		private System.Windows.Forms.TextBox txtdescricao;
		private System.Windows.Forms.PictureBox imagem;
		private System.Windows.Forms.Button bntnovo;
		private System.Windows.Forms.Label Anter;
		private System.Windows.Forms.Button bntsair;
		private System.Windows.Forms.MaskedTextBox txtpeso;
		private System.Windows.Forms.MaskedTextBox txtaltura;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMC));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bntcalculo = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtimc = new System.Windows.Forms.TextBox();
			this.txtdescricao = new System.Windows.Forms.TextBox();
			this.imagem = new System.Windows.Forms.PictureBox();
			this.bntnovo = new System.Windows.Forms.Button();
			this.Anter = new System.Windows.Forms.Label();
			this.bntsair = new System.Windows.Forms.Button();
			this.txtpeso = new System.Windows.Forms.MaskedTextBox();
			this.txtaltura = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(181, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite seu peso:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(179, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Digite sua altura:";
			// 
			// bntcalculo
			// 
			this.bntcalculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntcalculo.BackgroundImage")));
			this.bntcalculo.Location = new System.Drawing.Point(187, 265);
			this.bntcalculo.Name = "bntcalculo";
			this.bntcalculo.Size = new System.Drawing.Size(119, 33);
			this.bntcalculo.TabIndex = 5;
			this.bntcalculo.Text = "Calcular";
			this.bntcalculo.UseVisualStyleBackColor = true;
			this.bntcalculo.Click += new System.EventHandler(this.BntcalculoClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(200, 344);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Seu IMC é:";
			// 
			// txtimc
			// 
			this.txtimc.Enabled = false;
			this.txtimc.Location = new System.Drawing.Point(148, 372);
			this.txtimc.Name = "txtimc";
			this.txtimc.Size = new System.Drawing.Size(193, 20);
			this.txtimc.TabIndex = 6;
			// 
			// txtdescricao
			// 
			this.txtdescricao.Enabled = false;
			this.txtdescricao.Location = new System.Drawing.Point(148, 404);
			this.txtdescricao.Name = "txtdescricao";
			this.txtdescricao.Size = new System.Drawing.Size(193, 20);
			this.txtdescricao.TabIndex = 8;
			// 
			// imagem
			// 
			this.imagem.BackColor = System.Drawing.Color.Transparent;
			this.imagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagem.BackgroundImage")));
			this.imagem.Location = new System.Drawing.Point(513, 60);
			this.imagem.Name = "imagem";
			this.imagem.Size = new System.Drawing.Size(214, 398);
			this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imagem.TabIndex = 9;
			this.imagem.TabStop = false;
			// 
			// bntnovo
			// 
			this.bntnovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntnovo.BackgroundImage")));
			this.bntnovo.Location = new System.Drawing.Point(12, 496);
			this.bntnovo.Name = "bntnovo";
			this.bntnovo.Size = new System.Drawing.Size(78, 30);
			this.bntnovo.TabIndex = 10;
			this.bntnovo.Text = "Novo";
			this.bntnovo.UseVisualStyleBackColor = true;
			this.bntnovo.Click += new System.EventHandler(this.BntnovoClick);
			// 
			// Anter
			// 
			this.Anter.BackColor = System.Drawing.Color.Transparent;
			this.Anter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Anter.ForeColor = System.Drawing.Color.White;
			this.Anter.Location = new System.Drawing.Point(12, 11);
			this.Anter.Name = "Anter";
			this.Anter.Size = new System.Drawing.Size(23, 28);
			this.Anter.TabIndex = 16;
			this.Anter.Text = "ᐸ";
			this.Anter.Click += new System.EventHandler(this.AnterClick);
			// 
			// bntsair
			// 
			this.bntsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntsair.BackgroundImage")));
			this.bntsair.Location = new System.Drawing.Point(762, 496);
			this.bntsair.Name = "bntsair";
			this.bntsair.Size = new System.Drawing.Size(78, 30);
			this.bntsair.TabIndex = 17;
			this.bntsair.Text = "Voltar";
			this.bntsair.UseVisualStyleBackColor = true;
			this.bntsair.Click += new System.EventHandler(this.BntsairClick);
			// 
			// txtpeso
			// 
			this.txtpeso.Location = new System.Drawing.Point(148, 108);
			this.txtpeso.Name = "txtpeso";
			this.txtpeso.PromptChar = ' ';
			this.txtpeso.Size = new System.Drawing.Size(193, 20);
			this.txtpeso.TabIndex = 18;
			// 
			// txtaltura
			// 
			this.txtaltura.Location = new System.Drawing.Point(148, 205);
			this.txtaltura.Name = "txtaltura";
			this.txtaltura.PromptChar = ' ';
			this.txtaltura.Size = new System.Drawing.Size(193, 20);
			this.txtaltura.TabIndex = 19;
			// 
			// IMC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(852, 538);
			this.Controls.Add(this.txtaltura);
			this.Controls.Add(this.txtpeso);
			this.Controls.Add(this.bntsair);
			this.Controls.Add(this.Anter);
			this.Controls.Add(this.bntnovo);
			this.Controls.Add(this.imagem);
			this.Controls.Add(this.txtdescricao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtimc);
			this.Controls.Add(this.bntcalculo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Name = "IMC";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IMC";
			((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
