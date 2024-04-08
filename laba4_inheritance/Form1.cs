namespace laba4_inheritance
{
    public partial class Form1 : Form
    {

        List<Transport> transportList = new List<Transport>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.transportList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.transportList.Add(Bicycle.Generate());
                        break;
                    case 1:
                        this.transportList.Add(Cars.Generate());

                        break;
                    case 2:
                        this.transportList.Add(Plane.Generate());

                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int bicycleCount = 0;
            int carsCount = 0;
            int planeCount = 0;

            // пройдемся по всему списку
            foreach (var transport in this.transportList)
            {
                if (transport is Bicycle)
                {
                    bicycleCount += 1;
                }
                else if (transport is Cars)
                {
                    carsCount += 1;
                }
                else if (transport is Plane)
                {
                    planeCount += 1;
                }
            }

            txtInfo.Text = "Вел\tАвто\tСамолет";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", bicycleCount, carsCount, planeCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.transportList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            // взяли первый транспорт
            var fruit = this.transportList[0];
            this.transportList.RemoveAt(0);

            txtOut.Text = fruit.GetInfo();

            ShowInfo();
        }
    }
}
