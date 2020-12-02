/*
 * Criado por SharpDevelop.
 * Usuário: Gabriel Oliveira
 * Data: 25/11/2020
 * Hora: 12:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUIZ
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			
			InitializeComponent();
			label2.Select();
			
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			label1.Visible = true;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form2 OutroForm =  new Form2();
			OutroForm.ShowDialog();
		}
		
		void Button1(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			label1.Visible = false;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form3 OutroForm =  new Form3();
			OutroForm.ShowDialog();
		}
	}
}
