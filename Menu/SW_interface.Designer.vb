<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SW_interface
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.CbxOwnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewPJDataSet = New VipDesignerUM.NewPJDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cbx_OwnerTableAdapter = New VipDesignerUM.NewPJDataSetTableAdapters.cbx_OwnerTableAdapter()
        Me.cbx_diametro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DiametriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseSWDataSet1 = New VipDesignerUM.DataBaseSWDataSet1()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_angolo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.AngoloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbx_motore = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.MotoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseSWDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseSWDataSet = New VipDesignerUM.DataBaseSWDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_ventilatore = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.VentilatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_ventola = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SerieVentolaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbx_flusso = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Check1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check3 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check4 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check5 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check6 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check7 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.SerieVentolaTableAdapter = New VipDesignerUM.DataBaseSWDataSetTableAdapters.SerieVentolaTableAdapter()
        Me.MotoreTableAdapter = New VipDesignerUM.DataBaseSWDataSetTableAdapters.MotoreTableAdapter()
        Me.VentilatoriTableAdapter = New VipDesignerUM.DataBaseSWDataSetTableAdapters.VentilatoriTableAdapter()
        Me.Pan1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbx_marca = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lab_piedini = New System.Windows.Forms.Label()
        Me.cbx_piedini = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lab_cappello = New System.Windows.Forms.Label()
        Me.cbx_cappello = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbx_ventilazione = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lab_ventilaione = New System.Windows.Forms.Label()
        Me.cbx_unificato = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lab_unificato = New System.Windows.Forms.Label()
        Me.MarcaMotoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseSWDataSet15 = New VipDesignerUM.DataBaseSWDataSet15()
        Me.cbx_pala = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TipoPalaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseSWDataSet12 = New VipDesignerUM.DataBaseSWDataSet12()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pan2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbx_cestello = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TipoCestelloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseSWDataSet14 = New VipDesignerUM.DataBaseSWDataSet14()
        Me.Pan3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Check15 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check16 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check17 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check21 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check18 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check20 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check19 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check8 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check9 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check10 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check14 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check11 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check13 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Check12 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.DataBaseSWDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBaseSWDataSet1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiametriTableAdapter = New VipDesignerUM.DataBaseSWDataSet1TableAdapters.DiametriTableAdapter()
        Me.DataBaseSWDataSet1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AngoloTableAdapter = New VipDesignerUM.DataBaseSWDataSet1TableAdapters.AngoloTableAdapter()
        Me.btnOpenSW = New Guna.UI2.WinForms.Guna2Button()
        Me.TipoPalaTableAdapter = New VipDesignerUM.DataBaseSWDataSet12TableAdapters.TipoPalaTableAdapter()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnSegnala = New Guna.UI2.WinForms.Guna2Button()
        Me.TipoCestelloTableAdapter = New VipDesignerUM.DataBaseSWDataSet14TableAdapters.TipoCestelloTableAdapter()
        Me.btnTestaFan = New Guna.UI2.WinForms.Guna2Button()
        Me.MarcaMotoreTableAdapter = New VipDesignerUM.DataBaseSWDataSet15TableAdapters.MarcaMotoreTableAdapter()
        Me.lab_marca = New System.Windows.Forms.Label()
        CType(Me.CbxOwnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewPJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiametriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseSWDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AngoloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseSWDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseSWDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentilatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerieVentolaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan1.SuspendLayout()
        CType(Me.MarcaMotoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseSWDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoPalaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseSWDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan2.SuspendLayout()
        CType(Me.TipoCestelloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseSWDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan3.SuspendLayout()
        CType(Me.DataBaseSWDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseSWDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBaseSWDataSet1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(-187, 306)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 28)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "AGGIORNA"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'CbxOwnerBindingSource
        '
        Me.CbxOwnerBindingSource.DataMember = "cbx_Owner"
        Me.CbxOwnerBindingSource.DataSource = Me.NewPJDataSet
        '
        'NewPJDataSet
        '
        Me.NewPJDataSet.DataSetName = "NewPJDataSet"
        Me.NewPJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cbx_OwnerTableAdapter
        '
        Me.Cbx_OwnerTableAdapter.ClearBeforeFill = True
        '
        'cbx_diametro
        '
        Me.cbx_diametro.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_diametro.BorderColor = System.Drawing.Color.Black
        Me.cbx_diametro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_diametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_diametro.DropDownWidth = 200
        Me.cbx_diametro.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_diametro.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_diametro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_diametro.FocusedState.Parent = Me.cbx_diametro
        Me.cbx_diametro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_diametro.ForeColor = System.Drawing.Color.Black
        Me.cbx_diametro.HoverState.Parent = Me.cbx_diametro
        Me.cbx_diametro.ItemHeight = 16
        Me.cbx_diametro.ItemsAppearance.Parent = Me.cbx_diametro
        Me.cbx_diametro.Location = New System.Drawing.Point(181, 6)
        Me.cbx_diametro.Name = "cbx_diametro"
        Me.cbx_diametro.ShadowDecoration.Parent = Me.cbx_diametro
        Me.cbx_diametro.Size = New System.Drawing.Size(259, 22)
        Me.cbx_diametro.TabIndex = 33
        '
        'DiametriBindingSource
        '
        Me.DiametriBindingSource.DataMember = "Diametri"
        Me.DiametriBindingSource.DataSource = Me.DataBaseSWDataSet1
        '
        'DataBaseSWDataSet1
        '
        Me.DataBaseSWDataSet1.DataSetName = "DataBaseSWDataSet1"
        Me.DataBaseSWDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(2, 7)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 19)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "Diametro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 19)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Angolo calettamento"
        '
        'cbx_angolo
        '
        Me.cbx_angolo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_angolo.BorderColor = System.Drawing.Color.Black
        Me.cbx_angolo.DataSource = Me.AngoloBindingSource
        Me.cbx_angolo.DisplayMember = "Angolo"
        Me.cbx_angolo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_angolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_angolo.DropDownWidth = 200
        Me.cbx_angolo.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_angolo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_angolo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_angolo.FocusedState.Parent = Me.cbx_angolo
        Me.cbx_angolo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_angolo.ForeColor = System.Drawing.Color.Black
        Me.cbx_angolo.HoverState.Parent = Me.cbx_angolo
        Me.cbx_angolo.ItemHeight = 16
        Me.cbx_angolo.ItemsAppearance.Parent = Me.cbx_angolo
        Me.cbx_angolo.Location = New System.Drawing.Point(181, 52)
        Me.cbx_angolo.Name = "cbx_angolo"
        Me.cbx_angolo.ShadowDecoration.Parent = Me.cbx_angolo
        Me.cbx_angolo.Size = New System.Drawing.Size(259, 22)
        Me.cbx_angolo.TabIndex = 120
        '
        'AngoloBindingSource
        '
        Me.AngoloBindingSource.DataMember = "Angolo"
        Me.AngoloBindingSource.DataSource = Me.DataBaseSWDataSet1
        '
        'cbx_motore
        '
        Me.cbx_motore.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_motore.BorderColor = System.Drawing.Color.Black
        Me.cbx_motore.DataSource = Me.MotoreBindingSource
        Me.cbx_motore.DisplayMember = "TipoMotore"
        Me.cbx_motore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_motore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_motore.DropDownWidth = 200
        Me.cbx_motore.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_motore.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_motore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_motore.FocusedState.Parent = Me.cbx_motore
        Me.cbx_motore.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_motore.ForeColor = System.Drawing.Color.Black
        Me.cbx_motore.HoverState.Parent = Me.cbx_motore
        Me.cbx_motore.ItemHeight = 16
        Me.cbx_motore.ItemsAppearance.Parent = Me.cbx_motore
        Me.cbx_motore.Location = New System.Drawing.Point(183, 80)
        Me.cbx_motore.Name = "cbx_motore"
        Me.cbx_motore.ShadowDecoration.Parent = Me.cbx_motore
        Me.cbx_motore.Size = New System.Drawing.Size(259, 22)
        Me.cbx_motore.TabIndex = 121
        '
        'MotoreBindingSource
        '
        Me.MotoreBindingSource.DataMember = "Motore"
        Me.MotoreBindingSource.DataSource = Me.DataBaseSWDataSetBindingSource
        '
        'DataBaseSWDataSetBindingSource
        '
        Me.DataBaseSWDataSetBindingSource.DataSource = Me.DataBaseSWDataSet
        Me.DataBaseSWDataSetBindingSource.Position = 0
        '
        'DataBaseSWDataSet
        '
        Me.DataBaseSWDataSet.DataSetName = "DataBaseSWDataSet"
        Me.DataBaseSWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(2, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 19)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Configurazione ventilatore"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(2, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Serie motore"
        '
        'cbx_ventilatore
        '
        Me.cbx_ventilatore.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_ventilatore.BorderColor = System.Drawing.Color.Black
        Me.cbx_ventilatore.DataSource = Me.VentilatoriBindingSource
        Me.cbx_ventilatore.DisplayMember = "TipoVentilatore"
        Me.cbx_ventilatore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_ventilatore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_ventilatore.DropDownWidth = 200
        Me.cbx_ventilatore.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_ventilatore.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_ventilatore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_ventilatore.FocusedState.Parent = Me.cbx_ventilatore
        Me.cbx_ventilatore.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_ventilatore.ForeColor = System.Drawing.Color.Black
        Me.cbx_ventilatore.HoverState.Parent = Me.cbx_ventilatore
        Me.cbx_ventilatore.ItemHeight = 16
        Me.cbx_ventilatore.ItemsAppearance.Parent = Me.cbx_ventilatore
        Me.cbx_ventilatore.Location = New System.Drawing.Point(183, 34)
        Me.cbx_ventilatore.Name = "cbx_ventilatore"
        Me.cbx_ventilatore.ShadowDecoration.Parent = Me.cbx_ventilatore
        Me.cbx_ventilatore.Size = New System.Drawing.Size(259, 22)
        Me.cbx_ventilatore.TabIndex = 124
        '
        'VentilatoriBindingSource
        '
        Me.VentilatoriBindingSource.DataMember = "Ventilatori"
        Me.VentilatoriBindingSource.DataSource = Me.DataBaseSWDataSetBindingSource
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(2, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Serie ventola"
        '
        'cbx_ventola
        '
        Me.cbx_ventola.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_ventola.BorderColor = System.Drawing.Color.Black
        Me.cbx_ventola.DataSource = Me.SerieVentolaBindingSource
        Me.cbx_ventola.DisplayMember = "TipoVentola"
        Me.cbx_ventola.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_ventola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_ventola.DropDownWidth = 200
        Me.cbx_ventola.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_ventola.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_ventola.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_ventola.FocusedState.Parent = Me.cbx_ventola
        Me.cbx_ventola.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_ventola.ForeColor = System.Drawing.Color.Black
        Me.cbx_ventola.HoverState.Parent = Me.cbx_ventola
        Me.cbx_ventola.ItemHeight = 16
        Me.cbx_ventola.ItemsAppearance.Parent = Me.cbx_ventola
        Me.cbx_ventola.Location = New System.Drawing.Point(183, 11)
        Me.cbx_ventola.Name = "cbx_ventola"
        Me.cbx_ventola.ShadowDecoration.Parent = Me.cbx_ventola
        Me.cbx_ventola.Size = New System.Drawing.Size(259, 22)
        Me.cbx_ventola.TabIndex = 126
        '
        'SerieVentolaBindingSource
        '
        Me.SerieVentolaBindingSource.DataMember = "SerieVentola"
        Me.SerieVentolaBindingSource.DataSource = Me.DataBaseSWDataSet
        '
        'cbx_flusso
        '
        Me.cbx_flusso.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_flusso.BorderColor = System.Drawing.Color.Black
        Me.cbx_flusso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_flusso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_flusso.DropDownWidth = 200
        Me.cbx_flusso.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_flusso.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_flusso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_flusso.FocusedState.Parent = Me.cbx_flusso
        Me.cbx_flusso.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_flusso.ForeColor = System.Drawing.Color.Black
        Me.cbx_flusso.HoverState.Parent = Me.cbx_flusso
        Me.cbx_flusso.ItemHeight = 16
        Me.cbx_flusso.Items.AddRange(New Object() {"A", "P", "R"})
        Me.cbx_flusso.ItemsAppearance.Parent = Me.cbx_flusso
        Me.cbx_flusso.Location = New System.Drawing.Point(183, 57)
        Me.cbx_flusso.Name = "cbx_flusso"
        Me.cbx_flusso.ShadowDecoration.Parent = Me.cbx_flusso
        Me.cbx_flusso.Size = New System.Drawing.Size(259, 22)
        Me.cbx_flusso.TabIndex = 128
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(1, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Flusso"
        '
        'Check1
        '
        Me.Check1.AutoSize = True
        Me.Check1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check1.CheckedState.BorderRadius = 0
        Me.Check1.CheckedState.BorderThickness = 0
        Me.Check1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check1.Location = New System.Drawing.Point(18, 16)
        Me.Check1.Name = "Check1"
        Me.Check1.Size = New System.Drawing.Size(15, 14)
        Me.Check1.TabIndex = 131
        Me.Check1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check1.UncheckedState.BorderRadius = 0
        Me.Check1.UncheckedState.BorderThickness = 0
        Me.Check1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check2
        '
        Me.Check2.AutoSize = True
        Me.Check2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check2.CheckedState.BorderRadius = 0
        Me.Check2.CheckedState.BorderThickness = 0
        Me.Check2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check2.Location = New System.Drawing.Point(18, 41)
        Me.Check2.Name = "Check2"
        Me.Check2.Size = New System.Drawing.Size(15, 14)
        Me.Check2.TabIndex = 132
        Me.Check2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check2.UncheckedState.BorderRadius = 0
        Me.Check2.UncheckedState.BorderThickness = 0
        Me.Check2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check3
        '
        Me.Check3.AutoSize = True
        Me.Check3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check3.CheckedState.BorderRadius = 0
        Me.Check3.CheckedState.BorderThickness = 0
        Me.Check3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check3.Location = New System.Drawing.Point(18, 66)
        Me.Check3.Name = "Check3"
        Me.Check3.Size = New System.Drawing.Size(15, 14)
        Me.Check3.TabIndex = 133
        Me.Check3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check3.UncheckedState.BorderRadius = 0
        Me.Check3.UncheckedState.BorderThickness = 0
        Me.Check3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check4
        '
        Me.Check4.AutoSize = True
        Me.Check4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check4.CheckedState.BorderRadius = 0
        Me.Check4.CheckedState.BorderThickness = 0
        Me.Check4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check4.Location = New System.Drawing.Point(18, 91)
        Me.Check4.Name = "Check4"
        Me.Check4.Size = New System.Drawing.Size(15, 14)
        Me.Check4.TabIndex = 134
        Me.Check4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check4.UncheckedState.BorderRadius = 0
        Me.Check4.UncheckedState.BorderThickness = 0
        Me.Check4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check5
        '
        Me.Check5.AutoSize = True
        Me.Check5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check5.CheckedState.BorderRadius = 0
        Me.Check5.CheckedState.BorderThickness = 0
        Me.Check5.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check5.Location = New System.Drawing.Point(18, 116)
        Me.Check5.Name = "Check5"
        Me.Check5.Size = New System.Drawing.Size(15, 14)
        Me.Check5.TabIndex = 135
        Me.Check5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check5.UncheckedState.BorderRadius = 0
        Me.Check5.UncheckedState.BorderThickness = 0
        Me.Check5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check6
        '
        Me.Check6.AutoSize = True
        Me.Check6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check6.CheckedState.BorderRadius = 0
        Me.Check6.CheckedState.BorderThickness = 0
        Me.Check6.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check6.Location = New System.Drawing.Point(18, 141)
        Me.Check6.Name = "Check6"
        Me.Check6.Size = New System.Drawing.Size(15, 14)
        Me.Check6.TabIndex = 136
        Me.Check6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check6.UncheckedState.BorderRadius = 0
        Me.Check6.UncheckedState.BorderThickness = 0
        Me.Check6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check7
        '
        Me.Check7.AutoSize = True
        Me.Check7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check7.CheckedState.BorderRadius = 0
        Me.Check7.CheckedState.BorderThickness = 0
        Me.Check7.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check7.Location = New System.Drawing.Point(18, 166)
        Me.Check7.Name = "Check7"
        Me.Check7.Size = New System.Drawing.Size(15, 14)
        Me.Check7.TabIndex = 137
        Me.Check7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check7.UncheckedState.BorderRadius = 0
        Me.Check7.UncheckedState.BorderThickness = 0
        Me.Check7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'SerieVentolaTableAdapter
        '
        Me.SerieVentolaTableAdapter.ClearBeforeFill = True
        '
        'MotoreTableAdapter
        '
        Me.MotoreTableAdapter.ClearBeforeFill = True
        '
        'VentilatoriTableAdapter
        '
        Me.VentilatoriTableAdapter.ClearBeforeFill = True
        '
        'Pan1
        '
        Me.Pan1.Controls.Add(Me.lab_marca)
        Me.Pan1.Controls.Add(Me.cbx_marca)
        Me.Pan1.Controls.Add(Me.lab_piedini)
        Me.Pan1.Controls.Add(Me.cbx_piedini)
        Me.Pan1.Controls.Add(Me.lab_cappello)
        Me.Pan1.Controls.Add(Me.cbx_cappello)
        Me.Pan1.Controls.Add(Me.cbx_ventilazione)
        Me.Pan1.Controls.Add(Me.lab_ventilaione)
        Me.Pan1.Controls.Add(Me.cbx_unificato)
        Me.Pan1.Controls.Add(Me.lab_unificato)
        Me.Pan1.Controls.Add(Me.Label4)
        Me.Pan1.Controls.Add(Me.cbx_motore)
        Me.Pan1.Controls.Add(Me.Label2)
        Me.Pan1.Controls.Add(Me.Label3)
        Me.Pan1.Controls.Add(Me.cbx_ventilatore)
        Me.Pan1.Controls.Add(Me.cbx_ventola)
        Me.Pan1.Controls.Add(Me.cbx_flusso)
        Me.Pan1.Controls.Add(Me.Label6)
        Me.Pan1.Location = New System.Drawing.Point(6, 8)
        Me.Pan1.Name = "Pan1"
        Me.Pan1.ShadowDecoration.Parent = Me.Pan1
        Me.Pan1.Size = New System.Drawing.Size(932, 131)
        Me.Pan1.TabIndex = 138
        '
        'cbx_marca
        '
        Me.cbx_marca.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_marca.BorderColor = System.Drawing.Color.Black
        Me.cbx_marca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_marca.DropDownWidth = 200
        Me.cbx_marca.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_marca.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_marca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_marca.FocusedState.Parent = Me.cbx_marca
        Me.cbx_marca.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_marca.ForeColor = System.Drawing.Color.Black
        Me.cbx_marca.HoverState.Parent = Me.cbx_marca
        Me.cbx_marca.ItemHeight = 16
        Me.cbx_marca.ItemsAppearance.Parent = Me.cbx_marca
        Me.cbx_marca.Location = New System.Drawing.Point(183, 103)
        Me.cbx_marca.Name = "cbx_marca"
        Me.cbx_marca.ShadowDecoration.Parent = Me.cbx_marca
        Me.cbx_marca.Size = New System.Drawing.Size(259, 22)
        Me.cbx_marca.TabIndex = 140
        Me.cbx_marca.Visible = False
        '
        'lab_piedini
        '
        Me.lab_piedini.AutoSize = True
        Me.lab_piedini.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lab_piedini.Location = New System.Drawing.Point(446, 79)
        Me.lab_piedini.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_piedini.Name = "lab_piedini"
        Me.lab_piedini.Size = New System.Drawing.Size(49, 19)
        Me.lab_piedini.TabIndex = 139
        Me.lab_piedini.Text = "Piedini"
        Me.lab_piedini.Visible = False
        '
        'cbx_piedini
        '
        Me.cbx_piedini.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_piedini.BorderColor = System.Drawing.Color.Black
        Me.cbx_piedini.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_piedini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_piedini.DropDownWidth = 200
        Me.cbx_piedini.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_piedini.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_piedini.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_piedini.FocusedState.Parent = Me.cbx_piedini
        Me.cbx_piedini.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_piedini.ForeColor = System.Drawing.Color.Black
        Me.cbx_piedini.HoverState.Parent = Me.cbx_piedini
        Me.cbx_piedini.ItemHeight = 16
        Me.cbx_piedini.Items.AddRange(New Object() {"Senza piedini", "Con piedini"})
        Me.cbx_piedini.ItemsAppearance.Parent = Me.cbx_piedini
        Me.cbx_piedini.Location = New System.Drawing.Point(544, 80)
        Me.cbx_piedini.Name = "cbx_piedini"
        Me.cbx_piedini.ShadowDecoration.Parent = Me.cbx_piedini
        Me.cbx_piedini.Size = New System.Drawing.Size(259, 22)
        Me.cbx_piedini.StartIndex = 0
        Me.cbx_piedini.TabIndex = 138
        Me.cbx_piedini.Visible = False
        '
        'lab_cappello
        '
        Me.lab_cappello.AutoSize = True
        Me.lab_cappello.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lab_cappello.Location = New System.Drawing.Point(446, 56)
        Me.lab_cappello.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_cappello.Name = "lab_cappello"
        Me.lab_cappello.Size = New System.Drawing.Size(62, 19)
        Me.lab_cappello.TabIndex = 137
        Me.lab_cappello.Text = "Cappello"
        Me.lab_cappello.Visible = False
        '
        'cbx_cappello
        '
        Me.cbx_cappello.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_cappello.BorderColor = System.Drawing.Color.Black
        Me.cbx_cappello.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_cappello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_cappello.DropDownWidth = 200
        Me.cbx_cappello.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_cappello.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_cappello.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_cappello.FocusedState.Parent = Me.cbx_cappello
        Me.cbx_cappello.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_cappello.ForeColor = System.Drawing.Color.Black
        Me.cbx_cappello.HoverState.Parent = Me.cbx_cappello
        Me.cbx_cappello.ItemHeight = 16
        Me.cbx_cappello.Items.AddRange(New Object() {"Senza cappello parapioggia", "Con cappello parapioggia"})
        Me.cbx_cappello.ItemsAppearance.Parent = Me.cbx_cappello
        Me.cbx_cappello.Location = New System.Drawing.Point(544, 57)
        Me.cbx_cappello.Name = "cbx_cappello"
        Me.cbx_cappello.ShadowDecoration.Parent = Me.cbx_cappello
        Me.cbx_cappello.Size = New System.Drawing.Size(259, 22)
        Me.cbx_cappello.StartIndex = 0
        Me.cbx_cappello.TabIndex = 136
        Me.cbx_cappello.Visible = False
        '
        'cbx_ventilazione
        '
        Me.cbx_ventilazione.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_ventilazione.BorderColor = System.Drawing.Color.Black
        Me.cbx_ventilazione.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_ventilazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_ventilazione.DropDownWidth = 200
        Me.cbx_ventilazione.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_ventilazione.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_ventilazione.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_ventilazione.FocusedState.Parent = Me.cbx_ventilazione
        Me.cbx_ventilazione.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_ventilazione.ForeColor = System.Drawing.Color.Black
        Me.cbx_ventilazione.HoverState.Parent = Me.cbx_ventilazione
        Me.cbx_ventilazione.ItemHeight = 16
        Me.cbx_ventilazione.Items.AddRange(New Object() {"IC 418 - Non ventilato", "IC 411 - Ventilazione forzata"})
        Me.cbx_ventilazione.ItemsAppearance.Parent = Me.cbx_ventilazione
        Me.cbx_ventilazione.Location = New System.Drawing.Point(544, 34)
        Me.cbx_ventilazione.Name = "cbx_ventilazione"
        Me.cbx_ventilazione.ShadowDecoration.Parent = Me.cbx_ventilazione
        Me.cbx_ventilazione.Size = New System.Drawing.Size(259, 22)
        Me.cbx_ventilazione.StartIndex = 0
        Me.cbx_ventilazione.TabIndex = 135
        Me.cbx_ventilazione.Visible = False
        '
        'lab_ventilaione
        '
        Me.lab_ventilaione.AutoSize = True
        Me.lab_ventilaione.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lab_ventilaione.Location = New System.Drawing.Point(447, 36)
        Me.lab_ventilaione.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_ventilaione.Name = "lab_ventilaione"
        Me.lab_ventilaione.Size = New System.Drawing.Size(82, 19)
        Me.lab_ventilaione.TabIndex = 134
        Me.lab_ventilaione.Text = "Ventilazione"
        Me.lab_ventilaione.Visible = False
        '
        'cbx_unificato
        '
        Me.cbx_unificato.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_unificato.BorderColor = System.Drawing.Color.Black
        Me.cbx_unificato.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_unificato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_unificato.DropDownWidth = 200
        Me.cbx_unificato.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_unificato.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_unificato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_unificato.FocusedState.Parent = Me.cbx_unificato
        Me.cbx_unificato.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_unificato.ForeColor = System.Drawing.Color.Black
        Me.cbx_unificato.HoverState.Parent = Me.cbx_unificato
        Me.cbx_unificato.ItemHeight = 16
        Me.cbx_unificato.ItemsAppearance.Parent = Me.cbx_unificato
        Me.cbx_unificato.Location = New System.Drawing.Point(544, 11)
        Me.cbx_unificato.Name = "cbx_unificato"
        Me.cbx_unificato.ShadowDecoration.Parent = Me.cbx_unificato
        Me.cbx_unificato.Size = New System.Drawing.Size(259, 22)
        Me.cbx_unificato.TabIndex = 133
        Me.cbx_unificato.Visible = False
        '
        'lab_unificato
        '
        Me.lab_unificato.AutoSize = True
        Me.lab_unificato.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lab_unificato.Location = New System.Drawing.Point(446, 14)
        Me.lab_unificato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_unificato.Name = "lab_unificato"
        Me.lab_unificato.Size = New System.Drawing.Size(84, 19)
        Me.lab_unificato.TabIndex = 132
        Me.lab_unificato.Text = "Tipo motore"
        Me.lab_unificato.Visible = False
        '
        'MarcaMotoreBindingSource
        '
        Me.MarcaMotoreBindingSource.DataMember = "MarcaMotore"
        Me.MarcaMotoreBindingSource.DataSource = Me.DataBaseSWDataSet15
        '
        'DataBaseSWDataSet15
        '
        Me.DataBaseSWDataSet15.DataSetName = "DataBaseSWDataSet15"
        Me.DataBaseSWDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbx_pala
        '
        Me.cbx_pala.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_pala.BorderColor = System.Drawing.Color.Black
        Me.cbx_pala.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_pala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_pala.DropDownWidth = 200
        Me.cbx_pala.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_pala.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_pala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_pala.FocusedState.Parent = Me.cbx_pala
        Me.cbx_pala.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_pala.ForeColor = System.Drawing.Color.Black
        Me.cbx_pala.HoverState.Parent = Me.cbx_pala
        Me.cbx_pala.ItemHeight = 16
        Me.cbx_pala.ItemsAppearance.Parent = Me.cbx_pala
        Me.cbx_pala.Location = New System.Drawing.Point(181, 29)
        Me.cbx_pala.Name = "cbx_pala"
        Me.cbx_pala.ShadowDecoration.Parent = Me.cbx_pala
        Me.cbx_pala.Size = New System.Drawing.Size(259, 22)
        Me.cbx_pala.TabIndex = 132
        '
        'TipoPalaBindingSource
        '
        Me.TipoPalaBindingSource.DataMember = "TipoPala"
        Me.TipoPalaBindingSource.DataSource = Me.DataBaseSWDataSet12
        '
        'DataBaseSWDataSet12
        '
        Me.DataBaseSWDataSet12.DataSetName = "DataBaseSWDataSet12"
        Me.DataBaseSWDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(2, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Tipo pala"
        '
        'Pan2
        '
        Me.Pan2.Controls.Add(Me.cbx_pala)
        Me.Pan2.Controls.Add(Me.Label5)
        Me.Pan2.Controls.Add(Me.cbx_cestello)
        Me.Pan2.Controls.Add(Me.Label7)
        Me.Pan2.Controls.Add(Me.Label18)
        Me.Pan2.Controls.Add(Me.cbx_diametro)
        Me.Pan2.Controls.Add(Me.Label1)
        Me.Pan2.Controls.Add(Me.cbx_angolo)
        Me.Pan2.Location = New System.Drawing.Point(6, 141)
        Me.Pan2.Name = "Pan2"
        Me.Pan2.ShadowDecoration.Parent = Me.Pan2
        Me.Pan2.Size = New System.Drawing.Size(932, 100)
        Me.Pan2.TabIndex = 139
        Me.Pan2.Visible = False
        '
        'cbx_cestello
        '
        Me.cbx_cestello.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_cestello.BorderColor = System.Drawing.Color.Black
        Me.cbx_cestello.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_cestello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_cestello.DropDownWidth = 200
        Me.cbx_cestello.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cbx_cestello.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_cestello.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_cestello.FocusedState.Parent = Me.cbx_cestello
        Me.cbx_cestello.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_cestello.ForeColor = System.Drawing.Color.Black
        Me.cbx_cestello.HoverState.Parent = Me.cbx_cestello
        Me.cbx_cestello.ItemHeight = 16
        Me.cbx_cestello.ItemsAppearance.Parent = Me.cbx_cestello
        Me.cbx_cestello.Location = New System.Drawing.Point(181, 75)
        Me.cbx_cestello.Name = "cbx_cestello"
        Me.cbx_cestello.ShadowDecoration.Parent = Me.cbx_cestello
        Me.cbx_cestello.Size = New System.Drawing.Size(259, 22)
        Me.cbx_cestello.TabIndex = 122
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(3, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Cestello"
        '
        'TipoCestelloBindingSource
        '
        Me.TipoCestelloBindingSource.DataMember = "TipoCestello"
        Me.TipoCestelloBindingSource.DataSource = Me.DataBaseSWDataSet14
        '
        'DataBaseSWDataSet14
        '
        Me.DataBaseSWDataSet14.DataSetName = "DataBaseSWDataSet14"
        Me.DataBaseSWDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pan3
        '
        Me.Pan3.Controls.Add(Me.Check15)
        Me.Pan3.Controls.Add(Me.Check16)
        Me.Pan3.Controls.Add(Me.Check17)
        Me.Pan3.Controls.Add(Me.Check21)
        Me.Pan3.Controls.Add(Me.Check18)
        Me.Pan3.Controls.Add(Me.Check20)
        Me.Pan3.Controls.Add(Me.Check19)
        Me.Pan3.Controls.Add(Me.Check8)
        Me.Pan3.Controls.Add(Me.Check9)
        Me.Pan3.Controls.Add(Me.Check10)
        Me.Pan3.Controls.Add(Me.Check14)
        Me.Pan3.Controls.Add(Me.Check11)
        Me.Pan3.Controls.Add(Me.Check13)
        Me.Pan3.Controls.Add(Me.Check12)
        Me.Pan3.Controls.Add(Me.Check1)
        Me.Pan3.Controls.Add(Me.Check2)
        Me.Pan3.Controls.Add(Me.Check3)
        Me.Pan3.Controls.Add(Me.Check7)
        Me.Pan3.Controls.Add(Me.Check4)
        Me.Pan3.Controls.Add(Me.Check6)
        Me.Pan3.Controls.Add(Me.Check5)
        Me.Pan3.Location = New System.Drawing.Point(6, 243)
        Me.Pan3.Name = "Pan3"
        Me.Pan3.ShadowDecoration.Parent = Me.Pan3
        Me.Pan3.Size = New System.Drawing.Size(932, 209)
        Me.Pan3.TabIndex = 140
        Me.Pan3.Visible = False
        '
        'Check15
        '
        Me.Check15.AutoSize = True
        Me.Check15.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check15.CheckedState.BorderRadius = 0
        Me.Check15.CheckedState.BorderThickness = 0
        Me.Check15.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check15.Location = New System.Drawing.Point(422, 16)
        Me.Check15.Name = "Check15"
        Me.Check15.Size = New System.Drawing.Size(15, 14)
        Me.Check15.TabIndex = 145
        Me.Check15.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check15.UncheckedState.BorderRadius = 0
        Me.Check15.UncheckedState.BorderThickness = 0
        Me.Check15.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check16
        '
        Me.Check16.AutoSize = True
        Me.Check16.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check16.CheckedState.BorderRadius = 0
        Me.Check16.CheckedState.BorderThickness = 0
        Me.Check16.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check16.Location = New System.Drawing.Point(422, 41)
        Me.Check16.Name = "Check16"
        Me.Check16.Size = New System.Drawing.Size(15, 14)
        Me.Check16.TabIndex = 146
        Me.Check16.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check16.UncheckedState.BorderRadius = 0
        Me.Check16.UncheckedState.BorderThickness = 0
        Me.Check16.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check17
        '
        Me.Check17.AutoSize = True
        Me.Check17.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check17.CheckedState.BorderRadius = 0
        Me.Check17.CheckedState.BorderThickness = 0
        Me.Check17.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check17.Location = New System.Drawing.Point(422, 66)
        Me.Check17.Name = "Check17"
        Me.Check17.Size = New System.Drawing.Size(15, 14)
        Me.Check17.TabIndex = 147
        Me.Check17.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check17.UncheckedState.BorderRadius = 0
        Me.Check17.UncheckedState.BorderThickness = 0
        Me.Check17.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check21
        '
        Me.Check21.AutoSize = True
        Me.Check21.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check21.CheckedState.BorderRadius = 0
        Me.Check21.CheckedState.BorderThickness = 0
        Me.Check21.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check21.Location = New System.Drawing.Point(422, 166)
        Me.Check21.Name = "Check21"
        Me.Check21.Size = New System.Drawing.Size(15, 14)
        Me.Check21.TabIndex = 151
        Me.Check21.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check21.UncheckedState.BorderRadius = 0
        Me.Check21.UncheckedState.BorderThickness = 0
        Me.Check21.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check18
        '
        Me.Check18.AutoSize = True
        Me.Check18.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check18.CheckedState.BorderRadius = 0
        Me.Check18.CheckedState.BorderThickness = 0
        Me.Check18.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check18.Location = New System.Drawing.Point(422, 91)
        Me.Check18.Name = "Check18"
        Me.Check18.Size = New System.Drawing.Size(15, 14)
        Me.Check18.TabIndex = 148
        Me.Check18.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check18.UncheckedState.BorderRadius = 0
        Me.Check18.UncheckedState.BorderThickness = 0
        Me.Check18.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check20
        '
        Me.Check20.AutoSize = True
        Me.Check20.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check20.CheckedState.BorderRadius = 0
        Me.Check20.CheckedState.BorderThickness = 0
        Me.Check20.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check20.Location = New System.Drawing.Point(422, 141)
        Me.Check20.Name = "Check20"
        Me.Check20.Size = New System.Drawing.Size(15, 14)
        Me.Check20.TabIndex = 150
        Me.Check20.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check20.UncheckedState.BorderRadius = 0
        Me.Check20.UncheckedState.BorderThickness = 0
        Me.Check20.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check19
        '
        Me.Check19.AutoSize = True
        Me.Check19.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check19.CheckedState.BorderRadius = 0
        Me.Check19.CheckedState.BorderThickness = 0
        Me.Check19.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check19.Location = New System.Drawing.Point(422, 116)
        Me.Check19.Name = "Check19"
        Me.Check19.Size = New System.Drawing.Size(15, 14)
        Me.Check19.TabIndex = 149
        Me.Check19.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check19.UncheckedState.BorderRadius = 0
        Me.Check19.UncheckedState.BorderThickness = 0
        Me.Check19.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check8
        '
        Me.Check8.AutoSize = True
        Me.Check8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check8.CheckedState.BorderRadius = 0
        Me.Check8.CheckedState.BorderThickness = 0
        Me.Check8.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check8.Location = New System.Drawing.Point(221, 16)
        Me.Check8.Name = "Check8"
        Me.Check8.Size = New System.Drawing.Size(15, 14)
        Me.Check8.TabIndex = 138
        Me.Check8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check8.UncheckedState.BorderRadius = 0
        Me.Check8.UncheckedState.BorderThickness = 0
        Me.Check8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check9
        '
        Me.Check9.AutoSize = True
        Me.Check9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check9.CheckedState.BorderRadius = 0
        Me.Check9.CheckedState.BorderThickness = 0
        Me.Check9.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check9.Location = New System.Drawing.Point(221, 41)
        Me.Check9.Name = "Check9"
        Me.Check9.Size = New System.Drawing.Size(15, 14)
        Me.Check9.TabIndex = 139
        Me.Check9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check9.UncheckedState.BorderRadius = 0
        Me.Check9.UncheckedState.BorderThickness = 0
        Me.Check9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check10
        '
        Me.Check10.AutoSize = True
        Me.Check10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check10.CheckedState.BorderRadius = 0
        Me.Check10.CheckedState.BorderThickness = 0
        Me.Check10.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check10.Location = New System.Drawing.Point(221, 66)
        Me.Check10.Name = "Check10"
        Me.Check10.Size = New System.Drawing.Size(15, 14)
        Me.Check10.TabIndex = 140
        Me.Check10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check10.UncheckedState.BorderRadius = 0
        Me.Check10.UncheckedState.BorderThickness = 0
        Me.Check10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check14
        '
        Me.Check14.AutoSize = True
        Me.Check14.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check14.CheckedState.BorderRadius = 0
        Me.Check14.CheckedState.BorderThickness = 0
        Me.Check14.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check14.Location = New System.Drawing.Point(221, 166)
        Me.Check14.Name = "Check14"
        Me.Check14.Size = New System.Drawing.Size(15, 14)
        Me.Check14.TabIndex = 144
        Me.Check14.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check14.UncheckedState.BorderRadius = 0
        Me.Check14.UncheckedState.BorderThickness = 0
        Me.Check14.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check11
        '
        Me.Check11.AutoSize = True
        Me.Check11.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check11.CheckedState.BorderRadius = 0
        Me.Check11.CheckedState.BorderThickness = 0
        Me.Check11.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check11.Location = New System.Drawing.Point(221, 91)
        Me.Check11.Name = "Check11"
        Me.Check11.Size = New System.Drawing.Size(15, 14)
        Me.Check11.TabIndex = 141
        Me.Check11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check11.UncheckedState.BorderRadius = 0
        Me.Check11.UncheckedState.BorderThickness = 0
        Me.Check11.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check13
        '
        Me.Check13.AutoSize = True
        Me.Check13.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check13.CheckedState.BorderRadius = 0
        Me.Check13.CheckedState.BorderThickness = 0
        Me.Check13.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check13.Location = New System.Drawing.Point(221, 141)
        Me.Check13.Name = "Check13"
        Me.Check13.Size = New System.Drawing.Size(15, 14)
        Me.Check13.TabIndex = 143
        Me.Check13.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check13.UncheckedState.BorderRadius = 0
        Me.Check13.UncheckedState.BorderThickness = 0
        Me.Check13.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Check12
        '
        Me.Check12.AutoSize = True
        Me.Check12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check12.CheckedState.BorderRadius = 0
        Me.Check12.CheckedState.BorderThickness = 0
        Me.Check12.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check12.Location = New System.Drawing.Point(221, 116)
        Me.Check12.Name = "Check12"
        Me.Check12.Size = New System.Drawing.Size(15, 14)
        Me.Check12.TabIndex = 142
        Me.Check12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check12.UncheckedState.BorderRadius = 0
        Me.Check12.UncheckedState.BorderThickness = 0
        Me.Check12.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'DataBaseSWDataSet1BindingSource
        '
        Me.DataBaseSWDataSet1BindingSource.DataSource = Me.DataBaseSWDataSet1
        Me.DataBaseSWDataSet1BindingSource.Position = 0
        '
        'DataBaseSWDataSet1BindingSource1
        '
        Me.DataBaseSWDataSet1BindingSource1.DataSource = Me.DataBaseSWDataSet1
        Me.DataBaseSWDataSet1BindingSource1.Position = 0
        '
        'DiametriTableAdapter
        '
        Me.DiametriTableAdapter.ClearBeforeFill = True
        '
        'DataBaseSWDataSet1BindingSource2
        '
        Me.DataBaseSWDataSet1BindingSource2.DataSource = Me.DataBaseSWDataSet1
        Me.DataBaseSWDataSet1BindingSource2.Position = 0
        '
        'AngoloTableAdapter
        '
        Me.AngoloTableAdapter.ClearBeforeFill = True
        '
        'btnOpenSW
        '
        Me.btnOpenSW.CheckedState.Parent = Me.btnOpenSW
        Me.btnOpenSW.CustomBorderColor = System.Drawing.Color.Black
        Me.btnOpenSW.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.btnOpenSW.CustomImages.Parent = Me.btnOpenSW
        Me.btnOpenSW.Enabled = False
        Me.btnOpenSW.FillColor = System.Drawing.Color.Transparent
        Me.btnOpenSW.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenSW.ForeColor = System.Drawing.Color.Black
        Me.btnOpenSW.HoverState.Parent = Me.btnOpenSW
        Me.btnOpenSW.Image = Global.VipDesignerUM.My.Resources.Resources.sw_icon
        Me.btnOpenSW.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOpenSW.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnOpenSW.Location = New System.Drawing.Point(6, 455)
        Me.btnOpenSW.Name = "btnOpenSW"
        Me.btnOpenSW.ShadowDecoration.Parent = Me.btnOpenSW
        Me.btnOpenSW.Size = New System.Drawing.Size(232, 35)
        Me.btnOpenSW.TabIndex = 142
        Me.btnOpenSW.Text = "     Open Solid Work"
        '
        'TipoPalaTableAdapter
        '
        Me.TipoPalaTableAdapter.ClearBeforeFill = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ProgressBar1)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.Controls.Add(Me.Label22)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1924, 1041)
        Me.Guna2Panel2.TabIndex = 143
        Me.Guna2Panel2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(6, 502)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 29)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Label9"
        Me.Label9.Visible = False
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.FillThickness = 4
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(764, 736)
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ProgressThickness = 6
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.ShadowDecoration.Parent = Me.Guna2CircleProgressBar1
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(88, 88)
        Me.Guna2CircleProgressBar1.TabIndex = 4
        Me.Guna2CircleProgressBar1.Visible = False
        '
        'Guna2ProgressBar1
        '
        Me.Guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2ProgressBar1.Location = New System.Drawing.Point(457, 549)
        Me.Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.ShadowDecoration.Parent = Me.Guna2ProgressBar1
        Me.Guna2ProgressBar1.Size = New System.Drawing.Size(752, 30)
        Me.Guna2ProgressBar1.TabIndex = 3
        Me.Guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(580, 686)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(754, 421)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(150, 37)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "LOADING..."
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.VipDesignerUM.My.Resources.Resources.sw_icon
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(483, 89)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(593, 370)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnSegnala
        '
        Me.btnSegnala.CheckedState.Parent = Me.btnSegnala
        Me.btnSegnala.CustomBorderColor = System.Drawing.Color.Black
        Me.btnSegnala.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.btnSegnala.CustomImages.Parent = Me.btnSegnala
        Me.btnSegnala.FillColor = System.Drawing.Color.Transparent
        Me.btnSegnala.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSegnala.ForeColor = System.Drawing.Color.Black
        Me.btnSegnala.HoverState.Parent = Me.btnSegnala
        Me.btnSegnala.Image = Global.VipDesignerUM.My.Resources.Resources.sw_icon
        Me.btnSegnala.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSegnala.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnSegnala.Location = New System.Drawing.Point(239, 455)
        Me.btnSegnala.Name = "btnSegnala"
        Me.btnSegnala.ShadowDecoration.Parent = Me.btnSegnala
        Me.btnSegnala.Size = New System.Drawing.Size(232, 35)
        Me.btnSegnala.TabIndex = 144
        Me.btnSegnala.Text = "    Segnala ventilatore"
        Me.btnSegnala.Visible = False
        '
        'TipoCestelloTableAdapter
        '
        Me.TipoCestelloTableAdapter.ClearBeforeFill = True
        '
        'btnTestaFan
        '
        Me.btnTestaFan.CheckedState.Parent = Me.btnTestaFan
        Me.btnTestaFan.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTestaFan.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.btnTestaFan.CustomImages.Parent = Me.btnTestaFan
        Me.btnTestaFan.FillColor = System.Drawing.Color.Transparent
        Me.btnTestaFan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestaFan.ForeColor = System.Drawing.Color.Black
        Me.btnTestaFan.HoverState.Parent = Me.btnTestaFan
        Me.btnTestaFan.Image = Global.VipDesignerUM.My.Resources.Resources.sw_icon
        Me.btnTestaFan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTestaFan.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnTestaFan.Location = New System.Drawing.Point(472, 455)
        Me.btnTestaFan.Name = "btnTestaFan"
        Me.btnTestaFan.ShadowDecoration.Parent = Me.btnTestaFan
        Me.btnTestaFan.Size = New System.Drawing.Size(232, 35)
        Me.btnTestaFan.TabIndex = 145
        Me.btnTestaFan.Text = "    Testa Fan"
        '
        'MarcaMotoreTableAdapter
        '
        Me.MarcaMotoreTableAdapter.ClearBeforeFill = True
        '
        'lab_marca
        '
        Me.lab_marca.AutoSize = True
        Me.lab_marca.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lab_marca.Location = New System.Drawing.Point(1, 105)
        Me.lab_marca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_marca.Name = "lab_marca"
        Me.lab_marca.Size = New System.Drawing.Size(96, 19)
        Me.lab_marca.TabIndex = 141
        Me.lab_marca.Text = "Marca motore"
        Me.lab_marca.Visible = False
        '
        'SW_interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1041)
        Me.Controls.Add(Me.btnTestaFan)
        Me.Controls.Add(Me.btnSegnala)
        Me.Controls.Add(Me.btnOpenSW)
        Me.Controls.Add(Me.Pan3)
        Me.Controls.Add(Me.Pan2)
        Me.Controls.Add(Me.Pan1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Name = "SW_interface"
        Me.Text = "cbx_diametro"
        CType(Me.CbxOwnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewPJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiametriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseSWDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AngoloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseSWDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseSWDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentilatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerieVentolaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan1.ResumeLayout(False)
        Me.Pan1.PerformLayout()
        CType(Me.MarcaMotoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseSWDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoPalaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseSWDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan2.ResumeLayout(False)
        Me.Pan2.PerformLayout()
        CType(Me.TipoCestelloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseSWDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan3.ResumeLayout(False)
        Me.Pan3.PerformLayout()
        CType(Me.DataBaseSWDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseSWDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBaseSWDataSet1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NewPJDataSet As NewPJDataSet
    Friend WithEvents CbxOwnerBindingSource As BindingSource
    Friend WithEvents Cbx_OwnerTableAdapter As NewPJDataSetTableAdapters.cbx_OwnerTableAdapter
    Friend WithEvents cbx_diametro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_angolo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbx_motore As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_ventilatore As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_ventola As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbx_flusso As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Check1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check3 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check4 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check5 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check6 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check7 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents DataBaseSWDataSet As DataBaseSWDataSet
    Friend WithEvents SerieVentolaBindingSource As BindingSource
    Friend WithEvents SerieVentolaTableAdapter As DataBaseSWDataSetTableAdapters.SerieVentolaTableAdapter
    Friend WithEvents DataBaseSWDataSetBindingSource As BindingSource
    Friend WithEvents MotoreBindingSource As BindingSource
    Friend WithEvents MotoreTableAdapter As DataBaseSWDataSetTableAdapters.MotoreTableAdapter
    Friend WithEvents VentilatoriBindingSource As BindingSource
    Friend WithEvents VentilatoriTableAdapter As DataBaseSWDataSetTableAdapters.VentilatoriTableAdapter
    Friend WithEvents Pan1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Pan2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Pan3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Check15 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check16 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check17 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check21 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check18 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check20 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check19 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check8 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check9 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check10 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check14 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check11 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check13 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Check12 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents DataBaseSWDataSet1 As DataBaseSWDataSet1
    Friend WithEvents DataBaseSWDataSet1BindingSource As BindingSource
    Friend WithEvents DataBaseSWDataSet1BindingSource1 As BindingSource
    Friend WithEvents DiametriBindingSource As BindingSource
    Friend WithEvents DiametriTableAdapter As DataBaseSWDataSet1TableAdapters.DiametriTableAdapter
    Friend WithEvents DataBaseSWDataSet1BindingSource2 As BindingSource
    Friend WithEvents AngoloBindingSource As BindingSource
    Friend WithEvents AngoloTableAdapter As DataBaseSWDataSet1TableAdapters.AngoloTableAdapter
    Friend WithEvents btnOpenSW As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbx_pala As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataBaseSWDataSet12 As DataBaseSWDataSet12
    Friend WithEvents TipoPalaBindingSource As BindingSource
    Friend WithEvents TipoPalaTableAdapter As DataBaseSWDataSet12TableAdapters.TipoPalaTableAdapter
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnSegnala As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbx_cestello As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataBaseSWDataSet14 As DataBaseSWDataSet14
    Friend WithEvents TipoCestelloBindingSource As BindingSource
    Friend WithEvents TipoCestelloTableAdapter As DataBaseSWDataSet14TableAdapters.TipoCestelloTableAdapter
    Friend WithEvents btnTestaFan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label9 As Label
    Friend WithEvents lab_unificato As Label
    Friend WithEvents cbx_unificato As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lab_piedini As Label
    Friend WithEvents cbx_piedini As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lab_cappello As Label
    Friend WithEvents cbx_cappello As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbx_ventilazione As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lab_ventilaione As Label
    Friend WithEvents cbx_marca As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DataBaseSWDataSet15 As DataBaseSWDataSet15
    Friend WithEvents MarcaMotoreBindingSource As BindingSource
    Friend WithEvents MarcaMotoreTableAdapter As DataBaseSWDataSet15TableAdapters.MarcaMotoreTableAdapter
    Friend WithEvents lab_marca As Label
End Class
