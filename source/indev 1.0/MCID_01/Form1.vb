Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label5.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ListBox1.Text = "Air" Then
            Label2.Text = "Air"
            Label3.Text = "0"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Stone" Then
            Label2.Text = "Stone"
            Label3.Text = "1"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Grass" Then
            Label2.Text = "Grass"
            Label3.Text = "2"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Dirt" Then
            Label2.Text = "Dirt"
            Label3.Text = "3"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Cobblestone" Then
            Label2.Text = "Cobblestone"
            Label3.Text = "4"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Wooden Plank" Then
            Label2.Text = "Wooden Plank"
            Label3.Text = "5"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Sapling" Then
            Label2.Text = "Sapling"
            Label3.Text = "6"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Redwood Sapling" Then
            Label2.Text = "Redwood Sapling"
            Label3.Text = "6:1"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Birch Sapling" Then
            Label2.Text = "Birch Sapling"
            Label3.Text = "6:2"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Bedrock" Then
            Label2.Text = "Bedrock"
            Label3.Text = "7"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Water (still)" Then
            Label2.Text = "Water (still)"
            Label3.Text = "9"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Water (active)" Then
            Label2.Text = "Water (active)"
            Label3.Text = "8"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Lava (active)" Then
            Label2.Text = "Lava (active)"
            Label3.Text = "10"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Lava (still)" Then
            Label2.Text = "Lava (still)"
            Label3.Text = "11"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Sand" Then
            Label2.Text = "Sand"
            Label3.Text = "12"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Gravel" Then
            Label2.Text = "Gravel"
            Label3.Text = "13"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Gold Ore" Then
            Label2.Text = "Gold Ore (Block)"
            Label3.Text = "14"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Iron Ore" Then
            Label2.Text = "Iron Ore (Block)"
            Label3.Text = "15"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Coal Ore" Then
            Label2.Text = "Coal Ore (Block)"
            Label3.Text = "16"
            Label5.Text = "Item is unobtainable"
        End If

        If ListBox1.Text = "Wood" Then
            Label2.Text = "Wood Block"
            Label3.Text = "17"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Redwood" Then
            Label2.Text = "Redwood Block"
            Label3.Text = "17:1"
            Label5.Text = ""
        End If

        If ListBox1.Text = "Birchwood" Then
            Label2.Text = "Birchwood Block"
            Label3.Text = "17:2"
            Label5.Text = ""
        End If

        If ListBox1.Text = "More (click me!)" Then
            Timer1.Enabled = False
            Label2.Visible = False
            Label3.Visible = False
            Label1.Visible = False
            Label4.Visible = False
            Button1.Text = "Resume"
            Label2.Text = "N/A"
            Label3.Text = "N/A"
            Label5.Text = "Press 'Resume'"
            MsgBox("More being added in the next update. This is only an INDEV version for testing.", , "Sorry,")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Text = "ID not showing?"
        Label2.Visible = True
        Label3.Visible = True
        Label1.Visible = True
        Label4.Visible = True
        ListBox1.Text = "Air"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("ID's will no longer show temporarily if you click on the item name. However, you can re-enable this by clicking the 'ID not showing' button", , "Information")
        Timer1.Enabled = False
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, _
       ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) _
       Handles LinkLabel1.LinkClicked
        Try
            VisitLink()
        Catch ex As Exception
            ' The error message
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Sub VisitLink()
        ' Change the color of the link text by setting LinkVisited 
        ' to True.
        LinkLabel2.LinkVisited = True
        ' Call the Process.Start method to open the default browser 
        ' with a URL:
        System.Diagnostics.Process.Start("http://www.minecraftforum.net/topic/450085-indev10-mcid-minecraft-id-viewer-requires-testing/")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Feedback()
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Sub Feedback()
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("mailto:jjayden@live.co.uk")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("This program should be used for entertainment purposes only and should not be redistrubuted as your own")
    End Sub
End Class