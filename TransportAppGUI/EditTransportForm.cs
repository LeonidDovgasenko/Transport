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

namespace TransportAppGUI
{
    public partial class EditTransportForm : Form
    {
        public Abstract_Transport_by_wheels EditedTransport { get; private set; }

        public EditTransportForm(Abstract_Transport_by_wheels transport)
        {
            InitializeComponent();
            EditedTransport = transport;

            // Заполнение полей формы данными выбранного объекта
            txtName.Text = transport.Name;
            txtCapacity.Text = transport.Capacity.ToString();
            txtTypeOfEnergy.Text = transport.Type_of_energy;
            txtNumberOfWheels.Text = transport.Numbers_of_wheels.ToString();
            txtPrice.Text = transport.Price.ToString();
            txtStops.Text = string.Join(",", transport.Stops);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Обновление объекта на основе введенных данных
            EditedTransport.Name = txtName.Text;
            EditedTransport.Capacity = int.Parse(txtCapacity.Text);
            EditedTransport.Type_of_energy = txtTypeOfEnergy.Text;
            EditedTransport.Numbers_of_wheels = int.Parse(txtNumberOfWheels.Text);
            EditedTransport.Price = int.Parse(txtPrice.Text);
            EditedTransport.Stops = txtStops.Text.Split(',');
            DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
