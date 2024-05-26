/*
 * Criado por SharpDevelop.
 * Usuário: Rony Marcolino
 * Data: 22/4/2010
 * Hora: 14:25
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculador_frequencia
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		Int16 horasCurso = 0;
		Int16 horasFaltas = 0;
		Int32 porcentagem = 0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
				horasCurso = Convert.ToInt16(textBox1.Text);
				horasFaltas = Convert.ToInt16(textBox2.Text);
				if (horasCurso != 0)
				{
					porcentagem = 100 * horasFaltas;
					porcentagem = porcentagem / horasCurso;
					label3.Text = "" + (-porcentagem + 100) + " %";
				}
				else
				{
					label3.Text = "Digite um valor de hora válida!";
                }
			}
			catch (Exception exp)
			{
				textBox1.Text = "0";
				textBox2.Text = "0";
                label3.Text = "Digite um valor de hora válida!";
			}
		}
	}
}
