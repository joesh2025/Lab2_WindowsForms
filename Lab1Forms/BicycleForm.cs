namespace Lab1Forms;

public partial class BicycleForm : Form
{
    public BicycleForm()
    {
        InitializeComponent();
        btnCalculate.Click += BtnCalculate_Click;
        btnBack.Click += (_, _) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };
        btnLogout.Click += (_, _) =>
        {
            DialogResult = DialogResult.Abort;
            Close();
        };
    }

    private void BtnCalculate_Click(object? sender, EventArgs e)
    {
        int startHour;
        int endHour;

        if (!int.TryParse(txtStart.Text.Trim(), out startHour) || startHour < 0 || startHour > 23)
        {
            MessageBox.Show("Starting hour must be a whole number from 0 to 23.", "Bicycle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!int.TryParse(txtEnd.Text.Trim(), out endHour) || endHour < 1 || endHour > 24)
        {
            MessageBox.Show("Ending hour must be a whole number from 1 to 24.", "Bicycle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (startHour >= endHour)
        {
            MessageBox.Show("Starting hour must be less than ending hour.", "Bicycle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int total = 0;
        for (int hour = startHour; hour < endHour; hour++)
            total = total + RateForHour(hour);

        txtTotal.Text = total + " RWF";
    }

    static int RateForHour(int hour)
    {
        if (hour < 7)
            return 500;
        if (hour < 14)
            return 1000;
        if (hour < 19)
            return 1500;
        if (hour < 21)
            return 1000;

        return 500;
    }
}
