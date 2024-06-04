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
    public partial class AddTransportForm : Form
    {
        public Abstract_Transport_by_wheels NewTransport { get; private set; }
        public AddTransportForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            // Создание нового объекта на основе введенных данных
            NewTransport = new Bus
            {
                Name = txtName.Text,
                Capacity = int.Parse(txtCapacity.Text),
                Type_of_energy = txtTypeOfEnergy.Text,
                Numbers_of_wheels = int.Parse(txtNumberOfWheels.Text),
                Price = int.Parse(txtPrice.Text),
                Stops = txtStops.Text.Split(',')
            };
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
