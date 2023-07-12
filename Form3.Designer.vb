<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guesser
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnGuess = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        labCarJouables = New Label()
        labCar = New Label()
        labAbs = New Label()
        labPres = New Label()
        labPresBien = New Label()
        panPredEssais = New Panel()
        panPred15 = New Panel()
        Label75 = New Label()
        Label76 = New Label()
        Label77 = New Label()
        Label78 = New Label()
        Label79 = New Label()
        panPred14 = New Panel()
        Label70 = New Label()
        Label71 = New Label()
        Label72 = New Label()
        Label73 = New Label()
        Label74 = New Label()
        panPred13 = New Panel()
        Label65 = New Label()
        Label66 = New Label()
        Label67 = New Label()
        Label68 = New Label()
        Label69 = New Label()
        panPred12 = New Panel()
        Label60 = New Label()
        Label61 = New Label()
        Label62 = New Label()
        Label63 = New Label()
        Label64 = New Label()
        panPred11 = New Panel()
        Label55 = New Label()
        Label56 = New Label()
        Label57 = New Label()
        Label58 = New Label()
        Label59 = New Label()
        panPred10 = New Panel()
        Label50 = New Label()
        Label51 = New Label()
        Label52 = New Label()
        Label53 = New Label()
        Label54 = New Label()
        panPred9 = New Panel()
        Label45 = New Label()
        Label46 = New Label()
        Label47 = New Label()
        Label48 = New Label()
        Label49 = New Label()
        panPred8 = New Panel()
        Label40 = New Label()
        Label41 = New Label()
        Label42 = New Label()
        Label43 = New Label()
        Label44 = New Label()
        panPred7 = New Panel()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        panPred6 = New Panel()
        Label30 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Label33 = New Label()
        Label34 = New Label()
        panPred5 = New Panel()
        Label25 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        panPred4 = New Panel()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        panPred3 = New Panel()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        panPred2 = New Panel()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        panPred1 = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        panCombiDeviner = New Panel()
        txt1 = New TextBox()
        txt2 = New TextBox()
        txt3 = New TextBox()
        txt4 = New TextBox()
        txt5 = New TextBox()
        labtrouve = New Label()
        labTempsRst = New Label()
        Timer1 = New Timer(components)
        labCoupRst = New Label()
        btnPartieSuiv = New Button()
        labTemps = New Label()
        labCoup = New Label()
        labDmg = New Label()
        panPredEssais.SuspendLayout()
        panPred15.SuspendLayout()
        panPred14.SuspendLayout()
        panPred13.SuspendLayout()
        panPred12.SuspendLayout()
        panPred11.SuspendLayout()
        panPred10.SuspendLayout()
        panPred9.SuspendLayout()
        panPred8.SuspendLayout()
        panPred7.SuspendLayout()
        panPred6.SuspendLayout()
        panPred5.SuspendLayout()
        panPred4.SuspendLayout()
        panPred3.SuspendLayout()
        panPred2.SuspendLayout()
        panPred1.SuspendLayout()
        panCombiDeviner.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnGuess
        ' 
        btnGuess.Location = New Point(520, 57)
        btnGuess.Name = "btnGuess"
        btnGuess.Size = New Size(76, 23)
        btnGuess.TabIndex = 0
        btnGuess.Text = "Guess"
        btnGuess.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(214, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 30)
        Label1.TabIndex = 1
        Label1.Text = "Master Mind"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(352, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(102, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 20)
        Label3.TabIndex = 8
        Label3.Text = "Precedents essaies"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(324, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 9
        Label4.Text = "Code couleur"
        ' 
        ' labCarJouables
        ' 
        labCarJouables.AutoSize = True
        labCarJouables.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        labCarJouables.Location = New Point(324, 198)
        labCarJouables.Name = "labCarJouables"
        labCarJouables.Size = New Size(144, 20)
        labCarJouables.TabIndex = 10
        labCarJouables.Text = "Caractères jouables"
        ' 
        ' labCar
        ' 
        labCar.AutoSize = True
        labCar.Location = New Point(341, 216)
        labCar.Name = "labCar"
        labCar.Size = New Size(47, 15)
        labCar.TabIndex = 11
        labCar.Text = "#$£%@"
        ' 
        ' labAbs
        ' 
        labAbs.AutoSize = True
        labAbs.Location = New Point(341, 134)
        labAbs.Name = "labAbs"
        labAbs.Size = New Size(44, 15)
        labAbs.TabIndex = 12
        labAbs.Text = "Absent"
        ' 
        ' labPres
        ' 
        labPres.AutoSize = True
        labPres.ForeColor = Color.RoyalBlue
        labPres.Location = New Point(341, 149)
        labPres.Name = "labPres"
        labPres.Size = New Size(46, 15)
        labPres.TabIndex = 13
        labPres.Text = "Présent"
        ' 
        ' labPresBien
        ' 
        labPresBien.AutoSize = True
        labPresBien.ForeColor = Color.ForestGreen
        labPresBien.Location = New Point(341, 164)
        labPresBien.Name = "labPresBien"
        labPresBien.Size = New Size(116, 15)
        labPresBien.TabIndex = 14
        labPresBien.Text = "Présent et bien placé"
        ' 
        ' panPredEssais
        ' 
        panPredEssais.Controls.Add(panPred15)
        panPredEssais.Controls.Add(panPred14)
        panPredEssais.Controls.Add(panPred13)
        panPredEssais.Controls.Add(panPred12)
        panPredEssais.Controls.Add(panPred11)
        panPredEssais.Controls.Add(panPred10)
        panPredEssais.Controls.Add(panPred9)
        panPredEssais.Controls.Add(panPred8)
        panPredEssais.Controls.Add(panPred7)
        panPredEssais.Controls.Add(panPred6)
        panPredEssais.Controls.Add(panPred5)
        panPredEssais.Controls.Add(panPred4)
        panPredEssais.Controls.Add(panPred3)
        panPredEssais.Controls.Add(panPred2)
        panPredEssais.Controls.Add(panPred1)
        panPredEssais.Location = New Point(68, 130)
        panPredEssais.Margin = New Padding(2)
        panPredEssais.Name = "panPredEssais"
        panPredEssais.Size = New Size(208, 310)
        panPredEssais.TabIndex = 15
        ' 
        ' panPred15
        ' 
        panPred15.Controls.Add(Label75)
        panPred15.Controls.Add(Label76)
        panPred15.Controls.Add(Label77)
        panPred15.Controls.Add(Label78)
        panPred15.Controls.Add(Label79)
        panPred15.Location = New Point(14, 283)
        panPred15.Margin = New Padding(2)
        panPred15.Name = "panPred15"
        panPred15.Size = New Size(177, 16)
        panPred15.TabIndex = 27
        ' 
        ' Label75
        ' 
        Label75.AutoSize = True
        Label75.Location = New Point(158, 1)
        Label75.Margin = New Padding(2, 0, 2, 0)
        Label75.Name = "Label75"
        Label75.Size = New Size(15, 15)
        Label75.TabIndex = 25
        Label75.Text = "A"
        ' 
        ' Label76
        ' 
        Label76.AutoSize = True
        Label76.Location = New Point(120, 1)
        Label76.Margin = New Padding(2, 0, 2, 0)
        Label76.Name = "Label76"
        Label76.Size = New Size(15, 15)
        Label76.TabIndex = 24
        Label76.Text = "A"
        ' 
        ' Label77
        ' 
        Label77.AutoSize = True
        Label77.Location = New Point(78, 1)
        Label77.Margin = New Padding(2, 0, 2, 0)
        Label77.Name = "Label77"
        Label77.Size = New Size(15, 15)
        Label77.TabIndex = 23
        Label77.Text = "A"
        ' 
        ' Label78
        ' 
        Label78.AutoSize = True
        Label78.Location = New Point(39, 1)
        Label78.Margin = New Padding(2, 0, 2, 0)
        Label78.Name = "Label78"
        Label78.Size = New Size(15, 15)
        Label78.TabIndex = 22
        Label78.Text = "A"
        ' 
        ' Label79
        ' 
        Label79.AutoSize = True
        Label79.Location = New Point(2, 1)
        Label79.Margin = New Padding(2, 0, 2, 0)
        Label79.Name = "Label79"
        Label79.Size = New Size(15, 15)
        Label79.TabIndex = 21
        Label79.Text = "A"
        ' 
        ' panPred14
        ' 
        panPred14.Controls.Add(Label70)
        panPred14.Controls.Add(Label71)
        panPred14.Controls.Add(Label72)
        panPred14.Controls.Add(Label73)
        panPred14.Controls.Add(Label74)
        panPred14.Location = New Point(14, 263)
        panPred14.Margin = New Padding(2)
        panPred14.Name = "panPred14"
        panPred14.Size = New Size(177, 16)
        panPred14.TabIndex = 27
        ' 
        ' Label70
        ' 
        Label70.AutoSize = True
        Label70.Location = New Point(158, 1)
        Label70.Margin = New Padding(2, 0, 2, 0)
        Label70.Name = "Label70"
        Label70.Size = New Size(15, 15)
        Label70.TabIndex = 25
        Label70.Text = "A"
        ' 
        ' Label71
        ' 
        Label71.AutoSize = True
        Label71.Location = New Point(120, 1)
        Label71.Margin = New Padding(2, 0, 2, 0)
        Label71.Name = "Label71"
        Label71.Size = New Size(15, 15)
        Label71.TabIndex = 24
        Label71.Text = "A"
        ' 
        ' Label72
        ' 
        Label72.AutoSize = True
        Label72.Location = New Point(78, 1)
        Label72.Margin = New Padding(2, 0, 2, 0)
        Label72.Name = "Label72"
        Label72.Size = New Size(15, 15)
        Label72.TabIndex = 23
        Label72.Text = "A"
        ' 
        ' Label73
        ' 
        Label73.AutoSize = True
        Label73.Location = New Point(39, 1)
        Label73.Margin = New Padding(2, 0, 2, 0)
        Label73.Name = "Label73"
        Label73.Size = New Size(15, 15)
        Label73.TabIndex = 22
        Label73.Text = "A"
        ' 
        ' Label74
        ' 
        Label74.AutoSize = True
        Label74.Location = New Point(2, 1)
        Label74.Margin = New Padding(2, 0, 2, 0)
        Label74.Name = "Label74"
        Label74.Size = New Size(15, 15)
        Label74.TabIndex = 21
        Label74.Text = "A"
        ' 
        ' panPred13
        ' 
        panPred13.Controls.Add(Label65)
        panPred13.Controls.Add(Label66)
        panPred13.Controls.Add(Label67)
        panPred13.Controls.Add(Label68)
        panPred13.Controls.Add(Label69)
        panPred13.Location = New Point(14, 244)
        panPred13.Margin = New Padding(2)
        panPred13.Name = "panPred13"
        panPred13.Size = New Size(177, 16)
        panPred13.TabIndex = 27
        ' 
        ' Label65
        ' 
        Label65.AutoSize = True
        Label65.Location = New Point(158, 1)
        Label65.Margin = New Padding(2, 0, 2, 0)
        Label65.Name = "Label65"
        Label65.Size = New Size(15, 15)
        Label65.TabIndex = 25
        Label65.Text = "A"
        ' 
        ' Label66
        ' 
        Label66.AutoSize = True
        Label66.Location = New Point(120, 1)
        Label66.Margin = New Padding(2, 0, 2, 0)
        Label66.Name = "Label66"
        Label66.Size = New Size(15, 15)
        Label66.TabIndex = 24
        Label66.Text = "A"
        ' 
        ' Label67
        ' 
        Label67.AutoSize = True
        Label67.Location = New Point(78, 1)
        Label67.Margin = New Padding(2, 0, 2, 0)
        Label67.Name = "Label67"
        Label67.Size = New Size(15, 15)
        Label67.TabIndex = 23
        Label67.Text = "A"
        ' 
        ' Label68
        ' 
        Label68.AutoSize = True
        Label68.Location = New Point(39, 1)
        Label68.Margin = New Padding(2, 0, 2, 0)
        Label68.Name = "Label68"
        Label68.Size = New Size(15, 15)
        Label68.TabIndex = 22
        Label68.Text = "A"
        ' 
        ' Label69
        ' 
        Label69.AutoSize = True
        Label69.Location = New Point(2, 1)
        Label69.Margin = New Padding(2, 0, 2, 0)
        Label69.Name = "Label69"
        Label69.Size = New Size(15, 15)
        Label69.TabIndex = 21
        Label69.Text = "A"
        ' 
        ' panPred12
        ' 
        panPred12.Controls.Add(Label60)
        panPred12.Controls.Add(Label61)
        panPred12.Controls.Add(Label62)
        panPred12.Controls.Add(Label63)
        panPred12.Controls.Add(Label64)
        panPred12.Location = New Point(14, 225)
        panPred12.Margin = New Padding(2)
        panPred12.Name = "panPred12"
        panPred12.Size = New Size(177, 16)
        panPred12.TabIndex = 27
        ' 
        ' Label60
        ' 
        Label60.AutoSize = True
        Label60.Location = New Point(158, 1)
        Label60.Margin = New Padding(2, 0, 2, 0)
        Label60.Name = "Label60"
        Label60.Size = New Size(15, 15)
        Label60.TabIndex = 25
        Label60.Text = "A"
        ' 
        ' Label61
        ' 
        Label61.AutoSize = True
        Label61.Location = New Point(120, 1)
        Label61.Margin = New Padding(2, 0, 2, 0)
        Label61.Name = "Label61"
        Label61.Size = New Size(15, 15)
        Label61.TabIndex = 24
        Label61.Text = "A"
        ' 
        ' Label62
        ' 
        Label62.AutoSize = True
        Label62.Location = New Point(78, 1)
        Label62.Margin = New Padding(2, 0, 2, 0)
        Label62.Name = "Label62"
        Label62.Size = New Size(15, 15)
        Label62.TabIndex = 23
        Label62.Text = "A"
        ' 
        ' Label63
        ' 
        Label63.AutoSize = True
        Label63.Location = New Point(39, 1)
        Label63.Margin = New Padding(2, 0, 2, 0)
        Label63.Name = "Label63"
        Label63.Size = New Size(15, 15)
        Label63.TabIndex = 22
        Label63.Text = "A"
        ' 
        ' Label64
        ' 
        Label64.AutoSize = True
        Label64.Location = New Point(2, 1)
        Label64.Margin = New Padding(2, 0, 2, 0)
        Label64.Name = "Label64"
        Label64.Size = New Size(15, 15)
        Label64.TabIndex = 21
        Label64.Text = "A"
        ' 
        ' panPred11
        ' 
        panPred11.Controls.Add(Label55)
        panPred11.Controls.Add(Label56)
        panPred11.Controls.Add(Label57)
        panPred11.Controls.Add(Label58)
        panPred11.Controls.Add(Label59)
        panPred11.Location = New Point(14, 206)
        panPred11.Margin = New Padding(2)
        panPred11.Name = "panPred11"
        panPred11.Size = New Size(177, 16)
        panPred11.TabIndex = 27
        ' 
        ' Label55
        ' 
        Label55.AutoSize = True
        Label55.Location = New Point(158, 1)
        Label55.Margin = New Padding(2, 0, 2, 0)
        Label55.Name = "Label55"
        Label55.Size = New Size(15, 15)
        Label55.TabIndex = 25
        Label55.Text = "A"
        ' 
        ' Label56
        ' 
        Label56.AutoSize = True
        Label56.Location = New Point(120, 1)
        Label56.Margin = New Padding(2, 0, 2, 0)
        Label56.Name = "Label56"
        Label56.Size = New Size(15, 15)
        Label56.TabIndex = 24
        Label56.Text = "A"
        ' 
        ' Label57
        ' 
        Label57.AutoSize = True
        Label57.Location = New Point(78, 1)
        Label57.Margin = New Padding(2, 0, 2, 0)
        Label57.Name = "Label57"
        Label57.Size = New Size(15, 15)
        Label57.TabIndex = 23
        Label57.Text = "A"
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Location = New Point(39, 1)
        Label58.Margin = New Padding(2, 0, 2, 0)
        Label58.Name = "Label58"
        Label58.Size = New Size(15, 15)
        Label58.TabIndex = 22
        Label58.Text = "A"
        ' 
        ' Label59
        ' 
        Label59.AutoSize = True
        Label59.Location = New Point(2, 1)
        Label59.Margin = New Padding(2, 0, 2, 0)
        Label59.Name = "Label59"
        Label59.Size = New Size(15, 15)
        Label59.TabIndex = 21
        Label59.Text = "A"
        ' 
        ' panPred10
        ' 
        panPred10.Controls.Add(Label50)
        panPred10.Controls.Add(Label51)
        panPred10.Controls.Add(Label52)
        panPred10.Controls.Add(Label53)
        panPred10.Controls.Add(Label54)
        panPred10.Location = New Point(14, 187)
        panPred10.Margin = New Padding(2)
        panPred10.Name = "panPred10"
        panPred10.Size = New Size(177, 16)
        panPred10.TabIndex = 27
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Location = New Point(158, 1)
        Label50.Margin = New Padding(2, 0, 2, 0)
        Label50.Name = "Label50"
        Label50.Size = New Size(15, 15)
        Label50.TabIndex = 25
        Label50.Text = "A"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Location = New Point(120, 1)
        Label51.Margin = New Padding(2, 0, 2, 0)
        Label51.Name = "Label51"
        Label51.Size = New Size(15, 15)
        Label51.TabIndex = 24
        Label51.Text = "A"
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Location = New Point(78, 1)
        Label52.Margin = New Padding(2, 0, 2, 0)
        Label52.Name = "Label52"
        Label52.Size = New Size(15, 15)
        Label52.TabIndex = 23
        Label52.Text = "A"
        ' 
        ' Label53
        ' 
        Label53.AutoSize = True
        Label53.Location = New Point(39, 1)
        Label53.Margin = New Padding(2, 0, 2, 0)
        Label53.Name = "Label53"
        Label53.Size = New Size(15, 15)
        Label53.TabIndex = 22
        Label53.Text = "A"
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Location = New Point(2, 1)
        Label54.Margin = New Padding(2, 0, 2, 0)
        Label54.Name = "Label54"
        Label54.Size = New Size(15, 15)
        Label54.TabIndex = 21
        Label54.Text = "A"
        ' 
        ' panPred9
        ' 
        panPred9.Controls.Add(Label45)
        panPred9.Controls.Add(Label46)
        panPred9.Controls.Add(Label47)
        panPred9.Controls.Add(Label48)
        panPred9.Controls.Add(Label49)
        panPred9.Location = New Point(14, 167)
        panPred9.Margin = New Padding(2)
        panPred9.Name = "panPred9"
        panPred9.Size = New Size(177, 16)
        panPred9.TabIndex = 27
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Location = New Point(158, 1)
        Label45.Margin = New Padding(2, 0, 2, 0)
        Label45.Name = "Label45"
        Label45.Size = New Size(15, 15)
        Label45.TabIndex = 25
        Label45.Text = "A"
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Location = New Point(120, 1)
        Label46.Margin = New Padding(2, 0, 2, 0)
        Label46.Name = "Label46"
        Label46.Size = New Size(15, 15)
        Label46.TabIndex = 24
        Label46.Text = "A"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Location = New Point(78, 1)
        Label47.Margin = New Padding(2, 0, 2, 0)
        Label47.Name = "Label47"
        Label47.Size = New Size(15, 15)
        Label47.TabIndex = 23
        Label47.Text = "A"
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Location = New Point(39, 1)
        Label48.Margin = New Padding(2, 0, 2, 0)
        Label48.Name = "Label48"
        Label48.Size = New Size(15, 15)
        Label48.TabIndex = 22
        Label48.Text = "A"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Location = New Point(2, 1)
        Label49.Margin = New Padding(2, 0, 2, 0)
        Label49.Name = "Label49"
        Label49.Size = New Size(15, 15)
        Label49.TabIndex = 21
        Label49.Text = "A"
        ' 
        ' panPred8
        ' 
        panPred8.Controls.Add(Label40)
        panPred8.Controls.Add(Label41)
        panPred8.Controls.Add(Label42)
        panPred8.Controls.Add(Label43)
        panPred8.Controls.Add(Label44)
        panPred8.Location = New Point(14, 148)
        panPred8.Margin = New Padding(2)
        panPred8.Name = "panPred8"
        panPred8.Size = New Size(177, 16)
        panPred8.TabIndex = 27
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Location = New Point(158, 1)
        Label40.Margin = New Padding(2, 0, 2, 0)
        Label40.Name = "Label40"
        Label40.Size = New Size(15, 15)
        Label40.TabIndex = 25
        Label40.Text = "A"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Location = New Point(120, 1)
        Label41.Margin = New Padding(2, 0, 2, 0)
        Label41.Name = "Label41"
        Label41.Size = New Size(15, 15)
        Label41.TabIndex = 24
        Label41.Text = "A"
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Location = New Point(78, 1)
        Label42.Margin = New Padding(2, 0, 2, 0)
        Label42.Name = "Label42"
        Label42.Size = New Size(15, 15)
        Label42.TabIndex = 23
        Label42.Text = "A"
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Location = New Point(39, 1)
        Label43.Margin = New Padding(2, 0, 2, 0)
        Label43.Name = "Label43"
        Label43.Size = New Size(15, 15)
        Label43.TabIndex = 22
        Label43.Text = "A"
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Location = New Point(2, 1)
        Label44.Margin = New Padding(2, 0, 2, 0)
        Label44.Name = "Label44"
        Label44.Size = New Size(15, 15)
        Label44.TabIndex = 21
        Label44.Text = "A"
        ' 
        ' panPred7
        ' 
        panPred7.Controls.Add(Label35)
        panPred7.Controls.Add(Label36)
        panPred7.Controls.Add(Label37)
        panPred7.Controls.Add(Label38)
        panPred7.Controls.Add(Label39)
        panPred7.Location = New Point(14, 129)
        panPred7.Margin = New Padding(2)
        panPred7.Name = "panPred7"
        panPred7.Size = New Size(177, 16)
        panPred7.TabIndex = 27
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Location = New Point(158, 1)
        Label35.Margin = New Padding(2, 0, 2, 0)
        Label35.Name = "Label35"
        Label35.Size = New Size(15, 15)
        Label35.TabIndex = 25
        Label35.Text = "A"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(120, 1)
        Label36.Margin = New Padding(2, 0, 2, 0)
        Label36.Name = "Label36"
        Label36.Size = New Size(15, 15)
        Label36.TabIndex = 24
        Label36.Text = "A"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(78, 1)
        Label37.Margin = New Padding(2, 0, 2, 0)
        Label37.Name = "Label37"
        Label37.Size = New Size(15, 15)
        Label37.TabIndex = 23
        Label37.Text = "A"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Location = New Point(39, 1)
        Label38.Margin = New Padding(2, 0, 2, 0)
        Label38.Name = "Label38"
        Label38.Size = New Size(15, 15)
        Label38.TabIndex = 22
        Label38.Text = "A"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Location = New Point(2, 1)
        Label39.Margin = New Padding(2, 0, 2, 0)
        Label39.Name = "Label39"
        Label39.Size = New Size(15, 15)
        Label39.TabIndex = 21
        Label39.Text = "A"
        ' 
        ' panPred6
        ' 
        panPred6.Controls.Add(Label30)
        panPred6.Controls.Add(Label31)
        panPred6.Controls.Add(Label32)
        panPred6.Controls.Add(Label33)
        panPred6.Controls.Add(Label34)
        panPred6.Location = New Point(14, 110)
        panPred6.Margin = New Padding(2)
        panPred6.Name = "panPred6"
        panPred6.Size = New Size(177, 16)
        panPred6.TabIndex = 27
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Location = New Point(158, 1)
        Label30.Margin = New Padding(2, 0, 2, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(15, 15)
        Label30.TabIndex = 25
        Label30.Text = "A"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(120, 1)
        Label31.Margin = New Padding(2, 0, 2, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(15, 15)
        Label31.TabIndex = 24
        Label31.Text = "A"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(78, 1)
        Label32.Margin = New Padding(2, 0, 2, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(15, 15)
        Label32.TabIndex = 23
        Label32.Text = "A"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(39, 1)
        Label33.Margin = New Padding(2, 0, 2, 0)
        Label33.Name = "Label33"
        Label33.Size = New Size(15, 15)
        Label33.TabIndex = 22
        Label33.Text = "A"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(2, 1)
        Label34.Margin = New Padding(2, 0, 2, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(15, 15)
        Label34.TabIndex = 21
        Label34.Text = "A"
        ' 
        ' panPred5
        ' 
        panPred5.Controls.Add(Label25)
        panPred5.Controls.Add(Label26)
        panPred5.Controls.Add(Label27)
        panPred5.Controls.Add(Label28)
        panPred5.Controls.Add(Label29)
        panPred5.Location = New Point(14, 91)
        panPred5.Margin = New Padding(2)
        panPred5.Name = "panPred5"
        panPred5.Size = New Size(177, 16)
        panPred5.TabIndex = 27
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(158, 1)
        Label25.Margin = New Padding(2, 0, 2, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(15, 15)
        Label25.TabIndex = 25
        Label25.Text = "A"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(120, 1)
        Label26.Margin = New Padding(2, 0, 2, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(15, 15)
        Label26.TabIndex = 24
        Label26.Text = "A"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(78, 1)
        Label27.Margin = New Padding(2, 0, 2, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(15, 15)
        Label27.TabIndex = 23
        Label27.Text = "A"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(39, 1)
        Label28.Margin = New Padding(2, 0, 2, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(15, 15)
        Label28.TabIndex = 22
        Label28.Text = "A"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(2, 1)
        Label29.Margin = New Padding(2, 0, 2, 0)
        Label29.Name = "Label29"
        Label29.Size = New Size(15, 15)
        Label29.TabIndex = 21
        Label29.Text = "A"
        ' 
        ' panPred4
        ' 
        panPred4.Controls.Add(Label20)
        panPred4.Controls.Add(Label21)
        panPred4.Controls.Add(Label22)
        panPred4.Controls.Add(Label23)
        panPred4.Controls.Add(Label24)
        panPred4.Location = New Point(14, 71)
        panPred4.Margin = New Padding(2)
        panPred4.Name = "panPred4"
        panPred4.Size = New Size(177, 16)
        panPred4.TabIndex = 27
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(158, 1)
        Label20.Margin = New Padding(2, 0, 2, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(15, 15)
        Label20.TabIndex = 25
        Label20.Text = "A"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(120, 1)
        Label21.Margin = New Padding(2, 0, 2, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(15, 15)
        Label21.TabIndex = 24
        Label21.Text = "A"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(78, 1)
        Label22.Margin = New Padding(2, 0, 2, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(15, 15)
        Label22.TabIndex = 23
        Label22.Text = "A"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(39, 1)
        Label23.Margin = New Padding(2, 0, 2, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(15, 15)
        Label23.TabIndex = 22
        Label23.Text = "A"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(2, 1)
        Label24.Margin = New Padding(2, 0, 2, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(15, 15)
        Label24.TabIndex = 21
        Label24.Text = "A"
        ' 
        ' panPred3
        ' 
        panPred3.Controls.Add(Label15)
        panPred3.Controls.Add(Label16)
        panPred3.Controls.Add(Label17)
        panPred3.Controls.Add(Label18)
        panPred3.Controls.Add(Label19)
        panPred3.Location = New Point(14, 52)
        panPred3.Margin = New Padding(2)
        panPred3.Name = "panPred3"
        panPred3.Size = New Size(177, 16)
        panPred3.TabIndex = 26
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(158, 1)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(15, 15)
        Label15.TabIndex = 25
        Label15.Text = "A"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(120, 1)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(15, 15)
        Label16.TabIndex = 24
        Label16.Text = "A"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(78, 1)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(15, 15)
        Label17.TabIndex = 23
        Label17.Text = "A"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(39, 1)
        Label18.Margin = New Padding(2, 0, 2, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(15, 15)
        Label18.TabIndex = 22
        Label18.Text = "A"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(2, 1)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(15, 15)
        Label19.TabIndex = 21
        Label19.Text = "A"
        ' 
        ' panPred2
        ' 
        panPred2.Controls.Add(Label10)
        panPred2.Controls.Add(Label11)
        panPred2.Controls.Add(Label12)
        panPred2.Controls.Add(Label13)
        panPred2.Controls.Add(Label14)
        panPred2.Location = New Point(14, 33)
        panPred2.Margin = New Padding(2)
        panPred2.Name = "panPred2"
        panPred2.Size = New Size(177, 16)
        panPred2.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(158, 1)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(15, 15)
        Label10.TabIndex = 25
        Label10.Text = "A"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(120, 1)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(15, 15)
        Label11.TabIndex = 24
        Label11.Text = "A"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(78, 1)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(15, 15)
        Label12.TabIndex = 23
        Label12.Text = "A"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(39, 0)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(15, 15)
        Label13.TabIndex = 22
        Label13.Text = "A"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(2, 1)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(15, 15)
        Label14.TabIndex = 21
        Label14.Text = "A"
        ' 
        ' panPred1
        ' 
        panPred1.Controls.Add(Label9)
        panPred1.Controls.Add(Label8)
        panPred1.Controls.Add(Label7)
        panPred1.Controls.Add(Label6)
        panPred1.Controls.Add(Label5)
        panPred1.Location = New Point(14, 14)
        panPred1.Margin = New Padding(2)
        panPred1.Name = "panPred1"
        panPred1.Size = New Size(177, 16)
        panPred1.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(158, 1)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(15, 15)
        Label9.TabIndex = 3
        Label9.Text = "A"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(120, 1)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(15, 15)
        Label8.TabIndex = 2
        Label8.Text = "A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(78, 1)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(15, 15)
        Label7.TabIndex = 5
        Label7.Text = "A"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(39, 1)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(15, 15)
        Label6.TabIndex = 4
        Label6.Text = "A"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(2, 1)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(15, 15)
        Label5.TabIndex = 1
        Label5.Text = "A"
        ' 
        ' panCombiDeviner
        ' 
        panCombiDeviner.Controls.Add(txt1)
        panCombiDeviner.Controls.Add(txt2)
        panCombiDeviner.Controls.Add(txt3)
        panCombiDeviner.Controls.Add(txt4)
        panCombiDeviner.Controls.Add(txt5)
        panCombiDeviner.Location = New Point(35, 43)
        panCombiDeviner.Margin = New Padding(2)
        panCombiDeviner.Name = "panCombiDeviner"
        panCombiDeviner.Size = New Size(456, 46)
        panCombiDeviner.TabIndex = 16
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(361, 14)
        txt1.Margin = New Padding(2)
        txt1.MaxLength = 1
        txt1.Name = "txt1"
        txt1.Size = New Size(78, 23)
        txt1.TabIndex = 4
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(279, 14)
        txt2.Margin = New Padding(2)
        txt2.MaxLength = 1
        txt2.Name = "txt2"
        txt2.Size = New Size(78, 23)
        txt2.TabIndex = 3
        ' 
        ' txt3
        ' 
        txt3.Location = New Point(196, 14)
        txt3.Margin = New Padding(2)
        txt3.MaxLength = 1
        txt3.Name = "txt3"
        txt3.Size = New Size(78, 23)
        txt3.TabIndex = 2
        ' 
        ' txt4
        ' 
        txt4.Location = New Point(114, 14)
        txt4.Margin = New Padding(2)
        txt4.MaxLength = 1
        txt4.Name = "txt4"
        txt4.Size = New Size(78, 23)
        txt4.TabIndex = 1
        ' 
        ' txt5
        ' 
        txt5.Location = New Point(32, 13)
        txt5.Margin = New Padding(2)
        txt5.MaxLength = 1
        txt5.Name = "txt5"
        txt5.Size = New Size(78, 23)
        txt5.TabIndex = 0
        ' 
        ' labtrouve
        ' 
        labtrouve.AutoSize = True
        labtrouve.Font = New Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        labtrouve.Location = New Point(336, 344)
        labtrouve.Margin = New Padding(2, 0, 2, 0)
        labtrouve.Name = "labtrouve"
        labtrouve.Size = New Size(103, 28)
        labtrouve.TabIndex = 17
        labtrouve.Text = "Trouvé !"
        labtrouve.Visible = False
        ' 
        ' labTempsRst
        ' 
        labTempsRst.AutoSize = True
        labTempsRst.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        labTempsRst.Location = New Point(324, 252)
        labTempsRst.Name = "labTempsRst"
        labTempsRst.Size = New Size(128, 20)
        labTempsRst.TabIndex = 18
        labTempsRst.Text = "Temps restants : "
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' labCoupRst
        ' 
        labCoupRst.AutoSize = True
        labCoupRst.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        labCoupRst.Location = New Point(324, 296)
        labCoupRst.Name = "labCoupRst"
        labCoupRst.Size = New Size(125, 20)
        labCoupRst.TabIndex = 19
        labCoupRst.Text = "Coups restants : "
        ' 
        ' btnPartieSuiv
        ' 
        btnPartieSuiv.Location = New Point(480, 406)
        btnPartieSuiv.Margin = New Padding(2)
        btnPartieSuiv.Name = "btnPartieSuiv"
        btnPartieSuiv.Size = New Size(116, 30)
        btnPartieSuiv.TabIndex = 20
        btnPartieSuiv.Text = "Partie Suivante"
        btnPartieSuiv.UseVisualStyleBackColor = True
        btnPartieSuiv.Visible = False
        ' 
        ' labTemps
        ' 
        labTemps.AutoSize = True
        labTemps.Location = New Point(450, 255)
        labTemps.Margin = New Padding(2, 0, 2, 0)
        labTemps.Name = "labTemps"
        labTemps.Size = New Size(57, 15)
        labTemps.TabIndex = 21
        labTemps.Text = "labTemps"
        ' 
        ' labCoup
        ' 
        labCoup.AutoSize = True
        labCoup.Location = New Point(450, 299)
        labCoup.Margin = New Padding(2, 0, 2, 0)
        labCoup.Name = "labCoup"
        labCoup.Size = New Size(55, 15)
        labCoup.TabIndex = 22
        labCoup.Text = "LabCoup"
        ' 
        ' labDmg
        ' 
        labDmg.AutoSize = True
        labDmg.Font = New Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        labDmg.Location = New Point(336, 339)
        labDmg.Margin = New Padding(2, 0, 2, 0)
        labDmg.Name = "labDmg"
        labDmg.Size = New Size(138, 37)
        labDmg.TabIndex = 23
        labDmg.Text = "Dommage !"
        labDmg.Visible = False
        ' 
        ' Guesser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 459)
        Controls.Add(labDmg)
        Controls.Add(labCoup)
        Controls.Add(labTemps)
        Controls.Add(btnPartieSuiv)
        Controls.Add(labCoupRst)
        Controls.Add(labTempsRst)
        Controls.Add(labtrouve)
        Controls.Add(panCombiDeviner)
        Controls.Add(panPredEssais)
        Controls.Add(labPresBien)
        Controls.Add(labPres)
        Controls.Add(labAbs)
        Controls.Add(labCar)
        Controls.Add(labCarJouables)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnGuess)
        MaximumSize = New Size(645, 498)
        MinimumSize = New Size(645, 498)
        Name = "Guesser"
        Text = "Guesser"
        panPredEssais.ResumeLayout(False)
        panPred15.ResumeLayout(False)
        panPred15.PerformLayout()
        panPred14.ResumeLayout(False)
        panPred14.PerformLayout()
        panPred13.ResumeLayout(False)
        panPred13.PerformLayout()
        panPred12.ResumeLayout(False)
        panPred12.PerformLayout()
        panPred11.ResumeLayout(False)
        panPred11.PerformLayout()
        panPred10.ResumeLayout(False)
        panPred10.PerformLayout()
        panPred9.ResumeLayout(False)
        panPred9.PerformLayout()
        panPred8.ResumeLayout(False)
        panPred8.PerformLayout()
        panPred7.ResumeLayout(False)
        panPred7.PerformLayout()
        panPred6.ResumeLayout(False)
        panPred6.PerformLayout()
        panPred5.ResumeLayout(False)
        panPred5.PerformLayout()
        panPred4.ResumeLayout(False)
        panPred4.PerformLayout()
        panPred3.ResumeLayout(False)
        panPred3.PerformLayout()
        panPred2.ResumeLayout(False)
        panPred2.PerformLayout()
        panPred1.ResumeLayout(False)
        panPred1.PerformLayout()
        panCombiDeviner.ResumeLayout(False)
        panCombiDeviner.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGuess As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents labCarJouables As Label
    Friend WithEvents labCar As Label
    Friend WithEvents labAbs As Label
    Friend WithEvents labPres As Label
    Friend WithEvents labPresBien As Label
    Friend WithEvents panPredEssais As Panel
    Friend WithEvents panCombiDeviner As Panel
    Friend WithEvents labtrouve As Label
    Friend WithEvents labTempsRst As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents labCoupRst As Label
    Friend WithEvents btnPartieSuiv As Button
    Friend WithEvents panPred1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents panPred3 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents panPred2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents panPred15 As Panel
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents panPred14 As Panel
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents panPred13 As Panel
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents panPred12 As Panel
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents panPred11 As Panel
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents panPred10 As Panel
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents panPred9 As Panel
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents panPred8 As Panel
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents panPred7 As Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents panPred6 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents panPred5 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents panPred4 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents labTemps As Label
    Friend WithEvents labCoup As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents labDmg As Label
End Class
