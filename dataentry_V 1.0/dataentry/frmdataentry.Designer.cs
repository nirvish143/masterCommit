namespace dataentry
{
    partial class frmdataentry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdataentry));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtzip1 = new System.Windows.Forms.TextBox();
            this.txtstate1 = new System.Windows.Forms.TextBox();
            this.txtcity1 = new System.Windows.Forms.TextBox();
            this.txtadd1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btncloseapp = new System.Windows.Forms.Button();
            this.btnsaveandnext = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtbilling_name = new System.Windows.Forms.TextBox();
            this.txtemp_ln = new System.Windows.Forms.TextBox();
            this.txtssn = new System.Windows.Forms.TextBox();
            this.txtid_no = new System.Windows.Forms.TextBox();
            this.txtsr_no = new System.Windows.Forms.TextBox();
            this.txtimage_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblimgname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalimgno = new System.Windows.Forms.Label();
            this.lblcimgno = new System.Windows.Forms.Label();
            this.lblcimgpath = new System.Windows.Forms.Label();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnloadassignment = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.btnzoomin = new System.Windows.Forms.Button();
            this.btnzoomout = new System.Windows.Forms.Button();
            this.dataentryDataSet = new dataentry.dataentryDataSet();
            this.dataentryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataentryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataentryDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 231);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 378);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.txtzip1);
            this.tabPage1.Controls.Add(this.txtstate1);
            this.tabPage1.Controls.Add(this.txtcity1);
            this.tabPage1.Controls.Add(this.txtadd1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btncloseapp);
            this.tabPage1.Controls.Add(this.btnsaveandnext);
            this.tabPage1.Controls.Add(this.btnreset);
            this.tabPage1.Controls.Add(this.btnsave);
            this.tabPage1.Controls.Add(this.txtbilling_name);
            this.tabPage1.Controls.Add(this.txtemp_ln);
            this.tabPage1.Controls.Add(this.txtssn);
            this.tabPage1.Controls.Add(this.txtid_no);
            this.tabPage1.Controls.Add(this.txtsr_no);
            this.tabPage1.Controls.Add(this.txtimage_name);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblimgname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbltotalimgno);
            this.tabPage1.Controls.Add(this.lblcimgno);
            this.tabPage1.Controls.Add(this.lblcimgpath);
            this.tabPage1.Controls.Add(this.btnprevious);
            this.tabPage1.Controls.Add(this.btnnext);
            this.tabPage1.Controls.Add(this.btnloadassignment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(180, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 43;
            this.txtID.Visible = false;
            this.txtID.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtzip1
            // 
            this.txtzip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzip1.Location = new System.Drawing.Point(111, 297);
            this.txtzip1.Name = "txtzip1";
            this.txtzip1.ShortcutsEnabled = false;
            this.txtzip1.Size = new System.Drawing.Size(100, 22);
            this.txtzip1.TabIndex = 10;
            this.txtzip1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtstate1
            // 
            this.txtstate1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstate1.Location = new System.Drawing.Point(111, 271);
            this.txtstate1.Name = "txtstate1";
            this.txtstate1.ShortcutsEnabled = false;
            this.txtstate1.Size = new System.Drawing.Size(100, 22);
            this.txtstate1.TabIndex = 9;
            this.txtstate1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtcity1
            // 
            this.txtcity1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity1.Location = new System.Drawing.Point(111, 245);
            this.txtcity1.Name = "txtcity1";
            this.txtcity1.ShortcutsEnabled = false;
            this.txtcity1.Size = new System.Drawing.Size(100, 22);
            this.txtcity1.TabIndex = 8;
            this.txtcity1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtadd1
            // 
            this.txtadd1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd1.Location = new System.Drawing.Point(111, 219);
            this.txtadd1.Name = "txtadd1";
            this.txtadd1.ShortcutsEnabled = false;
            this.txtadd1.Size = new System.Drawing.Size(100, 22);
            this.txtadd1.TabIndex = 7;
            this.txtadd1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Zip 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "State 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "City 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Add1";
            // 
            // btncloseapp
            // 
            this.btncloseapp.BackColor = System.Drawing.Color.CadetBlue;
            this.btncloseapp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncloseapp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseapp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncloseapp.Location = new System.Drawing.Point(614, 246);
            this.btncloseapp.Name = "btncloseapp";
            this.btncloseapp.Size = new System.Drawing.Size(226, 23);
            this.btncloseapp.TabIndex = 14;
            this.btncloseapp.Text = "Close Application";
            this.btncloseapp.UseVisualStyleBackColor = false;
            this.btncloseapp.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsaveandnext
            // 
            this.btnsaveandnext.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsaveandnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsaveandnext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveandnext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsaveandnext.Location = new System.Drawing.Point(614, 217);
            this.btnsaveandnext.Name = "btnsaveandnext";
            this.btnsaveandnext.Size = new System.Drawing.Size(226, 23);
            this.btnsaveandnext.TabIndex = 12;
            this.btnsaveandnext.Text = "Save And Next Entry";
            this.btnsaveandnext.UseVisualStyleBackColor = false;
            this.btnsaveandnext.Click += new System.EventHandler(this.btnsaveandnext_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.CadetBlue;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreset.Location = new System.Drawing.Point(614, 187);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(106, 23);
            this.btnreset.TabIndex = 13;
            this.btnreset.Text = "Reset Form";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(765, 187);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtbilling_name
            // 
            this.txtbilling_name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbilling_name.Location = new System.Drawing.Point(111, 192);
            this.txtbilling_name.Name = "txtbilling_name";
            this.txtbilling_name.ShortcutsEnabled = false;
            this.txtbilling_name.Size = new System.Drawing.Size(100, 22);
            this.txtbilling_name.TabIndex = 6;
            this.txtbilling_name.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtemp_ln
            // 
            this.txtemp_ln.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemp_ln.Location = new System.Drawing.Point(111, 166);
            this.txtemp_ln.Name = "txtemp_ln";
            this.txtemp_ln.ShortcutsEnabled = false;
            this.txtemp_ln.Size = new System.Drawing.Size(100, 22);
            this.txtemp_ln.TabIndex = 5;
            this.txtemp_ln.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtssn
            // 
            this.txtssn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtssn.Location = new System.Drawing.Point(111, 140);
            this.txtssn.Name = "txtssn";
            this.txtssn.ShortcutsEnabled = false;
            this.txtssn.Size = new System.Drawing.Size(100, 22);
            this.txtssn.TabIndex = 4;
            this.txtssn.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtid_no
            // 
            this.txtid_no.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_no.Location = new System.Drawing.Point(111, 114);
            this.txtid_no.Name = "txtid_no";
            this.txtid_no.ShortcutsEnabled = false;
            this.txtid_no.Size = new System.Drawing.Size(100, 22);
            this.txtid_no.TabIndex = 3;
            this.txtid_no.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtsr_no
            // 
            this.txtsr_no.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsr_no.Location = new System.Drawing.Point(111, 88);
            this.txtsr_no.Name = "txtsr_no";
            this.txtsr_no.ShortcutsEnabled = false;
            this.txtsr_no.Size = new System.Drawing.Size(100, 22);
            this.txtsr_no.TabIndex = 2;
            this.txtsr_no.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txtimage_name
            // 
            this.txtimage_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtimage_name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimage_name.Location = new System.Drawing.Point(111, 64);
            this.txtimage_name.Name = "txtimage_name";
            this.txtimage_name.ShortcutsEnabled = false;
            this.txtimage_name.Size = new System.Drawing.Size(100, 22);
            this.txtimage_name.TabIndex = 1;
            this.txtimage_name.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Billing Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Emp_ln";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sr No";
            // 
            // lblimgname
            // 
            this.lblimgname.AutoSize = true;
            this.lblimgname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimgname.Location = new System.Drawing.Point(15, 68);
            this.lblimgname.Name = "lblimgname";
            this.lblimgname.Size = new System.Drawing.Size(81, 16);
            this.lblimgname.TabIndex = 14;
            this.lblimgname.Text = "Image Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "of";
            // 
            // lbltotalimgno
            // 
            this.lbltotalimgno.AutoSize = true;
            this.lbltotalimgno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalimgno.Location = new System.Drawing.Point(743, 14);
            this.lbltotalimgno.Name = "lbltotalimgno";
            this.lbltotalimgno.Size = new System.Drawing.Size(14, 13);
            this.lbltotalimgno.TabIndex = 12;
            this.lbltotalimgno.Text = "0";
            // 
            // lblcimgno
            // 
            this.lblcimgno.AutoSize = true;
            this.lblcimgno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcimgno.Location = new System.Drawing.Point(699, 14);
            this.lblcimgno.Name = "lblcimgno";
            this.lblcimgno.Size = new System.Drawing.Size(14, 13);
            this.lblcimgno.TabIndex = 11;
            this.lblcimgno.Text = "0";
            // 
            // lblcimgpath
            // 
            this.lblcimgpath.AutoSize = true;
            this.lblcimgpath.Location = new System.Drawing.Point(286, 15);
            this.lblcimgpath.Name = "lblcimgpath";
            this.lblcimgpath.Size = new System.Drawing.Size(0, 16);
            this.lblcimgpath.TabIndex = 10;
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.CadetBlue;
            this.btnprevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnprevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnprevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprevious.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprevious.Location = new System.Drawing.Point(614, 9);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(75, 23);
            this.btnprevious.TabIndex = 15;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.CadetBlue;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnext.Location = new System.Drawing.Point(765, 9);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 16;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnloadassignment
            // 
            this.btnloadassignment.BackColor = System.Drawing.Color.CadetBlue;
            this.btnloadassignment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnloadassignment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadassignment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnloadassignment.Location = new System.Drawing.Point(19, 25);
            this.btnloadassignment.Name = "btnloadassignment";
            this.btnloadassignment.Size = new System.Drawing.Size(135, 24);
            this.btnloadassignment.TabIndex = 0;
            this.btnloadassignment.Text = "Load Assignment Folder";
            this.btnloadassignment.UseVisualStyleBackColor = false;
            this.btnloadassignment.Click += new System.EventHandler(this.btnloadassignment_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.datagrid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Completed Forms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(23, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "• Just Single Click on any cell to select the record.";
            // 
            // datagrid1
            // 
            this.datagrid1.AllowUserToAddRows = false;
            this.datagrid1.AllowUserToDeleteRows = false;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.Location = new System.Drawing.Point(6, 37);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.ReadOnly = true;
            this.datagrid1.Size = new System.Drawing.Size(850, 335);
            this.datagrid1.TabIndex = 0;
            this.datagrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_CellContentClick);
            this.datagrid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagrid1_CellMouseClick);
            // 
            // btnzoomin
            // 
            this.btnzoomin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnzoomin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnzoomin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzoomin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnzoomin.Location = new System.Drawing.Point(704, 211);
            this.btnzoomin.Name = "btnzoomin";
            this.btnzoomin.Size = new System.Drawing.Size(75, 23);
            this.btnzoomin.TabIndex = 11;
            this.btnzoomin.Text = "Zoom -";
            this.btnzoomin.UseVisualStyleBackColor = false;
            this.btnzoomin.Click += new System.EventHandler(this.btnzoomin_Click);
            // 
            // btnzoomout
            // 
            this.btnzoomout.BackColor = System.Drawing.Color.CadetBlue;
            this.btnzoomout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnzoomout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzoomout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnzoomout.Location = new System.Drawing.Point(785, 211);
            this.btnzoomout.Name = "btnzoomout";
            this.btnzoomout.Size = new System.Drawing.Size(75, 23);
            this.btnzoomout.TabIndex = 10;
            this.btnzoomout.Text = "Zoom +";
            this.btnzoomout.UseVisualStyleBackColor = false;
            this.btnzoomout.Click += new System.EventHandler(this.btnzoomout_Click);
            // 
            // dataentryDataSet
            // 
            this.dataentryDataSet.DataSetName = "dataentryDataSet";
            this.dataentryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataentryDataSetBindingSource
            // 
            this.dataentryDataSetBindingSource.DataSource = this.dataentryDataSet;
            this.dataentryDataSetBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 184);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.CadetBlue;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset.Location = new System.Drawing.Point(621, 211);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // frmdataentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(894, 621);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.btnzoomin);
            this.Controls.Add(this.btnzoomout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmdataentry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry";
            this.Load += new System.EventHandler(this.frmdataentry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataentryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataentryDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalimgno;
        private System.Windows.Forms.Label lblcimgno;
        private System.Windows.Forms.Label lblcimgpath;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnloadassignment;
        private System.Windows.Forms.Button btnsaveandnext;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtbilling_name;
        private System.Windows.Forms.TextBox txtemp_ln;
        private System.Windows.Forms.TextBox txtssn;
        private System.Windows.Forms.TextBox txtid_no;
        private System.Windows.Forms.TextBox txtsr_no;
        private System.Windows.Forms.TextBox txtimage_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblimgname;
        private System.Windows.Forms.TextBox txtzip1;
        private System.Windows.Forms.TextBox txtstate1;
        private System.Windows.Forms.TextBox txtcity1;
        private System.Windows.Forms.TextBox txtadd1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncloseapp;
        private System.Windows.Forms.DataGridView datagrid1;
        private System.Windows.Forms.Button btnzoomin;
        private System.Windows.Forms.Button btnzoomout;
        private dataentryDataSet dataentryDataSet;
        private System.Windows.Forms.BindingSource dataentryDataSetBindingSource;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Reset;
    }
}