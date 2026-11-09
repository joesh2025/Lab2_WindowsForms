namespace Lab1Forms;

partial class MushroomForm
{
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblList = new Label();
        lblQuestion = new Label();
        btnYes = new Button();
        btnNo = new Button();
        btnLogout = new Button();
        btnBack = new Button();
        SuspendLayout();

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(24, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "Mushroom";

        lblList.Font = new Font("Segoe UI", 10F);
        lblList.Location = new Point(28, 60);
        lblList.Name = "lblList";
        lblList.Size = new Size(460, 90);
        lblList.Text = "Agaric jaunissant, Amanite tue-mouches, Cepe de Bordeaux,\r\nCoprin chevelu, Girolle, Pied bleu";

        lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblQuestion.Location = new Point(28, 160);
        lblQuestion.Name = "lblQuestion";
        lblQuestion.Size = new Size(460, 55);
        lblQuestion.Text = "Does your mushroom grow in a forest?";

        btnYes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnYes.Location = new Point(28, 230);
        btnYes.Name = "btnYes";
        btnYes.Size = new Size(120, 40);
        btnYes.Text = "Yes";

        btnNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnNo.Location = new Point(165, 230);
        btnNo.Name = "btnNo";
        btnNo.Size = new Size(120, 40);
        btnNo.Text = "No";

        btnLogout.Font = new Font("Segoe UI", 11F);
        btnLogout.Location = new Point(28, 290);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(120, 36);
        btnLogout.Text = "Logout";

        btnBack.Font = new Font("Segoe UI", 11F);
        btnBack.Location = new Point(165, 290);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(120, 36);
        btnBack.Text = "Back";

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(520, 350);
        Controls.Add(lblTitle);
        Controls.Add(lblList);
        Controls.Add(lblQuestion);
        Controls.Add(btnYes);
        Controls.Add(btnNo);
        Controls.Add(btnLogout);
        Controls.Add(btnBack);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "MushroomForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Mushroom";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Label lblList;
    private Label lblQuestion;
    private Button btnYes;
    private Button btnNo;
    private Button btnLogout;
    private Button btnBack;
}
