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
using Root.Reports;

namespace App
{
    public partial class Form1 : Form
    {
        string login = "";
        string permissao = "";
        string senha = "";
        Thread ts;
        Form2 f2;
        Boolean formdesenhado = false;
        Boolean formcarregado = false;

        Thread tc;
        Thread t;
        Thread tr1;
        Thread tr2;
        int estagio = 0;
        int controlesalvar = 0;
        DB db = new DB();
        DB db1 = new DB();
        List<registros> reg = new List<registros>();
        registros registro1;
        registros registro2;

        public Form1(string login, string permissao, string senha)
        {
            InitializeComponent();
            this.login = login;
            this.senha = senha;
            this.permissao = permissao;




        }


        public void fazerlogin(string permissao)
        {

            switch (permissao)
            {
                case "1":

                    filtrosgroupBox.Invoke(new Action(() =>
                    {

                        filtrosgroupBox.Enabled = true;

                    }));


                    novoButton.Invoke(new Action(() =>
                    {


                        novoButton.Enabled = false;

                    }));

                    atualizarButton.Invoke(new Action(() =>
                    {


                        atualizarButton.Enabled = true;

                    }));

                    excluirButton.Invoke(new Action(() =>
                    {

                        excluirButton.Enabled = false;

                    }));

                    salvarButton.Invoke(new Action(() =>
                    {

                        salvarButton.Enabled = false;

                    }));

                    canceçarButton.Invoke(new Action(() =>
                    {

                        canceçarButton.Enabled = false;

                    }));

                    selecionarbutton.Invoke(new Action(() =>
                    {

                        selecionarbutton.Enabled = false;

                    }));

                    menuStrip1.Invoke(new Action(() =>
                    {

                        logoToolStripMenuItem.Enabled = false;

                    }));

                    menuStrip1.Invoke(new Action(() =>
                    {

                        usuariosToolStripMenuItem.Enabled = false;

                    }));


                    break;

                case "2":


                    filtrosgroupBox.Invoke(new Action(() =>
                    {

                        filtrosgroupBox.Enabled = true;

                    }));


                    novoButton.Invoke(new Action(() =>
                    {


                        novoButton.Enabled = true;

                    }));

                    atualizarButton.Invoke(new Action(() =>
                    {


                        atualizarButton.Enabled = true;

                    }));

                    excluirButton.Invoke(new Action(() =>
                    {

                        excluirButton.Enabled = false;

                    }));

                    salvarButton.Invoke(new Action(() =>
                    {

                        salvarButton.Enabled = false;

                    }));

                    canceçarButton.Invoke(new Action(() =>
                    {

                        canceçarButton.Enabled = false;

                    }));

                    selecionarbutton.Invoke(new Action(() =>
                    {

                        selecionarbutton.Enabled = false;

                    }));
                    menuStrip1.Invoke(new Action(() =>
                    {

                        logoToolStripMenuItem.Enabled = false;

                    }));

                    menuStrip1.Invoke(new Action(() =>
                    {

                        usuariosToolStripMenuItem.Enabled = false;

                    }));
                    break;

                case "3":


                    filtrosgroupBox.Invoke(new Action(() =>
                    {

                        filtrosgroupBox.Enabled = true;

                    }));


                    novoButton.Invoke(new Action(() =>
                    {


                        novoButton.Enabled = true;

                    }));

                    atualizarButton.Invoke(new Action(() =>
                    {


                        atualizarButton.Enabled = true;

                    }));

                    excluirButton.Invoke(new Action(() =>
                    {

                        excluirButton.Enabled = false;

                    }));

                    salvarButton.Invoke(new Action(() =>
                    {

                        salvarButton.Enabled = false;

                    }));

                    canceçarButton.Invoke(new Action(() =>
                    {

                        canceçarButton.Enabled = false;

                    }));

                    selecionarbutton.Invoke(new Action(() =>
                    {

                        selecionarbutton.Enabled = true;

                    }));
                    menuStrip1.Invoke(new Action(() =>
                    {

                        logoToolStripMenuItem.Enabled = false;

                    }));

                    menuStrip1.Invoke(new Action(() =>
                    {

                        usuariosToolStripMenuItem.Enabled = false;

                    }));
                    break;
                case "4":


                    filtrosgroupBox.Invoke(new Action(() => {

                        filtrosgroupBox.Enabled = true;

                    }));


                    novoButton.Invoke(new Action(() => {


                        novoButton.Enabled = true;

                    }));

                    atualizarButton.Invoke(new Action(() => {


                        atualizarButton.Enabled = true;

                    }));

                    excluirButton.Invoke(new Action(() => {

                        excluirButton.Enabled = false;

                    }));

                    salvarButton.Invoke(new Action(() => {

                        salvarButton.Enabled = false;

                    }));

                    canceçarButton.Invoke(new Action(() => {

                        canceçarButton.Enabled = false;

                    }));

                    selecionarbutton.Invoke(new Action(() => {

                        selecionarbutton.Enabled = true;

                    }));
                    menuStrip1.Invoke(new Action(() => {

                        logoToolStripMenuItem.Enabled = true;

                    }));

                    menuStrip1.Invoke(new Action(() => {

                        usuariosToolStripMenuItem.Enabled = true;

                    }));
                    menuStrip1.Invoke(new Action(() => {

                        desenvolvedorToolStripMenuItem.Enabled = true;

                    }));
                    
                    break;




            }

        }









    

