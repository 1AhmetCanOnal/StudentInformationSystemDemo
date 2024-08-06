namespace StudentUI
{
    partial class XtraAddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraAddStudent));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            gC1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            colDep = new DevExpress.XtraGrid.Columns.GridColumn();
            colbd = new DevExpress.XtraGrid.Columns.GridColumn();
            colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            dateStudentBD = new DateTimePicker();
            textStudentDep = new DevExpress.XtraEditors.TextEdit();
            textStudentSurname = new DevExpress.XtraEditors.TextEdit();
            textStudentName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            addStudentName = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            addStudentSurname = new DevExpress.XtraLayout.LayoutControlItem();
            addStudentDeparment = new DevExpress.XtraLayout.LayoutControlItem();
            AddStudentDateofbirth = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            repositoryBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gC1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textStudentDep.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textStudentSurname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textStudentName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addStudentName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addStudentSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addStudentDeparment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddStudentDateofbirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gC1);
            layoutControl1.Controls.Add(btnClose);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(dateStudentBD);
            layoutControl1.Controls.Add(textStudentDep);
            layoutControl1.Controls.Add(textStudentSurname);
            layoutControl1.Controls.Add(textStudentName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(752, 640);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // gC1
            // 
            gC1.Location = new Point(12, 283);
            gC1.MainView = gridView1;
            gC1.Name = "gC1";
            gC1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnDelete, repositoryBtnEdit });
            gC1.Size = new Size(728, 345);
            gC1.TabIndex = 10;
            gC1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colSurname, colDep, colbd, colDelete, gridColumn1 });
            gridView1.GridControl = gC1;
            gridView1.Name = "gridView1";
            // 
            // colId
            // 
            colId.Caption = "#";
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colName
            // 
            colName.Caption = "Adı";
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            // 
            // colSurname
            // 
            colSurname.Caption = "Soyadı";
            colSurname.FieldName = "Surname";
            colSurname.Name = "colSurname";
            colSurname.Visible = true;
            colSurname.VisibleIndex = 2;
            // 
            // colDep
            // 
            colDep.Caption = "Bölümü";
            colDep.FieldName = "Department";
            colDep.Name = "colDep";
            colDep.Visible = true;
            colDep.VisibleIndex = 3;
            // 
            // colbd
            // 
            colbd.Caption = "Doğum Tarihi";
            colbd.FieldName = "Dateofbirth";
            colbd.Name = "colbd";
            colbd.Visible = true;
            colbd.VisibleIndex = 4;
            // 
            // colDelete
            // 
            colDelete.Caption = "Sil";
            colDelete.ColumnEdit = repositoryBtnDelete;
            colDelete.Name = "colDelete";
            colDelete.Visible = true;
            colDelete.VisibleIndex = 5;
            // 
            // repositoryBtnDelete
            // 
            repositoryBtnDelete.AutoHeight = false;
            repositoryBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryBtnDelete.Name = "repositoryBtnDelete";
            repositoryBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnDelete.Click += repositoryBtnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new Point(12, 148);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(728, 36);
            btnClose.StyleController = layoutControl1;
            btnClose.TabIndex = 9;
            btnClose.Text = "Kapat";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.Location = new Point(12, 108);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(728, 36);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 8;
            btnSave.Text = "Kaydet";
            btnSave.Click += btnSave_Click;
            // 
            // dateStudentBD
            // 
            dateStudentBD.Location = new Point(126, 84);
            dateStudentBD.Name = "dateStudentBD";
            dateStudentBD.Size = new Size(614, 21);
            dateStudentBD.TabIndex = 7;
            // 
            // textStudentDep
            // 
            textStudentDep.Location = new Point(126, 60);
            textStudentDep.Name = "textStudentDep";
            textStudentDep.Size = new Size(614, 20);
            textStudentDep.StyleController = layoutControl1;
            textStudentDep.TabIndex = 6;
            // 
            // textStudentSurname
            // 
            textStudentSurname.Location = new Point(126, 36);
            textStudentSurname.Name = "textStudentSurname";
            textStudentSurname.Size = new Size(614, 20);
            textStudentSurname.StyleController = layoutControl1;
            textStudentSurname.TabIndex = 5;
            // 
            // textStudentName
            // 
            textStudentName.Location = new Point(126, 12);
            textStudentName.Name = "textStudentName";
            textStudentName.Size = new Size(614, 20);
            textStudentName.StyleController = layoutControl1;
            textStudentName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { addStudentName, emptySpaceItem1, addStudentSurname, addStudentDeparment, AddStudentDateofbirth, layoutControlItem1, layoutControlItem2, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new Size(752, 640);
            Root.TextVisible = false;
            // 
            // addStudentName
            // 
            addStudentName.Control = textStudentName;
            addStudentName.Location = new Point(0, 0);
            addStudentName.Name = "addStudentName";
            addStudentName.Size = new Size(732, 24);
            addStudentName.Text = "Öğrenci Adı";
            addStudentName.TextSize = new Size(102, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 176);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(732, 95);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // addStudentSurname
            // 
            addStudentSurname.Control = textStudentSurname;
            addStudentSurname.Location = new Point(0, 24);
            addStudentSurname.Name = "addStudentSurname";
            addStudentSurname.Size = new Size(732, 24);
            addStudentSurname.Text = "Öğrenci Soyadı";
            addStudentSurname.TextSize = new Size(102, 13);
            // 
            // addStudentDeparment
            // 
            addStudentDeparment.Control = textStudentDep;
            addStudentDeparment.Location = new Point(0, 48);
            addStudentDeparment.Name = "addStudentDeparment";
            addStudentDeparment.Size = new Size(732, 24);
            addStudentDeparment.Text = "Öğrenci Bölüm";
            addStudentDeparment.TextSize = new Size(102, 13);
            // 
            // AddStudentDateofbirth
            // 
            AddStudentDateofbirth.Control = dateStudentBD;
            AddStudentDateofbirth.Location = new Point(0, 72);
            AddStudentDateofbirth.Name = "AddStudentDateofbirth";
            AddStudentDateofbirth.Size = new Size(732, 24);
            AddStudentDateofbirth.Text = "Öğrenci Doğum Tarihi";
            AddStudentDateofbirth.TextSize = new Size(102, 13);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnSave;
            layoutControlItem1.Location = new Point(0, 96);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(732, 40);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnClose;
            layoutControlItem2.Location = new Point(0, 136);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(732, 40);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = gC1;
            layoutControlItem3.Location = new Point(0, 271);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(732, 349);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // repositoryBtnEdit
            // 
            repositoryBtnEdit.AutoHeight = false;
            repositoryBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo) });
            repositoryBtnEdit.Name = "repositoryBtnEdit";
            repositoryBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnEdit.Click += repositoryBtnEdit_Click;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Güncelle";
            gridColumn1.ColumnEdit = repositoryBtnEdit;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 6;
            // 
            // XtraAddStudent
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 640);
            Controls.Add(layoutControl1);
            Name = "XtraAddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XtraAddStudent";
            Load += XtraAddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gC1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)textStudentDep.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textStudentSurname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textStudentName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)addStudentName).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)addStudentSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)addStudentDeparment).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddStudentDateofbirth).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DateTimePicker dateStudentBD;
        private DevExpress.XtraEditors.TextEdit textStudentDep;
        private DevExpress.XtraEditors.TextEdit textStudentSurname;
        private DevExpress.XtraEditors.TextEdit textStudentName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem addStudentName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem addStudentSurname;
        private DevExpress.XtraLayout.LayoutControlItem addStudentDeparment;
        private DevExpress.XtraLayout.LayoutControlItem AddStudentDateofbirth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gC1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colDep;
        private DevExpress.XtraGrid.Columns.GridColumn colbd;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEdit;
    }
}