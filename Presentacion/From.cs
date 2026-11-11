using Datos;
using Entidades;
using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamar a la Capa de Negocio
            // Suponiendo que D_Usuario.Login te devolvió el objeto usuario con éxito
            E_Usuario? usuarioLogueado = D_Usuario.Login(txtUsuario.Text, txtPassword.Text);

            if (usuarioLogueado != null)
            {
                MessageBox.Show("¡Bienvenido al sistema, " + usuarioLogueado.dsUsuario + "!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Instanciamos el formulario principal
                FrmPrincipal principal = new FrmPrincipal(usuarioLogueado);
                principal.Show();

                // Ocultamos el formulario de login actual
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento requerido por el diseñador
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Evento requerido por el diseñador
        }
    }
}
