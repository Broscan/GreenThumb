using GreenThumb.Database;
using GreenThumb.Models;
using System.Windows;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for AddPlantWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        public AddPlantWindow()
        {
            InitializeComponent();
        }

        private async void btn_AddPlant(object sender, RoutedEventArgs e)
        {
            using (AppDbContext context = new())
            {
                if (!string.IsNullOrEmpty(txtPlant.Text) && !string.IsNullOrEmpty(txtDesc.Text))
                {
                    string plantName = txtPlant.Text;
                    string plantDesc = txtDesc.Text;

                    List<InstructionModel> instructions = new();

                    foreach (string instruction in lstInstructions.Items)
                    {
                        InstructionModel inst = new()
                        {
                            Instruction = instruction
                        };

                        instructions.Add(inst);
                    }

                    PlantModel newPlant = new()
                    {
                        PlantName = plantName,
                        Description = plantDesc,
                        Instructions = instructions
                    };

                    GreenThumbUoW gtUow = new(context);
                    var allPlants = await gtUow.PlantRepository.GetAll();

                    if (!allPlants.Any(p => p.PlantName?.ToLower() == plantName))
                    {
                        await gtUow.PlantRepository.Add(newPlant);
                        await gtUow.Complete();

                        UpdateUI();
                    }
                    else
                    {
                        MessageBox.Show("That plant already exists!", "Warning");
                    }

                }

                else
                {
                    MessageBox.Show("Some of the inputs are empty!", "Warning");
                }
            }

        }

        private void btn_AddInstruction(object sender, RoutedEventArgs e)
        {
            if (txtInstructions != null)
            {
                string newInstruction = txtInstructions.Text;

                lstInstructions.Items.Add(newInstruction);
                txtInstructions.Text = "";
            }
        }

        private void UpdateUI()
        {
            txtPlant.Text = "";
            txtDesc.Text = "";
            lstInstructions.Items.Clear();
        }
    }
}
