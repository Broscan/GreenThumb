using GreenThumb.Database;
using GreenThumb.Manager;
using GreenThumb.Models;
using System.Windows;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window
    {
        private PlantModel _plant;

        public PlantDetailsWindow(PlantModel plantModel)
        {
            InitializeComponent();

            _plant = plantModel;

            txtName.Text = plantModel.PlantName;
            txtDesc.Text = plantModel.Description;

            PrintInstructions();

        }
        public async void PrintInstructions()
        {
            using (AppDbContext context = new())
            {
                GreenThumbUoW uow = new(context);

                var allInstructions = await uow.InstructionRepository.GetAll();
                var plantInstructions = allInstructions.Where(p => p.PlantId == _plant.PlantId);
                string instructions = "";
                foreach (var i in plantInstructions)
                {
                    instructions += i.Instruction + "\n";
                }

                txtInstructions.Text = instructions;
            }
        }

        private void btn_Go_back(object sender, RoutedEventArgs e)
        {
            PlantWindow plantWindow = new();
            plantWindow.Show();
            Close();
        }

        private async void btn_AddToGarden(object sender, RoutedEventArgs e)
        {
            using (AppDbContext context = new())
            {
                int plantId = _plant.PlantId;
                // Short hand som returnerar 0 om CurrentSignedInUser.GardenId är null
                int gardenId = UserManager.CurrentSignedInUser.GardenId ?? 0;

                PlantGarden plantGarden = new()
                {
                    PlantId = plantId,
                    GardenId = gardenId
                };

                GreenThumbUoW gtUow = new(context);

                await gtUow.PlantGardenRepository.Add(plantGarden);
                await gtUow.Complete();

                MessageBox.Show("Plant added successfully!");

            }
        }
    }
}
