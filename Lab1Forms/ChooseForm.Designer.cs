namespace Lab1Forms;

partial class ChooseForm
{
    private void InitializeComponent()
    {
        lblTitle = new Label();
        btnBicycle = new Button();
        btnMushroom = new Button();
        SuspendLayout();

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.Location = new Point(150, 30);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "Choose";

        btnBicycle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnBicycle.Location = new Point(70, 110);
        btnBicycle.Name = "btnBicycle";
        btnBicycle.Size = new Size(140, 48);
        btnBicycle.Text = "Bicycle";

        btnMushroom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnMushroom.Location = new Point(240, 110);
        btnMushroom.Name = "btnMushroom";
        btnMushroom.Size = new Size(140, 48);
        btnMushroom.Text = "Mushroom";

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(460, 230);
        Controls.Add(lblTitle);
        Controls.Add(btnBicycle);
        Controls.Add(btnMushroom);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "ChooseForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Choose";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Button btnBicycle;
    private Button btnMushroom;
}
