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
    public partial class Form1 : Form
    {
        private List<Docente> _listado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _listado = DocenteBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.DocenteId,
                            Nombre = x.Nombre,
                            Apellido = x.Apellido,
                            Aula = x.Aula,
                            Laptop = x.Laptops.Nombre
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Editar"].Selected)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[1].Value;
                string nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string apellido = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string Aula = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                int laptopid = _listado.FirstOrDefault(x => x.DocenteId.Equals(id)).LaptopId;

                Docente entity = new Docente()
                {
                    DocenteId = id,
                    Nombre = nombre,
                    Apellido  =apellido,
                    Aula = Aula,
                    LaptopId = laptopid
                  
                };

                //Editar
                frmNuevo frm = new frmNuevo(entity);
                frm.ShowDialog();
                UpdateGrid();


            }
        }

        private void o_Click(object sender, EventArgs e)
        {
            frmNuevo frm = new frmNuevo();
            frm.ShowDialog();
            UpdateGrid();
        }
    }
}
