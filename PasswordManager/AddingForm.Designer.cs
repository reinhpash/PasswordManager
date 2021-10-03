
namespace PasswordManager
{
    partial class AddingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.source_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mail_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.password_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.username_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.source_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 197);
            this.panel1.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(224)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(482, 117);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(144, 69);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Add";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(399, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Mail";
            // 
            // mail_textBox
            // 
            this.mail_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            this.mail_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail_textBox.Location = new System.Drawing.Point(399, 78);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(227, 21);
            this.mail_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(270, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_textBox.Location = new System.Drawing.Point(270, 78);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(123, 21);
            this.password_textBox.TabIndex = 4;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // username_textBox
            // 
            this.username_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            this.username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_textBox.Location = new System.Drawing.Point(141, 78);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(123, 21);
            this.username_textBox.TabIndex = 2;
            this.username_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // source_textBox
            // 
            this.source_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            this.source_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.source_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.source_textBox.Location = new System.Drawing.Point(12, 78);
            this.source_textBox.Name = "source_textBox";
            this.source_textBox.Size = new System.Drawing.Size(123, 21);
            this.source_textBox.TabIndex = 0;
            this.source_textBox.TextChanged += new System.EventHandler(this.source_textBox_TextChanged);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 197);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(660, 244);
            this.MinimumSize = new System.Drawing.Size(660, 244);
            this.Name = "AddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.AddingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox source_textBox;
        private System.Windows.Forms.Button SaveButton;
    }
}