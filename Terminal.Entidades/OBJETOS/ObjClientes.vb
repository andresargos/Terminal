Namespace OBJETOS
    Public Class ObjClientes
#Region "Variables"
        Private _Id As Integer
        Private _Nombre As String
        Private _Pasaporte As Integer
        Private _Direccion As String
        Private _Edad As Integer
        Private _Telefono As String
        Private _Email As String
        Private _Vuelos_Matriculados As String
#End Region
#Region "Propiedades"
        Public Property Vuelos_Matriculados() As String
            Get
                Return _Vuelos_Matriculados
            End Get
            Set(ByVal value As String)
                _Vuelos_Matriculados = value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal value As String)
                _Email = value
            End Set
        End Property

        Public Property Telefono() As String
            Get
                Return _Telefono
            End Get
            Set(ByVal value As String)
                _Telefono = value
            End Set
        End Property

        Public Property Edad() As Integer
            Get
                Return _Edad
            End Get
            Set(ByVal value As Integer)
                _Edad = value
            End Set
        End Property

        Public Property Direccion() As String
            Get
                Return _Direccion
            End Get
            Set(ByVal value As String)
                _Direccion = value
            End Set
        End Property

        Public Property Pasaporte() As Integer
            Get
                Return _Pasaporte
            End Get
            Set(ByVal value As Integer)
                _Pasaporte = value
            End Set
        End Property

        Public Property Nombre() As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                _Nombre = value
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

