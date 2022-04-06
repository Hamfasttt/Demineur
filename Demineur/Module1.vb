Module Module1
    Dim grille(10, 10) As Integer
    Dim grilleJoueur(11, 11) As String
    Dim RdmLig As Integer
    Dim RdmCol As Integer
    Dim Mine(2, 10) As Integer
    Dim I As Integer
    Public Sub Initialiser_grille()
        ' remplissage de la grille de 0 
        For lig = 1 To 10
            For col = 1 To 10
                grille(lig, col) = 0
            Next
        Next
    End Sub
    Public Sub Afficher_grille()
        ' affichage de la grille 
        For lig = 1 To 10
            For col = 1 To 10
                Console.Write(" " & grille(lig, col))
            Next
            Console.WriteLine("")
        Next

        Console.ReadLine()
    End Sub
    Public Sub Initialiser_grille_joueur()
        ' remplissage de la grille de █
        For lig = 1 To 10
            For col = 1 To 10
                grilleJoueur(lig, col) = " █ "
            Next
        Next
    End Sub
    Public Sub Afficher_grille_joueur()
        ' affichage de la grille 
        Console.Clear()

        For lig = 1 To 1
            For col = 1 To 1
                Console.Write("┌───")
            Next
            For col = 2 To 10
                Console.Write("┬───")
            Next
            For col = 11 To 11
                Console.Write("┐")
            Next
            Console.WriteLine("")
            For col = 1 To 11
                Console.Write("│" & grilleJoueur(lig, col))
            Next
        Next
        For lig = 2 To 10
            Console.WriteLine("")
            For col = 1 To 1
                Console.Write("├───")
            Next
            For col = 2 To 10
                Console.Write("┼───")
            Next
            For col = 11 To 11
                Console.Write("┤")
            Next
            Console.WriteLine("")
            For col = 1 To 11
                Console.Write("│" & grilleJoueur(lig, col))
            Next
        Next
        For lig = 10 To 10
            Console.WriteLine("")
            For col = 1 To 1
                Console.Write("└───")
            Next
            For col = 2 To 10
                Console.Write("┴───")
            Next
            For col = 11 To 11
                Console.Write("┘")
            Next
            Console.WriteLine("")
        Next

    End Sub
    Public Sub Poser_une_mine()
        Randomize()
        RdmCol = CInt(Int((10 * Rnd()) + 1))
        RdmLig = CInt(Int((10 * Rnd()) + 1))
        grille(RdmLig, RdmCol) = 9
    End Sub
    Public Sub Poser_dix_mines()
        For I = 1 To 10
            Randomize()
            RdmCol = CInt(Int((10 * Rnd()) + 1))
            RdmLig = CInt(Int((10 * Rnd()) + 1))
            grille(RdmLig, RdmCol) = 9
        Next
    End Sub
    Public Sub Coordonnees_mines()
        I = 0
        For ligne_mine = 1 To 10
            For colonne_mine = 1 To 10
                If grille(ligne_mine, colonne_mine) = 9 Then
                    I += 1
                    Console.WriteLine("Mine" & I & " :" & ligne_mine & ";" & colonne_mine & "    ")
                    If I = 1 Then
                        Console.WriteLine("Mine" & I & ": " & "coordonnées du contour: [" & ligne_mine & ";" & colonne_mine - 1 & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine - 1 & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine - 1 & "]")
                    End If
                    If I = 2 Then
                        Console.WriteLine("Mine" & I & ": " & "coordonnées du contour: [" & ligne_mine & ";" & colonne_mine - 1 & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine - 1 & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine - 1 & "]")
                    End If
                    If I = 5 Then
                        Console.WriteLine("Mine" & I & ": " & "coordonnées du contour: [" & ligne_mine & ";" & colonne_mine - 1 & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine - 1 & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine - 1 & "]")
                    End If
                    If I = 10 Then
                        Console.WriteLine("Mine" & I & ": " & "coordonnées du contour: [" & ligne_mine & ";" & colonne_mine - 1 & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine - 1 & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine & "]" & "[" & ligne_mine - 1 & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine + 1 & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine & "]" & "[" & ligne_mine + 1 & ";" & colonne_mine - 1 & "]")
                    End If
                End If

            Next
        Next

        Console.WriteLine("")

    End Sub

    Public Sub Contour_mine()
        For ligne_mine = 1 To 10
            For colonne_mine = 1 To 10
                If grille(ligne_mine, colonne_mine) = 9 Then
                    If grille(ligne_mine, colonne_mine - 1) <> 9 And colonne_mine <> 1 Then
                        grille(ligne_mine, colonne_mine - 1) += 1
                        On Error Resume Next
                    End If
                    If grille(ligne_mine - 1, colonne_mine - 1) <> 9 And colonne_mine <> 1 And ligne_mine <> 1 Then
                        grille(ligne_mine - 1, colonne_mine - 1) += 1
                        On Error Resume Next
                    End If
                    If grille(ligne_mine - 1, colonne_mine) <> 9 And ligne_mine <> 1 Then
                        grille(ligne_mine - 1, colonne_mine) += 1
                        On Error Resume Next
                    End If
                    If grille(ligne_mine - 1, colonne_mine + 1) <> 9 And colonne_mine <> 10 And ligne_mine <> 1 Then
                        grille(ligne_mine - 1, colonne_mine + 1) += 1
                        On Error Resume Next
                    End If
                    If grille(ligne_mine, colonne_mine + 1) <> 9 And colonne_mine <> 10 Then
                        grille(ligne_mine, colonne_mine + 1) += 1
                        On Error Resume Next
                    End If
                    If grille(ligne_mine + 1, colonne_mine + 1) <> 9 And colonne_mine <> 10 And ligne_mine <> 10 Then
                        grille(ligne_mine + 1, colonne_mine + 1) += 1
                        On Error Resume Next
                    End If
                    If grille(ligne_mine + 1, colonne_mine) <> 9 And ligne_mine <> 10 Then
                        grille(ligne_mine + 1, colonne_mine) += 1
                        On Error Resume Next
                    End If
                    If grille(ligne_mine + 1, colonne_mine - 1) <> 9 And ligne_mine <> 10 And colonne_mine <> 1 Then
                        grille(ligne_mine + 1, colonne_mine - 1) += 1
                        On Error Resume Next
                    End If
                End If
            Next
        Next

        Console.WriteLine("")
    End Sub

    Public Sub devoile_case(grille, grilleJoueur, pos_ligne, pos_colonne)
        Dim I As Integer
        If grille(pos_ligne, pos_colonne) = 0 Then
            grilleJoueur(pos_ligne, pos_colonne) = "   "
        End If
        If grille(pos_ligne, pos_colonne - 1) <> 9 Then
            grilleJoueur(pos_ligne, pos_colonne - 1) = " " & grille(pos_ligne, pos_colonne - 1) & " "
            If grille(pos_ligne, pos_colonne - 1) = 0 Then
                grilleJoueur(pos_ligne, pos_colonne - 1) = "   "
            End If
            On Error Resume Next
        End If
        If grille(pos_ligne - 1, pos_colonne - 1) <> 9 Then
            grilleJoueur(pos_ligne - 1, pos_colonne - 1) = " " & grille(pos_ligne - 1, pos_colonne - 1) & " "
            If grille(pos_ligne - 1, pos_colonne - 1) = 0 Then
                grilleJoueur(pos_ligne - 1, pos_colonne - 1) = "   "
            End If
            On Error Resume Next
        End If
        If grille(pos_ligne - 1, pos_colonne) <> 9 Then
            grilleJoueur(pos_ligne - 1, pos_colonne) = " " & grille(pos_ligne - 1, pos_colonne) & " "
            If grille(pos_ligne - 1, pos_colonne) = 0 Then
                grilleJoueur(pos_ligne - 1, pos_colonne) = "   "
            End If
            On Error Resume Next
        End If
        If grille(pos_ligne - 1, pos_colonne + 1) <> 9 Then
            grilleJoueur(pos_ligne - 1, pos_colonne + 1) = " " & grille(pos_ligne - 1, pos_colonne + 1) & " "
            If grille(pos_ligne - 1, pos_colonne + 1) = 0 Then
                grilleJoueur(pos_ligne - 1, pos_colonne + 1) = "   "
            End If
            On Error Resume Next
        End If
        If grille(pos_ligne, pos_colonne + 1) <> 9 Then
            grilleJoueur(pos_ligne, pos_colonne + 1) = " " & grille(pos_ligne, pos_colonne + 1) & " "
            If grille(pos_ligne, pos_colonne + 1) = 0 Then
                grilleJoueur(pos_ligne, pos_colonne + 1) = "   "
            End If
            On Error Resume Next
        End If
        If grille(pos_ligne + 1, pos_colonne + 1) <> 9 Then
            grilleJoueur(pos_ligne + 1, pos_colonne + 1) = " " & grille(pos_ligne + 1, pos_colonne + 1) & " "
            If grille(pos_ligne + 1, pos_colonne + 1) = 0 Then
                grilleJoueur(pos_ligne + 1, pos_colonne + 1) = "   "
            End If
            On Error Resume Next
        End If
        If grille(pos_ligne + 1, pos_colonne) <> 9 Then
            grilleJoueur(pos_ligne + 1, pos_colonne) = " " & grille(pos_ligne + 1, pos_colonne) & " "
            If grille(pos_ligne + 1, pos_colonne) = 0 Then
                grilleJoueur(pos_ligne + 1, pos_colonne) = "   "
            End If
            On Error Resume Next
        End If
        If grille(pos_ligne + 1, pos_colonne - 1) <> 9 Then
            grilleJoueur(pos_ligne + 1, pos_colonne - 1) = " " & grille(pos_ligne + 1, pos_colonne - 1) & " "
            If grille(pos_ligne + 1, pos_colonne - 1) = 0 Then
                grilleJoueur(pos_ligne + 1, pos_colonne - 1) = "   "
            End If
            On Error Resume Next
        End If
    End Sub
    Public Sub devoile_case_vide(grille, grilleJoueur, pos_ligne, pos_colonne)
        I = 1
        While I < 15
            For pos_ligne = 1 To 10
                For pos_colonne = 1 To 10
                    If grilleJoueur(pos_ligne, pos_colonne) = "   " Then
                        devoile_case(grille, grilleJoueur, pos_ligne, pos_colonne)
                    End If
                    I += 1
                Next
            Next
            For pos_ligne = 10 To 1 Step -1
                For pos_colonne = 10 To 1 Step -1
                    If grilleJoueur(pos_ligne, pos_colonne) = "   " Then
                        devoile_case(grille, grilleJoueur, pos_ligne, pos_colonne)
                    End If
                    I += 1
                Next
            Next
            For pos_ligne = 1 To 10
                For pos_colonne = 1 To 10
                    If grilleJoueur(pos_ligne, pos_colonne) = "   " Then
                        devoile_case(grille, grilleJoueur, pos_ligne, pos_colonne)
                    End If
                    I += 1
                Next
            Next
            For pos_ligne = 10 To 1 Step -1
                For pos_colonne = 10 To 1 Step -1
                    If grilleJoueur(pos_ligne, pos_colonne) = "   " Then
                        devoile_case(grille, grilleJoueur, pos_ligne, pos_colonne)
                    End If
                    I += 1
                Next
            Next
        End While





    End Sub
    Sub main()
        Dim pos_ligne As Integer
        Dim pos_colonne As Integer
        Call Initialiser_grille()
        Call Poser_dix_mines()
        Call Contour_mine()
        Call Initialiser_grille_joueur()
        Call Afficher_grille_joueur()
        Do While grille(pos_ligne, pos_colonne) <> 9

            Console.WriteLine("Saisir ligne entre 1 et 10:")
            pos_ligne = Console.ReadLine()
            Console.WriteLine("Saisir colonne entre 1 et 10:")
            pos_colonne = Console.ReadLine()
            If grille(pos_ligne, pos_colonne) = 9 Then

                Console.WriteLine("Vous avez perdu...")
                Console.ReadKey()
            ElseIf grille(pos_ligne, pos_colonne) <> 9 Then
                If grilleJoueur(pos_ligne, pos_colonne) = " █ " Then

                    grilleJoueur(pos_ligne, pos_colonne) = " " & grille(pos_ligne, pos_colonne) & " "
                    devoile_case(grille, grilleJoueur, pos_ligne, pos_colonne)
                    devoile_case_vide(grille, grilleJoueur, pos_ligne, pos_colonne)
                    Afficher_grille_joueur()
                    Console.WriteLine("Appuyer sur une touche")
                    Console.ReadKey()
                ElseIf grilleJoueur(pos_ligne, pos_colonne) = "   " Then


                End If
            End If


        Loop



    End Sub

End Module
