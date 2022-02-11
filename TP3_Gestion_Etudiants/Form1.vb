' TITRE:   Programme_Test
' DESCRIPTION: Ce programme est conçu pour tester les classes ListeEleves et Etu.
' Il gère les inscriptions par la saisie des informations relatives à chaque élève.
'FAIT PAR : Alex Morissette
' Révisé le : 22 juin 2021
Public Class Form1

    ' Variables
    Dim WithEvents ListeEtudiants As New ListeEleves
    Dim actionCourante As Action = Action.Aucune
    Dim No_Etu As Integer = 0
    Dim nb_Prof As Integer = 0

    ''' <summary>
    ''' Procédure qui charge les informations des étudiants et prépare les contrôles pour l'utilisateur.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If ListeEtudiants.Nb_Etu > 0 Then

                nb_Prof = ListeEtudiants.Nb_Etu \ 5 ' Récupérer le nombre de professeurs
                lblNbProf.Text = nb_Prof

                DeBarrer(grpNav, cmdModifier, cmdSupprimer)
                Barrer(grpInfoEtu)
                RecupererEtu(No_Etu)

                ListeEtudiants.ChargerListeEleves(lvListeEtu)
                lblMoyGenCalc.Text = ListeEtudiants.CalculerMoyenne().ToString("F2") & " %"
            Else
                Barrer(grpNav, grpInfoEtu, cmdModifier, cmdSupprimer, grpRecherche)
            End If
            cbFiltre.SelectedIndex = 0
            lblQteResultat.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Procédure qui permet de récupérer les informations d'un étudiant dans les cahmps du formulaire.
    ''' </summary>
    ''' <param name="no">Index correspondant à l'étudiant dans le tableau</param>
    Public Sub RecupererEtu(no As Integer)
        Try
            Dim etu As Etu
            etu = ListeEtudiants.Etudiant(no)

            txtDA.Text = etu.DA
            txtNom.Text = etu.Nom
            txtPrenom.Text = etu.Prenom
            cbSexe.Text = etu.Sexe
            txtVille.Text = etu.Ville
            numNbCoursR.Value = etu.NbCoursReussi
            numMoyenne.Value = etu.Moyenne
            cbStatus.Text = etu.Status

            lblMode.Text = "Étudiant " & no + 1 & " de " & ListeEtudiants.Nb_Etu

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#Region "NAVIGATION"
    '//////////////////// NAVIGATION ////////////////////////////
    ''' <summary>
    ''' Procédure qui permet de récupérer les informations du premier étudiant. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPremier_Click(sender As Object, e As EventArgs) Handles cmdPremier.Click
        Try
            No_Etu = 0
            RecupererEtu(No_Etu)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de récupérer les informations de l'étudiant précédant celui actuellement affiché. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPrecedent_Click(sender As Object, e As EventArgs) Handles cmdPrecedent.Click
        Try
            If No_Etu = 0 Then
                cmdPremier.PerformClick()
            Else
                No_Etu -= 1
                RecupererEtu(No_Etu)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de récupérer les informations de étudiant suivant celui affiché. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdSuivant_Click(sender As Object, e As EventArgs) Handles cmdSuivant.Click
        Try
            If No_Etu = ListeEtudiants.Nb_Etu - 1 Then
                cmdDernier.PerformClick()
            Else
                No_Etu += 1
                RecupererEtu(No_Etu)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de récupérer les informations du dernier étudiant. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdDernier_Click(sender As Object, e As EventArgs) Handles cmdDernier.Click
        Try
            No_Etu = ListeEtudiants.Nb_Etu - 1
            RecupererEtu(No_Etu)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
#End Region

#Region "UTILITAIRES"
    '//////////////////// UTILITAIRES ////////////////////////
    ''' <summary>
    ''' Procédure pour barrer des contrôles
    ''' </summary>
    ''' <param name="ctrl">Un tableau dynamique des contrôles à débarrer.</param>
    Private Sub Barrer(ParamArray ctrl() As Control)
        Try
            For Each c As Control In ctrl
                c.Enabled = False
            Next

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    ''' <summary>
    ''' Procédure pour débarrer des contrôles
    ''' </summary>
    ''' <param name="ctrl">Un tableau dynamique des contrôles à débarrer.</param>
    Private Sub DeBarrer(ParamArray ctrl() As Control)
        Try
            For Each c As Control In ctrl
                c.Enabled = True
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Procédure pour vider les champs du formulaire.
    ''' </summary>
    Private Sub ViderChamps()
        Try
            txtDA.Clear()
            txtNom.Clear()
            txtPrenom.Clear()
            cbSexe.Text = ""
            txtVille.Clear()
            numNbCoursR.Value = 0
            numMoyenne.Value = 0
            cbStatus.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de vider le champ de recherche
    ''' </summary>
    Private Sub ViderRecherche()
        Try
            txtRecherche.Clear()
            lblQteResultat.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
