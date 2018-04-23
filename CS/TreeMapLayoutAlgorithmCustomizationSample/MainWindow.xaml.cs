using DevExpress.Xpf.TreeMap;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeMapLayoutAlgorithmCustomizationSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    [ContentProperty("LayoutAlgorithm")]
    class LayoutAlgorithmWarapper {
        public TreeMapLayoutAlgorithmBase LayoutAlgorithm { get; set; }
        public String LayoutAlgorithmName { get; set; }
    }

    [ContentProperty("Direction")]
    class LayoutDirectionWrapper {
        public LayoutDirection Direction { get; set; }
        public String DirectionName { get; set; }
    }
}
