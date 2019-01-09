Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        PersonasComboBox.DataContext = Persona.GetPersonas()
    End Sub

    Private Sub combo_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles PersonasComboBox.SelectionChanged
        MessageBox.Show("El identificador del usuario seleccionado es: " & PersonasComboBox.SelectedValue)
    End Sub
End Class
