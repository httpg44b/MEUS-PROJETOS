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
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			richTextBox1.Enabled = true;
			richTextBox1.Text += textBox1.Text +"|"+ textBox2.Text +"|"+ textBox3.Text +"|"+ textBox4.Text +"|"+ textBox5.Text +"\n";
			richTextBox1.SaveFile("QUIZ.txt", RichTextBoxStreamType.PlainText);
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox1.Select();
		}
		
		void Form3Load(object sender, EventArgs e)
		{
			richTextBox1.Enabled = false;
			richTextBox1.LoadFile("QUIZ.txt", RichTextBoxStreamType.PlainText);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.SaveFile("QUIZ.txt", RichTextBoxStreamType.PlainText);
			richTextBox1.Enabled = false;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			try{
			int nLinha = int.Parse(textBox6.Text);
			string linha = richTextBox1.Lines[nLinha];
			string[] info = linha.Split('|');
			 
			textBox1.Text = info[0];
			textBox2.Text = info[1];
			textBox3.Text = info[2];
			textBox4.Text = info[3];
			textBox5.Text = info[4];
			}
			catch{
				MessageBox.Show("LINHA NÃO ENCONTRADA");
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			int nLinha = int.Parse(textBox6.Text);
			string linha = richTextBox1.Lines[nLinha];
			
			string paraRemover = richTextBox1.Lines[nLinha]; // nLinha é o númro da linha que vc quer remover
            richTextBox1.Text = richTextBox1.Text.Replace(paraRemover,"");
		}
	}
}