        public void controle(int controle)
        {
         
            switch (controle)
            {

                case 0:

               
                            fazerlogin(permissao);

                  





                 












                    
                            break;



                    





               


                    
                    break;
                case 1:
                    // novo
                
                    novoButton.Enabled = false;
                    atualizarButton.Enabled = false;
                    excluirButton.Enabled = false;
                    salvarButton.Enabled = true;
                    canceçarButton.Enabled = true;
                    selecionarbutton.Enabled = false;
                    filtrosgroupBox.Enabled = false;
                    liberacampos();
                    limpacampos();
                    break;
         

     

                case 3:
                    //cancelar
                switch (permissao)
                    {
                        case "1":

                            novoButton.Enabled = false;
                            atualizarButton.Enabled = true;
                            excluirButton.Enabled = false;
                            salvarButton.Enabled = false;
                            canceçarButton.Enabled = false;
                            selecionarbutton.Enabled = false;
                            filtrosgroupBox.Enabled = true;

                            break;

                        case "2":

                            novoButton.Enabled = true;
                            atualizarButton.Enabled = true;
                            excluirButton.Enabled = false;
                            salvarButton.Enabled = false;
                            canceçarButton.Enabled = false;
                            selecionarbutton.Enabled = false;
                            filtrosgroupBox.Enabled = true;

                            break;

         
                            break;

                        case "3":

                            novoButton.Enabled = true;
                            atualizarButton.Enabled = true;
                            excluirButton.Enabled = false;
                            salvarButton.Enabled = false;
                            canceçarButton.Enabled = false;
                            selecionarbutton.Enabled = true;
                            filtrosgroupBox.Enabled = true;

                            break;


                        case "4":

                            novoButton.Enabled = true;
                            atualizarButton.Enabled = true;
                            excluirButton.Enabled = false;
                            salvarButton.Enabled = false;
                            canceçarButton.Enabled = false;
                            selecionarbutton.Enabled = true;
                            filtrosgroupBox.Enabled = true;

                            break;
                    }
                 
                    bloqueiacampos();
                    if (controlesalvar == 1)
                    {

                        carregacabeçalho();

                    }
                    break;

               

                case 4:
                    //excluir



                  
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {

                        canceçarButton.Enabled = false;
                        salvarButton.Enabled = false;
                        excluirButton.Enabled = false;
                        tr2 = new Thread(excluirthread);
                        tr2.Start();



                    }
                    else
                    {
                        carregacabeçalho();
                        controlesalvar = 2;

                        areaComboBox.Text = registro2.area;


                        celulaComboBox.Text = registro2.celula;

                        unidadeComboBox.Text = registro2.unidade;

                        cargoComboBox.Text = registro2.cargo;




                    }





                    break;

                case 5:
                    //salvar
             
          
                    if (controlesalvar == 1)
                    {
                        var l1 = reg.Where(c => c.area == registro1.area).ToList();
                        var l2 = l1.Where(c => c.celula == registro1.celula).ToList();
                        var l3 = l2.Where(c => c.unidade == registro1.unidade).ToList();
                        var l4 = l3.Where(c => c.cargo == registro1.cargo).ToList();
                        
                        if (l4 .Count()>=1)
                        {
                            controlesalvar = 0;
                            MessageBox.Show("Não foi possivel salvar porque ja existe no banco de dados com area,celula,unidade e cargo informado!");
                        }
                        else
                        {
                            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                            {
                                canceçarButton.Enabled = false;
                                salvarButton.Enabled = false;
                                excluirButton.Enabled = false;

                                tr2 = new Thread(salvarthread);
                                tr2.Start();
                                carregacabeçalho();
                                bloqueiacampos();

                            }
                            else
                            {
                              
                            }



                           
                        }



                       

                       

                    }// salvar novo 
                    if (controlesalvar == 2)
                    {
                      
                        if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            canceçarButton.Enabled = false;
                            salvarButton.Enabled = false;
                            excluirButton.Enabled = false;

                            tr2 = new Thread(salvarthread);
                           tr2.Start();



                        }
                        else
                        {
                            carregacabeçalho();
                          

                            areaComboBox.Text = registro2.area;


                            celulaComboBox.Text = registro2.celula;

                            unidadeComboBox.Text = registro2.unidade;

                            cargoComboBox.Text = registro2.cargo;


                        }




                    }// salvar editar
                 
                    break;


                case 6:
                    //selecionar
                    
                    novoButton.Enabled = false;
                    atualizarButton.Enabled = false;
                    excluirButton.Enabled = true;
                    salvarButton.Enabled = true;
                    canceçarButton.Enabled = true;
                    selecionarbutton.Enabled = false;
                    filtrosgroupBox.Enabled = false;
                    liberacampos();
                    break;

            }

        }


