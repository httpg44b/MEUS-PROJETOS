/*
 * Criado por SharpDevelop.
 * Usuário: Gabriel Oliveira
 * Data: 25/11/2020
 * Hora: 13:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace QUIZ
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.Pergunta = new System.Windows.Forms.Label();
			this.alternativa1 = new System.Windows.Forms.Label();
			this.alternativa2 = new System.Windows.Forms.Label();
			this.alternativa4 = new System.Windows.Forms.Label();
			this.alternativa3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Pergunta
			// 
			this.Pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pergunta.Location = new System.Drawing.Point(31, 29);
			this.Pergunta.Name = "Pergunta";
			this.Pergunta.Size = new System.Drawing.Size(1175, 23);
			this.Pergunta.TabIndex = 0;
			this.Pergunta.Text = "Pergunta";
			// 
			// alternativa1
			// 
			this.alternativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alternativa1.Location = new System.Drawing.Point(85, 124);
			this.alternativa1.Name = "alternativa1";
			this.alternativa1.Size = new System.Drawing.Size(666, 23);
			this.alternativa1.TabIndex = 1;
			this.alternativa1.Text = "Alternativa1";
			// 
			// alternativa2
			// 
			this.alternativa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alternativa2.Location = new System.Drawing.Point(85, 251);
			this.alternativa2.Name = "alternativa2";
			this.alternativa2.Size = new System.Drawing.Size(666, 23);
			this.alternativa2.TabIndex = 2;
			this.alternativa2.Text = "Alternativa 2";
			// 
			// alternativa4
			// 
			this.alternativa4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alternativa4.Location = new System.Drawing.Point(85, 508);
			this.alternativa4.Name = "alternativa4";
			this.alternativa4.Size = new System.Drawing.Size(666, 23);
			this.alternativa4.TabIndex = 3;
			this.alternativa4.Text = "Alternativa 4";
			// 
			// alternativa3
			// 
			this.alternativa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alternativa3.Location = new System.Drawing.Point(85, 373);
			this.alternativa3.Name = "alternativa3";
			this.alternativa3.Size = new System.Drawing.Size(666, 23);
			this.alternativa3.TabIndex = 4;
			this.alternativa3.Text = "Alternativa 3";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Silver;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(31, 115);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 37);
			this.button3.TabIndex = 7;
			this.button3.Text = "A";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Silver;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(31, 242);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 37);
			this.button4.TabIndex = 7;
			this.button4.Text = "B";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Silver;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(31, 364);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 37);
			this.button5.TabIndex = 7;
			this.button5.Text = "C";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Silver;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(31, 499);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(48, 37);
			this.button6.TabIndex = 7;
			this.button6.Text = "D";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(955, 34);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(251, 308);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(85, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(666, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Alternativa1";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(85, 251);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(666, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Alternativa 2";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(85, 373);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(666, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Alternativa 3";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(85, 508);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(666, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Alternativa 4";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.MidnightBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(12, 692);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(574, 70);
			this.button2.TabIndex = 6;
			this.button2.Text = "Menu";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MidnightBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(689, 692);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(574, 70);
			this.button1.TabIndex = 5;
			this.button1.Text = "Começar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(-3, -4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1533, 690);
			this.panel1.TabIndex = 13;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(49, 304);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(607, 310);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(745, 304);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 310);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.MidnightBlue;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(0, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1302, 309);
			this.label5.TabIndex = 0;
			this.label5.Text = "QUIZ SOBRE HARDWARE";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1218, 765);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.alternativa3);
			this.Controls.Add(this.alternativa4);
			this.Controls.Add(this.alternativa2);
			this.Controls.Add(this.alternativa1);
			this.Controls.Add(this.Pergunta);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "QUIZ";
			this.Load += new System.EventHandler(this.Form2Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label alternativa3;
		private System.Windows.Forms.Label alternativa4;
		private System.Windows.Forms.Label alternativa2;
		private System.Windows.Forms.Label alternativa1;
		private System.Windows.Forms.Label Pergunta;
	}
}
