using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsNpgsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost; Database=postgres; User ID=postgres; Password=Master1234; Pooling=true; MaxPoolSize=100"))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT 1", conn))
                    {
                        var result = (int) cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
