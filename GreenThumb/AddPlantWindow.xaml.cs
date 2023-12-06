using GreenThumb.Database;
using GreenThumb.Models;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for AddPlantWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        List<string> instructions = new();
        public AddPlantWindow()
        {
            InitializeComponent();
        }

        private void btn_AddPlant(object sender, RoutedEventArgs e)
        {

            using (AppDbContext context = new())
            {

                ListViewItem selectedItem = (ListViewItem)lstInstructions.SelectedItem;


                if (selectedItem != null)
                {
                    string plantName = txtPlant.Text;
                    string plantDesc = txtDesc.Text;

                    foreach (var instruction in instructions)
                    {
                        InstructionModel newInstruction = new()
                        {
                            Instruction = instruction,
                        };
                    }


                    PlantModel newPlant = new()
                    {
                        PlantName = plantName,
                        Description = plantDesc,

                    };
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
                instructions.Add(newInstruction);

                foreach (string instruction in instructions)
                {
                    lstInstructions.Items.Add(instruction);
                }
            }
        }

        private void UpdateUI()
        {

        }
    }
}
