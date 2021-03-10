using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement
{
    public partial class FileEntryForm : Form
    {
        public FileEntryForm()
        {
            InitializeComponent();
        }

        private void FileEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void BackToMainFE_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPage mp = new MainPage();
            mp.ShowDialog();
        }
    }
}
