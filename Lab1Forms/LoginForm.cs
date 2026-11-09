namespace Lab1Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        btnLogin.Click += BtnLogin_Click;
    }

    private void BtnLogin_Click(object? sender, EventArgs e)
    {
        if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
        {
            MessageBox.Show("Enter your username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Hide();
        using ChooseForm choose = new ChooseForm();
        choose.ShowDialog(this);
        txtPassword.Clear();
        Show();
        txtUsername.Focus();
    }

}
