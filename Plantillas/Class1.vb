Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Persona
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub


    Private _id As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
            NotifyPropertyChanged()
        End Set
    End Property

    Private _nombre As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
            NotifyPropertyChanged()
        End Set
    End Property

    Private _foto As String

    Public Property Foto As String
        Get
            Return _foto
        End Get
        Set(value As String)
            _foto = value
            NotifyPropertyChanged()
        End Set
    End Property

    Private _sexo As String

    Public Property Sexo As String
        Get
            Return _sexo
            NotifyPropertyChanged()
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property

    Public Sub New(id As Integer, nombre As String, foto As String, sexo As String)
        _id = id
        _nombre = nombre
        _foto = foto
        _sexo = sexo
    End Sub

    Public Shared Function GetPersonas() As ObservableCollection(Of Persona)
        Dim lista As New ObservableCollection(Of Persona)

        lista.Add(New Persona(1, "Pepe", "1.jpg", "Hombre"))
        lista.Add(New Persona(2, "Antonio", "2.jpg", "Hombre"))
        lista.Add(New Persona(3, "Sara", "3.jpg", "Mujer"))

        Return lista
    End Function
End Class
