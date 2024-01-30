' String Manipulation and Arrays Programming Assignment.
' This program records and displays hours donated to four separate missions.
' Benjamin Andrews.


' “I will not use code that was never covered in class or in our textbook. If you do you must be able to explain your code when asked by the professor.
' Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.” 


Public Class frmMain
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Closes the application through close button

        Me.Close()

    End Sub

    Dim strMissions() As String = {"Soup Kitchen", "Homeless Shelter", "Humane Society", "Medical Clinic"}
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' CLear listbox and set up initial form load.

        lstTotals.Items.Clear()
        lstTotals.Items.Add("Hours for " & Today)
        lstTotals.Items.Add("Hours recorded by Benjamin Andrews")
        lstTotals.Items.Add("----------------------------------")

        ' Loop to add array to lstMissions.

        For i As Integer = 0 To (strMissions.Count - 1)
            lstMissions.Items.Add(strMissions(i))
        Next

    End Sub

    Private Sub btnAddHours_Click(sender As Object, e As EventArgs) Handles btnAddHours.Click

        ' Error Checking

        If txtHoursInput.Text = "" Then
            MessageBox.Show("Enter your hours served.")
            txtHoursInput.Focus()
            Return
        End If

        If lstMissions.SelectedIndex = -1 Then
            MessageBox.Show("Select a mission.")
            lstMissions.Focus()
            Return
        End If

        ' Declare Variables.

        Dim inthours As Integer
        Dim intindex As Integer = lstMissions.SelectedIndex
        Dim strname As String = InputBox("Enter your full name.")

        Static inttotals(4) As Integer
        Integer.TryParse(txtHoursInput.Text, inthours)

        ' Calculate totals.

        inttotals(intindex) = inttotals(intindex) + inthours

        ' Display last name and hours donated

        lstTotals.Items.Add(getLast(strname) & " - served " & inthours & " hours")
        lblSoupTotal.Text = inttotals(0).ToString
        lblShelterTotal.Text = inttotals(1).ToString
        lblHumaneTotal.Text = inttotals(2).ToString
        lblMedTotal.Text = inttotals(3).ToString

        ' Clear text box for next entry.

        txtHoursInput.Text = String.Empty
    End Sub

    ' Function to get last name.

    Function getLast(ByVal strname As String)

        Dim intnameindex As Integer = strname.IndexOf(" ")
        Dim strlast As String = strname.Substring(intnameindex - 0)
        Return strlast

    End Function

End Class
