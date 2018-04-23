Imports DevExpress.Xpf.TreeMap
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace TreeMapLayoutAlgorithmCustomizationSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    <ContentProperty("LayoutAlgorithm")> _
    Friend Class LayoutAlgorithmWarapper
        Public Property LayoutAlgorithm() As TreeMapLayoutAlgorithmBase
        Public Property LayoutAlgorithmName() As String
    End Class

    <ContentProperty("Direction")> _
    Friend Class LayoutDirectionWrapper
        Public Property Direction() As LayoutDirection
        Public Property DirectionName() As String
    End Class
End Namespace
