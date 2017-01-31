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
    Private dwDamage As Integer = 0
    Private LocationX As Integer
    Private LocationY As Integer
    Private dwSpeed As Integer = VAR_SPEEDSCALE \ 100

    'Internal
    Private VAR_SPEEDSCALE As Integer = 5000

    Public Property Speed As Integer
        Get
            Return dwSpeed
        End Get
        Set(ByVal value As Integer)
            dwSpeed = value
        End Set
    End Property


    'Map location
    Public Property X As Integer
        Get
            Return LocationX
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Y As Integer
        Get
            Return LocationY
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Damage As Integer
        Get
            Return dwDamage
        End Get
        Set(ByVal value As Integer)
            dwDamage = value
        End Set
    End Property

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

    Public Sub RemoveFromInventory(ByVal itemName As Integer)
        'We're actually using the index here because the class name doesn't convert cleanly to string - dwarf.Item+<ITEM>
        Inventory.RemoveAt(itemName)
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

                If Form1.MyForest.TreeExists(LocationX, LocationY) Then
                    'There's a tree here
                    result = dwName & " chops down a tree."
                    State = "Farming"
                    Resources.Lumber += 1
                    Fatigue += 5
                    Form1.MyForest.ClearTree(LocationX, LocationY)

                    'Done at this location, wander
                    Wander()
                    Return result
                Else
                    result = dwName & " wants to chop down a tree, but doesn't see one here."
                    Wander()
                    Return result
                End If


            ElseIf TypeOf iObj Is Item.Basket Then
                If Form1.MyForest.TreeExists(LocationX, LocationY) Then
                    result = dwName & " harvests fruit from a tree."
                    Resources.Food += 1
                    Fatigue += 2
                    State = "Farming"
                    'Done at this location, wander
                    Wander()
                    Return result
                Else
                    result = dwName & " wants to harvest fruit, but there is none here."
                    Wander()
                    Return result
                End If

            Else

            End If

        Next

        'Nothing in inventory dictates what we're doing, let's wander around
        State = "wandering, resting."
        'Done at this location, wander
        Wander()
        Return dwName & " wanders around aimlessly."

    End Function

    Private Function HasWeapon() As Boolean
        'determine if we have something that can be used as a weapon and set our damage
        For Each iObj In Inventory
            If iObj.IsWeapon Then
                Damage = iObj.Damage
                Return True
            End If
        Next
        Return False
    End Function


    Private Function CalculateWeight() As Integer
        Dim tWeight As Integer = 0
        For Each iobj In Inventory
            tWeight += iobj.weight
        Next
        Return tWeight
    End Function

    Public Sub Activate()
        VAR_SPEEDSCALE = SpawnControl.GetRandom(5000, 6000)
        Speed = VAR_SPEEDSCALE / 100

        ActionTimer.Enabled = True
        AddHandler ActionTimer.Tick, AddressOf TimerTick
        ActionTimer.Interval = VAR_SPEEDSCALE
        ActionTimer.Start()
        LocationX = SpawnControl.SpawnLocationX
        LocationY = SpawnControl.SpawnLocationY
    End Sub

    Private Sub Wander()
        Dim WanderX As Integer = SpawnControl.GetRandom(1, 100)
        Dim WanderY As Integer = SpawnControl.GetRandom(1, 100)
        If WanderX > 50 Then WanderX = 1 Else WanderX = -1
        If WanderY > 50 Then WanderY = 1 Else WanderY = -1

        If LocationX + WanderX > -1 AndAlso LocationX + WanderX <= Map.WIDTH Then
            LocationX = LocationX + WanderX
        End If
        If LocationY + WanderY > -1 AndAlso LocationY + WanderY <= Map.HEIGHT Then
            LocationY = LocationY + WanderY
        End If
    End Sub


    Private Sub TimerTick(ByVal sender As Object, ByVal e As EventArgs)
        Dim ActResult As String = thinkAndAct()
        If ActResult <> "" Then
            Form1.rtbOutput.AppendText(ActResult & vbNewLine)
            Form1.rtbOutput.ScrollToCaret()
        End If
        InventoryWeight = CalculateWeight()
        HasWeapon()
    End Sub
End Class