        public void atualizacampos(registros registro)
        {
            var la = reg.ToList();
            var laa = la.Select(c => c.area).ToList();
            laa.Sort();
            laa = laa.Distinct().ToList();

            var lce = la.ToList();
            var lcee = lce.Select(c => c.celula).ToList();
            lcee.Sort();
            lcee = lcee.Distinct().ToList();

            var lu =lce.ToList();
            var luu = lu.Select(c => c.unidade).ToList();
            luu.Sort();
            luu = luu.Distinct().ToList();

         

            areaTextcomboBox.DataSource = laa;
            areaTextcomboBox.Text = registro.area;
            celulaTextcomboBox.DataSource = lcee;
            celulaTextcomboBox.Text = registro.celula;
            unidadeTextcomboBox.DataSource = luu;
            unidadeTextcomboBox.Text = registro.unidade;



            cargoTextcomboBox.Text = registro.cargo;

          

       


           


            superiortextBox.Text = registro.superior;
            descricaoSumariarichTextBox.Text = registro.descSumaria;
            responsabilidadesEspecificasrichTextBox.Text = registro.responsabilidadesEspecificas;
            responsabilidadesTodosrichTextBox.Text = registro.responsabilidadesAlemTodos;
            competenciasdesejaveisrichTextBox.Text = registro.competenciasDesejaveis;
            competenciasObrigatoriasrichTextBox.Text = registro.competenciasObrigatorias;
            experienciadesejavelrichTextBox.Text = registro.experienciaDesejavel;
            cp1.Text = registro.cp1;
            cp2.Text = registro.cp2;
            nivelobrigatoriocomboBox.Text = registro.nivelObrigatorio;
            niveldesejavelcomboBox.Text = registro.nivelDesejavel;
            areadeconhecimentodesejavelrichTextBox.Text = registro.areaConhecimentoDesejavel;
            areadeconhecimentoobrigatoriarichTextBox.Text = registro.areaConhecimentoObrigatorio;

        




        } // atualiza campos
        private void limpacampos()
        {
            cargoTextcomboBox.Invoke(new Action(() => {


                cargoTextcomboBox.Text = "";

            }));
            unidadeTextcomboBox.Invoke(new Action(() => {


                unidadeTextcomboBox.Text = "";

            }));
            celulaTextcomboBox.Invoke(new Action(() => {

                celulaTextcomboBox.Text = "";

            }));

            areaTextcomboBox.Invoke(new Action(() => {

                areaTextcomboBox.Text = "";

            }));

            superiortextBox.Invoke(new Action(() => {

                superiortextBox.Text = "";

            }));

            descricaoSumariarichTextBox.Invoke(new Action(() => {

                descricaoSumariarichTextBox.Text = "";

            }));

            responsabilidadesEspecificasrichTextBox.Invoke(new Action(() => {

                responsabilidadesEspecificasrichTextBox.Text = "";

            }));

            responsabilidadesTodosrichTextBox.Invoke(new Action(() => {

                responsabilidadesTodosrichTextBox.Text = "";

            }));
            competenciasdesejaveisrichTextBox.Invoke(new Action(() => {

                competenciasdesejaveisrichTextBox.Text = "";

            }));
            competenciasObrigatoriasrichTextBox.Invoke(new Action(() => {

                competenciasObrigatoriasrichTextBox.Text = "";

            }));
            experienciadesejavelrichTextBox.Invoke(new Action(() => {

                experienciadesejavelrichTextBox.Text = "";

            }));
            cp1.Invoke(new Action(() => {

                cp1.Text = "";

            }));
            cp2.Invoke(new Action(() => {

                cp2.Text = "";

            }));
            nivelobrigatoriocomboBox.Invoke(new Action(() => {

                nivelobrigatoriocomboBox.Text = "";

            }));

            niveldesejavelcomboBox.Invoke(new Action(() => {

                niveldesejavelcomboBox.Text = "";

            }));
            areadeconhecimentodesejavelrichTextBox.Invoke(new Action(() => {

                areadeconhecimentodesejavelrichTextBox.Text = "";

            }));

            areadeconhecimentoobrigatoriarichTextBox.Invoke(new Action(() => {

                areadeconhecimentoobrigatoriarichTextBox.Text = "";

            }));
           


        } // limpa campos

        public void atualizafiltros()
        {
            refresh();
            var larea = reg.Select(c => c.area).ToList();
            var lunidade = reg.Select(c => c.unidade).ToList();
            var lcelula = reg.Select(c => c.celula).ToList();
            var lcargo = reg.Select(c => c.cargo).ToList();
            larea.Sort();
            lunidade.Sort();
            lcelula.Sort();
            lcargo.Sort();
            areaComboBox.DataSource = larea;
            unidadeComboBox.DataSource = lunidade;
            celulaComboBox.DataSource = lcelula;
            cargoComboBox.DataSource = lcargo;

        } // atualiza filtros

        private void liberacampos()
        {

            g1groupBox.Enabled = true;
            g2groupBox.Enabled = true;
            g3groupBox.Enabled = true;
            g4groupBox.Enabled = true;
            g5groupBox.Enabled = true;

        }// libera campos

