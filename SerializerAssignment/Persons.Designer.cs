namespace SerializerAssignment
{
    partial class Persons
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.goToFirstBtn = new System.Windows.Forms.Button();
            this.goToLastBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(42, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(268, 20);
            this.nameBox.TabIndex = 0;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(42, 104);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(268, 20);
            this.addressBox.TabIndex = 1;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(42, 172);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(268, 20);
            this.phoneBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(42, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(42, 88);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(42, 156);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Phone:";
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(42, 229);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 23);
            this.prevBtn.TabIndex = 6;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(139, 229);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(235, 229);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // goToFirstBtn
            // 
            this.goToFirstBtn.Location = new System.Drawing.Point(42, 280);
            this.goToFirstBtn.Name = "goToFirstBtn";
            this.goToFirstBtn.Size = new System.Drawing.Size(75, 23);
            this.goToFirstBtn.TabIndex = 9;
            this.goToFirstBtn.Text = "First";
            this.goToFirstBtn.UseVisualStyleBackColor = true;
            this.goToFirstBtn.Click += new System.EventHandler(this.goToFirstBtn_Click);
            // 
            // goToLastBtn
            // 
            this.goToLastBtn.Location = new System.Drawing.Point(139, 280);
            this.goToLastBtn.Name = "goToLastBtn";
            this.goToLastBtn.Size = new System.Drawing.Size(75, 23);
            this.goToLastBtn.TabIndex = 10;
            this.goToLastBtn.Text = "Last";
            this.goToLastBtn.UseVisualStyleBackColor = true;
            this.goToLastBtn.Click += new System.EventHandler(this.goToLastBtn_Click);
            // 
            // Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 337);
            this.Controls.Add(this.goToLastBtn);
            this.Controls.Add(this.goToFirstBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Persons";
            this.Text = "Persons";
            this.Load += new System.EventHandler(this.Persons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button goToFirstBtn;
        private System.Windows.Forms.Button goToLastBtn;
    }
}

