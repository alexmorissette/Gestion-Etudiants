' TITRE:   Classe Etu
' DESCRIPTION: Cette classe définie les propriétés pour la gestion d'un étudiant: 
' Son DA, nom, prénom, sexe, ville, le nombre de cours réussis, la moyenne et son status.
'FAIT PAR : Alex Morissette
' Révisé le : 22 juin 2021

Public Class Etu

    '*************** 1 - DA *****************
    Private _DA As Integer
    Public Property DA As Integer
        Get
            Return _DA
        End Get
        Set(value As Integer)
            _DA = value
        End Set
    End Property

    '*************** 2 - NOM *****************
    Private _Nom As String
    Public Property Nom As String
        Get
            Return _Nom
        End Get
        Set(value As String)
            _Nom = value
        End Set
    End Property

    '*************** 3 - PRENOM *****************
    Private _Prenom As String
    Public Property Prenom As String
        Get
            Return _Prenom
        End Get
        Set(value As String)
            _Prenom = value
        End Set
    End Property

    '*************** 4 - SEXE *****************
    Private _Sexe As Char
    Public Property Sexe As Char
        Get
            Return _Sexe
        End Get
        Set(value As Char)
            _Sexe = value
        End Set
    End Property

    '*************** 5 - VILLE *****************
    Private _Ville As String
    Public Property Ville As String
        Get
            Return _Ville
        End Get
        Set(value As String)
            _Ville = value
        End Set
    End Property

    '*************** 6 - NBCOURSREUSSI *****************
    Private _NbCoursReussi As Integer
    Public Property NbCoursReussi As Integer
        Get
            Return _NbCoursReussi
        End Get
        Set(value As Integer)
            _NbCoursReussi = value
        End Set
    End Property

    '*************** 7 - MOYENNE *****************
    Private _Moyenne As Single
    Public Property Moyenne As Single
        Get
            Return _Moyenne
        End Get
        Set(value As Single)
            _Moyenne = value
        End Set
    End Property

    '*************** 8 - STATUS *****************
    Private _Status As Char
    Public Property Status As Char
        Get
            Return _Status
        End Get
        Set(value As Char)
            _Status = value
        End Set
    End Property

    '************** Constructeur ****************/
    Public Sub New()
        _DA = 0
        _Nom = "Nom"
        _Prenom = "Prénom"
        _Sexe = "F"
        _Ville = "Québec"
        _NbCoursReussi = 0
        _Moyenne = 0
        _Status = "I"
    End Sub

End Class
