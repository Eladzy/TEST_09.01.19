using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace winformsquestion
{
	public partial class Form1 : Form
	{
		Color typeColor = Color.Black;
		int score = 0;
		const int dly = 5000;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			
				label1.Text = rnd.Next(101).ToString();
				label2.Text = rnd.Next(101).ToString();
				label3.Text = rnd.Next(101).ToString();
				label4.Text = rnd.Next(101).ToString();
				label5.Text = rnd.Next(101).ToString();
			
				label1.Visible = true;
				label2.Visible = true;
				label3.Visible = true;
				label4.Visible = true;
				label5.Visible = true;
			new Thread(() =>
			{
				Thread.Sleep(dly);			
				label1.Visible = false;
				label2.Visible = false;
				label4.Visible = false;
				label5.Visible = false;
				label3.Visible = false;
			}).Start();


		}

		private void btnFinish_Click(object sender, EventArgs e)
		{
			int txt1, txt2, txt3, txt4,txt5;
			txt1 = int.Parse(textBox1.Text);
			txt2 = int.Parse(textBox2.Text);
			txt3 = int.Parse(textBox3.Text);
			txt4 = int.Parse(textBox4.Text);
			txt5 = int.Parse(textBox5.Text);
			if (txt1 == int.Parse(label1.Text))
				score++;
			else
				textBox1.ForeColor = Color.Red;
			if (txt2 == int.Parse(label2.Text))
				score++;
			else
				textBox2.ForeColor = Color.Red;
			if (txt3 == int.Parse(label3.Text))
				score++;
			else
				textBox3.ForeColor = Color.Red;
			if (txt4 == int.Parse(label4.Text))
				score++;
			else
				textBox4.ForeColor = Color.Red;
			if (txt5 == int.Parse(label5.Text))
				score++;
			else
				textBox5.ForeColor = Color.Red;
			MessageBox.Show($"your score is: {score}", "Score!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listBox1.Items.Add(score);
			score = 0;

		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			label1.Visible = false;
			label2.Visible = false;
			label4.Visible = false;
			label5.Visible = false;
			label3.Visible = false;
			textBox1.ForeColor = typeColor;
			textBox2.ForeColor = typeColor;
			textBox3.ForeColor = typeColor;
			textBox4.ForeColor = typeColor;
			textBox5.ForeColor = typeColor;
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			score = 0;

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
			
		}

		private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("God help me!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
