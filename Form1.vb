Imports System.Data.SqlClient
Imports SqlDataAdapter = System.Data.SqlClient.SqlDataAdapter

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim title As String = TextBox1.Text
        Dim author As String = TextBox2.Text
        Dim dates As String = TextBox3.Text

        Dim query As String = "INSERT INTO library VALUES (@title, @author, @dates)"
        Using con As SqlConnection = New SqlConnection("Data Source=R\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@title", title)
                cmd.Parameters.AddWithValue("@author", author)
                cmd.Parameters.AddWithValue("@dates", dates)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                MessageBox.Show("Insert Confirm")
                BindData()
            End Using
        End Using
    End Sub

    Public Sub BindData()
        Dim query As String = "SELECT * FROM library"
        Using con As SqlConnection = New SqlConnection("Data Source=R\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = "SELECT * FROM library WHERE id ='" & TextBox4.Text & "' "
        Using con As SqlConnection = New SqlConnection("Data Source=R\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            TextBox1.Text = dt.Rows(0)(1).ToString
                            TextBox2.Text = dt.Rows(0)(2).ToString
                            TextBox3.Text = dt.Rows(0)(3).ToString
                        Else
                            TextBox1.Text = ""
                            TextBox2.Text = ""
                            TextBox3.Text = ""



                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer = TextBox4.Text
        Dim title As String = TextBox1.Text
        Dim author As String = TextBox2.Text
        Dim dates As String = TextBox3.Text

        Dim query As String = "UPDATE library SET title = @title, author = @author, published_date = @dates WHERE id = @id"
        Using con As SqlConnection = New SqlConnection("Data Source=R\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@title", title)
                cmd.Parameters.AddWithValue("@author", author)
                cmd.Parameters.AddWithValue("@dates", dates)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                MessageBox.Show("Updated Confirm")
                BindData()
            End Using
        End Using

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BindData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id As Integer = TextBox4.Text

        Dim query As String = "DELETE FROM library WHERE id = @id"
        Using con As SqlConnection = New SqlConnection("Data Source=R\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                MessageBox.Show("Delete Confirm")
                BindData()
            End Using
        End Using
    End Sub
End Class
