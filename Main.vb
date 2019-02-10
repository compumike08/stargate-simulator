﻿Public Class Main
    Dim glyphArray = New Image() {
        My.Resources.MilkyWayGlyph01,
        My.Resources.MilkyWayGlyph02,
        My.Resources.MilkyWayGlyph03,
        My.Resources.MilkyWayGlyph04,
        My.Resources.MilkyWayGlyph05,
        My.Resources.MilkyWayGlyph06,
        My.Resources.MilkyWayGlyph07,
        My.Resources.MilkyWayGlyph08,
        My.Resources.MilkyWayGlyph09,
        My.Resources.MilkyWayGlyph10,
        My.Resources.MilkyWayGlyph11,
        My.Resources.MilkyWayGlyph12,
        My.Resources.MilkyWayGlyph13,
        My.Resources.MilkyWayGlyph14,
        My.Resources.MilkyWayGlyph15,
        My.Resources.MilkyWayGlyph16,
        My.Resources.MilkyWayGlyph17,
        My.Resources.MilkyWayGlyph18,
        My.Resources.MilkyWayGlyph19,
        My.Resources.MilkyWayGlyph20,
        My.Resources.MilkyWayGlyph21,
        My.Resources.MilkyWayGlyph22,
        My.Resources.MilkyWayGlyph23,
        My.Resources.MilkyWayGlyph24,
        My.Resources.MilkyWayGlyph25,
        My.Resources.MilkyWayGlyph26,
        My.Resources.MilkyWayGlyph27,
        My.Resources.MilkyWayGlyph28,
        My.Resources.MilkyWayGlyph29,
        My.Resources.MilkyWayGlyph30,
        My.Resources.MilkyWayGlyph31,
        My.Resources.MilkyWayGlyph32,
        My.Resources.MilkyWayGlyph33,
        My.Resources.MilkyWayGlyph34,
        My.Resources.MilkyWayGlyph35,
        My.Resources.MilkyWayGlyph36,
        My.Resources.MilkyWayGlyph37,
        My.Resources.MilkyWayGlyph38,
        My.Resources.MilkyWayGlyph39
    }

    Dim currentGlyph As Integer = 0
    Dim rotatingToGlyph As Integer = 0
    Dim currentlyEncodingChevron As Integer = 0

    Dim dialGlyphs(7) As Integer

    Private Sub tmrDialClockwise_Tick(sender As Object, e As EventArgs) Handles tmrDialClockwise.Tick
        If currentGlyph = rotatingToGlyph Then
            tmrDialClockwise.Enabled = False

            Select Case currentlyEncodingChevron
                Case 0
                    encoded1.BackgroundImage = glyphArray(currentGlyph)
                    encoded1.BackColor = Color.LightBlue
                Case 1
                    encoded2.BackgroundImage = glyphArray(currentGlyph)
                    encoded2.BackColor = Color.LightBlue
                Case 2
                    encoded3.BackgroundImage = glyphArray(currentGlyph)
                    encoded3.BackColor = Color.LightBlue
                Case 3
                    encoded4.BackgroundImage = glyphArray(currentGlyph)
                    encoded4.BackColor = Color.LightBlue
                Case 4
                    encoded5.BackgroundImage = glyphArray(currentGlyph)
                    encoded5.BackColor = Color.LightBlue
                Case 5
                    encoded6.BackgroundImage = glyphArray(currentGlyph)
                    encoded6.BackColor = Color.LightBlue
                Case 6
                    encoded7.BackgroundImage = glyphArray(currentGlyph)
                    encoded7.BackColor = Color.LightBlue
            End Select

            If currentlyEncodingChevron = 6 Then
                addressLocked()
            Else
                currentlyEncodingChevron = currentlyEncodingChevron + 1
                rotatingToGlyph = dialGlyphs(currentlyEncodingChevron)
                tmrDialCounterclockwise.Enabled = True
            End If
        Else
            If currentGlyph = 0 Then
                currentGlyph = 38
            Else
                currentGlyph = currentGlyph - 1
            End If

            glyphContainer.BackgroundImage = glyphArray(currentGlyph)
        End If
    End Sub

    Private Sub tmrDialCounterclockwise_Tick(sender As Object, e As EventArgs) Handles tmrDialCounterclockwise.Tick
        If currentGlyph = rotatingToGlyph Then
            tmrDialCounterclockwise.Enabled = False

            Select Case currentlyEncodingChevron
                Case 0
                    encoded1.BackgroundImage = glyphArray(currentGlyph)
                    encoded1.BackColor = Color.LightBlue
                Case 1
                    encoded2.BackgroundImage = glyphArray(currentGlyph)
                    encoded2.BackColor = Color.LightBlue
                Case 2
                    encoded3.BackgroundImage = glyphArray(currentGlyph)
                    encoded3.BackColor = Color.LightBlue
                Case 3
                    encoded4.BackgroundImage = glyphArray(currentGlyph)
                    encoded4.BackColor = Color.LightBlue
                Case 4
                    encoded5.BackgroundImage = glyphArray(currentGlyph)
                    encoded5.BackColor = Color.LightBlue
                Case 5
                    encoded6.BackgroundImage = glyphArray(currentGlyph)
                    encoded6.BackColor = Color.LightBlue
                Case 6
                    encoded7.BackgroundImage = glyphArray(currentGlyph)
                    encoded7.BackColor = Color.LightBlue
            End Select

            If currentlyEncodingChevron = 6 Then
                addressLocked()
            Else
                currentlyEncodingChevron = currentlyEncodingChevron + 1
                rotatingToGlyph = dialGlyphs(currentlyEncodingChevron)
                tmrDialClockwise.Enabled = True
            End If
        Else
            If currentGlyph = 38 Then
                currentGlyph = 0
            Else
                currentGlyph = currentGlyph + 1
            End If

            glyphContainer.BackgroundImage = glyphArray(currentGlyph)
        End If
    End Sub

    Private Sub encoded1_Click(sender As Object, e As EventArgs) Handles encoded1.Click
        Dim dial As Integer = InputBox("Enter glyph number", "GLYPH 1")
        dialGlyphs(0) = dial - 1
        encoded1.BackgroundImage = glyphArray(dialGlyphs(0))
    End Sub

    Private Sub encoded2_Click(sender As Object, e As EventArgs) Handles encoded2.Click
        Dim dial As Integer = InputBox("Enter glyph number", "GLYPH 2")
        dialGlyphs(1) = dial - 1
        encoded2.BackgroundImage = glyphArray(dialGlyphs(1))
    End Sub

    Private Sub encoded3_Click(sender As Object, e As EventArgs) Handles encoded3.Click
        Dim dial As Integer = InputBox("Enter glyph number", "GLYPH 3")
        dialGlyphs(2) = dial - 1
        encoded3.BackgroundImage = glyphArray(dialGlyphs(2))
    End Sub

    Private Sub encoded4_Click(sender As Object, e As EventArgs) Handles encoded4.Click
        Dim dial As Integer = InputBox("Enter glyph number", "GLYPH 4")
        dialGlyphs(3) = dial - 1
        encoded4.BackgroundImage = glyphArray(dialGlyphs(3))
    End Sub

    Private Sub encoded5_Click(sender As Object, e As EventArgs) Handles encoded5.Click
        Dim dial As Integer = InputBox("Enter glyph number", "GLYPH 5")
        dialGlyphs(4) = dial - 1
        encoded5.BackgroundImage = glyphArray(dialGlyphs(4))
    End Sub

    Private Sub encoded6_Click(sender As Object, e As EventArgs) Handles encoded6.Click
        Dim dial As Integer = InputBox("Enter glyph number", "GLYPH 6")
        dialGlyphs(5) = dial - 1
        encoded6.BackgroundImage = glyphArray(dialGlyphs(5))
    End Sub

    Private Sub encoded7_Click(sender As Object, e As EventArgs) Handles encoded7.Click
        Dim dial As Integer = InputBox("Enter glyph number", "GLYPH 7")
        dialGlyphs(6) = dial - 1
        encoded7.BackgroundImage = glyphArray(dialGlyphs(6))
    End Sub

    Private Sub cmdDial_Click(sender As Object, e As EventArgs) Handles cmdDial.Click
        clearEncodedGlyphs()

        encoded1.BackColor = Color.White
        encoded2.BackColor = Color.White
        encoded3.BackColor = Color.White
        encoded4.BackColor = Color.White
        encoded5.BackColor = Color.White
        encoded6.BackColor = Color.White
        encoded7.BackColor = Color.White

        currentlyEncodingChevron = 0
        rotatingToGlyph = dialGlyphs(0)

        tmrDialCounterclockwise.Enabled = True

        cmdDial.Enabled = False
        cmdAbort.Enabled = True
    End Sub

    Private Sub addressLocked()
        encoded1.BackColor = Color.LightGreen
        encoded2.BackColor = Color.LightGreen
        encoded3.BackColor = Color.LightGreen
        encoded4.BackColor = Color.LightGreen
        encoded5.BackColor = Color.LightGreen
        encoded6.BackColor = Color.LightGreen
        encoded7.BackColor = Color.LightGreen
        glyphContainer.BackgroundImage = Nothing
        txtLocked.Visible = True
    End Sub

    Private Sub cmdAbort_Click(sender As Object, e As EventArgs) Handles cmdAbort.Click
        tmrDialClockwise.Enabled = False
        tmrDialCounterclockwise.Enabled = False
        currentlyEncodingChevron = 0
        dialGlyphs(0) = Nothing
        dialGlyphs(1) = Nothing
        dialGlyphs(2) = Nothing
        dialGlyphs(3) = Nothing
        dialGlyphs(4) = Nothing
        dialGlyphs(5) = Nothing
        dialGlyphs(6) = Nothing
        clearEncodedGlyphs()

        txtLocked.Visible = False
        cmdAbort.Enabled = False
        cmdDial.Enabled = True
    End Sub

    Private Sub clearEncodedGlyphs()
        encoded1.BackgroundImage = Nothing
        encoded1.BackColor = Color.LightGray

        encoded2.BackgroundImage = Nothing
        encoded2.BackColor = Color.LightGray

        encoded3.BackgroundImage = Nothing
        encoded3.BackColor = Color.LightGray

        encoded4.BackgroundImage = Nothing
        encoded4.BackColor = Color.LightGray

        encoded5.BackgroundImage = Nothing
        encoded5.BackColor = Color.LightGray

        encoded6.BackgroundImage = Nothing
        encoded6.BackColor = Color.LightGray

        encoded7.BackgroundImage = Nothing
        encoded7.BackColor = Color.LightGray
    End Sub
End Class
