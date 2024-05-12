Public Class Form1
    Inherits System.Windows.Forms.Form
    'Data variables.
    Dim Fir_ing_1 As String
    Dim Fir_ing_2 As String
    Dim Fir_ing_3 As String
    Dim Fir_ing_4 As String
    Dim Fir_ing_5 As String
    Dim Fir_ing_6 As String
    Dim Fir_ing_7 As String
    Dim Fir_ing_8 As String
    Dim Fir_ing_9 As String

    Dim Fir_tot As String
    Dim Osp_tot As String


    Dim Osp_ing_1 As String
    Dim Osp_ing_2 As String
    Dim Osp_ing_3 As String
    Dim Osp_ing_4 As String
    Dim Osp_ing_5 As String
    Dim Osp_ing_6 As String
    Dim Osp_ing_7 As String
    Dim Osp_ing_8 As String
    Dim Osp_ing_9 As String

    Dim inizio As String
    Dim fine As String
    Dim ball_1 As String
    Dim ball_2 As String
    Dim ball_3 As String
    Dim ball_tot As String
    Dim strike_1 As String
    Dim strike_2 As String
    Dim strike_tot As String
    Dim out_1 As String
    Dim out_2 As String
    Dim out_tot As String
    Dim hit As String
    Dim errore As String
    Dim sTx As String
    Dim WithEvents moRS232 As Rs232
    Dim mlTicks As Long
    Private Delegate Sub CommEventUpdate(ByVal source As Rs232, ByVal mask As Rs232.EventMasks)
    Dim disp2 As Integer
    Dim disp3 As Integer
    Dim disp4 As Integer
    Dim disp5 As Integer
    Dim disp6 As Integer
    Dim disp7 As Integer
    Dim disp8 As Integer
    Dim disp9 As Integer
    Dim null As Byte





