namespace ThaoTacTapTin
{
    partial class frmMain
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.btnWriteXML = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSerializeXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDocFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocFile.Location = new System.Drawing.Point(12, 12);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(124, 32);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc File Json";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnReadXML
            // 
            this.btnReadXML.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadXML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReadXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadXML.Location = new System.Drawing.Point(12, 73);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(124, 32);
            this.btnReadXML.TabIndex = 0;
            this.btnReadXML.Text = "Đọc File XML";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // btnWriteXML
            // 
            this.btnWriteXML.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteXML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWriteXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteXML.Location = new System.Drawing.Point(182, 73);
            this.btnWriteXML.Name = "btnWriteXML";
            this.btnWriteXML.Size = new System.Drawing.Size(124, 32);
            this.btnWriteXML.TabIndex = 0;
            this.btnWriteXML.Text = "Ghi File XML";
            this.btnWriteXML.UseVisualStyleBackColor = true;
            this.btnWriteXML.Click += new System.EventHandler(this.btnWriteXML_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(182, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ghi File Json";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSerializeXML
            // 
            this.btnSerializeXML.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializeXML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerializeXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerializeXML.Location = new System.Drawing.Point(182, 111);
            this.btnSerializeXML.Name = "btnSerializeXML";
            this.btnSerializeXML.Size = new System.Drawing.Size(202, 32);
            this.btnSerializeXML.TabIndex = 0;
            this.btnSerializeXML.Text = "Ghi XML bằng XmlSerializer";
            this.btnSerializeXML.UseVisualStyleBackColor = true;
            this.btnSerializeXML.Click += new System.EventHandler(this.btnSerializeXML_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWriteXML);
            this.Controls.Add(this.btnSerializeXML);
            this.Controls.Add(this.btnReadXML);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDocFile);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.Button btnWriteXML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSerializeXML;
    }
}

