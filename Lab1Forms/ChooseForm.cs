namespace Lab1Forms;

public partial class ChooseForm : Form
{
    public ChooseForm()
    {
        InitializeComponent();
        btnBicycle.Click += (_, _) => OpenLayout(new BicycleForm());
        btnMushroom.Click += (_, _) => OpenLayout(new MushroomForm());
    }

    private void OpenLayout(Form layout)
    {
        using (layout)
        {
            if (layout.ShowDialog(this) == DialogResult.Abort)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }
    }
}
