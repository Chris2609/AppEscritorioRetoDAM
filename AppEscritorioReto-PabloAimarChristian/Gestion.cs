using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorioReto_PabloAimarChristian
{
    public partial class Gestion : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public Gestion()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.DeepPurple900, Primary.DeepPurple900, Accent.Yellow100, TextShade.WHITE);
            this.MaximizeBox = false;
        }

        private void Gestion_Load(object sender, EventArgs e)
        {

        }
    }
}
