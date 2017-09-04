namespace Clinic_Management_System
{
    partial class frm_invatory_Add
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.nud_sellprice = new System.Windows.Forms.NumericUpDown();
            this.txt_functions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_invatory = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.num_buyPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sellprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invatory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_buyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 100);
            this.panel1.TabIndex = 28;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_add.Image = global::Clinic_Management_System.Properties.Resources.save_64;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(814, 3);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 95);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "حفظ";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Image = global::Clinic_Management_System.Properties.Resources.Cancel_64;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_exit.Location = new System.Drawing.Point(629, 5);
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
            this.btn_delete.Location = new System.Drawing.Point(721, 3);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 95);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = " حذف";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // nud_sellprice
            // 
            this.nud_sellprice.DecimalPlaces = 2;
            this.nud_sellprice.Location = new System.Drawing.Point(489, 151);
            this.nud_sellprice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_sellprice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_sellprice.Name = "nud_sellprice";
            this.nud_sellprice.Size = new System.Drawing.Size(297, 30);
            this.nud_sellprice.TabIndex = 35;
            this.nud_sellprice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_functions
            // 
            this.txt_functions.Location = new System.Drawing.Point(489, 216);
            this.txt_functions.Multiline = true;
            this.txt_functions.Name = "txt_functions";
            this.txt_functions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_functions.Size = new System.Drawing.Size(297, 63);
            this.txt_functions.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "سعر البيع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "الوظيفة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "اسم العنصر";
            // 
            // dgv_invatory
            // 
            this.dgv_invatory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_invatory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_invatory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_invatory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_invatory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invatory.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_invatory.Location = new System.Drawing.Point(0, 293);
            this.dgv_invatory.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_invatory.Name = "dgv_invatory";
            this.dgv_invatory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_invatory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_invatory.Size = new System.Drawing.Size(901, 320);
            this.dgv_invatory.TabIndex = 29;
            this.dgv_invatory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_expenses_CellDoubleClick);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(489, 106);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(297, 30);
            this.txt_name.TabIndex = 39;
            // 
            // num_buyPrice
            // 
            this.num_buyPrice.DecimalPlaces = 2;
            this.num_buyPrice.Location = new System.Drawing.Point(56, 158);
            this.num_buyPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_buyPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_buyPrice.Name = "num_buyPrice";
            this.num_buyPrice.Size = new System.Drawing.Size(297, 30);
            this.num_buyPrice.TabIndex = 41;
            this.num_buyPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "سعر الشراء";
            // 
            // num_quantity
            // 
            this.num_quantity.Location = new System.Drawing.Point(56, 107);
            this.num_quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(297, 30);
            this.num_quantity.TabIndex = 43;
            this.num_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "الكمية";
            // 
            // frm_invatory_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 598);
            this.Controls.Add(this.num_quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_buyPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nud_sellprice);
            this.Controls.Add(this.txt_functions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_invatory);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_invatory_Add";
            this.Text = "المخزن";
            this.Load += new System.EventHandler(this.frm_inventoery_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_sellprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invatory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_buyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_invatory;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.NumericUpDown nud_sellprice;
        public System.Windows.Forms.TextBox txt_functions;
        public System.Windows.Forms.NumericUpDown num_buyPrice;
        public System.Windows.Forms.NumericUpDown num_quantity;

    }
}