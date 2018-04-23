Imports DevExpress.Xpf.TreeMap
Imports System
Imports System.Windows
Imports System.Windows.Markup

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
