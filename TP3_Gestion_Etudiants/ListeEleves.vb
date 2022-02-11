' TITRE:   Classe ListeEleves
' DESCRIPTION: Cette classe définie les variables pour la gestion de la liste des étudiants.
' Elle possède aussi les méthodes pour l'ajout, la modification et la suppression d'une inscription
' ainsi qu'un constructeur et un destructeur. Elle fait également la gestion quelques évènements.
' FAIT PAR : Alex Morissette
' Révisé le : 22 juin 2021

Imports System.IO

Public Class ListeEleves
#Region "Variables d'instances et propriétés"
    '*************** TABELEVE *************
    Private Shared _TabEleve As ArrayList ' Tableau contenant les élèves inscrits

    '*************** NBCONNEXIONS *************
    Private Shared _NbConnexions As Integer

    Public Shared ReadOnly Property NbConnexions As Integer
        Get
            Return _NbConnexions
        End Get
    End Property

    '*************** ETUDIANT *************
    Public ReadOnly Property Etudiant(no As Integer) As Etu
        Get
            Return _TabEleve(no)
        End Get
    End Property
    '*************** NB_ETU *************
    Public ReadOnly Property Nb_Etu As Integer
        Get
            If _NbConnexions = 0 Then
                Return 0
            Else
                Return _TabEleve.Count
            End If
        End Get
    End Property

#End Region
#Region "CONSTRUCTEUR"
    '////////////////// CONSTRUCTEUR ///////////////////
    Public Sub New()
        Try
            If _NbConnexions = 0 Then
                _TabEleve = New ArrayList ' Si c'est la première connexion , on crée le tableau 

                ' Pour récupérer le contenu du fichier
                Dim fs As New FileStream(NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None)
                Dim sr As New StreamReader(fs)

                ' Lire le fichier
                Dim ligne As String
                ligne = sr.ReadLine
                Do While ligne <> ""
                    'MsgBox(ligne)
                    Dim champs() As String = ligne.Split(";")
                    Dim e As New Etu With {
                .DA = champs(0),
                .Nom = champs(1),
                .Prenom = champs(2),
                .Sexe = champs(3),
                .Ville = champs(4),
                .NbCoursReussi = champs(5),
                .Moyenne = champs(6),
                .Status = champs(7)
                }
                    _TabEleve.Add(e)
                    ligne = sr.ReadLine
                Loop

                sr.Close()
                fs.Close()

            End If
            _NbConnexions += 1

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
#End Region
    '////////////////// DESTRUCTEUR ///////////////////
#Region "Destructeur"
    Protected Overrides Sub Finalize()
        Try
            _NbConnexions -= 1
            If _NbConnexions = 0 Then
                ' Pour recréer le contenu du fichier avec la ArrayList TabEtu
                Dim fs As New FileStream(NomFichier, FileMode.Create, FileAccess.Write, FileShare.None)
                Dim sw As New StreamWriter(fs)
                ' Lire le fichier
                'Dim ligne As String
                Dim e As Etu
                Dim i As Integer
                For i = 0 To _TabEleve.Count - 1
                    e = _TabEleve(i)
                    sw.WriteLine(e.DA & ";" & ' 7 car numérique
                                 e.Nom & ";" & ' 15 car lettre
                                 e.Prenom & ";" & ' 15 car lettre
                                 e.Sexe & ";" & ' 1 char M ou F
                                 e.Ville & ";" & ' 20 car lettre
                                 e.NbCoursReussi & ";" & ' integer entre 0 et 25
                                 e.Moyenne & ";" & ' Single entre 0 et 100
                                 e.Status & ";") ' char I, A ou X
                Next

                sw.Close()
                fs.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
#End Region

