/*
 * Criado por SharpDevelop.
 * Usuário: Gabriel Oliveira
 * Data: 25/11/2020
 * Hora: 13:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUIZ
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		
		int cont=0;
	    int altIn = 0;
		int n=0;
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Form2Load(object sender, EventArgs e)
		{
			richTextBox1.Visible = false;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			panel1.Visible = false;
			pictureBox1.Visible = false;
			label5.Visible = false;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
		
			//COMEÇAR
			richTextBox1.Enabled = false;
			richTextBox1.LoadFile("QUIZ.txt", RichTextBoxStreamType.PlainText);
			Random nAle = new Random();
			
			n = nAle.Next(0,richTextBox1.Lines.Length-1);
			string linha = richTextBox1.Lines[n];
			string[] info = linha.Split('|');
			string[] altCertas = {"Memória de vídeo.", "LGA 2011.", "Não, pois ssd, não tem nada haver com desempenho em jogos.", "Para mostrar o vídeo do computador.", "Gddr6.", "Rom.", "O computador não vai dar vídeo.", "Ram.", "Pci - express.", "Xeon."};
			
			Pergunta.Text = info[0];
			alternativa1.Text = info[1];
			alternativa2.Text = info[2];
			alternativa3.Text = info[3];
			alternativa4.Text = info[4];
			
			switch (n)
			    {
				case 0:
					label3.Visible = true;
					label1.Visible = false;
					label2.Visible = false;
					label4.Visible = false;
					label1.Text = altCertas[0];
					label2.Text = altCertas[0];
					label3.Text = altCertas[0];
					label4.Text = altCertas[0];
					break;
				case 1:
					label1.Visible = false;
					label2.Visible = false;
					label3.Visible = false;
					label4.Visible = true;
					label1.Text = altCertas[1];
					label2.Text = altCertas[1];
					label3.Text = altCertas[1];
					label4.Text = altCertas[1];
					break;
				case 2:
					label1.Visible = false;
					label3.Visible = false;
					label4.Visible = false;
					label2.Visible = true;
					label1.Text = altCertas[2];
					label2.Text = altCertas[2];
					label3.Text = altCertas[2];
					label4.Text = altCertas[2];
					break;
				case 3:
					label2.Visible = false;
					label3.Visible = false;
					label1.Visible = true;
					label4.Visible = false;
					label1.Text = altCertas[3];
					label2.Text = altCertas[3];
					label3.Text = altCertas[3];
					label4.Text = altCertas[3];
					break;
				case 4:
					label1.Visible = false;
					label2.Visible = false;
					label3.Visible = true;
					label4.Visible = false;
					label1.Text = altCertas[4];
					label2.Text = altCertas[4];
					label3.Text = altCertas[4];
					label4.Text = altCertas[4];
					break;
				case 5:
					label1.Visible = false;
					label2.Visible = true;
					label3.Visible = false;
					label4.Visible = false;
					label1.Text = altCertas[5];
					label2.Text = altCertas[5];
					label3.Text = altCertas[5];
					label4.Text = altCertas[5];
					break;
				case 6:
					label1.Visible = false;
					label2.Visible = false;
					label3.Visible = true;
					label4.Visible = false;
					label1.Text = altCertas[6];
					label2.Text = altCertas[6];
					label3.Text = altCertas[6];
					label4.Text = altCertas[6];
					break;
				case 7:
					label1.Visible = false;
					label2.Visible = false;
					label3.Visible = true;
					label4.Visible = false;
					label1.Text = altCertas[7];
					label2.Text = altCertas[7];
					label3.Text = altCertas[7];
					label4.Text = altCertas[7];
					break;
				case 8:
					label1.Visible = true;
					label2.Visible = false;
					label3.Visible = false;
					label4.Visible = false;
					label1.Text = altCertas[8];
					label2.Text = altCertas[8];
					label3.Text = altCertas[8];
					label4.Text = altCertas[8];
					break;
				case 9:
					label1.Visible = false;
					label2.Visible = false;
					label3.Visible = false;
					label4.Visible = true;
					label1.Text = altCertas[9];
					label2.Text = altCertas[9];
					label3.Text = altCertas[9];
					label4.Text = altCertas[9];
					break;
			    }
				button1.Text = "PRÓXIMA QUESTÃO";
				this.button4.BackColor = Color.Gray;
				this.button5.BackColor = Color.Gray;
				this.button6.BackColor = Color.Gray;
				this.button3.BackColor = Color.Gray;
		}
		
		void Button3Click(object sender, EventArgs e)
		{	
			char altSele = button3.Text[cont];
			
			foreach(char letra in richTextBox1.Lines[n])
			{
				if(altSele == letra)
				{
					cont++;
				}
				else
				{ 
					altIn++;
				}
			}
			if(cont > 0){
					this.button3.BackColor = Color.Green;
					this.button4.BackColor = Color.Gray;
					this.button5.BackColor = Color.Gray;
					this.button6.BackColor = Color.Gray;
					MessageBox.Show("Alternativa correta!");
					button3.Enabled = false;
					button4.Enabled = false;
					button5.Enabled = false;
					button6.Enabled = false;
				}else{
				    this.button3.BackColor = Color.Red;
				    this.button4.BackColor = Color.Gray;
					this.button5.BackColor = Color.Gray;
					this.button6.BackColor = Color.Gray;
					MessageBox.Show("Alternativa incorreta!");
					button3.Enabled = false;
					button4.Enabled = false;
					button5.Enabled = false;
					button6.Enabled = false;
				}
				
				cont=0;
	}
		
		void Button4Click(object sender, EventArgs e)
		{
			char altSele = button4.Text[cont];
			foreach(char letra in richTextBox1.Lines[n])
			{
				if(altSele == letra)
				{
					cont++;
				}
				else
				{ 
					altIn++;
				}
			}
			if(cont > 0){
					this.button4.BackColor = Color.Green;
					this.button3.BackColor = Color.Gray;
					this.button5.BackColor = Color.Gray;
					this.button6.BackColor = Color.Gray;
					MessageBox.Show("Alternativa correta!");
					button3.Enabled = false;
					button4.Enabled = false;
					button5.Enabled = false;
					button6.Enabled = false;
					}
				
				else{
				    this.button4.BackColor = Color.Red;
				    this.button3.BackColor = Color.Gray;
					this.button5.BackColor = Color.Gray;
					this.button6.BackColor = Color.Gray;
					MessageBox.Show("Alternativa incorreta!");
					button3.Enabled = false;
					button4.Enabled = false;
					button5.Enabled = false;
					button6.Enabled = false;
				}
				cont=0;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			char altSele = button5.Text[cont];
			
			foreach(char letra in richTextBox1.Lines[n])
			{
				if(altSele == letra)
				{
					cont++;
				}
				else
				{ 
					altIn++;
				}
			}
			if(cont > 0){
					this.button5.BackColor = Color.Green;
					this.button4.BackColor = Color.Gray;
					this.button3.BackColor = Color.Gray;
					this.button6.BackColor = Color.Gray;
					MessageBox.Show("Alternativa correta!");
					button3.Enabled = false;
					button4.Enabled = false;
					button5.Enabled = false;
					button6.Enabled = false;
				}else{
				    this.button5.BackColor = Color.Red;
				    this.button4.BackColor = Color.Gray;
					this.button3.BackColor = Color.Gray;
					this.button6.BackColor = Color.Gray;
					MessageBox.Show("Alternativa incorreta!");
					button3.Enabled = false;
					button4.Enabled = false;
					button5.Enabled = false;
					button6.Enabled = false;
				}
				
				cont=0;
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			char altSele = button6.Text[cont];
			
			foreach(char letra in richTextBox1.Lines[n])
			{
				if(altSele == letra)
				{
					cont++;
				}
				else
				{ 
					altIn++;
				}
			}
			if(cont > 0){
					this.button6.BackColor = Color.Green;
					this.button4.BackColor = Color.Gray;
					this.button5.BackColor = Color.Gray;
					this.button3.BackColor = Color.Gray;
					MessageBox.Show("Alternativa correta!");
					button3.Enabled = false;
					button4.Enabled = false;
					button5.Enabled = false;
					button6.Enabled = false;
				}else{
				    this.button6.BackColor = Color.Red;
				    this.button4.BackColor = Color.Gray;
					this.button5.BackColor = Color.Gray;
					this.button3.BackColor = Color.Gray;
					MessageBox.Show("Alternativa incorreta!");
					button3.Enabled = false;
					button4.Enabled = false;
					button5.Enabled = false;
					button6.Enabled = false;
				}
				
				cont=0;
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
	}
}