        private void bloqueiacampos()
        {
            

              
            
        
                g1groupBox.Invoke(new Action(() => {


                    g1groupBox.Enabled = false;

                }));

                g2groupBox.Invoke(new Action(() => {


                    g2groupBox.Enabled = false;

                }));

                g3groupBox.Invoke(new Action(() => {

                    g3groupBox.Enabled = false;

                }));

                g4groupBox.Invoke(new Action(() => {

                    g4groupBox.Enabled = false;

                }));


                g5groupBox.Invoke(new Action(() => {

                    g5groupBox.Enabled = false;

                }));


            

        }//bloqueia campos

  
        public Form1()
        {
         

            InitializeComponent();


       

        }
        private void loading()
        {
            tabControl1.Invoke(new Action(() => {


                tabControl1.Visible = false;

            }));
               carregamento.Invoke(new Action(() => {


                carregamento.Visible = true;

            }));



            if (tabControl1.Visible == false  ){

                Thread.Sleep(700);



                carregamento.Invoke(new Action(() => {


                    carregamento.Visible = false;

                }));

                tabControl1.Invoke(new Action(() => {


                    tabControl1.Visible = true;

                }));

                t.Abort();
            }


        }
        private void loadingsave2()
        {
          

            tabControl1.Invoke(new Action(() => {


              tabControl1.Visible = false;

            }));

         filtrosgroupBox.Invoke(new Action(() => {


             filtrosgroupBox.Enabled = false;

            }));


            carregamento.Invoke(new Action(() => {


                carregamento.Visible = true;

            }));





            if (tabControl1.Visible == false )
            {

                while (!tr2.IsAlive)
                {


                }



                    while (tr2.IsAlive)
                {
                 

                }

                filtrosgroupBox.Invoke(new Action(() => {


                    filtrosgroupBox.Enabled = true; ;

                }));


                carregamento.Invoke(new Action(() => {


                    carregamento.Visible = false;

                }));


                tabControl1.Invoke(new Action(() => {


                    tabControl1.Visible = true;

                }));
                if (controlesalvar != 3)
                {

                    if (controlesalvar == 100)
                    {
                        MessageBox.Show("Dados Atualizados!");
                        tr1.Abort();
                        controlesalvar = 0;

                    }
                    else
                    {
                        MessageBox.Show("Registro salvo com sucesso!");
                        tr1.Abort();
                        controlesalvar = 0;

                    }
                   

                 

                }
                else
                  
                {
                    MessageBox.Show("Registro Excluido com sucesso!");
                    controlesalvar = 0;
                    tr1.Abort();

                }
               
            }



        }
        
