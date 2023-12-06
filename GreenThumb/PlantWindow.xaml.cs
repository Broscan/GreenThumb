using GreenThumb.Database;
using GreenThumb.Models;
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

        private void btn_AddPlant(object sender, RoutedEventArgs e)
        {
            AddPlantWindow newWindow = new();
            newWindow.Show();
            Close();
        }


        private void btn_Search(object sender, RoutedEventArgs e)
        {


        }

        private void btn_Details(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstPlants.SelectedItem;
            PlantModel selectedPlant = (PlantModel)selectedItem.Tag;

            if (lstPlants.SelectedItem != null)
            {
                PlantDetailsWindow detailsWindow = new(selectedPlant);
                detailsWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("You have to select a plant to show details!", "Warning");
            }
        }

        private async void btn_Remove(object sender, RoutedEventArgs e)
        {

            if (lstPlants.SelectedItem != null)
            {
                using (AppDbContext context = new())
                {
                    ListViewItem selectedItem = (ListViewItem)lstPlants.SelectedItem;
                    PlantModel selectedPlant = (PlantModel)selectedItem.Tag;

                    GreenThumbRepository<PlantModel> plantRepository = new(context);

                    await plantRepository.RemoveAsync(selectedPlant.PlantId);
                    lstPlants.Items.Remove(selectedItem);
                    GreenThumbUoW uow = new(context);
                    await uow.Complete();

                }


            }
            else
            {
                MessageBox.Show("You have to select a plant to remove!", "Warning");
            }
        }
    }
}
