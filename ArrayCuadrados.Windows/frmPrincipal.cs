using ArrayCuadrados.Datos;
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
    public partial class frmPrincipal : Form
    {
        private RepositorioDeCuadrados repo;
        private List<Cuadrado> lista;
        int intValor;

        public frmPrincipal()
        {
            InitializeComponent();
            repo = new RepositorioDeCuadrados();
            ActualizarCantidadRegistros();
        }

        private void ActualizarCantidadRegistros()
        {

            if (intValor > 0)
            {
                txtCantidad.Text = repo.GetCantidad(intValor).ToString();
            }
            else
            {
                txtCantidad.Text = repo.GetCantidad().ToString();
            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //Hacer click dos veces en actualizar para que se actualicen la cantidad de registros
            lista = repo.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
            intValor = 0;
            tsbFiltrar.BackColor = SystemColors.Control;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCuadradoAE frm = new frmCuadradoAE() { Text = "Agregar cuadrado." };
            DialogResult dr = frm.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }
            Cuadrado cuadrado = frm.GetCuadrado();
            repo.Agregar(cuadrado);
            txtCantidad.Text = repo.GetCantidad().ToString();
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, cuadrado);
            AgregarFila(r);

            MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cuadrado cuadrado)
        {
            r.Cells[colLado.Index].Value = cuadrado.GetLado();
            r.Cells[colBorde.Index].Value = cuadrado.TipoDeBorde;
            r.Cells[colRelleno.Index].Value = cuadrado.ColorRelleno;
            r.Cells[colSuperficie.Index].Value = cuadrado.GetSuperficie();
            r.Cells[colPerimetro.Index].Value = cuadrado.GetPerimetro();
            r.Tag = cuadrado;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea borrar el cuadrado?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Cuadrado cuadrado = filaSeleccionada.Tag as Cuadrado;
            repo.Borrar(cuadrado);
            txtCantidad.Text = repo.GetCantidad().ToString();
            QuitarFila(filaSeleccionada);
        }

        private void QuitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Registro borrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];

            Cuadrado cuadrado = (Cuadrado)filaSeleccionada.Tag;
            int ladoAnterior = cuadrado.GetLado();
            frmCuadradoAE frm = new frmCuadradoAE() { Text = "Editar cuadrado" };
            frm.SetCuadrado(cuadrado);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            cuadrado = frm.GetCuadrado();
            repo.Editar(ladoAnterior, cuadrado);
            SetearFila(filaSeleccionada, cuadrado);
            MessageBox.Show("Registro editado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            var stringValor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor a filtrar",
                "Filtrar por mayor o igual",
                "0", 400, 400);
            if (!int.TryParse(stringValor, out intValor))
            {
                return;
            }
            if (intValor <= 0)
            {
                return;
            }
            lista = repo.Filtrar(intValor);
            tsbFiltrar.BackColor = Color.Blue;
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
            MessageBox.Show("Filtro aplicado!");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (repo.GetCantidad() > 0)
            {
                lista = repo.GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var cuadrado in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, cuadrado);
                AgregarFila(r);
            }
        }

        private void tsbOrdenar_Click(object sender, EventArgs e)
        {

        }

    }
}

