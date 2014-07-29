Namespace OBJETOS
    Public Class ObjDestinosDeVuelos
#Region "Variables"
        Private _Id As Integer
        Private _NombreAeropuerto As String
        Private _Codigo As String
        Private _EstadoProvincia As String
        Private _Pais As String
#End Region
#Region "Propiedades"
        Public Property Pais() As String
            Get
                Return _Pais
            End Get
            Set(ByVal value As String)
                _Pais = value
            End Set
        End Property

        Public Property EstadoProvincia() As String
            Get
                Return _EstadoProvincia
            End Get
            Set(ByVal value As String)
                _EstadoProvincia = value
            End Set
        End Property

        Public Property Codigo() As String
            Get
                Return _Codigo
            End Get
            Set(ByVal value As String)
                _Codigo = value
            End Set
        End Property

        Public Property NombreAeropuerto() As String
            Get
                Return _NombreAeropuerto
            End Get
            Set(ByVal value As String)
                _NombreAeropuerto = value
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

