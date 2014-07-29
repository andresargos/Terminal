Namespace OBJETOS
    Public Class ObjVuelos
#Region "Variables"
        Private _Id As Integer
        Private _Numero As Integer
        Private _LugarSalida As String
        Private _HoraSalida As String
        Private _HoraLlegada As String
        Private _IdAerolinea As Integer
        Private _Precio As Integer
        Private _Campos As Integer
        Private _LugaresDisponibles As Integer
#End Region
#Region "Propiedades"

        Public Property LugaresDisponibles() As Integer
            Get
                Return _LugaresDisponibles
            End Get
            Set(ByVal value As Integer)
                _LugaresDisponibles = value
            End Set
        End Property

        Public Property Campos() As Integer
            Get
                Return _Campos
            End Get
            Set(ByVal value As Integer)
                _Campos = value
            End Set
        End Property

        Public Property Precio() As Integer
            Get
                Return _Precio
            End Get
            Set(ByVal value As Integer)
                _Precio = value
            End Set
        End Property

        Public Property IdAereolinea() As Integer
            Get
                Return _IdAerolinea
            End Get
            Set(ByVal value As Integer)
                _IdAerolinea = value
            End Set
        End Property

        Public Property HoraLlegada() As String
            Get
                Return _HoraLlegada
            End Get
            Set(ByVal value As String)
                _HoraLlegada = value
            End Set
        End Property

        Public Property HoraSalida() As String
            Get
                Return _HoraSalida
            End Get
            Set(ByVal value As String)
                _HoraSalida = value
            End Set
        End Property

        Public Property LugarSalida() As String
            Get
                Return _LugarSalida
            End Get
            Set(ByVal value As String)
                _LugarSalida = value
            End Set
        End Property

        Public Property Numero() As Integer
            Get
                Return _Numero
            End Get
            Set(ByVal value As Integer)
                _Numero = value
            End Set
        End Property

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal value As Integer)
                _Id = value
            End Set
        End Property
#End Region
    End Class
End Namespace