        private void salvarthread()
        {
          
 

            int i = 0;

            while (i == 0)
            {
               tr1 = new Thread(loadingsave2);
                tr1.Start();
                Thread.Sleep(500);
                i = 1;

            }
            if (i == 1)
            {
              
      
                if (controlesalvar == 2)
                {

                    db.registros.Remove(registro2);
                    db.registros.Add(registro1);
                    db.SaveChanges();



                    controlesalvar = 0;
                    refresh();

                    var lareb = reg.Select(c => c.area).ToList();
                    lareb.Sort();
                    lareb = lareb.Distinct().ToList();


                    areaComboBox.Invoke(new Action(() => {

                        areaComboBox.DataSource = lareb;
                        areaComboBox.Text = registro1.area;



                    }));


                    celulaComboBox.Invoke(new Action(() => {

                        celulaComboBox.Text = registro1.celula;



                    }));

                    unidadeComboBox.Invoke(new Action(() => {

                        unidadeComboBox.Text = registro1.unidade;



                    }));
                    cargoComboBox.Invoke(new Action(() => {

                        cargoComboBox.Text = registro1.cargo;



                    }));
                    switch (permissao)
                    {

                        case "1":

                            novoButton.Invoke(new Action(() => {

                                novoButton.Enabled = false;



                            }));
                            atualizarButton.Invoke(new Action(() => {

                                atualizarButton.Enabled = true;



                            }));

                            excluirButton.Invoke(new Action(() => {

                                excluirButton.Enabled = false;



                            }));

                            salvarButton.Invoke(new Action(() => {

                                salvarButton.Enabled = false;



                            }));
                            canceçarButton.Invoke(new Action(() => {

                                canceçarButton.Enabled = false;



                            }));
                            selecionarbutton.Invoke(new Action(() => {

                                selecionarbutton.Enabled = false;



                            }));

                            filtrosgroupBox.Invoke(new Action(() => {

                                filtrosgroupBox.Enabled = true;



                            }));


                            break;


                        case "2":







                            novoButton.Invoke(new Action(() => {

                                novoButton.Enabled = true;



                            }));
                            atualizarButton.Invoke(new Action(() => {

                                atualizarButton.Enabled = true;



                            }));

                            excluirButton.Invoke(new Action(() => {

                                excluirButton.Enabled = false;



                            }));

                            salvarButton.Invoke(new Action(() => {

                                salvarButton.Enabled = false;



                            }));
                            canceçarButton.Invoke(new Action(() => {

                                canceçarButton.Enabled = false;



                            }));
                            selecionarbutton.Invoke(new Action(() => {

                                selecionarbutton.Enabled = false;



                            }));

                            filtrosgroupBox.Invoke(new Action(() => {

                                filtrosgroupBox.Enabled = true;



                            }));




                            break;
                        case "3":

                            novoButton.Invoke(new Action(() => {

                                novoButton.Enabled = true;



                            }));
                            atualizarButton.Invoke(new Action(() => {

                                atualizarButton.Enabled = true;



                            }));

                            excluirButton.Invoke(new Action(() => {

                                excluirButton.Enabled = false;



                            }));

                            salvarButton.Invoke(new Action(() => {

                                salvarButton.Enabled = false;



                            }));
                            canceçarButton.Invoke(new Action(() => {

                                canceçarButton.Enabled = false;



                            }));
                            selecionarbutton.Invoke(new Action(() => {

                                selecionarbutton.Enabled = true;



                            }));

                            filtrosgroupBox.Invoke(new Action(() => {

                                filtrosgroupBox.Enabled = true;



                            }));



                            break;
                        case "4":

                            novoButton.Invoke(new Action(() => {

                                novoButton.Enabled = true;



                            }));
                            atualizarButton.Invoke(new Action(() => {

                                atualizarButton.Enabled = true;



                            }));

                            excluirButton.Invoke(new Action(() => {

                                excluirButton.Enabled = false;



                            }));

                            salvarButton.Invoke(new Action(() => {

                                salvarButton.Enabled = false;



                            }));
                            canceçarButton.Invoke(new Action(() => {

                                canceçarButton.Enabled = false;



                            }));
                          



                            break;

                    }

                    tr2.Abort();

                }

            
            else
            {
                    


                        db1.registros.Add(registro1);
                        db1.SaveChanges();



                        controlesalvar = 0;
                        refresh();

                



                    var lareb = reg.Select(c => c.area).ToList();
                        lareb.Sort();
                        lareb = lareb.Distinct().ToList();


                    areaComboBox.Invoke(new Action(() => {

                        areaComboBox.DataSource = lareb;
                        areaComboBox.Text = registro1.area;



                    }));


                    celulaComboBox.Invoke(new Action(() => {

                        celulaComboBox.Text = registro1.celula;



                    }));

                    unidadeComboBox.Invoke(new Action(() => {

                        unidadeComboBox.Text = registro1.unidade;



                    }));
                    cargoComboBox.Invoke(new Action(() => {

                        cargoComboBox.Text = registro1.cargo;



                    }));


                    switch (permissao)
                    {

                        case "1":

                            novoButton.Invoke(new Action(() => {

                                novoButton.Enabled = false;



                            }));
                            atualizarButton.Invoke(new Action(() => {

                                atualizarButton.Enabled = true;



                            }));

                            excluirButton.Invoke(new Action(() => {

                                excluirButton.Enabled = false;



                            }));

                            salvarButton.Invoke(new Action(() => {

                                salvarButton.Enabled = false;



                            }));
                            canceçarButton.Invoke(new Action(() => {

                                canceçarButton.Enabled = false;



                            }));
                            selecionarbutton.Invoke(new Action(() => {

                                selecionarbutton.Enabled = false;



                            }));

                            filtrosgroupBox.Invoke(new Action(() => {

                                filtrosgroupBox.Enabled = true;



                            }));


                            break;


                        case "2":







                            novoButton.Invoke(new Action(() => {

                                novoButton.Enabled = true;



                            }));
                            atualizarButton.Invoke(new Action(() => {

                                atualizarButton.Enabled = true;



                            }));

                            excluirButton.Invoke(new Action(() => {

                                excluirButton.Enabled = false;



                            }));

                            salvarButton.Invoke(new Action(() => {

                                salvarButton.Enabled = false;



                            }));
                            canceçarButton.Invoke(new Action(() => {

                                canceçarButton.Enabled = false;



                            }));
                            selecionarbutton.Invoke(new Action(() => {

                                selecionarbutton.Enabled = false;



                            }));

                            filtrosgroupBox.Invoke(new Action(() => {

                                filtrosgroupBox.Enabled = true;



                            }));




                            break;
                        case "3":

                            novoButton.Invoke(new Action(() => {

                                novoButton.Enabled = true;



                            }));
                            atualizarButton.Invoke(new Action(() => {

                                atualizarButton.Enabled = true;



                            }));

                            excluirButton.Invoke(new Action(() => {

                                excluirButton.Enabled = false;



                            }));

                            salvarButton.Invoke(new Action(() => {

                                salvarButton.Enabled = false;



                            }));
                            canceçarButton.Invoke(new Action(() => {

                                canceçarButton.Enabled = false;



                            }));
                            selecionarbutton.Invoke(new Action(() => {

                                selecionarbutton.Enabled = true;



                            }));

                            filtrosgroupBox.Invoke(new Action(() => {

                                filtrosgroupBox.Enabled = true;



                            }));



                            break;


                    }



                    tr2.Abort();
                    
                }


            }





        }



