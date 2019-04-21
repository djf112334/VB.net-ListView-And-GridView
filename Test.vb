Imports Microsoft.VisualBasic

Public Class Test
    Private _id As Integer

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _name As String

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _grade As String
    Public Property Grade() As Integer
        Get
            Return _grade
        End Get
        Set(ByVal value As Integer)
            _grade = value
        End Set
    End Property

    Private _remarks As String

    Public Property Remarks() As String
        Get
            Return _remarks
        End Get
        Set(ByVal value As String)
            _remarks = value
        End Set
    End Property
End Class
