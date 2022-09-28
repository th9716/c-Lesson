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
            // Frm_M32_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}