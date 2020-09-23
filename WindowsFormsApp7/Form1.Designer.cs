namespace WindowsFormsApp7
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
            this.components = new System.ComponentModel.Container();
            this.hal2EllenallasTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ellenallasMeresDataSet = new WindowsFormsApp7.EllenallasMeresDataSet();
            this.hal2EllenallasTempTableAdapter = new WindowsFormsApp7.EllenallasMeresDataSetTableAdapters.Hal2EllenallasTempTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hal2EllenallasTempBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.todayBtn = new System.Windows.Forms.Button();
            this.excelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setDayCheck = new System.Windows.Forms.CheckBox();
            this.showAllDay = new System.Windows.Forms.CheckBox();
            this.hal2EllenallasTempBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rajzszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ellenallasMeresDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ellenallasMeresDataSet1 = new WindowsFormsApp7.EllenallasMeresDataSet1();
            this.hal2EllenallasTempTableAdapter1 = new WindowsFormsApp7.EllenallasMeresDataSet1TableAdapters.Hal2EllenallasTempTableAdapter();
            this.mertErtekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hal2EllenallasTempBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ellenallasMeresDataSet2 = new WindowsFormsApp7.EllenallasMeresDataSet2();
            this.hal2EllenallasTempTableAdapter2 = new WindowsFormsApp7.EllenallasMeresDataSet2TableAdapters.Hal2EllenallasTempTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hal2EllenallasTempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellenallasMeresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal2EllenallasTempBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal2EllenallasTempBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellenallasMeresDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellenallasMeresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal2EllenallasTempBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellenallasMeresDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // hal2EllenallasTempBindingSource
            // 
            this.hal2EllenallasTempBindingSource.DataMember = "Hal2EllenallasTemp";
            this.hal2EllenallasTempBindingSource.DataSource = this.ellenallasMeresDataSet;
            // 
            // ellenallasMeresDataSet
            // 
            this.ellenallasMeresDataSet.DataSetName = "EllenallasMeresDataSet";
            this.ellenallasMeresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hal2EllenallasTempTableAdapter
            // 
            this.hal2EllenallasTempTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mertErtekDataGridViewTextBoxColumn,
            this.Datum,
            this.Rajzszam});
            this.dataGridView1.DataSource = this.hal2EllenallasTempBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(365, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // hal2EllenallasTempBindingSource1
            // 
            this.hal2EllenallasTempBindingSource1.DataMember = "Hal2EllenallasTemp";
            this.hal2EllenallasTempBindingSource1.DataSource = this.ellenallasMeresDataSet1BindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Frissít";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fromDate
            // 
            this.fromDate.CustomFormat = "yyyy-MM-dd";
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(383, 21);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 24);
            this.fromDate.TabIndex = 2;
            // 
            // toDate
            // 
            this.toDate.CustomFormat = "yyyy-MM-dd";
            this.toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(383, 112);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(200, 24);
            this.toDate.TabIndex = 3;
            // 
            // todayBtn
            // 
            this.todayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.todayBtn.Location = new System.Drawing.Point(396, 366);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.Size = new System.Drawing.Size(180, 72);
            this.todayBtn.TabIndex = 4;
            this.todayBtn.Text = "Csak a mai";
            this.todayBtn.UseVisualStyleBackColor = true;
            this.todayBtn.Click += new System.EventHandler(this.todayBtn_Click);
            // 
            // excelBtn
            // 
            this.excelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.excelBtn.Location = new System.Drawing.Point(599, 366);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(189, 72);
            this.excelBtn.TabIndex = 5;
            this.excelBtn.Text = "Excel generálás";
            this.excelBtn.UseVisualStyleBackColor = true;
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(383, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "-tól";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(383, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "-ig";
            // 
            // setDayCheck
            // 
            this.setDayCheck.AutoSize = true;
            this.setDayCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setDayCheck.Location = new System.Drawing.Point(599, 21);
            this.setDayCheck.Name = "setDayCheck";
            this.setDayCheck.Size = new System.Drawing.Size(135, 22);
            this.setDayCheck.TabIndex = 8;
            this.setDayCheck.Text = "Csak ez a nap";
            this.setDayCheck.UseVisualStyleBackColor = true;
            this.setDayCheck.CheckedChanged += new System.EventHandler(this.setDayCheck_CheckedChanged);
            // 
            // showAllDay
            // 
            this.showAllDay.AutoSize = true;
            this.showAllDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showAllDay.Location = new System.Drawing.Point(597, 112);
            this.showAllDay.Name = "showAllDay";
            this.showAllDay.Size = new System.Drawing.Size(191, 22);
            this.showAllDay.TabIndex = 9;
            this.showAllDay.Text = "Összes nap mutatása";
            this.showAllDay.UseVisualStyleBackColor = true;
            this.showAllDay.CheckedChanged += new System.EventHandler(this.showAllDay_CheckedChanged);
            // 
            // hal2EllenallasTempBindingSource3
            // 
            this.hal2EllenallasTempBindingSource3.DataMember = "Hal2EllenallasTemp";
            this.hal2EllenallasTempBindingSource3.DataSource = this.ellenallasMeresDataSet1BindingSource;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Rajzszam
            // 
            this.Rajzszam.DataPropertyName = "Rajzszam";
            this.Rajzszam.HeaderText = "Rajzszam";
            this.Rajzszam.Name = "Rajzszam";
            this.Rajzszam.ReadOnly = true;
            // 
            // ellenallasMeresDataSet1BindingSource
            // 
            this.ellenallasMeresDataSet1BindingSource.DataSource = this.ellenallasMeresDataSet1;
            this.ellenallasMeresDataSet1BindingSource.Position = 0;
            // 
            // ellenallasMeresDataSet1
            // 
            this.ellenallasMeresDataSet1.DataSetName = "EllenallasMeresDataSet1";
            this.ellenallasMeresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hal2EllenallasTempTableAdapter1
            // 
            this.hal2EllenallasTempTableAdapter1.ClearBeforeFill = true;
            // 
            // mertErtekDataGridViewTextBoxColumn
            // 
            this.mertErtekDataGridViewTextBoxColumn.DataPropertyName = "MertErtek";
            this.mertErtekDataGridViewTextBoxColumn.HeaderText = "MertErtek";
            this.mertErtekDataGridViewTextBoxColumn.Name = "mertErtekDataGridViewTextBoxColumn";
            this.mertErtekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hal2EllenallasTempBindingSource2
            // 
            this.hal2EllenallasTempBindingSource2.DataMember = "Hal2EllenallasTemp";
            this.hal2EllenallasTempBindingSource2.DataSource = this.ellenallasMeresDataSet2;
            // 
            // ellenallasMeresDataSet2
            // 
            this.ellenallasMeresDataSet2.DataSetName = "EllenallasMeresDataSet2";
            this.ellenallasMeresDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hal2EllenallasTempTableAdapter2
            // 
            this.hal2EllenallasTempTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.showAllDay);
            this.Controls.Add(this.setDayCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excelBtn);
            this.Controls.Add(this.todayBtn);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nézegető";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hal2EllenallasTempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellenallasMeresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal2EllenallasTempBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal2EllenallasTempBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellenallasMeresDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellenallasMeresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal2EllenallasTempBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellenallasMeresDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EllenallasMeresDataSet ellenallasMeresDataSet;
        private System.Windows.Forms.BindingSource hal2EllenallasTempBindingSource;
        private EllenallasMeresDataSetTableAdapters.Hal2EllenallasTempTableAdapter hal2EllenallasTempTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ellenallasMeresDataSet1BindingSource;
        private EllenallasMeresDataSet1 ellenallasMeresDataSet1;
        private System.Windows.Forms.BindingSource hal2EllenallasTempBindingSource1;
        private EllenallasMeresDataSet1TableAdapters.Hal2EllenallasTempTableAdapter hal2EllenallasTempTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Button todayBtn;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox setDayCheck;
        private System.Windows.Forms.CheckBox showAllDay;
        private EllenallasMeresDataSet2 ellenallasMeresDataSet2;
        private System.Windows.Forms.BindingSource hal2EllenallasTempBindingSource2;
        private EllenallasMeresDataSet2TableAdapters.Hal2EllenallasTempTableAdapter hal2EllenallasTempTableAdapter2;
        private System.Windows.Forms.BindingSource hal2EllenallasTempBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mertErtekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rajzszam;
    }
}

