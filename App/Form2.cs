using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form2 : Form
    {
        DB db = new DB();
        List<area> lu = new List<area>();
        Form1 f2;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var l = lu.Where(c => c.nv1 == logintextBox.Text).ToList();

            if (l.Count == 0)
            {
                MessageBox.Show("O informado login não existe!");
            }

            if (l.Count > 1)
            {
                MessageBox.Show("Existe logins duplicados contacte o suporte!");
            }
            if (l.Count == 1)
            {

                if (l[0].nv2 == senhatextBox2.Text)
                {
                    var p = l[0].int1;
                   f2 = new Form1(l[0].nv1, l[0].mv3, l[0].nv2);
                    this.ShowInTaskbar = false;
                    this.Visible = false;
                    this.Close();
                   
                 


                }
                else
                {

                    MessageBox.Show("Senha incorreta!");

                }









            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lu = db.area.ToList();

          



           










        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f2.ShowDialog();
        }
    }
}
