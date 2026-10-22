Public Class Node
    Private _value As Double
    Private _nextNodeLink As Node
    Private _type As String
    Private _weight As weight

    Property value() As Double
        Get
            Return _value
        End Get
        Set(ByVal Value As Double)
            _value = Value
        End Set
    End Property

    Property nextNodeLink() As Node
        Get
            Return _nextNodeLink
        End Get
        Set(ByVal Value As Node)
            _nextNodeLink = Value
        End Set
    End Property

    Property type() As String
        Get
            Return _type
        End Get
        Set(ByVal Value As String)
            _type = Value
        End Set
    End Property

    Property weight() As weight
        Get
            Return _weight
        End Get
        Set(ByVal Value As weight)
            _weight = Value
        End Set
    End Property

    Public Sub New()
        _value = 0
        _type = "N/A"
    End Sub

End Class

Public Class weight
    Private _value As Double
    Private _nextWeightLink As weight
    Private _linkedNode As Node

    Property value() As Double
        Get
            Return _value
        End Get
        Set(ByVal Value As Double)
            _value = Value
        End Set
    End Property

    Property nextWeightLink() As weight
        Get
            Return _nextWeightLink
        End Get
        Set(ByVal Value As weight)
            _nextWeightLink = Value
        End Set
    End Property

    Property linkedNode() As Node
        Get
            Return _linkedNode
        End Get
        Set(ByVal Value As Node)
            _linkedNode = Value
        End Set
    End Property

End Class
