using CableTVApp.Forms.Controls;
using CableTVApp.Forms.Dictionary;
using CableTVApp.Forms.Jobs;
using CableTVApp.Forms.Raport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableTVApp {
  public partial class CableTVMDI : Form {

    public CableTVMDI() {
      InitializeComponent();
    }

    public void CloseAllWindows() {
      Form[] childArray = this.MdiChildren;
      foreach (Form childForm in childArray) {
        childForm.Close();
      }
    }

    private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      ClientForm clientForm = new ClientForm();
      clientForm.MdiParent = this;
      clientForm.WindowState = FormWindowState.Maximized;
      clientForm.Show();
    }

    private void послугиToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      ServisesJobsForm servisesJobsForm = new ServisesJobsForm();
      servisesJobsForm.MdiParent = this;
      servisesJobsForm.WindowState = FormWindowState.Maximized;
      servisesJobsForm.Show();
    }

    private void категоріїToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      CategoryForm сategoryForm = new CategoryForm();
      сategoryForm.MdiParent = this;
      сategoryForm.WindowState = FormWindowState.Maximized;
      сategoryForm.Show();
    }

    private void програмиToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      ProgramsJobsForm programsJobsForm = new ProgramsJobsForm();
      programsJobsForm.MdiParent = this;
      programsJobsForm.WindowState = FormWindowState.Maximized;
      programsJobsForm.Show();
    }

    private void фільмиToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      FilmsForm filmsForm = new FilmsForm();
      filmsForm.MdiParent = this;
      filmsForm.WindowState = FormWindowState.Maximized;
      filmsForm.Show();
    }

    private void зПослугамиToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      ServisesJobsForm servisesJobsForm = new ServisesJobsForm();
      servisesJobsForm.MdiParent = this;
      servisesJobsForm.WindowState = FormWindowState.Maximized;
      servisesJobsForm.Show();
    }

    private void облікПослугToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      AccountingForServicesAndProgramsForm accountingForServicesAndProgramsForm = new AccountingForServicesAndProgramsForm();
      accountingForServicesAndProgramsForm.MdiParent = this;
      accountingForServicesAndProgramsForm.WindowState = FormWindowState.Maximized;
      accountingForServicesAndProgramsForm.Show();
    }

    private void оплатаToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      PayPeriodForm payPeriodForm = new PayPeriodForm();
      payPeriodForm.MdiParent = this;
      payPeriodForm.WindowState = FormWindowState.Maximized;
      payPeriodForm.Show();
    }

    private void вихідToolStripMenuItem_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void рейтинговийЗвітToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      RatingForm ratingForm = new RatingForm();
      ratingForm.MdiParent = this;
      ratingForm.WindowState = FormWindowState.Maximized;
      ratingForm.Show();
    }

    private void списокБоржниківToolStripMenuItem_Click(object sender, EventArgs e) {
      CloseAllWindows();
      DebtorsForm debtorsForm = new DebtorsForm();
      debtorsForm.MdiParent = this;
      debtorsForm.WindowState = FormWindowState.Maximized;
      debtorsForm.Show();
    }

        private void CableTVMDI_Resize(object sender, EventArgs e) {
      this.BackgroundImage = Properties.Resources.Back_img;
        }
    }
}
