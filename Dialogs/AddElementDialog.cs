using MinecraftDatapackStudio.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftDatapackStudio.Dialogs {
    public partial class AddElementDialog : Form {
        public DatapackElement DatapackElement { get; set; }
        public string DatapackElementName { get; set; }

        public AddElementDialog() {
            InitializeComponent();

            elementType.SelectedIndex = 0;
        }

        private void OnAddButtonClick(object sender, EventArgs e) {
            if (nameBox.Text == "") {
                errorText.Text = "Please enter the element name!";
                errorText.Show();

                return;
            }

            switch (elementType.SelectedItem.ToString()) {
                case "Function":
                    DatapackElement = DatapackElement.Function;
                    break;
                case "Loot Table":
                    DatapackElement = DatapackElement.LootTable;
                    break;
                case "Recipe":
                    DatapackElement = DatapackElement.CraftingRecipe;
                    break;
                case "Advancement":
                    DatapackElement = DatapackElement.Advancement;
                    break;
                case "Dimension":
                    DatapackElement = DatapackElement.Dimension;
                    break;
                default:
                    DatapackElement = DatapackElement.Function;
                    break;
            }

            DatapackElementName = nameBox.Text;
        }

        private void OnCancelButtonClick(object sender, EventArgs e) {

        }
    }
}
