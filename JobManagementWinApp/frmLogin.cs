using JobManagementLibrary.Repository;
using JobManagementLibrary.Repository.IRepository;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace JobManagementWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string pasword = txtPassword.Text;
                IHRAccountRepository hrRepo = new HRAccountRepository();
                bool isSucceed = hrRepo.HRLogin(username, pasword);
                if (isSucceed)
                {
                    frmManagement manageForm = new frmManagement();
                    manageForm.ShowDialog();
                }
                else
                {
                    throw new Exception("Invalid username or pasword");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}