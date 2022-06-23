namespace CableTVApp.Forms.Controls {
  partial class ServicesAndProgramsForm {
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.AddProgramsBtn = new System.Windows.Forms.Button();
      this.MaterialNameValidationLbl = new System.Windows.Forms.Label();
      this.ProgramsGridView = new System.Windows.Forms.DataGridView();
      this.ProgramsCBox = new System.Windows.Forms.ComboBox();
      this.MaterialNameLbl = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.AddServiseBtn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.ServicesGridView = new System.Windows.Forms.DataGridView();
      this.ServicesCBox = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ServicesGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.AddProgramsBtn);
      this.groupBox1.Controls.Add(this.MaterialNameValidationLbl);
      this.groupBox1.Controls.Add(this.ProgramsGridView);
      this.groupBox1.Controls.Add(this.ProgramsCBox);
      this.groupBox1.Controls.Add(this.MaterialNameLbl);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(431, 424);
      this.groupBox1.TabIndex = 25;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Список програм";
      // 
      // AddProgramsBtn
      // 
      this.AddProgramsBtn.Location = new System.Drawing.Point(344, 51);
      this.AddProgramsBtn.Name = "AddProgramsBtn";
      this.AddProgramsBtn.Size = new System.Drawing.Size(81, 23);
      this.AddProgramsBtn.TabIndex = 123;
      this.AddProgramsBtn.Text = "Додати";
      this.AddProgramsBtn.UseVisualStyleBackColor = true;
      this.AddProgramsBtn.Click += new System.EventHandler(this.AddProgramsBtn_Click);
      // 
      // MaterialNameValidationLbl
      // 
      this.MaterialNameValidationLbl.AutoSize = true;
      this.MaterialNameValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.MaterialNameValidationLbl.Location = new System.Drawing.Point(91, 26);
      this.MaterialNameValidationLbl.Name = "MaterialNameValidationLbl";
      this.MaterialNameValidationLbl.Size = new System.Drawing.Size(11, 13);
      this.MaterialNameValidationLbl.TabIndex = 122;
      this.MaterialNameValidationLbl.Text = "*";
      // 
      // ProgramsGridView
      // 
      this.ProgramsGridView.AllowUserToAddRows = false;
      this.ProgramsGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.ProgramsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.ProgramsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.ProgramsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ProgramsGridView.GridColor = System.Drawing.SystemColors.Control;
      this.ProgramsGridView.Location = new System.Drawing.Point(6, 103);
      this.ProgramsGridView.MultiSelect = false;
      this.ProgramsGridView.Name = "ProgramsGridView";
      this.ProgramsGridView.ReadOnly = true;
      this.ProgramsGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ProgramsGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.ProgramsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.ProgramsGridView.Size = new System.Drawing.Size(419, 315);
      this.ProgramsGridView.TabIndex = 89;
      this.ProgramsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProgramsGridView_CellClick);
      // 
      // ProgramsCBox
      // 
      this.ProgramsCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ProgramsCBox.FormattingEnabled = true;
      this.ProgramsCBox.Location = new System.Drawing.Point(116, 21);
      this.ProgramsCBox.Name = "ProgramsCBox";
      this.ProgramsCBox.Size = new System.Drawing.Size(309, 21);
      this.ProgramsCBox.TabIndex = 121;
      // 
      // MaterialNameLbl
      // 
      this.MaterialNameLbl.AutoSize = true;
      this.MaterialNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MaterialNameLbl.Location = new System.Drawing.Point(9, 24);
      this.MaterialNameLbl.Name = "MaterialNameLbl";
      this.MaterialNameLbl.Size = new System.Drawing.Size(76, 16);
      this.MaterialNameLbl.TabIndex = 120;
      this.MaterialNameLbl.Text = "Програми:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.AddServiseBtn);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.ServicesGridView);
      this.groupBox2.Controls.Add(this.ServicesCBox);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Location = new System.Drawing.Point(465, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(431, 424);
      this.groupBox2.TabIndex = 26;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Список послуг";
      // 
      // AddServiseBtn
      // 
      this.AddServiseBtn.Location = new System.Drawing.Point(344, 51);
      this.AddServiseBtn.Name = "AddServiseBtn";
      this.AddServiseBtn.Size = new System.Drawing.Size(81, 23);
      this.AddServiseBtn.TabIndex = 123;
      this.AddServiseBtn.Text = "Додати";
      this.AddServiseBtn.UseVisualStyleBackColor = true;
      this.AddServiseBtn.Click += new System.EventHandler(this.AddServiseBtn_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(72, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(11, 13);
      this.label1.TabIndex = 122;
      this.label1.Text = "*";
      // 
      // ServicesGridView
      // 
      this.ServicesGridView.AllowUserToAddRows = false;
      this.ServicesGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.ServicesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
      this.ServicesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.ServicesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ServicesGridView.GridColor = System.Drawing.SystemColors.Control;
      this.ServicesGridView.Location = new System.Drawing.Point(6, 103);
      this.ServicesGridView.MultiSelect = false;
      this.ServicesGridView.Name = "ServicesGridView";
      this.ServicesGridView.ReadOnly = true;
      this.ServicesGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ServicesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.ServicesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.ServicesGridView.Size = new System.Drawing.Size(419, 315);
      this.ServicesGridView.TabIndex = 89;
      this.ServicesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServicesGridView_CellClick);
      // 
      // ServicesCBox
      // 
      this.ServicesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ServicesCBox.FormattingEnabled = true;
      this.ServicesCBox.Location = new System.Drawing.Point(95, 21);
      this.ServicesCBox.Name = "ServicesCBox";
      this.ServicesCBox.Size = new System.Drawing.Size(330, 21);
      this.ServicesCBox.TabIndex = 121;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(9, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 16);
      this.label2.TabIndex = 120;
      this.label2.Text = "Послуги:";
      // 
      // ServicesAndProgramsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(931, 476);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ServicesAndProgramsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Послуги та програми";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ServicesGridView)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddProgramsBtn;
        private System.Windows.Forms.Label MaterialNameValidationLbl;
        private System.Windows.Forms.DataGridView ProgramsGridView;
        private System.Windows.Forms.ComboBox ProgramsCBox;
        private System.Windows.Forms.Label MaterialNameLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddServiseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ServicesGridView;
        private System.Windows.Forms.ComboBox ServicesCBox;
        private System.Windows.Forms.Label label2;
    }
}