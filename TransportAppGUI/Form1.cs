using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportApp;

namespace TransportAppGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Пример добавления объектов в список при загрузке формы
            listBoxTransports.Items.Add(new Bus
            {
                Name = "Российский Автобус",
                Capacity = 50,
                Type_of_energy = "Дизель",
                Numbers_of_wheels = 6,
                Price = 100,
                Stops = new string[] { "Остановка 1", "Остановка 2", "Остановка 3" }
            });

            listBoxTransports.Items.Add(new Trolleybus
            {
                Name = "Российский Троллейбус",
                Capacity = 40,
                Type_of_energy = "Электричество",
                Numbers_of_wheels = 4,
                Price = 80,
                Stops = new string[] { "Остановка A", "Остановка B", "Остановка C" }
            });

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления нового объекта
            var addForm = new AddTransportForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                listBoxTransports.Items.Add(addForm.NewTransport);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTransports.SelectedItem != null)
            {
                listBoxTransports.Items.Remove(listBoxTransports.SelectedItem);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTransports.SelectedItem != null)
            {
                // Открытие формы для редактирования выбранного объекта
                var editForm = new EditTransportForm((Abstract_Transport_by_wheels)listBoxTransports.SelectedItem);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Обновление элемента в ListBox
                    int index = listBoxTransports.SelectedIndex;
                    listBoxTransports.Items[index] = editForm.EditedTransport;
                }
            }

        }

        private void listBoxTransports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTransports.SelectedItem != null)
            {
                var selectedTransport = (Abstract_Transport_by_wheels)listBoxTransports.SelectedItem;
                lblFare.Text = $"Fare: {TransportLogic.CalculateFare(selectedTransport)}";
            }
        }
    }

}
