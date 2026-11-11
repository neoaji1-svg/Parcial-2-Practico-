using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices; //Importante para mover la ventana
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private E_Usuario usuarioActual;

        // Importación de librerías de Windows para permitir arrastrar el formulario sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmPrincipal(E_Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;

            // Muestra el nombre de usuario y su ID en la parte inferior del menú lateral
            lblUsuarioLogueado.Text = "👤 " + usuarioActual.dsUsuario + "\nID: " + usuarioActual.dsId;

            // Opcional: Si tu panel superior se llama 'panelTitulo', vinculamos el evento aquí:
            // panelTitulo.MouseDown += new MouseEventHandler(panelTitulo_MouseDown);
        }

        // Método para mover la ventana sin bordes haciendo clic en la barra superior
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Método genérico para abrir formularios dentro del panel contenedor central
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Asegúrate de cambiar 'panelContenedor' por el nombre real de tu panel central
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss \n dddd, dd 'de' MMMM 'de' yyyy");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Cambia 'panel1' por el nombre real de tu panel lateral izquierdo
            if (panel1.Width == 250)
            {
                panel1.Width = 70; // Ancho contraído
            }
            else
            {
                panel1.Width = 250; // Ancho expandido
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
