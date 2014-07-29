Namespace OBJETOS
    Public Class ObjUsuarios
#Region "Variables"
        Private _Id As Integer
        Private _Nombre As String
        Private _Usuario As String
        Private _Contraseña As String
        Private _Email As String
        Private _IdRol As String
#End Region
#Region "Propiedades"
        Public Property IdRol() As String
            Get
                Return _IdRol
            End Get
            Set(ByVal value As String)
                _IdRol = value
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

        Public Property Contraseña() As String
            Get
                Return _Contraseña
            End Get
            Set(ByVal value As String)
                _Contraseña = value
            End Set
        End Property

        Public Property Usuario() As String
            Get
                Return _Usuario
            End Get
            Set(ByVal value As String)
                _Usuario = value
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

