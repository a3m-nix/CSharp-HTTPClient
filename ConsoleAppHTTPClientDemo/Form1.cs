using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace ConsoleAppHTTPClientDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            User user = UserProvider.GetDataById(id);
            MessageBox.Show(user.nama);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                nama = txtNama.Text,
                alamat = txtAlamat.Text
            };
            HttpResponseMessage request = UserProvider.CreateData(user);
            MessageBox.Show(request.Content.ReadAsStringAsync().Result);
        }
    }
}
