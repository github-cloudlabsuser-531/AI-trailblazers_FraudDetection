using System.Windows.Forms.VisualStyles;

namespace AITrailblazers_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            //'Browse'
            OpenFileDialog dia1 = new OpenFileDialog();
            if (dia1.ShowDialog() == DialogResult.OK)
            {
                String file = dia1.FileName;
                string[] f = file.Split('\\');
                string fn = f[(f.Length) - 1];
                uploadIncomeText.Text = fn;
            }
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            // 'Browse'
            OpenFileDialog dia1 = new OpenFileDialog();
            if (dia1.ShowDialog() == DialogResult.OK)
            {
                String file = dia1.FileName;
                string[] f = file.Split('\\');
                string fn = f[(f.Length) - 1];
                bankText.Text = fn;
            }
        }

        private void debtTrap_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void identity_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void upload1_Click(object sender, EventArgs e)
        {
            //Upload
            MessageBox.Show("File Uploaded Successfully");

        }

        private void uploadIncomeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void upload2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Uploaded Successfully");
        }
    }
}
