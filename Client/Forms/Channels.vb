Public Class Channels

    Public Sub DisplayChannels()

        ChannelList.Items.Clear()

        Dim RawChannels As String = Main.NetGet.Retreive("http://api.versidyne.com/?session=" + Main.Session + "&info=channels")
        Dim Channels As Array = Split(RawChannels, "<|(row)|>")
        Dim Channel As String = Nothing
        Dim Info As String() = Nothing

        For Each Channel In Channels

            If Channel.Contains("<|(cell)|>") Then

                Info = Split(Channel, "<|(cell)|>")

                If Info(2) = "private" Then

                    ChannelList.Items.Add(Info(1), 1)

                Else

                    ChannelList.Items.Add(Info(1), 0)

                End If

            End If

        Next

    End Sub

    Private Sub Channels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DisplayChannels()

    End Sub

End Class