namespace bai20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Nhóm 1")
            {
                listNhom1.Items.Add(textBox1.Text);
                label6.Text = "Tổng số" + listNhom1.Items.Count;
            }
            else
            {
                listNhom2.Items.Add(textBox1.Text);
                label7.Text = "Tổng số" + listNhom2.Items.Count;
            }
            textBox1.Focus();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listNhom1.SelectedItems != null)
            {
                listNhom2.Items.Add(listNhom1.SelectedItems);
                listNhom1.Items.Remove(listNhom1.SelectedItems);
                label6.Text = "Tổng số" + listNhom1.Items.Count;
                label7.Text = "Tổng số" + listNhom2.Items.Count;
            }    
        }
    }
}