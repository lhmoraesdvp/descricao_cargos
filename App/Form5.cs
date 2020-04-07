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
namespace App
{
    public partial class Form5 : Form
    {
        List<registros> l = new List<registros>();
        DB db = new DB();
        registros r = new registros();
        registros r1 = new registros();
        Thread t;
        Thread t2;
        List<registros> re = new List<registros>();
        List<registros> rs = new List<registros>();
        int qtd = 0;
        int qtda = 0;
        int p = 0;
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void atualiza()

        {












            for (int i = 0; i < l.Count(); i++)
            {

                Thread.Sleep(150);
                r1 = l[i];
                db.registros.Remove(r1);
                db.SaveChanges();
                r = l[i];
                r.nv5 = "0";
                db.registros.Add(r);
                db.SaveChanges();
                qtda++;

            }



            MessageBox.Show("Banco de dados limpo com suceso!");
        

            button1.Invoke(new Action(() =>
            {
             

                button1.Enabled = true;

            }));
            button2.Invoke(new Action(() =>
            {
                

                button2.Enabled = true;

            }));
            button3.Invoke(new Action(() =>
            {
              

                button3.Enabled = true;

            }));
            label1.Invoke(new Action(() =>
            {
              

                label1.Text = "";

            }));
            
            t2.Abort();
            

        }
        public void atualiza1()

        {












            for (int i = 0; i < l.Count(); i++)
            {

                Thread.Sleep(150);
                r1 = l[i];
                db.registros.Remove(r1);
                db.SaveChanges();
                r = l[i];
                r.nv5 = "1";
                db.registros.Add(r);
                db.SaveChanges();
                qtda++;

            }



            MessageBox.Show("Banco de dados carregado com sucesso!");


            button1.Invoke(new Action(() =>
            {


                button1.Enabled = true;

            }));
            button2.Invoke(new Action(() =>
            {


                button2.Enabled = true;

            }));
            button3.Invoke(new Action(() =>
            {


                button3.Enabled = true;

            }));
            label1.Invoke(new Action(() =>
            {


                label1.Text = "";

            }));

            t2.Abort();


        }
        public void carrega()
        {
            while (t2.IsAlive)
            {
                label1.Invoke(new Action(() =>
                {
                    if (qtd > 0)

                    {
                        int p = qtda / (qtd / 100);
                        if (p <= 100)
                        {
                            label1.Text = "Atualizando " + p.ToString()+"%...";
                        }
                        if (p > 100)
                        {
                            label1.Text = "Encerrando , Aguarde ...";

                        }
                    }
                    else
                    {
                        label1.Text = "Registros atualizados";
                    }
                   



                }));
            }
            t.Abort();
      


        }
        private void button1_Click(object sender, EventArgs e)
        {
            l = db.registros.Where(ca => ca.nv5 == "1").ToList();
            qtd = l.Count();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            int c = 0;
            t2 = new Thread(atualiza);
            t2.Start();
            while (c == 0)
            {
                if (t2.IsAlive)
                {
                    c = 1;
                }


            }
            t = new Thread(carrega);
            t.Start();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            l = db.registros.Where(ca => ca.nv5 == "0").ToList();
            qtd = l.Count();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            int c = 0;
            t2 = new Thread(atualiza1);
            t2.Start();
            while (c == 0)
            {
                if (t2.IsAlive)
                {
                    c = 1;
                }


            }
            t = new Thread(carrega);
            t.Start();

           
        }


         








        }

      
    }


