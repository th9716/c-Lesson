namespace Frm_0919
{
    partial class Frm_M32_String
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labTime2 = new System.Windows.Forms.Label();
            this.labTime3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.timerPassword = new System.Windows.Forms.Timer(this.components);
            this.timerID = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "String";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 57);
            this.button2.TabIndex = 0;
            this.button2.Text = "StringBuilder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 57);
            this.button3.TabIndex = 0;
            this.button3.Text = "Path";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(12, 429);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(33, 12);
            this.labTime.TabIndex = 1;
            this.labTime.Text = "label1";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labTime2
            // 
            this.labTime2.AutoSize = true;
            this.labTime2.Location = new System.Drawing.Point(12, 405);
            this.labTime2.Name = "labTime2";
            this.labTime2.Size = new System.Drawing.Size(33, 12);
            this.labTime2.TabIndex = 1;
            this.labTime2.Text = "label1";
            // 
            // labTime3
            // 
            this.labTime3.AutoSize = true;
            this.labTime3.Location = new System.Drawing.Point(12, 384);
            this.labTime3.Name = "labTime3";
            this.labTime3.Size = new System.Drawing.Size(33, 12);
            this.labTime3.TabIndex = 1;
            this.labTime3.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(350, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "密碼:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Password.Location = new System.Drawing.Point(420, 63);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(143, 33);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(293, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "身分證字號:";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ID.Location = new System.Drawing.Point(420, 115);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(143, 33);
            this.txt_ID.TabIndex = 3;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPassword.Location = new System.Drawing.Point(580, 72);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(48, 24);
            this.labPassword.TabIndex = 2;
            this.labPassword.Text = "密碼";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labID.Location = new System.Drawing.Point(580, 124);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(105, 24);
            this.labID.TabIndex = 2;
            this.labID.Text = "身分證字號";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(439, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "驗證";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timerPassword
            // 
            this.timerPassword.Tick += new System.EventHandler(this.timerPassword_Tick);
            // 
            // timerID
            // 
            this.timerID.Tick += new System.EventHandler(this.timerID_Tick);
            // 
            // Frm_M32_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labTime3);
            this.Controls.Add(this.labTime2);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_M32_String";
            this.Text = "Frm_M32_String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labTime2;
        private System.Windows.Forms.Label labTime3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timerPassword;
        private System.Windows.Forms.Timer timerID;
    }
}