        public void atualizar()
        {
            tr1 = new Thread(loadingsave2);
            tr1.Start();
            Thread.Sleep(500);
            db = new DB();
            reg = db.registros.Where(c => c.nv5 == "1").ToList();

            refresh();

            controlesalvar = 100;



            var lareb = reg.Select(c => c.area).ToList();
            lareb.Sort();
            lareb = lareb.Distinct().ToList();
            if (reg.Count() > 0)
            {
                areaComboBox.Invoke(new Action(() => {

                    areaComboBox.DataSource = lareb;
                    areaComboBox.Text = registro1.area;



                }));


                celulaComboBox.Invoke(new Action(() => {

                    celulaComboBox.Text = registro1.celula;



                }));

                unidadeComboBox.Invoke(new Action(() => {

                    unidadeComboBox.Text = registro1.unidade;



                }));
                cargoComboBox.Invoke(new Action(() => {

                    cargoComboBox.Text = registro1.cargo;



                }));

            }
            else
            {
                limpacampos();

                areaComboBox.Invoke(new Action(() => {

                    areaComboBox.DataSource = lareb;
                    areaComboBox.Text = "";



                }));


                celulaComboBox.Invoke(new Action(() => {
                    celulaComboBox.DataSource = lareb;

                    celulaComboBox.Text = "";



                }));

                unidadeComboBox.Invoke(new Action(() => {
                    unidadeComboBox.DataSource = lareb;
                    unidadeComboBox.Text ="";



                }));
                cargoComboBox.Invoke(new Action(() => {
                    cargoComboBox.DataSource = lareb;
                    cargoComboBox.Text = "";



                }));


            }
        

         
            tr2.Abort();

        }

        private void excluirthread()
        {

            tr1 = new Thread(loadingsave2);
            tr1.Start();


            db.registros.Remove(registro2);
            db.SaveChanges();


          

            refresh();
            var larea = reg.Select(c => c.area).ToList();
            larea.Sort();
            larea = larea.Distinct().ToList();

            areaComboBox.Invoke(new Action(() => {

                areaComboBox.DataSource = larea;



            }));

     
            bloqueiacampos();
            novoButton.Invoke(new Action(() => {

                novoButton.Enabled = true;


            }));

            atualizarButton.Invoke(new Action(() => {

                atualizarButton.Enabled = true;


            }));
            excluirButton.Invoke(new Action(() => {

                excluirButton.Enabled = false;

            }));

            salvarButton.Invoke(new Action(() => {

                salvarButton.Enabled = false;

            }));

            canceçarButton.Invoke(new Action(() => {

                canceçarButton.Enabled = false;

            }));
            selecionarbutton.Invoke(new Action(() => {

                selecionarbutton.Enabled = true;

            }));
            filtrosgroupBox.Invoke(new Action(() => {

                filtrosgroupBox.Enabled = true;

            }));
       




            tr2.Abort();


        }

        private void refresh()
        {
            reg = db.registros.Where(c=>c.nv5=="1").ToList();
           
        }// atualiza dados

        private void Form1_Load(object sender, EventArgs e)

        {
            nomeDoUsuarioToolStripMenuItem.Text = login;

           


          cargo c = db.cargo.SingleOrDefault();
            if (c != null)
            {
                var s1 = c.nv2;
                
               
                if (File.Exists(s1))
                {
                    logopictureBox.Image = System.Drawing.Image.FromFile(s1);
                  
                }

            }
          
           
            ts = new Thread(splash);
            ts.Start();
          

            tc = new Thread(inicio);
            tc.Start();
          

            if (formcarregado == true)
            {
                while (tc.IsAlive)
                {


                    if (!tc.IsAlive)
                        
                    {
                        carregamento.Visible = false;
                    }

                }
                carregamento.Visible = false;

            }

           

      
         


       

         

           

        }

        private void splash()
        {


            carregamento.Invoke(new Action(() => {

                carregamento.Visible = true;

            }));

       

            imprimirButton.Invoke(new Action(() => {

                imprimirButton.Visible = false;

            }));


            while (!formcarregado)
            {

            }

            if (formcarregado == true)
            {
                while (tc.IsAlive)
                {


                    if (!tc.IsAlive)

                    {
                        carregamento.Invoke(new Action(() => {

                            carregamento.Visible = false;

                        }));



                        imprimirButton.Invoke(new Action(() => {

                            imprimirButton.Visible = true;

                        }));
                    }

                }
                carregamento.Invoke(new Action(() => {

                    carregamento.Visible = false;

                }));

          
         

                imprimirButton.Invoke(new Action(() => {

                    imprimirButton.Visible = true;

                }));

            }

     

            ts.Abort();


        }

        private void inicio()
        {


            reg = db.registros.Where(c=>c.nv5=="1").ToList();

            controle(0);

            var larea = reg.Select(c => c.area).ToList();

            for (int i = 0; i < larea.Count(); i++)
            {
                if (larea[i] == null || larea[i] == "")
                {
                    larea.Remove(larea[i]);
                }

            }// remove valores nulos
            larea = larea.Distinct().ToList();
            larea.Sort();

            areaComboBox.Invoke(new Action(() => {

                areaComboBox.DataSource = larea;

            }));

            tabControl1.Invoke(new Action(() => {

                tabControl1.Visible = true;

            }));


            tc.Abort();
           

        }


        private void novoButton_Click(object sender, EventArgs e)
        {
            controle(1);
            controlesalvar = 1;
        }// botao novo 

    

        private void canceçarButton_Click(object sender, EventArgs e)
        {
            controle(3);
        }// botao cancelar