#End Region

#Region "CMD CONTRÔLES"
    '///////////////// CMD - CONTROLES DE GESTION //////////////////////////
    ''' <summary>
    ''' Procédure qui permet de confimer la capture des informations saisies 
    ''' dans le formulaire lors de l'ajout et de la modification d'un éléve.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Try
            If ValiderChamps() = False Then
                MsgBox("Vous devez compléter tous les champs.", MsgBoxStyle.Exclamation, "Validation")
                Err1.Clear()
                Return
            End If

            Dim da, nbCoursReussi As Integer
            Dim nom, prenom, ville As String
            Dim sexe, status As Char
            Dim moyenne As Single

            nom = txtNom.Text.Trim()
            prenom = txtPrenom.Text.Trim()
            sexe = cbSexe.SelectedItem
            ville = txtVille.Text.Trim()
            nbCoursReussi = numNbCoursR.Value
            moyenne = numMoyenne.Value
            status = cbStatus.SelectedItem
            If actionCourante = Action.Ajout Then
                da = ListeEtudiants.GenererDA()
                ListeEtudiants.AjouterEleve(da, nom, prenom, sexe, ville, nbCoursReussi, moyenne, status)
                cmdAnnuler.PerformClick()
                cmdDernier.PerformClick()
            ElseIf actionCourante = Action.Modification Then
                da = txtDA.Text
                ListeEtudiants.ModifierEleve(No_Etu, da, nom, prenom, sexe, ville, nbCoursReussi, moyenne, status)
                'RecupererEtu(No_Etu)
                cmdAnnuler.PerformClick() '' Vérifier ici
            End If

            lblMoyGenCalc.Text = ListeEtudiants.CalculerMoyenne().ToString("F2") & " %"

            If ListeEtudiants.Nb_Etu > 0 Then
                ListeEtudiants.ChargerListeEleves(lvListeEtu)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    ''' <summary>
    ''' Procédure qui permet de préparer le formulaire pour la saisie des informations pour l'ajout.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdAjouter_Click(sender As Object, e As EventArgs) Handles cmdAjouter.Click
        Try
            actionCourante = Action.Ajout
            Barrer(cmdModifier, cmdAjouter, cmdSupprimer, grpNav, grpRecherche)
            DeBarrer(grpInfoEtu, cmdOK, cmdAnnuler)
            ViderChamps()
            txtNom.Focus()
            cbStatus.SelectedIndex = 0
            lblMode.Text = "*** Mode ajout ***"

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de préparer le formulaire pour la saisie des informations pour la modfication.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        Try
            Barrer(grpNav, cmdAjouter, cmdSupprimer, cmdModifier, grpRecherche)
            DeBarrer(grpInfoEtu, cmdOK, cmdAnnuler)
            actionCourante = Action.Modification

            lblMode.Text = "*** Mode modif ***"

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    ''' <summary>
    ''' Procédure qui permet de supprimer un élève.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdSupprimer_Click(sender As Object, e As EventArgs) Handles cmdSupprimer.Click
        Try
            Dim rep As DialogResult
            rep = MsgBox("Voulez-vous vraiment supprimer cet étudiant ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
            If rep = DialogResult.Yes Then
                ListeEtudiants.SupprimerEleve(No_Etu)
                'lv = lvListeEtu
                ListeEtudiants.ChargerListeEleves(lvListeEtu)
                If ListeEtudiants.Nb_Etu > 0 Then
                    cmdPremier.PerformClick()
                Else
                    'no_Etu = 0
                    ViderChamps()
                    Barrer(grpInfoEtu, grpNav, cmdOK, cmdAnnuler, cmdModifier, cmdSupprimer, grpRecherche)
                    lblMode.Text = ""
                End If
            Else
                cmdAnnuler.PerformClick()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de préparer le formulaire pour l'annulation de l'action courante (ajout ou modif).
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        Try
            actionCourante = Action.Aucune

            If ListeEtudiants.Nb_Etu > 0 Then

                Barrer(cmdOK, cmdAnnuler, grpInfoEtu)
                DeBarrer(cmdAjouter, cmdModifier, grpNav, cmdSupprimer, grpRecherche)
                RecupererEtu(No_Etu)

            Else

                ViderChamps()
                Barrer(cmdOK, cmdAnnuler, cmdSupprimer, cmdModifier, grpNav, grpInfoEtu)
                DeBarrer(cmdAjouter)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub cmdQuitter_Click(sender As Object, e As EventArgs) Handles cmdQuitter.Click
        Try
            Dim rep As DialogResult
            rep = MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.YesNo + MessageBoxIcon.Question, "Confirmation")
            If (rep = DialogResult.Yes) Then
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
#End Region

#Region "VALIDATION"
    '****************** VALIDATION *************************

    ''' <summary>
    ''' Procédure qui permet de valider les champs du nom et du prénom
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ValiderChaine(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress, txtPrenom.KeyPress
        Try
            If Char.IsLetter(e.KeyChar) Or
            Char.IsWhiteSpace(e.KeyChar) Or
            e.KeyChar = Chr(8) Or
            e.KeyChar = "-" _
            Or e.KeyChar = "'" Then
                Exit Sub
            Else
                e.KeyChar = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de valider les champs de la ville
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ValiderChaineVille(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or
            Char.IsWhiteSpace(e.KeyChar) Or
            e.KeyChar = Chr(8) Or
            e.KeyChar = "-" Or
            e.KeyChar = "'" Then
                Exit Sub
            Else
                e.KeyChar = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Fonction qui valide que tous les champs
    ''' </summary>
    ''' <returns>Vrai ou faux selon l'état du formulaire</returns>
    Private Function ValiderChamps() As Boolean
        Dim valide As Boolean = True
        Err1.Clear()
        If txtNom.Text.Trim = "" Then
            valide = False
            Err1.SetError(txtNom, "Nom obligatoire")
        End If

        If txtPrenom.Text.Trim = "" Then
            valide = False
            Err1.SetError(txtPrenom, "Prénom obligatoire")
        End If

        If cbSexe.Text = "" Then
            valide = False
            Err1.SetError(cbSexe, "Sexe obligatoire")
        End If

        If txtVille.Text.Trim = "" Then
            valide = False
            Err1.SetError(txtVille, "Ville obligatoire")
        End If

        If cbStatus.Text = "" Then
            valide = False
            Err1.SetError(cbStatus, "Status obligatoire")
        End If
        Return valide
    End Function
#End Region


#Region "RECHERCHE"
    '********************** Recherche **************************

    ''' <summary>
    ''' Procédure qui permet de vider le ListView
    ''' </summary>
    Public Sub ResetListView()
        Try
            lvListeEtu.Clear()

            lvListeEtu.Columns.Add("DA", 55)
            lvListeEtu.Columns.Add("Nom", 100)
            lvListeEtu.Columns.Add("Prénom", 100)
            lvListeEtu.Columns.Add("Sexe", 50, HorizontalAlignment.Center)
            lvListeEtu.Columns.Add("Ville", 80)
            lvListeEtu.Columns.Add("Cours réussis", 80, HorizontalAlignment.Center)
            lvListeEtu.Columns.Add("Moy", 50, HorizontalAlignment.Right)
            lvListeEtu.Columns.Add("Status", 50, HorizontalAlignment.Center)

            lvListeEtu.FullRowSelect = True
            lvListeEtu.View = View.Details

            lblQteResultat.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de chercher des carcatères dans le tableau des étudiants selon des critères
    ''' </summary>
    ''' <param name="f">Option de filtre</param>
    ''' <param name="el">Array qui sera inséré au ListView</param>
    Public Sub RechercheFiltre(f As Object, el() As String)
        Try
            If cbFiltre.SelectedItem = f Then
                If txtRecherche.Text = "" Then
                    ListeEtudiants.ChargerListeEleves(lvListeEtu)
                ElseIf el(cbFiltre.SelectedIndex).Contains(txtRecherche.Text.Trim.ToUpper) Then
                    'Ajouter l'item au ListView
                    Dim ligne = New ListViewItem(el) 'Ajout des info de l'étudiant ci-dessus au ListViewItem
                    lvListeEtu.Items.Add(ligne) 'Ajout l'étudiant (ligne) au ListView
                    lblQteResultat.Text = lvListeEtu.Items.Count.ToString() 'Afficher le nombre d'étudiants correspondant à la requête
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>
    ''' Procédure qui permet de charger les informations de tous les étudiants dans tableau afin de le comparer .
    ''' </summary>
    Public Sub Rechercher()
        Try
            ResetListView()

            Dim eleve(7) As String ' 8 Propriétés (DA, nom, prénom....)
            Dim e As New Etu
            Dim no As Integer
            no = 0
            Do
                e = ListeEtudiants.Etudiant(no)
                eleve(0) = e.DA.ToString.ToUpper
                eleve(1) = e.Nom.ToString.ToUpper
                eleve(2) = e.Prenom.ToString.ToUpper
                eleve(3) = e.Sexe.ToString.ToUpper
                eleve(4) = e.Ville.ToString.ToUpper
                eleve(5) = e.NbCoursReussi.ToString
                eleve(6) = e.Moyenne.ToString & " %"
                eleve(7) = e.Status.ToString.ToUpper

                no += 1
                RechercheFiltre(cbFiltre.SelectedItem, eleve)
                If no = ListeEtudiants.Nb_Etu Then Exit Sub
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
        End Try

    End Sub

    ''' <summary>
    ''' Procédure qui permet de d'appeler la procédure Rechercher() aussitôt que le texte du champ de recherche change.
    ''' </summary>
    Private Sub txtRecherche_TextChanged(sender As Object, e As EventArgs) Handles txtRecherche.TextChanged
        Rechercher()
    End Sub

    '''' <summary>
    '''' Procédure qui permet de d'appeler la procédure RecuperEtu() en cliquant sur la ligne correspondant à l'élève désiré dans le listview.
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    'Private Sub lvListeEtu_Click(sender As Object, e As EventArgs) Handles lvListeEtu.Click
    '    Try
    '        If txtRecherche.Text <> "" Then
    '            Return
    '        Else
    '            No_Etu = lvListeEtu.FocusedItem.Index
    '            RecupererEtu(No_Etu)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    ''' <summary>
    ''' Procédure qui permet de d'appeler les procédures qui vide les champs de recherche 
    ''' et qui charge le listview des informations des listes d'élèves.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbFiltre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltre.SelectedIndexChanged
        ListeEtudiants.ChargerListeEleves(lvListeEtu)
        ViderRecherche()
        txtRecherche.Focus()
    End Sub

