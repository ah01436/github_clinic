﻿namespace Clinic_Management_System
{
    partial class frm_Clinic_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clinic_information));
            this.txt_clinic_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_clinic_address = new System.Windows.Forms.TextBox();
            this.txt_clinic_phone = new System.Windows.Forms.TextBox();
            this.txt_clinic_mobile = new System.Windows.Forms.TextBox();
            this.txt_clinic_fax = new System.Windows.Forms.TextBox();
            this.txt_clinic_website = new System.Windows.Forms.TextBox();
            this.txt_clinic_email = new System.Windows.Forms.TextBox();
            this.txt_clinic_face = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_doctorname = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cancl = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_clinic_name
            // 
            this.txt_clinic_name.Enabled = false;
            this.txt_clinic_name.Location = new System.Drawing.Point(15, 47);
            this.txt_clinic_name.Name = "txt_clinic_name";
            this.txt_clinic_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_clinic_name.Size = new System.Drawing.Size(260, 30);
            this.txt_clinic_name.TabIndex = 0;
            this.txt_clinic_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_clinic_name, "ادخل اسم العيادة");
            this.txt_clinic_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clinic_name_KeyDown);
            this.txt_clinic_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clinic_name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم العيادة/المركز";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "رقم الهاتف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "الموبايل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "الفاكس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "البريد الالكترونى";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "الوقع الالكترونى";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "صفحة الفيس بوك";
            // 
            // txt_clinic_address
            // 
            this.txt_clinic_address.Enabled = false;
            this.txt_clinic_address.Location = new System.Drawing.Point(15, 145);
            this.txt_clinic_address.Name = "txt_clinic_address";
            this.txt_clinic_address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_clinic_address.Size = new System.Drawing.Size(260, 30);
            this.txt_clinic_address.TabIndex = 9;
            this.txt_clinic_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_clinic_address, "ادخل عنوان العيادة");
            this.txt_clinic_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clinic_name_KeyDown);
            this.txt_clinic_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clinic_name_KeyPress);
            // 
            // txt_clinic_phone
            // 
            this.txt_clinic_phone.Enabled = false;
            this.txt_clinic_phone.Location = new System.Drawing.Point(15, 194);
            this.txt_clinic_phone.Name = "txt_clinic_phone";
            this.txt_clinic_phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_clinic_phone.Size = new System.Drawing.Size(260, 30);
            this.txt_clinic_phone.TabIndex = 10;
            this.txt_clinic_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_clinic_phone, "ادخل رقم التليفون الثابت الخاص بالعيادة");
            // 
            // txt_clinic_mobile
            // 
            this.txt_clinic_mobile.Enabled = false;
            this.txt_clinic_mobile.Location = new System.Drawing.Point(15, 243);
            this.txt_clinic_mobile.Name = "txt_clinic_mobile";
            this.txt_clinic_mobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_clinic_mobile.Size = new System.Drawing.Size(260, 30);
            this.txt_clinic_mobile.TabIndex = 11;
            this.txt_clinic_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_clinic_mobile, "ادخل رقم الموبايل الخاص بالعيادة ");
            // 
            // txt_clinic_fax
            // 
            this.txt_clinic_fax.Enabled = false;
            this.txt_clinic_fax.Location = new System.Drawing.Point(15, 292);
            this.txt_clinic_fax.Name = "txt_clinic_fax";
            this.txt_clinic_fax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_clinic_fax.Size = new System.Drawing.Size(260, 30);
            this.txt_clinic_fax.TabIndex = 12;
            this.txt_clinic_fax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_clinic_fax, "اخل رقم الفاكس الخاص بالعيادة ");
            // 
            // txt_clinic_website
            // 
            this.txt_clinic_website.Enabled = false;
            this.txt_clinic_website.Location = new System.Drawing.Point(15, 341);
            this.txt_clinic_website.Name = "txt_clinic_website";
            this.txt_clinic_website.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_clinic_website.Size = new System.Drawing.Size(260, 30);
            this.txt_clinic_website.TabIndex = 13;
            this.txt_clinic_website.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_clinic_website, "ادخل رابط المقع الاكترونى الخاص بالعيادة ان وجد ");
            this.txt_clinic_website.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clinic_name_KeyDown);
            this.txt_clinic_website.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clinic_name_KeyPress);
            // 
            // txt_clinic_email
            // 
            this.txt_clinic_email.Enabled = false;
            this.txt_clinic_email.Location = new System.Drawing.Point(15, 390);
            this.txt_clinic_email.Name = "txt_clinic_email";
            this.txt_clinic_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_clinic_email.Size = new System.Drawing.Size(260, 30);
            this.txt_clinic_email.TabIndex = 14;
            this.txt_clinic_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_clinic_email, "ادخل البريد الالكترونى الخاص بالعيادة ان وجد ");
            this.txt_clinic_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clinic_name_KeyDown);
            this.txt_clinic_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clinic_name_KeyPress);
            // 
            // txt_clinic_face
            // 
            this.txt_clinic_face.Enabled = false;
            this.txt_clinic_face.Location = new System.Drawing.Point(15, 439);
            this.txt_clinic_face.Name = "txt_clinic_face";
            this.txt_clinic_face.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_clinic_face.Size = new System.Drawing.Size(260, 30);
            this.txt_clinic_face.TabIndex = 15;
            this.txt_clinic_face.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_clinic_face, "ادخل رابط صفحة العيادة على الفيس بوك ");
            this.txt_clinic_face.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clinic_name_KeyDown);
            this.txt_clinic_face.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clinic_name_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Image = global::Clinic_Management_System.Properties.Resources.accessories_text_editor_32;
            this.btn_edit.Location = new System.Drawing.Point(232, 486);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 44);
            this.btn_edit.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btn_edit, "تعديل ");
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Enabled = false;
            this.btn_save.Image = global::Clinic_Management_System.Properties.Resources.save_32;
            this.btn_save.Location = new System.Drawing.Point(345, 486);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 44);
            this.btn_save.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btn_save, "حفظ");
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_doctorname
            // 
            this.txt_doctorname.Enabled = false;
            this.txt_doctorname.Location = new System.Drawing.Point(15, 96);
            this.txt_doctorname.Name = "txt_doctorname";
            this.txt_doctorname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_doctorname.Size = new System.Drawing.Size(260, 30);
            this.txt_doctorname.TabIndex = 21;
            this.txt_doctorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_doctorname, "ادخل اسم المشرف على العيادة او المركز ");
            this.txt_doctorname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_clinic_name_KeyDown);
            this.txt_doctorname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clinic_name_KeyPress);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Enabled = false;
            this.btn_clear.Image = global::Clinic_Management_System.Properties.Resources.edit_clear;
            this.btn_clear.Location = new System.Drawing.Point(119, 486);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 44);
            this.btn_clear.TabIndex = 18;
            this.toolTip2.SetToolTip(this.btn_clear, "تفريغ الخانات ");
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 50;
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 50;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ReshowDelay = 10;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancl.Image = global::Clinic_Management_System.Properties.Resources.Close_32x32;
            this.btn_cancl.Location = new System.Drawing.Point(6, 486);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(107, 44);
            this.btn_cancl.TabIndex = 19;
            this.toolTip2.SetToolTip(this.btn_cancl, "إلغاء ");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "بيانات العيادة ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "اسم الدكتور المشرف";
            // 
            // frm_Clinic_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 540);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_doctorname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_clinic_face);
            this.Controls.Add(this.txt_clinic_email);
            this.Controls.Add(this.txt_clinic_website);
            this.Controls.Add(this.txt_clinic_fax);
            this.Controls.Add(this.txt_clinic_mobile);
            this.Controls.Add(this.txt_clinic_phone);
            this.Controls.Add(this.txt_clinic_address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_clinic_name);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Clinic_information";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات العيادة ";
            this.Load += new System.EventHandler(this.frm_Clinic_information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_doctorname;
        public System.Windows.Forms.TextBox txt_clinic_name;
        public System.Windows.Forms.TextBox txt_clinic_address;
        public System.Windows.Forms.TextBox txt_clinic_phone;
        public System.Windows.Forms.TextBox txt_clinic_mobile;
        public System.Windows.Forms.TextBox txt_clinic_fax;
        public System.Windows.Forms.TextBox txt_clinic_website;
        public System.Windows.Forms.TextBox txt_clinic_email;
        public System.Windows.Forms.TextBox txt_clinic_face;
    }
}