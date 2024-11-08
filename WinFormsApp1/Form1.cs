using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                comboBox3.Items.Add(colorDialog1.Color.Name);
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Items.Add(fontDialog1.Font.Name);
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                comboBox2.Items.Add(fontDialog1.Font.Size);
                textBox1.Font = new Font(textBox1.Font.FontFamily, fontDialog1.Font.Size);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox2.Text == "Enter Name and Load File..." || string.IsNullOrEmpty(textBox2.Text))
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Metin Dosyalar (*.txt)|*.txt";
                openFileDialog1.Title = "Bir dosya seçin";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string file = openFileDialog1.FileName;
                    try
                    {
                        string metn = File.ReadAllText(file);
                        textBox1.Text = metn;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File Acila Bilmedi: " + ex.Message);
                    }
                }
            }
            else
            {
                if (File.Exists(textBox2.Text))
                {
                    try
                    {
                        string metn = File.ReadAllText(textBox2.Text);
                        textBox1.Text = metn;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File Acila Bilmedi: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Bele File Yoxdu.");
                }
            }

            textBox2.Text = "Enter Name and Load File...";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(textBox3.Text== "Tap To Enter Name And Save..." || string.IsNullOrEmpty(textBox3.Text))
            {
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Metin Dosyaları (*.txt)|*.txt";
                saveFileDialog1.Title = "Dosya Kaydet";
                saveFileDialog1.FileName = "EnSon.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = saveFileDialog1.FileName;
                    File.WriteAllText(dosyaYolu, textBox1.Text);
                    textBox1.Text = "";
                }
            }
            else
            {
                FileInfo fileInfo = new FileInfo(textBox3.Text);
                if (fileInfo.Length!= 0)
                {
                    try
                    {
                        string metn = File.ReadAllText(textBox3.Text);
                        metn += '\n';
                        metn += textBox1.Text;
                        File.WriteAllText(textBox3.Text, metn);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File Acila Bilmedi: " + ex.Message);
                    }
                }
                else
                {
                    File.WriteAllText(textBox3.Text, textBox1.Text);
                }
                textBox1.Text = "";
            }

            textBox3.Text = "Tap To Enter Name And Save...";




        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}