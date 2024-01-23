/*
 * Created by SharpDevelop.
 * User: e01desis
 * Date: 10/10/2023
 * Time: 14:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Central_de_Controle
{
	partial class Calculadora
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtnum1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnum2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rddivisao;
		private System.Windows.Forms.RadioButton rdmultiplicacao;
		private System.Windows.Forms.RadioButton rdsubtracao;
		private System.Windows.Forms.RadioButton rdadicao;
		private System.Windows.Forms.Button bntcalculo;
		private System.Windows.Forms.TextBox txtresultado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bntsair;
		private System.Windows.Forms.Label Anter;
		private System.Windows.Forms.Button bntnovo;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
			this.txtnum1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtnum2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rddivisao = new System.Windows.Forms.RadioButton();
			this.rdmultiplicacao = new System.Windows.Forms.RadioButton();
			this.rdsubtracao = new System.Windows.Forms.RadioButton();
			this.rdadicao = new System.Windows.Forms.RadioButton();
			this.bntcalculo = new System.Windows.Forms.Button();
			this.txtresultado = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bntsair = new System.Windows.Forms.Button();
			this.Anter = new System.Windows.Forms.Label();
			this.bntnovo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtnum1
			// 
			this.txtnum1.Location = new System.Drawing.Point(141, 106);
			this.txtnum1.Name = "txtnum1";
			this.txtnum1.Size = new System.Drawing.Size(193, 20);
			this.txtnum1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(174, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Primeiro numero:";
			// 
			// txtnum2
			// 
			this.txtnum2.Location = new System.Drawing.Point(141, 189);
			this.txtnum2.Name = "txtnum2";
			this.txtnum2.Size = new System.Drawing.Size(193, 20);
			this.txtnum2.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(174, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Segundo numero:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.rddivisao);
			this.groupBox1.Controls.Add(this.rdmultiplicacao);
			this.groupBox1.Controls.Add(this.rdsubtracao);
			this.groupBox1.Controls.Add(this.rdadicao);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.groupBox1.Location = new System.Drawing.Point(464, 94);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 276);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opções";
			// 
			// rddivisao
			// 
			this.rddivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rddivisao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rddivisao.Location = new System.Drawing.Point(30, 209);
			this.rddivisao.Name = "rddivisao";
			this.rddivisao.Size = new System.Drawing.Size(148, 24);
			this.rddivisao.TabIndex = 3;
			this.rddivisao.TabStop = true;
			this.rddivisao.Text = "Divisão";
			this.rddivisao.UseVisualStyleBackColor = true;
			// 
			// rdmultiplicacao
			// 
			this.rdmultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdmultiplicacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rdmultiplicacao.Location = new System.Drawing.Point(30, 151);
			this.rdmultiplicacao.Name = "rdmultiplicacao";
			this.rdmultiplicacao.Size = new System.Drawing.Size(148, 24);
			this.rdmultiplicacao.TabIndex = 2;
			this.rdmultiplicacao.TabStop = true;
			this.rdmultiplicacao.Text = "Multiplicação";
			this.rdmultiplicacao.UseVisualStyleBackColor = true;
			// 
			// rdsubtracao
			// 
			this.rdsubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdsubtracao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rdsubtracao.Location = new System.Drawing.Point(30, 94);
			this.rdsubtracao.Name = "rdsubtracao";
			this.rdsubtracao.Size = new System.Drawing.Size(148, 24);
			this.rdsubtracao.TabIndex = 1;
			this.rdsubtracao.TabStop = true;
			this.rdsubtracao.Text = "Subtração";
			this.rdsubtracao.UseVisualStyleBackColor = true;
			// 
			// rdadicao
			// 
			this.rdadicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdadicao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rdadicao.Location = new System.Drawing.Point(30, 39);
			this.rdadicao.Name = "rdadicao";
			this.rdadicao.Size = new System.Drawing.Size(148, 24);
			this.rdadicao.TabIndex = 0;
			this.rdadicao.TabStop = true;
			this.rdadicao.Text = "Adição";
			this.rdadicao.UseVisualStyleBackColor = true;
			// 
			// bntcalculo
			// 
			this.bntcalculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntcalculo.BackgroundImage")));
			this.bntcalculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntcalculo.Location = new System.Drawing.Point(188, 259);
			this.bntcalculo.Name = "bntcalculo";
			this.bntcalculo.Size = new System.Drawing.Size(105, 33);
			this.bntcalculo.TabIndex = 8;
			this.bntcalculo.Text = "Calcular";
			this.bntcalculo.UseVisualStyleBackColor = true;
			this.bntcalculo.Click += new System.EventHandler(this.BntcalculoClick);
			// 
			// txtresultado
			// 
			this.txtresultado.Location = new System.Drawing.Point(141, 360);
			this.txtresultado.Name = "txtresultado";
			this.txtresultado.Size = new System.Drawing.Size(193, 20);
			this.txtresultado.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(193, 332);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 25);
			this.label3.TabIndex = 9;
			this.label3.Text = "Resultado:";
			// 
			// bntsair
			// 
			this.bntsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntsair.BackgroundImage")));
			this.bntsair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntsair.Location = new System.Drawing.Point(762, 496);
			this.bntsair.Name = "bntsair";
			this.bntsair.Size = new System.Drawing.Size(78, 30);
			this.bntsair.TabIndex = 20;
			this.bntsair.Text = "Voltar";
			this.bntsair.UseVisualStyleBackColor = true;
			this.bntsair.Click += new System.EventHandler(this.BntsairClick);
			// 
			// Anter
			// 
			this.Anter.BackColor = System.Drawing.Color.Transparent;
			this.Anter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Anter.ForeColor = System.Drawing.Color.White;
			this.Anter.Location = new System.Drawing.Point(12, 11);
			this.Anter.Name = "Anter";
			this.Anter.Size = new System.Drawing.Size(23, 28);
			this.Anter.TabIndex = 19;
			this.Anter.Text = "ᐸ";
			this.Anter.Click += new System.EventHandler(this.AnterClick);
			// 
			// bntnovo
			// 
			this.bntnovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntnovo.BackgroundImage")));
			this.bntnovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntnovo.Location = new System.Drawing.Point(12, 496);
			this.bntnovo.Name = "bntnovo";
			this.bntnovo.Size = new System.Drawing.Size(78, 30);
			this.bntnovo.TabIndex = 18;
			this.bntnovo.Text = "Novo";
			this.bntnovo.UseVisualStyleBackColor = true;
			this.bntnovo.Click += new System.EventHandler(this.BntnovoClick);
			// 
			// Calculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(852, 538);
			this.Controls.Add(this.bntsair);
			this.Controls.Add(this.Anter);
			this.Controls.Add(this.bntnovo);
			this.Controls.Add(this.txtresultado);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bntcalculo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtnum2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtnum1);
			this.Controls.Add(this.label1);
			this.Name = "Calculadora";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
