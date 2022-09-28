namespace Frm_0919
{
    partial class Frm_01
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_01));
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Btn_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelName.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.labelName.Location = new System.Drawing.Point(548, 492);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(130, 42);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "NAME";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(548, 555);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 34);
            this.txtName.TabIndex = 1;
            // 
            // Btn_play
            // 
            this.Btn_play.BackColor = System.Drawing.Color.Transparent;
            this.Btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_play.BackgroundImage")));
            this.Btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_play.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_play.FlatAppearance.BorderSize = 0;
            this.Btn_play.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_play.Location = new System.Drawing.Point(528, 601);
            this.Btn_play.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_play.Name = "Btn_play";
            this.Btn_play.Size = new System.Drawing.Size(181, 58);
            this.Btn_play.TabIndex = 2;
            this.Btn_play.UseVisualStyleBackColor = false;
            this.Btn_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1175, 671);
            this.Controls.Add(this.Btn_play);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Name = "Frm_01";
            this.Text = "FallGuys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button Btn_play;
    }
}

