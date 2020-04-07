using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace App
{
    public partial class Form3 : Form
    {
        DB db = new DB();
        List<area> usuarios = new List<area>();
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nivelcomboBox.Text != "Selecionar"&&logintextBox.Text!="Selecionar")
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja adcionar este rgistro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    int nivel = 0;
                    switch (nivelcomboBox.Text)
                    {

                        case "Usuário 1 (Visualizar)":
                            nivel = 1;
                            break;

                        case "Usuário 2 (Visualizar e salvar novos itens)":
                            nivel = 2;
                            break;

                        case "Usuário 3 (Visualizar , Editar e salvar novos itens)":
                            nivel = 3;
                            break;

                        case "Administrador 4 (Todas permisões + Parametros Basicos)":
                            nivel = 4;
                            break;
                        case "Administrador 5 (Todas as permisões)":
                            nivel = 5;
                            break;



                    }
                    int dup = 0;

                    area login = new area();
                    login.nv1 = logintextBox.Text;
                    login.nv2 = senhatextBox.Text;
                    login.mv3 = nivel.ToString();
                    for (int i = 0; i < usuarios.Count(); i++)
                    {

                        if (usuarios[i].nv1 == login.nv1)
                        {
                            dup = 1;
                            MessageBox.Show("Impossivel salvar. Já existe um usuário com o login informado");

                        }

                    }
                    if (dup == 0)
                    {
                        db.area.Add(login);
                        db.SaveChanges();
                        logintextBox.Text = "";
                        senhatextBox.Text = "";
                        nivelcomboBox.Text = "";
                        MessageBox.Show("Login cadastrado com sucesso");
                        usuarios = db.area.ToList();
                        var logins = usuarios.Select(c => c.nv1).ToList();
                        logins.Sort();
                        logins.Add("Selecionar");
                        LoginsEcomboBox.DataSource = logins;
                        LoginsEcomboBox.Text = "Selecionar";
                        nivelEcomboBox.Text = "Selecionar";
                        nivelcomboBox.Text = "Selecionar";
                        senhatextBox.Text = "";

                        novobutton4.Enabled = true;
                        novogroupBox.Enabled = false;
                        salvarnovobutton.Enabled = false;
                        cancelanovorbutton.Enabled = false;
                        editarbutton.Enabled = true;
                    }




                }


            }
            else
            {
                MessageBox.Show("Palavra Selecionar Reservada Para o Sistema!");

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cargo cc = db.cargo.SingleOrDefault();
            if (cc != null)
            {
                var s1 = cc.nv2;


                if (File.Exists(s1))
                {
                    logopictureBox.Image = System.Drawing.Image.FromFile(s1);

                }

            }


            usuarios = db.area.ToList();
            var logins = usuarios.Select(c => c.nv1).ToList();
            logins.Sort();
            logins.Add("Selecionar");
  
            LoginsEcomboBox.DataSource = logins;

            LoginsEcomboBox.Text = "Selecionar";





        }

        private void LoginsEcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                area a = usuarios.Where(c => c.nv1 == LoginsEcomboBox.Text).SingleOrDefault();
          
                if (a != null){
                switch (a.mv3)
                {
                    case "1":
                        nivelEcomboBox.Text = "Usuário 1 (Visualizar)";

                        break;

                    case "2":
                        nivelEcomboBox.Text = "Usuário 2 (Visualizar e salvar novos itens)";

                        break;

                    case "3":
                        nivelEcomboBox.Text = "Usuário 3 (Visualizar , Editar e salvar novos itens)";

                        break;

                    case "4":
                        nivelEcomboBox.Text = "Administrador 4 (Todas permisões + Parametros Basicos)";

                        break;

                    case "5":
                        nivelEcomboBox.Text = "Administrador 5 (Todas as permisões)";

                        break;

                      
                }

                senhaEtextBox.Text = a.nv2;
            }
            else
            {
                nivelEcomboBox.Text="Selecionar";
                if (LoginsEcomboBox.Text != "Selecionar")
                {
                    senhaEtextBox.Text = "";
                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginsEcomboBox.Text != "Selecionar"&&nivelEcomboBox.Text!="Selecionar")
            {

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja adcionar este rgistro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    int nivel = 0;
                    switch (nivelEcomboBox.Text)
                    {

                        case "Usuário 1 (Visualizar)":
                            nivel = 1;
                            break;

                        case "Usuário 2 (Visualizar e salvar novos itens)":
                            nivel = 2;
                            break;

                        case "Usuário 3 (Visualizar , Editar e salvar novos itens)":
                            nivel = 3;
                            break;

                        case "Administrador 4 (Todas permisões + Parametros Basicos)":
                            nivel = 4;
                            break;
                        case "Administrador 5 (Todas as permisões)":
                            nivel = 5;
                            break;



                    }


                    area login = new area();
                    login.nv1 = LoginsEcomboBox.Text;
                    login.nv2 = senhaEtextBox.Text;
                    login.mv3 = nivel.ToString();

                    area exc = usuarios.Where(c => c.nv1 == LoginsEcomboBox.Text).SingleOrDefault();
                    db.area.Remove(exc);
                    db.area.Add(login);
                    db.SaveChanges();
                    LoginsEcomboBox.Text = "Selecionar";
                    nivelEcomboBox.Text = "";
                    senhaEtextBox.Text = "";

                    MessageBox.Show("Login Atualizado com sucesso");




                    usuarios = db.area.ToList();
                    var logins = usuarios.Select(c => c.nv1).ToList();
                    logins.Sort();
                    logins.Add("Selecionar");
                    LoginsEcomboBox.DataSource = logins;
                    nivelEcomboBox.Text = "Selecionar";
                    LoginsEcomboBox.Text = "Selecionar";
                    editarbutton.Enabled = true;
                    salvareditarbutton.Enabled = false;
                    excluirbutton.Enabled = false;
                    cancelareditarbutton.Enabled = false;
                    novobutton4.Enabled = true;
                    Editargroubox.Enabled = false;


                }


            }
            else
            {
                MessageBox.Show("Palavra Selecionar Reservada para o Sistema!");

            }





        }

        private void novobutton4_Click(object sender, EventArgs e)
        {
            novobutton4.Enabled = false;
            novogroupBox.Enabled = true;
            salvarnovobutton.Enabled = true;
            cancelanovorbutton.Enabled = true;
            editarbutton.Enabled = false;

        }

        private void editarbutton_Click(object sender, EventArgs e)
        {
            Editargroubox.Enabled = true;
            editarbutton.Enabled = false;
            salvareditarbutton.Enabled = true;
            excluirbutton.Enabled = true;
            cancelareditarbutton.Enabled = true;
            novobutton4.Enabled = false;
    


        }

        private void cancelanovorbutton_Click(object sender, EventArgs e)
        {
            novobutton4.Enabled = true;
            novogroupBox.Enabled = false;
            salvarnovobutton.Enabled = false;
            cancelanovorbutton.Enabled = false;
            editarbutton.Enabled = true;

            LoginsEcomboBox.Text = "Selecionar";
            nivelEcomboBox.Text = "Selecionar";
            nivelcomboBox.Text = "Selecionar";
            senhatextBox.Text = "";
            logintextBox.Text = "";
        }

        private void cancelareditarbutton_Click(object sender, EventArgs e)
        {
            editarbutton.Enabled = true;
            salvareditarbutton.Enabled = false;
            excluirbutton.Enabled = false;
            cancelareditarbutton.Enabled = false;
            novobutton4.Enabled = true;
            Editargroubox.Enabled = false;

            nivelEcomboBox.Text = "Selecionar";
            LoginsEcomboBox.Text = "Selecionar";
            senhaEtextBox.Text = "";
        }

        private void logopictureBox_Click(object sender, EventArgs e)
        {

        }

        private void excluirbutton_Click(object sender, EventArgs e)
        {
            if (LoginsEcomboBox.Text != "Selecionar")
            {

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir este rgistro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    area exc = usuarios.Where(c => c.nv1 == LoginsEcomboBox.Text).SingleOrDefault();
                    db.area.Remove(exc);

                    db.SaveChanges();
                    LoginsEcomboBox.Text = "Selecionar";
                    nivelEcomboBox.Text = "Selecionar";
                    senhaEtextBox.Text = "";

                    MessageBox.Show("Login Atualizado com sucesso");




                    usuarios = db.area.ToList();
                    var logins = usuarios.Select(c => c.nv1).ToList();
                    logins.Sort();
                    logins.Add("Selecionar");
                    LoginsEcomboBox.DataSource = logins;
                    nivelEcomboBox.Text = "Selecionar";
                    LoginsEcomboBox.Text = "Selecionar";
                    editarbutton.Enabled = true;
                    salvareditarbutton.Enabled = false;
                    excluirbutton.Enabled = false;
                    cancelareditarbutton.Enabled = false;
                    novobutton4.Enabled = true;
                    Editargroubox.Enabled = false;
                }
                else
                {
                    nivelEcomboBox.Text = "Selecionar";
                    LoginsEcomboBox.Text = "Selecionar";

                }
            }
            else
            {
                MessageBox.Show("Primeiro selecione um registro");

            }
         
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
