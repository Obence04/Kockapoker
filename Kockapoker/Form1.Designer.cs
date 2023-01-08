namespace Kockapoker
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Dobas = new System.Windows.Forms.Button();
            this.LB_dobott_text = new System.Windows.Forms.Label();
            this.LB_Dobott1 = new System.Windows.Forms.Label();
            this.LB_Dobott2 = new System.Windows.Forms.Label();
            this.LB_Dobott3 = new System.Windows.Forms.Label();
            this.LB_Dobott4 = new System.Windows.Forms.Label();
            this.LB_Dobott5 = new System.Windows.Forms.Label();
            this.CHB_Dobott1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CHB_Dobott2 = new System.Windows.Forms.CheckBox();
            this.CHB_Dobott3 = new System.Windows.Forms.CheckBox();
            this.CHB_Dobott4 = new System.Windows.Forms.CheckBox();
            this.CHB_Dobott5 = new System.Windows.Forms.CheckBox();
            this.LB_Dobasok = new System.Windows.Forms.Label();
            this.DGV_Tablazat = new System.Windows.Forms.DataGridView();
            this.Kat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pont = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LB_Korok = new System.Windows.Forms.Label();
            this.LB_Vegeredmeny = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tablazat)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Dobas
            // 
            this.BTN_Dobas.BackColor = System.Drawing.Color.SeaGreen;
            this.BTN_Dobas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Dobas.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Dobas.Location = new System.Drawing.Point(12, 12);
            this.BTN_Dobas.Name = "BTN_Dobas";
            this.BTN_Dobas.Size = new System.Drawing.Size(150, 75);
            this.BTN_Dobas.TabIndex = 0;
            this.BTN_Dobas.Text = "Dobás";
            this.BTN_Dobas.UseVisualStyleBackColor = false;
            this.BTN_Dobas.Click += new System.EventHandler(this.BTN_Dobas_Click);
            // 
            // LB_dobott_text
            // 
            this.LB_dobott_text.AutoSize = true;
            this.LB_dobott_text.BackColor = System.Drawing.Color.Transparent;
            this.LB_dobott_text.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_dobott_text.Location = new System.Drawing.Point(10, 140);
            this.LB_dobott_text.Name = "LB_dobott_text";
            this.LB_dobott_text.Size = new System.Drawing.Size(100, 17);
            this.LB_dobott_text.TabIndex = 1;
            this.LB_dobott_text.Text = "Dobott számok:";
            // 
            // LB_Dobott1
            // 
            this.LB_Dobott1.AutoSize = true;
            this.LB_Dobott1.BackColor = System.Drawing.Color.Transparent;
            this.LB_Dobott1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Dobott1.Location = new System.Drawing.Point(12, 157);
            this.LB_Dobott1.Name = "LB_Dobott1";
            this.LB_Dobott1.Size = new System.Drawing.Size(15, 17);
            this.LB_Dobott1.TabIndex = 2;
            this.LB_Dobott1.Text = "0";
            // 
            // LB_Dobott2
            // 
            this.LB_Dobott2.AutoSize = true;
            this.LB_Dobott2.BackColor = System.Drawing.Color.Transparent;
            this.LB_Dobott2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Dobott2.Location = new System.Drawing.Point(33, 157);
            this.LB_Dobott2.Name = "LB_Dobott2";
            this.LB_Dobott2.Size = new System.Drawing.Size(15, 17);
            this.LB_Dobott2.TabIndex = 3;
            this.LB_Dobott2.Text = "0";
            // 
            // LB_Dobott3
            // 
            this.LB_Dobott3.AutoSize = true;
            this.LB_Dobott3.BackColor = System.Drawing.Color.Transparent;
            this.LB_Dobott3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Dobott3.Location = new System.Drawing.Point(54, 157);
            this.LB_Dobott3.Name = "LB_Dobott3";
            this.LB_Dobott3.Size = new System.Drawing.Size(15, 17);
            this.LB_Dobott3.TabIndex = 4;
            this.LB_Dobott3.Text = "0";
            // 
            // LB_Dobott4
            // 
            this.LB_Dobott4.AutoSize = true;
            this.LB_Dobott4.BackColor = System.Drawing.Color.Transparent;
            this.LB_Dobott4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Dobott4.Location = new System.Drawing.Point(75, 157);
            this.LB_Dobott4.Name = "LB_Dobott4";
            this.LB_Dobott4.Size = new System.Drawing.Size(15, 17);
            this.LB_Dobott4.TabIndex = 5;
            this.LB_Dobott4.Text = "0";
            // 
            // LB_Dobott5
            // 
            this.LB_Dobott5.AutoSize = true;
            this.LB_Dobott5.BackColor = System.Drawing.Color.Transparent;
            this.LB_Dobott5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Dobott5.Location = new System.Drawing.Point(96, 157);
            this.LB_Dobott5.Name = "LB_Dobott5";
            this.LB_Dobott5.Size = new System.Drawing.Size(15, 17);
            this.LB_Dobott5.TabIndex = 6;
            this.LB_Dobott5.Text = "0";
            // 
            // CHB_Dobott1
            // 
            this.CHB_Dobott1.AutoSize = true;
            this.CHB_Dobott1.BackColor = System.Drawing.Color.Transparent;
            this.CHB_Dobott1.Location = new System.Drawing.Point(13, 194);
            this.CHB_Dobott1.Name = "CHB_Dobott1";
            this.CHB_Dobott1.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott1.TabIndex = 7;
            this.CHB_Dobott1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Megtartott kockák:";
            // 
            // CHB_Dobott2
            // 
            this.CHB_Dobott2.AutoSize = true;
            this.CHB_Dobott2.BackColor = System.Drawing.Color.Transparent;
            this.CHB_Dobott2.Location = new System.Drawing.Point(33, 194);
            this.CHB_Dobott2.Name = "CHB_Dobott2";
            this.CHB_Dobott2.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott2.TabIndex = 9;
            this.CHB_Dobott2.UseVisualStyleBackColor = false;
            // 
            // CHB_Dobott3
            // 
            this.CHB_Dobott3.AutoSize = true;
            this.CHB_Dobott3.BackColor = System.Drawing.Color.Transparent;
            this.CHB_Dobott3.Location = new System.Drawing.Point(54, 194);
            this.CHB_Dobott3.Name = "CHB_Dobott3";
            this.CHB_Dobott3.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott3.TabIndex = 10;
            this.CHB_Dobott3.UseVisualStyleBackColor = false;
            // 
            // CHB_Dobott4
            // 
            this.CHB_Dobott4.AutoSize = true;
            this.CHB_Dobott4.BackColor = System.Drawing.Color.Transparent;
            this.CHB_Dobott4.Location = new System.Drawing.Point(75, 194);
            this.CHB_Dobott4.Name = "CHB_Dobott4";
            this.CHB_Dobott4.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott4.TabIndex = 11;
            this.CHB_Dobott4.UseVisualStyleBackColor = false;
            // 
            // CHB_Dobott5
            // 
            this.CHB_Dobott5.AutoSize = true;
            this.CHB_Dobott5.BackColor = System.Drawing.Color.Transparent;
            this.CHB_Dobott5.Location = new System.Drawing.Point(96, 194);
            this.CHB_Dobott5.Name = "CHB_Dobott5";
            this.CHB_Dobott5.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott5.TabIndex = 12;
            this.CHB_Dobott5.UseVisualStyleBackColor = false;
            // 
            // LB_Dobasok
            // 
            this.LB_Dobasok.AutoSize = true;
            this.LB_Dobasok.BackColor = System.Drawing.Color.Transparent;
            this.LB_Dobasok.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Dobasok.Location = new System.Drawing.Point(41, 90);
            this.LB_Dobasok.Name = "LB_Dobasok";
            this.LB_Dobasok.Size = new System.Drawing.Size(83, 20);
            this.LB_Dobasok.TabIndex = 13;
            this.LB_Dobasok.Text = "Dobások: 0";
            // 
            // DGV_Tablazat
            // 
            this.DGV_Tablazat.AllowUserToAddRows = false;
            this.DGV_Tablazat.AllowUserToDeleteRows = false;
            this.DGV_Tablazat.AllowUserToResizeColumns = false;
            this.DGV_Tablazat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Tablazat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Tablazat.BackgroundColor = System.Drawing.Color.Black;
            this.DGV_Tablazat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tablazat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Tablazat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tablazat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kat,
            this.Pont});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Tablazat.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Tablazat.EnableHeadersVisualStyles = false;
            this.DGV_Tablazat.GridColor = System.Drawing.Color.Black;
            this.DGV_Tablazat.Location = new System.Drawing.Point(168, 12);
            this.DGV_Tablazat.Name = "DGV_Tablazat";
            this.DGV_Tablazat.RowHeadersVisible = false;
            this.DGV_Tablazat.RowTemplate.Height = 25;
            this.DGV_Tablazat.Size = new System.Drawing.Size(180, 425);
            this.DGV_Tablazat.TabIndex = 14;
            this.DGV_Tablazat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kivalasztas);
            // 
            // Kat
            // 
            this.Kat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kat.HeaderText = "Kategória";
            this.Kat.Name = "Kat";
            this.Kat.ReadOnly = true;
            this.Kat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Pont
            // 
            this.Pont.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Pont.DefaultCellStyle = dataGridViewCellStyle3;
            this.Pont.HeaderText = "Pontszám";
            this.Pont.Name = "Pont";
            this.Pont.ReadOnly = true;
            this.Pont.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LB_Korok
            // 
            this.LB_Korok.AutoSize = true;
            this.LB_Korok.BackColor = System.Drawing.Color.Transparent;
            this.LB_Korok.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Korok.Location = new System.Drawing.Point(41, 110);
            this.LB_Korok.Name = "LB_Korok";
            this.LB_Korok.Size = new System.Drawing.Size(69, 20);
            this.LB_Korok.TabIndex = 15;
            this.LB_Korok.Text = "Kör: 0/15";
            // 
            // LB_Vegeredmeny
            // 
            this.LB_Vegeredmeny.AutoSize = true;
            this.LB_Vegeredmeny.BackColor = System.Drawing.Color.Transparent;
            this.LB_Vegeredmeny.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Vegeredmeny.Location = new System.Drawing.Point(13, 412);
            this.LB_Vegeredmeny.Name = "LB_Vegeredmeny";
            this.LB_Vegeredmeny.Size = new System.Drawing.Size(145, 25);
            this.LB_Vegeredmeny.TabIndex = 16;
            this.LB_Vegeredmeny.Text = "Végeredmény: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.LB_Vegeredmeny);
            this.Controls.Add(this.LB_Korok);
            this.Controls.Add(this.DGV_Tablazat);
            this.Controls.Add(this.LB_Dobasok);
            this.Controls.Add(this.CHB_Dobott5);
            this.Controls.Add(this.CHB_Dobott4);
            this.Controls.Add(this.CHB_Dobott3);
            this.Controls.Add(this.CHB_Dobott2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CHB_Dobott1);
            this.Controls.Add(this.LB_Dobott5);
            this.Controls.Add(this.LB_Dobott4);
            this.Controls.Add(this.LB_Dobott3);
            this.Controls.Add(this.LB_Dobott2);
            this.Controls.Add(this.LB_Dobott1);
            this.Controls.Add(this.LB_dobott_text);
            this.Controls.Add(this.BTN_Dobas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tablazat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_Dobas;
        private Label LB_dobott_text;
        private Label LB_Dobott1;
        private Label LB_Dobott2;
        private Label LB_Dobott3;
        private Label LB_Dobott4;
        private Label LB_Dobott5;
        private CheckBox CHB_Dobott1;
        private Label label1;
        private CheckBox CHB_Dobott2;
        private CheckBox CHB_Dobott3;
        private CheckBox CHB_Dobott4;
        private CheckBox CHB_Dobott5;
        private Label LB_Dobasok;
        private DataGridView DGV_Tablazat;
        private Label LB_Korok;
        private Label LB_Vegeredmeny;
        private DataGridViewTextBoxColumn Kat;
        private DataGridViewButtonColumn Pont;
    }
}