namespace WindowsFormsApplication1
{
    partial class Form1
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
        /// 
        
        //public class DateTimePicker : Control


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_printForm = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_upload_slika = new System.Windows.Forms.Button();
            this.tb_activationCode = new System.Windows.Forms.TextBox();
            this.L_korisnichki_kod = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_t2_time = new System.Windows.Forms.TextBox();
            this.btn_t2_submit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_t2_serviceID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_t2_dateTo = new System.Windows.Forms.Label();
            this.pb_t2_photo = new System.Windows.Forms.PictureBox();
            this.lbl_t2_dateFrom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_t2_surname = new System.Windows.Forms.Label();
            this.lbl_t2_name = new System.Windows.Forms.Label();
            this.tb_t2_userCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._dp_gold_membershipDataSet1 = new WindowsFormsApplication1._dp_gold_membershipDataSet1();
            this.lbl_t3_search = new System.Windows.Forms.Label();
            this.btn_t3_renew = new System.Windows.Forms.Button();
            this.btn_t3_edit = new System.Windows.Forms.Button();
            this.btn_t3_submit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_t3_dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_t3_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_t3_phone = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_t3_mail = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_t3_surname = new System.Windows.Forms.TextBox();
            this.tb_t3_name = new System.Windows.Forms.TextBox();
            this.btn_t3_upload = new System.Windows.Forms.Button();
            this.lbl_t3_dateTo = new System.Windows.Forms.Label();
            this.pb_t3_photo = new System.Windows.Forms.PictureBox();
            this.lbl_t3_dateFrom = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_t3_search = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.usersTableAdapter1 = new WindowsFormsApplication1._dp_gold_membershipDataSet1TableAdapters.UsersTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_t2_photo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dp_gold_membershipDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_t3_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 689);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_printForm);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.button_upload_slika);
            this.tabPage1.Controls.Add(this.tb_activationCode);
            this.tabPage1.Controls.Add(this.L_korisnichki_kod);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Нов корисник";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_printForm
            // 
            this.btn_printForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printForm.Location = new System.Drawing.Point(271, 613);
            this.btn_printForm.Name = "btn_printForm";
            this.btn_printForm.Size = new System.Drawing.Size(145, 30);
            this.btn_printForm.TabIndex = 21;
            this.btn_printForm.Text = "Печати";
            this.btn_printForm.UseVisualStyleBackColor = true;
            this.btn_printForm.Click += new System.EventHandler(this.btn_printForm_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(91, 348);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 18);
            this.label27.TabIndex = 17;
            this.label27.Text = "Слика:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(308, 348);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(277, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // button_upload_slika
            // 
            this.button_upload_slika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload_slika.Location = new System.Drawing.Point(441, 534);
            this.button_upload_slika.Name = "button_upload_slika";
            this.button_upload_slika.Size = new System.Drawing.Size(145, 30);
            this.button_upload_slika.TabIndex = 15;
            this.button_upload_slika.Text = "Додади слика";
            this.button_upload_slika.UseVisualStyleBackColor = true;
            this.button_upload_slika.Click += new System.EventHandler(this.button_upload_slika_Click);
            // 
            // tb_activationCode
            // 
            this.tb_activationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_activationCode.Location = new System.Drawing.Point(308, 295);
            this.tb_activationCode.Name = "tb_activationCode";
            this.tb_activationCode.Size = new System.Drawing.Size(277, 24);
            this.tb_activationCode.TabIndex = 14;
            // 
            // L_korisnichki_kod
            // 
            this.L_korisnichki_kod.AutoSize = true;
            this.L_korisnichki_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_korisnichki_kod.Location = new System.Drawing.Point(90, 295);
            this.L_korisnichki_kod.Name = "L_korisnichki_kod";
            this.L_korisnichki_kod.Size = new System.Drawing.Size(125, 18);
            this.L_korisnichki_kod.TabIndex = 13;
            this.L_korisnichki_kod.Text = "Кориснички код:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(308, 250);
            this.dateTimePicker2.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(277, 24);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(90, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 18);
            this.label14.TabIndex = 11;
            this.label14.Text = "Важност од:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Внеси корисник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 24);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата на раѓање:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(308, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(277, 24);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(308, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 24);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Е-mail:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(308, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 24);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Презиме:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(308, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 24);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_t2_time);
            this.tabPage2.Controls.Add(this.btn_t2_submit);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tb_t2_serviceID);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.tb_t2_userCode);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Активност";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_t2_time
            // 
            this.tb_t2_time.Enabled = false;
            this.tb_t2_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t2_time.Location = new System.Drawing.Point(336, 500);
            this.tb_t2_time.Name = "tb_t2_time";
            this.tb_t2_time.ReadOnly = true;
            this.tb_t2_time.Size = new System.Drawing.Size(280, 24);
            this.tb_t2_time.TabIndex = 8;
            // 
            // btn_t2_submit
            // 
            this.btn_t2_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_t2_submit.Location = new System.Drawing.Point(471, 603);
            this.btn_t2_submit.Name = "btn_t2_submit";
            this.btn_t2_submit.Size = new System.Drawing.Size(145, 30);
            this.btn_t2_submit.TabIndex = 7;
            this.btn_t2_submit.Text = "Внеси";
            this.btn_t2_submit.UseVisualStyleBackColor = true;
            this.btn_t2_submit.Click += new System.EventHandler(this.btn_t2_submit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(73, 506);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Време:";
            // 
            // tb_t2_serviceID
            // 
            this.tb_t2_serviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t2_serviceID.Location = new System.Drawing.Point(336, 448);
            this.tb_t2_serviceID.Name = "tb_t2_serviceID";
            this.tb_t2_serviceID.Size = new System.Drawing.Size(280, 24);
            this.tb_t2_serviceID.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Шифра:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_t2_dateTo);
            this.panel1.Controls.Add(this.pb_t2_photo);
            this.panel1.Controls.Add(this.lbl_t2_dateFrom);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_t2_surname);
            this.panel1.Controls.Add(this.lbl_t2_name);
            this.panel1.Location = new System.Drawing.Point(38, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 280);
            this.panel1.TabIndex = 2;
            // 
            // lbl_t2_dateTo
            // 
            this.lbl_t2_dateTo.AutoSize = true;
            this.lbl_t2_dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t2_dateTo.Location = new System.Drawing.Point(39, 179);
            this.lbl_t2_dateTo.Name = "lbl_t2_dateTo";
            this.lbl_t2_dateTo.Size = new System.Drawing.Size(74, 18);
            this.lbl_t2_dateTo.TabIndex = 5;
            this.lbl_t2_dateTo.Text = "// дата до";
            // 
            // pb_t2_photo
            // 
            this.pb_t2_photo.BackColor = System.Drawing.Color.White;
            this.pb_t2_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_t2_photo.Location = new System.Drawing.Point(387, 24);
            this.pb_t2_photo.Name = "pb_t2_photo";
            this.pb_t2_photo.Size = new System.Drawing.Size(190, 232);
            this.pb_t2_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_t2_photo.TabIndex = 4;
            this.pb_t2_photo.TabStop = false;
            // 
            // lbl_t2_dateFrom
            // 
            this.lbl_t2_dateFrom.AutoSize = true;
            this.lbl_t2_dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t2_dateFrom.Location = new System.Drawing.Point(39, 156);
            this.lbl_t2_dateFrom.Name = "lbl_t2_dateFrom";
            this.lbl_t2_dateFrom.Size = new System.Drawing.Size(74, 18);
            this.lbl_t2_dateFrom.TabIndex = 3;
            this.lbl_t2_dateFrom.Text = "// дата од";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Важност:";
            // 
            // lbl_t2_surname
            // 
            this.lbl_t2_surname.AutoSize = true;
            this.lbl_t2_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t2_surname.Location = new System.Drawing.Point(39, 67);
            this.lbl_t2_surname.Name = "lbl_t2_surname";
            this.lbl_t2_surname.Size = new System.Drawing.Size(79, 18);
            this.lbl_t2_surname.TabIndex = 1;
            this.lbl_t2_surname.Text = "// презиме";
            // 
            // lbl_t2_name
            // 
            this.lbl_t2_name.AutoSize = true;
            this.lbl_t2_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t2_name.Location = new System.Drawing.Point(39, 44);
            this.lbl_t2_name.Name = "lbl_t2_name";
            this.lbl_t2_name.Size = new System.Drawing.Size(47, 18);
            this.lbl_t2_name.TabIndex = 0;
            this.lbl_t2_name.Text = "// име";
            // 
            // tb_t2_userCode
            // 
            this.tb_t2_userCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t2_userCode.Location = new System.Drawing.Point(336, 400);
            this.tb_t2_userCode.Name = "tb_t2_userCode";
            this.tb_t2_userCode.Size = new System.Drawing.Size(280, 24);
            this.tb_t2_userCode.TabIndex = 1;
            this.tb_t2_userCode.TextChanged += new System.EventHandler(this.tb_t2_userCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Кориснички код:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_users);
            this.tabPage3.Controls.Add(this.lbl_t3_search);
            this.tabPage3.Controls.Add(this.btn_t3_renew);
            this.tabPage3.Controls.Add(this.btn_t3_edit);
            this.tabPage3.Controls.Add(this.btn_t3_submit);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.tb_t3_search);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(676, 663);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Преглед на корисници";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.AllowUserToResizeColumns = false;
            this.dgv_users.AllowUserToResizeRows = false;
            this.dgv_users.AutoGenerateColumns = false;
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_users.ColumnHeadersHeight = 30;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.mail,
            this.photo,
            this.phone,
            this.dateOfBirth});
            this.dgv_users.DataSource = this.usersBindingSource;
            this.dgv_users.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_users.Location = new System.Drawing.Point(21, 71);
            this.dgv_users.MultiSelect = false;
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersVisible = false;
            this.dgv_users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(632, 201);
            this.dgv_users.TabIndex = 8;
            this.dgv_users.SelectionChanged += new System.EventHandler(this.dgv_users_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Кориснички код";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Презиме";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Visible = false;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "photo";
            this.photo.HeaderText = "photo";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Visible = false;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Visible = false;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataPropertyName = "dateOfBirth";
            this.dateOfBirth.HeaderText = "dateOfBirth";
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            this.dateOfBirth.Visible = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._dp_gold_membershipDataSet1;
            // 
            // _dp_gold_membershipDataSet1
            // 
            this._dp_gold_membershipDataSet1.DataSetName = "_dp_gold_membershipDataSet1";
            this._dp_gold_membershipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_t3_search
            // 
            this.lbl_t3_search.AutoSize = true;
            this.lbl_t3_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t3_search.Location = new System.Drawing.Point(21, 20);
            this.lbl_t3_search.Name = "lbl_t3_search";
            this.lbl_t3_search.Size = new System.Drawing.Size(107, 18);
            this.lbl_t3_search.TabIndex = 7;
            this.lbl_t3_search.Text = "Пребарување:";
            // 
            // btn_t3_renew
            // 
            this.btn_t3_renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_t3_renew.Location = new System.Drawing.Point(357, 278);
            this.btn_t3_renew.Name = "btn_t3_renew";
            this.btn_t3_renew.Size = new System.Drawing.Size(145, 30);
            this.btn_t3_renew.TabIndex = 6;
            this.btn_t3_renew.Text = "Обнови картичка";
            this.btn_t3_renew.UseVisualStyleBackColor = true;
            this.btn_t3_renew.Click += new System.EventHandler(this.btn_t3_renew_Click);
            // 
            // btn_t3_edit
            // 
            this.btn_t3_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_t3_edit.Location = new System.Drawing.Point(508, 278);
            this.btn_t3_edit.Name = "btn_t3_edit";
            this.btn_t3_edit.Size = new System.Drawing.Size(145, 30);
            this.btn_t3_edit.TabIndex = 5;
            this.btn_t3_edit.Text = "Промени податоци";
            this.btn_t3_edit.UseVisualStyleBackColor = true;
            this.btn_t3_edit.Click += new System.EventHandler(this.btn_t3_edit_Click);
            // 
            // btn_t3_submit
            // 
            this.btn_t3_submit.Enabled = false;
            this.btn_t3_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_t3_submit.Location = new System.Drawing.Point(508, 622);
            this.btn_t3_submit.Name = "btn_t3_submit";
            this.btn_t3_submit.Size = new System.Drawing.Size(145, 30);
            this.btn_t3_submit.TabIndex = 4;
            this.btn_t3_submit.Text = "Зачувај";
            this.btn_t3_submit.UseVisualStyleBackColor = true;
            this.btn_t3_submit.Click += new System.EventHandler(this.btn_t3_submit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtp_t3_dateFrom);
            this.panel2.Controls.Add(this.dtp_t3_birthdate);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.tb_t3_phone);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.tb_t3_mail);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.tb_t3_surname);
            this.panel2.Controls.Add(this.tb_t3_name);
            this.panel2.Controls.Add(this.btn_t3_upload);
            this.panel2.Controls.Add(this.lbl_t3_dateTo);
            this.panel2.Controls.Add(this.pb_t3_photo);
            this.panel2.Controls.Add(this.lbl_t3_dateFrom);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Location = new System.Drawing.Point(21, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 302);
            this.panel2.TabIndex = 3;
            // 
            // dtp_t3_dateFrom
            // 
            this.dtp_t3_dateFrom.CustomFormat = "dd-MM-yyyy";
            this.dtp_t3_dateFrom.Enabled = false;
            this.dtp_t3_dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_t3_dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_t3_dateFrom.Location = new System.Drawing.Point(197, 229);
            this.dtp_t3_dateFrom.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_t3_dateFrom.Name = "dtp_t3_dateFrom";
            this.dtp_t3_dateFrom.Size = new System.Drawing.Size(211, 24);
            this.dtp_t3_dateFrom.TabIndex = 15;
            this.dtp_t3_dateFrom.Value = new System.DateTime(2015, 6, 27, 0, 0, 0, 0);
            this.dtp_t3_dateFrom.Visible = false;
            this.dtp_t3_dateFrom.ValueChanged += new System.EventHandler(this.dtp_t3_dateFrom_ValueChanged);
            // 
            // dtp_t3_birthdate
            // 
            this.dtp_t3_birthdate.CustomFormat = "dd-MM-yyyy";
            this.dtp_t3_birthdate.Enabled = false;
            this.dtp_t3_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_t3_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_t3_birthdate.Location = new System.Drawing.Point(197, 185);
            this.dtp_t3_birthdate.MaxDate = new System.DateTime(2015, 6, 30, 0, 0, 0, 0);
            this.dtp_t3_birthdate.MinDate = new System.DateTime(1915, 1, 1, 0, 0, 0, 0);
            this.dtp_t3_birthdate.Name = "dtp_t3_birthdate";
            this.dtp_t3_birthdate.Size = new System.Drawing.Size(211, 24);
            this.dtp_t3_birthdate.TabIndex = 14;
            this.dtp_t3_birthdate.Value = new System.DateTime(2015, 6, 27, 0, 0, 0, 0);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(10, 186);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 18);
            this.label23.TabIndex = 13;
            this.label23.Text = "Дата на раѓање:";
            // 
            // tb_t3_phone
            // 
            this.tb_t3_phone.Enabled = false;
            this.tb_t3_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t3_phone.Location = new System.Drawing.Point(197, 144);
            this.tb_t3_phone.Name = "tb_t3_phone";
            this.tb_t3_phone.Size = new System.Drawing.Size(211, 24);
            this.tb_t3_phone.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 18);
            this.label22.TabIndex = 11;
            this.label22.Text = "Телефон:";
            // 
            // tb_t3_mail
            // 
            this.tb_t3_mail.Enabled = false;
            this.tb_t3_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t3_mail.Location = new System.Drawing.Point(197, 103);
            this.tb_t3_mail.Name = "tb_t3_mail";
            this.tb_t3_mail.Size = new System.Drawing.Size(211, 24);
            this.tb_t3_mail.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 18);
            this.label21.TabIndex = 9;
            this.label21.Text = "E-mail:";
            // 
            // tb_t3_surname
            // 
            this.tb_t3_surname.Enabled = false;
            this.tb_t3_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t3_surname.Location = new System.Drawing.Point(197, 66);
            this.tb_t3_surname.Name = "tb_t3_surname";
            this.tb_t3_surname.Size = new System.Drawing.Size(211, 24);
            this.tb_t3_surname.TabIndex = 8;
            // 
            // tb_t3_name
            // 
            this.tb_t3_name.Enabled = false;
            this.tb_t3_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t3_name.Location = new System.Drawing.Point(197, 28);
            this.tb_t3_name.Name = "tb_t3_name";
            this.tb_t3_name.Size = new System.Drawing.Size(211, 24);
            this.tb_t3_name.TabIndex = 7;
            // 
            // btn_t3_upload
            // 
            this.btn_t3_upload.Enabled = false;
            this.btn_t3_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_t3_upload.Location = new System.Drawing.Point(487, 238);
            this.btn_t3_upload.Name = "btn_t3_upload";
            this.btn_t3_upload.Size = new System.Drawing.Size(145, 30);
            this.btn_t3_upload.TabIndex = 6;
            this.btn_t3_upload.Text = "Додади слика";
            this.btn_t3_upload.UseVisualStyleBackColor = true;
            this.btn_t3_upload.Click += new System.EventHandler(this.btn_t3_upload_Click);
            // 
            // lbl_t3_dateTo
            // 
            this.lbl_t3_dateTo.AutoSize = true;
            this.lbl_t3_dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t3_dateTo.Location = new System.Drawing.Point(194, 262);
            this.lbl_t3_dateTo.Name = "lbl_t3_dateTo";
            this.lbl_t3_dateTo.Size = new System.Drawing.Size(74, 18);
            this.lbl_t3_dateTo.TabIndex = 5;
            this.lbl_t3_dateTo.Text = "// дата до";
            // 
            // pb_t3_photo
            // 
            this.pb_t3_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_t3_photo.Location = new System.Drawing.Point(441, 28);
            this.pb_t3_photo.Name = "pb_t3_photo";
            this.pb_t3_photo.Size = new System.Drawing.Size(188, 198);
            this.pb_t3_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_t3_photo.TabIndex = 4;
            this.pb_t3_photo.TabStop = false;
            // 
            // lbl_t3_dateFrom
            // 
            this.lbl_t3_dateFrom.AutoSize = true;
            this.lbl_t3_dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t3_dateFrom.Location = new System.Drawing.Point(194, 229);
            this.lbl_t3_dateFrom.Name = "lbl_t3_dateFrom";
            this.lbl_t3_dateFrom.Size = new System.Drawing.Size(74, 18);
            this.lbl_t3_dateFrom.TabIndex = 3;
            this.lbl_t3_dateFrom.Text = "// дата од";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 18);
            this.label18.TabIndex = 2;
            this.label18.Text = "Важност:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 18);
            this.label19.TabIndex = 1;
            this.label19.Text = "Презиме:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Име:";
            // 
            // tb_t3_search
            // 
            this.tb_t3_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_t3_search.Location = new System.Drawing.Point(21, 41);
            this.tb_t3_search.Name = "tb_t3_search";
            this.tb_t3_search.Size = new System.Drawing.Size(632, 24);
            this.tb_t3_search.TabIndex = 1;
            this.tb_t3_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_t3_search_KeyUp);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 687);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Спортски Центар „Борис Трајковски“";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_t2_photo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dp_gold_membershipDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_t3_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_t2_submit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_t2_serviceID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_t2_dateTo;
        private System.Windows.Forms.PictureBox pb_t2_photo;
        private System.Windows.Forms.Label lbl_t2_dateFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_t2_surname;
        private System.Windows.Forms.Label lbl_t2_name;
        private System.Windows.Forms.TextBox tb_t2_userCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_t3_search;
        private System.Windows.Forms.Button btn_t3_submit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_t3_upload;
        private System.Windows.Forms.Label lbl_t3_dateTo;
        private System.Windows.Forms.PictureBox pb_t3_photo;
        private System.Windows.Forms.Label lbl_t3_dateFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_t3_renew;
        private System.Windows.Forms.Button btn_t3_edit;
        private System.Windows.Forms.TextBox tb_t3_mail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_t3_surname;
        private System.Windows.Forms.TextBox tb_t3_name;
        private System.Windows.Forms.TextBox tb_t3_phone;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtp_t3_birthdate;
        private System.Windows.Forms.DateTimePicker dtp_t3_dateFrom;
        private System.Windows.Forms.Label lbl_t3_search;
        private System.Windows.Forms.TextBox tb_activationCode;
        private System.Windows.Forms.Label L_korisnichki_kod;
        private System.Windows.Forms.Button button_upload_slika;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tb_t2_time;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_printForm;
        private System.Windows.Forms.DataGridView dgv_users;
        private _dp_gold_membershipDataSet1 _dp_gold_membershipDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _dp_gold_membershipDataSet1TableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;



        // getters


        public string getName
        {
            get { return textBox1.Text; }
        }

        //
    }
}

