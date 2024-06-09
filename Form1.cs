namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_click;
            button2.Click += button2_click;
        }

        public void button1_click(object sender, EventArgs e)
        {
            TimeSpan ts = dateTimePicker1.Value - dateTimePicker2.Value;

            Label label = new Label();
            label.Text = "Разница во времени: " + ts.ToString();
            label.AutoSize = true;

     
            label.Location = new Point(20, 80); 
            Controls.Add(label);
        }

        public void button2_click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введите количество дней для добавления");

            if (int.TryParse(input, out int daysToAdd))
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(daysToAdd);
                MessageBox.Show($"Результат: {dateTimePicker1.Value.ToShortDateString()}");
            }
            else
            {
                MessageBox.Show("Некорректное значение!");
            }
        }
    }
}
