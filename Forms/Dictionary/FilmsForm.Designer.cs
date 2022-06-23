namespace CableTVApp.Forms.Dictionary {
  partial class FilmsForm {
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
      this.AddGBox = new System.Windows.Forms.GroupBox();
      this.CategoryIdValiadtionLbl = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.CategoryIdCBox = new System.Windows.Forms.ComboBox();
      this.PriceValiadtionLbl = new System.Windows.Forms.Label();
      this.PriceTBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      this.FilmsNameValiadtionLbl = new System.Windows.Forms.Label();
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.FilmsNameTBox = new System.Windows.Forms.TextBox();
      this.DescriptionLbl = new System.Windows.Forms.Label();
      this.СomputerLbl = new System.Windows.Forms.Label();
      this.AddPanel = new System.Windows.Forms.Panel();
      this.FilmsGridView = new System.Windows.Forms.DataGridView();
      this.GraduationYearDTP = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.AddGBox.SuspendLayout();
      this.AddPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FilmsGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // AddGBox
      // 
      this.AddGBox.Controls.Add(this.label3);
      this.AddGBox.Controls.Add(this.GraduationYearDTP);
      this.AddGBox.Controls.Add(this.CategoryIdValiadtionLbl);
      this.AddGBox.Controls.Add(this.label1);
      this.AddGBox.Controls.Add(this.CategoryIdCBox);
      this.AddGBox.Controls.Add(this.PriceValiadtionLbl);
      this.AddGBox.Controls.Add(this.PriceTBox);
      this.AddGBox.Controls.Add(this.label2);
      this.AddGBox.Controls.Add(this.ExitBtn);
      this.AddGBox.Controls.Add(this.ClearBtn);
      this.AddGBox.Controls.Add(this.AddBtn);
      this.AddGBox.Controls.Add(this.FilmsNameValiadtionLbl);
      this.AddGBox.Controls.Add(this.DescriptionTBox);
      this.AddGBox.Controls.Add(this.FilmsNameTBox);
      this.AddGBox.Controls.Add(this.DescriptionLbl);
      this.AddGBox.Controls.Add(this.СomputerLbl);
      this.AddGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddGBox.Location = new System.Drawing.Point(12, 12);
      this.AddGBox.Name = "AddGBox";
      this.AddGBox.Size = new System.Drawing.Size(347, 467);
      this.AddGBox.TabIndex = 0;
      this.AddGBox.TabStop = false;
      this.AddGBox.Text = "Додати";
      // 
      // CategoryIdValiadtionLbl
      // 
      this.CategoryIdValiadtionLbl.AutoSize = true;
      this.CategoryIdValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.CategoryIdValiadtionLbl.Location = new System.Drawing.Point(98, 106);
      this.CategoryIdValiadtionLbl.Name = "CategoryIdValiadtionLbl";
      this.CategoryIdValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.CategoryIdValiadtionLbl.TabIndex = 107;
      this.CategoryIdValiadtionLbl.Text = "*";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(8, 109);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 16);
      this.label1.TabIndex = 106;
      this.label1.Text = "Категорія:";
      // 
      // CategoryIdCBox
      // 
      this.CategoryIdCBox.DropDownWidth = 250;
      this.CategoryIdCBox.FormattingEnabled = true;
      this.CategoryIdCBox.Location = new System.Drawing.Point(117, 103);
      this.CategoryIdCBox.Name = "CategoryIdCBox";
      this.CategoryIdCBox.Size = new System.Drawing.Size(224, 24);
      this.CategoryIdCBox.TabIndex = 105;
      // 
      // PriceValiadtionLbl
      // 
      this.PriceValiadtionLbl.AutoSize = true;
      this.PriceValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.PriceValiadtionLbl.Location = new System.Drawing.Point(98, 76);
      this.PriceValiadtionLbl.Name = "PriceValiadtionLbl";
      this.PriceValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.PriceValiadtionLbl.TabIndex = 29;
      this.PriceValiadtionLbl.Text = "*";
      // 
      // PriceTBox
      // 
      this.PriceTBox.Location = new System.Drawing.Point(117, 73);
      this.PriceTBox.MaxLength = 15;
      this.PriceTBox.Name = "PriceTBox";
      this.PriceTBox.Size = new System.Drawing.Size(109, 22);
      this.PriceTBox.TabIndex = 28;
      this.PriceTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(8, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 16);
      this.label2.TabIndex = 27;
      this.label2.Text = "Ціна:";
      // 
      // ExitBtn
      // 
      this.ExitBtn.Location = new System.Drawing.Point(257, 428);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 5;
      this.ExitBtn.Text = "Вихід";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // ClearBtn
      // 
      this.ClearBtn.Location = new System.Drawing.Point(155, 428);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(81, 23);
      this.ClearBtn.TabIndex = 4;
      this.ClearBtn.Text = "Очистити";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(53, 428);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 3;
      this.AddBtn.Text = "Додати";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // FilmsNameValiadtionLbl
      // 
      this.FilmsNameValiadtionLbl.AutoSize = true;
      this.FilmsNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.FilmsNameValiadtionLbl.Location = new System.Drawing.Point(65, 22);
      this.FilmsNameValiadtionLbl.Name = "FilmsNameValiadtionLbl";
      this.FilmsNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.FilmsNameValiadtionLbl.TabIndex = 23;
      this.FilmsNameValiadtionLbl.Text = "*";
      // 
      // DescriptionTBox
      // 
      this.DescriptionTBox.Location = new System.Drawing.Point(3, 199);
      this.DescriptionTBox.MaxLength = 1500;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DescriptionTBox.Size = new System.Drawing.Size(335, 211);
      this.DescriptionTBox.TabIndex = 2;
      // 
      // FilmsNameTBox
      // 
      this.FilmsNameTBox.Location = new System.Drawing.Point(6, 41);
      this.FilmsNameTBox.MaxLength = 250;
      this.FilmsNameTBox.Name = "FilmsNameTBox";
      this.FilmsNameTBox.Size = new System.Drawing.Size(335, 22);
      this.FilmsNameTBox.TabIndex = 1;
      // 
      // DescriptionLbl
      // 
      this.DescriptionLbl.AutoSize = true;
      this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.DescriptionLbl.Location = new System.Drawing.Point(8, 180);
      this.DescriptionLbl.Name = "DescriptionLbl";
      this.DescriptionLbl.Size = new System.Drawing.Size(44, 16);
      this.DescriptionLbl.TabIndex = 1;
      this.DescriptionLbl.Text = "Опис:";
      // 
      // СomputerLbl
      // 
      this.СomputerLbl.AutoSize = true;
      this.СomputerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.СomputerLbl.Location = new System.Drawing.Point(6, 22);
      this.СomputerLbl.Name = "СomputerLbl";
      this.СomputerLbl.Size = new System.Drawing.Size(53, 16);
      this.СomputerLbl.TabIndex = 0;
      this.СomputerLbl.Text = "Назва:";
      // 
      // AddPanel
      // 
      this.AddPanel.Controls.Add(this.AddGBox);
      this.AddPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.AddPanel.Location = new System.Drawing.Point(0, 0);
      this.AddPanel.Name = "AddPanel";
      this.AddPanel.Size = new System.Drawing.Size(365, 560);
      this.AddPanel.TabIndex = 128;
      // 
      // FilmsGridView
      // 
      this.FilmsGridView.AllowUserToAddRows = false;
      this.FilmsGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.FilmsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.FilmsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.FilmsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.FilmsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FilmsGridView.GridColor = System.Drawing.SystemColors.Control;
      this.FilmsGridView.Location = new System.Drawing.Point(365, 0);
      this.FilmsGridView.MultiSelect = false;
      this.FilmsGridView.Name = "FilmsGridView";
      this.FilmsGridView.ReadOnly = true;
      this.FilmsGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FilmsGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.FilmsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.FilmsGridView.Size = new System.Drawing.Size(606, 560);
      this.FilmsGridView.TabIndex = 129;
      this.FilmsGridView.TabStop = false;
      this.FilmsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmsGridView_CellClick);
      // 
      // GraduationYearDTP
      // 
      this.GraduationYearDTP.Location = new System.Drawing.Point(117, 142);
      this.GraduationYearDTP.Name = "GraduationYearDTP";
      this.GraduationYearDTP.Size = new System.Drawing.Size(146, 22);
      this.GraduationYearDTP.TabIndex = 108;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(8, 147);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(92, 16);
      this.label3.TabIndex = 109;
      this.label3.Text = "Дата виходу:";
      // 
      // FilmsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(971, 560);
      this.Controls.Add(this.FilmsGridView);
      this.Controls.Add(this.AddPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FilmsForm";
      this.Text = "Фільми";
      this.AddGBox.ResumeLayout(false);
      this.AddGBox.PerformLayout();
      this.AddPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.FilmsGridView)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.GroupBox AddGBox;
        private System.Windows.Forms.Label CategoryIdValiadtionLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryIdCBox;
        private System.Windows.Forms.Label PriceValiadtionLbl;
        private System.Windows.Forms.TextBox PriceTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label FilmsNameValiadtionLbl;
        private System.Windows.Forms.TextBox DescriptionTBox;
        private System.Windows.Forms.TextBox FilmsNameTBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label СomputerLbl;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.DataGridView FilmsGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker GraduationYearDTP;
    }
}