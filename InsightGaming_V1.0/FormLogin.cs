using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;

namespace InsightGaming_V1._0
{
    public partial class FormLogin : Form
    {
        //Variables para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormLogin()
        {
            //Inicio de componentes y configuraciones de visibilidad en el evento load
            InitializeComponent();
            pbLogin.ImageLocation = ".\\basedatos\\login.gif";
            pnRecuperarContraseña.Visible = false;
            laConfirmacionEnvioContraseña.Visible = false;
        }
        //Metodo para cancelar 
        private void btCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Metodo de login
        private void btAcceptLogin_Click(object sender, EventArgs e)
        {
            string sqlorder = "SELECT * FROM usuario ";
            sqlorder = sqlorder + "WHERE email=@email AND @password=password";
            OleDbCommand command = new OleDbCommand(sqlorder, MainForm.conexion);
            command.Parameters.AddWithValue("@email", tbUserLogin.Text);
            command.Parameters.AddWithValue("@password", tbPasswordLogin.Text);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LoginInfo.UserCode = reader.GetInt32(0);
                    LoginInfo.UserName = reader.GetString(3);
                    LoginInfo.Email = reader.GetString(1);        
                    LoginInfo.imagen = reader.GetString(11);                       
                    LoginInfo.Puntos = reader.GetInt32(10);
                    LoginInfo.Usertype = reader.GetInt32(4);
                    this.Close();
                }
                
       
            }
            else
            {
                laComprobacionLogin.ForeColor = Color.Red;
                laComprobacionLogin.Text = "¡Las credenciales para entrar no son correctas o el usuario no existe!";
                LoginInfo.UserName = null;
            }
        }
        //Errores
        private void tbPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }
        //
        //Metodo para mover la ventana
        private void pbLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Metodos para hacer efecto de desaparicion de texto al cambiar de textbox
        private void tbUserLogin_Enter(object sender, EventArgs e)
        {
            laConfirmacionEnvioContraseña.Visible = false;
            if (tbUserLogin.Text == "Usuario")
            {
                tbUserLogin.Text = "";
            }
        }
        //Metodos para hacer efecto de desaparicion de texto al cambiar de textbox
        private void tbUserLogin_Leave(object sender, EventArgs e)
        {
            if (tbUserLogin.Text =="")
            {
                tbUserLogin.Text = "Usuario";
            }
        }
        //Metodos para hacer efecto de desaparicion de texto al cambiar de textbox
        private void tbPasswordLogin_Enter(object sender, EventArgs e)
        {
            if (tbPasswordLogin.Text == "Contraseña")
            {
                tbPasswordLogin.Text = "";
            }
        }
        //Metodos para hacer efecto de desaparicion de texto al cambiar de textbox
        private void tbPasswordLogin_Leave(object sender, EventArgs e)
        {
            if (tbPasswordLogin.Text == "")
            {
                tbPasswordLogin.Text = "Contraseña";
            }
        }
        //Metodo de llamada al formulario de registro
        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.ShowDialog();
        }
        //Metodo para visibilizar la recuperacion la contraseña
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnRecuperarContraseña.Visible = true;
        }
        //Metodos para hacer efecto de desaparicion de texto al cambiar de textbox
        private void tbCorreoRecuperacion_Enter(object sender, EventArgs e)
        {
            if (tbCorreoRecuperacion.Text == "Introduce dirección de correo")
            {
                tbCorreoRecuperacion.Text = "";
            }
        }
        //Metodo de envio de correo 1/2
        private void btEnviarCorreo_Click(object sender, EventArgs e)
        {
            string correo = tbCorreoRecuperacion.Text.Trim();
            string sqlorder = "SELECT email FROM usuario WHERE email=@email";
            OleDbCommand command = new OleDbCommand(sqlorder, MainForm.conexion);
            command.Parameters.AddWithValue("@email", correo);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                MailAddress from = new MailAddress("jmanuelsanchezros@gmail.com", "Recuperación de contraseña");
                MailAddress to = new MailAddress(correo, "Recuperación de contraseña");
                List<MailAddress> cc = new List<MailAddress>();
                cc.Add(new MailAddress("jmanuelsanchezros@gmail.com", "Recuperación de contraseña"));
                SendEmail("Recuperacion de contraseña", from, to, cc);
                pnRecuperarContraseña.Visible = false;
                laConfirmacionEnvioContraseña.Visible = true;
            }
            else
            {
                pnRecuperarContraseña.Visible = false;
                laConfirmacionEnvioContraseña.Visible = true;
            }
            
            
        }
        //Metodo de envio de correo 2/2
        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string correo = tbCorreoRecuperacion.Text.Trim();
            string contraseña = "";
            string sqlorder = "SELECT password FROM usuario WHERE email=@email";
            OleDbCommand command = new OleDbCommand(sqlorder, MainForm.conexion);
            command.Parameters.AddWithValue("@email",correo );
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                  contraseña = reader.GetString(0);
                MessageBox.Show(contraseña);
            }
            string Text = "";
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.Credentials = new NetworkCredential("jmanuelsanchezros@gmail.com", "Naruto56/");
            mailClient.EnableSsl = true;
            MailMessage msgMail;
            Text = "Tu contraseña de usuario es: " + contraseña;
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
        }
        //Metodos para hacer efecto de desaparicion de texto al cambiar de textbox

        private void tbCorreoRecuperacion_Leave(object sender, EventArgs e)
        {
            if (tbCorreoRecuperacion.Text == "")
            {
                tbCorreoRecuperacion.Text = "Introduce dirección de correo";
            }
        }
    }
    }

