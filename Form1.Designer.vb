<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Accueil))
        cboJ1 = New ComboBox()
        cboJ2 = New ComboBox()
        labJ1 = New Label()
        labJ2 = New Label()
        btnStart = New Button()
        btnClose = New Button()
        btnScore = New Button()
        btnParam = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' cboJ1
        ' 
        cboJ1.FormattingEnabled = True
        resources.ApplyResources(cboJ1, "cboJ1")
        cboJ1.Name = "cboJ1"
        ' 
        ' cboJ2
        ' 
        cboJ2.FormattingEnabled = True
        resources.ApplyResources(cboJ2, "cboJ2")
        cboJ2.Name = "cboJ2"
        ' 
        ' labJ1
        ' 
        resources.ApplyResources(labJ1, "labJ1")
        labJ1.BackColor = Color.PaleVioletRed
        labJ1.Name = "labJ1"
        ' 
        ' labJ2
        ' 
        resources.ApplyResources(labJ2, "labJ2")
        labJ2.BackColor = Color.PaleVioletRed
        labJ2.Name = "labJ2"
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.LawnGreen
        resources.ApplyResources(btnStart, "btnStart")
        btnStart.Name = "btnStart"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        resources.ApplyResources(btnClose, "btnClose")
        btnClose.Name = "btnClose"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnScore
        ' 
        btnScore.BackColor = Color.CornflowerBlue
        resources.ApplyResources(btnScore, "btnScore")
        btnScore.Name = "btnScore"
        btnScore.UseVisualStyleBackColor = False
        ' 
        ' btnParam
        ' 
        btnParam.BackColor = Color.DarkGray
        resources.ApplyResources(btnParam, "btnParam")
        btnParam.Name = "btnParam"
        btnParam.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Accueil
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        Controls.Add(Label1)
        Controls.Add(btnParam)
        Controls.Add(btnScore)
        Controls.Add(btnClose)
        Controls.Add(btnStart)
        Controls.Add(labJ2)
        Controls.Add(labJ1)
        Controls.Add(cboJ2)
        Controls.Add(cboJ1)
        Name = "Accueil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboJ1 As ComboBox
    Friend WithEvents cboJ2 As ComboBox
    Friend WithEvents labJ1 As Label
    Friend WithEvents labJ2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnScore As Button
    Friend WithEvents btnParam As Button
    Friend WithEvents Label1 As Label
End Class
