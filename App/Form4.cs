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
    public partial class Form4 : Form
    {
        DB db = new DB();
        area alogin = new area();
        area uarea = new area();
        string usuario = "";
        string senha = "";
        string nivel = "";
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(string login,string senha,string nivel)
        {
          usuario = login;
            this.senha = senha;
            this.nivel = nivel;

            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loginlabel.Text = usuario;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (senhaatualtextBox.Text == senha)
            {

                if(novasenhatextBox.Text!=null&& novasenhatextBox.Text != "")
                {
                    if (novasenhatextBox.Text == confirmasenhatextBox.Text)
                    {
                        area a = db.area.Where(c => c.nv1 == usuario).SingleOrDefault();
                        if (a != null)
                        {
                            alogin.nv1 = usuario;
                            alogin.nv2 = novasenhatextBox.Text;
                            alogin.mv3 = nivel;

                            db.area.Remove(a);
                            db.area.Add(alogin);
                            db.SaveChanges();

                            MessageBox.Show("Senha alterada com sucesso!");
                            this.Close();

                        }
                        else
                        {

                            MessageBox.Show("Erro ao salvar , tente novamente!");
                        }

                    }
                    else
                    {

                        MessageBox.Show("Senha diferente da confirmação!");

                    }





                }
                else
                {



                    MessageBox.Show("Informar uma nova senha!");
                }




            }
            else
            {
                MessageBox.Show("Senha atual incorreta!");

            }
        }
    }
}
