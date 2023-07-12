Imports System.ComponentModel

Public Class Form4
    Dim BonneCouleur As Boolean = True


    Private CouleurPres As Color = Color.MidnightBlue
    Private CouleurPresBien As Color = Color.ForestGreen
    Private CouleurAbs As Color = Color.Gray

    Private CouleurPresT As Color
    Private CouleurPresBienT As Color
    Private CouleurAbsT As Color
    Private CouleurModif As Boolean = False

    Private CharAutorise As String = "#$£%@"
    Private PropositionMax As Integer = 15
    Private LimTemps As Integer = 90




    Public Function GetLimTemps()
        Return LimTemps
    End Function

    Public Function getCharAutorise()
        Return CharAutorise
    End Function

    Public Function getPropMax()
        Return PropositionMax
    End Function

    Public Function getCouleurPres()
        Return CouleurPres
    End Function

    Public Function getCouleurPresBien()
        Return CouleurPresBien
    End Function

    Public Function getCouleurAbs()
        Return CouleurAbs
    End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChar.Text = CharAutorise
        txtProp.Text = PropositionMax
        txtTemps.Text = LimTemps
        RBtnAct.Checked = True

    End Sub






    Private Sub Color_Click(sender As Object, e As EventArgs) Handles btnPres.Click, btnPresBien.Click, btnCAbs.Click

        If sender.Text = "Présent" Then
            ColPres.ShowDialog()
            CouleurPresT = ColPres.Color()
        Else
            If sender.Text = "Présent et Bien" Then
                ColPresBien.ShowDialog()
                CouleurPresBienT = ColPresBien.Color()
            Else
                ColAbsent.ShowDialog()
                CouleurAbsT = ColAbsent.Color()
            End If
        End If

        If CouleurPresT = CouleurPresBienT Or CouleurPresT = CouleurAbsT Or CouleurPresBienT = CouleurAbsT Then
            BonneCouleur = False
            CouleurModif = False
        Else
            BonneCouleur = True
            CouleurModif = True

        End If


    End Sub





    Private Sub txtProp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProp.KeyPress, txtTemps.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub RBtnAct_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnAct.CheckedChanged
        txtTemps.Visible = True
        lblLimTemps.Visible = True

    End Sub

    Private Sub RbtnDesac_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnDesac.CheckedChanged
        txtTemps.Visible = False
        lblLimTemps.Visible = False

    End Sub

    Private Sub btnAnnu_Click(sender As Object, e As EventArgs) Handles btnAnnu.Click
        Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnEnr_Click(sender As Object, e As EventArgs) Handles btnEnr.Click

        'Verif couleur
        If (BonneCouleur = False) Then
            MsgBox("Veuillez entrer des couleurs différentes.")
            Return

        ElseIf CouleurModif = True Then
            CouleurPres = CouleurPresT
            CouleurPresBien = CouleurPresBienT
            CouleurAbs = CouleurAbsT

        End If

        'Verif Char utilisable
        If (txtChar.Text.Length() <= 1) Then
            MsgBox("Veuillez entrer au minimum 2 caractères utilisables")
            Return

        End If
        For Each c As Char In txtChar.Text
            Dim nb As Integer = 0
            For Each ch As Char In txtChar.Text
                If c = ch Then
                    nb += 1
                    If nb > 1 Then
                        MsgBox("Veuillez entrer des caractères utilisables différents")
                        Return
                    End If
                End If
            Next
        Next
        CharAutorise = txtChar.Text

        'Verif max Propositions
        If txtProp.Text.Length > 0 Then
            If txtProp.Text > 15 Then
                MsgBox("Veuillez entrer un nombre de proposition entre 0 et 15")
                Return
            Else
                PropositionMax = txtProp.Text
            End If
        Else
            MsgBox("Veuillez entrer un nombre de proposition")
            Return
        End If



        If RBtnAct.Checked Then
            If txtTemps.Text.Length = 0 Then
                MsgBox("Veuillez entrer une limite de temps")
                Return
            Else
                LimTemps = txtTemps.Text
            End If

        End If
        If RbtnDesac.Checked Then
            LimTemps = Integer.MaxValue
        End If


        MsgBox("Enregistrement effecuté ! ")
        Me.Hide()

    End Sub


End Class