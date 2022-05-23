using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxMS;

namespace ExampleUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxMS.MessageBoxMS msg = new MessageBoxMS.MessageBoxMS("¿Está seguro que desea continuar?", "Confirmar", "Si", "No", "Cancelar", MessageBoxMSTipoIcono.Error);
            msg.ShowDialog();
            MessageBox.Show(msg.respuestaBoton);
        }
    }
}
