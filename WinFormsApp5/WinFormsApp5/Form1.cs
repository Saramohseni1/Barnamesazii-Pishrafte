namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] qadstudent = new int[20];
        int count = 0;
        int sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    int i = int.Parse(textBox1.Text);
                    if (count < qadstudent.Length)
                    {
                        qadstudent[count] = i;
                        count++;

                    }

                    for (int j = 0; j < count; j++)
                    {
                        sum += qadstudent[j];
                    }
                    if (count <= 20)
                    {
                        double avg = sum / count;
                        label3.Text = avg.ToString();
                    }
                    else
                    {
                        MessageBox.Show("your job here is now done;please press the empty maker button and move on.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                textBox1.Clear();
            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            count = 0;
            label3.Text = "";
        }

    }
}


