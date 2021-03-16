using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    public partial class FileContentsForm : Form
    {
        public FileContentsForm()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DbFileEntry.DisplayAndSerach("SECLECT id,item_name,quantity, location From file_information", DataGridView);
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            FileEntryContents.FileInformationForm fIF = new FileEntryContents.FileInformationForm(this);
            fIF.ShowDialog();
        }

        private void FileContents_Load(object sender, EventArgs e)
        {
            Display();
        }
    }
}
