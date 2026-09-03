Class MainWindow
    
    Private Sub Button_Action_Minimize(sender As Object, e As RoutedEventArgs)
        WindowState = WindowState.Minimized
    End Sub

    Private Sub Button_Action_Maximize(sender As Object, e As RoutedEventArgs)
        WindowState = If(WindowState = WindowState.Maximized, WindowState.Normal, WindowState.Maximized)
    End Sub

    Private Sub Button_Action_Close(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub

End Class