using GreenThumb.Database;
using GreenThumb.Manager;
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

        // Search function for plants 
        private void searchPlants_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (AppDbContext context = new())
            {
                string searchPlant = searchPlants.Text.ToLower();

                var filterPlants = context.Plants.Where(p => p.PlantName.Contains(searchPlant)).ToList();

                lstPlants.Items.Clear();
                foreach (var filterPlant in filterPlants)
                {
                    ListViewItem item = new();
                    item.Tag = filterPlant;
                    item.Content = filterPlant.PlantName;

                    lstPlants.Items.Add(item);
                }
            }
        }

        private void btn_MyGarden(object sender, RoutedEventArgs e)
        {
            MyGardenWindow myGarden = new();
            myGarden.Show();
            Close();
        }

        private void btn_SignOut(object sender, RoutedEventArgs e)
        {
            UserManager.SignOutUser();
            SignInWindow signInWindow = new();
            signInWindow.Show();
            Close();
        }
    }
}
