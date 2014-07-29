Namespace OBJETOS
    Public Class ObjLineasAereas
#Region "Variables"
        Private _Id As String
        Private _Nombre As String
        Private _IdDestinos As String
#End Region
#Region "Propiedades"
        Public Property Nombre() As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                _Nombre = value
            End Set
        End Property

        Public Property IdDestinos() As String
            Get
                Return _IdDestinos
            End Get
            Set(ByVal value As String)
                _IdDestinos = value
            End Set
        End Property

        Public Property Id() As String
            Get
                Return _Id
            End Get
            Set(ByVal value As String)
                _Id = value
            End Set
        End Property
#End Region
    End Class
End Namespace

