using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxMS
{
    public partial class MessageBoxMS : Form
    {
        public string respuestaBoton { get; set; }
        public string mensaje { get; set; }
        public string titulo { get; set; }
        public string textoBoton1 { get; set; }
        public string textoBoton2 { get; set; }
        public string textoBoton3 { get; set; }


        public MessageBoxMS(string Mensaje, string Titulo, string TextoBoton1, string TextoBoton2, string TextoBoton3, MessageBoxMSTipoIcono TipoIcono, int TamanoFuenteMensaje = 9)
        {
            InitializeComponent();

            this.mensaje = Mensaje;
            this.titulo = Titulo;
            this.textoBoton1 = TextoBoton1;
            this.textoBoton2 = TextoBoton2;
            this.textoBoton3 = TextoBoton3;
            this.respuestaBoton = "";

            AsignarValoresAControles();

            if (TipoIcono == MessageBoxMSTipoIcono.Exclamacion)
            {
                pbxIcono.Image = Properties.Resources.exclamacion24;
            }
            else if (TipoIcono == MessageBoxMSTipoIcono.Error)
            {
                pbxIcono.Image = Properties.Resources.error24;
            }
            else if (TipoIcono == MessageBoxMSTipoIcono.Informacion)
            {
                pbxIcono.Image = Properties.Resources.informacion24;
            }
            else if (TipoIcono == MessageBoxMSTipoIcono.Interrogante)
            {
                pbxIcono.Image = Properties.Resources.interrogante24;
            }

            Font Fuente = new Font(lblMensaje.Font.Name, TamanoFuenteMensaje, FontStyle.Regular);
            this.lblMensaje.Font = Fuente;



        }

        private void AsignarValoresAControles()
        {
            lblMensaje.Text = this.mensaje;
            this.Text = titulo;
            btn1.Text = textoBoton1;
            btn2.Text = textoBoton2;
            btn3.Text = textoBoton3;

            btn1.Visible = textoBoton1.Length > 0;
            btn2.Visible = textoBoton2.Length > 0;
            btn3.Visible = textoBoton3.Length > 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            respuestaBoton = btn1.Text;
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            respuestaBoton = btn2.Text;
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            respuestaBoton = btn3.Text;
            this.Close();
        }

        private void MessageBoxMS_Shown(object sender, EventArgs e)
        {
            this.AcceptButton = btn2;
        }
    }

    public enum MessageBoxMSTipoIcono
    {
        Exclamacion = 0,
        Error = 1,
        Informacion = 2,
        Interrogante = 3
    }
}
