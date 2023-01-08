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
            this.Pont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tablazat)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Dobas
            // 
            this.BTN_Dobas.Location = new System.Drawing.Point(12, 12);
            this.BTN_Dobas.Name = "BTN_Dobas";
            this.BTN_Dobas.Size = new System.Drawing.Size(75, 75);
            this.BTN_Dobas.TabIndex = 0;
            this.BTN_Dobas.Text = "Dobás";
            this.BTN_Dobas.UseVisualStyleBackColor = true;
            this.BTN_Dobas.Click += new System.EventHandler(this.BTN_Dobas_Click);
            // 
            // LB_dobott_text
            // 
            this.LB_dobott_text.AutoSize = true;
            this.LB_dobott_text.Location = new System.Drawing.Point(96, 16);
            this.LB_dobott_text.Name = "LB_dobott_text";
            this.LB_dobott_text.Size = new System.Drawing.Size(90, 15);
            this.LB_dobott_text.TabIndex = 1;
            this.LB_dobott_text.Text = "Dobott számok:";
            // 
            // LB_Dobott1
            // 
            this.LB_Dobott1.AutoSize = true;
            this.LB_Dobott1.Location = new System.Drawing.Point(96, 42);
            this.LB_Dobott1.Name = "LB_Dobott1";
            this.LB_Dobott1.Size = new System.Drawing.Size(13, 15);
            this.LB_Dobott1.TabIndex = 2;
            this.LB_Dobott1.Text = "0";
            // 
            // LB_Dobott2
            // 
            this.LB_Dobott2.AutoSize = true;
            this.LB_Dobott2.Location = new System.Drawing.Point(115, 42);
            this.LB_Dobott2.Name = "LB_Dobott2";
            this.LB_Dobott2.Size = new System.Drawing.Size(13, 15);
            this.LB_Dobott2.TabIndex = 3;
            this.LB_Dobott2.Text = "0";
            // 
            // LB_Dobott3
            // 
            this.LB_Dobott3.AutoSize = true;
            this.LB_Dobott3.Location = new System.Drawing.Point(134, 42);
            this.LB_Dobott3.Name = "LB_Dobott3";
            this.LB_Dobott3.Size = new System.Drawing.Size(13, 15);
            this.LB_Dobott3.TabIndex = 4;
            this.LB_Dobott3.Text = "0";
            // 
            // LB_Dobott4
            // 
            this.LB_Dobott4.AutoSize = true;
            this.LB_Dobott4.Location = new System.Drawing.Point(153, 42);
            this.LB_Dobott4.Name = "LB_Dobott4";
            this.LB_Dobott4.Size = new System.Drawing.Size(13, 15);
            this.LB_Dobott4.TabIndex = 5;
            this.LB_Dobott4.Text = "0";
            // 
            // LB_Dobott5
            // 
            this.LB_Dobott5.AutoSize = true;
            this.LB_Dobott5.Location = new System.Drawing.Point(173, 42);
            this.LB_Dobott5.Name = "LB_Dobott5";
            this.LB_Dobott5.Size = new System.Drawing.Size(13, 15);
            this.LB_Dobott5.TabIndex = 6;
            this.LB_Dobott5.Text = "0";
            // 
            // CHB_Dobott1
            // 
            this.CHB_Dobott1.AutoSize = true;
            this.CHB_Dobott1.Location = new System.Drawing.Point(96, 90);
            this.CHB_Dobott1.Name = "CHB_Dobott1";
            this.CHB_Dobott1.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott1.TabIndex = 7;
            this.CHB_Dobott1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Megtartott kockák:";
            // 
            // CHB_Dobott2
            // 
            this.CHB_Dobott2.AutoSize = true;
            this.CHB_Dobott2.Location = new System.Drawing.Point(115, 90);
            this.CHB_Dobott2.Name = "CHB_Dobott2";
            this.CHB_Dobott2.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott2.TabIndex = 9;
            this.CHB_Dobott2.UseVisualStyleBackColor = true;
            // 
            // CHB_Dobott3
            // 
            this.CHB_Dobott3.AutoSize = true;
            this.CHB_Dobott3.Location = new System.Drawing.Point(134, 90);
            this.CHB_Dobott3.Name = "CHB_Dobott3";
            this.CHB_Dobott3.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott3.TabIndex = 10;
            this.CHB_Dobott3.UseVisualStyleBackColor = true;
            // 
            // CHB_Dobott4
            // 
            this.CHB_Dobott4.AutoSize = true;
            this.CHB_Dobott4.Location = new System.Drawing.Point(153, 90);
            this.CHB_Dobott4.Name = "CHB_Dobott4";
            this.CHB_Dobott4.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott4.TabIndex = 11;
            this.CHB_Dobott4.UseVisualStyleBackColor = true;
            // 
            // CHB_Dobott5
            // 
            this.CHB_Dobott5.AutoSize = true;
            this.CHB_Dobott5.Location = new System.Drawing.Point(173, 90);
            this.CHB_Dobott5.Name = "CHB_Dobott5";
            this.CHB_Dobott5.Size = new System.Drawing.Size(15, 14);
            this.CHB_Dobott5.TabIndex = 12;
            this.CHB_Dobott5.UseVisualStyleBackColor = true;
            // 
            // LB_Dobasok
            // 
            this.LB_Dobasok.AutoSize = true;
            this.LB_Dobasok.Location = new System.Drawing.Point(12, 90);
            this.LB_Dobasok.Name = "LB_Dobasok";
            this.LB_Dobasok.Size = new System.Drawing.Size(13, 15);
            this.LB_Dobasok.TabIndex = 13;
            this.LB_Dobasok.Text = "0";
            // 
            // DGV_Tablazat
            // 
            this.DGV_Tablazat.AllowUserToAddRows = false;
            this.DGV_Tablazat.AllowUserToDeleteRows = false;
            this.DGV_Tablazat.AllowUserToResizeColumns = false;
            this.DGV_Tablazat.AllowUserToResizeRows = false;
            this.DGV_Tablazat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tablazat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kat,
            this.Pont});
            this.DGV_Tablazat.Location = new System.Drawing.Point(209, 12);
            this.DGV_Tablazat.Name = "DGV_Tablazat";
            this.DGV_Tablazat.RowHeadersVisible = false;
            this.DGV_Tablazat.RowTemplate.Height = 25;
            this.DGV_Tablazat.Size = new System.Drawing.Size(180, 375);
            this.DGV_Tablazat.TabIndex = 14;
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
            this.Pont.HeaderText = "Pontszám";
            this.Pont.Name = "Pont";
            this.Pont.ReadOnly = true;
            this.Pont.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
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
        private DataGridViewTextBoxColumn Kat;
        private DataGridViewTextBoxColumn Pont;
    }
}