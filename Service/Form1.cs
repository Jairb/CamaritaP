using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class Form1 : Form
    {
        public static int op1 = 0;
        public static bool second_service = false;

        //comentario
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StatusLabel1.Text = @"localhost\SQLExpress";
            StatusLabel1.Visible = true;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        //Nueva Area op1 = 1
        private void option_NewArea_Click(object sender, EventArgs e)
        {
            op1 = 1;

            //Titulo de la ventana
            this.Text = "Nueva Área";

            //TabControl
            tabForm1.Visible = true;
            tabForm1.TabPages.Remove(tabPage1);
            tabForm1.TabPages.Remove(tabPage2);
            tabForm1.TabPages.Add(tabPage1);

            //TextBox
            textBox1.Text = null;
            textBox1.Visible = true;
            textBox1.Size = new System.Drawing.Size(500, 20);
            textBox2.Visible = false;
            textBox2.Text = null;
            textBox3.Visible = false;
            textBox3.Text = null;
            textBox4.Visible = false;
            textBox4.Text = null;

            //Labels
            label1.Visible = true;
            label1.Text = "Nombre del Área";
            label1.Location = new System.Drawing.Point(230, 56);
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            //Botones
            button_ac1.Visible = true;
            button_can1.Visible = true;

        }

        //Nuevo Servicio op1 = 2
        private void option_NewService_Click(object sender, EventArgs e)
        {
            op1 = 2;

            //Titulo de la ventana
            this.Text = "Nuevo Servicio";

            //Tabcontrol
            tabForm1.Visible = true;
            tabForm1.TabPages.Remove(tabPage1);
            tabForm1.TabPages.Remove(tabPage2);
            tabForm1.TabPages.Add(tabPage1);

            //TextBox
            textBox1.Visible = true;
            textBox1.Size = new System.Drawing.Size(500, 20);
            textBox1.Text = null;
            textBox2.Visible = false;
            textBox2.Text = null;
            textBox3.Visible = false;
            textBox3.Text = null;
            textBox4.Visible = false;
            textBox4.Text = null;

            //Labels
            label1.Visible = true;
            label1.Text = "Nombre del Servicio";
            label1.Location = new System.Drawing.Point(230, 56);
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            //Botones
            button_ac1.Visible = true;
            button_can1.Visible = true;
        }

        //Nuevo Solicitante op1 = 3
        private void option_NewSol_Click(object sender, EventArgs e)
        {
            op1 = 3;

            //Titulo de la ventana
            this.Text = "Nuevo Solicitante";

            //tab Control
            tabForm1.Visible = true;
            tabForm1.TabPages.Remove(tabPage1);
            tabForm1.TabPages.Remove(tabPage2);
            tabForm1.TabPages.Add(tabPage1);


            //Formulario Solicitante
            //TextBox
            textBox1.Visible = true;
            textBox1.Size = new System.Drawing.Size(68, 20);
            textBox1.Text = null;
            textBox2.Visible = true;
            textBox2.Text = null;
            textBox3.Visible = true;
            textBox3.Text = null;
            textBox4.Visible = true;
            textBox4.Text = null;

            //Labels
            label1.Visible = true;
            label1.Text = "Título";
            label1.Location = new System.Drawing.Point(41, 56);
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            //Botones
            button_ac1.Visible = true;
            button_can1.Visible = true;
        }

        //Nuevo Reporte
        private void option_NewRep_Click(object sender, EventArgs e)
        {
            this.Text = "Nuevo Reporte";

            tabForm1.Visible = true;
            tabForm1.TabPages.Remove(tabPage1);
            tabForm1.TabPages.Remove(tabPage2);
            tabForm1.TabPages.Add(tabPage2);

            llena_comboBox1();
            llena_comboBox2();
            llena_comboBox3();
            llena_comboBox4();
        }
        
        //Boton aceptar nuevo reporte
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (second_service == false && ProceduresHelper.execSPCreateTrue("INSERT INTO REP_SERV VALUES ( " + comboBox1.SelectedValue.ToString() +
                   ", " + comboBox2.SelectedValue.ToString() + ", " + comboBox3.SelectedValue.ToString() +
                   ", '" + dateTimePicker1.Text + "')") == true)
                {
                    ProceduresHelper.execSPCreate("EXEC ALTA_DETALLE 0," + comboBox4.SelectedValue.ToString() + ", " +
                                                    textBox5.Text + ", '" + textBox6.Text + "'");

                    DialogResult result = MessageBox.Show("¿Desea agregar otro servicio a este reporte?", "Atención",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        second_service = true;
                        comboBox4.Text = "Seleccione Servicio";
                        textBox5.Text = null;
                        textBox6.Text = null;
                    }
                }
                else
                {
                    if (second_service == true)
                    {
                        ProceduresHelper.execSPCreate("EXEC ALTA_DETALLE 0," + comboBox4.SelectedValue.ToString() + ", " +
                                                    textBox5.Text + ", '" + textBox6.Text + "'");
                        DialogResult result = MessageBox.Show("¿Desea agregar otro servicio a este reporte?", "Atención", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            second_service = true;
                            comboBox4.Text = "Seleccione Servicio";
                            textBox5.Text = null;
                            textBox6.Text = null;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

        }

        //Nuevo Responsable op1 = 4
        private void option_NewResp_Click(object sender, EventArgs e)
        {
            op1 = 4;

            //Titulo de la venyana
            this.Text = "Nuevo Responsable";

            //TabControl
            tabForm1.Visible = true;
            tabForm1.TabPages.Remove(tabPage1);
            tabForm1.TabPages.Remove(tabPage2);
            tabForm1.TabPages.Add(tabPage1);

            //TextBox
            textBox1.Visible = true;
            textBox1.Size = new System.Drawing.Size(500, 20);
            textBox1.Text = null;
            textBox2.Visible = false;
            textBox2.Text = null;
            textBox3.Visible = false;
            textBox3.Text = null;
            textBox4.Visible = false;
            textBox4.Text = null;

            //Labels
            label1.Visible = true;
            label1.Text = "Nombre del Responsable";
            label1.Location = new System.Drawing.Point(230, 56);
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            //Botones
            button_ac1.Visible = true;
            button_can1.Visible = true;
        }

        //Boton Aceptar1
        private void button_ac1_Click(object sender, EventArgs e)
        {
            if (op1==1)
            {
                try
                {
                    string cap = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox1.Text);
                    ProceduresHelper.execSPCreate("EXEC ALTA_AREA '" + cap + "'");
                    Mesages.Exito();
                }
                catch(Exception ex)
                {
                    ex.ToString();
                    errorProvider1.SetError(statusStrip1,"No se pudo agregar elemento");
                }

            }
            else
            {
                if (op1 == 2)
                {
                    try
                    {
                        ProceduresHelper.execSPCreate("EXEC ALTA_SERVICIO '"+textBox1.Text+"'");
                        Mesages.Exito();
                    }
                    catch(Exception ex)
                    {
                        ex.ToString();
                        errorProvider1.SetError(statusStrip1, "No se pudo agregar elemento");
                    }
                }
                else
                {
                    if (op1 == 3)
                    {
                        try
                        {
                            ProceduresHelper.execSPCreate("EXEC ALTA_SOLICITANTE '"+textBox1.Text+"', '"+
                                textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"'");
                            Mesages.Exito();
                        }
                        catch(Exception ex)
                        {
                            ex.ToString();
                            errorProvider1.SetError(statusStrip1, "No se pudo agregar elemento");
                        }
                    }
                    else
                    {
                        if (op1 == 4)
                        {

                        }
                    }
                }
            }
        }

        //Boton Cancelar1
        private void button_can1_Click(object sender, EventArgs e)
        {

        }


        //Editar/Eliminar Area
        private void option_EditArea_Click(object sender, EventArgs e)
        {
            this.Text = "Editar Área";
        }

        //Editar/Eliminar Servicio
        private void option_EditServ_Click(object sender, EventArgs e)
        {
            this.Text = "Editar Servicio";
        }

        //Editar/Eliminar Solicitante
        private void option_EditSol_Click(object sender, EventArgs e)
        {
            this.Text = "Editar Solicitante";
        }

        //Editar/Eliminar Reporte
        private void option_EditRep_Click(object sender, EventArgs e)
        {
            this.Text = "Editar Reporte";
        }

        //Editar/Elimar Responsable
        private void option_EditResp_Click(object sender, EventArgs e)
        {
            this.Text = "Editar Responsable";
        }


        //Error provider
        public void set_ErrorProvider()
        {

        }


        //Metodos para llenar los comboBox
        public void llena_comboBox1()
        {
            DataTable dt = new DataTable();
            dt = ProceduresHelper.execSPRead("EXEC CONSULTA_CATSOL");
            comboBox1.DisplayMember = "NOMBRE";
            comboBox1.ValueMember = "ID_SOL";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Seleccione Solicitante";
        }

        public void llena_comboBox2()
        {
            DataTable dt = new DataTable();
            dt = ProceduresHelper.execSPRead("EXEC CONSULTA_AREAS");
            comboBox2.DisplayMember = "NOM_AREA";
            comboBox2.ValueMember = "ID_AREA";
            comboBox2.DataSource = dt;
            comboBox2.Text = "Seleccione Área";
        }

        public void llena_comboBox3()
        {
            DataTable dt = new DataTable();
            dt = ProceduresHelper.execSPRead("SELECT*FROM CAT_RESPON");
            comboBox3.DisplayMember = "NOM_RESP";
            comboBox3.ValueMember = "ID_RESP";
            comboBox3.DataSource = dt;
            comboBox3.Text = "Seleccione Responsable";
        }

        public void llena_comboBox4()
        {
            DataTable dt = new DataTable();
            dt = ProceduresHelper.execSPRead("SELECT*FROM CAT_SERVICIOS");
            comboBox4.DisplayMember = "NOM_SERV";
            comboBox4.ValueMember = "ID_SERV";
            comboBox4.DataSource = dt;
            comboBox4.Text = "Seleccione Servicio";
        }
        //Terminan metodos para llenar los comboBox


        //Caja de verificación por si no existen observaciones
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if(this.checkBox1.Checked == true)
            {
                textBox6.Enabled = false;
            }
           else
            {
                textBox6.Enabled = true;
            }
        }


    }
}
