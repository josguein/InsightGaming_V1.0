using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightGaming_V1._0
{
    public partial class formOpciones : Form
    {
        //Metodos para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public static string img_archivo;
        public formOpciones()
        {
            
            InitializeComponent();
            pnTickets.BringToFront();
            pnTickets.Visible = false;
            pnInformar.Visible = false;
            pnTickets.Visible = false;
            rellenaDatos();
            cbOpcionesEnvioEmail.SelectedIndex = 1;
        }
        //Errores de Click
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {

        }
        //Metodo para mostrar la opcion seleccionada del menu lateral
        private void btDatosPersonales_Click(object sender, EventArgs e)
        {
            pnDatosPersonales.Visible = true;
            pnTickets.Visible = false;
            pnInformar.Visible = false;
            pnDatosPersonales.Dock = DockStyle.Fill;
            rellenaDatos();
        }
        //Metodo de rellenado de datos del usuario
        public void rellenaDatos()
        {
            string sentenciasql = "SELECT * FROM usuario ";
            sentenciasql = sentenciasql + "WHERE Id=@usuario";
            OleDbCommand comando = new OleDbCommand(sentenciasql, MainForm.conexion);
            comando.Parameters.AddWithValue("@usuario", LoginInfo.UserCode);
            OleDbDataReader lector = comando.ExecuteReader();
            
            while (lector.Read())
            {
                //MessageBox.Show(lector.GetString(3) + lector.GetString(5) +lector.GetString(6)+ lector.GetString(7) + lector.GetInt32(8).ToString() /*+ lector.GetString(8)*/) ;
                MessageBox.Show(lector.GetDateTime(9).ToShortDateString());
                tbNombreUsuario.Text=lector.GetString(3);
                tbNombre.Text = lector.GetString(5);
                tbApellidos.Text = lector.GetString(6);
                tbDireccion.Text = lector.GetString(7);
                tbTelefono.Text = lector.GetInt32(8).ToString();
                dateTimePicker1.Value = (DateTime)lector.GetDateTime(9);
            }
        }
        //Metodo que retorna los tickets asociados a un usuario
        private void btOrdenes_Click(object sender, EventArgs e)
        {
            //pnDatosPersonales.Visible = false;
            pnTickets.Visible = true;
            pnTickets.Dock = DockStyle.Fill;
           // pnInformar.Visible = false;
            string sentenciasql = "SELECT * FROM tickets ";
            sentenciasql = sentenciasql + "WHERE usuario_compra=@usuario";
            OleDbCommand comando = new OleDbCommand(sentenciasql, MainForm.conexion);
            comando.Parameters.AddWithValue("@usuario", LoginInfo.UserCode);

            OleDbDataReader lector = comando.ExecuteReader();
            lvListaCompra.Items.Clear();
            while (lector.Read())
            {
                string[] items = new string[3];
                items[0] = lector.GetDateTime(1).ToString();
                items[1] = lector.GetInt32(2).ToString();
                items[2] = lector.GetString(4);
                ListViewItem elementos = new ListViewItem(items);
                lvListaCompra.Items.Add(elementos);
            }
        }
        //Metodo de hacer aparecer el la seccion de informar
        private void btInformar_Click(object sender, EventArgs e)
        {
            pnDatosPersonales.Visible = true;
            pnInformar.Dock = DockStyle.Fill;
            pnTickets.Visible = false;
           pnInformar.Visible = true;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Metodo para guardar cambios en los datos personales
        private void btGuardarCambios_Click(object sender, EventArgs e)
        {

            OleDbCommand command;
            if (!string.IsNullOrWhiteSpace(tbNombreUsuario.Text))
            {
                string modificar = "UPDATE usuario SET username=@nombre_usuario WHERE Id = " + LoginInfo.UserCode + ";";
                
                 command= new OleDbCommand(modificar, MainForm.conexion);
                command.Parameters.AddWithValue("@nombre_usuario", tbNombreUsuario.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
    
                }
            }
            if (!string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                string modificar = "UPDATE usuario SET nombre=@nombre WHERE Id = " + LoginInfo.UserCode + ";";
                command = new OleDbCommand(modificar, MainForm.conexion);
                command.Parameters.AddWithValue("@nombre", tbNombre.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
            }
            
            if (!string.IsNullOrWhiteSpace(tbApellidos.Text))
            {
                string modificar = "UPDATE usuario SET apellidos=@apellidos WHERE Id = " + LoginInfo.UserCode + ";";
                command = new OleDbCommand(modificar, MainForm.conexion);
                command.Parameters.AddWithValue("@apellidos", tbApellidos.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                 
                }
            }
            if (!string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                string modificar = "UPDATE usuario SET direccion=@direccion WHERE Id = " + LoginInfo.UserCode + ";";
                command = new OleDbCommand(modificar, MainForm.conexion);
                command.Parameters.AddWithValue("@direccion", tbDireccion.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                 
                }
            }
            if (!string.IsNullOrWhiteSpace(tbTelefono.Text))
            {
                string modificar = "UPDATE usuario SET telefono=@telefono WHERE Id = " + LoginInfo.UserCode + ";";
                command = new OleDbCommand(modificar, MainForm.conexion);
                command.Parameters.AddWithValue("@telefono", tbNombre.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
           
                    
                }
            }
            if (dateTimePicker1.Text != "")
            {
                string modificar = "UPDATE usuario SET fecha_nacimiento=@fecha_nacimiento WHERE Id = " + LoginInfo.UserCode + ";";
                command = new OleDbCommand(modificar, MainForm.conexion);
                command.Parameters.AddWithValue("@fecha_nacimiento", dateTimePicker1.Value);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                   /* MessageBox.Show(ex.Message);
                    MessageBox.Show(modificar);*/
                    ;
                }
            }
            if (img_archivo!="")
            {
               
                string modificar = "UPDATE usuario SET img=@img WHERE Id = " + LoginInfo.UserCode + ";";
                command = new OleDbCommand(modificar, MainForm.conexion);
                command.Parameters.AddWithValue("@img", dlgImagen.FileName);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    /*MessageBox.Show(ex.Message);
                    MessageBox.Show(modificar);*/
                    ;
                }
            }
        }
        //Metodo para solo poner numeros en el apartado de telefono
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
        //Metodo para seleccionar imagen de usuario
        private void btSeleccionarAvatar_Click(object sender, EventArgs e)
        {
            
            pictureBox1.ImageLocation = dlgImagen.FileName;
            if (dlgImagen.ShowDialog(this) == DialogResult.OK)
            {
                img_archivo = dlgImagen.InitialDirectory + dlgImagen.FileName;
                MessageBox.Show(img_archivo);
            }
        }
        //Metodo para enviar incidencia al correo administrador
        private void btEnviarIncidencia_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress(LoginInfo.Email, cbOpcionesEnvioEmail.SelectedItem.ToString());
            MailAddress to = new MailAddress("jmanuelsanchezros@gmail.com", cbOpcionesEnvioEmail.SelectedItem.ToString());
            List<MailAddress> cc = new List<MailAddress>();
            cc.Add(new MailAddress("jmanuelsanchezros@gmail.com", cbOpcionesEnvioEmail.SelectedItem.ToString()));
            SendEmail(cbOpcionesEnvioEmail.SelectedItem.ToString(), from, to, cc);
        }
        //Metodo para enviar incidencia al correo administrador
        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "";
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.Credentials = new NetworkCredential(LoginInfo.Email, "narutovssasuke56");
            mailClient.EnableSsl = true;
            MailMessage msgMail;
            Text = "Has recibido una peticion para "+_subject+" del usuario "+LoginInfo.UserName;
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
            msgMail.Dispose();
        }
        //Metodo para acceder a la parte de administrador
        private void btAdmin_Click(object sender, EventArgs e)
        {
            FormAdministracion formAdministracion = new FormAdministracion();
            formAdministracion.ShowDialog();
        }
        //Metodo load que carga segun los parametros
        private void formOpciones_Load(object sender, EventArgs e)
        {
            if (LoginInfo.Usertype == 1)
            {
                btAdmin.Visible = true;
                btSalirAdmin.Visible = true;
            }
            else
            {
                btAdmin.Visible = false;
                btSalirAdmin.Visible = false;
            }
        }
        //Metodo para mover la ventana
        private void pnDatosPersonales_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    }

