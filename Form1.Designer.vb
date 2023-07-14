<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox4 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(32, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 42)
        Label1.TabIndex = 0
        Label1.Text = "Title"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(232, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(318, 54)
        Label4.TabIndex = 3
        Label4.Text = "Library Database"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(160, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(209, 34)
        TextBox1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(32, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 42)
        Label2.TabIndex = 5
        Label2.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(32, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 42)
        Label3.TabIndex = 6
        Label3.Text = "Date"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(160, 155)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(209, 34)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(160, 197)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(209, 34)
        TextBox3.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(160, 247)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 36)
        Button1.TabIndex = 9
        Button1.Text = "Insert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(298, 247)
        Button2.Name = "Button2"
        Button2.Size = New Size(71, 36)
        Button2.TabIndex = 10
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(160, 324)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(209, 34)
        TextBox4.TabIndex = 11
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(232, 377)
        Button3.Name = "Button3"
        Button3.Size = New Size(71, 36)
        Button3.TabIndex = 12
        Button3.Text = "Search"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(309, 377)
        Button4.Name = "Button4"
        Button4.Size = New Size(71, 36)
        Button4.TabIndex = 13
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(6, 320)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 42)
        Label5.TabIndex = 14
        Label5.Text = "Search ID"
        Label5.UseCompatibleTextRendering = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(395, 92)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(393, 346)
        DataGridView1.TabIndex = 15
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(155, 377)
        Button5.Name = "Button5"
        Button5.Size = New Size(71, 36)
        Button5.TabIndex = 16
        Button5.Text = "Show"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
End Class
