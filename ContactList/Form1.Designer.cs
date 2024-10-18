namespace ContactList
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNBox = new System.Windows.Forms.TextBox();
            this.lastNBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.companyBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Company Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(598, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // firstNBox
            // 
            this.firstNBox.Location = new System.Drawing.Point(80, 123);
            this.firstNBox.Multiline = true;
            this.firstNBox.Name = "firstNBox";
            this.firstNBox.Size = new System.Drawing.Size(161, 47);
            this.firstNBox.TabIndex = 6;
            // 
            // lastNBox
            // 
            this.lastNBox.Location = new System.Drawing.Point(316, 123);
            this.lastNBox.Multiline = true;
            this.lastNBox.Name = "lastNBox";
            this.lastNBox.Size = new System.Drawing.Size(161, 47);
            this.lastNBox.TabIndex = 7;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(557, 123);
            this.mailBox.Multiline = true;
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(161, 47);
            this.mailBox.TabIndex = 8;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(80, 229);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(161, 47);
            this.phoneBox.TabIndex = 9;
            // 
            // companyBox
            // 
            this.companyBox.Location = new System.Drawing.Point(316, 229);
            this.companyBox.Multiline = true;
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(161, 47);
            this.companyBox.TabIndex = 10;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(557, 229);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(161, 47);
            this.addressBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Welcome to CLMS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 93);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(117, 293);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 37);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(274, 293);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 37);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(429, 293);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(96, 37);
            this.viewButton.TabIndex = 16;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(582, 291);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 39);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.companyBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.lastNBox);
            this.Controls.Add(this.firstNBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Contact List Management Studio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstNBox;
        private System.Windows.Forms.TextBox lastNBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox companyBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

