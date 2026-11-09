namespace Lab1Forms;

public partial class MushroomForm : Form
{
    private int step;

    public MushroomForm()
    {
        InitializeComponent();
        btnYes.Click += (_, _) => Answer(true);
        btnNo.Click += (_, _) => Answer(false);
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
        ShowQuestion();
    }

    private void ShowQuestion()
    {
        if (step == 0)
            lblQuestion.Text = "Does your mushroom grow in a forest?";
        else if (step == 1)
            lblQuestion.Text = "Does your mushroom have a convex cup?";
        else if (step == 2 && growsInForest && convexCup)
            lblQuestion.Text = "Does your mushroom have a ring?";
        else
            lblQuestion.Text = "Does your mushroom have gills?";
    }

    private bool growsInForest;
    private bool convexCup;

    private void Answer(bool yes)
    {
        if (step == 0)
        {
            growsInForest = yes;
            step = 1;
            ShowQuestion();
            return;
        }

        if (step == 1)
        {
            convexCup = yes;
            if (!growsInForest)
            {
                Finish(yes ? "Agaric jaunissant" : "Coprin chevelu");
                return;
            }

            step = 2;
            ShowQuestion();
            return;
        }

        if (growsInForest && convexCup)
            Finish(yes ? "Amanite tue-mouches" : "Pied bleu");
        else
            Finish(yes ? "Girolle" : "Cepe de Bordeaux");
    }

    private void Finish(string mushroom)
    {
        MessageBox.Show("Your mushroom is: " + mushroom, "Mushroom", MessageBoxButtons.OK, MessageBoxIcon.Information);
        step = 0;
        ShowQuestion();
    }
}
