using MartinParcialII.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartinParcialII.View
{
    public partial class frmNuevo : Form
    {
        int id = 0;
        public frmNuevo()
        {
            InitializeComponent();
            UpdateCombo();
        }

        public frmNuevo(Docente entity)
        {
            InitializeComponent();
            id = entity.DocenteId;

            textBoxNombre.Text = entity.Nombre;
            textBoxApellido.Text = entity.Apellido;
            textBoxAula.Text = entity.Aula;
            UpdateCombo();
            comboBox1.SelectedValue = entity.LaptopId;

        }
        private void frmNuevo_Load(object sender, EventArgs e)
        {

        }

        private void UpdateCombo()
        {
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "LaptopId";
            comboBox1.DataSource = LaptopBL.Instance.SellecALL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Docente entity = new Docente()
            {
                DocenteId = id,
                Nombre = textBoxNombre.Text.Trim(),
                Apellido = textBoxApellido.Text.Trim(),
                Aula = textBoxAula.Text.Trim(),
                LaptopId = (int)comboBox1.SelectedValue

            };
            if (id == 0)
            {
                if (DocenteBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (DocenteBL.Instance.Update(entity))
                {
                    MessageBox.Show("Registro se edito con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            this.Close();
        }
    }
}
