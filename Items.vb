Module Item
    Class Axe
        Private Dura As Integer = 100
        Private Desc As String = "Stone Axe"
        Private iWeight As Integer = 50
        Private ItemIsWeapon As Boolean = True
        Private iDamage As Integer = 5

        Public Property Damage As Integer
            Get
                Return iDamage
            End Get
            Set(ByVal value As Integer)
                iDamage = value
            End Set
        End Property

        Public Property IsWeapon As Boolean
            Get
                Return ItemIsWeapon
            End Get
            Set(ByVal value As Boolean)
                ItemIsWeapon = value
            End Set
        End Property

        Public Property Weight As Integer
            Get
                Return iWeight
            End Get
            Set(ByVal value As Integer)
                iWeight = value
            End Set
        End Property

        Public Property Durability As Integer
            Get
                Return Dura
            End Get
            Set(ByVal value As Integer)
                Dura = value
            End Set
        End Property

        Public Property Description As String
            Get
                Return Desc
            End Get
            Set(ByVal value As String)
                Desc = value
            End Set
        End Property
    End Class

    Class Basket
        Private Size As Integer = 10
        Private Desc As String = "Thatch Basket"
        Private iWeight As Integer = 25
        Private ItemIsWeapon As Boolean = False

        Public Property IsWeapon As Boolean
            Get
                Return ItemIsWeapon
            End Get
            Set(ByVal value As Boolean)
                ItemIsWeapon = value
            End Set
        End Property

        Public Property Weight As Integer
            Get
                Return iWeight
            End Get
            Set(ByVal value As Integer)
                iWeight = value
            End Set
        End Property

        Public Property Durability As Integer
            Get
                Return Size
            End Get
            Set(ByVal value As Integer)
                Size = value
            End Set
        End Property

        Public Property Description As String
            Get
                Return Desc
            End Get
            Set(ByVal value As String)
                Desc = value
            End Set
        End Property
    End Class
End Module
