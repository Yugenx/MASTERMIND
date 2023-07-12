Imports MASTERMIND.Settings

Public Class Accueil

    Private joueur1 As New Joueur()
    Private joueur2 As New Joueur()
    Private TempsPDeviner As Integer = 90

    Public Function getTempsPDeviver()
        Return TempsPDeviner
    End Function

    Private Sub btnLancerLaPartie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If cboJ1.Text <> "" And cboJ2.Text <> "" And cboJ1.Text <> cboJ2.Text Then
            Setter.Show()
            Me.Hide()
        Else
            MessageBox.Show("Veuillez entrer des noms différents pour les joueurs.", "Erreur")
        End If
    End Sub

    Private Sub btnQuitterLaPartie_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAfficherLesScores_Click(sender As System.Object, e As System.EventArgs) Handles btnScore.Click

        Scores.Show()
        Me.Hide()

    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Settings.Initialiser()

        'Setter ComboBox d'Accueil
        For Each j As Joueur In Settings.getJoueurs()
            cboJ1.Items.Add(j.Nom)
            cboJ2.Items.Add(j.Nom)
        Next

    End Sub

    Private Sub btnParam_Click(sender As Object, e As EventArgs) Handles btnParam.Click
        Form4.Show()
    End Sub


End Class

