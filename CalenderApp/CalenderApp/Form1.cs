namespace CalenderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTimetableMatrix();
        }

        void LoadTimetableMatrix()
        {
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            int space = 0;
            for (int i = 0; i < Cons.columnWeek; i++)
            {
                for (int j = 0; j < Cons.dayOfWeek; j++)
                {

                    if (j > 0)
                    {
                        space = 21;
                    }
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + space, oldBtn.Location.Y);

                    pnlDayInMonth.Controls.Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, oldBtn.Location.Y + Cons.dateButtonHeight + 10) };
                space = 0;
            }
        }
    }
}