using System;
using System.Drawing;
using System.Windows.Forms;

public class p130_13 : Form
{
  private TextBox txtNumA;
  private TextBox txtNumB;
  private Label lblSum;
  private Label lblDif;
  private Label lblMul;
  public static void Main()
  {
    Application.Run(new p130_13());
  }
  public p130_13()
  {
    InitializeComponent();
  }
  private void InitializeComponent()
  {
    // initialize form
    this.ClientSize = new Size(160, 180);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    
    // txtNumA
    txtNumA = new TextBox();
    txtNumA.Location = new Point(20, 20);
    txtNumA.Width = 120;
    txtNumA.TextAlign = HorizontalAlignment.Center;
    txtNumA.TextChanged += new EventHandler(this.Number_Entered);
    this.Controls.Add(txtNumA);

    // txtNumB
    txtNumB = new TextBox();
    txtNumB.Location = new Point(20, 50);
    txtNumB.Width = 120;
    txtNumB.TextAlign = HorizontalAlignment.Center;
    txtNumB.TextChanged += new EventHandler(this.Number_Entered);
    this.Controls.Add(txtNumB);

    // lblSum
    lblSum = new Label();
    lblSum.Location = new Point(20, 80);
    lblSum.Size = new Size(120, 30);
    lblSum.TextAlign = ContentAlignment.MiddleCenter;
    lblSum.Text = "Enter";
    this.Controls.Add(lblSum);
    
    // lblDif
    lblDif = new Label();
    lblDif.Location = new Point(20, 110);
    lblDif.Size = new Size(120, 30);
    lblDif.TextAlign = ContentAlignment.MiddleCenter;
    lblDif.Text = "Your";
    this.Controls.Add(lblDif);
    
    // lblMul
    lblMul = new Label();
    lblMul.Location = new Point(20, 140);
    lblMul.Size = new Size(120, 30);
    lblMul.TextAlign = ContentAlignment.MiddleCenter;
    lblMul.Text = "Numbers";
    this.Controls.Add(lblMul);
  }
  protected void Number_Entered(object sender, EventArgs args)
  {
    try
    {
      decimal NumA = Convert.ToDecimal(txtNumA.Text);
      decimal NumB = Convert.ToDecimal(txtNumB.Text);
      lblSum.Text = "+: " + Convert.ToString(NumA + NumB);
      lblDif.Text = "-: " + Convert.ToString(NumA - NumB);
      lblMul.Text = "*: " + Convert.ToString(NumA * NumB);
    }
    catch
    {
      lblSum.Text = "Enter";
      lblDif.Text = "True";
      lblMul.Text = "Numbers!";
    }
  }
}
