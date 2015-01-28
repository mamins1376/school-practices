using System;
using System.Drawing;
using System.Windows.Forms;

public class p130_12 : Form
{
  private TextBox txtCity1, txtCity2, txtCity3, txtCity4, txtCity5, txtCity6, txtCity7, txtCity8, txtCity9, txtCity10;
  private NumericUpDown nudCity1, nudCity2, nudCity3, nudCity4, nudCity5, nudCity6, nudCity7, nudCity8, nudCity9, nudCity10;
  private Button btnAction;
  
  private void InitializeComponent()
  {
    txtCity1 = new TextBox();
    txtCity1.Location = new Point(10, 10);
    txtCity1.Size = new Size(130, 30);
    this.Controls.Add(txtCity1);
    nudCity1 = new NumericUpDown();
    nudCity1.Location = new Point(150, 10);
    nudCity1.Size = new Size(40, 30);
    this.Controls.Add(nudCity1);

    txtCity2 = new TextBox();
    txtCity2.Location = new Point(10, 50);
    txtCity2.Size = new Size(130, 30);
    this.Controls.Add(txtCity2);
    nudCity2 = new NumericUpDown();
    nudCity2.Location = new Point(150, 50);
    nudCity2.Size = new Size(40, 30);
    this.Controls.Add(nudCity2);

    txtCity3 = new TextBox();
    txtCity3.Location = new Point(10, 90);
    txtCity3.Size = new Size(130, 30);
    this.Controls.Add(txtCity3);
    nudCity3 = new NumericUpDown();
    nudCity3.Location = new Point(150, 90);
    nudCity3.Size = new Size(40, 30);
    this.Controls.Add(nudCity3);

    txtCity4 = new TextBox();
    txtCity4.Location = new Point(10, 130);
    txtCity4.Size = new Size(130, 30);
    this.Controls.Add(txtCity4);
    nudCity4 = new NumericUpDown();
    nudCity4.Location = new Point(150, 130);
    nudCity4.Size = new Size(40, 30);
    this.Controls.Add(nudCity4);

    txtCity5 = new TextBox();
    txtCity5.Location = new Point(10, 170);
    txtCity5.Size = new Size(130, 30);
    this.Controls.Add(txtCity5);
    nudCity5 = new NumericUpDown();
    nudCity5.Location = new Point(150, 170);
    nudCity5.Size = new Size(40, 30);
    this.Controls.Add(nudCity5);

    txtCity6 = new TextBox();
    txtCity6.Location = new Point(10, 210);
    txtCity6.Size = new Size(130, 30);
    this.Controls.Add(txtCity6);
    nudCity6 = new NumericUpDown();
    nudCity6.Location = new Point(150, 210);
    nudCity6.Size = new Size(40, 30);
    this.Controls.Add(nudCity6);

    txtCity7 = new TextBox();
    txtCity7.Location = new Point(10, 250);
    txtCity7.Size = new Size(130, 30);
    this.Controls.Add(txtCity7);
    nudCity7 = new NumericUpDown();
    nudCity7.Location = new Point(150, 250);
    nudCity7.Size = new Size(40, 30);
    this.Controls.Add(nudCity7);

    txtCity8 = new TextBox();
    txtCity8.Location = new Point(10, 290);
    txtCity8.Size = new Size(130, 30);
    this.Controls.Add(txtCity8);
    nudCity8 = new NumericUpDown();
    nudCity8.Location = new Point(150, 290);
    nudCity8.Size = new Size(40, 30);
    this.Controls.Add(nudCity8);

    txtCity9 = new TextBox();
    txtCity9.Location = new Point(10, 330);
    txtCity9.Size = new Size(130, 30);
    this.Controls.Add(txtCity9);
    nudCity9 = new NumericUpDown();
    nudCity9.Location = new Point(150, 330);
    nudCity9.Size = new Size(40, 30);
    this.Controls.Add(nudCity9);

    txtCity10 = new TextBox();
    txtCity10.Location = new Point(10, 370);
    txtCity10.Size = new Size(130, 30);
    this.Controls.Add(txtCity10);
    nudCity10 = new NumericUpDown();
    nudCity10.Location = new Point(150, 370);
    nudCity10.Size = new Size(40, 30);
    this.Controls.Add(nudCity10);

    btnAction = new Button();
    btnAction.Location = new Point(10, 410);
    btnAction.Size = new Size(180, 30);
    btnAction.Text = "Enter a number and press me";
    btnAction.Click += new EventHandler(this.btnAction_Click);
    this.Controls.Add(btnAction);
        
    this.ClientSize = new Size(200, 450);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
  }
  
  private void btnAction_Click(object sender, EventArgs args)
  {
    foreach (Control control in this.Controls)
    {
      if (control is NumericUpDown)
      {
        Console.WriteLine(control.Text);
      }
    }
  }
  
  public p130_12()
  {
    InitializeComponent();
  }
  
  public static void Main()
  {
    Application.Run(new p130_12());
  }
}
