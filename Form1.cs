using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue<string> QueueNombre = new Queue<string>();
            Queue<string> QueueApellidos = new Queue<string>();
            Queue<string> QueueNumeroCuenta = new Queue<string>();
            Queue<Queue<string>> QueueNombreCompleto = new Queue<Queue<string>>();
            QueueNombre.Enqueue("JESUS ALEJANDRO");
            QueueNombre.Enqueue("ERICK IVAN");
            QueueNombre.Enqueue("LUIS ANTONIO");
            QueueNombre.Enqueue("SEBASTIAN ALDAIR");
            QueueNombre.Enqueue("LUIS ARMANDO");
            QueueNombre.Enqueue("MILTON OSMAR");
            QueueNombre.Enqueue("Armando");
            QueueApellidos.Enqueue("ARZATE");
            QueueApellidos.Enqueue("BARCENAS");
            QueueApellidos.Enqueue("LAGUNA");
            QueueApellidos.Enqueue("MARTINEZ");
            QueueApellidos.Enqueue("SANCHEZ");
            QueueApellidos.Enqueue("SOSA");
            QueueApellidos.Enqueue("Uribe");
            QueueNumeroCuenta.Enqueue("1");
            QueueNumeroCuenta.Enqueue("2");
            QueueNumeroCuenta.Enqueue("3");
            QueueNumeroCuenta.Enqueue("4");
            QueueNumeroCuenta.Enqueue("5");
            QueueNumeroCuenta.Enqueue("6");
            QueueNumeroCuenta.Enqueue("7");
            QueueNombreCompleto.Enqueue(QueueNombre);
            QueueNombreCompleto.Enqueue(QueueApellidos);
            QueueNombreCompleto.Enqueue(QueueNombre);
            QueueNombreCompleto.Enqueue(QueueNumeroCuenta);
            QueueNombreCompleto.Enqueue(QueueApellidos);
            QueueNombreCompleto.Enqueue(QueueNumeroCuenta);

            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Name = "Apellido Paterno";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Numero de cuenta";

            for (int contadorFilas = 0; contadorFilas < 7; contadorFilas++)
            {
                Boolean flag1 = true;
                Boolean flag2 = true;
                dataGridView1.Rows.Add();
                for (int contadorCol = 0; contadorCol < 2; contadorCol++)
                {
                    if (flag1)
                    {
                        dataGridView1.Rows[contadorFilas].Cells[contadorCol].Value = QueueApellidos.Peek();
                        QueueApellidos.Dequeue();
                        flag1 = false;
                    }
                    else if (flag2)
                    {
                        dataGridView1.Rows[contadorFilas].Cells[contadorCol].Value = QueueNombre.Peek();
                        QueueNombre.Dequeue();
                        flag2 = false;
                    }
                    else
                    {
                        dataGridView1.Rows[contadorFilas].Cells[contadorCol].Value = QueueNumeroCuenta.Peek();
                        QueueNumeroCuenta.Dequeue();
                        flag2 = false;
                    }
                }
            }
        }
    }
}
