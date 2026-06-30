using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PracticeMidterm
{
    public partial class Form1 : Form
    {
        private List<User> users;
        public Form1()
        {
            InitializeComponent();
            // Upon start, the form renders the users data.
            loadUsers();
        }

        private void loadUsers()
        {
            string data = File.ReadAllText("../../Data/users.json");
            users = JsonConvert.DeserializeObject<List<User>>(data);
            dataGridView1.DataSource = users;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // The show button resets the datas in DataView for demo purposes
        private void btnShow_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*
             * The use of `dataGridView1.SelectedRows` is to identify
             * what are the rows does the user select.
             */
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("There is no user selected.");
                return;
            }

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                User user = (User)dataGridView1.SelectedRows[i].DataBoundItem;
                users.Remove(user);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<User> sortedUsers = users.OrderBy(user => user.name).ToList();
            dataGridView1.DataSource = sortedUsers;
            users = sortedUsers;
        }
    }
}
