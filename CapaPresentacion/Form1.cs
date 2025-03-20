using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private CapaNegocio.Logica logica;


        public Form1()
        {
            InitializeComponent();

            logica = new CapaNegocio.Logica( new ConexionSQLServer());

            // Agregar los tipos de documento al ComboBox
            cbtipoDoc.Items.Add("Cédula de ciudadanía");
            cbtipoDoc.Items.Add("Tarjeta de identidad");
            cbtipoDoc.Items.Add("Cédula de extranjería");
            cbtipoDoc.Items.Add("Pasaporte");

            cbtipoDoc.SelectedIndex = 0; // Seleccionar el primer ítem por defecto
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar datos del formulario
                string tipoDocumento = cbtipoDoc.Text;
                int numeroDocumento = int.Parse(tbnumeroDoc.Text);
                int ingresosTotales = int.Parse(tbingresosTotales.Text);
                int egresosTotales = int.Parse(tbegresosTotales.Text); // ❗ Corregido aquí
                int montoSolicitado = int.Parse(tbmonto.Text);
                int plazoSolicitado = int.Parse(tbplazo.Text);

                // Llamar a la lógica de negocio
                string respuesta = logica.aprobacionCredito(tipoDocumento, numeroDocumento, ingresosTotales, egresosTotales, montoSolicitado, plazoSolicitado); // ❗ Corregido aquí

                // Mostrar mensaje según la respuesta
                if (respuesta == "Negado")
                {
                    MessageBox.Show("Este crédito no fue aprobado", "Resultado asegurabilidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Este crédito fue aprobado", "Resultado asegurabilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Limpiar los campos
                tbplazo.Text = string.Empty;
                tbnumeroDoc.Text = string.Empty;
                tbmonto.Text = string.Empty;
                tbingresosTotales.Text = string.Empty;
                tbegresosTotales.Text = string.Empty;
                cbtipoDoc.SelectedIndex = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
