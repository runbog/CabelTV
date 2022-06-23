using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CableTVApp.AppCode;
using CableTVApp.Provider;

namespace CableTVApp.Forms.Dictionary {
  public partial class UpdateClientForm : Form {
    private int _ClientId = 0;
    private Client _selectedClient = new Client();
    private ClientProvider _ClientProvider = new ClientProvider();
    private ValidationMy _validation = new ValidationMy();

    public UpdateClientForm(int ClientId) {
      InitializeComponent();
      _ClientId = ClientId;
      LoadAllDate();
    }

    private void SaveBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _ClientProvider.UpdateClient(LastNameTBox.Text, FirstNameTBox.Text, PhoneTBox.Text, _ClientId);
        this.Close();
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Ви дійсно хочете видалити цей елемент?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        _ClientProvider.DeleteClientByClientId(_ClientId);
        this.Close();
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _selectedClient = _ClientProvider.SelectedClientByClientId(_ClientId);
      LastNameTBox.Text = _selectedClient.LastName;
      FirstNameTBox.Text = _selectedClient.FirstName;
      PhoneTBox.Text = _selectedClient.Phone;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(LastNameTBox.Text)) {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(FirstNameTBox.Text)) {
        FirstNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        FirstNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(PhoneTBox.Text)) {
        PhoneValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PhoneValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }
  }
}
