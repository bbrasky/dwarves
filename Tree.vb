Public Class Tree
    Private Trees(Map.WIDTH, Map.HEIGHT) As Integer
    Private WithEvents SpawnTimer As New Timer

    Public Sub InitializeTrees(Optional ByVal Count As Integer = 2000)
        'Zero out the array
        For zeroX = 0 To Map.WIDTH
            For zeroY = 0 To Map.HEIGHT
                Trees(zeroX, zeroY) = 0
            Next
        Next
        'Randomly populate Trees
        For i = 1 To Count
            Trees(SpawnControl.GetRandom(0, Map.WIDTH), SpawnControl.GetRandom(0, Map.HEIGHT)) = 1
        Next
        AddHandler SpawnTimer.Tick, AddressOf SpawnTimer_Tick
        SpawnTimer.Interval = 30000
        SpawnTimer.Enabled = True
        SpawnTimer.Start()

    End Sub

    Public Sub SpawnTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        'randomly spawn a new tree
        Trees(SpawnControl.GetRandom(0, Map.WIDTH), SpawnControl.GetRandom(0, Map.HEIGHT)) = 1
        Form1.rtbOutput.AppendText("A new tree has grown!" & vbNewLine)
    End Sub

    Public Function TreeExists(ByVal PositionX As Integer, ByVal PositionY As Integer) As Boolean
        If Trees(PositionX, PositionY) = 1 Then Return True
        Return False
    End Function

    Public Sub ClearTree(ByVal PositionX As Integer, ByVal PositionY As Integer)
        Trees(PositionX, PositionY) = 0
    End Sub

    Public Sub AddTree(ByVal PositionX As Integer, ByVal PositionY As Integer)
        Trees(PositionX, PositionY) = 1
    End Sub

    Public Function GetTreeData() As String
        Dim tData As String = ""
        For y = 0 To Map.HEIGHT
            For x = 0 To Map.WIDTH
                tData = tData & Trees(x, y).ToString & " "
            Next
            tData = tData & vbNewLine
        Next
        Return tData
    End Function

End Class
