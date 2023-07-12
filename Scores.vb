Public Class Scores

    Private Sub lst_IndexChanged(sender As Object, e As EventArgs) Handles lstNom.SelectedIndexChanged, lstScore.SelectedIndexChanged, lstTempsR.SelectedIndexChanged, lstFirst.SelectedIndexChanged, lstSecond.SelectedIndexChanged, lstTempsT.SelectedIndexChanged, cboNom.SelectedIndexChanged

        'Synchronisation des listbox
        lstNom.SelectedIndex = sender.selectedIndex
        lstScore.SelectedIndex = sender.selectedIndex
        lstTempsR.SelectedIndex = sender.selectedIndex
        lstFirst.SelectedIndex = sender.selectedIndex
        lstSecond.SelectedIndex = sender.selectedIndex
        lstTempsT.SelectedIndex = sender.selectedIndex

        lstNom.TopIndex = sender.SelectedIndex
        lstScore.TopIndex = sender.SelectedIndex
        lstTempsR.TopIndex = sender.SelectedIndex
        lstFirst.TopIndex = sender.selectedIndex
        lstSecond.TopIndex = sender.selectedIndex
        lstTempsT.TopIndex = sender.selectedIndex

        cboNom.Text = lstNom.Text


    End Sub

    Private Sub Actualise(joueurs As List(Of Joueur))

        lstNom.Items.Clear()
        cboNom.Items.Clear()
        lstScore.Items.Clear()
        lstTempsR.Items.Clear()
        lstFirst.Items.Clear()
        lstSecond.Items.Clear()
        lstTempsT.Items.Clear()

        Initialise(joueurs)

        lstNom.SelectedIndex = 0
        lstScore.SelectedIndex = 0
        lstTempsR.SelectedIndex = 0
        lstFirst.SelectedIndex = 0
        lstSecond.SelectedIndex = 0
        lstTempsT.SelectedIndex = 0
    End Sub
    Private Sub Initialise(joueurs As List(Of Joueur))

        'Enregistrement des joueurs dans toutes les listbox et combobox
        For Each j As Joueur In joueurs

            lstNom.Items.Add(j.Nom)
            cboNom.Items.Add(j.Nom)
            lstScore.Items.Add(j.Score)
            lstTempsR.Items.Add(j.TempsRecord & "s")
            lstFirst.Items.Add(j.NbFirst)
            lstSecond.Items.Add(j.NbSecond)
            lstTempsT.Items.Add((j.TempsTotal \ 60).ToString("00") & "m" & (j.TempsTotal Mod 60).ToString("00") & "s")
        Next

    End Sub
    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initialise(Settings.getJoueurs())

        lstTrie.Items.Add("Alphabétique")
        lstTrie.Items.Add("Meilleur score")
        lstTrie.Items.Add("Meilleur temps")
        lstTrie.Items.Add("Grand Décideur")
        lstTrie.Items.Add("Grand Devineur")
        lstTrie.Items.Add("Temps Total")

    End Sub

    Private Sub cboNom_TextChanged(sender As Object, e As EventArgs) Handles cboNom.TextChanged
        'Affiche le bouton stats si le joueur existe bien
        If Settings.Existe(cboNom.Text) Then
            btnStats.Visible = True
        Else
            btnStats.Visible = False
        End If
    End Sub
    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        Dim j As Joueur = Settings.getJoueur(cboNom.Text)
        MsgBox("Parties gagnées : " & j.Score & vbCrLf & "Meilleur temps : " & j.TempsRecord & "s" & vbCrLf & "Partie Décideur : " & j.NbFirst & vbCrLf & "Partie Devineur : " & j.NbSecond & vbCrLf & "Temps total : " & (j.TempsTotal \ 60).ToString("00") & "m" & (j.TempsTotal Mod 60).ToString("00") & "s", , "Statistiques de " & j.Nom) 'Finir l'affichage des stats du joueur
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Accueil.Show()
        Me.Close()
    End Sub

    Private Sub lstTrie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrie.SelectedIndexChanged
        'Liste de choix de trie à faire
        If lstTrie.SelectedItem = "Alphabétique" Then
            Actualise(getJoueurs.OrderBy(Function(x) x.Nom).ToList())
        End If

        If lstTrie.SelectedItem = "Meilleur score" Then
            Actualise(getJoueurs.OrderByDescending(Function(x) x.Score).ToList())
        End If

        If lstTrie.SelectedItem = "Meilleur temps" Then
            Actualise(getJoueurs.OrderBy(Function(x) x.TempsRecord).ToList())
        End If

        If lstTrie.SelectedItem = "Grand Décideur" Then
            Actualise(getJoueurs.OrderByDescending(Function(x) x.NbFirst).ToList())
        End If

        If lstTrie.SelectedItem = "Grand Devineur" Then
            Actualise(getJoueurs.OrderByDescending(Function(x) x.NbSecond).ToList())
        End If

        If lstTrie.SelectedItem = "Temps Total" Then
            Actualise(getJoueurs.OrderByDescending(Function(x) x.TempsTotal).ToList())
        End If

    End Sub

    Private Sub Scores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Accueil.Show()
    End Sub
End Class