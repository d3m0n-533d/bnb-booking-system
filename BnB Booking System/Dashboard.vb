Public Class Dashboard

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim existStatus As DialogResult = MessageBox.Show("Are you sure you want to EXIT ?", "warning", MessageBoxButtons.YesNoCancel)

        ' if user clicked yes exit program
        If existStatus = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
