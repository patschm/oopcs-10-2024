namespace Grafies;

internal class Program
{
    static void Main(string[] args)
    {
        Form f1 = new Form();
        f1.Height = 300;
        f1.Width = 400;
        f1.Text = "Hello";

        Button btn = new Button();
        btn.Text = "Click Me!";
        btn.Location = new Point(100, 100);
        btn.Click += MakeOrange;

        f1.Controls.Add(btn);

        f1.ShowDialog();
    }

    static void MakeOrange(object? sender, EventArgs e)
    {
       Button? btn =sender as Button;
        if (btn != null && btn.Parent != null)
        {
            btn.Parent.BackColor = Color.Orange;

        }
    }
}
