Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DT As Integer
        Dim MM As String
        Dim YY As Integer
        Me.Text = "JavaTpoint.com"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = "Display Calendar"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = "Get Date"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Items.Add("Date")
        ComboBox1.Items.Add("01")
        ComboBox1.Items.Add("02")
        ComboBox1.Items.Add("03")
        ComboBox1.Items.Add("04")
        ComboBox1.Items.Add("05")
        ComboBox1.Items.Add("06")
        ComboBox1.Items.Add("07")
        ComboBox1.Items.Add("08")
        ComboBox1.Items.Add("09")

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.Items.Add("Mon th")
        ComboBox2.Items.Add("January")
        ComboBox2.Items.Add("February")
        ComboBox2.Items.Add("March")
        ComboBox2.Items.Add("May")
        ComboBox2.Items.Add("June")
        ComboBox2.Items.Add("July")

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox3.Items.Add("Year")
        ComboBox3.Items.Add("2016")
        ComboBox3.Items.Add("2017")
        ComboBox3.Items.Add("2018")
        ComboBox3.Items.Add("2019")
        ComboBox3.Items.Add("2020")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Exit"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = "Date"
    End Sub
End Class
