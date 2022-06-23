namespace CableTVApp.Forms.Dictionary {
  partial class CategoryForm {
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
      this.CategoryGridView = new System.Windows.Forms.DataGridView();
      this.CategoryNameValiadtionLbl = new System.Windows.Forms.Label();
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.CategoryNameTBox = new System.Windows.Forms.TextBox();
      this.DescriptionLbl = new System.Windows.Forms.Label();
      this.СomputerLbl = new System.Windows.Forms.Label();
      this.AddGBox = new System.Windows.Forms.GroupBox();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      this.AddPanel = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
      this.AddGBox.SuspendLayout();
      this.AddPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // CategoryGridView
      // 
      this.CategoryGridView.AllowUserToAddRows = false;
      this.CategoryGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.CategoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.CategoryGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.CategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.CategoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CategoryGridView.GridColor = System.Drawing.SystemColors.Control;
      this.CategoryGridView.Location = new System.Drawing.Point(365, 0);
      this.CategoryGridView.MultiSelect = false;
      this.CategoryGridView.Name = "CategoryGridView";
      this.CategoryGridView.ReadOnly = true;
      this.CategoryGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CategoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.CategoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.CategoryGridView.Size = new System.Drawing.Size(473, 520);
      this.CategoryGridView.TabIndex = 125;
      this.CategoryGridView.TabStop = false;
      this.CategoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellClick);
      // 
      // CategoryNameValiadtionLbl
      // 
      this.CategoryNameValiadtionLbl.AutoSize = true;
      this.CategoryNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.CategoryNameValiadtionLbl.Location = new System.Drawing.Point(89, 22);
      this.CategoryNameValiadtionLbl.Name = "CategoryNameValiadtionLbl";
      this.CategoryNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.CategoryNameValiadtionLbl.TabIndex = 23;
      this.CategoryNameValiadtionLbl.Text = "*";
      // 
      // DescriptionTBox
      // 
      this.DescriptionTBox.Location = new System.Drawing.Point(9, 96);
      this.DescriptionTBox.MaxLength = 1500;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.Size = new System.Drawing.Size(319, 156);
      this.DescriptionTBox.TabIndex = 2;
      // 
      // CategoryNameTBox
      // 
      this.CategoryNameTBox.Location = new System.Drawing.Point(6, 41);
      this.CategoryNameTBox.MaxLength = 250;
      this.CategoryNameTBox.Name = "CategoryNameTBox";
      this.CategoryNameTBox.Size = new System.Drawing.Size(323, 22);
      this.CategoryNameTBox.TabIndex = 1;
      // 
      // DescriptionLbl
      // 
      this.DescriptionLbl.AutoSize = true;
      this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.DescriptionLbl.Location = new System.Drawing.Point(6, 77);
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
      // AddGBox
      // 
      this.AddGBox.Controls.Add(this.ExitBtn);
      this.AddGBox.Controls.Add(this.ClearBtn);
      this.AddGBox.Controls.Add(this.AddBtn);
      this.AddGBox.Controls.Add(this.CategoryNameValiadtionLbl);
      this.AddGBox.Controls.Add(this.DescriptionTBox);
      this.AddGBox.Controls.Add(this.CategoryNameTBox);
      this.AddGBox.Controls.Add(this.DescriptionLbl);
      this.AddGBox.Controls.Add(this.СomputerLbl);
      this.AddGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddGBox.Location = new System.Drawing.Point(12, 12);
      this.AddGBox.Name = "AddGBox";
      this.AddGBox.Size = new System.Drawing.Size(335, 318);
      this.AddGBox.TabIndex = 0;
      this.AddGBox.TabStop = false;
      this.AddGBox.Text = "Додати";
      // 
      // ExitBtn
      // 
      this.ExitBtn.Location = new System.Drawing.Point(248, 272);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 5;
      this.ExitBtn.Text = "Вихід";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // ClearBtn
      // 
      this.ClearBtn.Location = new System.Drawing.Point(146, 272);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(81, 23);
      this.ClearBtn.TabIndex = 4;
      this.ClearBtn.Text = "Очистити";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(44, 272);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 3;
      this.AddBtn.Text = "Додати";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // AddPanel
      // 
      this.AddPanel.Controls.Add(this.AddGBox);
      this.AddPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.AddPanel.Location = new System.Drawing.Point(0, 0);
      this.AddPanel.Name = "AddPanel";
      this.AddPanel.Size = new System.Drawing.Size(365, 520);
      this.AddPanel.TabIndex = 124;
      // 
      // CategoryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(838, 520);
      this.Controls.Add(this.CategoryGridView);
      this.Controls.Add(this.AddPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CategoryForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Категорії";
      ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
      this.AddGBox.ResumeLayout(false);
      this.AddGBox.PerformLayout();
      this.AddPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView CategoryGridView;
    private System.Windows.Forms.Label CategoryNameValiadtionLbl;
    private System.Windows.Forms.TextBox DescriptionTBox;
    private System.Windows.Forms.TextBox CategoryNameTBox;
    private System.Windows.Forms.Label DescriptionLbl;
    private System.Windows.Forms.Label СomputerLbl;
    private System.Windows.Forms.GroupBox AddGBox;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Button ClearBtn;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.Panel AddPanel;
  }
}