﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DgvMatriz = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvMatriz
        '
        Me.DgvMatriz.AllowUserToAddRows = False
        Me.DgvMatriz.AllowUserToDeleteRows = False
        Me.DgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMatriz.ColumnHeadersVisible = False
        Me.DgvMatriz.Location = New System.Drawing.Point(162, 12)
        Me.DgvMatriz.Name = "DgvMatriz"
        Me.DgvMatriz.ReadOnly = True
        Me.DgvMatriz.RowHeadersVisible = False
        Me.DgvMatriz.Size = New System.Drawing.Size(805, 444)
        Me.DgvMatriz.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Crear Laberinto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 476)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvMatriz)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgvMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvMatriz As DataGridView
    Friend WithEvents Button1 As Button
End Class