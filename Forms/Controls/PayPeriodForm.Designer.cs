namespace CableTVApp.Forms.Controls {
  partial class PayPeriodForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.AddPanel = new System.Windows.Forms.Panel();
      this.AddGBox = new System.Windows.Forms.GroupBox();
      this.ClientPayDGV = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.FormingBtn = new System.Windows.Forms.Button();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.PayDateDTP = new System.Windows.Forms.DateTimePicker();
      this.PayPeriodNameValiadtionLbl = new System.Windows.Forms.Label();
      this.StartDateLbl = new System.Windows.Forms.Label();
      this.PayPeriodNameTBox = new System.Windows.Forms.TextBox();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      this.PayPeriodGridView = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.AddPanel.SuspendLayout();
      this.AddGBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ClientPayDGV)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PayPeriodGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // AddPanel
      // 
      this.AddPanel.Controls.Add(this.AddGBox);
      this.AddPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.AddPanel.Location = new System.Drawing.Point(0, 0);
      this.AddPanel.Name = "AddPanel";
      this.AddPanel.Size = new System.Drawing.Size(551, 624);
      this.AddPanel.TabIndex = 100;
      // 
      // AddGBox
      // 
      this.AddGBox.Controls.Add(this.ClientPayDGV);
      this.AddGBox.Controls.Add(this.groupBox1);
      this.AddGBox.Controls.Add(this.ExitBtn);
      this.AddGBox.Controls.Add(this.ClearBtn);
      this.AddGBox.Controls.Add(this.AddBtn);
      this.AddGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddGBox.Location = new System.Drawing.Point(12, 12);
      this.AddGBox.Name = "AddGBox";
      this.AddGBox.Size = new System.Drawing.Size(528, 609);
      this.AddGBox.TabIndex = 2;
      this.AddGBox.TabStop = false;
      this.AddGBox.Text = "Додати";
      // 
      // ClientPayDGV
      // 
      this.ClientPayDGV.AllowUserToAddRows = false;
      this.ClientPayDGV.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.ClientPayDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.ClientPayDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ClientPayDGV.GridColor = System.Drawing.SystemColors.Control;
      this.ClientPayDGV.Location = new System.Drawing.Point(16, 297);
      this.ClientPayDGV.MultiSelect = false;
      this.ClientPayDGV.Name = "ClientPayDGV";
      this.ClientPayDGV.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ClientPayDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.ClientPayDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
      this.ClientPayDGV.Size = new System.Drawing.Size(480, 264);
      this.ClientPayDGV.TabIndex = 116;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.DescriptionTBox);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.FormingBtn);
      this.groupBox1.Controls.Add(this.LastNameLbl);
      this.groupBox1.Controls.Add(this.PayDateDTP);
      this.groupBox1.Controls.Add(this.PayPeriodNameValiadtionLbl);
      this.groupBox1.Controls.Add(this.StartDateLbl);
      this.groupBox1.Controls.Add(this.PayPeriodNameTBox);
      this.groupBox1.Location = new System.Drawing.Point(16, 21);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(500, 270);
      this.groupBox1.TabIndex = 115;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Відомість оплати послуг/програм:";
      // 
      // FormingBtn
      // 
      this.FormingBtn.Location = new System.Drawing.Point(384, 241);
      this.FormingBtn.Name = "FormingBtn";
      this.FormingBtn.Size = new System.Drawing.Size(96, 23);
      this.FormingBtn.TabIndex = 115;
      this.FormingBtn.Text = "Формувати";
      this.FormingBtn.UseVisualStyleBackColor = true;
      this.FormingBtn.Click += new System.EventHandler(this.FormingBtn_Click);
      // 
      // LastNameLbl
      // 
      this.LastNameLbl.AutoSize = true;
      this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LastNameLbl.Location = new System.Drawing.Point(21, 27);
      this.LastNameLbl.Name = "LastNameLbl";
      this.LastNameLbl.Size = new System.Drawing.Size(53, 16);
      this.LastNameLbl.TabIndex = 1;
      this.LastNameLbl.Text = "Назва:";
      // 
      // PayDateDTP
      // 
      this.PayDateDTP.Location = new System.Drawing.Point(157, 52);
      this.PayDateDTP.Name = "PayDateDTP";
      this.PayDateDTP.Size = new System.Drawing.Size(159, 22);
      this.PayDateDTP.TabIndex = 114;
      // 
      // PayPeriodNameValiadtionLbl
      // 
      this.PayPeriodNameValiadtionLbl.AutoSize = true;
      this.PayPeriodNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.PayPeriodNameValiadtionLbl.Location = new System.Drawing.Point(130, 27);
      this.PayPeriodNameValiadtionLbl.Name = "PayPeriodNameValiadtionLbl";
      this.PayPeriodNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.PayPeriodNameValiadtionLbl.TabIndex = 22;
      this.PayPeriodNameValiadtionLbl.Text = "*";
      // 
      // StartDateLbl
      // 
      this.StartDateLbl.AutoSize = true;
      this.StartDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.StartDateLbl.Location = new System.Drawing.Point(21, 57);
      this.StartDateLbl.Name = "StartDateLbl";
      this.StartDateLbl.Size = new System.Drawing.Size(43, 16);
      this.StartDateLbl.TabIndex = 113;
      this.StartDateLbl.Text = "Дата:";
      // 
      // PayPeriodNameTBox
      // 
      this.PayPeriodNameTBox.Location = new System.Drawing.Point(157, 24);
      this.PayPeriodNameTBox.MaxLength = 200;
      this.PayPeriodNameTBox.Name = "PayPeriodNameTBox";
      this.PayPeriodNameTBox.Size = new System.Drawing.Size(323, 22);
      this.PayPeriodNameTBox.TabIndex = 1;
      // 
      // ExitBtn
      // 
      this.ExitBtn.Location = new System.Drawing.Point(415, 567);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 6;
      this.ExitBtn.Text = "Вихід";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // ClearBtn
      // 
      this.ClearBtn.Location = new System.Drawing.Point(316, 567);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(81, 23);
      this.ClearBtn.TabIndex = 5;
      this.ClearBtn.Text = "Очистити";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(214, 567);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 4;
      this.AddBtn.Text = "Зберегти";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // PayPeriodGridView
      // 
      this.PayPeriodGridView.AllowUserToAddRows = false;
      this.PayPeriodGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.PayPeriodGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
      this.PayPeriodGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.PayPeriodGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.PayPeriodGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PayPeriodGridView.GridColor = System.Drawing.SystemColors.Control;
      this.PayPeriodGridView.Location = new System.Drawing.Point(551, 0);
      this.PayPeriodGridView.MultiSelect = false;
      this.PayPeriodGridView.Name = "PayPeriodGridView";
      this.PayPeriodGridView.ReadOnly = true;
      this.PayPeriodGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PayPeriodGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.PayPeriodGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.PayPeriodGridView.Size = new System.Drawing.Size(537, 624);
      this.PayPeriodGridView.TabIndex = 101;
      this.PayPeriodGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PayPeroodGridView_CellClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(21, 83);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 16);
      this.label1.TabIndex = 116;
      this.label1.Text = "Опис:";
      // 
      // DescriptionTBox
      // 
      this.DescriptionTBox.Location = new System.Drawing.Point(24, 102);
      this.DescriptionTBox.MaxLength = 200;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DescriptionTBox.Size = new System.Drawing.Size(456, 131);
      this.DescriptionTBox.TabIndex = 117;
      // 
      // PayPeriodForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1088, 624);
      this.Controls.Add(this.PayPeriodGridView);
      this.Controls.Add(this.AddPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PayPeriodForm";
      this.Text = "Оплата";
      this.AddPanel.ResumeLayout(false);
      this.AddGBox.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ClientPayDGV)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PayPeriodGridView)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.GroupBox AddGBox;
        private System.Windows.Forms.DataGridView ClientPayDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FormingBtn;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.DateTimePicker PayDateDTP;
        private System.Windows.Forms.Label PayPeriodNameValiadtionLbl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.TextBox PayPeriodNameTBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView PayPeriodGridView;
        private System.Windows.Forms.TextBox DescriptionTBox;
        private System.Windows.Forms.Label label1;
    }
}