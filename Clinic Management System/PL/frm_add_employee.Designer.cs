namespace Clinic_Management_System
{
    partial class add_employee
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
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.ts_btn_save = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_clear = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.tabControl_patient_info = new System.Windows.Forms.TabControl();
            this.tab_basic_info = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdb_doc = new System.Windows.Forms.RadioButton();
            this.rdb_nurse = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdb_armal = new System.Windows.Forms.RadioButton();
            this.rdb_motalk = new System.Windows.Forms.RadioButton();
            this.rdb_mairried = new System.Windows.Forms.RadioButton();
            this.rdb_single = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.dtb_reg_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_birth_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.tab_contact_info = new System.Windows.Forms.TabPage();
            this.txt_nat_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdp_doctor = new System.Windows.Forms.RadioButton();
            this.rdb_employee = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_phone1 = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip_controrl.SuspendLayout();
            this.tabControl_patient_info.SuspendLayout();
            this.tab_basic_info.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_contact_info.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_controrl
            // 
            this.toolStrip_controrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip_controrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_save,
            this.toolStripSeparator2,
            this.ts_btn_clear,
            this.toolStripSeparator1,
            this.ts_btn_exit});
            this.toolStrip_controrl.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controrl.Name = "toolStrip_controrl";
            this.toolStrip_controrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip_controrl.ShowItemToolTips = false;
            this.toolStrip_controrl.Size = new System.Drawing.Size(710, 90);
            this.toolStrip_controrl.TabIndex = 23;
            this.toolStrip_controrl.Text = "toolStrip1";
            // 
            // ts_btn_save
            // 
            this.ts_btn_save.Image = global::Clinic_Management_System.Properties.Resources.save_64;
            this.ts_btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btn_save.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.ts_btn_save.Name = "ts_btn_save";
            this.ts_btn_save.ShowDropDownArrow = false;
            this.ts_btn_save.Size = new System.Drawing.Size(68, 87);
            this.ts_btn_save.Text = "حفظ   ";
            this.ts_btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_save.Click += new System.EventHandler(this.ts_btn_save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 90);
            // 
            // ts_btn_clear
            // 
            this.ts_btn_clear.Image = global::Clinic_Management_System.Properties.Resources.edit_clear_64;
            this.ts_btn_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btn_clear.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.ts_btn_clear.Name = "ts_btn_clear";
            this.ts_btn_clear.ShowDropDownArrow = false;
            this.ts_btn_clear.Size = new System.Drawing.Size(87, 87);
            this.ts_btn_clear.Text = "تفريغ الخانات ";
            this.ts_btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_clear.Click += new System.EventHandler(this.ts_btn_clear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 90);
            // 
            // ts_btn_exit
            // 
            this.ts_btn_exit.Image = global::Clinic_Management_System.Properties.Resources.Cancel_64;
            this.ts_btn_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btn_exit.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.ts_btn_exit.Name = "ts_btn_exit";
            this.ts_btn_exit.ShowDropDownArrow = false;
            this.ts_btn_exit.Size = new System.Drawing.Size(68, 87);
            this.ts_btn_exit.Text = "خروج";
            this.ts_btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ts_btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_exit.Click += new System.EventHandler(this.ts_btn_exit_Click);
            // 
            // tabControl_patient_info
            // 
            this.tabControl_patient_info.Controls.Add(this.tab_basic_info);
            this.tabControl_patient_info.Controls.Add(this.tab_contact_info);
            this.tabControl_patient_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl_patient_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_patient_info.Location = new System.Drawing.Point(0, 90);
            this.tabControl_patient_info.Name = "tabControl_patient_info";
            this.tabControl_patient_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl_patient_info.RightToLeftLayout = true;
            this.tabControl_patient_info.SelectedIndex = 0;
            this.tabControl_patient_info.Size = new System.Drawing.Size(710, 398);
            this.tabControl_patient_info.TabIndex = 24;
            // 
            // tab_basic_info
            // 
            this.tab_basic_info.BackColor = System.Drawing.Color.Pink;
            this.tab_basic_info.Controls.Add(this.panel4);
            this.tab_basic_info.Controls.Add(this.label7);
            this.tab_basic_info.Controls.Add(this.panel2);
            this.tab_basic_info.Controls.Add(this.panel1);
            this.tab_basic_info.Controls.Add(this.dtb_reg_date);
            this.tab_basic_info.Controls.Add(this.dtp_birth_date);
            this.tab_basic_info.Controls.Add(this.label9);
            this.tab_basic_info.Controls.Add(this.label8);
            this.tab_basic_info.Controls.Add(this.label3);
            this.tab_basic_info.Controls.Add(this.label4);
            this.tab_basic_info.Controls.Add(this.label2);
            this.tab_basic_info.Controls.Add(this.txt_name);
            this.tab_basic_info.Controls.Add(this.label1);
            this.tab_basic_info.Controls.Add(this.txt_id);
            this.tab_basic_info.Location = new System.Drawing.Point(4, 32);
            this.tab_basic_info.Name = "tab_basic_info";
            this.tab_basic_info.Padding = new System.Windows.Forms.Padding(3);
            this.tab_basic_info.Size = new System.Drawing.Size(702, 362);
            this.tab_basic_info.TabIndex = 0;
            this.tab_basic_info.Text = "البيانات الاساسية ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.rdb_doc);
            this.panel4.Controls.Add(this.rdb_nurse);
            this.panel4.Location = new System.Drawing.Point(72, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 53);
            this.panel4.TabIndex = 4;
            // 
            // rdb_doc
            // 
            this.rdb_doc.AutoSize = true;
            this.rdb_doc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_doc.Location = new System.Drawing.Point(99, 12);
            this.rdb_doc.Name = "rdb_doc";
            this.rdb_doc.Size = new System.Drawing.Size(73, 27);
            this.rdb_doc.TabIndex = 3;
            this.rdb_doc.Text = "طبيب";
            this.rdb_doc.UseVisualStyleBackColor = true;
            this.rdb_doc.CheckedChanged += new System.EventHandler(this.rdp_doctor_CheckedChanged);
            // 
            // rdb_nurse
            // 
            this.rdb_nurse.AutoSize = true;
            this.rdb_nurse.Checked = true;
            this.rdb_nurse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_nurse.Location = new System.Drawing.Point(7, 13);
            this.rdb_nurse.Name = "rdb_nurse";
            this.rdb_nurse.Size = new System.Drawing.Size(80, 27);
            this.rdb_nurse.TabIndex = 2;
            this.rdb_nurse.TabStop = true;
            this.rdb_nurse.Text = "ممرض";
            this.rdb_nurse.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "الوظيفة";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.rdb_armal);
            this.panel2.Controls.Add(this.rdb_motalk);
            this.panel2.Controls.Add(this.rdb_mairried);
            this.panel2.Controls.Add(this.rdb_single);
            this.panel2.Location = new System.Drawing.Point(53, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 41);
            this.panel2.TabIndex = 5;
            // 
            // rdb_armal
            // 
            this.rdb_armal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_armal.AutoSize = true;
            this.rdb_armal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_armal.Location = new System.Drawing.Point(55, 7);
            this.rdb_armal.Name = "rdb_armal";
            this.rdb_armal.Size = new System.Drawing.Size(80, 27);
            this.rdb_armal.TabIndex = 8;
            this.rdb_armal.Text = "أرمل/ة";
            this.rdb_armal.UseVisualStyleBackColor = true;
            this.rdb_armal.CheckedChanged += new System.EventHandler(this.rdb_single_CheckedChanged);
            // 
            // rdb_motalk
            // 
            this.rdb_motalk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_motalk.AutoSize = true;
            this.rdb_motalk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_motalk.Location = new System.Drawing.Point(158, 7);
            this.rdb_motalk.Name = "rdb_motalk";
            this.rdb_motalk.Size = new System.Drawing.Size(91, 27);
            this.rdb_motalk.TabIndex = 7;
            this.rdb_motalk.Text = "مطلق/ة";
            this.rdb_motalk.UseVisualStyleBackColor = true;
            this.rdb_motalk.CheckedChanged += new System.EventHandler(this.rdb_single_CheckedChanged);
            // 
            // rdb_mairried
            // 
            this.rdb_mairried.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_mairried.AutoSize = true;
            this.rdb_mairried.Checked = true;
            this.rdb_mairried.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_mairried.Location = new System.Drawing.Point(378, 7);
            this.rdb_mairried.Name = "rdb_mairried";
            this.rdb_mairried.Size = new System.Drawing.Size(89, 27);
            this.rdb_mairried.TabIndex = 5;
            this.rdb_mairried.TabStop = true;
            this.rdb_mairried.Text = "متزوج/ة";
            this.rdb_mairried.UseVisualStyleBackColor = true;
            this.rdb_mairried.CheckedChanged += new System.EventHandler(this.rdb_single_CheckedChanged);
            // 
            // rdb_single
            // 
            this.rdb_single.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_single.AutoSize = true;
            this.rdb_single.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_single.Location = new System.Drawing.Point(272, 7);
            this.rdb_single.Name = "rdb_single";
            this.rdb_single.Size = new System.Drawing.Size(83, 27);
            this.rdb_single.TabIndex = 6;
            this.rdb_single.Text = "أعزب/ة";
            this.rdb_single.UseVisualStyleBackColor = true;
            this.rdb_single.CheckedChanged += new System.EventHandler(this.rdb_single_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.rdb_male);
            this.panel1.Controls.Add(this.rdb_female);
            this.panel1.Location = new System.Drawing.Point(341, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 53);
            this.panel1.TabIndex = 2;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_male.Location = new System.Drawing.Point(125, 13);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(54, 27);
            this.rdb_male.TabIndex = 3;
            this.rdb_male.Text = "ذكر";
            this.rdb_male.UseVisualStyleBackColor = true;
            this.rdb_male.CheckedChanged += new System.EventHandler(this.rdb_female_CheckedChanged);
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Checked = true;
            this.rdb_female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_female.Location = new System.Drawing.Point(19, 13);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(70, 27);
            this.rdb_female.TabIndex = 2;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "أنثى ";
            this.rdb_female.UseVisualStyleBackColor = true;
            this.rdb_female.CheckedChanged += new System.EventHandler(this.rdb_female_CheckedChanged);
            // 
            // dtb_reg_date
            // 
            this.dtb_reg_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_reg_date.Location = new System.Drawing.Point(388, 301);
            this.dtb_reg_date.Name = "dtb_reg_date";
            this.dtb_reg_date.Size = new System.Drawing.Size(137, 30);
            this.dtb_reg_date.TabIndex = 9;
            // 
            // dtp_birth_date
            // 
            this.dtp_birth_date.CustomFormat = "";
            this.dtp_birth_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_birth_date.Location = new System.Drawing.Point(388, 190);
            this.dtp_birth_date.Name = "dtp_birth_date";
            this.dtp_birth_date.Size = new System.Drawing.Size(137, 30);
            this.dtp_birth_date.TabIndex = 4;
            this.dtp_birth_date.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "تاريخ التعين";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "تاريخ الميلاد ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "الجنس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "الحالة الاجتماعية ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم الموظف/ة";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(27, 73);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(498, 30);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "الكود ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(388, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(137, 30);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tab_contact_info
            // 
            this.tab_contact_info.BackColor = System.Drawing.Color.Pink;
            this.tab_contact_info.Controls.Add(this.txt_nat_id);
            this.tab_contact_info.Controls.Add(this.label12);
            this.tab_contact_info.Controls.Add(this.panel3);
            this.tab_contact_info.Controls.Add(this.label11);
            this.tab_contact_info.Controls.Add(this.txt_phone1);
            this.tab_contact_info.Controls.Add(this.txt_address);
            this.tab_contact_info.Controls.Add(this.label10);
            this.tab_contact_info.Controls.Add(this.txt_email);
            this.tab_contact_info.Controls.Add(this.label6);
            this.tab_contact_info.Controls.Add(this.label5);
            this.tab_contact_info.Location = new System.Drawing.Point(4, 32);
            this.tab_contact_info.Name = "tab_contact_info";
            this.tab_contact_info.Size = new System.Drawing.Size(702, 362);
            this.tab_contact_info.TabIndex = 1;
            this.tab_contact_info.Text = "معلومات الاتصال";
            // 
            // txt_nat_id
            // 
            this.txt_nat_id.Location = new System.Drawing.Point(88, 35);
            this.txt_nat_id.MaxLength = 14;
            this.txt_nat_id.Name = "txt_nat_id";
            this.txt_nat_id.Size = new System.Drawing.Size(471, 30);
            this.txt_nat_id.TabIndex = 20;
            this.txt_nat_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nat_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nat_id_KeyPress);
            this.txt_nat_id.Leave += new System.EventHandler(this.txt_nat_id_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(584, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "الرقم القومى";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.rdp_doctor);
            this.panel3.Controls.Add(this.rdb_employee);
            this.panel3.Location = new System.Drawing.Point(373, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 53);
            this.panel3.TabIndex = 17;
            // 
            // rdp_doctor
            // 
            this.rdp_doctor.AutoSize = true;
            this.rdp_doctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdp_doctor.Location = new System.Drawing.Point(95, 13);
            this.rdp_doctor.Name = "rdp_doctor";
            this.rdp_doctor.Size = new System.Drawing.Size(73, 27);
            this.rdp_doctor.TabIndex = 3;
            this.rdp_doctor.Text = "طبيب";
            this.rdp_doctor.UseVisualStyleBackColor = true;
            this.rdp_doctor.CheckedChanged += new System.EventHandler(this.rdp_doctor_CheckedChanged);
            // 
            // rdb_employee
            // 
            this.rdb_employee.AutoSize = true;
            this.rdb_employee.Checked = true;
            this.rdb_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_employee.Location = new System.Drawing.Point(3, 13);
            this.rdb_employee.Name = "rdb_employee";
            this.rdb_employee.Size = new System.Drawing.Size(76, 27);
            this.rdb_employee.TabIndex = 2;
            this.rdb_employee.TabStop = true;
            this.rdb_employee.Text = "موظف";
            this.rdb_employee.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(586, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "نوع الوظيفة ";
            // 
            // txt_phone1
            // 
            this.txt_phone1.Location = new System.Drawing.Point(275, 188);
            this.txt_phone1.MaxLength = 11;
            this.txt_phone1.Name = "txt_phone1";
            this.txt_phone1.Size = new System.Drawing.Size(282, 30);
            this.txt_phone1.TabIndex = 12;
            this.txt_phone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_phone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone1_KeyPress_1);
            this.txt_phone1.Leave += new System.EventHandler(this.txt_phone1_Leave);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(86, 81);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(471, 30);
            this.txt_address.TabIndex = 11;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(630, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "العنوان";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(86, 316);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(471, 30);
            this.txt_email.TabIndex = 14;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "الايميل ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "رقم الهاتف";
            // 
            // add_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 488);
            this.Controls.Add(this.tabControl_patient_info);
            this.Controls.Add(this.toolStrip_controrl);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة موظف جديد ";
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            this.tabControl_patient_info.ResumeLayout(false);
            this.tab_basic_info.ResumeLayout(false);
            this.tab_basic_info.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_contact_info.ResumeLayout(false);
            this.tab_contact_info.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripDropDownButton ts_btn_exit;
        private System.Windows.Forms.TabControl tabControl_patient_info;
        private System.Windows.Forms.TabPage tab_basic_info;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton rdb_armal;
        public System.Windows.Forms.RadioButton rdb_motalk;
        public System.Windows.Forms.RadioButton rdb_mairried;
        public System.Windows.Forms.RadioButton rdb_single;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton rdb_male;
        public System.Windows.Forms.RadioButton rdb_female;
        public System.Windows.Forms.DateTimePicker dtb_reg_date;
        public System.Windows.Forms.DateTimePicker dtp_birth_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TabPage tab_contact_info;
        public System.Windows.Forms.TextBox txt_phone1;
        public System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.RadioButton rdp_doctor;
        public System.Windows.Forms.RadioButton rdb_employee;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_nat_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.RadioButton rdb_doc;
        public System.Windows.Forms.RadioButton rdb_nurse;
    }
}