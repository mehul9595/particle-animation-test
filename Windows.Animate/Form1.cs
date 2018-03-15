using AnimateLib;
using System;
using System.Windows.Forms;

namespace WindowsAnimate
{
    public partial class frmAnimate : Form
    {
        public frmAnimate()
        {
            InitializeComponent();
        }

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            try
            {
                int speed = int.Parse(txtSpeed.Text);
                string init = txtInit.Text;
                
                var result = Animation.Animate(speed, init);

                rchTxtbox.Text = "{ " + string.Join(", " + Environment.NewLine, result) + " }";
            }
            catch (Exception ex)
            {
                rchTxtbox.Text = ex.Message;
            }            
        }

        private void frmAnimate_Load(object sender, EventArgs e)
        {

        }
    }
}
