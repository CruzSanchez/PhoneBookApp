
namespace PhonebookDesktopUI
{
    partial class PhonebookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhonebookForm));
            this.CreateButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.phonebookGridView = new System.Windows.Forms.DataGridView();
            this.RefreshDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(625, 112);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(103, 30);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create Contact";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadButton.Location = new System.Drawing.Point(625, 173);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(103, 30);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Get Contacts";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(625, 234);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(103, 30);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update Contact";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(625, 295);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 30);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete Contact";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // phonebookGridView
            // 
            this.phonebookGridView.AllowUserToAddRows = false;
            this.phonebookGridView.AllowUserToDeleteRows = false;
            this.phonebookGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.phonebookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phonebookGridView.Location = new System.Drawing.Point(48, 92);
            this.phonebookGridView.Name = "phonebookGridView";
            this.phonebookGridView.ReadOnly = true;
            this.phonebookGridView.RowTemplate.Height = 25;
            this.phonebookGridView.Size = new System.Drawing.Size(558, 259);
            this.phonebookGridView.TabIndex = 4;
            // 
            // RefreshDataButton
            // 
            this.RefreshDataButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshDataButton.Location = new System.Drawing.Point(255, 369);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Size = new System.Drawing.Size(145, 30);
            this.RefreshDataButton.TabIndex = 5;
            this.RefreshDataButton.Text = "Refresh Contact List";
            this.RefreshDataButton.UseVisualStyleBackColor = true;
            this.RefreshDataButton.Click += new System.EventHandler(this.RefreshDataButton_Click);
            // 
            // PhonebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshDataButton);
            this.Controls.Add(this.phonebookGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.CreateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhonebookForm";
            this.Text = "Phonebook";
            ((System.ComponentModel.ISupportInitialize)(this.phonebookGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView phonebookGridView;
        private System.Windows.Forms.Button RefreshDataButton;
    }
}

