namespace FoodCourtManagementSystem
{
    partial class AdminPassChange
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
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxPrePass = new System.Windows.Forms.TextBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtboxNewPass = new System.Windows.Forms.TextBox();
            this.txtboxCPass = new System.Windows.Forms.TextBox();
            this.lblCross = new System.Windows.Forms.Label();
            this.lblRigh = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Username:";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(300, 53);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(90, 26);
            this.lblUname.TabIndex = 1;
            this.lblUname.Text = "ABCDEF";
            this.lblUname.Visible = false;
            this.lblUname.Click += new System.EventHandler(this.lblUname_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(182, 27);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 26);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "XYZXYZ";
            this.lblPassword.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Previous Password:";
            // 
            // txtboxPrePass
            // 
            this.txtboxPrePass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPrePass.Location = new System.Drawing.Point(242, 82);
            this.txtboxPrePass.Multiline = true;
            this.txtboxPrePass.Name = "txtboxPrePass";
            this.txtboxPrePass.PasswordChar = '*';
            this.txtboxPrePass.Size = new System.Drawing.Size(196, 26);
            this.txtboxPrePass.TabIndex = 4;
            this.txtboxPrePass.TextChanged += new System.EventHandler(this.txtboxPrePass_TextChanged);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(263, 111);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(64, 26);
            this.lblAlert.TabIndex = 5;
            this.lblAlert.Text = "Match";
            this.lblAlert.Visible = false;
            this.lblAlert.Click += new System.EventHandler(this.lblAlert_Click);
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(62, 147);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(141, 26);
            this.lblNewPass.TabIndex = 6;
            this.lblNewPass.Text = "New Password:";
            this.lblNewPass.Visible = false;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(62, 187);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(169, 26);
            this.lblConfirmPass.TabIndex = 7;
            this.lblConfirmPass.Text = "Confirm Password:";
            this.lblConfirmPass.Visible = false;
            // 
            // txtboxNewPass
            // 
            this.txtboxNewPass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewPass.Location = new System.Drawing.Point(242, 147);
            this.txtboxNewPass.Multiline = true;
            this.txtboxNewPass.Name = "txtboxNewPass";
            this.txtboxNewPass.Size = new System.Drawing.Size(196, 26);
            this.txtboxNewPass.TabIndex = 8;
            this.txtboxNewPass.Visible = false;
            this.txtboxNewPass.TextChanged += new System.EventHandler(this.txtboxNewPass_TextChanged);
            // 
            // txtboxCPass
            // 
            this.txtboxCPass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCPass.Location = new System.Drawing.Point(242, 187);
            this.txtboxCPass.Multiline = true;
            this.txtboxCPass.Name = "txtboxCPass";
            this.txtboxCPass.PasswordChar = '*';
            this.txtboxCPass.Size = new System.Drawing.Size(196, 26);
            this.txtboxCPass.TabIndex = 9;
            this.txtboxCPass.Visible = false;
            this.txtboxCPass.TextChanged += new System.EventHandler(this.txtboxCPass_TextChanged);
            // 
            // lblCross
            // 
            this.lblCross.AutoSize = true;
            this.lblCross.BackColor = System.Drawing.Color.Red;
            this.lblCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCross.Location = new System.Drawing.Point(444, 187);
            this.lblCross.Name = "lblCross";
            this.lblCross.Size = new System.Drawing.Size(25, 24);
            this.lblCross.TabIndex = 10;
            this.lblCross.Text = "❌";
            this.lblCross.Visible = false;
            // 
            // lblRigh
            // 
            this.lblRigh.AutoSize = true;
            this.lblRigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRigh.Location = new System.Drawing.Point(444, 187);
            this.lblRigh.Name = "lblRigh";
            this.lblRigh.Size = new System.Drawing.Size(22, 24);
            this.lblRigh.TabIndex = 11;
            this.lblRigh.Text = "✔";
            this.lblRigh.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(201, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 38);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(201, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 38);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AdminPassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(496, 313);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRigh);
            this.Controls.Add(this.lblCross);
            this.Controls.Add(this.txtboxCPass);
            this.Controls.Add(this.txtboxNewPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.txtboxPrePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.label1);
            this.Name = "AdminPassChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPassChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxPrePass;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtboxNewPass;
        private System.Windows.Forms.TextBox txtboxCPass;
        private System.Windows.Forms.Label lblCross;
        private System.Windows.Forms.Label lblRigh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
    }
}