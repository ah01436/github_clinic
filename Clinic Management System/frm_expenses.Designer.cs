namespace Clinic_Management_System
{
    partial class frm_Add
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_expenses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.add_item = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_buy = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 100);
            this.panel1.TabIndex = 17;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Image = global::Clinic_Management_System.Properties.Resources.Cancel_64;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_exit.Location = new System.Drawing.Point(637, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 95);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = " الغاء";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Image = global::Clinic_Management_System.Properties.Resources._1_04_64;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(725, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 95);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = " حذف";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Image = global::Clinic_Management_System.Properties.Resources.save_64;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(813, 0);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 95);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_expenses
            // 
            this.dgv_expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_expenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_expenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_expenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_expenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expenses.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_expenses.Location = new System.Drawing.Point(0, 307);
            this.dgv_expenses.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_expenses.Name = "dgv_expenses";
            this.dgv_expenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_expenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_expenses.Size = new System.Drawing.Size(901, 320);
            this.dgv_expenses.TabIndex = 18;
            this.dgv_expenses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_expenses_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "اسم العنصر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "ملاحظات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "السعر";
            // 
            // cmb_items
            // 
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.Location = new System.Drawing.Point(409, 113);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.Size = new System.Drawing.Size(374, 31);
            this.cmb_items.TabIndex = 22;
            this.cmb_items.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(409, 159);
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(374, 30);
            this.txt_Notes.TabIndex = 23;
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Location = new System.Drawing.Point(409, 259);
            this.nud_price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(374, 30);
            this.nud_price.TabIndex = 24;
            this.nud_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_item
            // 
            this.add_item.Image = global::Clinic_Management_System.Properties.Resources.if_plus_1646001;
            this.add_item.Location = new System.Drawing.Point(336, 110);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(53, 38);
            this.add_item.TabIndex = 25;
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(817, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "التاريخ";
            // 
            // dtp_buy
            // 
            this.dtp_buy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_buy.Location = new System.Drawing.Point(409, 208);
            this.dtp_buy.Name = "dtp_buy";
            this.dtp_buy.Size = new System.Drawing.Size(377, 30);
            this.dtp_buy.TabIndex = 27;
            // 
            // frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 598);
            this.Controls.Add(this.dtp_buy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.nud_price);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.cmb_items);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_expenses);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Add";
            this.Text = "المصروفات";
            this.Load += new System.EventHandler(this.frm_expenses_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_expenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_items;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtp_buy;
    }
}