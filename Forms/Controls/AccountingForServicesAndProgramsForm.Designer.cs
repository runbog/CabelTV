namespace CableTVApp.Forms.Controls {
  partial class AccountingForServicesAndProgramsForm {
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
      this.ClientGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // ClientGridView
      // 
      this.ClientGridView.AllowUserToAddRows = false;
      this.ClientGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.ClientGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.ClientGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.ClientGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ClientGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ClientGridView.GridColor = System.Drawing.SystemColors.Control;
      this.ClientGridView.Location = new System.Drawing.Point(0, 0);
      this.ClientGridView.MultiSelect = false;
      this.ClientGridView.Name = "ClientGridView";
      this.ClientGridView.ReadOnly = true;
      this.ClientGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ClientGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.ClientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.ClientGridView.Size = new System.Drawing.Size(924, 523);
      this.ClientGridView.TabIndex = 90;
      this.ClientGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView_CellClick);
      // 
      // AccountingForServicesAndProgramsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(924, 523);
      this.Controls.Add(this.ClientGridView);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AccountingForServicesAndProgramsForm";
      this.Text = "Облік послуг/програм";
      ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView ClientGridView;
    }
}