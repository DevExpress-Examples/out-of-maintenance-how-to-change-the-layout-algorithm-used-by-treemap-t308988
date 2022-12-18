Imports DevExpress.Xpf.TreeMap
Imports System.Windows
Imports System.Windows.Markup

Namespace TreeMapLayoutAlgorithmCustomizationSample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    <ContentProperty("LayoutAlgorithm")>
    Friend Class LayoutAlgorithmWarapper

        Public Property LayoutAlgorithm As TreeMapLayoutAlgorithmBase

        Public Property LayoutAlgorithmName As String
    End Class

    <ContentProperty("Direction")>
    Friend Class LayoutDirectionWrapper

        Public Property Direction As LayoutDirection

        Public Property DirectionName As String
    End Class
End Namespace
