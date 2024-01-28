namespace DatabaseHelper
{
    partial class DatabaseConnect
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
            this.HostnameTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseUsernameTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseUsernamePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveLoginDataCheckbox = new System.Windows.Forms.CheckBox();
            this.AutoconnectCheckbox = new System.Windows.Forms.CheckBox();
            this.DatabaseConnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // HostnameTextBox
            // 
            this.HostnameTextBox.Location = new System.Drawing.Point(73, 12);
            this.HostnameTextBox.Name = "HostnameTextBox";
            this.HostnameTextBox.Size = new System.Drawing.Size(153, 20);
            this.HostnameTextBox.TabIndex = 2;
            this.HostnameTextBox.Text = "localhost";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(73, 38);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(152, 20);
            this.PortTextBox.TabIndex = 3;
            this.PortTextBox.Text = "3306";
            // 
            // DatabaseUsernameTextBox
            // 
            this.DatabaseUsernameTextBox.Location = new System.Drawing.Point(73, 65);
            this.DatabaseUsernameTextBox.Name = "DatabaseUsernameTextBox";
            this.DatabaseUsernameTextBox.Size = new System.Drawing.Size(153, 20);
            this.DatabaseUsernameTextBox.TabIndex = 4;
            this.DatabaseUsernameTextBox.Text = "root";
            // 
            // DatabaseUsernamePasswordTextBox
            // 
            this.DatabaseUsernamePasswordTextBox.Location = new System.Drawing.Point(73, 92);
            this.DatabaseUsernamePasswordTextBox.Name = "DatabaseUsernamePasswordTextBox";
            this.DatabaseUsernamePasswordTextBox.Size = new System.Drawing.Size(153, 20);
            this.DatabaseUsernamePasswordTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // SaveLoginDataCheckbox
            // 
            this.SaveLoginDataCheckbox.AutoSize = true;
            this.SaveLoginDataCheckbox.Location = new System.Drawing.Point(13, 124);
            this.SaveLoginDataCheckbox.Name = "SaveLoginDataCheckbox";
            this.SaveLoginDataCheckbox.Size = new System.Drawing.Size(103, 17);
            this.SaveLoginDataCheckbox.TabIndex = 8;
            this.SaveLoginDataCheckbox.Text = "Save login data ";
            this.SaveLoginDataCheckbox.UseVisualStyleBackColor = true;
            // 
            // AutoconnectCheckbox
            // 
            this.AutoconnectCheckbox.AutoSize = true;
            this.AutoconnectCheckbox.Location = new System.Drawing.Point(13, 148);
            this.AutoconnectCheckbox.Name = "AutoconnectCheckbox";
            this.AutoconnectCheckbox.Size = new System.Drawing.Size(87, 17);
            this.AutoconnectCheckbox.TabIndex = 9;
            this.AutoconnectCheckbox.Text = "Autoconnect";
            this.AutoconnectCheckbox.UseVisualStyleBackColor = true;
            // 
            // DatabaseConnectButton
            // 
            this.DatabaseConnectButton.Location = new System.Drawing.Point(73, 171);
            this.DatabaseConnectButton.Name = "DatabaseConnectButton";
            this.DatabaseConnectButton.Size = new System.Drawing.Size(75, 23);
            this.DatabaseConnectButton.TabIndex = 10;
            this.DatabaseConnectButton.Text = "Connect";
            this.DatabaseConnectButton.UseVisualStyleBackColor = true;
            // 
            // DatabaseConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 207);
            this.Controls.Add(this.DatabaseConnectButton);
            this.Controls.Add(this.AutoconnectCheckbox);
            this.Controls.Add(this.SaveLoginDataCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatabaseUsernamePasswordTextBox);
            this.Controls.Add(this.DatabaseUsernameTextBox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.HostnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseConnect";
            this.Text = "DatabaseConnect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HostnameTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox DatabaseUsernameTextBox;
        private System.Windows.Forms.TextBox DatabaseUsernamePasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox SaveLoginDataCheckbox;
        private System.Windows.Forms.CheckBox AutoconnectCheckbox;
        private System.Windows.Forms.Button DatabaseConnectButton;
    }
}