        private void excluirButton_Click(object sender, EventArgs e)
        {
            var l1 = reg.Where(c => c.area == areaComboBox.Text).ToList();
            var l2 = l1.Where(c => c.celula == celulaComboBox.Text).ToList();
            var l3 = l2.Where(c => c.unidade == unidadeComboBox.Text).ToList();
            var l4 = l3.Where(c => c.cargo == cargoComboBox.Text).ToList();
            registro2 = l3.Where(c => c.cargo == cargoComboBox.Text).SingleOrDefault();
            controlesalvar = 3;
            controle(4);


          



        }//botao excluir

        private void salvarButton_Click(object sender, EventArgs e)
        {
            registro1 = new registros(areaTextcomboBox.Text, celulaTextcomboBox.Text, unidadeTextcomboBox.Text, cargoTextcomboBox.Text, superiortextBox.Text,
            descricaoSumariarichTextBox.Text, responsabilidadesEspecificasrichTextBox.Text, responsabilidadesTodosrichTextBox.Text, competenciasObrigatoriasrichTextBox.Text,
            competenciasdesejaveisrichTextBox.Text, experienciadesejavelrichTextBox.Text, cp1.Text, cp2.Text, niveldesejavelcomboBox.Text, niveldesejavelcomboBox.Text, areadeconhecimentodesejavelrichTextBox.Text, areadeconhecimentoobrigatoriarichTextBox.Text);

            var l1 = reg.Where(c => c.area == areaComboBox.Text).ToList();
            var l2 = l1.Where(c => c.celula == celulaComboBox.Text).ToList();
            var l3 = l2.Where(c => c.unidade == unidadeComboBox.Text).ToList();
            var l4 = l3.Where(c => c.cargo == cargoComboBox.Text).ToList();
            registro2 = l3.Where(c => c.cargo == cargoComboBox.Text).SingleOrDefault();

          
                controle(5);


           




         
        }//botao salvar

        private void selecionarbutton_Click(object sender, EventArgs e)
        {
            controlesalvar = 2;
            controle(6);
        }//botao selecionar

