Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        CaniacLabel.Visibility = Visibility.Visible
        CaniacPic.Visibility = Visibility.Visible
        BoxPic.Visibility = Visibility.Hidden
        ThreePic.Visibility = Visibility.Hidden
        CaniacLabel.Content = "Contains 5 chicken fingers, two canes sauces, a drink of your choice, and fries"
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        CaniacPic.Visibility = Visibility.Hidden
        BoxPic.Visibility = Visibility.Visible
        ThreePic.Visibility = Visibility.Hidden
        CaniacLabel.Content = "Contains 4 chicken fingers, one canes sauce, a drink of your choice, and fries"
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        CaniacPic.Visibility = Visibility.Hidden
        BoxPic.Visibility = Visibility.Hidden
        ThreePic.Visibility = Visibility.Visible
        CaniacLabel.Content = "Contains 3 chicken fingers, one canes sauce, a drink of your choice, and fries"
    End Sub
End Class
