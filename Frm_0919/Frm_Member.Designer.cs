namespace Frm_0919
{
    partial class Frm_Member
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
            this.Btn_Member = new System.Windows.Forms.Button();
            this.Btn_RegisterEvent = new System.Windows.Forms.Button();
            this.Btn_RegisterEvent01 = new System.Windows.Forms.Button();
            this.Btn_RegisterEvent02 = new System.Windows.Forms.Button();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.Btn_sure = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_SetProperty = new System.Windows.Forms.Button();
            this.Btn_GetProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Member
            // 
            this.Btn_Member.Location = new System.Drawing.Point(629, 31);
            this.Btn_Member.Name = "Btn_Member";
            this.Btn_Member.Size = new System.Drawing.Size(176, 53);
            this.Btn_Member.TabIndex = 0;
            this.Btn_Member.Text = "Btn_Member";
            this.Btn_Member.UseVisualStyleBackColor = true;
            this.Btn_Member.Click += new System.EventHandler(this.Btn_Member_Click);
            // 
            // Btn_RegisterEvent
            // 
            this.Btn_RegisterEvent.Location = new System.Drawing.Point(12, 38);
            this.Btn_RegisterEvent.Name = "Btn_RegisterEvent";
            this.Btn_RegisterEvent.Size = new System.Drawing.Size(127, 46);
            this.Btn_RegisterEvent.TabIndex = 1;
            this.Btn_RegisterEvent.Text = "註冊事件";
            this.Btn_RegisterEvent.UseVisualStyleBackColor = true;
            this.Btn_RegisterEvent.Click += new System.EventHandler(this.Btn_RegisterEvent_Click);
            // 
            // Btn_RegisterEvent01
            // 
            this.Btn_RegisterEvent01.Location = new System.Drawing.Point(12, 101);
            this.Btn_RegisterEvent01.Name = "Btn_RegisterEvent01";
            this.Btn_RegisterEvent01.Size = new System.Drawing.Size(127, 46);
            this.Btn_RegisterEvent01.TabIndex = 2;
            this.Btn_RegisterEvent01.Text = "註冊事件01";
            this.Btn_RegisterEvent01.UseVisualStyleBackColor = true;
            // 
            // Btn_RegisterEvent02
            // 
            this.Btn_RegisterEvent02.Location = new System.Drawing.Point(12, 164);
            this.Btn_RegisterEvent02.Name = "Btn_RegisterEvent02";
            this.Btn_RegisterEvent02.Size = new System.Drawing.Size(127, 46);
            this.Btn_RegisterEvent02.TabIndex = 3;
            this.Btn_RegisterEvent02.Text = "註冊事件02";
            this.Btn_RegisterEvent02.UseVisualStyleBackColor = true;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Location = new System.Drawing.Point(326, 152);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(112, 20);
            this.cmbDiscount.TabIndex = 4;
            // 
            // txt_payment
            // 
            this.txt_payment.Location = new System.Drawing.Point(326, 115);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(112, 22);
            this.txt_payment.TabIndex = 5;
            // 
            // Btn_sure
            // 
            this.Btn_sure.Location = new System.Drawing.Point(326, 187);
            this.Btn_sure.Name = "Btn_sure";
            this.Btn_sure.Size = new System.Drawing.Size(112, 35);
            this.Btn_sure.TabIndex = 6;
            this.Btn_sure.Text = "計算";
            this.Btn_sure.UseVisualStyleBackColor = true;
            this.Btn_sure.Click += new System.EventHandler(this.Btn_sure_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Btn_MessageBox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_SetProperty
            // 
            this.Btn_SetProperty.Location = new System.Drawing.Point(629, 101);
            this.Btn_SetProperty.Name = "Btn_SetProperty";
            this.Btn_SetProperty.Size = new System.Drawing.Size(176, 46);
            this.Btn_SetProperty.TabIndex = 8;
            this.Btn_SetProperty.Text = "Set Property";
            this.Btn_SetProperty.UseVisualStyleBackColor = true;
            this.Btn_SetProperty.Click += new System.EventHandler(this.Btn_SetProperty_Click);
            // 
            // Btn_GetProperty
            // 
            this.Btn_GetProperty.Location = new System.Drawing.Point(629, 164);
            this.Btn_GetProperty.Name = "Btn_GetProperty";
            this.Btn_GetProperty.Size = new System.Drawing.Size(176, 46);
            this.Btn_GetProperty.TabIndex = 9;
            this.Btn_GetProperty.Text = "Get Property";
            this.Btn_GetProperty.UseVisualStyleBackColor = true;
            this.Btn_GetProperty.Click += new System.EventHandler(this.Btn_GetProperty_Click);
            // 
            // Frm_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 471);
            this.Controls.Add(this.Btn_GetProperty);
            this.Controls.Add(this.Btn_SetProperty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_sure);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.Btn_RegisterEvent02);
            this.Controls.Add(this.Btn_RegisterEvent01);
            this.Controls.Add(this.Btn_RegisterEvent);
            this.Controls.Add(this.Btn_Member);
            this.Name = "Frm_Member";
            this.Text = "Frm_Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Member;
        private System.Windows.Forms.Button Btn_RegisterEvent;
        private System.Windows.Forms.Button Btn_RegisterEvent01;
        private System.Windows.Forms.Button Btn_RegisterEvent02;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.Button Btn_sure;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_SetProperty;
        private System.Windows.Forms.Button Btn_GetProperty;
    }
}