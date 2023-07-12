Imports System.Diagnostics.Eventing.Reader
Imports System.Diagnostics.PerformanceData
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Guesser

    Private NombreTentativesMax As Integer = Form4.getPropMax()
    Private TempsPDeviner As Integer = Form4.GetLimTemps()
    Private BonneCombinaison As String = Setter.getCombinaisonJoueur()
    Private couleurPres As Color = Form4.getCouleurPres()
    Private couleurPresBien As Color = Form4.getCouleurPresBien()
    Private couleurAbs As Color = Form4.getCouleurAbs()


    Private TentativesRestantes As Integer = NombreTentativesMax
    Private TempsRestant As Integer = TempsPDeviner

    Private j1 As Joueur
    Private j2 As Joueur


    Private caracteresAutorises As String = Form4.getCharAutorise()


    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress, txt2.KeyPress, txt3.KeyPress, txt4.KeyPress, txt5.KeyPress

        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If Not caracteresAutorises.Contains(e.KeyChar) Then
            e.Handled = True
        End If

        If (sender.BackColor <> couleurPresBien) Then
            sender.BackColor = Color.White
        End If



    End Sub



    Private Sub Guesser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labAbs.ForeColor = couleurAbs
        labPres.ForeColor = couleurPres
        labPresBien.ForeColor = couleurPresBien


        labCar.Text = caracteresAutorises
        For Each p In panPredEssais.Controls
            p.Visible = False
        Next
        labCoup.Text = TentativesRestantes
        labTemps.Text = TempsRestant
        If TempsPDeviner = Integer.MaxValue Then
            labTemps.Visible = False
            labTempsRst.Visible = False
        End If

        Timer1.Start()



        'Enregistrement des joueurs

        j1.Nom = Accueil.cboJ1.Text
        j2.Nom = Accueil.cboJ2.Text

        j1.TempsRecord = TempsPDeviner
        j1.NbFirst += 1
        j2.NbSecond += 1

    End Sub

    Private Sub btnGuess_Click_1(sender As Object, e As EventArgs) Handles btnGuess.Click

        For Each txt In panCombiDeviner.Controls
            If txt.Text.Length = 0 Then
                MsgBox("Veuillez remplir toutes les cases.")
                Return
            End If
        Next

        Dim NbTxtBox As Integer = 4
        Dim Trouve As Boolean = True
        Dim compteur As Integer = NbTxtBox
        For Each txt In panCombiDeviner.Controls
            Dim Boncontrole As Control = panPredEssais.Controls(TentativesRestantes - 1)
            Boncontrole.Visible = True
            Dim Bonlab As Label = Boncontrole.Controls(NbTxtBox - compteur) 'l'index de chaque control est à l'envers (0 devient 4, 1 devient 3 etc.)
            Bonlab.Text = txt.Text

            If txt.Text = BonneCombinaison(compteur) Then

                txt.BackColor = couleurPresBien
                Bonlab.ForeColor = couleurPresBien
                txt.ReadOnly = True

            Else
                Trouve = False
                If BonneCombinaison.IndexOf(txt.Text) <> -1 Then
                    txt.BackColor = couleurPres
                    Bonlab.ForeColor = couleurPres
                Else
                    txt.BackColor = couleurAbs
                    Bonlab.ForeColor = couleurAbs
                End If
            End If

            compteur -= 1
        Next

        TentativesRestantes -= 1
        labCoup.Text = TentativesRestantes

        If Trouve = True Or TentativesRestantes = 0 Or TempsRestant = 0 Then
            If Trouve = True Then
                j2.Score += 1
                FinirPartie(labtrouve)
            End If
            If TentativesRestantes = 0 Then
                j1.Score += 1
                FinirPartie(labDmg)
            End If

            Return
        End If
    End Sub

    Private Sub FinirPartie(AffLab As Label)

        AffLab.Visible = True
        btnPartieSuiv.Visible = True
        Timer1.Stop()
        btnGuess.Enabled = False

        j2.TempsTotal += TempsPDeviner - TempsRestant
        j2.TempsRecord = TempsPDeviner - TempsRestant

        Settings.Add(j1)
        Settings.Add(j2)

        Settings.Actualiser()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TempsRestant -= 1
        labTemps.Text = TempsRestant
        If TempsRestant = 0 Then
            FinirPartie(labDmg)
        End If

    End Sub

    Private Sub btnPartieSuiv_Click(sender As Object, e As EventArgs) Handles btnPartieSuiv.Click
        Accueil.cboJ1.Text = j2.Nom
        Accueil.cboJ2.Text = j1.Nom

        Accueil.Show()
        Me.Close()
    End Sub

    Private Sub Guesser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Accueil.Show()
    End Sub

End Class
