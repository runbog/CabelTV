namespace CableTVApp.Forms.Jobs {
  partial class ProgramsJobsForm {
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
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.AddBtn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.СomputerLbl = new System.Windows.Forms.Label();
      this.ProgramsNameTBox = new System.Windows.Forms.TextBox();
      this.AddRabotaBtn = new System.Windows.Forms.Button();
      this.MaterialNameValidationLbl = new System.Windows.Forms.Label();
      this.FilmsDataGridView = new System.Windows.Forms.DataGridView();
      this.FilmsCBox = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.MaterialNameLbl = new System.Windows.Forms.Label();
      this.PriceValiadtionLbl = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.PriceTBox = new System.Windows.Forms.TextBox();
      this.ProgramsNameValiadtionLbl = new System.Windows.Forms.Label();
      this.AddGBox = new System.Windows.Forms.GroupBox();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.AddPanel = new System.Windows.Forms.Panel();
      this.ProgramsGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.FilmsDataGridView)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.AddGBox.SuspendLayout();
      this.AddPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // DescriptionTBox
      // 
      this.DescriptionTBox.Location = new System.Drawing.Point(15, 125);
      this.DescriptionTBox.MaxLength = 300;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DescriptionTBox.Size = new System.Drawing.Size(425, 163);
      this.DescriptionTBox.TabIndex = 139;
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(152, 589);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 6;
      this.AddBtn.Text = "Додати";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 106);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 16);
      this.label1.TabIndex = 138;
      this.label1.Text = "Опис";
      // 
      // СomputerLbl
      // 
      this.СomputerLbl.AutoSize = true;
      this.СomputerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.СomputerLbl.Location = new System.Drawing.Point(12, 18);
      this.СomputerLbl.Name = "СomputerLbl";
      this.СomputerLbl.Size = new System.Drawing.Size(53, 16);
      this.СomputerLbl.TabIndex = 135;
      this.СomputerLbl.Text = "Назва:";
      // 
      // ProgramsNameTBox
      // 
      this.ProgramsNameTBox.Location = new System.Drawing.Point(15, 37);
      this.ProgramsNameTBox.MaxLength = 200;
      this.ProgramsNameTBox.Name = "ProgramsNameTBox";
      this.ProgramsNameTBox.Size = new System.Drawing.Size(425, 22);
      this.ProgramsNameTBox.TabIndex = 136;
      // 
      // AddRabotaBtn
      // 
      this.AddRabotaBtn.Location = new System.Drawing.Point(344, 51);
      this.AddRabotaBtn.Name = "AddRabotaBtn";
      this.AddRabotaBtn.Size = new System.Drawing.Size(81, 23);
      this.AddRabotaBtn.TabIndex = 123;
      this.AddRabotaBtn.Text = "Додати";
      this.AddRabotaBtn.UseVisualStyleBackColor = true;
      this.AddRabotaBtn.Click += new System.EventHandler(this.AddRabotaBtn_Click);
      // 
      // MaterialNameValidationLbl
      // 
      this.MaterialNameValidationLbl.AutoSize = true;
      this.MaterialNameValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.MaterialNameValidationLbl.Location = new System.Drawing.Point(72, 29);
      this.MaterialNameValidationLbl.Name = "MaterialNameValidationLbl";
      this.MaterialNameValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.MaterialNameValidationLbl.TabIndex = 122;
      this.MaterialNameValidationLbl.Text = "*";
      // 
      // FilmsDataGridView
      // 
      this.FilmsDataGridView.AllowUserToAddRows = false;
      this.FilmsDataGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.FilmsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.FilmsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.FilmsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.FilmsDataGridView.GridColor = System.Drawing.SystemColors.Control;
      this.FilmsDataGridView.Location = new System.Drawing.Point(6, 103);
      this.FilmsDataGridView.MultiSelect = false;
      this.FilmsDataGridView.Name = "FilmsDataGridView";
      this.FilmsDataGridView.ReadOnly = true;
      this.FilmsDataGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FilmsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.FilmsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.FilmsDataGridView.Size = new System.Drawing.Size(419, 171);
      this.FilmsDataGridView.TabIndex = 89;
      // 
      // FilmsCBox
      // 
      this.FilmsCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.FilmsCBox.FormattingEnabled = true;
      this.FilmsCBox.Location = new System.Drawing.Point(95, 21);
      this.FilmsCBox.Name = "FilmsCBox";
      this.FilmsCBox.Size = new System.Drawing.Size(330, 24);
      this.FilmsCBox.TabIndex = 121;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(15, 71);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(39, 16);
      this.label6.TabIndex = 141;
      this.label6.Text = "Ціна:";
      // 
      // ClearBtn
      // 
      this.ClearBtn.Location = new System.Drawing.Point(254, 589);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(81, 23);
      this.ClearBtn.TabIndex = 7;
      this.ClearBtn.Text = "Очистити";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // MaterialNameLbl
      // 
      this.MaterialNameLbl.AutoSize = true;
      this.MaterialNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MaterialNameLbl.Location = new System.Drawing.Point(9, 24);
      this.MaterialNameLbl.Name = "MaterialNameLbl";
      this.MaterialNameLbl.Size = new System.Drawing.Size(49, 16);
      this.MaterialNameLbl.TabIndex = 120;
      this.MaterialNameLbl.Text = "Фільм:";
      // 
      // PriceValiadtionLbl
      // 
      this.PriceValiadtionLbl.AutoSize = true;
      this.PriceValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.PriceValiadtionLbl.Location = new System.Drawing.Point(70, 71);
      this.PriceValiadtionLbl.Name = "PriceValiadtionLbl";
      this.PriceValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.PriceValiadtionLbl.TabIndex = 142;
      this.PriceValiadtionLbl.Text = "*";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.AddRabotaBtn);
      this.groupBox1.Controls.Add(this.MaterialNameValidationLbl);
      this.groupBox1.Controls.Add(this.FilmsDataGridView);
      this.groupBox1.Controls.Add(this.FilmsCBox);
      this.groupBox1.Controls.Add(this.MaterialNameLbl);
      this.groupBox1.Location = new System.Drawing.Point(9, 294);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(431, 280);
      this.groupBox1.TabIndex = 24;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Список фільмів";
      // 
      // PriceTBox
      // 
      this.PriceTBox.Location = new System.Drawing.Point(89, 68);
      this.PriceTBox.MaxLength = 12;
      this.PriceTBox.Name = "PriceTBox";
      this.PriceTBox.Size = new System.Drawing.Size(136, 22);
      this.PriceTBox.TabIndex = 140;
      this.PriceTBox.Text = "0";
      this.PriceTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // ProgramsNameValiadtionLbl
      // 
      this.ProgramsNameValiadtionLbl.AutoSize = true;
      this.ProgramsNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.ProgramsNameValiadtionLbl.Location = new System.Drawing.Point(95, 18);
      this.ProgramsNameValiadtionLbl.Name = "ProgramsNameValiadtionLbl";
      this.ProgramsNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.ProgramsNameValiadtionLbl.TabIndex = 137;
      this.ProgramsNameValiadtionLbl.Text = "*";
      // 
      // AddGBox
      // 
      this.AddGBox.Controls.Add(this.PriceValiadtionLbl);
      this.AddGBox.Controls.Add(this.groupBox1);
      this.AddGBox.Controls.Add(this.PriceTBox);
      this.AddGBox.Controls.Add(this.ExitBtn);
      this.AddGBox.Controls.Add(this.label6);
      this.AddGBox.Controls.Add(this.ClearBtn);
      this.AddGBox.Controls.Add(this.DescriptionTBox);
      this.AddGBox.Controls.Add(this.AddBtn);
      this.AddGBox.Controls.Add(this.label1);
      this.AddGBox.Controls.Add(this.СomputerLbl);
      this.AddGBox.Controls.Add(this.ProgramsNameValiadtionLbl);
      this.AddGBox.Controls.Add(this.ProgramsNameTBox);
      this.AddGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddGBox.Location = new System.Drawing.Point(12, 12);
      this.AddGBox.Name = "AddGBox";
      this.AddGBox.Size = new System.Drawing.Size(446, 627);
      this.AddGBox.TabIndex = 2;
      this.AddGBox.TabStop = false;
      this.AddGBox.Text = "Додати";
      // 
      // ExitBtn
      // 
      this.ExitBtn.Location = new System.Drawing.Point(353, 589);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 8;
      this.ExitBtn.Text = "Вихід";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // AddPanel
      // 
      this.AddPanel.Controls.Add(this.AddGBox);
      this.AddPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.AddPanel.Location = new System.Drawing.Point(0, 0);
      this.AddPanel.Name = "AddPanel";
      this.AddPanel.Size = new System.Drawing.Size(469, 624);
      this.AddPanel.TabIndex = 86;
      // 
      // ProgramsGridView
      // 
      this.ProgramsGridView.AllowUserToAddRows = false;
      this.ProgramsGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.ProgramsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
      this.ProgramsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.ProgramsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ProgramsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ProgramsGridView.GridColor = System.Drawing.SystemColors.Control;
      this.ProgramsGridView.Location = new System.Drawing.Point(469, 0);
      this.ProgramsGridView.MultiSelect = false;
      this.ProgramsGridView.Name = "ProgramsGridView";
      this.ProgramsGridView.ReadOnly = true;
      this.ProgramsGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ProgramsGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.ProgramsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.ProgramsGridView.Size = new System.Drawing.Size(565, 624);
      this.ProgramsGridView.TabIndex = 87;
      this.ProgramsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProgramsGridView_CellClick);
      // 
      // ProgramsJobsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1034, 624);
      this.Controls.Add(this.ProgramsGridView);
      this.Controls.Add(this.AddPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ProgramsJobsForm";
      this.Text = "Програми";
      ((System.ComponentModel.ISupportInitialize)(this.FilmsDataGridView)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.AddGBox.ResumeLayout(false);
      this.AddGBox.PerformLayout();
      this.AddPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TextBox DescriptionTBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label СomputerLbl;
        private System.Windows.Forms.TextBox ProgramsNameTBox;
        private System.Windows.Forms.Button AddRabotaBtn;
        private System.Windows.Forms.Label MaterialNameValidationLbl;
        private System.Windows.Forms.DataGridView FilmsDataGridView;
        private System.Windows.Forms.ComboBox FilmsCBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label MaterialNameLbl;
        private System.Windows.Forms.Label PriceValiadtionLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PriceTBox;
        private System.Windows.Forms.Label ProgramsNameValiadtionLbl;
        private System.Windows.Forms.GroupBox AddGBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.DataGridView ProgramsGridView;
    }
}