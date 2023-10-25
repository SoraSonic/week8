namespace week8
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
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Create_button = new System.Windows.Forms.Button();
            this.Read_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(368, 76);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(100, 20);
            this.ID_textBox.TabIndex = 0;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(368, 135);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 20);
            this.Name_textBox.TabIndex = 1;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(318, 83);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(18, 13);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = "ID";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(318, 142);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(35, 13);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Name";
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(185, 232);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(75, 23);
            this.Create_button.TabIndex = 4;
            this.Create_button.Text = "Create";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(306, 232);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(75, 23);
            this.Read_button.TabIndex = 5;
            this.Read_button.Text = "Read";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(438, 232);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 6;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(562, 232);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 7;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(0, 336);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(817, 97);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 433);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.ListView listView1;
    }
}

