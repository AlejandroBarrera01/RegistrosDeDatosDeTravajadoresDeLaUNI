using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrosDeDatosDeTravajadoresDeLaUNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int N;
        int i = 0;
        string Security;
        string Cleaning;
        string Teacher;
        int Count = 0;
        int Count1 = 0;
        int Count2 = 0;

        // Registro De Los Datos
        public struct Information
        {
            public int ID;
            public string Name;
            public string LastName;
            public int Salary;
            public string Position;
            public string Gender;
        }
        Information[] Info;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            N = int.Parse(TextBoxIngresoTotal.Text);

            Info = new Information[N];
            TextBoxIngresoTotal.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)

        {


            if (i < N )
            {
                Info[i].ID = int.Parse(TextBoxID.Text);
                Info[i].Name = (TextBoxNombre.Text);
                Info[i].LastName = (TextBoxApellido.Text);
                Info[i].Salary = int.Parse(TextBoxSueldo.Text);
                Info[i].Position = (TextBoxPuesto.Text);
                Info[i].Gender = (TextBoxSexo.Text);
                if (Info[i].Position == "Cleaning")
                {
                    Count = Count + 1;
                }
                if (Info[i].Position == "Teacher")
                {
                    Count1 = Count1 + 1;
                }
                if (Info[i].Position == "Security")
                {
                    Count2 = Count2 + 1;
                }

                i++;
            }
            MessageBox.Show("Saved!");


            TextBoxID.Clear();
            TextBoxNombre.Clear();
            TextBoxApellido.Clear();
            TextBoxSueldo.Clear();
            TextBoxPuesto.Clear();
            TextBoxSexo.Clear();
            TextBoxID.Focus();

        } 
            
        
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Teacher = (TextBoxBuscarEmpleado.Text);
            Cleaning = (TextBoxBuscarEmpleado.Text);
            Security = (TextBoxBuscarEmpleado.Text);

            i = 0;
            Boolean bandera = false;

            TextBoxInformationDelEmpleado.Clear();

            while (i< N)
            {
                if (Info[i].Position == Teacher)
                {
                    TextBoxInformationDelEmpleado.Text = TextBoxInformationDelEmpleado.Text + "ID:   " + Info[i].ID.ToString() + "   " + "Name:  " + Info[i].Name + "   " + "LastName:   " + Info[i].LastName + " " + "Salary: " + Info[i].Salary.ToString() + " " + "Position: " + Info[i].Position.ToString() + " " + " Gender:  " + Info[i].Gender.ToString() + "\r\n";

                    bandera = true;
                    
                }
               
                i++;
            }
            if (bandera == false) MessageBox.Show("We don't have that position");
            else
               MessageBox.Show("We found your Information! ");

            
        }
        

        private void TextBoxBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            i = 0;
            while (i < N)
            {
                if (TextBoxID.Text == Info[i].ID.ToString())  
                {
                    Info[i].ID = int.Parse(TextBoxID.Text);
                    Info[i].Name = (TextBoxNombre.Text);
                    Info[i].LastName = (TextBoxApellido.Text);
                    Info[i].Salary = int.Parse(TextBoxSueldo.Text);
                    Info[i].Position = (TextBoxPuesto.Text);
                    Info[i].Gender = (TextBoxSexo.Text);
                    MessageBox.Show("It has been Modify!");
                }
                i++;
            }
        }

        private void btnTotalDeEmpleadosPorCategorias_Click(object sender, EventArgs e)
        {
            


        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            try { 
            i = 0;
            while (i < N)
            {
                if (TextBoxID.Text == Info[i].ID.ToString())
                {
                    TextBoxNombre.Text = (Info[i].Name);
                    TextBoxApellido.Text = (Info[i].LastName);
                    TextBoxSueldo.Text = (Info[i].Salary.ToString());
                    TextBoxPuesto.Text = (Info[i].Position);
                    TextBoxPuesto.Text = (Info[i].Gender);                   
                }
                i++;
            }
                 }
            catch {};
        }

        private void rbDocente_CheckedChanged(object sender, EventArgs e)
        {
            
            
            if (rbDocente.Checked == true)
            {
                TextBoxResultadoDeTotal.Text = (Count1.ToString());
            }
           
        }

        private void rbLimpiesa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLimpiesa.Checked == true)
            {
                TextBoxResultadoDeTotal.Text = (Count.ToString());
            }
        }

        private void rbSeguridad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeguridad.Checked == true)
            {
                TextBoxResultadoDeTotal.Text = (Count2.ToString());
            }
        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
