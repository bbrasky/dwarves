﻿Imports System.Windows.Forms

Public Class dlg_NewDwarf

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlg_NewDwarf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Select()
    End Sub
End Class
