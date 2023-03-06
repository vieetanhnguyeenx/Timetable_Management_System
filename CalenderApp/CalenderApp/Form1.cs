namespace CalenderApp
{
    public partial class Form1 : Form
    {

        #region Properties;
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public Form1()
        {
            InitializeComponent();
            LoadTimetableMatrix();
        }

        void LoadTimetableMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            int space = 0;
            for (int i = 0; i < Cons.columnWeek; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.dayOfWeek; j++)
                {

                    if (j > 0)
                    {
                        space = 21;
                    }
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + space, oldBtn.Location.Y);
                    Matrix[i].Add(btn);
                    pnlDayInMonth.Controls.Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, oldBtn.Location.Y + Cons.dateButtonHeight + 10) };
                space = 0;
            }
            setDefaultDate();
        }

        void setDefaultDate()
        {
            dtpDateTime.Value = DateTime.Now;
        }

        void AddNumberIntoMatrixByDate(DateTime date)
        {
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int days = DateTime.DaysInMonth(date.Year, date.Month);
            int line = 0;

            for (int i = 1; i <= days; i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }

        private void dtpDateTime_ValueChanged(object sender, EventArgs e)
        {
            
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }
    }
}