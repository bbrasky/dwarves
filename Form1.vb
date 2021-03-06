﻿Public Class Form1
    Private Dwarves As New List(Of Dwarf)
    Public MyForest As New Tree
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set up control of the action log
        ActionLog.InitializeHighlights()
        ActionLog.DwarfList = Dwarves
        ActionLog.OutputField = rtbOutput

        'Data refresh for stats
        tmrDataRefresh.Enabled = True
        tmrDataRefresh.Start()

        'Initialize the forest
        MyForest.InitializeTrees()

    End Sub

    Private Sub btnNewDwarf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDwarf.Click
        CreateDwarf()

    End Sub

    Private Sub CreateDwarf()
        Dim nd As New dlg_NewDwarf
        If nd.ShowDialog = DialogResult.OK Then
            Dwarves.Add(New Dwarf)
            Dwarves(Dwarves.Count - 1).Name = nd.txtName.Text
            Dwarves(Dwarves.Count - 1).Activate()

            'Decide how to determine stregnth
            Dwarves(Dwarves.Count - 1).Strength = 1
            RefreshList()
        End If
        nd.Dispose()
    End Sub

    Public Function FindDwarf(ByVal DwarfName As String) As Dwarf
        For Each fDwarf In Dwarves
            If fDwarf.Name = DwarfName Then
                Return fDwarf
            End If
        Next
        Return Nothing
    End Function

    Private Sub RefreshList()
        lbDwarves.Items.Clear()
        For Each iDwarf As Dwarf In Dwarves
            lbDwarves.Items.Add(iDwarf.Name)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim giveDLG As New dlg_Give
        If giveDLG.ShowDialog = DialogResult.OK Then
            For Each iDwarf In Dwarves
                If iDwarf.Name = lbDwarves.SelectedItem.ToString Then
                    Select Case giveDLG.lbItems.SelectedItem
                        Case "Axe"
                            iDwarf.Inventory.Add(New Item.Axe)
                        Case "Basket"
                            iDwarf.Inventory.Add(New Item.Basket)
                        Case "Satchel"
                            iDwarf.Inventory.Add(New Item.Satchel)
                    End Select

                End If
            Next
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dlgInv As New dlg_Inventory
        Dim currentDwarf As Dwarf = FindDwarf(lbDwarves.SelectedItem)
        For Each iobj As Object In currentDwarf.Inventory
            dlgInv.lbItems.Items.Add(iobj.ToString)
        Next
        dlgInv.ShowDialog()
    End Sub

    Private Sub tmrDataRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDataRefresh.Tick
        lblLumber.Text = "Lumber: " & Resources.Lumber
        lblFood.Text = "Food: " & Resources.Food
        If Not lbDwarves.SelectedItem Is Nothing Then
            lblSelectedState.Text = lbDwarves.SelectedItem & " is " & FindDwarf(lbDwarves.SelectedItem).State
            lblStrength.Text = "Strength: " & FindDwarf(lbDwarves.SelectedItem).Strength.ToString
            lblWeight.Text = "Inventory weight: " & FindDwarf(lbDwarves.SelectedItem).InventoryWeight.ToString
            lblHP.Text = "HP: " & FindDwarf(lbDwarves.SelectedItem).HP & "/100"
            lbldamage.Text = "Damage: " & FindDwarf(lbDwarves.SelectedItem).Damage
            lblCoords.Text = "Coordinates: " & FindDwarf(lbDwarves.SelectedItem).X & ", " & FindDwarf(lbDwarves.SelectedItem).Y
            lblSpeed.Text = "Speed: " & FindDwarf(lbDwarves.SelectedItem).Speed

            Dim SkillText As String = "Skill Order:" & vbNewLine
            For Each iobj As Object In FindDwarf(lbDwarves.SelectedItem).MySkills
                SkillText = SkillText & iobj.ToString.Replace("dwarf.Skills+", "") & vbNewLine
            Next
            lblSkillOrder.Text = SkillText

        Else
            lblSelectedState.Text = ""
        End If
    End Sub

    Private Sub lbDwarves_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDwarves.SelectedIndexChanged
        If Not lbDwarves.SelectedItem Is Nothing Then
            lblSelectedState.Text = lbDwarves.SelectedItem & " is " & FindDwarf(lbDwarves.SelectedItem).State
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'rtbOutput.AppendText(lbDwarves.SelectedItem & "has been fired!  Out with you now!" & vbNewLine)
        ActionLog.Write(lbDwarves.SelectedItem & "has been fired!  Out with you now!")
        Dwarves.Remove(FindDwarf(lbDwarves.SelectedItem))
        lbDwarves.Items.Remove(lbDwarves.SelectedItem)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtRandom.Text <> "" Then
            SpawnControl.AutoSpawn(Convert.ToInt32(txtRandom.Text), Dwarves)
            RefreshList()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TreeData.Show()
    End Sub

    Public Function DwarfExistsAt(ByVal lX As Integer, ByVal lY As Integer) As Boolean
        For Each iDwarf As Dwarf In Dwarves
            If iDwarf.X = lX AndAlso iDwarf.Y = lY Then Return True
        Next
        Return False
    End Function

End Class