#End Region

#Region "Evenement"

    ''' <summary>
    ''' Procédure qui permet d'afficher un message à l'utilisateur lorsque l'événement se produit. Besoin d'un prof.
    ''' </summary>
    ''' <param name="nbr">Nombre d'élèves inscrits</param>
    Private Sub BesoinProf(nbr As Integer) Handles ListeEtudiants.BesoinProf
        MsgBox("L'école a maintenant " & ListeEtudiants.Nb_Etu & " élèves. Vous avez besoin d'un nouveau professeur!", MsgBoxStyle.Information, "Recrutement")
        nb_Prof = nbr \ 5
        lblNbProf.Text = nb_Prof
    End Sub

    ''' <summary>
    ''' Procédure qui permet d'afficher un message à l'utilisateur lorsque l'événement se produit. Obtenition d'un diplôme.
    ''' </summary>
    Private Sub DiplomeObtenu() Handles ListeEtudiants.DiplomeObtenu
        MsgBox("L'élève a réussi " & ListeEtudiants.Etudiant(No_Etu).NbCoursReussi & " cours. Il obtient son diplôme!", MsgBoxStyle.Information, "Graduation")
    End Sub

    ''' <summary>
    ''' Procédure qui permet d'afficher un message à l'utilisateur lorsque l'événement se produit. Élève en echec.
    ''' </summary>
    Private Sub EchecEleve() Handles ListeEtudiants.EchecEleve
        MsgBox("L'élève est en situation d'échec. Merci de lui en informer gentillement.", MsgBoxStyle.Critical, "Message important")

    End Sub

    Private Sub cmdApropos_Click(sender As Object, e As EventArgs) Handles cmdApropos.Click
        frmApropos.ShowDialog()
    End Sub

#End Region

End Class
