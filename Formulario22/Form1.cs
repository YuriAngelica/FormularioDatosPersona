using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulario22
{
    public partial class Form1 : Form

    {
        DataTable tabla = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int sueldo, calificacion;

            if (radEstudiante.Checked)
            {
                if (int.TryParse(txtCalificacion.Text, out calificacion))
                {
                    DataRow newRow = tabla.NewRow();
                    newRow["Nombre"] = nombre;
                    newRow["Calificacion"] = calificacion;
                    newRow["Tipo de persona"] = "Estudiante";
                    tabla.Rows.Add(newRow);


                    txtNombre.Text = "";
                    txtCalificacion.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para Calificación.");
                }
            }
            else if (radProfesor.Checked)
            {
                if (int.TryParse(txtSueldo.Text, out sueldo))
                {
                    DataRow newRow = tabla.NewRow();
                    newRow["Nombre"] = nombre;
                    newRow["Sueldo"] = sueldo;
                    newRow["Tipo de persona"] = "Profesor";
                    tabla.Rows.Add(newRow);


                    txtNombre.Text = "";
                    txtSueldo.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para Sueldo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de persona (Estudiante o Profesor).");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder datos = new StringBuilder();

            foreach (DataRow row in tabla.Rows)
            {
                datos.AppendLine("Nombre: " + row["Nombre"].ToString());
                datos.AppendLine("Sueldo: " + row["Sueldo"].ToString());
                datos.AppendLine("Calificación: " + row["Calificacion"].ToString());
                datos.AppendLine("Tipo de persona: " + row["Tipo de persona"].ToString());
                datos.AppendLine();
            }

            if (datos.Length > 0)
            {
                MessageBox.Show("Datos almacenados:\n\n" + datos.ToString(), "Datos Guardados");
            }
            else
            {
                MessageBox.Show("No hay datos almacenados.", "Datos Guardados");
            }
        }

    

    private void grpTipoPersona_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {

                txtNombre.ReadOnly = false;
                txtSueldo.ReadOnly = false;
                txtCalificacion.ReadOnly = true;
            }

        }

        private void radEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (radEstudiante.Checked)
            {

                txtNombre.ReadOnly = false;
                txtSueldo.ReadOnly = true;
                txtCalificacion.ReadOnly = false;
            }

        }

        private void dtgListaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Nombre";
            tabla.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Sueldo";
            tabla.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Calificacion";
            tabla.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Tipo de persona";
            tabla.Columns.Add(column);

            dtgListaDatos.DataSource = tabla;

        }
    }
}
