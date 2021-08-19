namespace FoodCourtManagementSystem
{
    partial class MyOrders
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
            this.lblUname = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnCheckOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBreakfast = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnShawarma = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnSoup = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(12, 314);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(51, 13);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "lblUname";
            this.lblUname.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(143, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 32);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(10, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(362, 284);
            this.dataGridViewOrders.TabIndex = 7;
            // 
            // btnCheckOrders
            // 
            this.btnCheckOrders.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOrders.Location = new System.Drawing.Point(112, 302);
            this.btnCheckOrders.Name = "btnCheckOrders";
            this.btnCheckOrders.Size = new System.Drawing.Size(159, 32);
            this.btnCheckOrders.TabIndex = 8;
            this.btnCheckOrders.Text = "Check My Orders";
            this.btnCheckOrders.UseVisualStyleBackColor = true;
            this.btnCheckOrders.Click += new System.EventHandler(this.btnCheckOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(267, 360);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnBreakfast
            // 
            this.btnBreakfast.BackColor = System.Drawing.Color.Silver;
            this.btnBreakfast.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreakfast.Location = new System.Drawing.Point(651, 21);
            this.btnBreakfast.Name = "btnBreakfast";
            this.btnBreakfast.Size = new System.Drawing.Size(219, 32);
            this.btnBreakfast.TabIndex = 10;
            this.btnBreakfast.Text = "Check Breakfast List";
            this.btnBreakfast.UseVisualStyleBackColor = false;
            this.btnBreakfast.Click += new System.EventHandler(this.btnBreakfast_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.Silver;
            this.btnLunch.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunch.Location = new System.Drawing.Point(651, 59);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(219, 32);
            this.btnLunch.TabIndex = 11;
            this.btnLunch.Text = "Check Lunch List";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnShawarma
            // 
            this.btnShawarma.BackColor = System.Drawing.Color.Silver;
            this.btnShawarma.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShawarma.Location = new System.Drawing.Point(651, 97);
            this.btnShawarma.Name = "btnShawarma";
            this.btnShawarma.Size = new System.Drawing.Size(219, 32);
            this.btnShawarma.TabIndex = 12;
            this.btnShawarma.Text = "Check Shawarma List";
            this.btnShawarma.UseVisualStyleBackColor = false;
            this.btnShawarma.Click += new System.EventHandler(this.btnShawarma_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.BackColor = System.Drawing.Color.Silver;
            this.btnPasta.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasta.Location = new System.Drawing.Point(651, 135);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(219, 32);
            this.btnPasta.TabIndex = 13;
            this.btnPasta.Text = "Check Pasta List";
            this.btnPasta.UseVisualStyleBackColor = false;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.BackColor = System.Drawing.Color.Silver;
            this.btnPizza.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizza.Location = new System.Drawing.Point(651, 173);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(219, 32);
            this.btnPizza.TabIndex = 14;
            this.btnPizza.Text = "Check Pizza List";
            this.btnPizza.UseVisualStyleBackColor = false;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.BackColor = System.Drawing.Color.Silver;
            this.btnBurger.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurger.Location = new System.Drawing.Point(651, 211);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(219, 32);
            this.btnBurger.TabIndex = 15;
            this.btnBurger.Text = "Check Burger List";
            this.btnBurger.UseVisualStyleBackColor = false;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.Silver;
            this.btnDessert.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessert.Location = new System.Drawing.Point(651, 249);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(219, 32);
            this.btnDessert.TabIndex = 16;
            this.btnDessert.Text = "Check Dessert List";
            this.btnDessert.UseVisualStyleBackColor = false;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnSoup
            // 
            this.btnSoup.BackColor = System.Drawing.Color.Silver;
            this.btnSoup.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoup.Location = new System.Drawing.Point(651, 287);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(219, 32);
            this.btnSoup.TabIndex = 17;
            this.btnSoup.Text = "Check Soup List";
            this.btnSoup.UseVisualStyleBackColor = false;
            this.btnSoup.Click += new System.EventHandler(this.btnSoup_Click);
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.Silver;
            this.btnDinner.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinner.Location = new System.Drawing.Point(651, 325);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(219, 32);
            this.btnDinner.TabIndex = 18;
            this.btnDinner.Text = "Check Dinner List";
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.button8_Click);
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodCourtManagementSystem.Properties.Resources.myorders2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 388);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnSoup);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnBurger);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.btnShawarma);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnBreakfast);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCheckOrders);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyOrders";
            this.Load += new System.EventHandler(this.MyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnCheckOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBreakfast;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnShawarma;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnSoup;
        private System.Windows.Forms.Button btnDinner;
    }
}