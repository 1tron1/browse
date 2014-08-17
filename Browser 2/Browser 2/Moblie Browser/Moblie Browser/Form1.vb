Public Class Form1


    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        WebBrowser1.Refresh()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs)
        WebBrowser1.GoForward()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
        TopMost = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Close()
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
