<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrder
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.BtnChangePayMode = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbPayMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.BtnChengeRoom = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbRoom = New DevExpress.XtraEditors.LookUpEdit()
        Me.RoomsCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.BtnAction = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbActions = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BtnChangeOrderStatus = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbOrderStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.txtStartTime = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscVal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductVal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommentsVal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToPrinter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToReceipt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToCashMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrinter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClonePrinter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAppComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommentVal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToCloud = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductDescr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductDescrEn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosProductDescr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeriko = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVatValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommentLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommentLinePrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtOrderNum = New DevExpress.XtraEditors.TextEdit()
        Me.txtUser = New DevExpress.XtraEditors.TextEdit()
        Me.txtTrapezi = New DevExpress.XtraEditors.TextEdit()
        Me.txtOrderDate = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CmbPayMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbActions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbOrderStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrapezi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.BtnChangePayMode)
        Me.LayoutControl1.Controls.Add(Me.CmbPayMode)
        Me.LayoutControl1.Controls.Add(Me.BtnChengeRoom)
        Me.LayoutControl1.Controls.Add(Me.CmbRoom)
        Me.LayoutControl1.Controls.Add(Me.BtnAction)
        Me.LayoutControl1.Controls.Add(Me.CmbActions)
        Me.LayoutControl1.Controls.Add(Me.BtnChangeOrderStatus)
        Me.LayoutControl1.Controls.Add(Me.CmbOrderStatus)
        Me.LayoutControl1.Controls.Add(Me.txtStartTime)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.txtOrderNum)
        Me.LayoutControl1.Controls.Add(Me.txtUser)
        Me.LayoutControl1.Controls.Add(Me.txtTrapezi)
        Me.LayoutControl1.Controls.Add(Me.txtOrderDate)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1073, 472)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'BtnChangePayMode
        '
        Me.BtnChangePayMode.Location = New System.Drawing.Point(533, 360)
        Me.BtnChangePayMode.Name = "BtnChangePayMode"
        Me.BtnChangePayMode.Size = New System.Drawing.Size(107, 22)
        Me.BtnChangePayMode.StyleController = Me.LayoutControl1
        Me.BtnChangePayMode.TabIndex = 21
        Me.BtnChangePayMode.Text = "Αλλαγή"
        '
        'CmbPayMode
        '
        Me.CmbPayMode.Location = New System.Drawing.Point(140, 360)
        Me.CmbPayMode.Name = "CmbPayMode"
        Me.CmbPayMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPayMode.Size = New System.Drawing.Size(389, 20)
        Me.CmbPayMode.StyleController = Me.LayoutControl1
        Me.CmbPayMode.TabIndex = 20
        '
        'BtnChengeRoom
        '
        Me.BtnChengeRoom.Location = New System.Drawing.Point(533, 438)
        Me.BtnChengeRoom.Name = "BtnChengeRoom"
        Me.BtnChengeRoom.Size = New System.Drawing.Size(107, 22)
        Me.BtnChengeRoom.StyleController = Me.LayoutControl1
        Me.BtnChengeRoom.TabIndex = 19
        Me.BtnChengeRoom.Text = "Αλλαγή"
        '
        'CmbRoom
        '
        Me.CmbRoom.Location = New System.Drawing.Point(140, 436)
        Me.CmbRoom.Name = "CmbRoom"
        Me.CmbRoom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmbRoom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbRoom.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid", "Oid", 25, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoomDescr", "Room Descr", 66, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoomStatus", "Room Status", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GetRoomClosedTotal", "Get Room Closed Total", 118, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GetRoomOpenTotal", "Get Room Open Total", 112, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbRoom.Properties.DataSource = Me.RoomsCollection
        Me.CmbRoom.Properties.DisplayMember = "RoomDescr"
        Me.CmbRoom.Properties.ValueMember = "This"
        Me.CmbRoom.Size = New System.Drawing.Size(389, 20)
        Me.CmbRoom.StyleController = Me.LayoutControl1
        Me.CmbRoom.TabIndex = 18
        '
        'RoomsCollection
        '
        Me.RoomsCollection.CriteriaString = "[RoomStatus] = 'EnRoomsTypeNotAvailable'"
        Me.RoomsCollection.ObjectType = GetType(NrgWaiterModel.Cmp300.Room)
        '
        'BtnAction
        '
        Me.BtnAction.Location = New System.Drawing.Point(533, 412)
        Me.BtnAction.Name = "BtnAction"
        Me.BtnAction.Size = New System.Drawing.Size(107, 22)
        Me.BtnAction.StyleController = Me.LayoutControl1
        Me.BtnAction.TabIndex = 17
        Me.BtnAction.Text = "Εκτέλεση"
        '
        'CmbActions
        '
        Me.CmbActions.Location = New System.Drawing.Point(140, 412)
        Me.CmbActions.Name = "CmbActions"
        Me.CmbActions.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbActions.Properties.Items.AddRange(New Object() {"Εκτύπωση Λογαριασμού", "Εκπτύπωση Εκρεμότητες Απόδειξης", "Επανεκτύπωση Απόδειξης", "Εκτύπψση Ειδών"})
        Me.CmbActions.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CmbActions.Size = New System.Drawing.Size(389, 20)
        Me.CmbActions.StyleController = Me.LayoutControl1
        Me.CmbActions.TabIndex = 16
        '
        'BtnChangeOrderStatus
        '
        Me.BtnChangeOrderStatus.Location = New System.Drawing.Point(533, 386)
        Me.BtnChangeOrderStatus.Name = "BtnChangeOrderStatus"
        Me.BtnChangeOrderStatus.Size = New System.Drawing.Size(107, 22)
        Me.BtnChangeOrderStatus.StyleController = Me.LayoutControl1
        Me.BtnChangeOrderStatus.TabIndex = 11
        Me.BtnChangeOrderStatus.Text = "Αλλαγή"
        '
        'CmbOrderStatus
        '
        Me.CmbOrderStatus.Location = New System.Drawing.Point(140, 386)
        Me.CmbOrderStatus.Name = "CmbOrderStatus"
        Me.CmbOrderStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbOrderStatus.Size = New System.Drawing.Size(389, 20)
        Me.CmbOrderStatus.StyleController = Me.LayoutControl1
        Me.CmbOrderStatus.TabIndex = 10
        '
        'txtStartTime
        '
        Me.txtStartTime.Location = New System.Drawing.Point(798, 28)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Properties.DisplayFormat.FormatString = "t"
        Me.txtStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtStartTime.Properties.EditFormat.FormatString = "t"
        Me.txtStartTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtStartTime.Size = New System.Drawing.Size(263, 20)
        Me.txtStartTime.StyleController = Me.LayoutControl1
        Me.txtStartTime.TabIndex = 9
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Location = New System.Drawing.Point(12, 52)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(1049, 304)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'XpCollection1
        '
        Me.XpCollection1.LoadingEnabled = False
        Me.XpCollection1.ObjectType = GetType(NrgWaiterModel.Cmp300.PosOrderLine)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colComments, Me.colQuant, Me.colPrice, Me.colDisc, Me.colDiscVal, Me.colProductVal, Me.colCommentsVal, Me.colTotal, Me.colToPrinter, Me.colToReceipt, Me.colToCashMachine, Me.GridColumn5, Me.GridColumn6, Me.colPrinter, Me.colClonePrinter, Me.colAppComments, Me.colPosition, Me.colCommentVal, Me.colToCloud, Me.colProductDescr, Me.colProductDescrEn, Me.colPosProductDescr, Me.colMeriko, Me.colTotalPrice, Me.colNetPrice, Me.colNetValue, Me.colVatValue, Me.colCommentLine, Me.colCommentLinePrice})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "PosOrder!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "PosOrder!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Product!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Είδος"
        Me.GridColumn4.FieldName = "ProductDescr"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 215
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        '
        'colQuant
        '
        Me.colQuant.Caption = "Ποσότητα"
        Me.colQuant.DisplayFormat.FormatString = "N2"
        Me.colQuant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuant.FieldName = "Quant"
        Me.colQuant.Name = "colQuant"
        Me.colQuant.Visible = True
        Me.colQuant.VisibleIndex = 1
        Me.colQuant.Width = 79
        '
        'colPrice
        '
        Me.colPrice.Caption = "Τιμή"
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 2
        Me.colPrice.Width = 79
        '
        'colDisc
        '
        Me.colDisc.Caption = "Εκπτ%"
        Me.colDisc.FieldName = "Disc"
        Me.colDisc.Name = "colDisc"
        Me.colDisc.Visible = True
        Me.colDisc.VisibleIndex = 3
        Me.colDisc.Width = 49
        '
        'colDiscVal
        '
        Me.colDiscVal.Caption = "Αξία Έκπτ"
        Me.colDiscVal.FieldName = "DiscVal"
        Me.colDiscVal.Name = "colDiscVal"
        Me.colDiscVal.Visible = True
        Me.colDiscVal.VisibleIndex = 4
        Me.colDiscVal.Width = 64
        '
        'colProductVal
        '
        Me.colProductVal.Caption = "Αξία Είδών"
        Me.colProductVal.FieldName = "ProductVal"
        Me.colProductVal.Name = "colProductVal"
        Me.colProductVal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProductVal", "{0:0.##}")})
        Me.colProductVal.Visible = True
        Me.colProductVal.VisibleIndex = 5
        Me.colProductVal.Width = 67
        '
        'colCommentsVal
        '
        Me.colCommentsVal.Caption = "Extra"
        Me.colCommentsVal.FieldName = "CommentsVal"
        Me.colCommentsVal.Name = "colCommentsVal"
        Me.colCommentsVal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CommentsVal", "{0:0.##}")})
        Me.colCommentsVal.Visible = True
        Me.colCommentsVal.VisibleIndex = 6
        Me.colCommentsVal.Width = 65
        '
        'colTotal
        '
        Me.colTotal.Caption = "Σύνολο"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:0.##}")})
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 7
        Me.colTotal.Width = 79
        '
        'colToPrinter
        '
        Me.colToPrinter.CustomizationCaption = "Εκτυπωμένο"
        Me.colToPrinter.FieldName = "ToPrinter"
        Me.colToPrinter.Name = "colToPrinter"
        Me.colToPrinter.Visible = True
        Me.colToPrinter.VisibleIndex = 10
        Me.colToPrinter.Width = 139
        '
        'colToReceipt
        '
        Me.colToReceipt.Caption = "Λογαριασμός"
        Me.colToReceipt.FieldName = "ToReceipt"
        Me.colToReceipt.Name = "colToReceipt"
        Me.colToReceipt.Visible = True
        Me.colToReceipt.VisibleIndex = 9
        Me.colToReceipt.Width = 94
        '
        'colToCashMachine
        '
        Me.colToCashMachine.Caption = "Ταμειακή"
        Me.colToCashMachine.FieldName = "ToCashMachine"
        Me.colToCashMachine.Name = "colToCashMachine"
        Me.colToCashMachine.Visible = True
        Me.colToCashMachine.VisibleIndex = 8
        Me.colToCashMachine.Width = 94
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "User!"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "User!Key"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'colPrinter
        '
        Me.colPrinter.FieldName = "Printer"
        Me.colPrinter.Name = "colPrinter"
        '
        'colClonePrinter
        '
        Me.colClonePrinter.FieldName = "ClonePrinter"
        Me.colClonePrinter.Name = "colClonePrinter"
        '
        'colAppComments
        '
        Me.colAppComments.FieldName = "AppComments"
        Me.colAppComments.Name = "colAppComments"
        '
        'colPosition
        '
        Me.colPosition.FieldName = "Position"
        Me.colPosition.Name = "colPosition"
        '
        'colCommentVal
        '
        Me.colCommentVal.FieldName = "CommentVal"
        Me.colCommentVal.Name = "colCommentVal"
        '
        'colToCloud
        '
        Me.colToCloud.FieldName = "ToCloud"
        Me.colToCloud.Name = "colToCloud"
        '
        'colProductDescr
        '
        Me.colProductDescr.FieldName = "ProductDescr"
        Me.colProductDescr.Name = "colProductDescr"
        '
        'colProductDescrEn
        '
        Me.colProductDescrEn.FieldName = "ProductDescrEn"
        Me.colProductDescrEn.Name = "colProductDescrEn"
        '
        'colPosProductDescr
        '
        Me.colPosProductDescr.FieldName = "PosProductDescr"
        Me.colPosProductDescr.Name = "colPosProductDescr"
        '
        'colMeriko
        '
        Me.colMeriko.FieldName = "Meriko"
        Me.colMeriko.Name = "colMeriko"
        '
        'colTotalPrice
        '
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.Name = "colTotalPrice"
        '
        'colNetPrice
        '
        Me.colNetPrice.FieldName = "NetPrice"
        Me.colNetPrice.Name = "colNetPrice"
        '
        'colNetValue
        '
        Me.colNetValue.FieldName = "NetValue"
        Me.colNetValue.Name = "colNetValue"
        '
        'colVatValue
        '
        Me.colVatValue.FieldName = "VatValue"
        Me.colVatValue.Name = "colVatValue"
        '
        'colCommentLine
        '
        Me.colCommentLine.FieldName = "CommentLine"
        Me.colCommentLine.Name = "colCommentLine"
        '
        'colCommentLinePrice
        '
        Me.colCommentLinePrice.FieldName = "CommentLinePrice"
        Me.colCommentLinePrice.Name = "colCommentLinePrice"
        '
        'txtOrderNum
        '
        Me.txtOrderNum.Location = New System.Drawing.Point(185, 28)
        Me.txtOrderNum.Name = "txtOrderNum"
        Me.txtOrderNum.Size = New System.Drawing.Size(172, 20)
        Me.txtOrderNum.StyleController = Me.LayoutControl1
        Me.txtOrderNum.TabIndex = 7
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(533, 28)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(261, 20)
        Me.txtUser.StyleController = Me.LayoutControl1
        Me.txtUser.TabIndex = 6
        '
        'txtTrapezi
        '
        Me.txtTrapezi.Location = New System.Drawing.Point(361, 28)
        Me.txtTrapezi.Name = "txtTrapezi"
        Me.txtTrapezi.Size = New System.Drawing.Size(168, 20)
        Me.txtTrapezi.StyleController = Me.LayoutControl1
        Me.txtTrapezi.TabIndex = 5
        '
        'txtOrderDate
        '
        Me.txtOrderDate.EditValue = Nothing
        Me.txtOrderDate.Location = New System.Drawing.Point(12, 28)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOrderDate.Properties.DisplayFormat.FormatString = ""
        Me.txtOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtOrderDate.Properties.EditFormat.FormatString = ""
        Me.txtOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtOrderDate.Properties.MaskSettings.Set("mask", "")
        Me.txtOrderDate.Size = New System.Drawing.Size(169, 20)
        Me.txtOrderDate.StyleController = Me.LayoutControl1
        Me.txtOrderDate.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem13, Me.LayoutControlItem9, Me.LayoutControlItem12, Me.LayoutControlItem14, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1073, 472)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem1.Control = Me.txtOrderDate
        Me.LayoutControlItem1.Enabled = False
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(173, 40)
        Me.LayoutControlItem1.Text = "Ημερομηνία"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(116, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem2.Control = Me.txtTrapezi
        Me.LayoutControlItem2.Enabled = False
        Me.LayoutControlItem2.Location = New System.Drawing.Point(349, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(172, 40)
        Me.LayoutControlItem2.Text = "Τραπέζι"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(116, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem3.Control = Me.txtUser
        Me.LayoutControlItem3.Enabled = False
        Me.LayoutControlItem3.Location = New System.Drawing.Point(521, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(265, 40)
        Me.LayoutControlItem3.Text = "Χρήστης"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(116, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem4.Control = Me.txtOrderNum
        Me.LayoutControlItem4.Enabled = False
        Me.LayoutControlItem4.Location = New System.Drawing.Point(173, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(176, 40)
        Me.LayoutControlItem4.Text = "Αρ.Παραγγελίας"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(116, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridControl1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1053, 308)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem6.Control = Me.txtStartTime
        Me.LayoutControlItem6.Enabled = False
        Me.LayoutControlItem6.Location = New System.Drawing.Point(786, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(267, 40)
        Me.LayoutControlItem6.Text = "Start Time"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(116, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.CmbOrderStatus
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 374)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(521, 26)
        Me.LayoutControlItem7.Text = "Κατάσταση Παραγγελίας"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(116, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.BtnChangeOrderStatus
        Me.LayoutControlItem8.Location = New System.Drawing.Point(521, 374)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CmbRoom
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 424)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(521, 28)
        Me.LayoutControlItem10.Text = "Αλλαγή Δωματίου"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(116, 13)
        Me.LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.BtnChengeRoom
        Me.LayoutControlItem11.Location = New System.Drawing.Point(521, 426)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.CmbActions
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 400)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(521, 24)
        Me.LayoutControlItem13.Text = "Ενέργιες"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(116, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.BtnAction
        Me.LayoutControlItem9.Location = New System.Drawing.Point(521, 400)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.CmbPayMode
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 348)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(521, 26)
        Me.LayoutControlItem12.Text = "Τρόπος Πληρωμής"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(116, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.BtnChangePayMode
        Me.LayoutControlItem14.Location = New System.Drawing.Point(521, 348)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(632, 348)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(421, 104)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 472)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Παραγγελία"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CmbPayMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbActions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbOrderStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrapezi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtStartTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtOrderNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTrapezi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOrderDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommentsVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToPrinter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToReceipt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToCashMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrinter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClonePrinter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAppComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommentVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToCloud As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductDescr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductDescrEn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosProductDescr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeriko As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVatValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommentLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommentLinePrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnChangeOrderStatus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbOrderStatus As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmbActions As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnAction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnChengeRoom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbRoom As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RoomsCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnChangePayMode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbPayMode As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