#Region " Codice generato da Progettazione Windows Form "

    Public Sub New()
        MyBase.New()

        'Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()
        Dim file As New System.IO.StreamReader("data.txt")
        TextBox1.Text = file.ReadLine()
        TextBox2.Text = file.ReadLine()
        TextBox3.Text = file.ReadLine()
        TextBox4.Text = file.ReadLine()
        TextBox5.Text = file.ReadLine()
        TextBox6.Text = file.ReadLine()
        TextBox7.Text = file.ReadLine()
        TextBox8.Text = file.ReadLine()
        TextBox9.Text = file.ReadLine()
        TextBox10.Text = file.ReadLine()
        TextBox11.Text = file.ReadLine()
        TextBox12.Text = file.ReadLine()
        TextBox13.Text = file.ReadLine()
        TextBox14.Text = file.ReadLine()
        TextBox15.Text = file.ReadLine()
        TextBox16.Text = file.ReadLine()
        TextBox17.Text = file.ReadLine()
        TextBox18.Text = file.ReadLine()
        TextBox19.Text = file.ReadLine()
        TextBox20.Text = file.ReadLine()

        ball_1 = file.ReadLine()
        If ball_1 = 1 Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If

        ball_2 = file.ReadLine()
        If ball_2 = 1 Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If

        ball_3 = file.ReadLine()
        If ball_3 = 1 Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If

        strike_1 = file.ReadLine()
        If strike_1 = 1 Then
            PictureBox4.Visible = True
        Else
            PictureBox4.Visible = False
        End If

        strike_2 = file.ReadLine()
        If strike_2 = 1 Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If

        out_1 = file.ReadLine()
        If out_1 = 1 Then
            PictureBox6.Visible = True
        Else
            PictureBox6.Visible = False
        End If

        out_2 = file.ReadLine()
        If out_2 = 1 Then
            PictureBox7.Visible = True
        Else
            PictureBox7.Visible = False
        End If

        hit = file.ReadLine()
        If hit = 1 Then
            PictureBox8.Visible = True
        Else
            PictureBox8.Visible = False
        End If
        errore = file.ReadLine()
        If errore = 1 Then
            PictureBox9.Visible = True
        Else
            PictureBox9.Visible = False
        End If

        file.Close()
        Me.Button3.Enabled = False
        Me.Button4.Enabled = False
        Me.Button5.Enabled = False
        Me.Button6.Enabled = False
        Me.Button7.Enabled = False
        Me.Button8.Enabled = False
        Me.Button9.Enabled = False
        Me.Button10.Enabled = False
        Me.Button11.Enabled = False
        Me.Button12.Enabled = False
        Me.Button13.Enabled = False
        Me.Button14.Enabled = False
        Me.Button15.Enabled = False
        Me.Button16.Enabled = False
        Me.Button17.Enabled = False
        Me.Button18.Enabled = False
        Me.Button23.Enabled = False
        Me.Button24.Enabled = False
        Me.Button25.Enabled = False
        Me.Button26.Enabled = False
        Me.Button27.Enabled = False
        Me.Button28.Enabled = False
        Me.Button29.Enabled = False
        Me.Button30.Enabled = False
        Me.Button31.Enabled = False
        Me.Button32.Enabled = False
        Me.Button33.Enabled = False
        Me.Button34.Enabled = False
        Me.Button35.Enabled = False
        Me.Button36.Enabled = False
        Me.Button37.Enabled = False
        Me.Button38.Enabled = False
        disp2 = 0
        disp3 = 0
        disp4 = 0
        disp5 = 0
        disp6 = 0
        disp7 = 0
        disp8 = 0
        disp9 = 0
        null = &HA
        'Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent()

    End Sub

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form.
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button41 As System.Windows.Forms.Button
    Friend WithEvents Button42 As System.Windows.Forms.Button
    Friend WithEvents Button43 As System.Windows.Forms.Button
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents Button45 As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Button52 As System.Windows.Forms.Button
    Friend WithEvents Button55 As System.Windows.Forms.Button
    Friend WithEvents Button59 As System.Windows.Forms.Button
    Friend WithEvents Button58 As System.Windows.Forms.Button
    Friend WithEvents Button57 As System.Windows.Forms.Button
    Friend WithEvents Button54 As System.Windows.Forms.Button
    Friend WithEvents Button56 As System.Windows.Forms.Button
    Friend WithEvents Button53 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Label30 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button31 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.Button33 = New System.Windows.Forms.Button
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button35 = New System.Windows.Forms.Button
        Me.Button36 = New System.Windows.Forms.Button
        Me.Button37 = New System.Windows.Forms.Button
        Me.Button38 = New System.Windows.Forms.Button
        Me.Button39 = New System.Windows.Forms.Button
        Me.Button40 = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button41 = New System.Windows.Forms.Button
        Me.Button42 = New System.Windows.Forms.Button
        Me.Button43 = New System.Windows.Forms.Button
        Me.Button44 = New System.Windows.Forms.Button
        Me.Button45 = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Button52 = New System.Windows.Forms.Button
        Me.Button55 = New System.Windows.Forms.Button
        Me.Button59 = New System.Windows.Forms.Button
        Me.Button58 = New System.Windows.Forms.Button
        Me.Button57 = New System.Windows.Forms.Button
        Me.Button54 = New System.Windows.Forms.Button
        Me.Button56 = New System.Windows.Forms.Button
        Me.Button53 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 504)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 40)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "FIRENZE"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(120, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 48)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "+"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Location = New System.Drawing.Point(120, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 48)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "-"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Location = New System.Drawing.Point(200, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 48)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "+"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button4.Location = New System.Drawing.Point(200, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 48)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "-"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 56)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 56)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "0"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(16, 304)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 32)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "INNING"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(872, 304)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(96, 32)
        Me.Label41.TabIndex = 21
        Me.Label41.Text = "TOTALE"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 56)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 56)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(440, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 56)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(520, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 56)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(600, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 56)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(680, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 56)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "0"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(760, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 56)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(888, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 56)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "0"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(120, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 56)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "0"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(200, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 56)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(280, 360)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 56)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "0"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(360, 360)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 56)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "0"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(440, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 56)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "0"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(520, 360)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 56)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "0"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(600, 360)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 56)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "0"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(680, 360)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 56)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "0"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(760, 360)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 56)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "0"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(888, 360)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 56)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "0"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.Location = New System.Drawing.Point(280, 200)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 48)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "-"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button5.Location = New System.Drawing.Point(280, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 48)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "+"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button8.Location = New System.Drawing.Point(360, 200)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 48)
        Me.Button8.TabIndex = 45
        Me.Button8.Text = "-"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button7.Location = New System.Drawing.Point(360, 136)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(64, 48)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "+"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button9.Location = New System.Drawing.Point(440, 136)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(64, 48)
        Me.Button9.TabIndex = 48
        Me.Button9.Text = "+"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button10.Location = New System.Drawing.Point(440, 200)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(64, 48)
        Me.Button10.TabIndex = 47
        Me.Button10.Text = "-"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button11.Location = New System.Drawing.Point(520, 136)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(64, 48)
        Me.Button11.TabIndex = 51
        Me.Button11.Text = "+"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button12.Location = New System.Drawing.Point(520, 200)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(64, 48)
        Me.Button12.TabIndex = 50
        Me.Button12.Text = "-"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button13.Location = New System.Drawing.Point(600, 136)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(64, 48)
        Me.Button13.TabIndex = 54
        Me.Button13.Text = "+"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button14.Location = New System.Drawing.Point(600, 200)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(64, 48)
        Me.Button14.TabIndex = 53
        Me.Button14.Text = "-"
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button15.Location = New System.Drawing.Point(680, 136)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(64, 48)
        Me.Button15.TabIndex = 57
        Me.Button15.Text = "+"
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button16.Location = New System.Drawing.Point(680, 200)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(64, 48)
        Me.Button16.TabIndex = 56
        Me.Button16.Text = "-"
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button17.Location = New System.Drawing.Point(760, 136)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(64, 48)
        Me.Button17.TabIndex = 60
        Me.Button17.Text = "+"
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button18.Location = New System.Drawing.Point(760, 200)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(64, 48)
        Me.Button18.TabIndex = 59
        Me.Button18.Text = "-"
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button19.Location = New System.Drawing.Point(888, 200)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(64, 48)
        Me.Button19.TabIndex = 63
        Me.Button19.Text = "+"
        Me.Button19.Visible = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button20.Location = New System.Drawing.Point(888, 248)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(64, 48)
        Me.Button20.TabIndex = 62
        Me.Button20.Text = "-"
        Me.Button20.Visible = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button21.Location = New System.Drawing.Point(120, 472)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(64, 48)
        Me.Button21.TabIndex = 66
        Me.Button21.Text = "+"
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button22.Location = New System.Drawing.Point(120, 536)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(64, 48)
        Me.Button22.TabIndex = 65
        Me.Button22.Text = "-"
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button23.Location = New System.Drawing.Point(200, 472)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(64, 48)
        Me.Button23.TabIndex = 69
        Me.Button23.Text = "+"
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button24.Location = New System.Drawing.Point(200, 536)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(64, 48)
        Me.Button24.TabIndex = 68
        Me.Button24.Text = "-"
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button25.Location = New System.Drawing.Point(280, 472)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(64, 48)
        Me.Button25.TabIndex = 72
        Me.Button25.Text = "+"
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button26.Location = New System.Drawing.Point(280, 536)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(64, 48)
        Me.Button26.TabIndex = 71
        Me.Button26.Text = "-"
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button27.Location = New System.Drawing.Point(360, 472)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(64, 48)
        Me.Button27.TabIndex = 75
        Me.Button27.Text = "+"
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button28.Location = New System.Drawing.Point(360, 536)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(64, 48)
        Me.Button28.TabIndex = 74
        Me.Button28.Text = "-"
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button29.Location = New System.Drawing.Point(440, 472)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(64, 48)
        Me.Button29.TabIndex = 78
        Me.Button29.Text = "+"
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button30.Location = New System.Drawing.Point(440, 536)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(64, 48)
        Me.Button30.TabIndex = 77
        Me.Button30.Text = "-"
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button31.Location = New System.Drawing.Point(520, 472)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(64, 48)
        Me.Button31.TabIndex = 81
        Me.Button31.Text = "+"
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button32.Location = New System.Drawing.Point(520, 536)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(64, 48)
        Me.Button32.TabIndex = 80
        Me.Button32.Text = "-"
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button33.Location = New System.Drawing.Point(600, 472)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(64, 48)
        Me.Button33.TabIndex = 84
        Me.Button33.Text = "+"
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button34.Location = New System.Drawing.Point(600, 536)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(64, 48)
        Me.Button34.TabIndex = 83
        Me.Button34.Text = "-"
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button35.Location = New System.Drawing.Point(680, 472)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(64, 48)
        Me.Button35.TabIndex = 87
        Me.Button35.Text = "+"
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button36.Location = New System.Drawing.Point(680, 536)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(64, 48)
        Me.Button36.TabIndex = 86
        Me.Button36.Text = "-"
        '
        'Button37
        '
        Me.Button37.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button37.Location = New System.Drawing.Point(760, 472)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(64, 48)
        Me.Button37.TabIndex = 91
        Me.Button37.Text = "+"
        '
        'Button38
        '
        Me.Button38.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button38.Location = New System.Drawing.Point(760, 536)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(64, 48)
        Me.Button38.TabIndex = 90
        Me.Button38.Text = "-"
        '
        'Button39
        '
        Me.Button39.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button39.Location = New System.Drawing.Point(888, 512)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(64, 48)
        Me.Button39.TabIndex = 93
        Me.Button39.Text = "+"
        Me.Button39.Visible = False
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button40.Location = New System.Drawing.Point(888, 568)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(64, 48)
        Me.Button40.TabIndex = 92
        Me.Button40.Text = "-"
        Me.Button40.Visible = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 32)
        Me.Label21.TabIndex = 94
        Me.Label21.Text = "OSPITI"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Navy
        Me.PictureBox1.Location = New System.Drawing.Point(208, 640)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Location = New System.Drawing.Point(272, 640)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.TabIndex = 102
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Red
        Me.PictureBox4.Location = New System.Drawing.Point(448, 640)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.TabIndex = 103
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Navy
        Me.PictureBox2.Location = New System.Drawing.Point(240, 640)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Red
        Me.PictureBox5.Location = New System.Drawing.Point(480, 640)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.TabIndex = 105
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Red
        Me.PictureBox7.Location = New System.Drawing.Point(648, 640)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox7.TabIndex = 106
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Red
        Me.PictureBox6.Location = New System.Drawing.Point(616, 640)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.TabIndex = 107
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Red
        Me.PictureBox8.Location = New System.Drawing.Point(784, 640)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox8.TabIndex = 108
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Red
        Me.PictureBox9.Location = New System.Drawing.Point(912, 640)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox9.TabIndex = 109
        Me.PictureBox9.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Button41
        '
        Me.Button41.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button41.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button41.Location = New System.Drawing.Point(120, 624)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(72, 48)
        Me.Button41.TabIndex = 110
        Me.Button41.Text = "BALL"
        '
        'Button42
        '
        Me.Button42.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button42.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button42.Location = New System.Drawing.Point(320, 624)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(112, 48)
        Me.Button42.TabIndex = 111
        Me.Button42.Text = "STRIKE"
        '
        'Button43
        '
        Me.Button43.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button43.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button43.Location = New System.Drawing.Point(528, 624)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(72, 48)
        Me.Button43.TabIndex = 112
        Me.Button43.Text = "OUT"
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button44.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button44.Location = New System.Drawing.Point(696, 624)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(72, 48)
        Me.Button44.TabIndex = 113
        Me.Button44.Text = "HIT"
        '
        'Button45
        '
        Me.Button45.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button45.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button45.Location = New System.Drawing.Point(832, 624)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(64, 48)
        Me.Button45.TabIndex = 114
        Me.Button45.Text = "E"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Strumenti"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Reset"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem3.Text = "Help"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Guida Generale"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "Informazioni si Cartellone"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(120, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 31)
        Me.TextBox1.TabIndex = 115
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(200, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 31)
        Me.TextBox2.TabIndex = 116
        Me.TextBox2.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(280, 88)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 31)
        Me.TextBox3.TabIndex = 117
        Me.TextBox3.Text = "0"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(360, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(64, 31)
        Me.TextBox4.TabIndex = 118
        Me.TextBox4.Text = "0"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(440, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(64, 31)
        Me.TextBox5.TabIndex = 119
        Me.TextBox5.Text = "0"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(520, 88)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(64, 31)
        Me.TextBox6.TabIndex = 120
        Me.TextBox6.Text = "0"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(600, 88)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(64, 31)
        Me.TextBox7.TabIndex = 121
        Me.TextBox7.Text = "0"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(680, 88)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(64, 31)
        Me.TextBox8.TabIndex = 122
        Me.TextBox8.Text = "0"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(760, 88)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(64, 31)
        Me.TextBox9.TabIndex = 123
        Me.TextBox9.Text = "0"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(888, 168)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(64, 31)
        Me.TextBox10.TabIndex = 124
        Me.TextBox10.Text = "0"
        Me.TextBox10.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(120, 424)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(64, 31)
        Me.TextBox11.TabIndex = 125
        Me.TextBox11.Text = "0"
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(200, 424)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(64, 31)
        Me.TextBox12.TabIndex = 126
        Me.TextBox12.Text = "0"
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(280, 424)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(64, 31)
        Me.TextBox13.TabIndex = 127
        Me.TextBox13.Text = "0"
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(360, 424)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(64, 31)
        Me.TextBox14.TabIndex = 128
        Me.TextBox14.Text = "0"
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(440, 424)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(64, 31)
        Me.TextBox15.TabIndex = 129
        Me.TextBox15.Text = "0"
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(520, 424)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(64, 31)
        Me.TextBox16.TabIndex = 130
        Me.TextBox16.Text = "0"
        '
        'TextBox17
        '
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(600, 424)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(64, 31)
        Me.TextBox17.TabIndex = 131
        Me.TextBox17.Text = "0"
        '
        'TextBox18
        '
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(680, 424)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(64, 31)
        Me.TextBox18.TabIndex = 132
        Me.TextBox18.Text = "0"
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(760, 424)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(64, 31)
        Me.TextBox19.TabIndex = 133
        Me.TextBox19.Text = "0"
        '
        'TextBox20
        '
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(888, 424)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(64, 31)
        Me.TextBox20.TabIndex = 134
        Me.TextBox20.Text = "0"
        Me.TextBox20.Visible = False
        '
        'Button52
        '
        Me.Button52.Location = New System.Drawing.Point(208, 280)
        Me.Button52.Name = "Button52"
        Me.Button52.Size = New System.Drawing.Size(48, 72)
        Me.Button52.TabIndex = 135
        Me.Button52.Text = "2"
        '
        'Button55
        '
        Me.Button55.Location = New System.Drawing.Point(448, 280)
        Me.Button55.Name = "Button55"
        Me.Button55.Size = New System.Drawing.Size(48, 72)
        Me.Button55.TabIndex = 136
        Me.Button55.Text = "5"
        '
        'Button59
        '
        Me.Button59.Location = New System.Drawing.Point(768, 280)
        Me.Button59.Name = "Button59"
        Me.Button59.Size = New System.Drawing.Size(48, 72)
        Me.Button59.TabIndex = 137
        Me.Button59.Text = "9"
        '
        'Button58
        '
        Me.Button58.Location = New System.Drawing.Point(688, 280)
        Me.Button58.Name = "Button58"
        Me.Button58.Size = New System.Drawing.Size(48, 72)
        Me.Button58.TabIndex = 138
        Me.Button58.Text = "8"
        '
        'Button57
        '
        Me.Button57.Location = New System.Drawing.Point(608, 280)
        Me.Button57.Name = "Button57"
        Me.Button57.Size = New System.Drawing.Size(48, 72)
        Me.Button57.TabIndex = 139
        Me.Button57.Text = "7"
        '
        'Button54
        '
        Me.Button54.Location = New System.Drawing.Point(368, 280)
        Me.Button54.Name = "Button54"
        Me.Button54.Size = New System.Drawing.Size(48, 72)
        Me.Button54.TabIndex = 140
        Me.Button54.Text = "4"
        '
        'Button56
        '
        Me.Button56.Location = New System.Drawing.Point(528, 280)
        Me.Button56.Name = "Button56"
        Me.Button56.Size = New System.Drawing.Size(48, 72)
        Me.Button56.TabIndex = 141
        Me.Button56.Text = "6"
        '
        'Button53
        '
        Me.Button53.Location = New System.Drawing.Point(288, 280)
        Me.Button53.Name = "Button53"
        Me.Button53.Size = New System.Drawing.Size(48, 72)
        Me.Button53.TabIndex = 142
        Me.Button53.Text = "3"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(24, 55)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(994, 697)
        Me.Controls.Add(Me.Button53)
        Me.Controls.Add(Me.Button56)
        Me.Controls.Add(Me.Button54)
        Me.Controls.Add(Me.Button57)
        Me.Controls.Add(Me.Button58)
        Me.Controls.Add(Me.Button59)
        Me.Controls.Add(Me.Button55)
        Me.Controls.Add(Me.Button52)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button45)
        Me.Controls.Add(Me.Button44)
        Me.Controls.Add(Me.Button43)
        Me.Controls.Add(Me.Button42)
        Me.Controls.Add(Me.Button41)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Button39)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.Button36)
        Me.Controls.Add(Me.Button33)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label30)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Cartellone segnapunti"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text < 19 Then
            TextBox1.Text = TextBox1.Text + 1
            Label1.Text = TextBox1.Text

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text > 0 Then
            TextBox1.Text = TextBox1.Text - 1
            Label1.Text = TextBox1.Text
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox2.Text < 19 Then
            TextBox2.Text = TextBox2.Text + 1
            Label2.Text = TextBox2.Text
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox2.Text > 0 Then
            TextBox2.Text = TextBox2.Text - 1
            Label2.Text = TextBox2.Text
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox3.Text < 19 Then
            TextBox3.Text = TextBox3.Text + 1
            Label3.Text = TextBox3.Text
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox3.Text > 0 Then
            TextBox3.Text = TextBox3.Text - 1
            Label3.Text = TextBox3.Text
        End If
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox4.Text < 19 Then
            TextBox4.Text = TextBox4.Text + 1
            Label4.Text = TextBox4.Text
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox4.Text > 0 Then
            TextBox4.Text = TextBox4.Text - 1
            Label4.Text = TextBox4.Text
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox5.Text < 19 Then
            TextBox5.Text = TextBox5.Text + 1
            Label5.Text = TextBox5.Text
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If TextBox5.Text > 0 Then
            TextBox5.Text = TextBox5.Text - 1
            Label5.Text = TextBox5.Text
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If TextBox6.Text < 19 Then
            TextBox6.Text = TextBox6.Text + 1
            Label6.Text = TextBox6.Text
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If TextBox6.Text > 0 Then
            TextBox6.Text = TextBox6.Text - 1
            Label6.Text = TextBox6.Text
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If TextBox7.Text < 19 Then
            TextBox7.Text = TextBox7.Text + 1
            Label7.Text = TextBox7.Text
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If TextBox7.Text > 0 Then
            TextBox7.Text = TextBox7.Text - 1
            Label7.Text = TextBox7.Text
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If TextBox8.Text < 19 Then
            TextBox8.Text = TextBox8.Text + 1
            Label8.Text = TextBox8.Text
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If TextBox8.Text > 0 Then
            TextBox8.Text = TextBox8.Text - 1
            Label8.Text = TextBox8.Text
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If TextBox9.Text < 19 Then
            TextBox9.Text = TextBox9.Text + 1
            Label9.Text = TextBox9.Text
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If TextBox9.Text > 0 Then
            TextBox9.Text = TextBox9.Text - 1
            Label9.Text = TextBox9.Text
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        TextBox10.Text = TextBox10.Text + 1
        Label10.Text = TextBox10.Text


    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If TextBox10.Text > 0 Then
            TextBox10.Text = TextBox10.Text - 1
            Label10.Text = TextBox10.Text
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If TextBox11.Text < 19 Then
            TextBox11.Text = TextBox11.Text + 1
            Label11.Text = TextBox11.Text
        End If
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If TextBox11.Text > 0 Then
            TextBox11.Text = TextBox11.Text - 1
            Label11.Text = TextBox11.Text
        End If
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If TextBox12.Text < 19 Then
            TextBox12.Text = TextBox12.Text + 1
            Label12.Text = TextBox12.Text
        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If TextBox12.Text > 0 Then
            TextBox12.Text = TextBox12.Text - 1
            Label12.Text = TextBox12.Text
        End If
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If TextBox13.Text < 19 Then
            TextBox13.Text = TextBox13.Text + 1
            Label13.Text = TextBox13.Text
        End If
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If TextBox13.Text > 0 Then
            TextBox13.Text = TextBox13.Text - 1
            Label13.Text = TextBox13.Text
        End If
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        If TextBox14.Text < 19 Then
            TextBox14.Text = TextBox14.Text + 1
            Label14.Text = TextBox14.Text
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If TextBox14.Text > 0 Then
            TextBox14.Text = TextBox14.Text - 1
            Label14.Text = TextBox14.Text
        End If
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        If TextBox15.Text < 19 Then
            TextBox15.Text = TextBox15.Text + 1
            Label15.Text = TextBox15.Text
        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If TextBox15.Text > 0 Then
            TextBox15.Text = TextBox15.Text - 1
            Label15.Text = TextBox15.Text
        End If
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        If TextBox16.Text < 19 Then
            TextBox16.Text = TextBox16.Text + 1
            Label16.Text = TextBox16.Text
        End If
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        If TextBox16.Text > 0 Then
            TextBox16.Text = TextBox16.Text - 1
            Label16.Text = TextBox16.Text
        End If
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If TextBox17.Text < 19 Then
            TextBox17.Text = TextBox17.Text + 1
            Label17.Text = TextBox17.Text
        End If
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        If TextBox17.Text > 0 Then
            TextBox17.Text = TextBox17.Text - 1
            Label17.Text = TextBox17.Text
        End If
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        If TextBox18.Text < 19 Then
            TextBox18.Text = TextBox18.Text + 1
            Label18.Text = TextBox18.Text
        End If
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        If TextBox18.Text > 0 Then
            TextBox18.Text = TextBox18.Text - 1
            Label18.Text = TextBox18.Text
        End If
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        If TextBox19.Text < 19 Then
            TextBox19.Text = TextBox19.Text + 1
            Label19.Text = TextBox19.Text
        End If
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        If TextBox19.Text > 0 Then
            TextBox19.Text = TextBox19.Text - 1
            Label19.Text = TextBox19.Text
        End If
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        TextBox20.Text = TextBox20.Text + 1
        Label20.Text = TextBox20.Text
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        If TextBox20.Text > 0 Then
            TextBox20.Text = TextBox20.Text - 1
            Label20.Text = TextBox20.Text
        End If
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        If PictureBox3.Visible = True And PictureBox2.Visible = True And PictureBox1.Visible = True Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            ball_tot = 8
        End If

        If ball_tot = 2 Then
            PictureBox3.Visible = True
            ball_3 = 1
            ball_tot = 4
        End If
        If ball_tot = 1 Then
            PictureBox2.Visible = True
            ball_2 = 1
            ball_tot = 2
        End If
        If ball_tot = 0 Then
            PictureBox1.Visible = True
            ball_1 = 1
            ball_tot = 1
        End If
        If ball_tot = 8 Then
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            ball_tot = 0
            ball_1 = 0
            ball_2 = 0
            ball_3 = 0
            strike_tot = 0
            strike_1 = 0
            strike_2 = 0
        End If

    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        If PictureBox4.Visible = True And PictureBox5.Visible = True Then
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            strike_tot = 3
        End If


        If strike_tot = 1 Then
            PictureBox5.Visible = True
            strike_2 = 1
            strike_tot = 2
        End If
        If strike_tot = 0 Then
            PictureBox4.Visible = True
            strike_1 = 1
            strike_tot = 1
        End If
        If strike_tot = 3 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            ball_tot = 0
            ball_1 = 0
            ball_2 = 0
            ball_3 = 0
            strike_tot = 0
            strike_1 = 0
            strike_2 = 0

        End If

    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        If PictureBox6.Visible = True And PictureBox7.Visible = True Then
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            out_tot = 3
        End If


        If out_tot = 1 Then
            PictureBox7.Visible = True
            out_1 = 1
            out_tot = 2
        End If
        If out_tot = 0 Then
            PictureBox6.Visible = True
            out_2 = 1
            out_tot = 1
        End If
        If out_tot = 3 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            ball_1 = 0
            ball_2 = 0
            ball_3 = 0
            ball_tot = 0
            strike_1 = 0
            strike_2 = 0
            strike_tot = 0
            out_tot = 0
            out_1 = 0
            out_2 = 0
        End If

    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        If PictureBox8.Visible = False Then
            PictureBox8.Visible = True
            hit = 1
        Else
            PictureBox8.Visible = False
            hit = 0

        End If

    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        If PictureBox9.Visible = False Then
            PictureBox9.Visible = True
            errore = 1
        Else
            PictureBox9.Visible = False
            errore = 0
        End If

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim Message As String = "Sei sicuri di cancellare tutti i punteggi?"
        Dim Caption As String = ""
        Dim Buttons As Integer = MessageBoxButtons.YesNo

        Dim Result As DialogResult

        'Displays a MessageBox using the Question icon and specifying the No button as the default.

        Result = MessageBox.Show(Message, Caption, MessageBoxButtons.YesNo)

        ' Gets the result of the MessageBox display.

        If Result = DialogResult.Yes Then



            TextBox1.Text = 0
            TextBox2.Text = 0
            TextBox3.Text = 0
            TextBox4.Text = 0
            TextBox5.Text = 0
            TextBox6.Text = 0
            TextBox7.Text = 0
            TextBox8.Text = 0
            TextBox9.Text = 0
            TextBox10.Text = 0
            TextBox11.Text = 0
            TextBox12.Text = 0
            TextBox13.Text = 0
            TextBox14.Text = 0
            TextBox15.Text = 0
            TextBox16.Text = 0
            TextBox17.Text = 0
            TextBox18.Text = 0
            TextBox19.Text = 0
            TextBox20.Text = 0
            ball_1 = 0
            ball_2 = 0
            ball_3 = 0
            ball_tot = 0
            strike_1 = 0
            strike_2 = 0
            strike_tot = 0
            out_1 = 0
            out_2 = 0
            out_tot = 0
            hit = 0
            errore = 0
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
        End If

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim Testo As String
        Dim FileReader As New System.IO.StreamReader("Guida Generale.txt")
        'Legge l'intero file e lo salva nella variabile "Testo".
        Testo = FileReader.ReadToEnd
        FileReader.Close()
        'Libera le risorse allocate con New.
        FileReader = Nothing
        'txtTesto.Text = Testo
        MsgBox(Testo)

    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        MsgBox("Cartellone segnapunti Fiorentina Baseball Versione1.1")
    End Sub
    Private Sub testo()
        If sTx = "0" Then sTx = "00"
        If sTx = "1" Then sTx = "01"
        If sTx = "2" Then sTx = "02"
        If sTx = "3" Then sTx = "03"
        If sTx = "4" Then sTx = "04"
        If sTx = "5" Then sTx = "05"
        If sTx = "6" Then sTx = "06"
        If sTx = "7" Then sTx = "07"
        If sTx = "8" Then sTx = "08"
        If sTx = "9" Then sTx = "09"


    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        inizio = "f"
        fine = "o"
        If TextBox1.Text > 18 Then
            TextBox1.Text = 19
        End If
        If TextBox2.Text > 18 Then
            TextBox2.Text = 19
        End If
        If TextBox3.Text > 18 Then
            TextBox3.Text = 19
        End If
        If TextBox4.Text > 18 Then
            TextBox4.Text = 19
        End If
        If TextBox5.Text > 18 Then
            TextBox5.Text = 19
        End If
        If TextBox6.Text > 18 Then
            TextBox6.Text = 19
        End If
        If TextBox7.Text > 18 Then
            TextBox7.Text = 19
        End If
        If TextBox8.Text > 18 Then
            TextBox8.Text = 19
        End If
        If TextBox9.Text > 18 Then
            TextBox9.Text = 19
        End If
        If TextBox11.Text > 18 Then
            TextBox11.Text = 19
        End If

        If TextBox12.Text > 18 Then
            TextBox12.Text = 19
        End If
        If TextBox13.Text > 18 Then
            TextBox13.Text = 19
        End If
        If TextBox14.Text > 18 Then
            TextBox14.Text = 19
        End If
        If TextBox15.Text > 18 Then
            TextBox15.Text = 19
        End If
        If TextBox16.Text > 18 Then
            TextBox16.Text = 19
        End If
        If TextBox17.Text > 18 Then
            TextBox17.Text = 19
        End If
        If TextBox18.Text > 18 Then
            TextBox18.Text = 19
        End If
        If TextBox19.Text > 18 Then
            TextBox19.Text = 19
        End If
        Label1.Text = TextBox1.Text
        Label2.Text = TextBox2.Text
        Label3.Text = TextBox3.Text
        Label4.Text = TextBox4.Text
        Label5.Text = TextBox5.Text
        Label6.Text = TextBox6.Text
        Label7.Text = TextBox7.Text
        Label8.Text = TextBox8.Text
        Label9.Text = TextBox9.Text
        Label10.Text = TextBox10.Text
        Label11.Text = TextBox11.Text
        Label12.Text = TextBox12.Text
        Label13.Text = TextBox13.Text
        Label14.Text = TextBox14.Text
        Label15.Text = TextBox15.Text
        Label16.Text = TextBox16.Text
        Label17.Text = TextBox17.Text
        Label18.Text = TextBox18.Text
        Label19.Text = TextBox19.Text
        Label20.Text = TextBox20.Text
        TextBox20.Text = Val(TextBox11.Text) + Val(TextBox12.Text) + Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox18.Text) + Val(TextBox19.Text)
        TextBox10.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text)
        moRS232 = New Rs232
        Try
            '// Setup parameters
            With moRS232
                '.Port = miComPort
                .Port = 4
                '.BaudRate = Int32.Parse(txtBaudrate.Text)
                .BaudRate = 9600
                .DataBit = 8
                .StopBit = Rs232.DataStopBit.StopBit_1

                .Parity = Rs232.DataParity.Parity_None
                '.Timeout = Int32.Parse(txtTimeout.Text)
                .Timeout = 500
            End With
            '// Initializes port
            moRS232.Open()
            '// Set state of RTS / DTS
            'moRS232.Dtr = (chkDTR.CheckState = CheckState.Checked)
            'moRS232.Rts = (chkRTS.CheckState = CheckState.Checked)
            'moRS232.Dtr = True
            'moRS232.Rts = True
            'If chkEvents.Checked Then moRS232.EnableEvents()
            'chkEvents.Enabled = True
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Connection Error", MessageBoxButtons.OK)
        Finally
            'btnCloseCom.Enabled = moRS232.IsOpen
            'btnOpenCom.Enabled = Not moRS232.IsOpen
            'btnTx.Enabled = moRS232.IsOpen
            'btnRx.Enabled = moRS232.IsOpen
            'btnCheck.Enabled = moRS232.IsOpen
        End Try
        'Dim sTx As String
        '----------------------
        '// Clear Tx/Rx Buffers
        moRS232.PurgeBuffer(Rs232.PurgeBuffers.TxClear Or Rs232.PurgeBuffers.RXClear)
        sTx = inizio
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)
        Osp_ing_1 = TextBox1.Text
        If PictureBox1.Visible = True Then Osp_ing_1 = Osp_ing_1 + 20
        sTx = Osp_ing_1
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Osp_ing_2 = null
        If disp2 = 1 Then
            Osp_ing_2 = TextBox2.Text
        End If
        If PictureBox2.Visible = True Then Osp_ing_2 = Osp_ing_2 + 20
        sTx = Osp_ing_2
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Osp_ing_3 = null
        If disp3 = 1 Then
            Osp_ing_3 = TextBox3.Text
        End If
        If PictureBox3.Visible = True Then Osp_ing_3 = Osp_ing_3 + 20
        sTx = Osp_ing_3
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Osp_ing_4 = null
        If disp4 = 1 Then
            Osp_ing_4 = TextBox4.Text
        End If
        If PictureBox4.Visible = True Then Osp_ing_4 = Osp_ing_4 + 20
        sTx = Osp_ing_4
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Osp_ing_5 = null
        If disp5 = 1 Then
            Osp_ing_5 = TextBox5.Text
        End If
        If PictureBox5.Visible = True Then Osp_ing_5 = Osp_ing_5 + 20
        sTx = Osp_ing_5
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Osp_ing_6 = null
        If disp6 = 1 Then
            Osp_ing_6 = TextBox6.Text
        End If
        If PictureBox6.Visible = True Then Osp_ing_6 = Osp_ing_6 + 20
        sTx = Osp_ing_6
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Osp_ing_7 = null
        If disp7 = 1 Then
            Osp_ing_7 = TextBox7.Text
        End If
        If PictureBox7.Visible = True Then Osp_ing_7 = Osp_ing_7 + 20
        sTx = Osp_ing_7
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Osp_ing_8 = null
        If disp8 = 1 Then
            Osp_ing_8 = TextBox8.Text
        End If
        If PictureBox8.Visible = True Then Osp_ing_8 = Osp_ing_8 + 20
        sTx = Osp_ing_8
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Osp_ing_9 = null
        If disp9 = 1 Then
            Osp_ing_9 = TextBox9.Text
        End If
        If PictureBox9.Visible = True Then Osp_ing_9 = Osp_ing_9 + 20
        sTx = Osp_ing_9
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        sTx = TextBox10.Text
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_1 = TextBox11.Text
        'If PictureBox1.Visible = True Then Fir_ing_1 = Fir_ing_1 + 20
        sTx = Fir_ing_1
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_2 = null
        If disp2 = 1 Then
            Fir_ing_2 = TextBox12.Text
        End If
        'If PictureBox2.Visible = True Then Fir_ing_2 = Fir_ing_2 + 20
        sTx = Fir_ing_2
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_3 = null
        If disp3 = 1 Then
            Fir_ing_3 = TextBox13.Text
        End If
        'If PictureBox3.Visible = True Then Fir_ing_3 = Fir_ing_3 + 20
        sTx = Fir_ing_3
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_4 = null
        If disp4 = 1 Then
            Fir_ing_4 = TextBox14.Text
        End If
        'If PictureBox4.Visible = True Then Fir_ing_4 = Fir_ing_4 + 20
        sTx = Fir_ing_4
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_5 = null
        If disp5 = 1 Then
            Fir_ing_5 = TextBox15.Text
        End If
        'If PictureBox5.Visible = True Then Fir_ing_5 = Fir_ing_5 + 20
        sTx = Fir_ing_5
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_6 = null
        If disp6 = 1 Then
            Fir_ing_6 = TextBox16.Text
        End If
        'If PictureBox6.Visible = True Then Fir_ing_6 = Fir_ing_6 + 20
        sTx = Fir_ing_6
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_7 = null
        If disp7 = 1 Then
            Fir_ing_7 = TextBox17.Text
        End If
        'If PictureBox7.Visible = True Then Fir_ing_7 = Fir_ing_7 + 20
        sTx = Fir_ing_7
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_8 = null
        If disp8 = 1 Then
            Fir_ing_8 = TextBox18.Text
        End If
        'If PictureBox8.Visible = True Then Fir_ing_8 = Fir_ing_8 + 20
        sTx = Fir_ing_8
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        Fir_ing_9 = null
        If disp9 = 1 Then
            Fir_ing_9 = TextBox19.Text
        End If
        'If PictureBox9.Visible = True Then Fir_ing_9 = Fir_ing_9 + 20
        sTx = Fir_ing_9
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        sTx = TextBox20.Text
        testo()
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        moRS232.Write(sTx)

        'sTx = ball_1
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        ' sTx = ball_2
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = ball_3
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = ball_tot
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = strike_1
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        ' moRS232.Write(sTx)
        'sTx = strike_2
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = strike_tot
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = out_1
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = out_2
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = out_tot
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = hit
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        'sTx = errore
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        sTx = fine
        'If chkAddCR.Checked Then sTx += ControlChars.Cr
        'moRS232.Write(sTx)
        moRS232.Close()

        Dim file As New System.IO.StreamWriter("data.txt")
        file.WriteLine(TextBox1.Text)
        file.WriteLine(TextBox2.Text)
        file.WriteLine(TextBox3.Text)
        file.WriteLine(TextBox4.Text)
        file.WriteLine(TextBox5.Text)
        file.WriteLine(TextBox6.Text)
        file.WriteLine(TextBox7.Text)
        file.WriteLine(TextBox8.Text)
        file.WriteLine(TextBox9.Text)
        file.WriteLine(TextBox10.Text)
        file.WriteLine(TextBox11.Text)
        file.WriteLine(TextBox12.Text)
        file.WriteLine(TextBox13.Text)
        file.WriteLine(TextBox14.Text)
        file.WriteLine(TextBox15.Text)
        file.WriteLine(TextBox16.Text)
        file.WriteLine(TextBox17.Text)
        file.WriteLine(TextBox18.Text)
        file.WriteLine(TextBox19.Text)
        file.WriteLine(TextBox20.Text)
        file.WriteLine(ball_1)
        file.WriteLine(ball_2)
        file.WriteLine(ball_3)
        file.WriteLine(strike_1)
        file.WriteLine(strike_2)
        file.WriteLine(out_1)
        file.WriteLine(out_2)
        file.WriteLine(hit)
        file.WriteLine(errore)
        file.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub KeyCheck(ByVal sender As Object, _
     ByVal e As KeyPressEventArgs) _
     Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress, TextBox11.KeyPress, TextBox12.KeyPress, TextBox13.KeyPress, TextBox14.KeyPress, TextBox15.KeyPress, TextBox16.KeyPress, TextBox17.KeyPress, TextBox18.KeyPress, TextBox19.KeyPress, TextBox20.KeyPress
        ' Check if the typed character is a number.
        If Char.IsControl(e.KeyChar) = False And _
          Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Puoi inserire solo numeri.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        If disp2 = 1 Then
            disp2 = 0
            Me.Button3.Enabled = False
            Me.Button4.Enabled = False
            Me.Button23.Enabled = False
            Me.Button24.Enabled = False
        Else

            disp2 = 1
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
            Me.Button23.Enabled = True
            Me.Button24.Enabled = True
        End If
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        If (disp3 = 1 Or disp2 = 0) Then
            disp3 = 0
            Me.Button5.Enabled = False
            Me.Button6.Enabled = False
            Me.Button25.Enabled = False
            Me.Button26.Enabled = False
        Else

            disp3 = 1
            Me.Button5.Enabled = True
            Me.Button6.Enabled = True
            Me.Button25.Enabled = True
            Me.Button26.Enabled = True
        End If
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        If (disp4 = 1 Or disp3 = 0 Or disp2 = 0) Then
            disp4 = 0
            Me.Button7.Enabled = False
            Me.Button8.Enabled = False
            Me.Button27.Enabled = False
            Me.Button28.Enabled = False
        Else

            disp4 = 1
            Me.Button7.Enabled = True
            Me.Button8.Enabled = True
            Me.Button27.Enabled = True
            Me.Button28.Enabled = True
        End If
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        If (disp5 = 1 Or disp4 = 0 Or disp3 = 0 Or disp2 = 0) Then
            disp5 = 0
            Me.Button9.Enabled = False
            Me.Button10.Enabled = False
            Me.Button29.Enabled = False
            Me.Button30.Enabled = False
        Else

            disp5 = 1
            Me.Button9.Enabled = True
            Me.Button10.Enabled = True
            Me.Button29.Enabled = True
            Me.Button30.Enabled = True
        End If
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        If (disp6 = 1 Or disp5 = 0 Or disp4 = 0 Or disp3 = 0 Or disp2 = 0) Then
            disp6 = 0
            Me.Button11.Enabled = False
            Me.Button12.Enabled = False
            Me.Button31.Enabled = False
            Me.Button32.Enabled = False
        Else

            disp6 = 1
            Me.Button11.Enabled = True
            Me.Button12.Enabled = True
            Me.Button31.Enabled = True
            Me.Button32.Enabled = True
        End If
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        If (disp7 = 1 Or disp6 = 0 Or disp5 = 1 Or disp4 = 0 Or disp3 = 0 Or disp2 = 0) Then
            disp7 = 0
            Me.Button13.Enabled = False
            Me.Button14.Enabled = False
            Me.Button33.Enabled = False
            Me.Button34.Enabled = False
        Else

            disp7 = 1
            Me.Button13.Enabled = True
            Me.Button14.Enabled = True
            Me.Button33.Enabled = True
            Me.Button34.Enabled = True
        End If
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        If (disp8 = 1 Or disp7 = 0 Or disp6 = 1 Or disp5 = 1 Or disp4 = 0 Or disp3 = 0 Or disp2 = 0) Then
            disp8 = 0
            Me.Button15.Enabled = False
            Me.Button16.Enabled = False
            Me.Button35.Enabled = False
            Me.Button36.Enabled = False
        Else

            disp8 = 1
            Me.Button15.Enabled = True
            Me.Button16.Enabled = True
            Me.Button35.Enabled = True
            Me.Button36.Enabled = True
        End If
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        If (disp9 = 1 Or disp8 = 0 Or disp7 = 1 Or disp6 = 1 Or disp5 = 1 Or disp4 = 0 Or disp3 = 0 Or disp2 = 0) Then
            disp9 = 0
            Me.Button17.Enabled = False
            Me.Button18.Enabled = False
            Me.Button37.Enabled = False
            Me.Button38.Enabled = False
        Else

            disp6 = 1
            Me.Button17.Enabled = True
            Me.Button18.Enabled = True
            Me.Button37.Enabled = True
            Me.Button38.Enabled = True
        End If
    End Sub
End Class
