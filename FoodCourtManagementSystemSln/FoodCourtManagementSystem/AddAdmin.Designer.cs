namespace FoodCourtManagementSystem
{
    partial class AddAdmin
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
            this.txtboxAdminUname = new System.Windows.Forms.TextBox();
            this.txtboxAdminPass = new System.Windows.Forms.TextBox();
            this.txtboxCpass = new System.Windows.Forms.TextBox();
            this.lblCross = new System.Windows.Forms.Label();
            this.lblRigh = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // txtboxAdminUname
            // 
            this.txtboxAdminUname.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAdminUname.Location = new System.Drawing.Point(219, 12);
            this.txtboxAdminUname.Multiline = true;
            this.txtboxAdminUname.Name = "txtboxAdminUname";
            this.txtboxAdminUname.Size = new System.Drawing.Size(204, 26);
            this.txtboxAdminUname.TabIndex = 3;
            // 
            // txtboxAdminPass
            // 
            this.txtboxAdminPass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAdminPass.Location = new System.Drawing.Point(219, 52);
            this.txtboxAdminPass.Multiline = true;
            this.txtboxAdminPass.Name = "txtboxAdminPass";
            this.txtboxAdminPass.Size = new System.Drawing.Size(204, 26);
            this.txtboxAdminPass.TabIndex = 4;
            this.txtboxAdminPass.TextChanged += new System.EventHandler(this.txtboxAdminPass_TextChanged);
            // 
            // txtboxCpass
            // 
            this.txtboxCpass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCpass.Location = new System.Drawing.Point(219, 90);
            this.txtboxCpass.Multiline = true;
            this.txtboxCpass.Name = "txtboxCpass";
            this.txtboxCpass.PasswordChar = '*';
            this.txtboxCpass.Size = new System.Drawing.Size(204, 26);
            this.txtboxCpass.TabIndex = 5;
            this.txtboxCpass.TextChanged += new System.EventHandler(this.txtboxCpass_TextChanged);
            // 
            // lblCross
            // 
            this.lblCross.AutoSize = true;
            this.lblCross.BackColor = System.Drawing.Color.Red;
            this.lblCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCross.Location = new System.Drawing.Point(429, 94);
            this.lblCross.Name = "lblCross";
            this.lblCross.Size = new System.Drawing.Size(21, 20);
            this.lblCross.TabIndex = 6;
            this.lblCross.Text = "❌";
            this.lblCross.Visible = false;
            // 
            // lblRigh
            // 
            this.lblRigh.AutoSize = true;
            this.lblRigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRigh.Location = new System.Drawing.Point(429, 94);
            this.lblRigh.Name = "lblRigh";
            this.lblRigh.Size = new System.Drawing.Size(19, 20);
            this.lblRigh.TabIndex = 7;
            this.lblRigh.Text = "✔";
            this.lblRigh.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(244, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(476, 175);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRigh);
            this.Controls.Add(this.lblCross);
            this.Controls.Add(this.txtboxCpass);
            this.Controls.Add(this.txtboxAdminPass);
            this.Controls.Add(this.txtboxAdminUname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxAdminUname;
        private System.Windows.Forms.TextBox txtboxAdminPass;
        private System.Windows.Forms.TextBox txtboxCpass;
        private System.Windows.Forms.Label lblCross;
        private System.Windows.Forms.Label lblRigh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
    }
}