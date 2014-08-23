using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing.Drawing2D;



namespace dataentry
{
    public partial class frmdataentry : Form
    {
        string[] files;
        FolderBrowserDialog folderBrowserDialog1;
        public frmdataentry()
        {
            InitializeComponent();
            folderBrowserDialog1 = new FolderBrowserDialog();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
        }

        private void btnloadassignment_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                set_file_neviagtion();
            }
        }

        protected void set_file_neviagtion()
        {
            if (files.Length > 0)
            {
                lblcimgno.Text = "0";
                lbltotalimgno.Text = (files.Length - 1).ToString();
                lblcimgpath.Text = files[0];
                pictureBox1.Image = Image.FromFile(files[0]);
            }
        }

        private void frmdataentry_Load(object sender, EventArgs e)
        {
            bindgrid();
        }

        protected void bindgrid()
        {
            SQLHelper.BindGridview(datagrid1, "select ID, Image_name, sr_no,id_no, ssn, emp_ln, billing_name, add1, city1, state1, zip1 from Entry");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_form();
        }

        protected void clear_form()
        {
            txtID.Text = "";
            txtadd1.Text = "";
            txtbilling_name.Text = "";
            txtcity1.Text = "";
            txtemp_ln.Text = "";
            txtID.Text = "";
            txtid_no.Text = "";
            txtimage_name.Text = "";
            txtsr_no.Text = "";
            txtssn.Text = "";
            txtstate1.Text = "";
            txtzip1.Text = "";
        }

        protected void disable_form()
        {
            btnnext.Enabled = false;
            btnprevious.Enabled = false;
            btnreset.Enabled = false;
            btnsave.Enabled = false;
            btnsaveandnext.Enabled = false;
            btnsave.Enabled = false;
            txtadd1.Enabled = false;
            txtbilling_name.Enabled = false;
            txtcity1.Enabled = false;
            txtemp_ln.Enabled = false;
            txtID.Enabled = false;
            txtid_no.Enabled = false;
            txtimage_name.Enabled = false;
            txtsr_no.Enabled = false;
            txtssn.Enabled = false;
            txtstate1.Enabled = false;
            txtzip1.Enabled = false;

        }

        protected void enable_form()
        {
            btnnext.Enabled = true;
            btnprevious.Enabled = true;
            btnreset.Enabled = true;
            btnsave.Enabled = true;
            btnsaveandnext.Enabled = true;
            btnsave.Enabled = true;
            txtadd1.Enabled = true;
            txtbilling_name.Enabled = true;
            txtcity1.Enabled = true;
            txtemp_ln.Enabled = true;
            txtID.Enabled = true;
            txtid_no.Enabled = true;
            txtimage_name.Enabled = true;
            txtsr_no.Enabled = true;
            txtssn.Enabled = true;
            txtstate1.Enabled = true;
            txtzip1.Enabled = true;
        }

        protected string insert_data()
        {
            string sql = "insert into Entry(Image_name,sr_no,id_no,ssn,emp_ln,billing_name,add1,city1,state1,zip1) values('" + lblcimgpath.Text + "','" + txtsr_no.Text + "','" + txtid_no.Text + "','" + txtssn.Text + "','" + txtemp_ln.Text + "','" + txtbilling_name.Text + "','" + txtadd1.Text + "','" + txtcity1.Text + "','" + txtstate1.Text + "','" + txtzip1.Text + "')";
            SQLHelper._objCmd.CommandText = sql;

            return SQLHelper.ExecuteNonQuery();

        }

        protected string update_data()
        {
            string sql = "update Entry set Image_name='" + txtimage_name.Text + "', sr_no='" + txtsr_no.Text + "',id_no='" + txtid_no.Text + "',ssn='" + txtssn.Text + "',emp_ln='" + txtemp_ln.Text + "',billing_name='" + txtbilling_name.Text + "',add1='" + txtadd1.Text + "',city1='" + txtcity1.Text + "',state1='" + txtstate1.Text + "',zip1='" + txtzip1.Text + "' where ID=" + txtID.Text;
            SQLHelper._objCmd.CommandText = sql;

            return SQLHelper.ExecuteNonQuery();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int current = 0, total;
            current = int.Parse(lblcimgno.Text);
            total = files.Length - 1;
            if (current < total)
            {
                current++;
                lblcimgno.Text = current.ToString();
                lblcimgpath.Text = files[current];
                pictureBox1.Image = Image.FromFile(files[current]);
            }

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            int current = 0, total;
            current = int.Parse(lblcimgno.Text);
            total = files.Length - 1;
            if (current > 0)
            {
                current--;
                lblcimgno.Text = current.ToString();
                lblcimgpath.Text = files[current];
                pictureBox1.Image = Image.FromFile(files[current]);
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                if (insert_data() == "")
                {
                    MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = SQLHelper.ExecuteStatement("select max(ID) from Entry");
                    //clear_form();
                    bindgrid();
                }
                else
                {
                    MessageBox.Show("Error while inserting record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (update_data() == "")
                {
                    MessageBox.Show("Record Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = SQLHelper.ExecuteStatement("select max(ID) from Entry");
                    //clear_form();
                    bindgrid();
                }
                else
                {
                    MessageBox.Show("Error while updating record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsaveandnext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                if (insert_data() == "")
                {
                    MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // txtID.Text = SQLHelper.ExecuteStatement("select max(ID) from Entry");
                    clear_form();
                    bindgrid();
                }
                else
                {
                    MessageBox.Show("Error while inserting record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (update_data() == "")
                {
                    MessageBox.Show("Record Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = SQLHelper.ExecuteStatement("select max(ID) from Entry");
                    clear_form();
                    bindgrid();
                }
                else
                {
                    MessageBox.Show("Error while updating record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void datagrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID = datagrid1.Rows[datagrid1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();

            txtID.Text = SQLHelper.ExecuteStatement("select ID from Entry where ID =" + ID + "");
            txtid_no.Text = SQLHelper.ExecuteStatement("select id_no from Entry where ID =" + ID + "");
            txtimage_name.Text = SQLHelper.ExecuteStatement("select Image_Name from Entry where ID =" + ID + "");
            txtsr_no.Text = SQLHelper.ExecuteStatement("select sr_no from Entry where ID=" + ID + "");
            txtssn.Text = SQLHelper.ExecuteStatement("select ssn from Entry where ID=" + ID + "");
            txtstate1.Text = SQLHelper.ExecuteStatement("select state1 from Entry where ID=" + ID + "");
            txtadd1.Text = SQLHelper.ExecuteStatement("select add1 from Entry where ID=" + ID + "");
            txtbilling_name.Text = SQLHelper.ExecuteStatement("select billing_name from Entry where ID=" + ID + "");
            txtcity1.Text = SQLHelper.ExecuteStatement("select city1 from Entry where ID=" + ID + "");
            txtemp_ln.Text = SQLHelper.ExecuteStatement("select emp_ln from Entry where ID=" + ID + "");
            txtzip1.Text = SQLHelper.ExecuteStatement("select zip1 from Entry where ID=" + ID + "");

            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedTab.Text = "Entry Form";
        }

        private void btnzoomout_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                int newWidth = pictureBox1.Size.Width, newHeight = pictureBox1.Size.Height, newX = pictureBox1.Location.X, newY = pictureBox1.Location.Y;
                newWidth = pictureBox1.Size.Width + (pictureBox1.Size.Width / 10);
                newHeight = pictureBox1.Size.Height + (pictureBox1.Size.Height / 10);
                //newX = pictureBox1.Location.X - ((pictureBox1.Size.Width / 10) / 2);
                //newY = pictureBox1.Location.Y - ((pictureBox1.Size.Height / 10) / 2);
                newX = pictureBox1.Location.X;
                newY = pictureBox1.Location.Y;

                //if (newWidth < pictureBox1.Width)
                //{
                //    newWidth = pictureBox1.Width;
                //    newHeight = pictureBox1.Height;
                //    newX = 0;
                //    newY = 0;
                //}
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Size = new Size(newWidth, newHeight);
                pictureBox1.Location = new Point(newX, newY);
            }
        }

        private void btnzoomin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                int newWidth = pictureBox1.Size.Width, newHeight = pictureBox1.Size.Height, newX = pictureBox1.Location.X, newY = pictureBox1.Location.Y;
                newWidth = pictureBox1.Size.Width - (pictureBox1.Size.Width / 10);
                newHeight = pictureBox1.Size.Height - (pictureBox1.Size.Height / 10);
                //newX = pictureBox1.Location.X + ((pictureBox1.Size.Width / 10) / 2);
                //newY = pictureBox1.Location.Y + ((pictureBox1.Size.Height / 10) / 2);
                newX = pictureBox1.Location.X;
                newY = pictureBox1.Location.Y;

                //if (newWidth < pictureBox1.Width)
                //{
                //    newWidth = pictureBox1.Width;
                //    newHeight = pictureBox1.Height;
                //    newX = 0;
                //    newY = 0;
                //}

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Size = new Size(newWidth, newHeight);
                //if (newX >= 3 && newY >= 3)
                //{
                //    pictureBox1.Refresh();
                //    pictureBox1.Location = new Point(3, 3);
                //    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                //}
                //else
                pictureBox1.Location = new Point(newX, newY);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {
                    panel1.AutoScrollPosition = new Point(0, 0);
                    pictureBox1.Refresh();
                    pictureBox1.Location = new Point(3, 3);
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                }
            }
            catch (Exception ex) { }
        }
    }
}
