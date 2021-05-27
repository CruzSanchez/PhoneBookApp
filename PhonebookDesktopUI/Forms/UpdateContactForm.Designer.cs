
namespace PhonebookDesktopUI.Forms
{
    partial class UpdateContactForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdatedDobPicker = new System.Windows.Forms.DateTimePicker();
            this.UpdatedEmailTextbox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.UpdatedNumberTextbox = new System.Windows.Forms.TextBox();
            this.UpdatedNameTextbox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(285, 233);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 27);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdatedDobPicker
            // 
            this.UpdatedDobPicker.Location = new System.Drawing.Point(222, 177);
            this.UpdatedDobPicker.Name = "UpdatedDobPicker";
            this.UpdatedDobPicker.Size = new System.Drawing.Size(200, 23);
            this.UpdatedDobPicker.TabIndex = 16;
            // 
            // UpdatedEmailTextbox
            // 
            this.UpdatedEmailTextbox.Location = new System.Drawing.Point(222, 143);
            this.UpdatedEmailTextbox.Name = "UpdatedEmailTextbox";
            this.UpdatedEmailTextbox.Size = new System.Drawing.Size(200, 23);
            this.UpdatedEmailTextbox.TabIndex = 15;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dobLabel.Location = new System.Drawing.Point(138, 182);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(36, 18);
            this.dobLabel.TabIndex = 14;
            this.dobLabel.Text = "DOB:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(138, 144);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 18);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email:";
            // 
            // UpdatedNumberTextbox
            // 
            this.UpdatedNumberTextbox.Location = new System.Drawing.Point(222, 104);
            this.UpdatedNumberTextbox.Name = "UpdatedNumberTextbox";
            this.UpdatedNumberTextbox.Size = new System.Drawing.Size(200, 23);
            this.UpdatedNumberTextbox.TabIndex = 12;
            // 
            // UpdatedNameTextbox
            // 
            this.UpdatedNameTextbox.Location = new System.Drawing.Point(222, 65);
            this.UpdatedNameTextbox.Name = "UpdatedNameTextbox";
            this.UpdatedNameTextbox.Size = new System.Drawing.Size(200, 23);
            this.UpdatedNameTextbox.TabIndex = 11;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberLabel.Location = new System.Drawing.Point(138, 106);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(58, 18);
            this.numberLabel.TabIndex = 10;
            this.numberLabel.Text = "Number:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(138, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 18);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // UpdateContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(560, 310);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdatedDobPicker);
            this.Controls.Add(this.UpdatedEmailTextbox);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.UpdatedNumberTextbox);
            this.Controls.Add(this.UpdatedNameTextbox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "UpdateContactForm";
            this.Text = "Update Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DateTimePicker UpdatedDobPicker;
        private System.Windows.Forms.TextBox UpdatedEmailTextbox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox UpdatedNumberTextbox;
        private System.Windows.Forms.TextBox UpdatedNameTextbox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}