namespace App
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.senhatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nivelcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.novogroupBox = new System.Windows.Forms.GroupBox();
            this.salvarnovobutton = new System.Windows.Forms.Button();
            this.novobutton4 = new System.Windows.Forms.Button();
            this.cancelanovorbutton = new System.Windows.Forms.Button();
            this.LoginsEcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nivelEcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.senhaEtextBox = new System.Windows.Forms.TextBox();
            this.Editargroubox = new System.Windows.Forms.GroupBox();
            this.salvareditarbutton = new System.Windows.Forms.Button();
            this.excluirbutton = new System.Windows.Forms.Button();
            this.editarbutton = new System.Windows.Forms.Button();
            this.cancelareditarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logopictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.novogroupBox.SuspendLayout();
            this.Editargroubox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sairToolStripMenuItem.Text = "Fechar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // logintextBox
            // 
            this.logintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintextBox.Location = new System.Drawing.Point(127, 28);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(323, 26);
            this.logintextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // senhatextBox
            // 
            this.senhatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatextBox.Location = new System.Drawing.Point(127, 69);
            this.senhatextBox.Name = "senhatextBox";
            this.senhatextBox.Size = new System.Drawing.Size(323, 26);
            this.senhatextBox.TabIndex = 27;
            this.senhatextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nivelcomboBox
            // 
            this.nivelcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelcomboBox.FormattingEnabled = true;
            this.nivelcomboBox.Items.AddRange(new object[] {
            "Usuário 1 (Visualizar)",
            "Usuário 2 (Visualizar e salvar novos itens)",
            "Usuário 3 (Visualizar , Editar e salvar novos itens)",
            "Administrador 4 (Todas permisões + Parametros Basicos)",
            "Administrador 5 (Todas as permisões)",
            "Selecionar"});
            this.nivelcomboBox.Location = new System.Drawing.Point(127, 110);
            this.nivelcomboBox.Name = "nivelcomboBox";
            this.nivelcomboBox.Size = new System.Drawing.Size(323, 28);
            this.nivelcomboBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nivel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // novogroupBox
            // 
            this.novogroupBox.Controls.Add(this.label3);
            this.novogroupBox.Controls.Add(this.nivelcomboBox);
            this.novogroupBox.Controls.Add(this.label2);
            this.novogroupBox.Controls.Add(this.senhatextBox);
            this.novogroupBox.Controls.Add(this.label1);
            this.novogroupBox.Controls.Add(this.logintextBox);
            this.novogroupBox.Enabled = false;
            this.novogroupBox.Location = new System.Drawing.Point(6, 110);
            this.novogroupBox.Name = "novogroupBox";
            this.novogroupBox.Size = new System.Drawing.Size(468, 198);
            this.novogroupBox.TabIndex = 26;
            this.novogroupBox.TabStop = false;
            this.novogroupBox.Text = "Novo Usuário";
            this.novogroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // salvarnovobutton
            // 
            this.salvarnovobutton.Enabled = false;
            this.salvarnovobutton.Location = new System.Drawing.Point(369, 60);
            this.salvarnovobutton.Name = "salvarnovobutton";
            this.salvarnovobutton.Size = new System.Drawing.Size(105, 35);
            this.salvarnovobutton.TabIndex = 25;
            this.salvarnovobutton.Text = "Salvar";
            this.salvarnovobutton.UseVisualStyleBackColor = true;
            this.salvarnovobutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // novobutton4
            // 
            this.novobutton4.Location = new System.Drawing.Point(147, 60);
            this.novobutton4.Name = "novobutton4";
            this.novobutton4.Size = new System.Drawing.Size(105, 35);
            this.novobutton4.TabIndex = 31;
            this.novobutton4.Text = "Novo";
            this.novobutton4.UseVisualStyleBackColor = true;
            this.novobutton4.Click += new System.EventHandler(this.novobutton4_Click);
            // 
            // cancelanovorbutton
            // 
            this.cancelanovorbutton.Enabled = false;
            this.cancelanovorbutton.Location = new System.Drawing.Point(258, 60);
            this.cancelanovorbutton.Name = "cancelanovorbutton";
            this.cancelanovorbutton.Size = new System.Drawing.Size(105, 35);
            this.cancelanovorbutton.TabIndex = 33;
            this.cancelanovorbutton.Text = "Cancelar";
            this.cancelanovorbutton.UseVisualStyleBackColor = true;
            this.cancelanovorbutton.Click += new System.EventHandler(this.cancelanovorbutton_Click);
            // 
            // LoginsEcomboBox
            // 
            this.LoginsEcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginsEcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginsEcomboBox.FormattingEnabled = true;
            this.LoginsEcomboBox.Location = new System.Drawing.Point(124, 28);
            this.LoginsEcomboBox.Name = "LoginsEcomboBox";
            this.LoginsEcomboBox.Size = new System.Drawing.Size(323, 28);
            this.LoginsEcomboBox.TabIndex = 31;
            this.LoginsEcomboBox.SelectedIndexChanged += new System.EventHandler(this.LoginsEcomboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "Login";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nivelEcomboBox
            // 
            this.nivelEcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelEcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelEcomboBox.FormattingEnabled = true;
            this.nivelEcomboBox.Items.AddRange(new object[] {
            "Usuário 1 (Visualizar)",
            "Usuário 2 (Visualizar e salvar novos itens)",
            "Usuário 3 (Visualizar , Editar e salvar novos itens)",
            "Administrador 4 (Todas permisões + Parametros Basicos)",
            "Administrador 5 (Todas as permisões)",
            "Selecionar"});
            this.nivelEcomboBox.Location = new System.Drawing.Point(124, 78);
            this.nivelEcomboBox.Name = "nivelEcomboBox";
            this.nivelEcomboBox.Size = new System.Drawing.Size(323, 28);
            this.nivelEcomboBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nivel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Senha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // senhaEtextBox
            // 
            this.senhaEtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaEtextBox.Location = new System.Drawing.Point(124, 123);
            this.senhaEtextBox.Name = "senhaEtextBox";
            this.senhaEtextBox.Size = new System.Drawing.Size(323, 26);
            this.senhaEtextBox.TabIndex = 37;
            this.senhaEtextBox.UseSystemPasswordChar = true;
            // 
            // Editargroubox
            // 
            this.Editargroubox.Controls.Add(this.senhaEtextBox);
            this.Editargroubox.Controls.Add(this.label4);
            this.Editargroubox.Controls.Add(this.label5);
            this.Editargroubox.Controls.Add(this.nivelEcomboBox);
            this.Editargroubox.Controls.Add(this.label6);
            this.Editargroubox.Controls.Add(this.LoginsEcomboBox);
            this.Editargroubox.Enabled = false;
            this.Editargroubox.Location = new System.Drawing.Point(9, 369);
            this.Editargroubox.Name = "Editargroubox";
            this.Editargroubox.Size = new System.Drawing.Size(465, 210);
            this.Editargroubox.TabIndex = 27;
            this.Editargroubox.TabStop = false;
            this.Editargroubox.Text = "Editar";
            // 
            // salvareditarbutton
            // 
            this.salvareditarbutton.Enabled = false;
            this.salvareditarbutton.Location = new System.Drawing.Point(369, 319);
            this.salvareditarbutton.Name = "salvareditarbutton";
            this.salvareditarbutton.Size = new System.Drawing.Size(105, 35);
            this.salvareditarbutton.TabIndex = 31;
            this.salvareditarbutton.Text = "Salvar";
            this.salvareditarbutton.UseVisualStyleBackColor = true;
            this.salvareditarbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // excluirbutton
            // 
            this.excluirbutton.Enabled = false;
            this.excluirbutton.Location = new System.Drawing.Point(147, 319);
            this.excluirbutton.Name = "excluirbutton";
            this.excluirbutton.Size = new System.Drawing.Size(105, 35);
            this.excluirbutton.TabIndex = 31;
            this.excluirbutton.Text = "Excluir";
            this.excluirbutton.UseVisualStyleBackColor = true;
            this.excluirbutton.Click += new System.EventHandler(this.excluirbutton_Click);
            // 
            // editarbutton
            // 
            this.editarbutton.Location = new System.Drawing.Point(36, 319);
            this.editarbutton.Name = "editarbutton";
            this.editarbutton.Size = new System.Drawing.Size(105, 35);
            this.editarbutton.TabIndex = 32;
            this.editarbutton.Text = "Editar";
            this.editarbutton.UseVisualStyleBackColor = true;
            this.editarbutton.Click += new System.EventHandler(this.editarbutton_Click);
            // 
            // cancelareditarbutton
            // 
            this.cancelareditarbutton.Enabled = false;
            this.cancelareditarbutton.Location = new System.Drawing.Point(258, 319);
            this.cancelareditarbutton.Name = "cancelareditarbutton";
            this.cancelareditarbutton.Size = new System.Drawing.Size(105, 35);
            this.cancelareditarbutton.TabIndex = 34;
            this.cancelareditarbutton.Text = "Cancelar";
            this.cancelareditarbutton.UseVisualStyleBackColor = true;
            this.cancelareditarbutton.Click += new System.EventHandler(this.cancelareditarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logopictureBox);
            this.groupBox1.Controls.Add(this.novobutton4);
            this.groupBox1.Controls.Add(this.cancelareditarbutton);
            this.groupBox1.Controls.Add(this.novogroupBox);
            this.groupBox1.Controls.Add(this.cancelanovorbutton);
            this.groupBox1.Controls.Add(this.Editargroubox);
            this.groupBox1.Controls.Add(this.editarbutton);
            this.groupBox1.Controls.Add(this.salvarnovobutton);
            this.groupBox1.Controls.Add(this.excluirbutton);
            this.groupBox1.Controls.Add(this.salvareditarbutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 544);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // logopictureBox
            // 
            this.logopictureBox.Location = new System.Drawing.Point(27, 16);
            this.logopictureBox.Name = "logopictureBox";
            this.logopictureBox.Size = new System.Drawing.Size(105, 88);
            this.logopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopictureBox.TabIndex = 35;
            this.logopictureBox.TabStop = false;
            this.logopictureBox.Click += new System.EventHandler(this.logopictureBox_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.novogroupBox.ResumeLayout(false);
            this.novogroupBox.PerformLayout();
            this.Editargroubox.ResumeLayout(false);
            this.Editargroubox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senhatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nivelcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox novogroupBox;
        private System.Windows.Forms.Button salvarnovobutton;
        private System.Windows.Forms.Button novobutton4;
        private System.Windows.Forms.Button cancelanovorbutton;
        private System.Windows.Forms.ComboBox LoginsEcomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox nivelEcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox senhaEtextBox;
        private System.Windows.Forms.GroupBox Editargroubox;
        private System.Windows.Forms.Button salvareditarbutton;
        private System.Windows.Forms.Button excluirbutton;
        private System.Windows.Forms.Button editarbutton;
        private System.Windows.Forms.Button cancelareditarbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox logopictureBox;
    }
}