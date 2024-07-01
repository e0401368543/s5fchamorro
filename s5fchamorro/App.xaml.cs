using s5fchamorro.Utils;
using s5fchamorro.Views;

namespace s5fchamorro
{
    public partial class App : Application
    {
        public static PersonRepository personRepo { get; set; }
        public App(PersonRepository personrepository)
        {
            InitializeComponent();

            MainPage = new Home();
            personRepo = personrepository;
        }
    }
}
