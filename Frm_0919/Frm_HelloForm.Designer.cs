namespace Frm_0919
{
    partial class Frm_HelloForm
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
            this.Btn_open = new System.Windows.Forms.Button();
            this.Btn_void = new System.Windows.Forms.Button();
            this.Btn_ReturnMethod = new System.Windows.Forms.Button();
            this.Btn_NewClass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_PartialClass = new System.Windows.Forms.Button();
            this.Btn_DialogResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_open
            // 
            this.Btn_open.Location = new System.Drawing.Point(12, 12);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.Size = new System.Drawing.Size(165, 55);
            this.Btn_open.TabIndex = 0;
            this.Btn_open.Text = "OpenFrm_01";
            this.Btn_open.UseVisualStyleBackColor = true;
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // Btn_void
            // 
            this.Btn_void.Location = new System.Drawing.Point(12, 73);
            this.Btn_void.Name = "Btn_void";
            this.Btn_void.Size = new System.Drawing.Size(165, 55);
            this.Btn_void.TabIndex = 1;
            this.Btn_void.Text = "Btn_void";
            this.Btn_void.UseVisualStyleBackColor = true;
            this.Btn_void.Click += new System.EventHandler(this.Btn_void_Click);
            // 
            // Btn_ReturnMethod
            // 
            this.Btn_ReturnMethod.Location = new System.Drawing.Point(12, 134);
            this.Btn_ReturnMethod.Name = "Btn_ReturnMethod";
            this.Btn_ReturnMethod.Size = new System.Drawing.Size(165, 55);
            this.Btn_ReturnMethod.TabIndex = 2;
            this.Btn_ReturnMethod.Text = "Btn_ReturnMethod";
            this.Btn_ReturnMethod.UseVisualStyleBackColor = true;
            this.Btn_ReturnMethod.Click += new System.EventHandler(this.Btn_ReturnMethod_Click);
            // 
            // Btn_NewClass
            // 
            this.Btn_NewClass.Location = new System.Drawing.Point(12, 195);
            this.Btn_NewClass.Name = "Btn_NewClass";
            this.Btn_NewClass.Size = new System.Drawing.Size(165, 55);
            this.Btn_NewClass.TabIndex = 3;
            this.Btn_NewClass.Text = "Btn_NewClass";
            this.Btn_NewClass.UseVisualStyleBackColor = true;
            this.Btn_NewClass.Click += new System.EventHandler(this.Btn_NewClass_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "封裝";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_PartialClass
            // 
            this.Btn_PartialClass.Location = new System.Drawing.Point(12, 317);
            this.Btn_PartialClass.Name = "Btn_PartialClass";
            this.Btn_PartialClass.Size = new System.Drawing.Size(165, 55);
            this.Btn_PartialClass.TabIndex = 5;
            this.Btn_PartialClass.Text = "Btn_PartialClass";
            this.Btn_PartialClass.UseVisualStyleBackColor = true;
            this.Btn_PartialClass.Click += new System.EventHandler(this.Btn_PartialClass_Click);
            // 
            // Btn_DialogResult
            // 
            this.Btn_DialogResult.Location = new System.Drawing.Point(251, 12);
            this.Btn_DialogResult.Name = "Btn_DialogResult";
            this.Btn_DialogResult.Size = new System.Drawing.Size(165, 55);
            this.Btn_DialogResult.TabIndex = 6;
            this.Btn_DialogResult.Text = "DialogResult";
            this.Btn_DialogResult.UseVisualStyleBackColor = true;
            this.Btn_DialogResult.Click += new System.EventHandler(this.Btn_DialogResult_Click);
            // 
            // Frm_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 610);
            this.Controls.Add(this.Btn_DialogResult);
            this.Controls.Add(this.Btn_PartialClass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_NewClass);
            this.Controls.Add(this.Btn_ReturnMethod);
            this.Controls.Add(this.Btn_void);
            this.Controls.Add(this.Btn_open);
            this.Name = "Frm_HelloForm";
            this.Text = "Hello_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_open;
        private System.Windows.Forms.Button Btn_void;
        private System.Windows.Forms.Button Btn_ReturnMethod;
        private System.Windows.Forms.Button Btn_NewClass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_PartialClass;
        private System.Windows.Forms.Button Btn_DialogResult;
    }
}