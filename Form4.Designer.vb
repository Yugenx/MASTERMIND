<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        txtChar = New TextBox()
        labCharUti = New Label()
        ColPres = New ColorDialog()
        Label1 = New Label()
        btnPres = New Button()
        Label2 = New Label()
        RbtnDesac = New RadioButton()
        RBtnAct = New RadioButton()
        lblLimTemps = New Label()
        txtTemps = New TextBox()
        Label3 = New Label()
        txtProp = New TextBox()
        btnEnr = New Button()
        btnAnnu = New Button()
        panLimTemps = New Panel()
        btnPresBien = New Button()
        ColPresBien = New ColorDialog()
        btnCAbs = New Button()
        ColAbsent = New ColorDialog()
        panLimTemps.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtChar
        ' 
        txtChar.Location = New Point(306, 20)
        txtChar.Margin = New Padding(2)
        txtChar.MaxLength = 10
        txtChar.Name = "txtChar"
        txtChar.Size = New Size(148, 23)
        txtChar.TabIndex = 0
        ' 
        ' labCharUti
        ' 
        labCharUti.AutoSize = True
        labCharUti.Location = New Point(27, 22)
        labCharUti.Margin = New Padding(2, 0, 2, 0)
        labCharUti.Name = "labCharUti"
        labCharUti.Size = New Size(180, 15)
        labCharUti.TabIndex = 1
        labCharUti.Text = "Modifier les caractères utilisables"
        ' 
        ' ColPres
        ' 
        ColPres.AllowFullOpen = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 64)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 15)
        Label1.TabIndex = 2
        Label1.Text = "Modifier les couleurs"
        ' 
        ' btnPres
        ' 
        btnPres.Location = New Point(204, 62)
        btnPres.Margin = New Padding(2)
        btnPres.Name = "btnPres"
        btnPres.Size = New Size(89, 20)
        btnPres.TabIndex = 3
        btnPres.Text = "Présent"
        btnPres.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 147)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 15)
        Label2.TabIndex = 4
        Label2.Text = "Activer ou désactiver la limite de temps"
        ' 
        ' RbtnDesac
        ' 
        RbtnDesac.AutoSize = True
        RbtnDesac.Location = New Point(8, 5)
        RbtnDesac.Margin = New Padding(2)
        RbtnDesac.Name = "RbtnDesac"
        RbtnDesac.Size = New Size(79, 19)
        RbtnDesac.TabIndex = 5
        RbtnDesac.TabStop = True
        RbtnDesac.Text = "Désactiver"
        RbtnDesac.UseVisualStyleBackColor = True
        ' 
        ' RBtnAct
        ' 
        RBtnAct.AutoSize = True
        RBtnAct.Location = New Point(116, 5)
        RBtnAct.Margin = New Padding(2)
        RBtnAct.Name = "RBtnAct"
        RBtnAct.Size = New Size(62, 19)
        RBtnAct.TabIndex = 6
        RBtnAct.TabStop = True
        RBtnAct.Text = "Activer"
        RBtnAct.UseVisualStyleBackColor = True
        ' 
        ' lblLimTemps
        ' 
        lblLimTemps.AutoSize = True
        lblLimTemps.Location = New Point(27, 184)
        lblLimTemps.Margin = New Padding(2, 0, 2, 0)
        lblLimTemps.Name = "lblLimTemps"
        lblLimTemps.Size = New Size(160, 15)
        lblLimTemps.TabIndex = 8
        lblLimTemps.Text = "Limite de temps en secondes"
        lblLimTemps.Visible = False
        ' 
        ' txtTemps
        ' 
        txtTemps.Location = New Point(306, 182)
        txtTemps.Margin = New Padding(2)
        txtTemps.MaxLength = 5
        txtTemps.Name = "txtTemps"
        txtTemps.Size = New Size(148, 23)
        txtTemps.TabIndex = 7
        txtTemps.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 105)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 15)
        Label3.TabIndex = 10
        Label3.Text = "Modifier la limite de propositions (max 15)"
        ' 
        ' txtProp
        ' 
        txtProp.Location = New Point(306, 103)
        txtProp.Margin = New Padding(2)
        txtProp.MaxLength = 2
        txtProp.Name = "txtProp"
        txtProp.Size = New Size(148, 23)
        txtProp.TabIndex = 9
        ' 
        ' btnEnr
        ' 
        btnEnr.BackColor = Color.LimeGreen
        btnEnr.Location = New Point(46, 211)
        btnEnr.Margin = New Padding(2)
        btnEnr.Name = "btnEnr"
        btnEnr.Size = New Size(194, 20)
        btnEnr.TabIndex = 13
        btnEnr.Text = "Enregistrer"
        btnEnr.UseVisualStyleBackColor = False
        ' 
        ' btnAnnu
        ' 
        btnAnnu.BackColor = Color.Red
        btnAnnu.Location = New Point(260, 211)
        btnAnnu.Margin = New Padding(2)
        btnAnnu.Name = "btnAnnu"
        btnAnnu.Size = New Size(194, 20)
        btnAnnu.TabIndex = 14
        btnAnnu.Text = "Retour"
        btnAnnu.UseVisualStyleBackColor = False
        ' 
        ' panLimTemps
        ' 
        panLimTemps.Controls.Add(RBtnAct)
        panLimTemps.Controls.Add(RbtnDesac)
        panLimTemps.Location = New Point(286, 142)
        panLimTemps.Margin = New Padding(2)
        panLimTemps.Name = "panLimTemps"
        panLimTemps.Size = New Size(192, 27)
        panLimTemps.TabIndex = 15
        ' 
        ' btnPresBien
        ' 
        btnPresBien.Location = New Point(306, 62)
        btnPresBien.Margin = New Padding(2)
        btnPresBien.Name = "btnPresBien"
        btnPresBien.Size = New Size(96, 20)
        btnPresBien.TabIndex = 16
        btnPresBien.Text = "Présent et Bien"
        btnPresBien.UseVisualStyleBackColor = True
        ' 
        ' btnCAbs
        ' 
        btnCAbs.Location = New Point(418, 62)
        btnCAbs.Margin = New Padding(2)
        btnCAbs.Name = "btnCAbs"
        btnCAbs.Size = New Size(89, 20)
        btnCAbs.TabIndex = 17
        btnCAbs.Text = "Absent"
        btnCAbs.UseVisualStyleBackColor = True
        ' 
        ' ColAbsent
        ' 
        ColAbsent.AllowFullOpen = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 243)
        Controls.Add(btnCAbs)
        Controls.Add(btnPresBien)
        Controls.Add(panLimTemps)
        Controls.Add(btnAnnu)
        Controls.Add(btnEnr)
        Controls.Add(Label3)
        Controls.Add(txtProp)
        Controls.Add(lblLimTemps)
        Controls.Add(txtTemps)
        Controls.Add(Label2)
        Controls.Add(btnPres)
        Controls.Add(Label1)
        Controls.Add(labCharUti)
        Controls.Add(txtChar)
        Margin = New Padding(2)
        MaximumSize = New Size(535, 282)
        MinimumSize = New Size(535, 282)
        Name = "Form4"
        Text = "Options"
        panLimTemps.ResumeLayout(False)
        panLimTemps.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtChar As TextBox
    Friend WithEvents labCharUti As Label
    Friend WithEvents ColPres As ColorDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPres As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RbtnDesac As RadioButton
    Friend WithEvents RBtnAct As RadioButton
    Friend WithEvents lblLimTemps As Label
    Friend WithEvents txtTemps As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProp As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnEnr As Button
    Friend WithEvents btnAnnu As Button
    Friend WithEvents panLimTemps As Panel
    Friend WithEvents btnPresBien As Button
    Friend WithEvents btnAbs As Button
    Friend WithEvents ColPresBien As ColorDialog
    Friend WithEvents btnCAbs As Button
    Friend WithEvents ColAbsent As ColorDialog
End Class
