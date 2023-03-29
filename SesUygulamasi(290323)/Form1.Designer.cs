namespace SesUygulamasi_290323_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNokia = new System.Windows.Forms.Button();
            this.btniphone = new System.Windows.Forms.Button();
            this.btnSamsung = new System.Windows.Forms.Button();
            this.btnTelefon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNokia
            // 
            this.btnNokia.Location = new System.Drawing.Point(121, 46);
            this.btnNokia.Name = "btnNokia";
            this.btnNokia.Size = new System.Drawing.Size(242, 119);
            this.btnNokia.TabIndex = 0;
            this.btnNokia.Text = "NOKIA";
            this.btnNokia.UseVisualStyleBackColor = true;
            this.btnNokia.Click += new System.EventHandler(this.btnNokia_Click);
            // 
            // btniphone
            // 
            this.btniphone.Location = new System.Drawing.Point(121, 205);
            this.btniphone.Name = "btniphone";
            this.btniphone.Size = new System.Drawing.Size(242, 119);
            this.btniphone.TabIndex = 1;
            this.btniphone.Text = "IPHONE";
            this.btniphone.UseVisualStyleBackColor = true;
            this.btniphone.Click += new System.EventHandler(this.btniphone_Click);
            // 
            // btnSamsung
            // 
            this.btnSamsung.Location = new System.Drawing.Point(121, 361);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(242, 119);
            this.btnSamsung.TabIndex = 2;
            this.btnSamsung.Text = "SAMSUNG";
            this.btnSamsung.UseVisualStyleBackColor = true;
            this.btnSamsung.Click += new System.EventHandler(this.btnSamsung_Click);
            // 
            // btnTelefon
            // 
            this.btnTelefon.Location = new System.Drawing.Point(121, 519);
            this.btnTelefon.Name = "btnTelefon";
            this.btnTelefon.Size = new System.Drawing.Size(242, 119);
            this.btnTelefon.TabIndex = 3;
            this.btnTelefon.Text = "TELEFON";
            this.btnTelefon.UseVisualStyleBackColor = true;
            this.btnTelefon.Click += new System.EventHandler(this.btnTelefon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 672);
            this.Controls.Add(this.btnTelefon);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.btniphone);
            this.Controls.Add(this.btnNokia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNokia;
        private Button btniphone;
        private Button btnSamsung;
        private Button btnTelefon;
    }
}