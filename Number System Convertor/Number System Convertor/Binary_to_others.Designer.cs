namespace Number_System_Convertor
{
    partial class Binary_to_others
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
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Binary Number\r\n";
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblresult.Location = new System.Drawing.Point(15, 76);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(333, 83);
            this.lblresult.TabIndex = 1;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.Control;
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(171, 23);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(177, 20);
            this.txtnum.TabIndex = 2;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(19, 184);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 35);
            this.btnDecimal.TabIndex = 3;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnHex
            // 
            this.btnHex.BackColor = System.Drawing.Color.LawnGreen;
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.Location = new System.Drawing.Point(181, 184);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(95, 35);
            this.btnHex.TabIndex = 4;
            this.btnHex.Text = "HexaDecimal";
            this.btnHex.UseVisualStyleBackColor = false;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.BackColor = System.Drawing.Color.LawnGreen;
            this.btnOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctal.Location = new System.Drawing.Point(100, 184);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(75, 35);
            this.btnOctal.TabIndex = 5;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = false;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.LawnGreen;
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.Location = new System.Drawing.Point(282, 184);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(66, 35);
            this.btnmenu.TabIndex = 6;
            this.btnmenu.Text = "Back";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // Binary_to_others
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(360, 263);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Name = "Binary_to_others";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary to Others";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnmenu;
    }
}