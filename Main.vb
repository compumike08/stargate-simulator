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

    Private Sub glyphContainer_Click(sender As Object, e As EventArgs) Handles glyphContainer.Click
        tmrDialCounterclockwise.Enabled = True
    End Sub
End Class