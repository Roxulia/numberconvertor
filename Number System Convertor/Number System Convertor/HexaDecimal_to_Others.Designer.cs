namespace Number_System_Convertor
{
    partial class HexaDecimal_to_Others
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
            this.btnbinary = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter HexaDecimal Number";
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(12, 62);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(336, 93);
            this.lblresult.TabIndex = 1;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnbinary
            // 
            this.btnbinary.BackColor = System.Drawing.Color.LawnGreen;
            this.btnbinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbinary.Location = new System.Drawing.Point(12, 187);
            this.btnbinary.Name = "btnbinary";
            this.btnbinary.Size = new System.Drawing.Size(75, 41);
            this.btnbinary.TabIndex = 2;
            this.btnbinary.Text = "Binary";
            this.btnbinary.UseVisualStyleBackColor = false;
            this.btnbinary.Click += new System.EventHandler(this.btnbinary_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(93, 187);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(93, 41);
            this.btnDecimal.TabIndex = 3;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.BackColor = System.Drawing.Color.LawnGreen;
            this.btnOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctal.Location = new System.Drawing.Point(192, 187);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(75, 41);
            this.btnOctal.TabIndex = 4;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = false;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.LawnGreen;
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.Location = new System.Drawing.Point(273, 187);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(75, 41);
            this.btnmenu.TabIndex = 5;
            this.btnmenu.Text = "Back";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(217, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HexaDecimal_to_Others
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(360, 263);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnbinary);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Name = "HexaDecimal_to_Others";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HexaDecimal to Others";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnbinary;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.TextBox textBox1;
    }
}