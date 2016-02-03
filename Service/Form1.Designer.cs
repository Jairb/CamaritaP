namespace Service
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuPrinc = new System.Windows.Forms.MenuStrip();
            this.option_New = new System.Windows.Forms.ToolStripMenuItem();
            this.option_NewArea = new System.Windows.Forms.ToolStripMenuItem();
            this.option_NewService = new System.Windows.Forms.ToolStripMenuItem();
            this.option_NewSol = new System.Windows.Forms.ToolStripMenuItem();
            this.option_NewRep = new System.Windows.Forms.ToolStripMenuItem();
            this.option_NewResp = new System.Windows.Forms.ToolStripMenuItem();
            this.option_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.option_EditArea = new System.Windows.Forms.ToolStripMenuItem();
            this.option_EditServ = new System.Windows.Forms.ToolStripMenuItem();
            this.option_EditSol = new System.Windows.Forms.ToolStripMenuItem();
            this.option_EditRep = new System.Windows.Forms.ToolStripMenuItem();
            this.option_EditResp = new System.Windows.Forms.ToolStripMenuItem();
            this.option_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.option_SearchArea = new System.Windows.Forms.ToolStripMenuItem();
            this.option_SearchService = new System.Windows.Forms.ToolStripMenuItem();
            this.option_SearchSol = new System.Windows.Forms.ToolStripMenuItem();
            this.option_SearchRep = new System.Windows.Forms.ToolStripMenuItem();
            this.option_SearchResp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabForm1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_can1 = new System.Windows.Forms.Button();
            this.button_ac1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuPrinc.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabForm1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrinc
            // 
            this.menuPrinc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option_New,
            this.option_Edit,
            this.option_Search});
            this.menuPrinc.Location = new System.Drawing.Point(0, 0);
            this.menuPrinc.Name = "menuPrinc";
            this.menuPrinc.Size = new System.Drawing.Size(843, 24);
            this.menuPrinc.TabIndex = 0;
            this.menuPrinc.Text = "menuStrip1";
            // 
            // option_New
            // 
            this.option_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option_NewArea,
            this.option_NewService,
            this.option_NewSol,
            this.option_NewRep,
            this.option_NewResp});
            this.option_New.Name = "option_New";
            this.option_New.Size = new System.Drawing.Size(54, 20);
            this.option_New.Text = "Nuevo";
            // 
            // option_NewArea
            // 
            this.option_NewArea.Name = "option_NewArea";
            this.option_NewArea.Size = new System.Drawing.Size(140, 22);
            this.option_NewArea.Text = "Área";
            this.option_NewArea.Click += new System.EventHandler(this.option_NewArea_Click);
            // 
            // option_NewService
            // 
            this.option_NewService.Name = "option_NewService";
            this.option_NewService.Size = new System.Drawing.Size(140, 22);
            this.option_NewService.Text = "Servicio";
            this.option_NewService.Click += new System.EventHandler(this.option_NewService_Click);
            // 
            // option_NewSol
            // 
            this.option_NewSol.Name = "option_NewSol";
            this.option_NewSol.Size = new System.Drawing.Size(140, 22);
            this.option_NewSol.Text = "Solicitante";
            this.option_NewSol.Click += new System.EventHandler(this.option_NewSol_Click);
            // 
            // option_NewRep
            // 
            this.option_NewRep.Name = "option_NewRep";
            this.option_NewRep.Size = new System.Drawing.Size(140, 22);
            this.option_NewRep.Text = "Reporte";
            this.option_NewRep.Click += new System.EventHandler(this.option_NewRep_Click);
            // 
            // option_NewResp
            // 
            this.option_NewResp.Name = "option_NewResp";
            this.option_NewResp.Size = new System.Drawing.Size(140, 22);
            this.option_NewResp.Text = "Responsable";
            this.option_NewResp.Click += new System.EventHandler(this.option_NewResp_Click);
            // 
            // option_Edit
            // 
            this.option_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option_EditArea,
            this.option_EditServ,
            this.option_EditSol,
            this.option_EditRep,
            this.option_EditResp});
            this.option_Edit.Name = "option_Edit";
            this.option_Edit.Size = new System.Drawing.Size(97, 20);
            this.option_Edit.Text = "Editar/Eliminar";
            // 
            // option_EditArea
            // 
            this.option_EditArea.Name = "option_EditArea";
            this.option_EditArea.Size = new System.Drawing.Size(140, 22);
            this.option_EditArea.Text = "Área";
            this.option_EditArea.Click += new System.EventHandler(this.option_EditArea_Click);
            // 
            // option_EditServ
            // 
            this.option_EditServ.Name = "option_EditServ";
            this.option_EditServ.Size = new System.Drawing.Size(140, 22);
            this.option_EditServ.Text = "Servicio";
            this.option_EditServ.Click += new System.EventHandler(this.option_EditServ_Click);
            // 
            // option_EditSol
            // 
            this.option_EditSol.Name = "option_EditSol";
            this.option_EditSol.Size = new System.Drawing.Size(140, 22);
            this.option_EditSol.Text = "Solicitante";
            this.option_EditSol.Click += new System.EventHandler(this.option_EditSol_Click);
            // 
            // option_EditRep
            // 
            this.option_EditRep.Name = "option_EditRep";
            this.option_EditRep.Size = new System.Drawing.Size(140, 22);
            this.option_EditRep.Text = "Reporte";
            this.option_EditRep.Click += new System.EventHandler(this.option_EditRep_Click);
            // 
            // option_EditResp
            // 
            this.option_EditResp.Name = "option_EditResp";
            this.option_EditResp.Size = new System.Drawing.Size(140, 22);
            this.option_EditResp.Text = "Responsable";
            this.option_EditResp.Click += new System.EventHandler(this.option_EditResp_Click);
            // 
            // option_Search
            // 
            this.option_Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option_SearchArea,
            this.option_SearchService,
            this.option_SearchSol,
            this.option_SearchRep,
            this.option_SearchResp});
            this.option_Search.Name = "option_Search";
            this.option_Search.Size = new System.Drawing.Size(70, 20);
            this.option_Search.Text = "Consultar";
            // 
            // option_SearchArea
            // 
            this.option_SearchArea.Name = "option_SearchArea";
            this.option_SearchArea.Size = new System.Drawing.Size(140, 22);
            this.option_SearchArea.Text = "Área";
            // 
            // option_SearchService
            // 
            this.option_SearchService.Name = "option_SearchService";
            this.option_SearchService.Size = new System.Drawing.Size(140, 22);
            this.option_SearchService.Text = "Servicio";
            // 
            // option_SearchSol
            // 
            this.option_SearchSol.Name = "option_SearchSol";
            this.option_SearchSol.Size = new System.Drawing.Size(140, 22);
            this.option_SearchSol.Text = "Solicitante";
            // 
            // option_SearchRep
            // 
            this.option_SearchRep.Name = "option_SearchRep";
            this.option_SearchRep.Size = new System.Drawing.Size(140, 22);
            this.option_SearchRep.Text = "Reporte";
            // 
            // option_SearchResp
            // 
            this.option_SearchResp.Name = "option_SearchResp";
            this.option_SearchResp.Size = new System.Drawing.Size(140, 22);
            this.option_SearchResp.Text = "Responsable";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(843, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.StatusLabel1.Text = "toolStripStatusLabel1";
            this.StatusLabel1.Visible = false;
            // 
            // tabForm1
            // 
            this.tabForm1.Controls.Add(this.tabPage1);
            this.tabForm1.Controls.Add(this.tabPage2);
            this.tabForm1.Location = new System.Drawing.Point(12, 37);
            this.tabForm1.Name = "tabForm1";
            this.tabForm1.SelectedIndex = 0;
            this.tabForm1.Size = new System.Drawing.Size(819, 440);
            this.tabForm1.TabIndex = 2;
            this.tabForm1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_can1);
            this.tabPage1.Controls.Add(this.button_ac1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_can1
            // 
            this.button_can1.Location = new System.Drawing.Point(624, 374);
            this.button_can1.Name = "button_can1";
            this.button_can1.Size = new System.Drawing.Size(75, 23);
            this.button_can1.TabIndex = 9;
            this.button_can1.Text = "Cancelar";
            this.button_can1.UseVisualStyleBackColor = true;
            this.button_can1.Visible = false;
            this.button_can1.Click += new System.EventHandler(this.button_can1_Click);
            // 
            // button_ac1
            // 
            this.button_ac1.Location = new System.Drawing.Point(705, 374);
            this.button_ac1.Name = "button_ac1";
            this.button_ac1.Size = new System.Drawing.Size(75, 23);
            this.button_ac1.TabIndex = 8;
            this.button_ac1.Text = "Aceptar";
            this.button_ac1.UseVisualStyleBackColor = true;
            this.button_ac1.Visible = false;
            this.button_ac1.Click += new System.EventHandler(this.button_ac1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido Materno";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido Paterno";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre(s)";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Título";
            this.label1.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(430, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(583, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Sin observaciones";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Observaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Servicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Responsable de Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Área";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Solicitante";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(16, 203);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(766, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(415, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(367, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(16, 145);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(392, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(16, 87);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(392, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(414, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(368, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 502);
            this.Controls.Add(this.tabForm1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrinc);
            this.MainMenuStrip = this.menuPrinc;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPrinc.ResumeLayout(false);
            this.menuPrinc.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabForm1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrinc;
        private System.Windows.Forms.ToolStripMenuItem option_New;
        private System.Windows.Forms.ToolStripMenuItem option_Edit;
        private System.Windows.Forms.ToolStripMenuItem option_NewArea;
        private System.Windows.Forms.ToolStripMenuItem option_NewService;
        private System.Windows.Forms.ToolStripMenuItem option_NewSol;
        private System.Windows.Forms.ToolStripMenuItem option_NewRep;
        private System.Windows.Forms.ToolStripMenuItem option_NewResp;
        private System.Windows.Forms.ToolStripMenuItem option_Search;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem option_EditArea;
        private System.Windows.Forms.ToolStripMenuItem option_EditServ;
        private System.Windows.Forms.ToolStripMenuItem option_EditSol;
        private System.Windows.Forms.ToolStripMenuItem option_EditRep;
        private System.Windows.Forms.ToolStripMenuItem option_EditResp;
        private System.Windows.Forms.ToolStripMenuItem option_SearchArea;
        private System.Windows.Forms.ToolStripMenuItem option_SearchService;
        private System.Windows.Forms.ToolStripMenuItem option_SearchSol;
        private System.Windows.Forms.ToolStripMenuItem option_SearchRep;
        private System.Windows.Forms.ToolStripMenuItem option_SearchResp;
        private System.Windows.Forms.TabControl tabForm1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button_can1;
        private System.Windows.Forms.Button button_ac1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

