Imports Microsoft.VisualBasic
Public Class gameManager

    'enumator created for readability without using strings, to assign to gamestate
    Public Enum State
        startScreen
        mainMenu
        ControlsTutorial
        MainGame
        Save
    End Enum
    'declares variables for gamestate and screen size 
    Private gamestate As State = State.startScreen
    Private ReadOnly screenWidth As Integer
    Private ReadOnly screenHeight As Integer


    Public Sub New(pWidth, pHeight)
        screenWidth = pWidth
        screenHeight = pHeight
        startscreen()
    End Sub

    Public Sub startscreen()    'loads title screen
        Dim dynamicTextBox As New Label With {
            .Name = "Title",
            .Location = New Point(screenWidth \ 2, screenHeight / 8),
            .Font = New Font("Snap ITC", 20),
            .Text = "Burger Boy!"
            }
        Form1.Controls.Add(dynamicTextBox)
    End Sub


End Class
