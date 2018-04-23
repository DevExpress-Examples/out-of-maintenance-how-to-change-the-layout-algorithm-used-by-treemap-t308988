using DevExpress.Xpf.TreeMap;
using System;
using System.Windows;
using System.Windows.Markup;

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
