Option Infer On
Imports System
Imports System.Net
Imports System.Web
Public Class Form1
    Private WithEvents kbHook As New kbhook
    Dim x As Integer = 0
    Dim login As String = ""
    Dim apikey As String = ""
    Dim convertedkeycode As String = ""
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        x = 1
        Application.Exit()
    End Sub
    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If FixKey(Key) = My.Settings.key Then
            If Clipboard.ContainsText Then
                Dim oldclip As String = My.Computer.Clipboard.GetText.Replace(" ", "+")
                Dim newclip As String = "http://lmgtfy.com/?q=" & oldclip
                My.Computer.Clipboard.SetText(bitly(newclip))
                NotifyIcon1.ShowBalloonTip(5000, "Clipboard Google-lyfied", "Your clipboard has been converted to a LMGTFY bit.ly link", ToolTipIcon.Info)
            End If

        End If
    End Sub
    Public Function FixKey(ByVal keycode As Integer)
        Select Case keycode
            Case 48 To 57
                If My.Computer.Keyboard.ShiftKeyDown Then
                    Select Case keycode
                        Case 48
                            convertedkeycode = ")"
                        Case 49
                            convertedkeycode = "!"
                        Case 50
                            convertedkeycode = """"
                        Case 51
                            convertedkeycode = "£"
                        Case 52
                            convertedkeycode = "$"
                        Case 53
                            convertedkeycode = "%"
                        Case 54
                            convertedkeycode = "^"
                        Case 55
                            convertedkeycode = "&"
                        Case 56
                            convertedkeycode = "*"
                        Case 57
                            convertedkeycode = "("
                    End Select
                Else
                    convertedkeycode = Convert.ToChar(keycode)
                End If
            Case 65 To 90
                If My.Computer.Keyboard.ShiftKeyDown Or My.Computer.Keyboard.CapsLock Then
                    convertedkeycode = Convert.ToChar(keycode)
                Else
                    convertedkeycode = Convert.ToChar(keycode + 32)
                End If
            Case 1
                convertedkeycode = ""
            Case 2
                convertedkeycode = "<RCLICK>"
            Case 8
                convertedkeycode = ""
            Case 9
                convertedkeycode = "<TAB>"
            Case 12
                convertedkeycode = "5"
            Case 13
                convertedkeycode = "{ENTER}"
            Case 17
                convertedkeycode = "<CTRL>"
            Case 18
                convertedkeycode = "<ALT>"
            Case 19
                convertedkeycode = "<PAUSE>"
            Case 20
                convertedkeycode = ""
            Case 27
                convertedkeycode = "<ESC>"
            Case 32
                convertedkeycode = " "
            Case 33
                convertedkeycode = "<PAGEUP>"
            Case 34
                convertedkeycode = "<PAGEDOWN>"
            Case 35
                convertedkeycode = "<END>"
            Case 36
                convertedkeycode = "<HOME>"
            Case 37
                convertedkeycode = "<LEFT>"
            Case 38
                convertedkeycode = "<UP>"
            Case 39
                convertedkeycode = "<RIGHT>"
            Case 40
                convertedkeycode = "<DOWN>"
            Case 44
                convertedkeycode = "<PRNTSCRN>"
            Case 45
                convertedkeycode = "<INSERT>"
            Case 46
                convertedkeycode = "<DEL>"
            Case 47
                convertedkeycode = "<HELP>"
            Case 91
                convertedkeycode = "<WIN>"
            Case 93
                convertedkeycode = "<CONTEXT>"
            Case 96
                convertedkeycode = "0"
            Case 97
                convertedkeycode = "1"
            Case 98
                convertedkeycode = "2"
            Case 99
                convertedkeycode = "3"
            Case 100
                convertedkeycode = "4"
            Case 101
                convertedkeycode = "5"
            Case 102
                convertedkeycode = "6"
            Case 103
                convertedkeycode = "7"
            Case 104
                convertedkeycode = "8"
            Case 105
                convertedkeycode = "9"
            Case 106
                convertedkeycode = "*"
            Case 107
                convertedkeycode = "+"
            Case 109
                convertedkeycode = "-"
            Case 110
                convertedkeycode = "."
            Case 111
                convertedkeycode = "/"
            Case 112
                convertedkeycode = "F1"
            Case 113
                convertedkeycode = "F2"
            Case 114
                convertedkeycode = "F3"
            Case 115
                convertedkeycode = "F4"
            Case 116
                convertedkeycode = "F5"
            Case 117
                convertedkeycode = "F6"
            Case 118
                convertedkeycode = "F7"
            Case 119
                convertedkeycode = "F8"
            Case 120
                convertedkeycode = "F9"
            Case 121
                convertedkeycode = "F10"
            Case 122
                convertedkeycode = "F11"
            Case 123
                convertedkeycode = "F12"
            Case 144
                convertedkeycode = "<NUMLOCK>"
            Case 162
                convertedkeycode = "<LCTRL>"
            Case 163
                convertedkeycode = "<RCTRL>"
            Case 164
                convertedkeycode = "<ALT>"
            Case 165
                convertedkeycode = "<ALTGR>"
            Case 186
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = ":"
                Else
                    convertedkeycode = ";"
                End If
            Case 187
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "+"
                Else
                    convertedkeycode = "="
                End If
            Case 188
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "<"
                Else
                    convertedkeycode = ","
                End If
            Case 189
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "_"
                Else
                    convertedkeycode = "-"
                End If
            Case 190
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = ">"
                Else
                    convertedkeycode = "."
                End If
            Case 191
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "?"
                Else
                    convertedkeycode = "/"
                End If
            Case 192
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "@"
                Else
                    convertedkeycode = "'"
                End If
            Case 219
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "{"
                Else
                    convertedkeycode = "["
                End If
            Case 220
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "|"
                Else
                    convertedkeycode = "\"
                End If
            Case 221
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "}"
                Else
                    convertedkeycode = "]"
                End If
            Case 222
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "~"
                Else
                    convertedkeycode = "#"
                End If
            Case 223
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "¬"
                Else
                    convertedkeycode = "`"
                End If
            Case Else
                convertedkeycode = ""
        End Select
        Return convertedkeycode
    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If x = 0 Then
            Me.Hide()
            Me.ShowInTaskbar = False
            e.Cancel = True
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        sender.text = FixKey(e.KeyValue)
        My.Settings.key = sender.text
        My.Settings.Save()
        e.SuppressKeyPress = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.ShowBalloonTip(3000, "LMGTFCFY ", "Let Me Google That From Clipboard For You" & vbNewLine & vbNewLine & "Double click icon for settings", ToolTipIcon.Info)
        TextBox1.Text = My.Settings.key
    End Sub

    Public Function bitly(ByVal url As String)
        Try
            Dim wc = New WebClient()
            If TextBox2.Text = "" Then
                login = "fma965"
                apikey = "R_6f169bc17f07aae53dc77a761585373e"
            Else
                login = TextBox2.Text
                apikey = TextBox3.Text
            End If
            Dim longUrl = HttpUtility.UrlEncode(url)
            Dim request = String.Format("http://api.bit.ly/v3/shorten?login={0}&apiKey={1}&longUrl={2}&format=txt", login, apikey, longUrl)
            Dim result = wc.DownloadString(request)
            Return result.ToString
        Catch webex As System.Net.WebException
            NotifyIcon1.ShowBalloonTip(3000, "LMGTFCFY ", webex.Message & vbNewLine & vbNewLine & "Please make sure your username and API key are correct", ToolTipIcon.Error)
            Return Nothing
        End Try
    End Function
End Class
