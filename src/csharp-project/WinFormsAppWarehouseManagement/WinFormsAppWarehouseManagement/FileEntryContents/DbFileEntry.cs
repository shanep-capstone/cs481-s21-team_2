using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    class DbFileEntry
    {
        public static MySqlConnection GetConnection()
        {
            string conn = "datasource=localhost;port=3306;username=root;pwd=St18an03!;database=WarehouseFile";
            //string cs = "Server=localhost;uid=root;pwd=St18an03!;database=WarehouseFile";
            MySqlConnection sqlConn = new MySqlConnection(conn);
            try
            {
                sqlConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sqlConn;
        }
        public static void AddFile(FileEntry fileEntry)
        {
            string sql = " INSERT INTO WarehouseFile.file_information(@id, @item_name,@quantity,@location)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = fileEntry.Id;
            cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = fileEntry.Item_Name;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = fileEntry.Quantity;
            cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value = fileEntry.Location;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("File is not inserted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            
        }
        public static void UpdateFile(FileEntry fileEntry, string id)
        {
            string sql = " UPDATE WarehouseFile.file_information SET id=@id, item_name=@item_name,quantity=@quantity,location=@location WHERE id=@id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = fileEntry.Id;
            cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = fileEntry.Item_Name;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = fileEntry.Quantity;
            cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value = fileEntry.Location;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("File is not updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteFile(string id)
        {
            string sql = "DELETE FROM WarehouseFile Where id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("File is not deleted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSerach(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();
        }

     }
}