#Region "MÉTHODES"
    '////////////////////// MÉTHODES ///////////////////////////
    Public Sub AjouterEleve(da As Integer, nom As String, prenom As String, sexe As Char,
                            ville As String, nbcoursreussi As Integer, moyenne As Single, status As Char)
        Try
            Dim e As New Etu With {
        .DA = da,
        .Nom = nom,
        .Prenom = prenom,
        .Sexe = sexe,
        .Ville = ville,
        .NbCoursReussi = nbcoursreussi,
        .Moyenne = moyenne,
        .Status = status
        }

            'Ajouter l'élève au tableau
            _TabEleve.Add(e)
            MsgBox("L'élève " & prenom & " " & nom & " ajouté avec succès!")

            If _TabEleve.Count Mod 5 = 0 Then
                RaiseEvent BesoinProf(_TabEleve.Count)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SupprimerEleve(index As Integer)
        Try
            _TabEleve.RemoveAt(index)
            MsgBox("Élève supprimé avec succès!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ModifierEleve(index As Integer, da As Integer, nom As String, prenom As String, sexe As Char,
                            ville As String, nbcoursreussi As Integer, moyenne As Single, status As Char)
        Try
            Dim e As New Etu
            e.DA = da
            e.Nom = nom
            e.Prenom = prenom
            e.Sexe = sexe
            e.Ville = ville
            e.NbCoursReussi = nbcoursreussi
            e.Moyenne = moyenne
            e.Status = status

            'Modifier l'élève au tableau
            _TabEleve.RemoveAt(index)
            _TabEleve.Insert(index, e)

            MsgBox("L'élève " & prenom & " " & nom & " modifié avec succès!")

            If nbcoursreussi >= 20 Then
                RaiseEvent DiplomeObtenu()
            End If
            If status = "X" And nbcoursreussi < 20 Then
                RaiseEvent EchecEleve()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Function GenererDA() As Integer
        Dim dt As DateTime = DateTime.Now
        Dim nouveauDA As Integer = CInt(dt.ToString("yy")) & CInt("10001")
        Dim e As New Etu
        If _TabEleve.Count = 0 Then
            Return nouveauDA
        Else
            For Each e In _TabEleve
                If e.DA = nouveauDA Then
                    nouveauDA += 1
                End If
            Next
            Return nouveauDA
        End If
    End Function

    Public Sub ChargerListeEleves(list As ListView)
        Try
            list.Clear()
            list.Sorting = SortOrder.None
            ' En-têtes du listview
            list.Columns.Add("DA", 55)
            list.Columns.Add("Nom", 100)
            list.Columns.Add("Prénom", 100)
            list.Columns.Add("Sexe", 50, HorizontalAlignment.Center)
            list.Columns.Add("Ville", 80)
            list.Columns.Add("Cours réussis", 80, HorizontalAlignment.Center)
            list.Columns.Add("Moy", 50, HorizontalAlignment.Right)
            list.Columns.Add("Status", 50, HorizontalAlignment.Center)

            'Propriétés
            list.FullRowSelect = True
            list.View = View.Details

            Dim eleve(7) As String ' 8 Propriétés (DA, nom, prénom....)
            Dim ligne As ListViewItem
            Dim e As New Etu
            For Each e In _TabEleve
                eleve(0) = e.DA.ToString.ToUpper
                eleve(1) = e.Nom.ToString.ToUpper
                eleve(2) = e.Prenom.ToString.ToUpper
                eleve(3) = e.Sexe.ToString.ToUpper
                eleve(4) = e.Ville.ToString.ToUpper
                eleve(5) = e.NbCoursReussi.ToString
                eleve(6) = e.Moyenne.ToString & " %"
                eleve(7) = e.Status.ToString.ToUpper

                ligne = New ListViewItem(eleve)
                list.Items.Add(ligne)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
        End Try
    End Sub

    Public Function CalculerMoyenne() As Single

        Dim somme As Single = 0
        Dim e As New Etu
        For Each e In _TabEleve
            somme += e.Moyenne
        Next
        Return somme / _TabEleve.Count
    End Function

#End Region

#Region "Evénements"
    Public Event BesoinProf(nbr As Integer)
    Public Event DiplomeObtenu()
    Public Event EchecEleve()
#End Region

End Class



