using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SingleSelectableButtonPanelSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var profiles = new List<Profile>
            {
                new Profile { Name = "Al"},
                new Profile { Name = "John" },
                new Profile { Name = "Jack" }
            };
            InitializeComponent();
            ContainerGrid.Children.Add(new SingleSelectableButtonPanel(profiles));
        }

    }
}