        private void areaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            var lcelula = reg.Where(c => c.area == areaComboBox.Text).Select(c=>c.celula).ToList();
            lcelula.Sort();
            lcelula = lcelula.Distinct().ToList();
            celulaComboBox.DataSource = lcelula;



        } //alteração combobox area

        private void celulaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var l1 = reg.Where(c => c.area == areaComboBox.Text).ToList();
            var l2 = l1.Where(c => c.celula == celulaComboBox.Text).ToList();
            

            var lunidade = l2.Select(c=>c.unidade).ToList();
            lunidade.Sort();
            lunidade = lunidade.Distinct().ToList();
            unidadeComboBox.DataSource = lunidade;

        } // alteração combbobox celula

        private void unidadeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var l1 = reg.Where(c => c.area == areaComboBox.Text).ToList();
            var l2 = l1.Where(c => c.celula == celulaComboBox.Text).ToList();
            var l3 = l2.Where(c => c.unidade == unidadeComboBox.Text).ToList();



            var lcargo = l3.Select(c=>c.cargo).ToList();
            lcargo.Sort();
            lcargo = lcargo.Distinct().ToList();
            cargoComboBox.DataSource = lcargo;



            //----


           





        }// alteração combobox unidade
        private void carregacabeçalho()
        {
          
            var l1 = reg.Where(c => c.area == areaComboBox.Text).ToList();
            var l2 = l1.Where(c => c.celula == celulaComboBox.Text).ToList();
            var l3 = l2.Where(c => c.unidade == unidadeComboBox.Text).ToList();

            var l4 = l3.Where(c => c.cargo == cargoComboBox.Text).ToList();
            
            if (l4.Count()==1)

                
            {
                var l44 = l4[0];
                atualizacampos(l44);
            }

            if (l4.Count() == 0)

            {
                MessageBox.Show("O cargo nao exite mais no banco de dados selecione outro!");
            }
            if (l4.Count() >1)

            {
                MessageBox.Show("O cargo esta duplicado no banco de dados,o ajuste sera feito automaticamente...");
             



            }





        }// alteração dos campos
        private void cargoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregacabeçalho();

        }// alteração combobox cargo

        private void cargoComboBox_DataSourceChanged(object sender, EventArgs e)
        {
      
        }

        private void cargoComboBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregacabeçalho();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            formcarregado = true;
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            registro1 = new registros(areaTextcomboBox.Text, celulaTextcomboBox.Text, unidadeTextcomboBox.Text, cargoTextcomboBox.Text, superiortextBox.Text,
          descricaoSumariarichTextBox.Text, responsabilidadesEspecificasrichTextBox.Text, responsabilidadesTodosrichTextBox.Text, competenciasObrigatoriasrichTextBox.Text,
          competenciasdesejaveisrichTextBox.Text, experienciadesejavelrichTextBox.Text, cp1.Text, cp2.Text, niveldesejavelcomboBox.Text, niveldesejavelcomboBox.Text, areadeconhecimentodesejavelrichTextBox.Text, areadeconhecimentoobrigatoriarichTextBox.Text);

            var l1 = reg.Where(c => c.area == areaComboBox.Text).ToList();
            var l2 = l1.Where(c => c.celula == celulaComboBox.Text).ToList();
            var l3 = l2.Where(c => c.unidade == unidadeComboBox.Text).ToList();
            var l4 = l3.Where(c => c.cargo == cargoComboBox.Text).ToList();
            registro2 = l3.Where(c => c.cargo == cargoComboBox.Text).SingleOrDefault();

            tr2 = new Thread(atualizar);
            tr2.Start();
        }

        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int u = 0;
             string s="";
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                s = fileToOpen;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                u = 1;
            }
          if(u==1)  {
                DB d = new DB();
                var l = d.cargo.ToList();
                cargo car = new cargo();


                // var ca = @"C:\res\" + FD.SafeFileName;


                if (l.Count() < 1)
                {
                    File.Copy(s, @"res\" + 1.ToString() + FD.SafeFileName); ;
                    var s1 = @"res\" + 1.ToString() + FD.SafeFileName;

                    car.nv1 = "Caminho do logo";
                    car.nv2 = s1.ToString();
                    car.int1 = 1;
                    d.cargo.Add(car);
                    d.SaveChanges();
                    logopictureBox.Image = System.Drawing.Image.FromFile(s1);


                }
                else
                {

                    File.Copy(s, @"res\" + (l[0].int1 + 1).ToString() + FD.SafeFileName); ;
                    var s1 = @"res\" + (l[0].int1 + 1) + FD.SafeFileName;
                    car.int1 = l[0].int1 + 1;
                    cargo c1 = d.cargo.SingleOrDefault();
                    d.cargo.Remove(c1);
                    d.SaveChanges();

                    car.nv1 = "Caminho do logo";
                    car.nv2 = s1.ToString();

                    d.cargo.Add(car);
                    d.SaveChanges();
                    logopictureBox.Image = System.Drawing.Image.FromFile(s1);

                }




            }












        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adcionarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void selecionarbutton_Click_1(object sender, EventArgs e)
        {
            controlesalvar = 2;
            controle(6);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(login,senha,permissao);
            f4.ShowDialog();
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"pdf\Relatorio1.pdf"))
            {
                File.Delete(@"templates/Relatorio1.html");
                File.Copy(@"templates/Relatorio.html", @"templates/Relatorio1.html");
            }
            else
            {
                File.Copy(@"templates/Relatorio.html", @"templates/Relatorio1.html");

            }

            var l1 = reg.Where(c => c.area == areaComboBox.Text).ToList();
            var l2 = l1.Where(c => c.celula == celulaComboBox.Text).ToList();
            var l3 = l2.Where(c => c.unidade == unidadeComboBox.Text).ToList();
            var l4 = l3.Where(c => c.cargo == cargoComboBox.Text).ToList();
            registro2 = l3.Where(c => c.cargo == cargoComboBox.Text).SingleOrDefault();


     




            string arquivo = @"templates/Relatorio1.html";
         
            StreamReader sr = new StreamReader(arquivo);
            StringBuilder sb = new StringBuilder();

            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();

                if (s.IndexOf("strcargo") > -1)
                {
                    s = s.Replace("strcargo", registro2.cargo);

                }

                if (s.IndexOf("strarea") > -1)
                {
                    s = s.Replace("strarea", registro2.area);

                }

                if (s.IndexOf("strcelula") > -1)
                {
                    s = s.Replace("strcelula", registro2.celula);

                }

                if (s.IndexOf("strunidade") > -1)
                {
                    s = s.Replace("strunidade", registro2.unidade);

                }
                if (s.IndexOf("strcargo") > -1)
                {
                    s = s.Replace("strcargo", registro2.cargo);

                }

                if (s.IndexOf("strlider") > -1)
                {
                    s = s.Replace("strlider", registro2.superior);

                }
                if (s.IndexOf("strdescsum") > -1)
                {
                    s = s.Replace("strdescsum", registro2.descSumaria);

                }

                if (s.IndexOf("strrespp") > -1)
                {
                    s = s.Replace("strrespp", registro2.responsabilidadesEspecificas);

                }
                if (s.IndexOf("strcompc") > -1)
                {
                    s = s.Replace("strcompc", registro2.competenciasObrigatorias);

                }

                if (s.IndexOf("strcompt") > -1)
                {
                    s = s.Replace("strcompt", registro2.competenciasDesejaveis);

                }
                if (s.IndexOf("streduc") > -1)
                {
                    s = s.Replace("streduc", registro2.nivelObrigatorio + ", " + registro2.areaConhecimentoObrigatorio);

                }



                sb.AppendLine(s);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(arquivo);
            sw.Write(sb);

            sw.Close();
            int cont = 1;
            

            while (File.Exists(@"pdf\Relatorio"+cont.ToString()+".pdf"))
            {
               cont++;

            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"wkhtmltopdf.exe";
            startInfo.Arguments = @"templates/Relatorio1.html"+ " " + @"pdf\Relatorio" + cont.ToString() + ".pdf";
            Process.Start(startInfo);
            while (!File.Exists(@"pdf\Relatorio" + cont.ToString() + ".pdf"))
            {
                

            }

            Process.Start(@"pdf\Relatorio" + cont.ToString() + ".pdf");

        }

         

        }



      
        }
    


