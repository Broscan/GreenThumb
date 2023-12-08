using GreenThumb.Database;
using GreenThumb.Manager;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for MyGardenWindow.xaml
    /// </summary>
    public partial class MyGardenWindow : Window
    {
        public MyGardenWindow()
        {
            InitializeComponent();

            GetAllPlants();

        }
        public async void GetAllPlants()
        {
            using (AppDbContext context = new())
            {
                GreenThumbUoW uow = new(context);
                if (UserManager.CurrentSignedInUser != null)
                {
                    // LINQ-statement för att hitta plantor till den specifika garden som är kopplat till usern.
                    var filteredPlantGardens = await context.PlantGarden.Where(p => p.GardenId == UserManager.CurrentSignedInUser.GardenId).Include(p => p.Plant).ToListAsync();
                    foreach (var plant in filteredPlantGardens)
                    {
                        ListViewItem item = new();
                        item.Content = plant.Plant.PlantName;
                        item.Tag = plant;

                        lstPlantsGarden.Items.Add(item);
                    }
                }
            }
        }

        private void btn_GoBackToPlants(object sender, RoutedEventArgs e)
        {
            PlantWindow plantWindow = new();
            plantWindow.Show();
            Close();
        }
    }
}
