using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Development\C#\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }


        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 1 * FROM [TABLE] ORDER BY Id DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void disp_All_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [TABLE] ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_data();
        }




        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            comboBoxMeetingType.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxMeetingActions.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxMeetingStatus.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Your insert code here
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [TABLE] VALUES('" + comboBoxMeetingType.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + textBoxMeetingActions.Text + "','" + textBoxMeetingStatus.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                comboBoxMeetingType.Text = "";
                dateTimePicker1.Text = "";
                textBoxMeetingActions.Text = "";
                textBoxMeetingStatus.Text = "";
                MessageBox.Show("record inserted sucessfully");
                disp_data();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [Table] SET Meetingstatus='" + textBoxMeetingStatus.Text + "' WHERE MeetingType='" + comboBoxMeetingType.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                MessageBox.Show("Meeting Status updated sucessfully");
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            disp_All_data();
        }

        private void buttonLastCreatedMeeting_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
