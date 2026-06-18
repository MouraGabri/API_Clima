namespace Weather_System
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmBoxCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rainProbabilty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txboxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmBoxCity
            // 
            this.cmBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmBoxCity.FormattingEnabled = true;
            this.cmBoxCity.Items.AddRange(new object[] {
            "",
            "Canoas - RS",
            "Tramandai - RS",
            "Caxias - RS",
            "Farroupilha - RS"});
            this.cmBoxCity.Location = new System.Drawing.Point(387, 63);
            this.cmBoxCity.Name = "cmBoxCity";
            this.cmBoxCity.Size = new System.Drawing.Size(188, 23);
            this.cmBoxCity.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(332, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cidade:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.day,
            this.minTemperature,
            this.maxTemperature,
            this.description,
            this.rainProbabilty});
            this.dataGridView1.Location = new System.Drawing.Point(27, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 218);
            this.dataGridView1.TabIndex = 9;
            // 
            // day
            // 
            this.day.HeaderText = "Dia";
            this.day.Name = "day";
            // 
            // minTemperature
            // 
            this.minTemperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemperature.DefaultCellStyle = dataGridViewCellStyle13;
            this.minTemperature.HeaderText = "Temp° Min";
            this.minTemperature.Name = "minTemperature";
            // 
            // maxTemperature
            // 
            this.maxTemperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTemperature.DefaultCellStyle = dataGridViewCellStyle14;
            this.maxTemperature.HeaderText = "Temp° Max";
            this.maxTemperature.Name = "maxTemperature";
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.DefaultCellStyle = dataGridViewCellStyle15;
            this.description.HeaderText = "Descrição";
            this.description.Name = "description";
            // 
            // rainProbabilty
            // 
            this.rainProbabilty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainProbabilty.DefaultCellStyle = dataGridViewCellStyle16;
            this.rainProbabilty.HeaderText = "Percent. Chuva";
            this.rainProbabilty.Name = "rainProbabilty";
            // 
            // txboxUser
            // 
            this.txboxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txboxUser.Location = new System.Drawing.Point(83, 61);
            this.txboxUser.Name = "txboxUser";
            this.txboxUser.ReadOnly = true;
            this.txboxUser.Size = new System.Drawing.Size(243, 21);
            this.txboxUser.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuário:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 36);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownn);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovee);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "WEATHER SYSTEM";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Weather_System.Properties.Resources.ExtensaoTitulo_1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 36);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.panel2.Location = new System.Drawing.Point(0, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 24);
            this.panel2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "History";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(651, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txboxUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txboxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn rainProbabilty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}