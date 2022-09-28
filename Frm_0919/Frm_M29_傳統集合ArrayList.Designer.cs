namespace Frm_0919
{
    partial class Frm_M29_傳統集合ArrayList
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
            this.Btn_Add = new System.Windows.Forms.Button();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Show = new System.Windows.Forms.Label();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_RemoveAt = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Dif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "產品名稱:";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(31, 202);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(114, 51);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ProductName.Location = new System.Drawing.Point(122, 94);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(147, 33);
            this.txt_ProductName.TabIndex = 2;
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ProductPrice.Location = new System.Drawing.Point(122, 140);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(147, 33);
            this.txt_ProductPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "產品單價:";
            // 
            // lab_Show
            // 
            this.lab_Show.AutoSize = true;
            this.lab_Show.BackColor = System.Drawing.Color.MistyRose;
            this.lab_Show.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Show.ForeColor = System.Drawing.Color.IndianRed;
            this.lab_Show.Location = new System.Drawing.Point(319, 21);
            this.lab_Show.Name = "lab_Show";
            this.lab_Show.Size = new System.Drawing.Size(48, 24);
            this.lab_Show.TabIndex = 5;
            this.lab_Show.Text = "產品";
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Location = new System.Drawing.Point(155, 202);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(114, 51);
            this.Btn_Insert.TabIndex = 6;
            this.Btn_Insert.Text = "Insert";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_RemoveAt
            // 
            this.Btn_RemoveAt.Location = new System.Drawing.Point(31, 277);
            this.Btn_RemoveAt.Name = "Btn_RemoveAt";
            this.Btn_RemoveAt.Size = new System.Drawing.Size(114, 51);
            this.Btn_RemoveAt.TabIndex = 6;
            this.Btn_RemoveAt.Text = "RemoveAt";
            this.Btn_RemoveAt.UseVisualStyleBackColor = true;
            this.Btn_RemoveAt.Click += new System.EventHandler(this.Btn_RemoveAt_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(155, 277);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(114, 51);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Dif
            // 
            this.Btn_Dif.Location = new System.Drawing.Point(31, 345);
            this.Btn_Dif.Name = "Btn_Dif";
            this.Btn_Dif.Size = new System.Drawing.Size(114, 51);
            this.Btn_Dif.TabIndex = 7;
            this.Btn_Dif.Text = "不同資料型態";
            this.Btn_Dif.UseVisualStyleBackColor = true;
            this.Btn_Dif.Click += new System.EventHandler(this.Btn_Dif_Click);
            // 
            // Frm_M29_傳統集合ArrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Dif);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_RemoveAt);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.lab_Show);
            this.Controls.Add(this.txt_ProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label1);
            this.Name = "Frm_M29_傳統集合ArrayList";
            this.Text = "Frm_M29_傳統集合";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Show;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_RemoveAt;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Dif;
    }
}