using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<Entities.User> users = new BindingList<Entities.User>();
        public Form1()
        {
            InitializeComponent();
            labelFullName.Text = Resource1.FullName;
            btnAdd.Text = Resource1.Add;
            buttonWriteToFile.Text = Resource1.WriteToFile;
            buttonDelete.Text = Resource1.Delete;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newUser = new Entities.User()
            {
                FullName = textBoxFullName.Text,
            };
            users.Add(newUser);
        }

        private void buttonWriteToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if(sf.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            StreamWriter sw = new StreamWriter(sf.FileName);
            MessageBox.Show(sf.FileName);
            foreach (var user in users)
            {
                sw.WriteLine(user.ID.ToString() + ": " + user.FullName);
            }
            sw.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedUser = (Entities.User)listBox1.SelectedItem;
            users.Remove(selectedUser);
        }
    }
}

