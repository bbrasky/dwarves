Public Class Dwarf
    Public Inventory As New List(Of Object)

    Private WithEvents ActionTimer As New Timer
    Private RecentAction As String = ""
    Private dwName As String
    Private dwState As String = "Resting"
    Private Fatigue As Integer = 0
    Private InRecovery As Boolean
    Private dwStrength As Integer
    Private IsEncumbered As Boolean = False
    Private InvWeight As Integer
    Private dwHP As Integer = 100

    'Internal
    Private VAR_SPEEDSCALE As Integer = 5000

    Public Property HP As Integer
        Get
            Return dwHP
        End Get
        Set(ByVal value As Integer)
            dwHP = value
        End Set
    End Property

    Public Property InventoryWeight As Integer
        Get
            Return InvWeight
        End Get
        Set(ByVal value As Integer)
            InvWeight = value
        End Set
    End Property

    Public Property Encumbered As Boolean
        Get
            Return IsEncumbered
        End Get
        Set(ByVal value As Boolean)
            IsEncumbered = value
        End Set
    End Property

    Public Property Strength As Integer
        Get
            Return dwStrength
        End Get
        Set(ByVal value As Integer)
            dwStrength = value
        End Set
    End Property

    Public Property State As String
        Get
            Return dwState
        End Get
        Set(ByVal value As String)
            dwState = value
        End Set
    End Property
    Public Property Name As String
        Get
            Return dwName
        End Get
        Set(ByVal value As String)
            dwName = value
        End Set
    End Property

    Public Property LastAct As String
        Get
            Dim retVal As String = RecentAction
            RecentAction = ""
            Return retVal
        End Get
        Set(ByVal value As String)
            RecentAction = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub RemoveFromInventory(ByVal itemName As String)
        'this isn't working, I think the string that comes from the name doesn't match the object name
        MsgBox("remove " & itemName)
        Inventory.Remove(itemName)
    End Sub

    Public Function thinkAndAct() As String
        Dim result As String = ""
        'Check to see if we're recovering
        If InRecovery Then
            Fatigue = Fatigue - 10
            If Fatigue <= 0 Then
                InRecovery = False
            End If
            Return ""
        End If

        'Check for max fatigue
        If Fatigue >= 100 Then
            State = "Fatigued, resting"
            InRecovery = True
            Return Name & " is exhausted and is taking a break."
        End If

        'Decide what to do based on inventory
        For Each iObj In Inventory
            If TypeOf iObj Is Item.Axe Then
                result = dwName & " chops down a tree."
                State = "Farming"
                Resources.Lumber += 1
                Fatigue += 5
                Return result
            ElseIf TypeOf iObj Is Item.Basket Then
                result = dwName & " harvests fruit from a tree."
                Resources.Food += 1
                Fatigue += 2
                State = "Farming"
                Return result
            Else
                'Nothing in inventory dictates what we're doing, let's wander around
                State = "wandering, resting."
                Return ""
            End If

        Next
        Return result
    End Function

    Private Function CalculateWeight() As Integer
        Dim tWeight As Integer = 0
        For Each iobj In Inventory
            tWeight += iobj.weight
        Next
        Return tWeight
    End Function

    Public Sub Activate()
        ActionTimer.Enabled = True
        AddHandler ActionTimer.Tick, AddressOf TimerTick
        ActionTimer.Interval = VAR_SPEEDSCALE
        ActionTimer.Start()
    End Sub

    Private Sub TimerTick(ByVal sender As Object, ByVal e As EventArgs)
        Dim ActResult As String = thinkAndAct()
        If ActResult <> "" Then
            Form1.rtbOutput.AppendText(ActResult & vbNewLine)
            Form1.rtbOutput.ScrollToCaret()
        End If
        InventoryWeight = CalculateWeight()
    End Sub
End Class
