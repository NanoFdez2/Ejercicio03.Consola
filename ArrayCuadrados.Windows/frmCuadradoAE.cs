using ArrayCuadrados.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayCuadrados.Windows
{
    public partial class frmCuadradoAE : Form
    {
        public frmCuadradoAE()
        {
            InitializeComponent();
        }
        public Cuadrado cuadrado;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboColorRelleno();
            CrearBotonesOpcionBordes();
            if (cuadrado != null)
            {
                txtLado.Text = cuadrado.GetLado().ToString();
            }
        }

        private void CrearBotonesOpcionBordes()
        {
            var listaBordes = Enum.GetValues(typeof(TipodeBorde)).Cast<TipodeBorde>().ToList();
            cboBorde.DataSource = listaBordes;
            cboBorde.SelectedIndex = 0;
        }

        private void CargarDatosComboColorRelleno()
        {
            var listaColores = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();
            cboColores.DataSource = listaColores;
            cboColores.SelectedIndex = 0;
        }

        public Cuadrado GetCuadrado()
        {
            return cuadrado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (cuadrado == null)
                {
                    cuadrado = new Cuadrado();
                }

                cuadrado.SetLado(int.Parse(txtLado.Text));
                //cuadrado.SetLado(int.Parse(txtLado.Text));
                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLado.Text, out int lado))
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Nro. mal ingresado.");
            }
            else if (lado <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Valor del lado menor a cero.");
            }
            return valido;
        }

        public void SetCuadrado(Cuadrado? cuadrado)
        {
            this.cuadrado = cuadrado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCuadradoAE_Load(object sender, EventArgs e)
        {

        }
    }
}
