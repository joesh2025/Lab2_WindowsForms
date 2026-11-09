namespace Lab1Forms;

partial class LoginForm
{
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        btnLogin = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.Location = new Point(145, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(89, 37);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Login";
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Segoe UI", 11F);
        lblUsername.Location = new Point(48, 95);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(75, 20);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Username";
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Segoe UI", 11F);
        txtUsername.Location = new Point(160, 92);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(200, 27);
        txtUsername.TabIndex = 2;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 11F);
        lblPassword.Location = new Point(48, 145);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(70, 20);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Password";
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 11F);
        txtPassword.Location = new Point(160, 142);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(200, 27);
        txtPassword.TabIndex = 4;
        // 
        // btnLogin
        // 
        btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnLogin.Location = new Point(160, 200);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(120, 38);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Login";
        // 
        // LoginForm
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 280);
        Controls.Add(lblTitle);
        Controls.Add(lblUsername);
        Controls.Add(txtUsername);
        Controls.Add(lblPassword);
        Controls.Add(txtPassword);
        Controls.Add(btnLogin);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Label lblUsername;
    private TextBox txtUsername;
    private Label lblPassword;
    private TextBox txtPassword;
    private Button btnLogin;
}
