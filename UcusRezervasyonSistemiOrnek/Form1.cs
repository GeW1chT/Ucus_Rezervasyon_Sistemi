namespace UcusRezervasyonSistemiOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text);
            listBox1.Items.Add("Tarih - Saat: " + dateTimePicker1.Text + " - " + maskedTextBox1.Text);
            listBox1.Items.Add("Ad Soyad: " + textBox1.Text);
            listBox1.Items.Add("TC:" + maskedTextBox2.Text);
            listBox1.Items.Add("Telefon:" + maskedTextBox3.Text);
            MessageBox.Show("Yolcu kaydý yapýldý");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}