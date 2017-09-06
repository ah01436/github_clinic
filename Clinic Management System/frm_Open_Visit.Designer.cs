namespace Clinic_Management_System
{
    partial class frm_Open_Visit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pat_name = new System.Windows.Forms.TextBox();
            this.toolStrip_controrl = new System.Windows.Forms.ToolStrip();
            this.btn_save = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_delete = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_doc = new System.Windows.Forms.ComboBox();
            this.add_item = new System.Windows.Forms.Button();
            this.cmb_visit_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_visits = new System.Windows.Forms.DataGridView();
            this.toolStrip_controrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visits)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 130);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المريض";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 242);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "الدكتور المعالج";
            // 
            // txt_pat_name
            // 
            this.txt_pat_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pat_name.Enabled = false;
            this.txt_pat_name.Location = new System.Drawing.Point(394, 130);
            this.txt_pat_name.Name = "txt_pat_name";
            this.txt_pat_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pat_name.Size = new System.Drawing.Size(322, 29);
            this.txt_pat_name.TabIndex = 4;
            this.txt_pat_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip_controrl
            // 
            this.toolStrip_controrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip_controrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_save,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.btn_delete,
            this.toolStripSeparator3,
            this.btn_exit});
            this.toolStrip_controrl.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_controrl.Name = "toolStrip_controrl";
            this.toolStrip_controrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip_controrl.Size = new System.Drawing.Size(904, 90);
            this.toolStrip_controrl.TabIndex = 22;
            this.toolStrip_controrl.Text = "toolStrip1";
            this.toolStrip_controrl.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_controrl_ItemClicked);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::Clinic_Management_System.Properties.Resources.save_64;
            this.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowDropDownArrow = false;
            this.btn_save.Size = new System.Drawing.Size(68, 87);
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_save.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 90);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 90);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::Clinic_Management_System.Properties.Resources._1_04_64;
            this.btn_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowDropDownArrow = false;
            this.btn_delete.Size = new System.Drawing.Size(68, 87);
            this.btn_delete.Text = "حذف ";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::Clinic_Management_System.Properties.Resources.search32;
            this.button1.Location = new System.Drawing.Point(748, 130);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(53, 38);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_doc
            // 
            this.cmb_doc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_doc.FormattingEnabled = true;
            this.cmb_doc.Location = new System.Drawing.Point(394, 239);
            this.cmb_doc.Name = "cmb_doc";
            this.cmb_doc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_doc.Size = new System.Drawing.Size(322, 32);
            this.cmb_doc.TabIndex = 28;
            // 
            // add_item
            // 
            this.add_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_item.Image = global::Clinic_Management_System.Properties.Resources.if_plus_1646001;
            this.add_item.Location = new System.Drawing.Point(748, 186);
            this.add_item.Name = "add_item";
            this.add_item.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_item.Size = new System.Drawing.Size(53, 38);
            this.add_item.TabIndex = 31;
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // cmb_visit_type
            // 
            this.cmb_visit_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_visit_type.FormattingEnabled = true;
            this.cmb_visit_type.Location = new System.Drawing.Point(394, 190);
            this.cmb_visit_type.Name = "cmb_visit_type";
            this.cmb_visit_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_visit_type.Size = new System.Drawing.Size(322, 32);
            this.cmb_visit_type.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(814, 190);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "نوع الزيارة";
            // 
            // dgv_visits
            // 
            this.dgv_visits.AllowUserToAddRows = false;
            this.dgv_visits.AllowUserToDeleteRows = false;
            this.dgv_visits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_visits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_visits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_visits.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_visits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_visits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_visits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_visits.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_visits.Location = new System.Drawing.Point(0, 277);
            this.dgv_visits.MultiSelect = false;
            this.dgv_visits.Name = "dgv_visits";
            this.dgv_visits.ReadOnly = true;
            this.dgv_visits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_visits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_visits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_visits.Size = new System.Drawing.Size(904, 309);
            this.dgv_visits.TabIndex = 32;
            // 
            // frm_Open_Visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 583);
            this.Controls.Add(this.dgv_visits);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.cmb_visit_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_doc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip_controrl);
            this.Controls.Add(this.txt_pat_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_Open_Visit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فتح زيارة لمريض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Open_Visit_Load);
            this.toolStrip_controrl.ResumeLayout(false);
            this.toolStrip_controrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pat_name;
        private System.Windows.Forms.ToolStrip toolStrip_controrl;
        public System.Windows.Forms.ToolStripDropDownButton btn_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripDropDownButton btn_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripDropDownButton btn_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_doc;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.ComboBox cmb_visit_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_visits;
    }
}