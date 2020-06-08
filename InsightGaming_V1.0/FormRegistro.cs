using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightGaming_V1._0
{
    public partial class FormRegistro : Form
    {
        //Variables para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormRegistro()
        {
            InitializeComponent();
            pbRegistro.ImageLocation = ".\\basedatos\\registro.gif";
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void tbNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
//Metodo de login
        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false ;
            string sqlorder = "SELECT * FROM usuario ";
            sqlorder = sqlorder + "WHERE email=@email";
            OleDbCommand command = new OleDbCommand(sqlorder, MainForm.conexion);
            command.Parameters.AddWithValue("@email", tbEmail.Text);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                laComprobacionRegistro.Text = "¡El Email que has introducido ya existe!";
                laComprobacionRegistro.ForeColor = Color.Red;
            }
            sqlorder = "SELECT username FROM usuario ";
            sqlorder = sqlorder + "WHERE username=@usuario";
            command = new OleDbCommand(sqlorder, MainForm.conexion);
            command.Parameters.AddWithValue("@usuario", tbNombreUsuario.Text);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                laComprobacionRegistro.Text = "¡El nombre que has introducido ya existe!";
                laComprobacionRegistro.ForeColor = Color.Red;
                error = true;
            }

            if (tbContraseña.Text != tbRepiteContraseña.Text)
            {
                error = true;
                laComprobacionRegistro.Text = "¡Las contraseñas introducidas no coinciden!";
                laComprobacionRegistro.ForeColor = Color.Red;
            }
            if(!error)
            {
                //Password va entre parentesis debido a que es un nombre resrvado y se producira un error fatal a la hora de introducir el usuario. Para solucionar esto, se coloca dentro de corchetes
               string query = @"INSERT INTO usuario(email,direccion,username,apellidos,telefono,fecha_nacimiento,nombre,[password],img,puntos) 
                            VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10)";
                OleDbCommand comandoinsertar = new OleDbCommand(query, MainForm.conexion);
                command = new OleDbCommand(query, MainForm.conexion);
                comandoinsertar.Parameters.AddWithValue("@param1", tbEmail.Text);
                comandoinsertar.Parameters.AddWithValue("@param2", tbDireccionRegistro.Text);
                comandoinsertar.Parameters.AddWithValue("@param3", tbNombreUsuario.Text);
                comandoinsertar.Parameters.AddWithValue("@param4", tbApellidosRegistro.Text);
                comandoinsertar.Parameters.AddWithValue("@param5", Convert.ToInt32(tbTelefono.Text));
                comandoinsertar.Parameters.AddWithValue("@param6", DtpFechaNacimiento.Value);
                comandoinsertar.Parameters.AddWithValue("@param7", tbNombreRegistro.Text);
                comandoinsertar.Parameters.AddWithValue("@param8", tbContraseña.Text);
                comandoinsertar.Parameters.AddWithValue("@param9", "!");
                comandoinsertar.Parameters.AddWithValue("@param10", 0);
                MessageBox.Show(query);
                comandoinsertar.ExecuteNonQuery();
        
                //this.Close();
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar
        private void tbNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (tbNombreUsuario.Text == "Introduce Nombre de Usuario")
            {
                tbNombreUsuario.Text = "";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar
        private void tbNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (tbNombreUsuario.Text == "")
            {
                tbNombreUsuario.Text = "Introduce Nombre de Usuario";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Introduce Email")
            {
                tbEmail.Text = "";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Introduce Email";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar
        private void tbContraseña_Enter(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "Introduce Contraseña")
            {
                tbContraseña.Text = "";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar
        private void tbContraseña_Leave(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "")
            {
                tbContraseña.Text = "Introduce Contraseña";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar
        private void tbRepiteContraseña_Enter(object sender, EventArgs e)
        {
            if (tbRepiteContraseña.Text == "Repite Contraseña")
            {
                tbRepiteContraseña.Text = "";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar
        private void tbRepiteContraseña_Leave(object sender, EventArgs e)
        {
            if (tbRepiteContraseña.Text == "")
            {
                tbRepiteContraseña.Text = "Repite Contraseña";
            }
        }
        //Error
        private void lineShape8_Click(object sender, EventArgs e)
        {

        }
        //Error
        private void lineShape6_Click(object sender, EventArgs e)
        {

        }
        //Error
        private void lineShape7_Click(object sender, EventArgs e)
        {

        }
        //Error
        private void lineShape5_Click(object sender, EventArgs e)
        {

        }
        //Error
        private void tbNombreRegistro_TextChanged(object sender, EventArgs e)
        {

        }
        //Error
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Error
        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar

        private void tbNombreRegistro_Enter(object sender, EventArgs e)
        {
            if (tbNombreRegistro.Text == "Introduce Nombre")
            {
                tbNombreRegistro.Text = "";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar

        private void tbNombreRegistro_Leave(object sender, EventArgs e)
        {
            if (tbNombreRegistro.Text == "")
            {
                tbNombreRegistro.Text = "Introduce Nombre";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar

        private void tbDireccionRegistro_Enter(object sender, EventArgs e)
        {
            if (tbDireccionRegistro.Text == "Introduce Dirección")
            {
                tbDireccionRegistro.Text = "";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar

        private void tbDireccionRegistro_Leave(object sender, EventArgs e)
        {
            if (tbDireccionRegistro.Text == "")
            {
                tbDireccionRegistro.Text = "Introduce Dirección";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar

        private void tbApellidosRegistro_Enter(object sender, EventArgs e)
        {
            if (tbApellidosRegistro.Text == "Introduce Apellidos")
            {
                tbApellidosRegistro.Text = "";
            }
        }
        //Metodos para crear la animacion de desaparicion de texto al ingresar

        private void tbApellidosRegistro_Leave(object sender, EventArgs e)
        {
            if (tbApellidosRegistro.Text == "")
            {
                tbApellidosRegistro.Text = "Introduce Apellidos";
            }
        }
        //Metodo para solo introducir numero

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //Metodo para mover la ventana
        private void FormRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
