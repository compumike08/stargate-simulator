Public Class Main
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
        If currentGlyph = 0 Then
            currentGlyph = 38
        Else
            currentGlyph = currentGlyph - 1
        End If

        glyphContainer.BackgroundImage = glyphArray(currentGlyph)
    End Sub

    Private Sub tmrDialCounterclockwise_Tick(sender As Object, e As EventArgs) Handles tmrDialCounterclockwise.Tick
        If currentGlyph = 38 Then
            currentGlyph = 0
        Else
            currentGlyph = currentGlyph + 1
        End If

        glyphContainer.BackgroundImage = glyphArray(currentGlyph)
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
        encoded1.BackgroundImage = Nothing
        encoded2.BackgroundImage = Nothing
        encoded3.BackgroundImage = Nothing
        encoded4.BackgroundImage = Nothing
        encoded5.BackgroundImage = Nothing
        encoded6.BackgroundImage = Nothing
        encoded7.BackgroundImage = Nothing

        tmrDialCounterclockwise.Enabled = True
    End Sub
End Class