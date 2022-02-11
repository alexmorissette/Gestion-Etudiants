<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdAjouter = New System.Windows.Forms.Button()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.cbSexe = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.numNbCoursR = New System.Windows.Forms.NumericUpDown()
        Me.numMoyenne = New System.Windows.Forms.NumericUpDown()
        Me.txtDA = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblSexe = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblNbCoursReussi = New System.Windows.Forms.Label()
        Me.lblMoyenne = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdPremier = New System.Windows.Forms.Button()
        Me.cmdPrecedent = New System.Windows.Forms.Button()
        Me.cmdSuivant = New System.Windows.Forms.Button()
        Me.cmdDernier = New System.Windows.Forms.Button()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.grpInfoEtu = New System.Windows.Forms.GroupBox()
        Me.lblDA = New System.Windows.Forms.Label()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdSupprimer = New System.Windows.Forms.Button()
        Me.Err1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.grpRecherche = New System.Windows.Forms.GroupBox()
        Me.lblTitreRecherche = New System.Windows.Forms.Label()
        Me.lvListeEtu = New System.Windows.Forms.ListView()
        Me.grpFiltres = New System.Windows.Forms.GroupBox()
        Me.cbFiltre = New System.Windows.Forms.ComboBox()
        Me.lblNbrResultats = New System.Windows.Forms.Label()
        Me.lblQteResultat = New System.Windows.Forms.Label()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.grpNav = New System.Windows.Forms.GroupBox()
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.lblMoyGenerale = New System.Windows.Forms.Label()
        Me.lblMoyGenCalc = New System.Windows.Forms.Label()
        Me.lblProfesseurs = New System.Windows.Forms.Label()
        Me.lblNbProf = New System.Windows.Forms.Label()
        Me.cmdApropos = New System.Windows.Forms.Button()
        CType(Me.numNbCoursR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMoyenne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfoEtu.SuspendLayout()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRecherche.SuspendLayout()
        Me.grpFiltres.SuspendLayout()
        Me.grpNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAjouter
        '
        Me.cmdAjouter.Location = New System.Drawing.Point(459, 40)
        Me.cmdAjouter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAjouter.Name = "cmdAjouter"
        Me.cmdAjouter.Size = New System.Drawing.Size(196, 59)
        Me.cmdAjouter.TabIndex = 13
        Me.cmdAjouter.Text = "&Ajouter un étudiant"
        Me.cmdAjouter.UseVisualStyleBackColor = True
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(164, 83)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNom.MaxLength = 15
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(200, 29)
        Me.txtNom.TabIndex = 2
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(164, 120)
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrenom.MaxLength = 15
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(200, 29)
        Me.txtPrenom.TabIndex = 3
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(164, 196)
        Me.txtVille.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVille.MaxLength = 30
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(246, 29)
        Me.txtVille.TabIndex = 5
        '
        'cbSexe
        '
        Me.cbSexe.DisplayMember = "(aucun)"
        Me.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexe.FormattingEnabled = True
        Me.cbSexe.Items.AddRange(New Object() {"F", "M"})
        Me.cbSexe.Location = New System.Drawing.Point(164, 156)
        Me.cbSexe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSexe.MaxDropDownItems = 2
        Me.cbSexe.MaxLength = 1
        Me.cbSexe.Name = "cbSexe"
        Me.cbSexe.Size = New System.Drawing.Size(55, 30)
        Me.cbSexe.TabIndex = 4
        '
        'cbStatus
        '
        Me.cbStatus.DisplayMember = "Items"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"A", "I", "X"})
        Me.cbStatus.Location = New System.Drawing.Point(164, 312)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbStatus.MaxDropDownItems = 3
        Me.cbStatus.MaxLength = 1
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(119, 30)
        Me.cbStatus.TabIndex = 8
        Me.cbStatus.ValueMember = "Items"
        '
        'numNbCoursR
        '
        Me.numNbCoursR.Location = New System.Drawing.Point(165, 238)
        Me.numNbCoursR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numNbCoursR.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.numNbCoursR.Name = "numNbCoursR"
        Me.numNbCoursR.Size = New System.Drawing.Size(54, 29)
        Me.numNbCoursR.TabIndex = 6
        '
        'numMoyenne
        '
        Me.numMoyenne.DecimalPlaces = 1
        Me.numMoyenne.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numMoyenne.Location = New System.Drawing.Point(165, 275)
        Me.numMoyenne.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numMoyenne.Name = "numMoyenne"
        Me.numMoyenne.Size = New System.Drawing.Size(69, 29)
        Me.numMoyenne.TabIndex = 7
        '
        'txtDA
        '
        Me.txtDA.Enabled = False
        Me.txtDA.Location = New System.Drawing.Point(164, 46)
        Me.txtDA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDA.MaxLength = 7
        Me.txtDA.Name = "txtDA"
        Me.txtDA.Size = New System.Drawing.Size(93, 29)
        Me.txtDA.TabIndex = 9
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(25, 83)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(133, 29)
        Me.lblNom.TabIndex = 11
        Me.lblNom.Text = "Nom :"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrenom
        '
        Me.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenom.Location = New System.Drawing.Point(25, 120)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(133, 29)
        Me.lblPrenom.TabIndex = 12
        Me.lblPrenom.Text = "Prénom :"
        Me.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSexe
        '
        Me.lblSexe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSexe.Location = New System.Drawing.Point(25, 159)
        Me.lblSexe.Name = "lblSexe"
        Me.lblSexe.Size = New System.Drawing.Size(133, 29)
        Me.lblSexe.TabIndex = 13
        Me.lblSexe.Text = "Sexe :"
        Me.lblSexe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVille
        '
        Me.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVille.Location = New System.Drawing.Point(25, 196)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(133, 29)
        Me.lblVille.TabIndex = 14
        Me.lblVille.Text = "Ville :"
        Me.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNbCoursReussi
        '
        Me.lblNbCoursReussi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbCoursReussi.Location = New System.Drawing.Point(25, 237)
        Me.lblNbCoursReussi.Name = "lblNbCoursReussi"
        Me.lblNbCoursReussi.Size = New System.Drawing.Size(133, 29)
        Me.lblNbCoursReussi.TabIndex = 15
        Me.lblNbCoursReussi.Text = "Cours Réussis :"
        Me.lblNbCoursReussi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoyenne
        '
        Me.lblMoyenne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoyenne.Location = New System.Drawing.Point(26, 275)
        Me.lblMoyenne.Name = "lblMoyenne"
        Me.lblMoyenne.Size = New System.Drawing.Size(133, 29)
        Me.lblMoyenne.TabIndex = 16
        Me.lblMoyenne.Text = "Moyenne :"
        Me.lblMoyenne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Location = New System.Drawing.Point(25, 312)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(133, 29)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Status :"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdPremier
        '
        Me.cmdPremier.Location = New System.Drawing.Point(6, 21)
        Me.cmdPremier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPremier.Name = "cmdPremier"
        Me.cmdPremier.Size = New System.Drawing.Size(45, 34)
        Me.cmdPremier.TabIndex = 9
        Me.cmdPremier.Text = "|<"
        Me.cmdPremier.UseVisualStyleBackColor = True
        '
        'cmdPrecedent
        '
        Me.cmdPrecedent.Location = New System.Drawing.Point(57, 21)
        Me.cmdPrecedent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPrecedent.Name = "cmdPrecedent"
        Me.cmdPrecedent.Size = New System.Drawing.Size(35, 34)
        Me.cmdPrecedent.TabIndex = 10
        Me.cmdPrecedent.Text = "<"
        Me.cmdPrecedent.UseVisualStyleBackColor = True
        '
        'cmdSuivant
        '
        Me.cmdSuivant.Location = New System.Drawing.Point(340, 21)
        Me.cmdSuivant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSuivant.Name = "cmdSuivant"
        Me.cmdSuivant.Size = New System.Drawing.Size(35, 34)
        Me.cmdSuivant.TabIndex = 11
        Me.cmdSuivant.Text = ">"
        Me.cmdSuivant.UseVisualStyleBackColor = True
        '
        'cmdDernier
        '
        Me.cmdDernier.Location = New System.Drawing.Point(381, 21)
        Me.cmdDernier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDernier.Name = "cmdDernier"
        Me.cmdDernier.Size = New System.Drawing.Size(43, 34)
        Me.cmdDernier.TabIndex = 12
        Me.cmdDernier.Text = ">|"
        Me.cmdDernier.UseVisualStyleBackColor = True
        '
        'lblMode
        '
        Me.lblMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMode.Location = New System.Drawing.Point(98, 21)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(236, 34)
        Me.lblMode.TabIndex = 22
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpInfoEtu
        '
        Me.grpInfoEtu.Controls.Add(Me.lblDA)
        Me.grpInfoEtu.Controls.Add(Me.txtNom)
        Me.grpInfoEtu.Controls.Add(Me.txtPrenom)
        Me.grpInfoEtu.Controls.Add(Me.txtVille)
        Me.grpInfoEtu.Controls.Add(Me.cbSexe)
        Me.grpInfoEtu.Controls.Add(Me.cbStatus)
        Me.grpInfoEtu.Controls.Add(Me.lblStatus)
        Me.grpInfoEtu.Controls.Add(Me.numNbCoursR)
        Me.grpInfoEtu.Controls.Add(Me.lblMoyenne)
        Me.grpInfoEtu.Controls.Add(Me.numMoyenne)
        Me.grpInfoEtu.Controls.Add(Me.lblNbCoursReussi)
        Me.grpInfoEtu.Controls.Add(Me.txtDA)
        Me.grpInfoEtu.Controls.Add(Me.lblVille)
        Me.grpInfoEtu.Controls.Add(Me.lblNom)
        Me.grpInfoEtu.Controls.Add(Me.lblSexe)
        Me.grpInfoEtu.Controls.Add(Me.lblPrenom)
        Me.grpInfoEtu.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfoEtu.Location = New System.Drawing.Point(12, 26)
        Me.grpInfoEtu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInfoEtu.Name = "grpInfoEtu"
        Me.grpInfoEtu.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInfoEtu.Size = New System.Drawing.Size(431, 359)
        Me.grpInfoEtu.TabIndex = 23
        Me.grpInfoEtu.TabStop = False
        Me.grpInfoEtu.Text = "Informations de l'étudiant"
        '
        'lblDA
        '
        Me.lblDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDA.Location = New System.Drawing.Point(25, 46)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(133, 29)
        Me.lblDA.TabIndex = 10
        Me.lblDA.Text = "DA :"
        Me.lblDA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdModifier
        '
        Me.cmdModifier.Location = New System.Drawing.Point(459, 117)
        Me.cmdModifier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(196, 58)
        Me.cmdModifier.TabIndex = 14
        Me.cmdModifier.Text = "&Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdSupprimer
        '
        Me.cmdSupprimer.Location = New System.Drawing.Point(459, 191)
        Me.cmdSupprimer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSupprimer.Name = "cmdSupprimer"
        Me.cmdSupprimer.Size = New System.Drawing.Size(196, 60)
        Me.cmdSupprimer.TabIndex = 15
        Me.cmdSupprimer.Text = "&Supprimer"
        Me.cmdSupprimer.UseVisualStyleBackColor = True
        '
        'Err1
        '
        Me.Err1.ContainerControl = Me
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.Color.LightGreen
        Me.cmdOK.Enabled = False
        Me.cmdOK.Location = New System.Drawing.Point(13, 473)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(196, 44)
        Me.cmdOK.TabIndex = 16
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.BackColor = System.Drawing.Color.IndianRed
        Me.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAnnuler.Enabled = False
        Me.cmdAnnuler.Location = New System.Drawing.Point(247, 473)
        Me.cmdAnnuler.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(196, 45)
        Me.cmdAnnuler.TabIndex = 17
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = False
        '
        'grpRecherche
        '
        Me.grpRecherche.Controls.Add(Me.lblTitreRecherche)
        Me.grpRecherche.Controls.Add(Me.lvListeEtu)
        Me.grpRecherche.Controls.Add(Me.grpFiltres)
        Me.grpRecherche.Controls.Add(Me.txtRecherche)
        Me.grpRecherche.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRecherche.Location = New System.Drawing.Point(670, 26)
        Me.grpRecherche.Name = "grpRecherche"
        Me.grpRecherche.Size = New System.Drawing.Size(615, 427)
        Me.grpRecherche.TabIndex = 28
        Me.grpRecherche.TabStop = False
        Me.grpRecherche.Text = "Liste des étudiants"
        '
        'lblTitreRecherche
        '
        Me.lblTitreRecherche.Location = New System.Drawing.Point(6, 41)
        Me.lblTitreRecherche.Name = "lblTitreRecherche"
        Me.lblTitreRecherche.Size = New System.Drawing.Size(151, 24)
        Me.lblTitreRecherche.TabIndex = 38
        Me.lblTitreRecherche.Text = "Rechercher :"
        '
        'lvListeEtu
        '
        Me.lvListeEtu.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvListeEtu.FullRowSelect = True
        Me.lvListeEtu.GridLines = True
        Me.lvListeEtu.HideSelection = False
        Me.lvListeEtu.Location = New System.Drawing.Point(9, 125)
        Me.lvListeEtu.MultiSelect = False
        Me.lvListeEtu.Name = "lvListeEtu"
        Me.lvListeEtu.Size = New System.Drawing.Size(600, 296)
        Me.lvListeEtu.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvListeEtu.TabIndex = 35
        Me.lvListeEtu.UseCompatibleStateImageBehavior = False
        Me.lvListeEtu.View = System.Windows.Forms.View.Details
        '
        'grpFiltres
        '
        Me.grpFiltres.Controls.Add(Me.cbFiltre)
        Me.grpFiltres.Controls.Add(Me.lblNbrResultats)
        Me.grpFiltres.Controls.Add(Me.lblQteResultat)
        Me.grpFiltres.Location = New System.Drawing.Point(259, 28)
        Me.grpFiltres.Name = "grpFiltres"
        Me.grpFiltres.Size = New System.Drawing.Size(350, 91)
        Me.grpFiltres.TabIndex = 19
        Me.grpFiltres.TabStop = False
        Me.grpFiltres.Text = "Filtres de recherche"
        '
        'cbFiltre
        '
        Me.cbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltre.FormattingEnabled = True
        Me.cbFiltre.Items.AddRange(New Object() {"Par DA", "Par Nom", "Par Prénom", "Par Sexe", "Par Ville", "Par Cours Réussis", "Par Moyenne", "Par Status"})
        Me.cbFiltre.Location = New System.Drawing.Point(16, 40)
        Me.cbFiltre.Name = "cbFiltre"
        Me.cbFiltre.Size = New System.Drawing.Size(165, 30)
        Me.cbFiltre.TabIndex = 33
        '
        'lblNbrResultats
        '
        Me.lblNbrResultats.Location = New System.Drawing.Point(256, 40)
        Me.lblNbrResultats.Name = "lblNbrResultats"
        Me.lblNbrResultats.Size = New System.Drawing.Size(88, 29)
        Me.lblNbrResultats.TabIndex = 33
        Me.lblNbrResultats.Text = "résultat(s)"
        Me.lblNbrResultats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQteResultat
        '
        Me.lblQteResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQteResultat.Location = New System.Drawing.Point(211, 40)
        Me.lblQteResultat.Name = "lblQteResultat"
        Me.lblQteResultat.Size = New System.Drawing.Size(39, 29)
        Me.lblQteResultat.TabIndex = 34
        Me.lblQteResultat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecherche
        '
        Me.txtRecherche.Location = New System.Drawing.Point(9, 68)
        Me.txtRecherche.MaxLength = 30
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(241, 29)
        Me.txtRecherche.TabIndex = 18
        '
        'grpNav
        '
        Me.grpNav.Controls.Add(Me.cmdPremier)
        Me.grpNav.Controls.Add(Me.cmdPrecedent)
        Me.grpNav.Controls.Add(Me.lblMode)
        Me.grpNav.Controls.Add(Me.cmdSuivant)
        Me.grpNav.Controls.Add(Me.cmdDernier)
        Me.grpNav.Location = New System.Drawing.Point(13, 392)
        Me.grpNav.Name = "grpNav"
        Me.grpNav.Size = New System.Drawing.Size(430, 62)
        Me.grpNav.TabIndex = 30
        Me.grpNav.TabStop = False
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Location = New System.Drawing.Point(1089, 477)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(196, 41)
        Me.cmdQuitter.TabIndex = 22
        Me.cmdQuitter.Text = "&Quitter"
        Me.cmdQuitter.UseVisualStyleBackColor = True
        '
        'lblMoyGenerale
        '
        Me.lblMoyGenerale.Font = New System.Drawing.Font("Open Sans Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoyGenerale.Location = New System.Drawing.Point(670, 477)
        Me.lblMoyGenerale.Name = "lblMoyGenerale"
        Me.lblMoyGenerale.Size = New System.Drawing.Size(211, 40)
        Me.lblMoyGenerale.TabIndex = 31
        Me.lblMoyGenerale.Text = "Moyenne générale :"
        Me.lblMoyGenerale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoyGenCalc
        '
        Me.lblMoyGenCalc.BackColor = System.Drawing.Color.LightBlue
        Me.lblMoyGenCalc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMoyGenCalc.Location = New System.Drawing.Point(887, 478)
        Me.lblMoyGenCalc.Name = "lblMoyGenCalc"
        Me.lblMoyGenCalc.Size = New System.Drawing.Size(105, 40)
        Me.lblMoyGenCalc.TabIndex = 32
        Me.lblMoyGenCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfesseurs
        '
        Me.lblProfesseurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProfesseurs.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfesseurs.Location = New System.Drawing.Point(468, 263)
        Me.lblProfesseurs.Name = "lblProfesseurs"
        Me.lblProfesseurs.Size = New System.Drawing.Size(176, 67)
        Me.lblProfesseurs.TabIndex = 33
        Me.lblProfesseurs.Text = "Nombre de professeurs requis :"
        Me.lblProfesseurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNbProf
        '
        Me.lblNbProf.BackColor = System.Drawing.Color.LightBlue
        Me.lblNbProf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNbProf.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbProf.Location = New System.Drawing.Point(528, 338)
        Me.lblNbProf.Name = "lblNbProf"
        Me.lblNbProf.Size = New System.Drawing.Size(56, 50)
        Me.lblNbProf.TabIndex = 36
        Me.lblNbProf.Text = "0"
        Me.lblNbProf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdApropos
        '
        Me.cmdApropos.Location = New System.Drawing.Point(487, 473)
        Me.cmdApropos.Name = "cmdApropos"
        Me.cmdApropos.Size = New System.Drawing.Size(139, 44)
        Me.cmdApropos.TabIndex = 37
        Me.cmdApropos.Text = "À propos"
        Me.cmdApropos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.cmdAnnuler
        Me.ClientSize = New System.Drawing.Size(1297, 545)
        Me.Controls.Add(Me.cmdApropos)
        Me.Controls.Add(Me.lblNbProf)
        Me.Controls.Add(Me.lblProfesseurs)
        Me.Controls.Add(Me.lblMoyGenCalc)
        Me.Controls.Add(Me.lblMoyGenerale)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.grpNav)
        Me.Controls.Add(Me.grpRecherche)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdSupprimer)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.grpInfoEtu)
        Me.Controls.Add(Me.cmdAjouter)
        Me.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Gestion des étudiants"
        CType(Me.numNbCoursR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMoyenne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfoEtu.ResumeLayout(False)
        Me.grpInfoEtu.PerformLayout()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRecherche.ResumeLayout(False)
        Me.grpRecherche.PerformLayout()
        Me.grpFiltres.ResumeLayout(False)
        Me.grpNav.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdAjouter As Button
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents cbSexe As ComboBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents numNbCoursR As NumericUpDown
    Friend WithEvents numMoyenne As NumericUpDown
    Friend WithEvents txtDA As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblSexe As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents lblNbCoursReussi As Label
    Friend WithEvents lblMoyenne As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmdPremier As Button
    Friend WithEvents cmdPrecedent As Button
    Friend WithEvents cmdSuivant As Button
    Friend WithEvents cmdDernier As Button
    Friend WithEvents lblMode As Label
    Friend WithEvents grpInfoEtu As GroupBox
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdSupprimer As Button
    Friend WithEvents Err1 As ErrorProvider
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdOK As Button
    Private WithEvents grpRecherche As GroupBox
    Private WithEvents lvListeEtu As ListView
    Private WithEvents lblQteResultat As Label
    Private WithEvents lblNbrResultats As Label
    Private WithEvents grpFiltres As GroupBox
    Private WithEvents txtRecherche As TextBox
    Friend WithEvents grpNav As GroupBox
    Friend WithEvents cmdQuitter As Button
    Friend WithEvents lblTitreRecherche As Label
    Friend WithEvents lblMoyGenerale As Label
    Friend WithEvents lblMoyGenCalc As Label
    Friend WithEvents cbFiltre As ComboBox
    Friend WithEvents lblProfesseurs As Label
    Friend WithEvents lblNbProf As Label
    Friend WithEvents lblDA As Label
    Friend WithEvents cmdApropos As Button
End Class
