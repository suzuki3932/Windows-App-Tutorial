using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

public class SampleWindow : Form
{
private Button btn;
private Label label;
public SampleWindow()
{
Text = "hello windows!";
Width = 800;
Height = 600;
label = new Label();
label.Text = "This is my very first Windows Application.";
label.Location = new Point(10, 50);
label.AutoSize = true;
Controls.Add(label);
btn = new Button();
btn.Text = "Click here";
btn.Location = new Point(10, 10);
btn.AutoSize = true;
btn.Click += new EventHandler(btnclick);
Controls.Add(btn);
}

private void btnclick(object sender, EventArgs e)
{
MessageBox.Show("You are Clicked this button!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

[STAThread]
public static void Main()
{
Application.Run(new SampleWindow());
}
}