Module Wildlife
    Class Rabbit
        Dim rHP As Integer = 30
        Dim rDamage As Integer = 2
        Dim rFoodRes As Integer = 10

        Public Property HP As Integer
            Get
                Return rHP
            End Get
            Set(ByVal value As Integer)
                rHP = value
            End Set
        End Property

        Public Property Damage As Integer
            Get
                Return rDamage
            End Get
            Set(ByVal value As Integer)
                rDamage = value
            End Set
        End Property

        Public Property ResourceValue As Integer
            Get
                Return rFoodRes
            End Get
            Set(ByVal value As Integer)
                rFoodRes = value
            End Set
        End Property

    End Class

End Module
