
namespace Cerner.PFT_COLLECTION_TOOL
{
    partial class frmCollectionLetter
    {

        #region "Upgrade Support "
        private static frmCollectionLetter m_vb6FormDefInstance;
        private static bool m_InitializingDefInstance;
        public static frmCollectionLetter DefInstance
        {
            get
            {
                if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
                {
                    m_InitializingDefInstance = true;
                    m_vb6FormDefInstance = new frmCollectionLetter();
                    m_InitializingDefInstance = false;
                }
                return m_vb6FormDefInstance;
            }
            set
            {
                m_vb6FormDefInstance = value;
            }
        }

        #endregion
        #region "Windows Form Designer generated code "
        public frmCollectionLetter()
            : base()
        {
            if (m_vb6FormDefInstance == null)
            {
                if (m_InitializingDefInstance)
                {
                    m_vb6FormDefInstance = this;
                }
                else
                {
                    try
                    {
                        //For the start-up form, the first instance created is the default instance.
                        if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                        {
                            m_vb6FormDefInstance = this;
                        }
                    }
                    catch (System.Exception _exception_)
                    {
                        Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                    }
                }
            }
            //This call is required by the Windows Form Designer.
            InitializeComponent();
            InitializetxtLetter();
            Form_Initialize_Renamed();
        }
        bool fTerminateCalled_Form_Terminate_Renamed;
        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!fTerminateCalled_Form_Terminate_Renamed)
                {
                    fTerminateCalled_Form_Terminate_Renamed = true;
                    Form_Terminate_Renamed();
                }
                if (oBESearch != null)
                {
                    oBESearch.Dispose();
                    oBESearch = null;
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(Disposing);
        }
        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.ToolTip ToolTip1;
        private Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledToolStripButton Save;
        private Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledToolStripSeparator _Toolbar1_Button3;
        private Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledToolStripButton Exit;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledExtendedToolStrip Toolbar1;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledButton cmdBESearch;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledTextBox txtBillingEntity;
        private System.Windows.Forms.TextBox _txtLetter_1;
        private System.Windows.Forms.TextBox _txtLetter_2;
        private System.Windows.Forms.TextBox _txtLetter_3;
        private System.Windows.Forms.TextBox _txtLetter_4;
        private System.Windows.Forms.TextBox _txtLetter_5;
        private System.Windows.Forms.TextBox _txtLetter_6;
        private System.Windows.Forms.TextBox _txtLetter_7;
        private System.Windows.Forms.TextBox _txtLetter_8;
        private System.Windows.Forms.TextBox _txtLetter_9;
        private System.Windows.Forms.TextBox _txtLetter_10;
        private System.Windows.Forms.TextBox _txtLetter_11;
        private System.Windows.Forms.TextBox _txtLetter_12;
        private System.Windows.Forms.TextBox _txtLetter_13;
        private System.Windows.Forms.TextBox _txtLetter_14;
        private System.Windows.Forms.TextBox _txtLetter_15;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledPanel Picture2;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledComboBox cmbDunningCd;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledCheckBox chkDisable;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledButton cmdExit;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledButton cmdSave;
        public AxCODESETLib.AxCodeSet csthidden;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledPanel Picture1;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledLabel lblBillingEntity;
        public Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledLabel lblDunningCd;
        public System.Windows.Forms.ImageList ImageList1;
        public System.Windows.Forms.TextBox[] txtLetter = new System.Windows.Forms.TextBox[16];
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollectionLetter));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Toolbar1 = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledExtendedToolStrip();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Save = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledToolStripButton();
            this.Exit = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledToolStripButton();
            this._Toolbar1_Button3 = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledToolStripSeparator();
            this.cmdBESearch = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledButton();
            this.txtBillingEntity = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledTextBox();
            this.Picture2 = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledPanel();
            this.cernerStyledTableLayoutPanel4 = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledTableLayoutPanel();
            this._txtLetter_14 = new System.Windows.Forms.TextBox();
            this._txtLetter_13 = new System.Windows.Forms.TextBox();
            this._txtLetter_12 = new System.Windows.Forms.TextBox();
            this._txtLetter_11 = new System.Windows.Forms.TextBox();
            this._txtLetter_10 = new System.Windows.Forms.TextBox();
            this._txtLetter_9 = new System.Windows.Forms.TextBox();
            this._txtLetter_8 = new System.Windows.Forms.TextBox();
            this._txtLetter_7 = new System.Windows.Forms.TextBox();
            this._txtLetter_6 = new System.Windows.Forms.TextBox();
            this._txtLetter_5 = new System.Windows.Forms.TextBox();
            this._txtLetter_4 = new System.Windows.Forms.TextBox();
            this._txtLetter_3 = new System.Windows.Forms.TextBox();
            this._txtLetter_2 = new System.Windows.Forms.TextBox();
            this._txtLetter_1 = new System.Windows.Forms.TextBox();
            this._txtLetter_15 = new System.Windows.Forms.TextBox();
            this.cmbDunningCd = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledComboBox();
            this.chkDisable = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledCheckBox();
            this.cmdExit = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledButton();
            this.cmdSave = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledButton();
            this.Picture1 = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledPanel();
            this.csthidden = new AxCODESETLib.AxCodeSet();
            this.lblBillingEntity = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledLabel();
            this.lblDunningCd = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledLabel();
            this.cernerStyledTableLayoutPanel1 = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledTableLayoutPanel();
            this.cernerStyledTableLayoutPanel2 = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledTableLayoutPanel();
            this.cernerStyledTableLayoutPanel3 = new Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledTableLayoutPanel();
            this.Toolbar1.SuspendLayout();
            this.Picture2.SuspendLayout();
            this.cernerStyledTableLayoutPanel4.SuspendLayout();
            this.Picture1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csthidden)).BeginInit();
            this.cernerStyledTableLayoutPanel1.SuspendLayout();
            this.cernerStyledTableLayoutPanel2.SuspendLayout();
            this.cernerStyledTableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolbar1
            // 
            this.Toolbar1.BottomGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.Toolbar1, "Toolbar1");
            this.Toolbar1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Toolbar1.GradientFill = true;
            this.Toolbar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar1.ImageList = this.ImageList1;
            this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Exit});
            this.Toolbar1.Name = "Toolbar1";
            this.Toolbar1.RolloverBottomGradientFill = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(143)))));
            this.Toolbar1.RolloverOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(73)))), ((int)(((byte)(81)))));
            this.Toolbar1.RolloverTextColor = System.Drawing.Color.White;
            this.Toolbar1.RolloverTopGradientFill = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.Toolbar1.SelectedItemBottomGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(93)))));
            this.Toolbar1.SelectedItemOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.Toolbar1.SelectedItemTextColor = System.Drawing.Color.White;
            this.Toolbar1.SelectedItemTopGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(122)))));
            this.Toolbar1.ToolbarHeaderGripperColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(143)))));
            this.Toolbar1.ToolbarHeaderGripperHighlightColor = System.Drawing.Color.White;
            this.Toolbar1.ToolbarSeparatorDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.Toolbar1.ToolbarSeparatorLightColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Toolbar1.ToolStripShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(194)))));
            this.Toolbar1.TopGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Silver;
            this.ImageList1.Images.SetKeyName(0, "save");
            this.ImageList1.Images.SetKeyName(1, "Exit");
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Name = "Save";
            this.Save.Tag = "";
            this.Save.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Name = "Exit";
            this.Exit.Tag = "";
            this.Exit.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
            // 
            // _Toolbar1_Button3
            // 
            resources.ApplyResources(this._Toolbar1_Button3, "_Toolbar1_Button3");
            this._Toolbar1_Button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Toolbar1_Button3.Name = "_Toolbar1_Button3";
            this._Toolbar1_Button3.Tag = "";
            // 
            // cmdBESearch
            // 
            this.cmdBESearch.AutoEllipsis = true;
            this.cmdBESearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdBESearch.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.cmdBESearch, "cmdBESearch");
            this.cmdBESearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBESearch.Name = "cmdBESearch";
            this.cmdBESearch.UseVisualStyleBackColor = true;
            this.cmdBESearch.Click += new System.EventHandler(this.cmdBESearch_Click);
            // 
            // txtBillingEntity
            // 
            this.txtBillingEntity.AcceptsReturn = true;
            this.txtBillingEntity.AutoRequired = false;
            this.txtBillingEntity.BackColor = System.Drawing.Color.White;
            this.txtBillingEntity.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtBillingEntity, "txtBillingEntity");
            this.txtBillingEntity.FixMultiLineBorder = false;
            this.txtBillingEntity.ForeColor = System.Drawing.Color.Black;
            this.txtBillingEntity.HighlightBorder = true;
            this.txtBillingEntity.Name = "txtBillingEntity";
            // 
            // Picture2
            // 
            this.Picture2.BackColor = System.Drawing.Color.White;
            this.Picture2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cernerStyledTableLayoutPanel2.SetColumnSpan(this.Picture2, 3);
            this.Picture2.Controls.Add(this.cernerStyledTableLayoutPanel4);
            this.Picture2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Picture2, "Picture2");
            this.Picture2.Name = "Picture2";
            this.Picture2.TabStop = true;
            // 
            // cernerStyledTableLayoutPanel4
            // 
            this.cernerStyledTableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cernerStyledTableLayoutPanel4, "cernerStyledTableLayoutPanel4");
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_14, 0, 13);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_13, 0, 12);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_12, 0, 11);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_11, 0, 10);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_10, 0, 9);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_9, 0, 8);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_8, 0, 7);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_7, 0, 6);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_6, 0, 5);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_5, 0, 4);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_4, 0, 3);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_3, 0, 2);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_2, 0, 1);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_1, 0, 0);
            this.cernerStyledTableLayoutPanel4.Controls.Add(this._txtLetter_15, 0, 14);
            this.cernerStyledTableLayoutPanel4.Name = "cernerStyledTableLayoutPanel4";
            // 
            // _txtLetter_14
            // 
            this._txtLetter_14.AcceptsReturn = true;
            this._txtLetter_14.BackColor = System.Drawing.Color.White;
            this._txtLetter_14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_14.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_14, "_txtLetter_14");
            this._txtLetter_14.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_14.Name = "_txtLetter_14";
            this._txtLetter_14.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_13
            // 
            this._txtLetter_13.AcceptsReturn = true;
            this._txtLetter_13.BackColor = System.Drawing.Color.White;
            this._txtLetter_13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_13.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_13, "_txtLetter_13");
            this._txtLetter_13.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_13.Name = "_txtLetter_13";
            this._txtLetter_13.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_12
            // 
            this._txtLetter_12.AcceptsReturn = true;
            this._txtLetter_12.BackColor = System.Drawing.Color.White;
            this._txtLetter_12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_12.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_12, "_txtLetter_12");
            this._txtLetter_12.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_12.Name = "_txtLetter_12";
            this._txtLetter_12.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_11
            // 
            this._txtLetter_11.AcceptsReturn = true;
            this._txtLetter_11.BackColor = System.Drawing.Color.White;
            this._txtLetter_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_11.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_11, "_txtLetter_11");
            this._txtLetter_11.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_11.Name = "_txtLetter_11";
            this._txtLetter_11.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_10
            // 
            this._txtLetter_10.AcceptsReturn = true;
            this._txtLetter_10.BackColor = System.Drawing.Color.White;
            this._txtLetter_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_10.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_10, "_txtLetter_10");
            this._txtLetter_10.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_10.Name = "_txtLetter_10";
            this._txtLetter_10.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_9
            // 
            this._txtLetter_9.AcceptsReturn = true;
            this._txtLetter_9.BackColor = System.Drawing.Color.White;
            this._txtLetter_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_9.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_9, "_txtLetter_9");
            this._txtLetter_9.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_9.Name = "_txtLetter_9";
            this._txtLetter_9.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_8
            // 
            this._txtLetter_8.AcceptsReturn = true;
            this._txtLetter_8.BackColor = System.Drawing.Color.White;
            this._txtLetter_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_8, "_txtLetter_8");
            this._txtLetter_8.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_8.Name = "_txtLetter_8";
            this._txtLetter_8.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_7
            // 
            this._txtLetter_7.AcceptsReturn = true;
            this._txtLetter_7.BackColor = System.Drawing.Color.White;
            this._txtLetter_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_7, "_txtLetter_7");
            this._txtLetter_7.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_7.Name = "_txtLetter_7";
            this._txtLetter_7.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_6
            // 
            this._txtLetter_6.AcceptsReturn = true;
            this._txtLetter_6.BackColor = System.Drawing.Color.White;
            this._txtLetter_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_6, "_txtLetter_6");
            this._txtLetter_6.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_6.Name = "_txtLetter_6";
            this._txtLetter_6.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_5
            // 
            this._txtLetter_5.AcceptsReturn = true;
            this._txtLetter_5.BackColor = System.Drawing.Color.White;
            this._txtLetter_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_5, "_txtLetter_5");
            this._txtLetter_5.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_5.Name = "_txtLetter_5";
            this._txtLetter_5.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_4
            // 
            this._txtLetter_4.AcceptsReturn = true;
            this._txtLetter_4.BackColor = System.Drawing.Color.White;
            this._txtLetter_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_4, "_txtLetter_4");
            this._txtLetter_4.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_4.Name = "_txtLetter_4";
            this._txtLetter_4.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_3
            // 
            this._txtLetter_3.AcceptsReturn = true;
            this._txtLetter_3.BackColor = System.Drawing.Color.White;
            this._txtLetter_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_3, "_txtLetter_3");
            this._txtLetter_3.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_3.Name = "_txtLetter_3";
            this._txtLetter_3.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_2
            // 
            this._txtLetter_2.AcceptsReturn = true;
            this._txtLetter_2.BackColor = System.Drawing.Color.White;
            this._txtLetter_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_2, "_txtLetter_2");
            this._txtLetter_2.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_2.Name = "_txtLetter_2";
            this._txtLetter_2.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_1
            // 
            this._txtLetter_1.AcceptsReturn = true;
            this._txtLetter_1.BackColor = System.Drawing.Color.White;
            this._txtLetter_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_1, "_txtLetter_1");
            this._txtLetter_1.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_1.Name = "_txtLetter_1";
            this._txtLetter_1.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // _txtLetter_15
            // 
            this._txtLetter_15.AcceptsReturn = true;
            this._txtLetter_15.BackColor = System.Drawing.Color.White;
            this._txtLetter_15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLetter_15.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this._txtLetter_15, "_txtLetter_15");
            this._txtLetter_15.ForeColor = System.Drawing.Color.Black;
            this._txtLetter_15.Name = "_txtLetter_15";
            this._txtLetter_15.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            this._txtLetter_15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // cmbDunningCd
            // 
            this.cmbDunningCd.AutoRequired = false;
            this.cmbDunningCd.AutoResizeDropDown = false;
            this.cmbDunningCd.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDunningCd.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.cmbDunningCd, "cmbDunningCd");
            this.cmbDunningCd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDunningCd.Name = "cmbDunningCd";
            this.cmbDunningCd.SelectionChangeCommitted += new System.EventHandler(this.cmbDunningCd_SelectionChangeCommitted);
            // 
            // chkDisable
            // 
            this.chkDisable.AutoEllipsis = true;
            this.chkDisable.BackColor = System.Drawing.Color.Transparent;
            this.chkDisable.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.chkDisable, "chkDisable");
            this.chkDisable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.UseVisualStyleBackColor = true;
            this.chkDisable.CheckStateChanged += new System.EventHandler(this.chkDisable_CheckStateChanged);
            // 
            // cmdExit
            // 
            resources.ApplyResources(this.cmdExit, "cmdExit");
            this.cmdExit.AutoEllipsis = true;
            this.cmdExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            resources.ApplyResources(this.cmdSave, "cmdSave");
            this.cmdSave.AutoEllipsis = true;
            this.cmdSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Picture1
            // 
            this.Picture1.BackColor = System.Drawing.Color.White;
            this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture1.Controls.Add(this.csthidden);
            this.Picture1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Picture1, "Picture1");
            this.Picture1.Name = "Picture1";
            this.Picture1.TabStop = true;
            // 
            // csthidden
            // 
            resources.ApplyResources(this.csthidden, "csthidden");
            this.csthidden.Name = "csthidden";
            this.csthidden.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("csthidden.OcxState")));
            // 
            // lblBillingEntity
            // 
            this.lblBillingEntity.AutoEllipsis = true;
            this.lblBillingEntity.BackColor = System.Drawing.Color.Transparent;
            this.lblBillingEntity.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.lblBillingEntity, "lblBillingEntity");
            this.lblBillingEntity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBillingEntity.Name = "lblBillingEntity";
            // 
            // lblDunningCd
            // 
            this.lblDunningCd.AutoEllipsis = true;
            this.lblDunningCd.BackColor = System.Drawing.Color.Transparent;
            this.lblDunningCd.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.lblDunningCd, "lblDunningCd");
            this.lblDunningCd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDunningCd.Name = "lblDunningCd";
            // 
            // cernerStyledTableLayoutPanel1
            // 
            this.cernerStyledTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cernerStyledTableLayoutPanel1, "cernerStyledTableLayoutPanel1");
            this.cernerStyledTableLayoutPanel1.Controls.Add(this.Toolbar1, 0, 0);
            this.cernerStyledTableLayoutPanel1.Controls.Add(this.cernerStyledTableLayoutPanel2, 0, 1);
            this.cernerStyledTableLayoutPanel1.Name = "cernerStyledTableLayoutPanel1";
            // 
            // cernerStyledTableLayoutPanel2
            // 
            this.cernerStyledTableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cernerStyledTableLayoutPanel2, "cernerStyledTableLayoutPanel2");
            this.cernerStyledTableLayoutPanel2.Controls.Add(this.lblBillingEntity, 0, 0);
            this.cernerStyledTableLayoutPanel2.Controls.Add(this.cmdBESearch, 2, 0);
            this.cernerStyledTableLayoutPanel2.Controls.Add(this.cernerStyledTableLayoutPanel3, 0, 3);
            this.cernerStyledTableLayoutPanel2.Controls.Add(this.chkDisable, 2, 1);
            this.cernerStyledTableLayoutPanel2.Controls.Add(this.cmbDunningCd, 1, 1);
            this.cernerStyledTableLayoutPanel2.Controls.Add(this.txtBillingEntity, 1, 0);
            this.cernerStyledTableLayoutPanel2.Controls.Add(this.lblDunningCd, 0, 1);
            this.cernerStyledTableLayoutPanel2.Controls.Add(this.Picture2, 0, 2);
            this.cernerStyledTableLayoutPanel2.Name = "cernerStyledTableLayoutPanel2";
            // 
            // cernerStyledTableLayoutPanel3
            // 
            this.cernerStyledTableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cernerStyledTableLayoutPanel3, "cernerStyledTableLayoutPanel3");
            this.cernerStyledTableLayoutPanel2.SetColumnSpan(this.cernerStyledTableLayoutPanel3, 3);
            this.cernerStyledTableLayoutPanel3.Controls.Add(this.Picture1, 0, 0);
            this.cernerStyledTableLayoutPanel3.Controls.Add(this.cmdExit, 2, 0);
            this.cernerStyledTableLayoutPanel3.Controls.Add(this.cmdSave, 1, 0);
            this.cernerStyledTableLayoutPanel3.Name = "cernerStyledTableLayoutPanel3";
            // 
            // frmCollectionLetter
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cernerStyledTableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCollectionLetter";
            this.Activated += new System.EventHandler(this.frmCollectionLetter_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCollectionLetter_FormClosing);
            this.Load += new System.EventHandler(this.frmCollectionLetter_Load);
            this.Toolbar1.ResumeLayout(false);
            this.Toolbar1.PerformLayout();
            this.Picture2.ResumeLayout(false);
            this.cernerStyledTableLayoutPanel4.ResumeLayout(false);
            this.cernerStyledTableLayoutPanel4.PerformLayout();
            this.Picture1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.csthidden)).EndInit();
            this.cernerStyledTableLayoutPanel1.ResumeLayout(false);
            this.cernerStyledTableLayoutPanel1.PerformLayout();
            this.cernerStyledTableLayoutPanel2.ResumeLayout(false);
            this.cernerStyledTableLayoutPanel2.PerformLayout();
            this.cernerStyledTableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        void InitializetxtLetter()
        {
            this.txtLetter[1] = _txtLetter_1;
            this.txtLetter[2] = _txtLetter_2;
            this.txtLetter[3] = _txtLetter_3;
            this.txtLetter[4] = _txtLetter_4;
            this.txtLetter[5] = _txtLetter_5;
            this.txtLetter[6] = _txtLetter_6;
            this.txtLetter[7] = _txtLetter_7;
            this.txtLetter[8] = _txtLetter_8;
            this.txtLetter[9] = _txtLetter_9;
            this.txtLetter[10] = _txtLetter_10;
            this.txtLetter[11] = _txtLetter_11;
            this.txtLetter[12] = _txtLetter_12;
            this.txtLetter[13] = _txtLetter_13;
            this.txtLetter[14] = _txtLetter_14;
            this.txtLetter[15] = _txtLetter_15;
        }
        #endregion

        private ApplicationFramework.GUI.CernerStyledControls.CernerStyledTableLayoutPanel cernerStyledTableLayoutPanel2;
        private ApplicationFramework.GUI.CernerStyledControls.CernerStyledTableLayoutPanel cernerStyledTableLayoutPanel1;
        private ApplicationFramework.GUI.CernerStyledControls.CernerStyledTableLayoutPanel cernerStyledTableLayoutPanel3;
        private ApplicationFramework.GUI.CernerStyledControls.CernerStyledTableLayoutPanel cernerStyledTableLayoutPanel4;
    }
}