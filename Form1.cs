namespace Console_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_2_Click(object sender, EventArgs e)
        {
          
            // Â–« «·”ÿ— Ì√Œ– «·ﬂ·«„ „‰ «·„—»⁄«  ÊÌ÷⁄Â ›Ì «·ÃœÊ· ›Ê—«
            dataGridView1.Rows.Add(textBox1.Text, "Technical Support Request", comboBox1.Text, DateTime.Now.ToShortDateString());

            // ≈ŸÂ«— —”«·…  √ﬂÌœ ··„ÊŸ›
            MessageBox.Show(" „ Õ›Ÿ «· –ﬂ—… »‰Ã«Õ ›Ì «·‰Ÿ«„!");
        }
    }
    }

