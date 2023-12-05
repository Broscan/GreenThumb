using GreenThumb.Database;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for PlantWindow.xaml
    /// </summary>
    public partial class PlantWindow : Window
    {
        public PlantWindow()
        {
            InitializeComponent();

            GetAllPlants();

        }

        public async void GetAllPlants()
        {
            using (AppDbContext context = new())
            {
                GreenThumbUoW uow = new(context);

                var allPlants = await uow.PlantRepository.GetAll();

                foreach (var plant in allPlants)
                {
                    ListViewItem item = new();
                    item.Content = plant.PlantName;
                    item.Tag = plant;

                    lstPlants.Items.Add(item);


                }

            }
        }
    }
}
