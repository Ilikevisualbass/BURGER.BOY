Public Class Form1
    Public Enum State
        startScreen
        mainMenu
        ControlsTutorial
        MainGame
        Save
    End Enum

    'declares variables for gamestate and screen size 
    Private gamestate As State = State.startScreen
    Private ReadOnly screenWidth As Integer = 800
    Private ReadOnly screenHeight As Integer = 600
    Private ReadOnly Title As Image = My.Resources.Title
    Private g As Graphics = Me.CreateGraphics()
    Private KyInput As Keys

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(screenWidth, screenHeight)
        startscreen()
    End Sub



    Public Sub startscreen()    'loads title screen
        Application.DoEvents()

        While gamestate = State.startScreen
            Application.DoEvents() ' allows the form to process events

            If KyInput = Keys.Space Then
                gamestate = State.mainMenu
            End If
        End While

    End Sub

    Private Sub mainmenuscreen()

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'handles key presses to change gamestate
        KyInput = e.KeyCode
        mainmenuscreen()
        Me.Invalidate() ' forces the form to repaint
    End Sub


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'refreshes the screen and draws the graphics
        g.Clear(Color.White)
        g.DrawImage(Title, (screenWidth - Title.Width) \ 2, (screenWidth - Title.Width) \ 2)
        g.DrawString("Press SPACE to continue", New Font("Arial", 16), Brushes.Black, (screenWidth - 200) \ 2, (screenHeight - 50) \ 2)
    End Sub
End Class
