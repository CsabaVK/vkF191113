namespace _11_13DB
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_nev = new System.Windows.Forms.Label();
            this.lb_tema = new System.Windows.Forms.Label();
            this.lb_datum = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_tema = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_jegy = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_tz = new System.Windows.Forms.CheckBox();
            this.bt_1 = new System.Windows.Forms.Button();
            this.Tb_1 = new System.Windows.Forms.RichTextBox();
            this.dgv_jegyek = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jegyek)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nev
            // 
            this.lb_nev.AutoSize = true;
            this.lb_nev.Location = new System.Drawing.Point(22, 23);
            this.lb_nev.Name = "lb_nev";
            this.lb_nev.Size = new System.Drawing.Size(30, 13);
            this.lb_nev.TabIndex = 0;
            this.lb_nev.Text = "Név:";
            // 
            // lb_tema
            // 
            this.lb_tema.AutoSize = true;
            this.lb_tema.Location = new System.Drawing.Point(22, 65);
            this.lb_tema.Name = "lb_tema";
            this.lb_tema.Size = new System.Drawing.Size(37, 13);
            this.lb_tema.TabIndex = 1;
            this.lb_tema.Text = "Téma:";
            // 
            // lb_datum
            // 
            this.lb_datum.AutoSize = true;
            this.lb_datum.Location = new System.Drawing.Point(465, 23);
            this.lb_datum.Name = "lb_datum";
            this.lb_datum.Size = new System.Drawing.Size(41, 13);
            this.lb_datum.TabIndex = 2;
            this.lb_datum.Text = "Dátum:";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(75, 20);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(384, 20);
            this.tb_nev.TabIndex = 3;
            // 
            // tb_tema
            // 
            this.tb_tema.Location = new System.Drawing.Point(75, 62);
            this.tb_tema.Name = "tb_tema";
            this.tb_tema.Size = new System.Drawing.Size(384, 20);
            this.tb_tema.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 20);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 6, 15, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // lb_jegy
            // 
            this.lb_jegy.AutoSize = true;
            this.lb_jegy.Location = new System.Drawing.Point(471, 65);
            this.lb_jegy.Name = "lb_jegy";
            this.lb_jegy.Size = new System.Drawing.Size(32, 13);
            this.lb_jegy.TabIndex = 6;
            this.lb_jegy.Text = "Jegy:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(512, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(421, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // checkBox_tz
            // 
            this.checkBox_tz.AutoSize = true;
            this.checkBox_tz.Location = new System.Drawing.Point(887, 22);
            this.checkBox_tz.Name = "checkBox_tz";
            this.checkBox_tz.Size = new System.Drawing.Size(46, 17);
            this.checkBox_tz.TabIndex = 8;
            this.checkBox_tz.Text = "TZ?";
            this.checkBox_tz.UseVisualStyleBackColor = true;
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(25, 114);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(908, 46);
            this.bt_1.TabIndex = 9;
            this.bt_1.Text = "Új jegy rögzítése!";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.Bt_1_Click);
            // 
            // Tb_1
            // 
            this.Tb_1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tb_1.Location = new System.Drawing.Point(12, 180);
            this.Tb_1.Name = "Tb_1";
            this.Tb_1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Tb_1.Size = new System.Drawing.Size(921, 145);
            this.Tb_1.TabIndex = 10;
            this.Tb_1.Text = "";
            // 
            // dgv_jegyek
            // 
            this.dgv_jegyek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_jegyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jegyek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_jegyek.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_jegyek.Location = new System.Drawing.Point(12, 331);
            this.dgv_jegyek.Name = "dgv_jegyek";
            this.dgv_jegyek.RowHeadersVisible = false;
            this.dgv_jegyek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_jegyek.Size = new System.Drawing.Size(921, 213);
            this.dgv_jegyek.TabIndex = 11;
            this.dgv_jegyek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_jegyek_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Név";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dátum";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Téma";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TZ?";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Jegy";
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 556);
            this.Controls.Add(this.dgv_jegyek);
            this.Controls.Add(this.Tb_1);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.checkBox_tz);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lb_jegy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_tema);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.lb_datum);
            this.Controls.Add(this.lb_tema);
            this.Controls.Add(this.lb_nev);
            this.Name = "Form1";
            this.Text = "Exam Creator 9000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jegyek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nev;
        private System.Windows.Forms.Label lb_tema;
        private System.Windows.Forms.Label lb_datum;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_tema;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_jegy;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox_tz;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.RichTextBox Tb_1;
        private System.Windows.Forms.DataGridView dgv_jegyek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

