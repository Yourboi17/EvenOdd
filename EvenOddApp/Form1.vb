Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        lstEven.Items.Clear()
        lstOdd.Items.Clear()

        Dim n As Integer
        If Integer.TryParse(txtNumber.Text, n) Then
            For i As Integer = 0 To n - 1
                If i Mod 2 = 0 Then
                    lstEven.Items.Add(i)
                Else
                    lstOdd.Items.Add(i)
                End If
            Next
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the TextBox input
        txtNumber.Clear()

        ' Clear the Even and Odd ListBoxes
        lstEven.Items.Clear()
        lstOdd.Items.Clear()
    End Sub

End Class
