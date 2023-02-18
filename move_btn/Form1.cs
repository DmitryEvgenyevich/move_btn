namespace move_btn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            //MessageBox.Show($"{this.PointToClient(Cursor.Position).X}     {MousePosition.Y},   {button1.Location.X}    {button1.Location.Y}");
            //bool temp1 = this.PointToClient(Cursor.Position).X < button1.Location.X + button1.Width + button1.Width / 2;
            //bool temp2 = this.PointToClient(Cursor.Position).X > button1.Location.X - button1.Width / 2;
            //bool temp3 = this.PointToClient(Cursor.Position).Y < button1.Location.Y + button1.Height + button1.Height / 2;
            //bool temp4 = this.PointToClient(Cursor.Position).Y > button1.Location.Y - button1.Height / 2;
            //while (temp1 & temp2 | temp3 & temp4)
            //{
                button1.Location = new Point(rand.Next(0, this.Width - button1.Width), rand.Next(0, this.Height - button1.Height * 2));
            //    temp1 = this.PointToClient(Cursor.Position).X < button1.Location.X + button1.Width + button1.Width / 2;
            //    temp2 = this.PointToClient(Cursor.Position).X > button1.Location.X - button1.Width / 2;
            //    temp3 = this.PointToClient(Cursor.Position).Y < button1.Location.Y + button1.Height + button1.Height / 2;
            //    temp4 = this.PointToClient(Cursor.Position).Y > button1.Location.Y - button1.Height / 2;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You did it");
        }
    }
}