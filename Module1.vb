Imports System.IO

Module Settings

    Dim Joueurs = New List(Of Joueur)()

    Public Structure Joueur

        Dim Nom As String
        Dim Score As Integer
        Dim TempsRecord As Integer
        Dim NbFirst As Integer
        Dim NbSecond As Integer
        Dim TempsTotal As Integer

    End Structure

    Public Sub Actualiser()
        Joueurs.Clear()
        Initialiser()
    End Sub
    Public Sub Initialiser()

        Dim File As System.IO.StreamReader
        File = My.Computer.FileSystem.OpenTextFileReader("PlayerData.txt")

        Dim jinput As String
        Dim joueur As Joueur

        'Ajout de tous les joueurs enregistrés
        Do While File.Peek() >= 0
            jinput = File.ReadLine()
            'Ajout d'un joueur
            joueur.Nom = jinput.Split(" ")(0)
            joueur.Score = jinput.Split(" ")(1)
            joueur.TempsRecord = jinput.Split(" ")(2)
            joueur.NbFirst = jinput.Split(" ")(3)
            joueur.NbSecond = jinput.Split(" ")(4)
            joueur.TempsTotal = jinput.Split(" ")(5)

            Joueurs.Add(joueur)
        Loop

        File.Close()

    End Sub

    'Retourne l'indice si existe
    Function Index(nom As String) As Integer

        For i As Integer = 0 To Joueurs.Count - 1
            If Joueurs(i).Nom.Equals(nom) Then
                Return i
            End If
        Next

        Return -1

    End Function

    'Retourne boolean si existe
    Function Existe(nom As String) As Boolean
        If Index(nom) <> -1 Then
            Return True
        End If
        Return False
    End Function

    Function getJoueur(nom As String) As Joueur

        If Existe(nom) Then
            Return Joueurs(Index(nom))
        End If

    End Function
    Function getJoueurs() As List(Of Joueur)
        Return Joueurs
    End Function

    Public Sub Modif(j As Joueur)

        'Vide le fichier
        File.WriteAllText("PlayerData.txt", "")


        'Modifie les statistiques du joueur concerné
        Dim jmodif As Joueur = Joueurs(Index(j.Nom))

        jmodif.Score += j.Score
        jmodif.NbFirst += j.NbFirst
        jmodif.NbSecond += j.NbSecond
        jmodif.TempsTotal += j.TempsTotal

        If jmodif.TempsRecord > j.TempsRecord Then
            jmodif.TempsRecord = j.TempsRecord
        End If

        Joueurs(Index(j.Nom)) = jmodif

        'Reécriture de tous les joueurs dans le fichier
        For Each jfile As Joueur In Joueurs
            Ajouter(jfile)
        Next

    End Sub

    Public Sub Ajouter(j As Joueur)

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("PlayerData.txt", True)
        file.WriteLine(j.Nom & " " & j.Score & " " & j.TempsRecord & " " & j.NbFirst & " " & j.NbSecond & " " & j.TempsTotal)
        file.Close()

    End Sub

    Public Sub Add(j As Joueur)

        'Joueur deja existant
        If Existe(j.Nom) Then
            Modif(j)
        Else
            'Sinon ajout du nouveau joueur
            Ajouter(j)
        End If

    End Sub

    Public Sub Echanger()

    End Sub


    'Public Function AjouterOuMettreAJourJoueur(joueur As Joueur) As Joueur
    ' Recherche un joueur existant avec le même nom
    ' Dim joueurExistant As Joueur = Joueurs.contains(joueur.Nom)
    'If joueurExistant IsNot Nothing Then
    ' Mettre à jour les statistiques du joueur existant
    ' TODO
    ' Else
    ' Ajouter le nouveau joueur à la liste
    '       Joueurs.Add(joueur)
    '       joueurExistant = joueur
    'End If

    'Return joueurExistant
    ' End Function




End Module

