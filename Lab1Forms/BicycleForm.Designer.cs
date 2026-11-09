namespace Lab1Forms;

partial class BicycleForm
{
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblStart = new Label();
        txtStart = new TextBox();
        lblEnd = new Label();
        txtEnd = new TextBox();
        btnCalculate = new Button();
        lblTotal = new Label();
        txtTotal = new TextBox();
        btnLogout = new Button();
        btnBack = new Button();
        SuspendLayout();

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(24, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "Bicycle";

        lblStart.AutoSize = true;
        lblStart.Font = new Font("Segoe UI", 11F);
        lblStart.Location = new Point(28, 75);
        lblStart.Name = "lblStart";
        lblStart.Text = "Starting hour (0-23)";

        txtStart.Font = new Font("Segoe UI", 11F);
        txtStart.Location = new Point(220, 72);
        txtStart.Name = "txtStart";
        txtStart.Size = new Size(180, 27);

        lblEnd.AutoSize = true;
        lblEnd.Font = new Font("Segoe UI", 11F);
        lblEnd.Location = new Point(28, 120);
        lblEnd.Name = "lblEnd";
        lblEnd.Text = "Ending hour (1-24)";

        txtEnd.Font = new Font("Segoe UI", 11F);
        txtEnd.Location = new Point(220, 117);
        txtEnd.Name = "txtEnd";
        txtEnd.Size = new Size(180, 27);

        btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnCalculate.Location = new Point(220, 165);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(180, 36);
        btnCalculate.Text = "Calculate";

        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTotal.Location = new Point(28, 225);
        lblTotal.Name = "lblTotal";
        lblTotal.Text = "Total";

        txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        txtTotal.Location = new Point(100, 222);
        txtTotal.Name = "txtTotal";
        txtTotal.ReadOnly = true;
        txtTotal.Size = new Size(300, 29);

        btnLogout.Font = new Font("Segoe UI", 11F);
        btnLogout.Location = new Point(28, 280);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(120, 36);
        btnLogout.Text = "Logout";

        btnBack.Font = new Font("Segoe UI", 11F);
        btnBack.Location = new Point(165, 280);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(120, 36);
        btnBack.Text = "Back";

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 340);
        Controls.Add(lblTitle);
        Controls.Add(lblStart);
        Controls.Add(txtStart);
        Controls.Add(lblEnd);
        Controls.Add(txtEnd);
        Controls.Add(btnCalculate);
        Controls.Add(lblTotal);
        Controls.Add(txtTotal);
        Controls.Add(btnLogout);
        Controls.Add(btnBack);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "BicycleForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bicycle";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Label lblStart;
    private TextBox txtStart;
    private Label lblEnd;
    private TextBox txtEnd;
    private Button btnCalculate;
    private Label lblTotal;
    private TextBox txtTotal;
    private Button btnLogout;
    private Button btnBack;
}
