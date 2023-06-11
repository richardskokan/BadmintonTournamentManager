using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using AppContext = BadmintonTournamentManager.Model.Common.AppContext;

namespace BadmintonTournamentManager.View.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AppContext AppContext;
        private bool _loggedIn = false;

        public LoginForm(AppContext appContext)
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            AppContext = appContext;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var passwordHash = new byte[0];

            using (SHA512 sha = SHA512.Create())
            {
                var passwordBytes = Encoding.UTF8.GetBytes(passwordTextBox.Text);
                passwordHash = sha.ComputeHash(passwordBytes);
            }

            if (!AppContext.Users.Login(usernameTextBox.Text, passwordHash))
                MessageBox.Show("Username and password combination is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ContinueToApp();
        }

        private void GuestLoginButton_Click(object sender, EventArgs e)
        {
            ContinueToApp();
        }

        private void ContinueToApp()
        {
            _loggedIn = true;

            Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_loggedIn)
                return;

            Application.Exit();
        }
    }
}
