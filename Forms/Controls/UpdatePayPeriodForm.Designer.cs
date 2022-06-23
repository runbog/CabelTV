namespace CableTVApp.Forms.Controls {
  partial class UpdatePayPeriodForm {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.ClientPayDGV = new System.Windows.Forms.DataGridView();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.ClientPayDGV)).BeginInit();
      this.SuspendLayout();
      // 
      // ClientPayDGV
      // 
      this.ClientPayDGV.AllowUserToAddRows = false;
      this.ClientPayDGV.AllowUserToDeleteRows = false;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.ClientPayDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
      this.ClientPayDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ClientPayDGV.GridColor = System.Drawing.SystemColors.Control;
      this.ClientPayDGV.Location = new System.Drawing.Point(12, 12);
      this.ClientPayDGV.MultiSelect = false;
      this.ClientPayDGV.Name = "ClientPayDGV";
      this.ClientPayDGV.RowHeadersWidth = 20;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ClientPayDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
      this.ClientPayDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
      this.ClientPayDGV.Size = new System.Drawing.Size(480, 264);
      this.ClientPayDGV.TabIndex = 119;
      // 
      // ExitBtn
      // 
      this.ExitBtn.Location = new System.Drawing.Point(411, 282);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 118;
      this.ExitBtn.Text = "Вихід";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(306, 282);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 117;
      this.AddBtn.Text = "Зберегти";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // UpdatePayPeriodForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(505, 313);
      this.Controls.Add(this.ClientPayDGV);
      this.Controls.Add(this.ExitBtn);
      this.Controls.Add(this.AddBtn);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UpdatePayPeriodForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Редагувати відомість";
      ((System.ComponentModel.ISupportInitialize)(this.ClientPayDGV)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView ClientPayDGV;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}