namespace Turkcell_Ders1
{
    partial class Form4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDizi1 = new System.Windows.Forms.Button();
            this.btnDizi2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(182, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btnDizi1
            // 
            this.btnDizi1.Location = new System.Drawing.Point(371, 61);
            this.btnDizi1.Name = "btnDizi1";
            this.btnDizi1.Size = new System.Drawing.Size(75, 23);
            this.btnDizi1.TabIndex = 1;
            this.btnDizi1.Text = "Dizi 1";
            this.btnDizi1.UseVisualStyleBackColor = true;
            this.btnDizi1.Click += new System.EventHandler(this.btnDizi1_Click);
            // 
            // btnDizi2
            // 
            this.btnDizi2.Location = new System.Drawing.Point(371, 90);
            this.btnDizi2.Name = "btnDizi2";
            this.btnDizi2.Size = new System.Drawing.Size(75, 23);
            this.btnDizi2.TabIndex = 2;
            this.btnDizi2.Text = "Dizi 2";
            this.btnDizi2.UseVisualStyleBackColor = true;
            this.btnDizi2.Click += new System.EventHandler(this.btnDizi2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(164, 186);
            this.listBox2.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 386);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnDizi2);
            this.Controls.Add(this.btnDizi1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDizi1;
        private System.Windows.Forms.Button btnDizi2;
        private System.Windows.Forms.ListBox listBox2;
    }
}