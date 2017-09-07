namespace Clinic_Management_System
{
    partial class frm_exposure
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_yes = new System.Windows.Forms.RadioButton();
            this.rdb_no = new System.Windows.Forms.RadioButton();
            this.txt_patName = new System.Windows.Forms.TextBox();
            this.list_personification = new System.Windows.Forms.ListBox();
            this.list_rays = new System.Windows.Forms.ListBox();
            this.list_diagnosis = new System.Windows.Forms.ListBox();
            this.list_drug = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.btn_add = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.dgv_patient = new System.Windows.Forms.DataGridView();
            this.dgv_drug = new System.Windows.Forms.DataGridView();
            this.dgv_diagnosis = new System.Windows.Forms.DataGridView();
            this.dgv_rays = new System.Windows.Forms.DataGridView();
            this.dgv_personification = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip_controrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personification)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1255, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المريضة";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "قبول المريضة";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "الاشعة المطلوبة ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "التحاليل";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1134, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "التشخيص";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.rdb_yes);
            this.panel1.Controls.Add(this.rdb_no);
            this.panel1.Location = new System.Drawing.Point(510, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 46);
            this.panel1.TabIndex = 6;
            // 
            // rdb_yes
            // 
            this.rdb_yes.AutoSize = true;
            this.rdb_yes.Checked = true;
            this.rdb_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_yes.Location = new System.Drawing.Point(127, 9);
            this.rdb_yes.Name = "rdb_yes";
            this.rdb_yes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb_yes.Size = new System.Drawing.Size(46, 28);
            this.rdb_yes.TabIndex = 3;
            this.rdb_yes.TabStop = true;
            this.rdb_yes.Text = "نعم";
            this.rdb_yes.UseVisualStyleBackColor = true;
            this.rdb_yes.CheckedChanged += new System.EventHandler(this.rdb_yes_CheckedChanged);
            // 
            // rdb_no
            // 
            this.rdb_no.AutoSize = true;
            this.rdb_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_no.Location = new System.Drawing.Point(21, 9);
            this.rdb_no.Name = "rdb_no";
            this.rdb_no.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb_no.Size = new System.Drawing.Size(38, 28);
            this.rdb_no.TabIndex = 2;
            this.rdb_no.Text = "لا";
            this.rdb_no.UseVisualStyleBackColor = true;
            this.rdb_no.CheckedChanged += new System.EventHandler(this.rdb_yes_CheckedChanged);
            // 
            // txt_patName
            // 
            this.txt_patName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_patName.Enabled = false;
            this.txt_patName.Location = new System.Drawing.Point(875, 166);
            this.txt_patName.Name = "txt_patName";
            this.txt_patName.Size = new System.Drawing.Size(374, 29);
            this.txt_patName.TabIndex = 7;
            // 
            // list_personification
            // 
            this.list_personification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.list_personification.FormattingEnabled = true;
            this.list_personification.ItemHeight = 24;
            this.list_personification.Location = new System.Drawing.Point(1032, 504);
            this.list_personification.Name = "list_personification";
            this.list_personification.Size = new System.Drawing.Size(310, 172);
            this.list_personification.TabIndex = 8;
            this.list_personification.DoubleClick += new System.EventHandler(this.list_personification_DoubleClick);
            // 
            // list_rays
            // 
            this.list_rays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.list_rays.FormattingEnabled = true;
            this.list_rays.ItemHeight = 24;
            this.list_rays.Location = new System.Drawing.Point(692, 504);
            this.list_rays.Name = "list_rays";
            this.list_rays.Size = new System.Drawing.Size(310, 172);
            this.list_rays.TabIndex = 10;
            this.list_rays.DoubleClick += new System.EventHandler(this.list_rays_DoubleClick);
            // 
            // list_diagnosis
            // 
            this.list_diagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.list_diagnosis.FormattingEnabled = true;
            this.list_diagnosis.ItemHeight = 24;
            this.list_diagnosis.Location = new System.Drawing.Point(352, 504);
            this.list_diagnosis.Name = "list_diagnosis";
            this.list_diagnosis.Size = new System.Drawing.Size(310, 172);
            this.list_diagnosis.TabIndex = 12;
            this.list_diagnosis.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            this.list_diagnosis.DoubleClick += new System.EventHandler(this.list_diagnosis_DoubleClick);
            // 
            // list_drug
            // 
            this.list_drug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.list_drug.FormattingEnabled = true;
            this.list_drug.ItemHeight = 24;
            this.list_drug.Location = new System.Drawing.Point(12, 504);
            this.list_drug.Name = "list_drug";
            this.list_drug.Size = new System.Drawing.Size(310, 172);
            this.list_drug.TabIndex = 15;
            this.list_drug.DoubleClick += new System.EventHandler(this.list_drug_DoubleClick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "الادوية";
            // 
            // toolStrip_controrl
            // 
            this.toolStrip_controrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip_controrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.toolStripSeparator3,
            this.btn_exit});
            this.toolStrip_controrl.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controrl.Name = "toolStrip_controrl";
            this.toolStrip_controrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip_controrl.Size = new System.Drawing.Size(1354, 90);
            this.toolStrip_controrl.TabIndex = 22;
            this.toolStrip_controrl.Text = "toolStrip1";
            // 
            // btn_add
            // 
            this.btn_add.Image = global::Clinic_Management_System.Properties.Resources.save_64;
            this.btn_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_add.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_add.Name = "btn_add";
            this.btn_add.ShowDropDownArrow = false;
            this.btn_add.Size = new System.Drawing.Size(68, 87);
            this.btn_add.Text = "حفظ";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 90);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Clinic_Management_System.Properties.Resources.Cancel_64;
            this.btn_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_exit.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShowDropDownArrow = false;
            this.btn_exit.Size = new System.Drawing.Size(68, 87);
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgv_patient
            // 
            this.dgv_patient.AllowUserToAddRows = false;
            this.dgv_patient.AllowUserToDeleteRows = false;
            this.dgv_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_patient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_patient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_patient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_patient.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_patient.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_patient.Location = new System.Drawing.Point(12, 97);
            this.dgv_patient.MultiSelect = false;
            this.dgv_patient.Name = "dgv_patient";
            this.dgv_patient.ReadOnly = true;
            this.dgv_patient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_patient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patient.Size = new System.Drawing.Size(408, 155);
            this.dgv_patient.TabIndex = 23;
            this.dgv_patient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patient_CellDoubleClick);
            // 
            // dgv_drug
            // 
            this.dgv_drug.AllowUserToAddRows = false;
            this.dgv_drug.AllowUserToDeleteRows = false;
            this.dgv_drug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_drug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_drug.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_drug.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_drug.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_drug.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_drug.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_drug.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_drug.Location = new System.Drawing.Point(12, 317);
            this.dgv_drug.MultiSelect = false;
            this.dgv_drug.Name = "dgv_drug";
            this.dgv_drug.ReadOnly = true;
            this.dgv_drug.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_drug.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_drug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_drug.Size = new System.Drawing.Size(310, 181);
            this.dgv_drug.TabIndex = 24;
            this.dgv_drug.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_drug_CellContentDoubleClick);
            // 
            // dgv_diagnosis
            // 
            this.dgv_diagnosis.AllowUserToAddRows = false;
            this.dgv_diagnosis.AllowUserToDeleteRows = false;
            this.dgv_diagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_diagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_diagnosis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_diagnosis.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_diagnosis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_diagnosis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_diagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_diagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_diagnosis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_diagnosis.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_diagnosis.Location = new System.Drawing.Point(352, 317);
            this.dgv_diagnosis.MultiSelect = false;
            this.dgv_diagnosis.Name = "dgv_diagnosis";
            this.dgv_diagnosis.ReadOnly = true;
            this.dgv_diagnosis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_diagnosis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_diagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_diagnosis.Size = new System.Drawing.Size(310, 181);
            this.dgv_diagnosis.TabIndex = 25;
            this.dgv_diagnosis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diagnosis_CellContentDoubleClick);
            // 
            // dgv_rays
            // 
            this.dgv_rays.AllowUserToAddRows = false;
            this.dgv_rays.AllowUserToDeleteRows = false;
            this.dgv_rays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_rays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rays.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_rays.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_rays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_rays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_rays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_rays.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_rays.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_rays.Location = new System.Drawing.Point(692, 317);
            this.dgv_rays.MultiSelect = false;
            this.dgv_rays.Name = "dgv_rays";
            this.dgv_rays.ReadOnly = true;
            this.dgv_rays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_rays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_rays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rays.Size = new System.Drawing.Size(310, 181);
            this.dgv_rays.TabIndex = 26;
            this.dgv_rays.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rays_CellContentDoubleClick);
            // 
            // dgv_personification
            // 
            this.dgv_personification.AllowUserToAddRows = false;
            this.dgv_personification.AllowUserToDeleteRows = false;
            this.dgv_personification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_personification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_personification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_personification.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_personification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_personification.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_personification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_personification.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_personification.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_personification.Location = new System.Drawing.Point(1032, 317);
            this.dgv_personification.MultiSelect = false;
            this.dgv_personification.Name = "dgv_personification";
            this.dgv_personification.ReadOnly = true;
            this.dgv_personification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_personification.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_personification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_personification.Size = new System.Drawing.Size(310, 181);
            this.dgv_personification.TabIndex = 27;
            this.dgv_personification.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_personification_CellContentDoubleClick);
            // 
            // frm_exposure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 682);
            this.Controls.Add(this.dgv_personification);
            this.Controls.Add(this.dgv_rays);
            this.Controls.Add(this.dgv_diagnosis);
            this.Controls.Add(this.dgv_drug);
            this.Controls.Add(this.dgv_patient);
            this.Controls.Add(this.toolStrip_controrl);
            this.Controls.Add(this.list_drug);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_diagnosis);
            this.Controls.Add(this.list_rays);
            this.Controls.Add(this.list_personification);
            this.Controls.Add(this.txt_patName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_exposure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الكشف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_exposure_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton rdb_yes;
        public System.Windows.Forms.RadioButton rdb_no;
        private System.Windows.Forms.TextBox txt_patName;
        private System.Windows.Forms.ListBox list_personification;
        private System.Windows.Forms.ListBox list_rays;
        private System.Windows.Forms.ListBox list_diagnosis;
        private System.Windows.Forms.ListBox list_drug;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton btn_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripDropDownButton btn_exit;
        private System.Windows.Forms.DataGridView dgv_patient;
        private System.Windows.Forms.DataGridView dgv_drug;
        private System.Windows.Forms.DataGridView dgv_diagnosis;
        private System.Windows.Forms.DataGridView dgv_rays;
        private System.Windows.Forms.DataGridView dgv_personification;
    }
}