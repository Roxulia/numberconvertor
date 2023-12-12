namespace Number_System_Convertor
{
    partial class Octal_to_others
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Octal Number";
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(15, 63);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(333, 102);
            this.lblresult.TabIndex = 1;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinary.Location = new System.Drawing.Point(15, 185);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(75, 41);
            this.btnBinary.TabIndex = 3;
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnHexa
            // 
            this.btnHexa.BackColor = System.Drawing.Color.LawnGreen;
            this.btnHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHexa.Location = new System.Drawing.Point(96, 185);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(90, 41);
            this.btnHexa.TabIndex = 4;
            this.btnHexa.Text = "HexaDecimal";
            this.btnHexa.UseVisualStyleBackColor = false;
            this.btnHexa.Click += new System.EventHandler(this.btnHexa_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(192, 185);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 41);
            this.btnDecimal.TabIndex = 5;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.LawnGreen;
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.Location = new System.Drawing.Point(273, 185);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(75, 41);
            this.btnmenu.TabIndex = 6;
            this.btnmenu.Text = "Back";
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // Octal_to_others
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(360, 263);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnHexa);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Name = "Octal_to_others";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Octal to Others";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnmenu;
    }
}