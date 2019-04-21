Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListview()
        DataGridView1.DataSource = GetList()
    End Sub

    Private Sub LoadListview()
        Dim i As Integer
        Dim listitem As New ListViewItem
        If ListView1.Items.Count > 0 Then
            ListView1.Items.Clear()
        End If

        Dim PropertyList As New List(Of Test)
        PropertyList = GetList()
        For i = 0 To PropertyList.Count - 1
            listitem = New ListViewItem(PropertyList(i).Id)
            listitem.SubItems.Add(PropertyList(i).Name)        
            listitem.SubItems.Add(PropertyList(i).Grade)   
            listitem.SubItems.Add(PropertyList(i).Remarks)   
            ListView1.Items.Add(listitem)
        Next i
    End Sub

    Private Function GetList() As List(Of Test)
        Dim list As New List(Of Test)
        list.Add(New Test With{.Id = 1, .Name = "Saurav1", .Grade = 3, .Remarks = "CSE"})
        list.Add(New Test With{.Id = 2, .Name = "Saurav2", .Grade = 4, .Remarks = "CSE"})
        list.Add(New Test With{.Id = 3, .Name = "Saurav3", .Grade = 3, .Remarks = "CSE"})
        list.Add(New Test With{.Id = 4, .Name = "Saurav4", .Grade = 4, .Remarks = "CSE"})
        list.Add(New Test With{.Id = 5, .Name = "Saurav5", .Grade = 3, .Remarks = "CSE"})
        Return list
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
