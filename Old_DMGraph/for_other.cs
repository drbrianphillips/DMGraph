using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.XPath;
using System.Threading;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;



namespace Skaggs_Method
{
    /// <summary>
    /// Skaggs Method Lateral Effect Program
    /// **********************************************************************
    /// Created by Brian D. Phillips,M.S.,E.I.
    /// Research Associate
    /// Department of Biological and Agricultural Engineering
    /// North Carolina State University
    /// Copyright 2006-2009. All rights reserved.
    /// **********************************************************************
    /// Boussinesq Routine by R Wayne Skaggs PhD, PE
    /// William Neal Reynolds and Distinguished University Professor
    /// Department of Biological and Agricultural Engineering
    /// North Carolina State University
    /// Copyright 1976 . All rights reserved
    /// **********************************************************************    
    /// Version Information
    /// Visual C# .NET 2008
    /// Requires .NE Framework 2.0 or higher
    /// Contact brian_phillips@ncsu.edu
    /// Current Version : 2.0.5
    /// Current Date: July 2009
    /// **********************************************************************
    /// </summary>
    /// 

    public class MainProgram : System.Windows.Forms.Form



    #region "Windows Initialization"

    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuConfirm;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.TextBox textDitchPorosity;
        private System.Windows.Forms.TextBox textDitchImpermeable;
        private System.Windows.Forms.Button btnDitchCalculate;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuUnitConversion;
        private System.Windows.Forms.MenuItem mnuSaveProject;
        private System.Windows.Forms.MenuItem mnuOpenProject;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textLateralEffect;
        private System.Windows.Forms.MenuItem menuViewSummary;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textProjectName;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuItem menuDiagram;
        private System.Windows.Forms.MenuItem menuDitchDiagram;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenu contextMenuImpoundment;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.TextBox textSoilSeries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuItem menuImpoundmentHelp;
        private System.Windows.Forms.MenuItem menuImpoundmentDitch;
        private System.Windows.Forms.MenuItem menuImpoundmentPit;
        private System.Windows.Forms.ContextMenu contextMenuStorage;
        private System.Windows.Forms.ContextMenu contextMenuDepth;
        private System.Windows.Forms.ContextMenu contextMenuOther;
        private System.Windows.Forms.ContextMenu contextMenuConductivity;
        private System.Windows.Forms.MenuItem menuStorageHelp;
        private System.Windows.Forms.MenuItem menuDepthHelp;
        private System.Windows.Forms.MenuItem menuOtherHelp;
        private System.Windows.Forms.MenuItem menuConductivityHelp;
        private System.Windows.Forms.ContextMenu contextSoilSurvey;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuClearCells;
        private TextBox textHydroperiod;
        private MenuItem menuUpdate;
        private Label label15;
        private TextBox textLocation;
        private Label label14;
        private TextBox textDepartment;
        private Label label12;
        private TextBox textCompany;
        private Label label17;
        private TextBox textCoordinates;
        private Label label16;
        private TextBox textNotes;
        private MenuItem menuTutorials;
        private ComboBox comboCounty;
        private ComboBox comboState;
        private Label label21;
        private Label label20;
        private TextBox textDitchDepth;
        private MenuItem menuImport;
        private ComboBox comboStorage;
        private MenuItem menuEnglishMetric;
        private MenuItem menuClearNotProject;
        private OpenFileDialog openFileDialog2;
        private MenuItem menVer;
        private ComboBox comboSoilSurvey;
        private RadioButton radioSSLat;
        private RadioButton radioUserLat;
        private TextBox textLayer5Average;
        private TextBox textLayer5High;
        private TextBox textLayer5Low;
        private TextBox textLayer5Bottom;
        private TextBox textLayer4Average;
        private TextBox textLayer4High;
        private TextBox textLayer4Low;
        private TextBox textLayer4Bottom;
        private TextBox textLayer3Average;
        private TextBox textLayer3High;
        private TextBox textLayer3Low;
        private TextBox textLayer3Bottom;
        private TextBox textLayer2Average;
        private TextBox textLayer2High;
        private TextBox textLayer2Low;
        private TextBox textLayer2Bottom;
        private TextBox textLayer1Average;
        private TextBox textLayer1High;
        private TextBox textLayer1Low;
        private TextBox textLayer1Bottom;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private RadioButton radioExportAverage;
        private RadioButton radioExportHigh;
        private RadioButton radioExportLow;
        private GroupBox groupSSK;
        private Label label22;
        private GroupBox groupUserK;
        private TextBox textDepthLayer1;
        private TextBox textDepthLayer5;
        private TextBox textDepthLayer2;
        private TextBox textKLayer5;
        private Label label13;
        private Label label10;
        private TextBox textDepthLayer3;
        private TextBox textKLayer4;
        private TextBox textDepthLayer4;
        private TextBox textKLayer2;
        private TextBox textKLayer3;
        private TextBox textKLayer1;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label11;
        private GroupBox groupBox1;
        private RadioButton radio14Days;
        private RadioButton radioPercent;
        private GroupBox groupBox2;
        private CheckBox checkBoxOverride;
        private Label label18;
        private TextBox textT25Override;
        private Label label23;
        private Label label19;
        private TextBox textDepthLayer8;
        private TextBox textKLayer8;
        private TextBox textDepthLayer6;
        private TextBox textKLayer7;
        private TextBox textDepthLayer7;
        private TextBox textKLayer6;
        private Label label24;
        private Label label25;
        private Label label30;
        private TextBox textLayer8Average;
        private TextBox textLayer8High;
        private TextBox textLayer8Low;
        private TextBox textLayer8Bottom;
        private TextBox textLayer7Average;
        private TextBox textLayer7High;
        private TextBox textLayer7Low;
        private TextBox textLayer7Bottom;
        private TextBox textLayer6Average;
        private TextBox textLayer6High;
        private TextBox textLayer6Low;
        private TextBox textLayer6Bottom;
        private MenuItem menuMetric;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private System.ComponentModel.IContainer components;

        public MainProgram()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

    #endregion


        #region "Windows Form Designer generated code"
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOpenProject = new System.Windows.Forms.MenuItem();
            this.mnuSaveProject = new System.Windows.Forms.MenuItem();
            this.menuImport = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuConfirm = new System.Windows.Forms.MenuItem();
            this.menuViewSummary = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuClearCells = new System.Windows.Forms.MenuItem();
            this.menuClearNotProject = new System.Windows.Forms.MenuItem();
            this.menuEnglishMetric = new System.Windows.Forms.MenuItem();
            this.menuMetric = new System.Windows.Forms.MenuItem();
            this.mnuUnitConversion = new System.Windows.Forms.MenuItem();
            this.menuDiagram = new System.Windows.Forms.MenuItem();
            this.menuDitchDiagram = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.menuTutorials = new System.Windows.Forms.MenuItem();
            this.menuUpdate = new System.Windows.Forms.MenuItem();
            this.menVer = new System.Windows.Forms.MenuItem();
            this.textDitchPorosity = new System.Windows.Forms.TextBox();
            this.textDitchImpermeable = new System.Windows.Forms.TextBox();
            this.btnDitchCalculate = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.contextMenuImpoundment = new System.Windows.Forms.ContextMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuImpoundmentHelp = new System.Windows.Forms.MenuItem();
            this.menuImpoundmentDitch = new System.Windows.Forms.MenuItem();
            this.menuImpoundmentPit = new System.Windows.Forms.MenuItem();
            this.contextMenuDepth = new System.Windows.Forms.ContextMenu();
            this.menuDepthHelp = new System.Windows.Forms.MenuItem();
            this.contextMenuStorage = new System.Windows.Forms.ContextMenu();
            this.menuStorageHelp = new System.Windows.Forms.MenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contextMenuOther = new System.Windows.Forms.ContextMenu();
            this.menuOtherHelp = new System.Windows.Forms.MenuItem();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio14Days = new System.Windows.Forms.RadioButton();
            this.radioPercent = new System.Windows.Forms.RadioButton();
            this.textHydroperiod = new System.Windows.Forms.TextBox();
            this.comboStorage = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxOverride = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textT25Override = new System.Windows.Forms.TextBox();
            this.comboCounty = new System.Windows.Forms.ComboBox();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.textDitchDepth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.contextMenuConductivity = new System.Windows.Forms.ContextMenu();
            this.menuConductivityHelp = new System.Windows.Forms.MenuItem();
            this.groupSSK = new System.Windows.Forms.GroupBox();
            this.textLayer8Average = new System.Windows.Forms.TextBox();
            this.textLayer8High = new System.Windows.Forms.TextBox();
            this.textLayer8Low = new System.Windows.Forms.TextBox();
            this.textLayer8Bottom = new System.Windows.Forms.TextBox();
            this.textLayer7Average = new System.Windows.Forms.TextBox();
            this.textLayer7High = new System.Windows.Forms.TextBox();
            this.textLayer7Low = new System.Windows.Forms.TextBox();
            this.textLayer7Bottom = new System.Windows.Forms.TextBox();
            this.textLayer6Average = new System.Windows.Forms.TextBox();
            this.textLayer6High = new System.Windows.Forms.TextBox();
            this.textLayer6Low = new System.Windows.Forms.TextBox();
            this.textLayer6Bottom = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.radioExportHigh = new System.Windows.Forms.RadioButton();
            this.radioExportAverage = new System.Windows.Forms.RadioButton();
            this.radioExportLow = new System.Windows.Forms.RadioButton();
            this.textLayer5Average = new System.Windows.Forms.TextBox();
            this.textLayer5High = new System.Windows.Forms.TextBox();
            this.textLayer5Low = new System.Windows.Forms.TextBox();
            this.textLayer5Bottom = new System.Windows.Forms.TextBox();
            this.textLayer4Average = new System.Windows.Forms.TextBox();
            this.textLayer4High = new System.Windows.Forms.TextBox();
            this.textLayer4Low = new System.Windows.Forms.TextBox();
            this.textLayer4Bottom = new System.Windows.Forms.TextBox();
            this.textLayer3Average = new System.Windows.Forms.TextBox();
            this.textLayer3High = new System.Windows.Forms.TextBox();
            this.textLayer3Low = new System.Windows.Forms.TextBox();
            this.textLayer3Bottom = new System.Windows.Forms.TextBox();
            this.textLayer2Average = new System.Windows.Forms.TextBox();
            this.textLayer2High = new System.Windows.Forms.TextBox();
            this.textLayer2Low = new System.Windows.Forms.TextBox();
            this.textLayer2Bottom = new System.Windows.Forms.TextBox();
            this.textLayer1Average = new System.Windows.Forms.TextBox();
            this.textLayer1High = new System.Windows.Forms.TextBox();
            this.textLayer1Low = new System.Windows.Forms.TextBox();
            this.textLayer1Bottom = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupUserK = new System.Windows.Forms.GroupBox();
            this.textDepthLayer8 = new System.Windows.Forms.TextBox();
            this.textKLayer8 = new System.Windows.Forms.TextBox();
            this.textDepthLayer6 = new System.Windows.Forms.TextBox();
            this.textKLayer7 = new System.Windows.Forms.TextBox();
            this.textDepthLayer7 = new System.Windows.Forms.TextBox();
            this.textKLayer6 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textDepthLayer1 = new System.Windows.Forms.TextBox();
            this.textDepthLayer5 = new System.Windows.Forms.TextBox();
            this.textDepthLayer2 = new System.Windows.Forms.TextBox();
            this.textKLayer5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textDepthLayer3 = new System.Windows.Forms.TextBox();
            this.textKLayer4 = new System.Windows.Forms.TextBox();
            this.textDepthLayer4 = new System.Windows.Forms.TextBox();
            this.textKLayer2 = new System.Windows.Forms.TextBox();
            this.textKLayer3 = new System.Windows.Forms.TextBox();
            this.textKLayer1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.comboSoilSurvey = new System.Windows.Forms.ComboBox();
            this.radioSSLat = new System.Windows.Forms.RadioButton();
            this.radioUserLat = new System.Windows.Forms.RadioButton();
            this.textLateralEffect = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textCoordinates = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSoilSeries = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textProjectName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextSoilSurvey = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupSSK.SuspendLayout();
            this.groupUserK.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.menuViewSummary,
            this.menuItem2,
            this.menuEnglishMetric,
            this.mnuUnitConversion,
            this.menuDiagram,
            this.mnuHelp,
            this.menuTutorials,
            this.menuUpdate,
            this.menVer});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOpenProject,
            this.mnuSaveProject,
            this.menuImport,
            this.mnuExit,
            this.mnuConfirm});
            this.mnuFile.Text = "&File";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.Index = 0;
            this.mnuOpenProject.Text = "&Open Project";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuSaveProject
            // 
            this.mnuSaveProject.Index = 1;
            this.mnuSaveProject.Text = "&Save Project";
            this.mnuSaveProject.Click += new System.EventHandler(this.mnuSaveProject_Click);
            // 
            // menuImport
            // 
            this.menuImport.Index = 2;
            this.menuImport.Text = "&Import Version 1 Project";
            this.menuImport.Click += new System.EventHandler(this.menuImport_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 3;
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuConfirm
            // 
            this.mnuConfirm.Checked = true;
            this.mnuConfirm.Index = 4;
            this.mnuConfirm.Text = "&Confim on Exit";
            this.mnuConfirm.Click += new System.EventHandler(this.mnuConfirm_Click);
            // 
            // menuViewSummary
            // 
            this.menuViewSummary.Index = 1;
            this.menuViewSummary.Text = "&View Output";
            this.menuViewSummary.Click += new System.EventHandler(this.menuViewSummary_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuClearCells,
            this.menuClearNotProject});
            this.menuItem2.Text = "&New Project";
            // 
            // menuClearCells
            // 
            this.menuClearCells.Index = 0;
            this.menuClearCells.Text = "&Clear all cells and start new project";
            this.menuClearCells.Click += new System.EventHandler(this.menuClearCells_Click);
            // 
            // menuClearNotProject
            // 
            this.menuClearNotProject.Index = 1;
            this.menuClearNotProject.Text = "&Clear all  cells except \'Project Information\'";
            this.menuClearNotProject.Click += new System.EventHandler(this.menuClearNotProject_Click);
            // 
            // menuEnglishMetric
            // 
            this.menuEnglishMetric.Index = 3;
            this.menuEnglishMetric.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuMetric});
            this.menuEnglishMetric.Text = "&Use Metric Version";
            this.menuEnglishMetric.Click += new System.EventHandler(this.menuMetric_Click);
            // 
            // menuMetric
            // 
            this.menuMetric.Index = 0;
            this.menuMetric.Text = "&Metric";
            this.menuMetric.Click += new System.EventHandler(this.menuMetric_Click);
            // 
            // mnuUnitConversion
            // 
            this.mnuUnitConversion.Index = 4;
            this.mnuUnitConversion.Text = "&Convert Units Utility";
            this.mnuUnitConversion.Click += new System.EventHandler(this.mnuUnitConversion_Click);
            // 
            // menuDiagram
            // 
            this.menuDiagram.Index = 5;
            this.menuDiagram.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuDitchDiagram});
            this.menuDiagram.Text = "&Diagrams";
            // 
            // menuDitchDiagram
            // 
            this.menuDitchDiagram.Index = 0;
            this.menuDitchDiagram.Text = "&Roadside Ditch";
            this.menuDitchDiagram.Click += new System.EventHandler(this.menuDitchDiagram_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 6;
            this.mnuHelp.Text = "&Help File";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // menuTutorials
            // 
            this.menuTutorials.Index = 7;
            this.menuTutorials.Text = "&Tutorials and Support";
            this.menuTutorials.Click += new System.EventHandler(this.menuTutorials_Click);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Index = 8;
            this.menuUpdate.Text = "&Check for Updates";
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // menVer
            // 
            this.menVer.Index = 9;
            this.menVer.Text = "&Version Info";
            this.menVer.Click += new System.EventHandler(this.menVer_Click);
            // 
            // textDitchPorosity
            // 
            this.textDitchPorosity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDitchPorosity.Location = new System.Drawing.Point(293, 132);
            this.textDitchPorosity.MaxLength = 10;
            this.textDitchPorosity.Name = "textDitchPorosity";
            this.textDitchPorosity.Size = new System.Drawing.Size(57, 21);
            this.textDitchPorosity.TabIndex = 39;
            this.textDitchPorosity.Text = "0";
            this.textDitchPorosity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDitchPorosity_KeyPress);
            // 
            // textDitchImpermeable
            // 
            this.textDitchImpermeable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDitchImpermeable.Location = new System.Drawing.Point(293, 88);
            this.textDitchImpermeable.MaxLength = 10;
            this.textDitchImpermeable.Name = "textDitchImpermeable";
            this.textDitchImpermeable.Size = new System.Drawing.Size(57, 21);
            this.textDitchImpermeable.TabIndex = 37;
            this.textDitchImpermeable.Text = "0";
            this.textDitchImpermeable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDitchImpermeable_KeyPress);
            // 
            // btnDitchCalculate
            // 
            this.btnDitchCalculate.BackColor = System.Drawing.Color.LightGray;
            this.btnDitchCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDitchCalculate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDitchCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDitchCalculate.Location = new System.Drawing.Point(381, 623);
            this.btnDitchCalculate.Name = "btnDitchCalculate";
            this.btnDitchCalculate.Size = new System.Drawing.Size(269, 31);
            this.btnDitchCalculate.TabIndex = 10000;
            this.btnDitchCalculate.Text = "Calculate Lateral Effect ";
            this.toolTip1.SetToolTip(this.btnDitchCalculate, "Program will check for input errors prior to calculations");
            this.btnDitchCalculate.UseVisualStyleBackColor = false;
            this.btnDitchCalculate.Click += new System.EventHandler(this.btnDitchCalculate_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar1.Location = new System.Drawing.Point(0, 664);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(1158, 24);
            this.statusBar1.TabIndex = 130;
            this.statusBar1.Text = "Lateral Effect  Version 2.1.1    Brian D. Phillips and R. Wayne Skaggs   Copyrigh" +
                "t 2006-2009";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = -1;
            this.menuItem4.Text = "Choose either roadside ditch or borrow pit and then choose county from drop-down " +
                "box";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = -1;
            this.menuItem5.Text = "-";
            // 
            // menuImpoundmentHelp
            // 
            this.menuImpoundmentHelp.Index = -1;
            this.menuImpoundmentHelp.Text = "&Help with this item";
            // 
            // menuImpoundmentDitch
            // 
            this.menuImpoundmentDitch.Index = -1;
            this.menuImpoundmentDitch.Text = "&Roadside Ditch Diagram";
            // 
            // menuImpoundmentPit
            // 
            this.menuImpoundmentPit.Index = -1;
            this.menuImpoundmentPit.Text = "";
            // 
            // contextMenuDepth
            // 
            this.contextMenuDepth.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuDepthHelp});
            // 
            // menuDepthHelp
            // 
            this.menuDepthHelp.Index = 0;
            this.menuDepthHelp.Text = "&Help for this topic";
            // 
            // contextMenuStorage
            // 
            this.contextMenuStorage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuStorageHelp});
            // 
            // menuStorageHelp
            // 
            this.menuStorageHelp.Index = 0;
            this.menuStorageHelp.Text = "&Help for this topic";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.ContextMenu = this.contextMenuOther;
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.comboStorage);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.comboCounty);
            this.groupBox4.Controls.Add(this.comboState);
            this.groupBox4.Controls.Add(this.textDitchDepth);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textDitchPorosity);
            this.groupBox4.Controls.Add(this.textDitchImpermeable);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(312, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(830, 180);
            this.groupBox4.TabIndex = 5000;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input Parameters";
            // 
            // contextMenuOther
            // 
            this.contextMenuOther.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOtherHelp});
            // 
            // menuOtherHelp
            // 
            this.menuOtherHelp.Index = 0;
            this.menuOtherHelp.Text = "&Help for this topic";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(23, 68);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(180, 17);
            this.label23.TabIndex = 170;
            this.label23.Text = "County";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(23, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 22);
            this.label19.TabIndex = 169;
            this.label19.Text = "State";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio14Days);
            this.groupBox1.Controls.Add(this.radioPercent);
            this.groupBox1.Controls.Add(this.textHydroperiod);
            this.groupBox1.Location = new System.Drawing.Point(559, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 79);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hydroperiod";
            this.toolTip1.SetToolTip(this.groupBox1, "Consecutive days during growing season when water table is less than 1 ft depth");
            // 
            // radio14Days
            // 
            this.radio14Days.AutoSize = true;
            this.radio14Days.Location = new System.Drawing.Point(10, 45);
            this.radio14Days.Name = "radio14Days";
            this.radio14Days.Size = new System.Drawing.Size(74, 19);
            this.radio14Days.TabIndex = 29;
            this.radio14Days.TabStop = true;
            this.radio14Days.Text = "14 days";
            this.radio14Days.UseVisualStyleBackColor = true;
            // 
            // radioPercent
            // 
            this.radioPercent.AutoSize = true;
            this.radioPercent.Checked = true;
            this.radioPercent.Location = new System.Drawing.Point(10, 20);
            this.radioPercent.Name = "radioPercent";
            this.radioPercent.Size = new System.Drawing.Size(199, 19);
            this.radioPercent.TabIndex = 27;
            this.radioPercent.TabStop = true;
            this.radioPercent.Text = "Percent of Growing Season";
            this.toolTip1.SetToolTip(this.radioPercent, "Currently, only 5% values are included in model.");
            this.radioPercent.UseVisualStyleBackColor = true;
            // 
            // textHydroperiod
            // 
            this.textHydroperiod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textHydroperiod.Location = new System.Drawing.Point(215, 19);
            this.textHydroperiod.MaxLength = 3;
            this.textHydroperiod.Name = "textHydroperiod";
            this.textHydroperiod.Size = new System.Drawing.Size(31, 21);
            this.textHydroperiod.TabIndex = 31;
            this.textHydroperiod.Text = "5";
            this.textHydroperiod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHydroperiod_KeyPress);
            // 
            // comboStorage
            // 
            this.comboStorage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStorage.FormattingEnabled = true;
            this.comboStorage.Items.AddRange(new object[] {
            "1 in (2.5 cm)",
            "2 in (5.0 cm)"});
            this.comboStorage.Location = new System.Drawing.Point(26, 132);
            this.comboStorage.Name = "comboStorage";
            this.comboStorage.Size = new System.Drawing.Size(105, 23);
            this.comboStorage.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxOverride);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textT25Override);
            this.groupBox2.Location = new System.Drawing.Point(559, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 75);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "T25 Override";
            // 
            // checkBoxOverride
            // 
            this.checkBoxOverride.AutoSize = true;
            this.checkBoxOverride.Location = new System.Drawing.Point(11, 20);
            this.checkBoxOverride.Name = "checkBoxOverride";
            this.checkBoxOverride.Size = new System.Drawing.Size(198, 19);
            this.checkBoxOverride.TabIndex = 23;
            this.checkBoxOverride.Text = "Override Default T25 Value";
            this.toolTip1.SetToolTip(this.checkBoxOverride, "Check this box if you would like to enter your own T25 value");
            this.checkBoxOverride.UseVisualStyleBackColor = true;
            this.checkBoxOverride.CheckedChanged += new System.EventHandler(this.checkBoxOverride_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(65, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 15);
            this.label18.TabIndex = 167;
            this.label18.Text = "Enter T25 Value (days)";
            // 
            // textT25Override
            // 
            this.textT25Override.Location = new System.Drawing.Point(10, 45);
            this.textT25Override.MaxLength = 10;
            this.textT25Override.Name = "textT25Override";
            this.textT25Override.ReadOnly = true;
            this.textT25Override.Size = new System.Drawing.Size(49, 21);
            this.textT25Override.TabIndex = 25;
            this.textT25Override.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textT25Override_KeyPress);
            // 
            // comboCounty
            // 
            this.comboCounty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboCounty.FormattingEnabled = true;
            this.comboCounty.Location = new System.Drawing.Point(26, 88);
            this.comboCounty.MaxDropDownItems = 25;
            this.comboCounty.Name = "comboCounty";
            this.comboCounty.Size = new System.Drawing.Size(247, 23);
            this.comboCounty.TabIndex = 19;
            this.comboCounty.Text = "Choose County";
            this.comboCounty.SelectedIndexChanged += new System.EventHandler(this.comboCounty_SelectedIndexChanged);
            // 
            // comboState
            // 
            this.comboState.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(26, 42);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(247, 23);
            this.comboState.TabIndex = 17;
            this.comboState.Text = "Choose State";
            this.comboState.SelectedIndexChanged += new System.EventHandler(this.comboState_SelectedIndexChanged);
            // 
            // textDitchDepth
            // 
            this.textDitchDepth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDitchDepth.Location = new System.Drawing.Point(293, 42);
            this.textDitchDepth.MaxLength = 10;
            this.textDitchDepth.Name = "textDitchDepth";
            this.textDitchDepth.Size = new System.Drawing.Size(57, 21);
            this.textDitchDepth.TabIndex = 35;
            this.textDitchDepth.Text = "0";
            this.textDitchDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDitchDepth_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(358, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 158;
            this.label1.Text = "Drainable Porosity of Top 1 ft of Soil";
            this.toolTip1.SetToolTip(this.label1, "Conservative values are between 0.035 and 0.040");
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(137, 132);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(150, 38);
            this.label31.TabIndex = 173;
            this.label31.Text = "Surface Depressional Storage (cm)";
            this.toolTip1.SetToolTip(this.label31, "Conservative values are between 0.035 and 0.040");
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(356, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(194, 32);
            this.label20.TabIndex = 161;
            this.label20.Text = "Ditch Depth or Depth to Water in Pit (ft)";
            this.toolTip1.SetToolTip(this.label20, "Depth to water surface for borrow pit. ");
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(356, 42);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(194, 32);
            this.label32.TabIndex = 172;
            this.label32.Text = "Ditch Depth or Depth to Water in Pit (m)";
            this.toolTip1.SetToolTip(this.label32, "Depth to water surface for borrow pit. ");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(358, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 34);
            this.label2.TabIndex = 159;
            this.label2.Text = "Depth to Restrictive (Impermeable) Layer (ft)";
            this.toolTip1.SetToolTip(this.label2, "From ground surface");
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(356, 86);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(194, 34);
            this.label33.TabIndex = 171;
            this.label33.Text = "Depth to Restrictive (Impermeable) Layer (m)";
            this.toolTip1.SetToolTip(this.label33, "From ground surface");
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(137, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 38);
            this.label21.TabIndex = 162;
            this.label21.Text = "Surface Depressional Storage (in)";
            this.toolTip1.SetToolTip(this.label21, "Conservative values are between 0.035 and 0.040");
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.ContextMenu = this.contextMenuConductivity;
            this.groupBox5.Controls.Add(this.groupSSK);
            this.groupBox5.Controls.Add(this.groupUserK);
            this.groupBox5.Controls.Add(this.comboSoilSurvey);
            this.groupBox5.Controls.Add(this.radioSSLat);
            this.groupBox5.Controls.Add(this.radioUserLat);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(312, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(830, 409);
            this.groupBox5.TabIndex = 6000;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lateral Hydraulic Conductivity";
            this.toolTip1.SetToolTip(this.groupBox5, "At minimum, information for soil layer 1 must be filled");
            // 
            // contextMenuConductivity
            // 
            this.contextMenuConductivity.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuConductivityHelp});
            // 
            // menuConductivityHelp
            // 
            this.menuConductivityHelp.Index = 0;
            this.menuConductivityHelp.Text = "&Help for this topic";
            // 
            // groupSSK
            // 
            this.groupSSK.Controls.Add(this.textLayer8Average);
            this.groupSSK.Controls.Add(this.textLayer8High);
            this.groupSSK.Controls.Add(this.textLayer8Low);
            this.groupSSK.Controls.Add(this.textLayer8Bottom);
            this.groupSSK.Controls.Add(this.textLayer7Average);
            this.groupSSK.Controls.Add(this.textLayer7High);
            this.groupSSK.Controls.Add(this.textLayer7Low);
            this.groupSSK.Controls.Add(this.textLayer7Bottom);
            this.groupSSK.Controls.Add(this.textLayer6Average);
            this.groupSSK.Controls.Add(this.textLayer6High);
            this.groupSSK.Controls.Add(this.textLayer6Low);
            this.groupSSK.Controls.Add(this.textLayer6Bottom);
            this.groupSSK.Controls.Add(this.label22);
            this.groupSSK.Controls.Add(this.radioExportHigh);
            this.groupSSK.Controls.Add(this.radioExportAverage);
            this.groupSSK.Controls.Add(this.radioExportLow);
            this.groupSSK.Controls.Add(this.textLayer5Average);
            this.groupSSK.Controls.Add(this.textLayer5High);
            this.groupSSK.Controls.Add(this.textLayer5Low);
            this.groupSSK.Controls.Add(this.textLayer5Bottom);
            this.groupSSK.Controls.Add(this.textLayer4Average);
            this.groupSSK.Controls.Add(this.textLayer4High);
            this.groupSSK.Controls.Add(this.textLayer4Low);
            this.groupSSK.Controls.Add(this.textLayer4Bottom);
            this.groupSSK.Controls.Add(this.textLayer3Average);
            this.groupSSK.Controls.Add(this.textLayer3High);
            this.groupSSK.Controls.Add(this.textLayer3Low);
            this.groupSSK.Controls.Add(this.textLayer3Bottom);
            this.groupSSK.Controls.Add(this.textLayer2Average);
            this.groupSSK.Controls.Add(this.textLayer2High);
            this.groupSSK.Controls.Add(this.textLayer2Low);
            this.groupSSK.Controls.Add(this.textLayer2Bottom);
            this.groupSSK.Controls.Add(this.textLayer1Average);
            this.groupSSK.Controls.Add(this.textLayer1High);
            this.groupSSK.Controls.Add(this.textLayer1Low);
            this.groupSSK.Controls.Add(this.textLayer1Bottom);
            this.groupSSK.Controls.Add(this.label26);
            this.groupSSK.Controls.Add(this.label27);
            this.groupSSK.Controls.Add(this.label28);
            this.groupSSK.Controls.Add(this.label29);
            this.groupSSK.Controls.Add(this.label36);
            this.groupSSK.Controls.Add(this.label37);
            this.groupSSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSSK.ForeColor = System.Drawing.Color.White;
            this.groupSSK.Location = new System.Drawing.Point(355, 71);
            this.groupSSK.Name = "groupSSK";
            this.groupSSK.Size = new System.Drawing.Size(443, 314);
            this.groupSSK.TabIndex = 6500;
            this.groupSSK.TabStop = false;
            this.groupSSK.Text = "Soil Survey Conductivity Values";
            // 
            // textLayer8Average
            // 
            this.textLayer8Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLayer8Average.Location = new System.Drawing.Point(344, 268);
            this.textLayer8Average.MaxLength = 6;
            this.textLayer8Average.Name = "textLayer8Average";
            this.textLayer8Average.ReadOnly = true;
            this.textLayer8Average.Size = new System.Drawing.Size(64, 21);
            this.textLayer8Average.TabIndex = 9056;
            this.textLayer8Average.TabStop = false;
            this.textLayer8Average.Text = "0";
            this.textLayer8Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLayer8High
            // 
            this.textLayer8High.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer8High.Location = new System.Drawing.Point(231, 269);
            this.textLayer8High.MaxLength = 6;
            this.textLayer8High.Name = "textLayer8High";
            this.textLayer8High.ReadOnly = true;
            this.textLayer8High.Size = new System.Drawing.Size(64, 21);
            this.textLayer8High.TabIndex = 9065;
            this.textLayer8High.TabStop = false;
            this.textLayer8High.Text = "0";
            this.textLayer8High.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer8High.TextChanged += new System.EventHandler(this.textLayer8High_TextChanged);
            // 
            // textLayer8Low
            // 
            this.textLayer8Low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer8Low.Location = new System.Drawing.Point(125, 269);
            this.textLayer8Low.MaxLength = 6;
            this.textLayer8Low.Name = "textLayer8Low";
            this.textLayer8Low.ReadOnly = true;
            this.textLayer8Low.Size = new System.Drawing.Size(64, 21);
            this.textLayer8Low.TabIndex = 9064;
            this.textLayer8Low.TabStop = false;
            this.textLayer8Low.Text = "0";
            this.textLayer8Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer8Low.TextChanged += new System.EventHandler(this.textLayer8Low_TextChanged);
            // 
            // textLayer8Bottom
            // 
            this.textLayer8Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer8Bottom.Location = new System.Drawing.Point(21, 269);
            this.textLayer8Bottom.MaxLength = 6;
            this.textLayer8Bottom.Name = "textLayer8Bottom";
            this.textLayer8Bottom.Size = new System.Drawing.Size(64, 21);
            this.textLayer8Bottom.TabIndex = 9063;
            this.textLayer8Bottom.TabStop = false;
            this.textLayer8Bottom.Text = "0";
            this.textLayer8Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer8Bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayer8Bottom_KeyPress);
            // 
            // textLayer7Average
            // 
            this.textLayer7Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLayer7Average.Location = new System.Drawing.Point(344, 240);
            this.textLayer7Average.MaxLength = 6;
            this.textLayer7Average.Name = "textLayer7Average";
            this.textLayer7Average.ReadOnly = true;
            this.textLayer7Average.Size = new System.Drawing.Size(64, 21);
            this.textLayer7Average.TabIndex = 9055;
            this.textLayer7Average.TabStop = false;
            this.textLayer7Average.Text = "0";
            this.textLayer7Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLayer7High
            // 
            this.textLayer7High.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer7High.Location = new System.Drawing.Point(231, 241);
            this.textLayer7High.MaxLength = 6;
            this.textLayer7High.Name = "textLayer7High";
            this.textLayer7High.ReadOnly = true;
            this.textLayer7High.Size = new System.Drawing.Size(64, 21);
            this.textLayer7High.TabIndex = 9062;
            this.textLayer7High.TabStop = false;
            this.textLayer7High.Text = "0";
            this.textLayer7High.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer7High.TextChanged += new System.EventHandler(this.textLayer7High_TextChanged);
            // 
            // textLayer7Low
            // 
            this.textLayer7Low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer7Low.Location = new System.Drawing.Point(125, 241);
            this.textLayer7Low.MaxLength = 6;
            this.textLayer7Low.Name = "textLayer7Low";
            this.textLayer7Low.ReadOnly = true;
            this.textLayer7Low.Size = new System.Drawing.Size(64, 21);
            this.textLayer7Low.TabIndex = 9061;
            this.textLayer7Low.TabStop = false;
            this.textLayer7Low.Text = "0";
            this.textLayer7Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer7Low.TextChanged += new System.EventHandler(this.textLayer7Low_TextChanged);
            // 
            // textLayer7Bottom
            // 
            this.textLayer7Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer7Bottom.Location = new System.Drawing.Point(21, 241);
            this.textLayer7Bottom.MaxLength = 6;
            this.textLayer7Bottom.Name = "textLayer7Bottom";
            this.textLayer7Bottom.Size = new System.Drawing.Size(64, 21);
            this.textLayer7Bottom.TabIndex = 9060;
            this.textLayer7Bottom.TabStop = false;
            this.textLayer7Bottom.Text = "0";
            this.textLayer7Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer7Bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayer7Bottom_KeyPress);
            // 
            // textLayer6Average
            // 
            this.textLayer6Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLayer6Average.Location = new System.Drawing.Point(344, 215);
            this.textLayer6Average.MaxLength = 6;
            this.textLayer6Average.Name = "textLayer6Average";
            this.textLayer6Average.ReadOnly = true;
            this.textLayer6Average.Size = new System.Drawing.Size(64, 21);
            this.textLayer6Average.TabIndex = 9054;
            this.textLayer6Average.TabStop = false;
            this.textLayer6Average.Text = "0";
            this.textLayer6Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLayer6High
            // 
            this.textLayer6High.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer6High.Location = new System.Drawing.Point(231, 216);
            this.textLayer6High.MaxLength = 6;
            this.textLayer6High.Name = "textLayer6High";
            this.textLayer6High.ReadOnly = true;
            this.textLayer6High.Size = new System.Drawing.Size(64, 21);
            this.textLayer6High.TabIndex = 9059;
            this.textLayer6High.TabStop = false;
            this.textLayer6High.Text = "0";
            this.textLayer6High.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer6High.TextChanged += new System.EventHandler(this.textLayer6High_TextChanged);
            // 
            // textLayer6Low
            // 
            this.textLayer6Low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer6Low.Location = new System.Drawing.Point(125, 216);
            this.textLayer6Low.MaxLength = 6;
            this.textLayer6Low.Name = "textLayer6Low";
            this.textLayer6Low.ReadOnly = true;
            this.textLayer6Low.Size = new System.Drawing.Size(64, 21);
            this.textLayer6Low.TabIndex = 9058;
            this.textLayer6Low.TabStop = false;
            this.textLayer6Low.Text = "0";
            this.textLayer6Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer6Low.TextChanged += new System.EventHandler(this.textLayer6Low_TextChanged);
            // 
            // textLayer6Bottom
            // 
            this.textLayer6Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer6Bottom.Location = new System.Drawing.Point(21, 216);
            this.textLayer6Bottom.MaxLength = 6;
            this.textLayer6Bottom.Name = "textLayer6Bottom";
            this.textLayer6Bottom.Size = new System.Drawing.Size(64, 21);
            this.textLayer6Bottom.TabIndex = 9057;
            this.textLayer6Bottom.TabStop = false;
            this.textLayer6Bottom.Text = "0";
            this.textLayer6Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer6Bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayer6Bottom_KeyPress);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(3, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 56);
            this.label22.TabIndex = 9053;
            this.label22.Text = "Depth to bottom of layer (in)";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label22, "Depth from ground surface to bottom of the particular soil layer");
            // 
            // radioExportHigh
            // 
            this.radioExportHigh.Location = new System.Drawing.Point(231, 288);
            this.radioExportHigh.Name = "radioExportHigh";
            this.radioExportHigh.Size = new System.Drawing.Size(98, 24);
            this.radioExportHigh.TabIndex = 4;
            this.radioExportHigh.Text = "Use High K";
            // 
            // radioExportAverage
            // 
            this.radioExportAverage.Checked = true;
            this.radioExportAverage.Location = new System.Drawing.Point(344, 288);
            this.radioExportAverage.Name = "radioExportAverage";
            this.radioExportAverage.Size = new System.Drawing.Size(91, 24);
            this.radioExportAverage.TabIndex = 5560;
            this.radioExportAverage.TabStop = true;
            this.radioExportAverage.Text = "Use Avg K";
            // 
            // radioExportLow
            // 
            this.radioExportLow.Location = new System.Drawing.Point(125, 288);
            this.radioExportLow.Name = "radioExportLow";
            this.radioExportLow.Size = new System.Drawing.Size(109, 24);
            this.radioExportLow.TabIndex = 6;
            this.radioExportLow.Text = "Use Low K";
            // 
            // textLayer5Average
            // 
            this.textLayer5Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLayer5Average.Location = new System.Drawing.Point(344, 189);
            this.textLayer5Average.MaxLength = 6;
            this.textLayer5Average.Name = "textLayer5Average";
            this.textLayer5Average.ReadOnly = true;
            this.textLayer5Average.Size = new System.Drawing.Size(64, 21);
            this.textLayer5Average.TabIndex = 9032;
            this.textLayer5Average.TabStop = false;
            this.textLayer5Average.Text = "0";
            this.textLayer5Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLayer5High
            // 
            this.textLayer5High.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer5High.Location = new System.Drawing.Point(231, 190);
            this.textLayer5High.MaxLength = 6;
            this.textLayer5High.Name = "textLayer5High";
            this.textLayer5High.ReadOnly = true;
            this.textLayer5High.Size = new System.Drawing.Size(64, 21);
            this.textLayer5High.TabIndex = 9052;
            this.textLayer5High.TabStop = false;
            this.textLayer5High.Text = "0";
            this.textLayer5High.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer5High.TextChanged += new System.EventHandler(this.textLayer5High_TextChanged);
            // 
            // textLayer5Low
            // 
            this.textLayer5Low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer5Low.Location = new System.Drawing.Point(125, 190);
            this.textLayer5Low.MaxLength = 6;
            this.textLayer5Low.Name = "textLayer5Low";
            this.textLayer5Low.ReadOnly = true;
            this.textLayer5Low.Size = new System.Drawing.Size(64, 21);
            this.textLayer5Low.TabIndex = 9051;
            this.textLayer5Low.TabStop = false;
            this.textLayer5Low.Text = "0";
            this.textLayer5Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer5Low.TextChanged += new System.EventHandler(this.textLayer5Low_TextChanged);
            // 
            // textLayer5Bottom
            // 
            this.textLayer5Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer5Bottom.Location = new System.Drawing.Point(21, 190);
            this.textLayer5Bottom.MaxLength = 6;
            this.textLayer5Bottom.Name = "textLayer5Bottom";
            this.textLayer5Bottom.Size = new System.Drawing.Size(64, 21);
            this.textLayer5Bottom.TabIndex = 9050;
            this.textLayer5Bottom.TabStop = false;
            this.textLayer5Bottom.Text = "0";
            this.textLayer5Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer5Bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayer5Bottom_KeyPress);
            // 
            // textLayer4Average
            // 
            this.textLayer4Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLayer4Average.Location = new System.Drawing.Point(344, 161);
            this.textLayer4Average.MaxLength = 6;
            this.textLayer4Average.Name = "textLayer4Average";
            this.textLayer4Average.ReadOnly = true;
            this.textLayer4Average.Size = new System.Drawing.Size(64, 21);
            this.textLayer4Average.TabIndex = 9030;
            this.textLayer4Average.TabStop = false;
            this.textLayer4Average.Text = "0";
            this.textLayer4Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLayer4High
            // 
            this.textLayer4High.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer4High.Location = new System.Drawing.Point(231, 162);
            this.textLayer4High.MaxLength = 6;
            this.textLayer4High.Name = "textLayer4High";
            this.textLayer4High.ReadOnly = true;
            this.textLayer4High.Size = new System.Drawing.Size(64, 21);
            this.textLayer4High.TabIndex = 9048;
            this.textLayer4High.TabStop = false;
            this.textLayer4High.Text = "0";
            this.textLayer4High.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer4High.TextChanged += new System.EventHandler(this.textLayer4High_TextChanged);
            // 
            // textLayer4Low
            // 
            this.textLayer4Low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer4Low.Location = new System.Drawing.Point(125, 162);
            this.textLayer4Low.MaxLength = 6;
            this.textLayer4Low.Name = "textLayer4Low";
            this.textLayer4Low.ReadOnly = true;
            this.textLayer4Low.Size = new System.Drawing.Size(64, 21);
            this.textLayer4Low.TabIndex = 9047;
            this.textLayer4Low.TabStop = false;
            this.textLayer4Low.Text = "0";
            this.textLayer4Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer4Low.TextChanged += new System.EventHandler(this.textLayer4Low_TextChanged);
            // 
            // textLayer4Bottom
            // 
            this.textLayer4Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer4Bottom.Location = new System.Drawing.Point(21, 162);
            this.textLayer4Bottom.MaxLength = 6;
            this.textLayer4Bottom.Name = "textLayer4Bottom";
            this.textLayer4Bottom.Size = new System.Drawing.Size(64, 21);
            this.textLayer4Bottom.TabIndex = 9046;
            this.textLayer4Bottom.TabStop = false;
            this.textLayer4Bottom.Text = "0";
            this.textLayer4Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer4Bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayer4Bottom_KeyPress);
            // 
            // textLayer3Average
            // 
            this.textLayer3Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLayer3Average.Location = new System.Drawing.Point(344, 136);
            this.textLayer3Average.MaxLength = 6;
            this.textLayer3Average.Name = "textLayer3Average";
            this.textLayer3Average.ReadOnly = true;
            this.textLayer3Average.Size = new System.Drawing.Size(64, 21);
            this.textLayer3Average.TabIndex = 9028;
            this.textLayer3Average.TabStop = false;
            this.textLayer3Average.Text = "0";
            this.textLayer3Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLayer3High
            // 
            this.textLayer3High.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer3High.Location = new System.Drawing.Point(231, 137);
            this.textLayer3High.MaxLength = 6;
            this.textLayer3High.Name = "textLayer3High";
            this.textLayer3High.ReadOnly = true;
            this.textLayer3High.Size = new System.Drawing.Size(64, 21);
            this.textLayer3High.TabIndex = 9044;
            this.textLayer3High.TabStop = false;
            this.textLayer3High.Text = "0";
            this.textLayer3High.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer3High.TextChanged += new System.EventHandler(this.textLayer3High_TextChanged);
            // 
            // textLayer3Low
            // 
            this.textLayer3Low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer3Low.Location = new System.Drawing.Point(125, 137);
            this.textLayer3Low.MaxLength = 6;
            this.textLayer3Low.Name = "textLayer3Low";
            this.textLayer3Low.ReadOnly = true;
            this.textLayer3Low.Size = new System.Drawing.Size(64, 21);
            this.textLayer3Low.TabIndex = 9043;
            this.textLayer3Low.TabStop = false;
            this.textLayer3Low.Text = "0";
            this.textLayer3Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer3Low.TextChanged += new System.EventHandler(this.textLayer3Low_TextChanged);
            // 
            // textLayer3Bottom
            // 
            this.textLayer3Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer3Bottom.Location = new System.Drawing.Point(21, 137);
            this.textLayer3Bottom.MaxLength = 6;
            this.textLayer3Bottom.Name = "textLayer3Bottom";
            this.textLayer3Bottom.Size = new System.Drawing.Size(64, 21);
            this.textLayer3Bottom.TabIndex = 9042;
            this.textLayer3Bottom.TabStop = false;
            this.textLayer3Bottom.Text = "0";
            this.textLayer3Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer3Bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayer3Bottom_KeyPress);
            // 
            // textLayer2Average
            // 
            this.textLayer2Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLayer2Average.Location = new System.Drawing.Point(344, 108);
            this.textLayer2Average.MaxLength = 6;
            this.textLayer2Average.Name = "textLayer2Average";
            this.textLayer2Average.ReadOnly = true;
            this.textLayer2Average.Size = new System.Drawing.Size(64, 21);
            this.textLayer2Average.TabIndex = 9026;
            this.textLayer2Average.TabStop = false;
            this.textLayer2Average.Text = "0";
            this.textLayer2Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLayer2High
            // 
            this.textLayer2High.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer2High.Location = new System.Drawing.Point(231, 109);
            this.textLayer2High.MaxLength = 6;
            this.textLayer2High.Name = "textLayer2High";
            this.textLayer2High.ReadOnly = true;
            this.textLayer2High.Size = new System.Drawing.Size(64, 21);
            this.textLayer2High.TabIndex = 9040;
            this.textLayer2High.TabStop = false;
            this.textLayer2High.Text = "0";
            this.textLayer2High.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer2High.TextChanged += new System.EventHandler(this.textLayer2High_TextChanged);
            // 
            // textLayer2Low
            // 
            this.textLayer2Low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer2Low.Location = new System.Drawing.Point(125, 109);
            this.textLayer2Low.MaxLength = 6;
            this.textLayer2Low.Name = "textLayer2Low";
            this.textLayer2Low.ReadOnly = true;
            this.textLayer2Low.Size = new System.Drawing.Size(64, 21);
            this.textLayer2Low.TabIndex = 9039;
            this.textLayer2Low.TabStop = false;
            this.textLayer2Low.Text = "0";
            this.textLayer2Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer2Low.TextChanged += new System.EventHandler(this.textLayer2Low_TextChanged);
            // 
            // textLayer2Bottom
            // 
            this.textLayer2Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer2Bottom.Location = new System.Drawing.Point(21, 109);
            this.textLayer2Bottom.MaxLength = 6;
            this.textLayer2Bottom.Name = "textLayer2Bottom";
            this.textLayer2Bottom.Size = new System.Drawing.Size(64, 21);
            this.textLayer2Bottom.TabIndex = 9038;
            this.textLayer2Bottom.TabStop = false;
            this.textLayer2Bottom.Text = "0";
            this.textLayer2Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer2Bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayer2Bottom_KeyPress);
            // 
            // textLayer1Average
            // 
            this.textLayer1Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLayer1Average.Location = new System.Drawing.Point(344, 81);
            this.textLayer1Average.MaxLength = 6;
            this.textLayer1Average.Name = "textLayer1Average";
            this.textLayer1Average.ReadOnly = true;
            this.textLayer1Average.Size = new System.Drawing.Size(64, 21);
            this.textLayer1Average.TabIndex = 9024;
            this.textLayer1Average.TabStop = false;
            this.textLayer1Average.Text = "0";
            this.textLayer1Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLayer1High
            // 
            this.textLayer1High.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer1High.Location = new System.Drawing.Point(231, 81);
            this.textLayer1High.MaxLength = 6;
            this.textLayer1High.Name = "textLayer1High";
            this.textLayer1High.ReadOnly = true;
            this.textLayer1High.Size = new System.Drawing.Size(64, 21);
            this.textLayer1High.TabIndex = 9036;
            this.textLayer1High.TabStop = false;
            this.textLayer1High.Text = "0";
            this.textLayer1High.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer1High.TextChanged += new System.EventHandler(this.textLayer1High_TextChanged);
            // 
            // textLayer1Low
            // 
            this.textLayer1Low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer1Low.Location = new System.Drawing.Point(125, 81);
            this.textLayer1Low.MaxLength = 6;
            this.textLayer1Low.Name = "textLayer1Low";
            this.textLayer1Low.ReadOnly = true;
            this.textLayer1Low.Size = new System.Drawing.Size(64, 21);
            this.textLayer1Low.TabIndex = 9035;
            this.textLayer1Low.TabStop = false;
            this.textLayer1Low.Text = "0";
            this.textLayer1Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer1Low.TextChanged += new System.EventHandler(this.textLayer1Low_TextChanged);
            // 
            // textLayer1Bottom
            // 
            this.textLayer1Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLayer1Bottom.Location = new System.Drawing.Point(21, 81);
            this.textLayer1Bottom.MaxLength = 6;
            this.textLayer1Bottom.Name = "textLayer1Bottom";
            this.textLayer1Bottom.Size = new System.Drawing.Size(64, 21);
            this.textLayer1Bottom.TabIndex = 9034;
            this.textLayer1Bottom.TabStop = false;
            this.textLayer1Bottom.Text = "0";
            this.textLayer1Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLayer1Bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayer1Bottom_KeyPress);
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(341, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 24);
            this.label26.TabIndex = 9023;
            this.label26.Text = "Average";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(125, 47);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 24);
            this.label27.TabIndex = 9022;
            this.label27.Text = "Low";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(228, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 24);
            this.label28.TabIndex = 9021;
            this.label28.Text = "High";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(125, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(283, 22);
            this.label29.TabIndex = 9020;
            this.label29.Text = "Conductivity (in/hr)";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label29, "Permeabilty range listed in soil survey.  Average values automatically calculated" +
                    ".");
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(3, 24);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(104, 56);
            this.label36.TabIndex = 9067;
            this.label36.Text = "Depth to bottom of layer (cm)";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label36, "Depth from ground surface to bottom of the particular soil layer");
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(125, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(283, 22);
            this.label37.TabIndex = 9066;
            this.label37.Text = "Conductivity (cm/hr)";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label37, "Permeabilty range listed in soil survey.  Average values automatically calculated" +
                    ".");
            // 
            // groupUserK
            // 
            this.groupUserK.Controls.Add(this.textDepthLayer8);
            this.groupUserK.Controls.Add(this.textKLayer8);
            this.groupUserK.Controls.Add(this.textDepthLayer6);
            this.groupUserK.Controls.Add(this.textKLayer7);
            this.groupUserK.Controls.Add(this.textDepthLayer7);
            this.groupUserK.Controls.Add(this.textKLayer6);
            this.groupUserK.Controls.Add(this.label24);
            this.groupUserK.Controls.Add(this.label25);
            this.groupUserK.Controls.Add(this.label30);
            this.groupUserK.Controls.Add(this.textDepthLayer1);
            this.groupUserK.Controls.Add(this.textDepthLayer5);
            this.groupUserK.Controls.Add(this.textDepthLayer2);
            this.groupUserK.Controls.Add(this.textKLayer5);
            this.groupUserK.Controls.Add(this.label13);
            this.groupUserK.Controls.Add(this.label10);
            this.groupUserK.Controls.Add(this.textDepthLayer3);
            this.groupUserK.Controls.Add(this.textKLayer4);
            this.groupUserK.Controls.Add(this.textDepthLayer4);
            this.groupUserK.Controls.Add(this.textKLayer2);
            this.groupUserK.Controls.Add(this.textKLayer3);
            this.groupUserK.Controls.Add(this.textKLayer1);
            this.groupUserK.Controls.Add(this.label5);
            this.groupUserK.Controls.Add(this.label6);
            this.groupUserK.Controls.Add(this.label8);
            this.groupUserK.Controls.Add(this.label9);
            this.groupUserK.Controls.Add(this.label11);
            this.groupUserK.Controls.Add(this.label34);
            this.groupUserK.Controls.Add(this.label35);
            this.groupUserK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUserK.ForeColor = System.Drawing.Color.White;
            this.groupUserK.Location = new System.Drawing.Point(26, 71);
            this.groupUserK.Name = "groupUserK";
            this.groupUserK.Size = new System.Drawing.Size(312, 314);
            this.groupUserK.TabIndex = 6250;
            this.groupUserK.TabStop = false;
            this.groupUserK.Text = "Your Conductivity Values";
            // 
            // textDepthLayer8
            // 
            this.textDepthLayer8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepthLayer8.Location = new System.Drawing.Point(100, 270);
            this.textDepthLayer8.MaxLength = 10;
            this.textDepthLayer8.Name = "textDepthLayer8";
            this.textDepthLayer8.Size = new System.Drawing.Size(72, 21);
            this.textDepthLayer8.TabIndex = 9017;
            this.textDepthLayer8.Text = "0";
            this.textDepthLayer8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDepthLayer8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepthLayer8_KeyPress);
            // 
            // textKLayer8
            // 
            this.textKLayer8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKLayer8.Location = new System.Drawing.Point(208, 270);
            this.textKLayer8.MaxLength = 10;
            this.textKLayer8.Name = "textKLayer8";
            this.textKLayer8.Size = new System.Drawing.Size(72, 21);
            this.textKLayer8.TabIndex = 9018;
            this.textKLayer8.Text = "0";
            this.textKLayer8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKLayer8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKLayer8_KeyPress);
            // 
            // textDepthLayer6
            // 
            this.textDepthLayer6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepthLayer6.Location = new System.Drawing.Point(100, 216);
            this.textDepthLayer6.MaxLength = 10;
            this.textDepthLayer6.Name = "textDepthLayer6";
            this.textDepthLayer6.Size = new System.Drawing.Size(72, 21);
            this.textDepthLayer6.TabIndex = 9013;
            this.textDepthLayer6.Text = "0";
            this.textDepthLayer6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDepthLayer6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepthLayer6_KeyPress);
            // 
            // textKLayer7
            // 
            this.textKLayer7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKLayer7.Location = new System.Drawing.Point(208, 243);
            this.textKLayer7.MaxLength = 10;
            this.textKLayer7.Name = "textKLayer7";
            this.textKLayer7.Size = new System.Drawing.Size(72, 21);
            this.textKLayer7.TabIndex = 9016;
            this.textKLayer7.Text = "0";
            this.textKLayer7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKLayer7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKLayer7_KeyPress);
            // 
            // textDepthLayer7
            // 
            this.textDepthLayer7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepthLayer7.Location = new System.Drawing.Point(100, 243);
            this.textDepthLayer7.MaxLength = 10;
            this.textDepthLayer7.Name = "textDepthLayer7";
            this.textDepthLayer7.Size = new System.Drawing.Size(72, 21);
            this.textDepthLayer7.TabIndex = 9015;
            this.textDepthLayer7.Text = "0";
            this.textDepthLayer7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDepthLayer7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepthLayer7_KeyPress);
            // 
            // textKLayer6
            // 
            this.textKLayer6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKLayer6.Location = new System.Drawing.Point(208, 216);
            this.textKLayer6.MaxLength = 10;
            this.textKLayer6.Name = "textKLayer6";
            this.textKLayer6.Size = new System.Drawing.Size(72, 21);
            this.textKLayer6.TabIndex = 9014;
            this.textKLayer6.Text = "0";
            this.textKLayer6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKLayer6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKLayer6_KeyPress);
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(8, 213);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 24);
            this.label24.TabIndex = 9019;
            this.label24.Text = "Soil Layer 6";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(8, 238);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 26);
            this.label25.TabIndex = 9020;
            this.label25.Text = "Soil Layer 7";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(8, 266);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(84, 27);
            this.label30.TabIndex = 9021;
            this.label30.Text = "Soil Layer 8";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textDepthLayer1
            // 
            this.textDepthLayer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepthLayer1.Location = new System.Drawing.Point(100, 81);
            this.textDepthLayer1.MaxLength = 10;
            this.textDepthLayer1.Name = "textDepthLayer1";
            this.textDepthLayer1.Size = new System.Drawing.Size(72, 21);
            this.textDepthLayer1.TabIndex = 49;
            this.textDepthLayer1.Text = "0";
            this.textDepthLayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDepthLayer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepthLayer1_KeyPress);
            // 
            // textDepthLayer5
            // 
            this.textDepthLayer5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepthLayer5.Location = new System.Drawing.Point(100, 189);
            this.textDepthLayer5.MaxLength = 10;
            this.textDepthLayer5.Name = "textDepthLayer5";
            this.textDepthLayer5.Size = new System.Drawing.Size(72, 21);
            this.textDepthLayer5.TabIndex = 69;
            this.textDepthLayer5.Text = "0";
            this.textDepthLayer5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDepthLayer5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepthLayer5_KeyPress);
            // 
            // textDepthLayer2
            // 
            this.textDepthLayer2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepthLayer2.Location = new System.Drawing.Point(100, 108);
            this.textDepthLayer2.MaxLength = 10;
            this.textDepthLayer2.Name = "textDepthLayer2";
            this.textDepthLayer2.Size = new System.Drawing.Size(72, 21);
            this.textDepthLayer2.TabIndex = 53;
            this.textDepthLayer2.Text = "0";
            this.textDepthLayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDepthLayer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepthLayer2_KeyPress);
            // 
            // textKLayer5
            // 
            this.textKLayer5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKLayer5.Location = new System.Drawing.Point(208, 190);
            this.textKLayer5.MaxLength = 10;
            this.textKLayer5.Name = "textKLayer5";
            this.textKLayer5.Size = new System.Drawing.Size(72, 21);
            this.textKLayer5.TabIndex = 71;
            this.textKLayer5.Text = "0";
            this.textKLayer5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKLayer5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKLayer5_KeyPress);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(192, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 32);
            this.label13.TabIndex = 131;
            this.label13.Text = "Conductivity (in/hr)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label13, "Listed as permeability in Soil Survey");
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(82, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 56);
            this.label10.TabIndex = 130;
            this.label10.Text = "Depth to bottom of layer (in)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label10, "Depth from ground surface to bottom of the particular soil layer");
            // 
            // textDepthLayer3
            // 
            this.textDepthLayer3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepthLayer3.Location = new System.Drawing.Point(100, 135);
            this.textDepthLayer3.MaxLength = 10;
            this.textDepthLayer3.Name = "textDepthLayer3";
            this.textDepthLayer3.Size = new System.Drawing.Size(72, 21);
            this.textDepthLayer3.TabIndex = 57;
            this.textDepthLayer3.Text = "0";
            this.textDepthLayer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDepthLayer3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepthLayer3_KeyPress);
            // 
            // textKLayer4
            // 
            this.textKLayer4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKLayer4.Location = new System.Drawing.Point(208, 163);
            this.textKLayer4.MaxLength = 10;
            this.textKLayer4.Name = "textKLayer4";
            this.textKLayer4.Size = new System.Drawing.Size(72, 21);
            this.textKLayer4.TabIndex = 63;
            this.textKLayer4.Text = "0";
            this.textKLayer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKLayer4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKLayer4_KeyPress);
            // 
            // textDepthLayer4
            // 
            this.textDepthLayer4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepthLayer4.Location = new System.Drawing.Point(100, 162);
            this.textDepthLayer4.MaxLength = 10;
            this.textDepthLayer4.Name = "textDepthLayer4";
            this.textDepthLayer4.Size = new System.Drawing.Size(72, 21);
            this.textDepthLayer4.TabIndex = 61;
            this.textDepthLayer4.Text = "0";
            this.textDepthLayer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDepthLayer4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepthLayer4_KeyPress);
            // 
            // textKLayer2
            // 
            this.textKLayer2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKLayer2.Location = new System.Drawing.Point(208, 109);
            this.textKLayer2.MaxLength = 10;
            this.textKLayer2.Name = "textKLayer2";
            this.textKLayer2.Size = new System.Drawing.Size(72, 21);
            this.textKLayer2.TabIndex = 55;
            this.textKLayer2.Text = "0";
            this.textKLayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKLayer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKLayer2_KeyPress);
            // 
            // textKLayer3
            // 
            this.textKLayer3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKLayer3.Location = new System.Drawing.Point(208, 136);
            this.textKLayer3.MaxLength = 10;
            this.textKLayer3.Name = "textKLayer3";
            this.textKLayer3.Size = new System.Drawing.Size(72, 21);
            this.textKLayer3.TabIndex = 59;
            this.textKLayer3.Text = "0";
            this.textKLayer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKLayer3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKLayer3_KeyPress);
            // 
            // textKLayer1
            // 
            this.textKLayer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKLayer1.Location = new System.Drawing.Point(208, 81);
            this.textKLayer1.MaxLength = 10;
            this.textKLayer1.Name = "textKLayer1";
            this.textKLayer1.Size = new System.Drawing.Size(72, 21);
            this.textKLayer1.TabIndex = 51;
            this.textKLayer1.Text = "0";
            this.textKLayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKLayer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textKLayer1_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 9006;
            this.label5.Text = "Soil Layer 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 9009;
            this.label6.Text = "Soil Layer 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 9010;
            this.label8.Text = "Soil Layer 3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 26);
            this.label9.TabIndex = 9011;
            this.label9.Text = "Soil Layer 4";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 27);
            this.label11.TabIndex = 9012;
            this.label11.Text = "Soil Layer 5";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(192, 33);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(88, 32);
            this.label34.TabIndex = 6502;
            this.label34.Text = "Conductivity (cm/hr)";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label34, "Listed as permeability in Soil Survey");
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(82, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(104, 56);
            this.label35.TabIndex = 6501;
            this.label35.Text = "Depth to bottom of layer (cm)";
            this.label35.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label35, "Depth from ground surface to bottom of the particular soil layer");
            // 
            // comboSoilSurvey
            // 
            this.comboSoilSurvey.FormattingEnabled = true;
            this.comboSoilSurvey.Location = new System.Drawing.Point(480, 29);
            this.comboSoilSurvey.Name = "comboSoilSurvey";
            this.comboSoilSurvey.Size = new System.Drawing.Size(318, 23);
            this.comboSoilSurvey.TabIndex = 45;
            this.comboSoilSurvey.TabStop = false;
            this.comboSoilSurvey.SelectedIndexChanged += new System.EventHandler(this.comboSoilSurvey_SelectedIndexChanged);
            // 
            // radioSSLat
            // 
            this.radioSSLat.AutoSize = true;
            this.radioSSLat.Location = new System.Drawing.Point(355, 33);
            this.radioSSLat.Name = "radioSSLat";
            this.radioSSLat.Size = new System.Drawing.Size(102, 19);
            this.radioSSLat.TabIndex = 43;
            this.radioSSLat.Text = "Choose Soil";
            this.radioSSLat.UseVisualStyleBackColor = true;
            // 
            // radioUserLat
            // 
            this.radioUserLat.AutoSize = true;
            this.radioUserLat.Checked = true;
            this.radioUserLat.Location = new System.Drawing.Point(26, 33);
            this.radioUserLat.Name = "radioUserLat";
            this.radioUserLat.Size = new System.Drawing.Size(139, 19);
            this.radioUserLat.TabIndex = 41;
            this.radioUserLat.TabStop = true;
            this.radioUserLat.Text = "Enter Your Values";
            this.radioUserLat.UseVisualStyleBackColor = true;
            // 
            // textLateralEffect
            // 
            this.textLateralEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(187)))));
            this.textLateralEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLateralEffect.Location = new System.Drawing.Point(664, 627);
            this.textLateralEffect.Name = "textLateralEffect";
            this.textLateralEffect.ReadOnly = true;
            this.textLateralEffect.Size = new System.Drawing.Size(120, 22);
            this.textLateralEffect.TabIndex = 11000;
            this.textLateralEffect.TabStop = false;
            this.textLateralEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "gen";
            this.saveFileDialog1.Filter = "General Input File (*.gen) |*.gen";
            this.saveFileDialog1.InitialDirectory = "inputs";
            this.saveFileDialog1.OverwritePrompt = false;
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Project As";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "gen";
            this.openFileDialog1.Filter = "Open Project File (*.gen) |*.gen";
            this.openFileDialog1.InitialDirectory = "inputs";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Open Project File";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Sienna;
            this.groupBox6.Controls.Add(this.textNotes);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.textCoordinates);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textLocation);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textDepartment);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.textCompany);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textSoilSeries);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.textUserName);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.textProjectName);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(16, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(280, 596);
            this.groupBox6.TabIndex = 500;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Project Information (Optional)";
            this.toolTip1.SetToolTip(this.groupBox6, "Not required to run model");
            // 
            // textNotes
            // 
            this.textNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textNotes.Location = new System.Drawing.Point(9, 450);
            this.textNotes.MaxLength = 200;
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(253, 122);
            this.textNotes.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(9, 419);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 25);
            this.label17.TabIndex = 514;
            this.label17.Text = "Notes";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textCoordinates
            // 
            this.textCoordinates.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textCoordinates.Location = new System.Drawing.Point(9, 334);
            this.textCoordinates.MaxLength = 200;
            this.textCoordinates.Name = "textCoordinates";
            this.textCoordinates.Size = new System.Drawing.Size(253, 21);
            this.textCoordinates.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(9, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 25);
            this.label16.TabIndex = 512;
            this.label16.Text = "Coordinates";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(9, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 25);
            this.label15.TabIndex = 511;
            this.label15.Text = "Project Location";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textLocation
            // 
            this.textLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLocation.Location = new System.Drawing.Point(9, 276);
            this.textLocation.MaxLength = 200;
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(253, 21);
            this.textLocation.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(9, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 25);
            this.label14.TabIndex = 509;
            this.label14.Text = "Department";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textDepartment
            // 
            this.textDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDepartment.Location = new System.Drawing.Point(9, 218);
            this.textDepartment.MaxLength = 200;
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(253, 21);
            this.textDepartment.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 25);
            this.label12.TabIndex = 507;
            this.label12.Text = "Company / Agency";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textCompany
            // 
            this.textCompany.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textCompany.Location = new System.Drawing.Point(9, 160);
            this.textCompany.MaxLength = 200;
            this.textCompany.Name = "textCompany";
            this.textCompany.Size = new System.Drawing.Size(253, 21);
            this.textCompany.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 504;
            this.label7.Text = "Soil ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textSoilSeries
            // 
            this.textSoilSeries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSoilSeries.Location = new System.Drawing.Point(9, 392);
            this.textSoilSeries.Name = "textSoilSeries";
            this.textSoilSeries.Size = new System.Drawing.Size(253, 21);
            this.textSoilSeries.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textUserName
            // 
            this.textUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textUserName.Location = new System.Drawing.Point(9, 102);
            this.textUserName.MaxLength = 100;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(253, 21);
            this.textUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Project";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textProjectName
            // 
            this.textProjectName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textProjectName.Location = new System.Drawing.Point(9, 44);
            this.textProjectName.MaxLength = 200;
            this.textProjectName.Name = "textProjectName";
            this.textProjectName.Size = new System.Drawing.Size(253, 21);
            this.textProjectName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.btnDitchCalculate);
            this.panel1.Controls.Add(this.textLateralEffect);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 688);
            this.panel1.TabIndex = 9002;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 688);
            this.splitter1.TabIndex = 5001;
            this.splitter1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 20;
            // 
            // contextSoilSurvey
            // 
            this.contextSoilSurvey.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "gen";
            this.openFileDialog2.Filter = "Open Project File (*.gen) |*.gen";
            this.openFileDialog2.InitialDirectory = "inputs";
            this.openFileDialog2.RestoreDirectory = true;
            this.openFileDialog2.Title = "Open Project File";
            // 
            // MainProgram
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(139)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(1158, 688);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lateral Effect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupSSK.ResumeLayout(false);
            this.groupSSK.PerformLayout();
            this.groupUserK.ResumeLayout(false);
            this.groupUserK.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


        #region "Windows Start Main and Onload Code"
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        [STAThread]
        static void Main()
        {
            Application.Run(new MainProgram());
        }

        //*****************************************************************
        //Onload Checks and Pre-Loads
        //*****************************************************************
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Create Folders if they do not exists
            if (!Directory.Exists(@".\temp"))
            {

                Directory.CreateDirectory(@".\temp");
            }
            if (!Directory.Exists(@".\inputs"))
            {

                Directory.CreateDirectory(@".\inputs");
            }
            if (!Directory.Exists(@".\outputs"))
            {

                Directory.CreateDirectory(@".\outputs");
            }


            //Check for Data folder
            if (!Directory.Exists(@".\data"))
            {

                MessageBox.Show("You are missing the folder labelled 'data' .\n\n The program will not work without the files found in this folder. \n\n Please download a new 'data' folder from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                //Clear Current List
                comboState.Items.Clear();

                //Load lists of States from XML file, start drop down box with North Carolina

                //Set file name with list of states
                string sStateList = "data/StateList.xml";

                //Set path to location of program
                Directory.SetCurrentDirectory(Application.StartupPath);

                //Throw Message if File Does Not Exists
                if (!File.Exists(sStateList))
                {

                    MessageBox.Show("You are missing the State List or the file has been corrupted .\n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Otherwise load state list to state combo box
                else
                {

                    try
                    {
                        //Open XML file - located in Data Folder
                        XmlDocument doc = new XmlDocument();
                        doc.Load(sStateList);

                        //Populate Soil Survey Combo Box
                        XmlNodeList stateList = doc.SelectNodes("states/state");
                        foreach (XmlNode state in stateList)
                        {
                            comboState.Items.Add(state.InnerText);
                        }

                    }

                    catch (Exception)
                    {

                        MessageBox.Show("You're State List file has been corrupted .\n\n You will not be able to run the program until the State List file has been repaired or replaced. \n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            return;
        }

        #endregion


        #region "Keypress - prevent non-numerics and only allows for one decimal"

        //The below coding prevent non-numerics and only allows for one decimal



        private void textT25Override_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (textT25Override.Text.Length == 0 & e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textT25Override.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textT25Override.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textT25Override.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textHydroperiod_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (textHydroperiod.Text.Length == 0 & e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textHydroperiod.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textHydroperiod.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textHydroperiod.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }



        private void textDitchDepth_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (textDitchDepth.Text.Length == 0 & e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textDitchDepth.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDitchDepth.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDitchDepth.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDitchImpermeable_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (textDitchImpermeable.Text.Length == 0 & e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textDitchImpermeable.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDitchImpermeable.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDitchImpermeable.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDitchPorosity_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDitchPorosity.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDitchPorosity.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDitchPorosity.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDepthLayer1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDepthLayer1.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDepthLayer1.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDepthLayer1.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textKLayer1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textKLayer1.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textKLayer1.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textKLayer1.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDepthLayer2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDepthLayer2.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDepthLayer2.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDepthLayer2.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textKLayer2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textKLayer2.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textKLayer2.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textKLayer2.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDepthLayer3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDepthLayer3.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDepthLayer3.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDepthLayer3.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textKLayer3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        private void textDepthLayer4_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDepthLayer4.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDepthLayer4.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDepthLayer4.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textKLayer4_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textKLayer4.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textKLayer4.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textKLayer4.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDepthLayer5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDepthLayer5.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDepthLayer5.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDepthLayer5.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textKLayer5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textKLayer5.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textKLayer5.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textKLayer5.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDepthLayer6_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDepthLayer6.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDepthLayer6.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDepthLayer6.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textKLayer6_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textKLayer6.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textKLayer6.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textKLayer6.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDepthLayer7_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDepthLayer7.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDepthLayer7.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDepthLayer7.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textKLayer7_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textKLayer7.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textKLayer7.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textKLayer7.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textDepthLayer8_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textDepthLayer8.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textDepthLayer8.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textDepthLayer8.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textKLayer8_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textKLayer8.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textKLayer8.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textKLayer8.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer1Bottom_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer1Bottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer1Bottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer1Bottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer2Bottom_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer2Bottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer2Bottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer2Bottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer3Bottom_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        private void textLayer4Bottom_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer4Bottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer4Bottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer4Bottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer5Bottom_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer5Bottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer5Bottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer5Bottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer6Bottom_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer6Bottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer6Bottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer6Bottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer7Bottom_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer7Bottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer7Bottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer7Bottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer8Bottom_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer8Bottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer8Bottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer8Bottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }



        #endregion


        #region "Menus"

        #region "Exit Program"

        //Exiting Program

        private void mnuConfirm_Click(object sender, System.EventArgs e)
        {
            mnuConfirm.Checked = (!mnuConfirm.Checked);
        }

        private void mnuExit_Click(object sender, System.EventArgs e)
        {
            if (mnuConfirm.Checked)
            {
                if (MessageBox.Show("Do you really wish to exit?", "Exit Verification",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            this.Close();


        }

        #endregion


        #region "Metric Menu"

        private void menuMetric_Click(object sender, EventArgs e)
        {
            menuMetric.Checked = (!menuMetric.Checked);

            if (!menuMetric.Checked)
            {
                label21.Visible = true;
                label20.Visible = true;
                label2.Visible = true;
                label10.Visible = true;
                label13.Visible = true;
                label22.Visible = true;
                label29.Visible = true;

            }
            else
            {
                label21.Visible = false;
                label20.Visible = false;
                label2.Visible = false;
                label10.Visible = false;
                label13.Visible = false;
                label22.Visible = false;
                label29.Visible = false;
            }
        }

        #endregion


        #region "Unit Conversion Utility"

        //Opening Unit Conversion Utility

        private void mnuUnitConversion_Click(object sender, System.EventArgs e)
        {

            Directory.SetCurrentDirectory(Application.StartupPath);

            if (!File.Exists("Conversion.exe"))
            {

                MessageBox.Show("You are missing the unit conversion utility .\n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else
            {
                try
                {

                    System.Diagnostics.Process.Start("Conversion.exe");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Whoops! An error file has been written to your outputs folder.  It is labeled \n\n"
                    + ex.Message + ".err" + "\n\n"
                    + "And has the following information:\n\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace + "\n\n"
                    + "Please email this file to brian_phillips@ncsu.edu  Thank you and my apologies for the error",
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    // get the version object for this assembly
                    Version v = System.Reflection.Assembly.GetExecutingAssembly().
                     GetName().Version;



                    using (StreamWriter swERR = new StreamWriter("outputs/" + ex.Message + ".err"))
                    {

                        swERR.WriteLine(DateTime.Now);
                        swERR.WriteLine("Message**********");
                        swERR.WriteLine(ex.Message);
                        swERR.WriteLine("Source**********");
                        swERR.WriteLine(ex.Source);
                        swERR.WriteLine("Stack Trace**********");
                        swERR.WriteLine(ex.StackTrace);
                        swERR.WriteLine("Assembly**********");
                        swERR.WriteLine(v.ToString());

                        //Clean up and close file
                        swERR.Flush();
                        swERR.Close();
                    }

                }
            }

        }

        #endregion


        #region"Open Help File"

        //Opening help file

        private void mnuHelp_Click(object sender, System.EventArgs e)
        {

            //Directory.SetCurrentDirectory(Application.StartupPath);

            // Open the Help file
            if (!File.Exists("Lateral_Effect.chm"))
            {

                MessageBox.Show("You are missing the Help file .\n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else
            {

                try
                {
                    Help.ShowHelp(this, "Lateral_Effect.chm", HelpNavigator.Topic, "general.htm");

                    //if (MessageBox.Show("Would you like to do X?", "MessageBox sample",
                    //MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    // Code to do X would go here.
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Whoops! An error file has been written to your outputs folder.  It is labeled \n\n"
                    + ex.Message + ".err" + "\n\n"
                    + "And has the following information:\n\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace + "\n\n"
                    + "Please email this file to brian_phillips@ncsu.edu  Thank you and my apologies for the error",
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    // get the version object for this assembly
                    Version v = System.Reflection.Assembly.GetExecutingAssembly().
                     GetName().Version;



                    using (StreamWriter swERR = new StreamWriter("outputs/" + ex.Message + ".err"))
                    {

                        swERR.WriteLine(DateTime.Now);
                        swERR.WriteLine("Message**********");
                        swERR.WriteLine(ex.Message);
                        swERR.WriteLine("Source**********");
                        swERR.WriteLine(ex.Source);
                        swERR.WriteLine("Stack Trace**********");
                        swERR.WriteLine(ex.StackTrace);
                        swERR.WriteLine("Assembly**********");
                        swERR.WriteLine(v.ToString());

                        //Clean up and close file
                        swERR.Flush();
                        swERR.Close();
                    }

                }

            }


        }
        #endregion


        #region "Open Summary File"

        //Open Summary file

        private void menuViewSummary_Click(object sender, System.EventArgs e)
        {
            //Open text output in Notepad
            Directory.SetCurrentDirectory(Application.StartupPath);

            if (!File.Exists("outputs/Lateral_Effect_Summary.txt"))
            {

                MessageBox.Show("There is currently no summary file. \n\n Please run a simulation to generate a summary file.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else
            {


                try
                {
                    System.Diagnostics.Process.Start("outputs/Lateral_Effect_Summary.txt");
                    //System.Diagnostics.Process.Start(@"c:\Program Files\Skaggs Method\Skaggs_Method_Summary.txt");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Whoops! An error file has been written to your outputs folder.  It is labeled \n\n"
                    + ex.Message + ".err" + "\n\n"
                    + "And has the following information:\n\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace + "\n\n"
                    + "Please email this file to brian_phillips@ncsu.edu  Thank you and my apologies for the error",
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    // get the version object for this assembly
                    Version v = System.Reflection.Assembly.GetExecutingAssembly().
                     GetName().Version;



                    using (StreamWriter swERR = new StreamWriter("outputs/" + ex.Message + ".err"))
                    {

                        swERR.WriteLine(DateTime.Now);
                        swERR.WriteLine("Message**********");
                        swERR.WriteLine(ex.Message);
                        swERR.WriteLine("Source**********");
                        swERR.WriteLine(ex.Source);
                        swERR.WriteLine("Stack Trace**********");
                        swERR.WriteLine(ex.StackTrace);
                        swERR.WriteLine("Assembly**********");
                        swERR.WriteLine(v.ToString());

                        //Clean up and close file
                        swERR.Flush();
                        swERR.Close();
                    }

                }
            }
        }

        #endregion


        #region "Save Project"

        private void mnuSaveProject_Click(object sender, System.EventArgs e)
        {
            //Have to assume thay have not run simulation and therefore need to save
            //inputs directly from text boxes et al.




            //Put zeros in empty conductivity fields
            if (textDepthLayer2.Text == "")
            {
                textDepthLayer2.Text = "0";
            }
            if (textDepthLayer3.Text == "")
            {
                textDepthLayer3.Text = "0";
            }
            if (textDepthLayer4.Text == "")
            {
                textDepthLayer4.Text = "0";
            }
            if (textDepthLayer5.Text == "")
            {
                textDepthLayer5.Text = "0";
            }
            if (textKLayer2.Text == "")
            {
                textKLayer2.Text = "0";
            }
            if (textKLayer3.Text == "")
            {
                textKLayer3.Text = "0";
            }
            if (textKLayer4.Text == "")
            {
                textKLayer4.Text = "0";
            }
            if (textKLayer5.Text == "")
            {
                textKLayer5.Text = "0";
            }
            if (textLateralEffect.Text == "")
            {
                textLateralEffect.Text = "0";
            }





            //Below code to save information in .this format

            string strFilename = "enter_file_name";

            this.saveFileDialog1.FileName = strFilename;
            // Display the Save dialog box
            // Find out if the user clicked OK or pressed Enter
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // If the user provided a name that already exists for an existing file
                if (File.Exists(this.saveFileDialog1.FileName))
                {
                    // Find out if the user wants to replace the existing file
                    System.Windows.Forms.DialogResult answer = MessageBox.Show(string.Concat("The file exists already.",
                        "Do you want to replace it?"),
                        "Save Project File",
                        MessageBoxButtons.YesNo);

                    // If the user wants to replace it
                    if (answer == DialogResult.Yes)
                    {
                        using (StreamWriter sw3 = new StreamWriter(this.saveFileDialog1.FileName))
                        {
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("***************BEGIN********************");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("Project Information");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.textProjectName.Text);
                            sw3.WriteLine(this.textUserName.Text);
                            sw3.WriteLine(this.textCompany.Text);
                            sw3.WriteLine(this.textDepartment.Text);
                            sw3.WriteLine(this.textLocation.Text);
                            sw3.WriteLine(this.textCoordinates.Text);
                            sw3.WriteLine(this.textSoilSeries.Text);
                            sw3.WriteLine(this.textNotes.Text);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("English / Metric");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.menuMetric.Checked);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("State - County - Surface Storage Index");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.comboState.SelectedIndex);
                            sw3.WriteLine(this.comboCounty.SelectedIndex);
                            sw3.WriteLine(this.comboStorage.SelectedIndex);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("T25 Override");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.checkBoxOverride.Checked);
                            sw3.WriteLine(this.textT25Override.Text);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("Hydroperiod");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.radioPercent.Checked);
                            sw3.WriteLine(this.radio14Days.Checked);
                            sw3.WriteLine(this.textHydroperiod.Text);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("Ditch Depth - Restrictive - Porosity");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.textDitchDepth.Text);
                            sw3.WriteLine(this.textDitchImpermeable.Text);
                            sw3.WriteLine(this.textDitchPorosity.Text);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("K Option");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.radioUserLat.Checked);
                            sw3.WriteLine(this.radioSSLat.Checked);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("User K Data");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.textDepthLayer1.Text);
                            sw3.WriteLine(this.textDepthLayer2.Text);
                            sw3.WriteLine(this.textDepthLayer3.Text);
                            sw3.WriteLine(this.textDepthLayer4.Text);
                            sw3.WriteLine(this.textDepthLayer5.Text);
                            sw3.WriteLine(this.textDepthLayer6.Text);
                            sw3.WriteLine(this.textDepthLayer7.Text);
                            sw3.WriteLine(this.textDepthLayer8.Text);
                            sw3.WriteLine(this.textKLayer1.Text);
                            sw3.WriteLine(this.textKLayer2.Text);
                            sw3.WriteLine(this.textKLayer3.Text);
                            sw3.WriteLine(this.textKLayer4.Text);
                            sw3.WriteLine(this.textKLayer5.Text);
                            sw3.WriteLine(this.textKLayer6.Text);
                            sw3.WriteLine(this.textKLayer7.Text);
                            sw3.WriteLine(this.textKLayer8.Text);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("Soil Survey Soil Index");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.comboSoilSurvey.SelectedIndex);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("Soil Survey K Data");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.textLayer1Bottom.Text);
                            sw3.WriteLine(this.textLayer2Bottom.Text);
                            sw3.WriteLine(this.textLayer3Bottom.Text);
                            sw3.WriteLine(this.textLayer4Bottom.Text);
                            sw3.WriteLine(this.textLayer5Bottom.Text);
                            sw3.WriteLine(this.textLayer6Bottom.Text);
                            sw3.WriteLine(this.textLayer7Bottom.Text);
                            sw3.WriteLine(this.textLayer8Bottom.Text);
                            sw3.WriteLine(this.textLayer1Low.Text);
                            sw3.WriteLine(this.textLayer2Low.Text);
                            sw3.WriteLine(this.textLayer3Low.Text);
                            sw3.WriteLine(this.textLayer4Low.Text);
                            sw3.WriteLine(this.textLayer5Low.Text);
                            sw3.WriteLine(this.textLayer6Low.Text);
                            sw3.WriteLine(this.textLayer7Low.Text);
                            sw3.WriteLine(this.textLayer8Low.Text);
                            sw3.WriteLine(this.textLayer1High.Text);
                            sw3.WriteLine(this.textLayer2High.Text);
                            sw3.WriteLine(this.textLayer3High.Text);
                            sw3.WriteLine(this.textLayer4High.Text);
                            sw3.WriteLine(this.textLayer5High.Text);
                            sw3.WriteLine(this.textLayer6High.Text);
                            sw3.WriteLine(this.textLayer7High.Text);
                            sw3.WriteLine(this.textLayer8High.Text);
                            sw3.WriteLine(this.textLayer1Average.Text);
                            sw3.WriteLine(this.textLayer2Average.Text);
                            sw3.WriteLine(this.textLayer3Average.Text);
                            sw3.WriteLine(this.textLayer4Average.Text);
                            sw3.WriteLine(this.textLayer5Average.Text);
                            sw3.WriteLine(this.textLayer6Average.Text);
                            sw3.WriteLine(this.textLayer7Average.Text);
                            sw3.WriteLine(this.textLayer8Average.Text);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("Soil Survey K - Low - High - Average Option");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.radioExportLow.Checked);
                            sw3.WriteLine(this.radioExportHigh.Checked);
                            sw3.WriteLine(this.radioExportAverage.Checked);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("Final Result");
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine(this.textLateralEffect.Text);
                            sw3.WriteLine("****************************************");
                            sw3.WriteLine("****************END*********************");
                            sw3.WriteLine("****************************************");






                            //Clean up and close file
                            sw3.Flush();
                            sw3.Close();
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw3 = new StreamWriter(this.saveFileDialog1.FileName))
                    {
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("***************BEGIN********************");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("Project Information");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.textProjectName.Text);
                        sw3.WriteLine(this.textUserName.Text);
                        sw3.WriteLine(this.textCompany.Text);
                        sw3.WriteLine(this.textDepartment.Text);
                        sw3.WriteLine(this.textLocation.Text);
                        sw3.WriteLine(this.textCoordinates.Text);
                        sw3.WriteLine(this.textSoilSeries.Text);
                        //DEBUG- Make it write notes to only one line even if user enters line breaks -REOMVE WHITESPACE
                        sw3.WriteLine(this.textNotes.Text);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("English / Metric");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.menuMetric.Checked);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("State - County - Surface Storage Index");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.comboState.SelectedIndex);
                        sw3.WriteLine(this.comboCounty.SelectedIndex);
                        sw3.WriteLine(this.comboStorage.SelectedIndex);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("T25 Override");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.checkBoxOverride.Checked);
                        sw3.WriteLine(this.textT25Override.Text);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("Hydroperiod");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.radioPercent.Checked);
                        sw3.WriteLine(this.radio14Days.Checked);
                        sw3.WriteLine(this.textHydroperiod.Text);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("Ditch Depth - Restrictive - Porosity");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.textDitchDepth.Text);
                        sw3.WriteLine(this.textDitchImpermeable.Text);
                        sw3.WriteLine(this.textDitchPorosity.Text);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("K Option");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.radioUserLat.Checked);
                        sw3.WriteLine(this.radioSSLat.Checked);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("User K Data");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.textDepthLayer1.Text);
                        sw3.WriteLine(this.textDepthLayer2.Text);
                        sw3.WriteLine(this.textDepthLayer3.Text);
                        sw3.WriteLine(this.textDepthLayer4.Text);
                        sw3.WriteLine(this.textDepthLayer5.Text);
                        sw3.WriteLine(this.textDepthLayer6.Text);
                        sw3.WriteLine(this.textDepthLayer7.Text);
                        sw3.WriteLine(this.textDepthLayer8.Text);
                        sw3.WriteLine(this.textKLayer1.Text);
                        sw3.WriteLine(this.textKLayer2.Text);
                        sw3.WriteLine(this.textKLayer3.Text);
                        sw3.WriteLine(this.textKLayer4.Text);
                        sw3.WriteLine(this.textKLayer5.Text);
                        sw3.WriteLine(this.textKLayer6.Text);
                        sw3.WriteLine(this.textKLayer7.Text);
                        sw3.WriteLine(this.textKLayer8.Text);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("Soil Survey Soil Index");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.comboSoilSurvey.SelectedIndex);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("Soil Survey K Data");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.textLayer1Bottom.Text);
                        sw3.WriteLine(this.textLayer2Bottom.Text);
                        sw3.WriteLine(this.textLayer3Bottom.Text);
                        sw3.WriteLine(this.textLayer4Bottom.Text);
                        sw3.WriteLine(this.textLayer5Bottom.Text);
                        sw3.WriteLine(this.textLayer6Bottom.Text);
                        sw3.WriteLine(this.textLayer7Bottom.Text);
                        sw3.WriteLine(this.textLayer8Bottom.Text);
                        sw3.WriteLine(this.textLayer1Low.Text);
                        sw3.WriteLine(this.textLayer2Low.Text);
                        sw3.WriteLine(this.textLayer3Low.Text);
                        sw3.WriteLine(this.textLayer4Low.Text);
                        sw3.WriteLine(this.textLayer5Low.Text);
                        sw3.WriteLine(this.textLayer6Low.Text);
                        sw3.WriteLine(this.textLayer7Low.Text);
                        sw3.WriteLine(this.textLayer8Low.Text);
                        sw3.WriteLine(this.textLayer1High.Text);
                        sw3.WriteLine(this.textLayer2High.Text);
                        sw3.WriteLine(this.textLayer3High.Text);
                        sw3.WriteLine(this.textLayer4High.Text);
                        sw3.WriteLine(this.textLayer5High.Text);
                        sw3.WriteLine(this.textLayer6High.Text);
                        sw3.WriteLine(this.textLayer7High.Text);
                        sw3.WriteLine(this.textLayer8High.Text);
                        sw3.WriteLine(this.textLayer1Average.Text);
                        sw3.WriteLine(this.textLayer2Average.Text);
                        sw3.WriteLine(this.textLayer3Average.Text);
                        sw3.WriteLine(this.textLayer4Average.Text);
                        sw3.WriteLine(this.textLayer5Average.Text);
                        sw3.WriteLine(this.textLayer6Average.Text);
                        sw3.WriteLine(this.textLayer7Average.Text);
                        sw3.WriteLine(this.textLayer8Average.Text);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("Soil Survey K - Low - High - Average Option");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.radioExportLow.Checked);
                        sw3.WriteLine(this.radioExportHigh.Checked);
                        sw3.WriteLine(this.radioExportAverage.Checked);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("Final Result");
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine(this.textLateralEffect.Text);
                        sw3.WriteLine("****************************************");
                        sw3.WriteLine("****************END*********************");
                        sw3.WriteLine("****************************************");


                        //Clean up and close file
                        sw3.Flush();
                        sw3.Close();
                    }
                }
            }

            //End .this format of saving project file information
            //**********************************************************************







        }


        #endregion


        #region "Open Project"

        private void mnuOpenProject_Click(object sender, System.EventArgs e)
        {


            //Opens project file and set combobox, radios, textboxes 



            // Display the Open dialog box
            // Find out if the user selected a file and clicked OK
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream strFilename = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader stmReader10 = new StreamReader(strFilename);

                if (File.Exists(this.openFileDialog1.FileName))
                {
                    // Retrieve the values from the file


                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.textProjectName.Text = stmReader10.ReadLine();
                    this.textUserName.Text = stmReader10.ReadLine();
                    this.textCompany.Text = stmReader10.ReadLine();
                    this.textDepartment.Text = stmReader10.ReadLine();
                    this.textLocation.Text = stmReader10.ReadLine();
                    this.textCoordinates.Text = stmReader10.ReadLine();
                    this.textSoilSeries.Text = stmReader10.ReadLine();
                    this.textNotes.Text = stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.menuMetric.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.comboState.SelectedIndex = Convert.ToInt16(stmReader10.ReadLine());
                    this.comboCounty.SelectedIndex = Convert.ToInt16(stmReader10.ReadLine());
                    this.comboStorage.SelectedIndex = Convert.ToInt16(stmReader10.ReadLine());
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.checkBoxOverride.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    this.textT25Override.Text = stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.radioPercent.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    this.radio14Days.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    this.textHydroperiod.Text = stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.textDitchDepth.Text = stmReader10.ReadLine();
                    this.textDitchImpermeable.Text = stmReader10.ReadLine();
                    this.textDitchPorosity.Text = stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.radioUserLat.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    this.radioSSLat.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.textDepthLayer1.Text = stmReader10.ReadLine();
                    this.textDepthLayer2.Text = stmReader10.ReadLine();
                    this.textDepthLayer3.Text = stmReader10.ReadLine();
                    this.textDepthLayer4.Text = stmReader10.ReadLine();
                    this.textDepthLayer5.Text = stmReader10.ReadLine();
                    this.textDepthLayer6.Text = stmReader10.ReadLine();
                    this.textDepthLayer7.Text = stmReader10.ReadLine();
                    this.textDepthLayer8.Text = stmReader10.ReadLine();
                    this.textKLayer1.Text = stmReader10.ReadLine();
                    this.textKLayer2.Text = stmReader10.ReadLine();
                    this.textKLayer3.Text = stmReader10.ReadLine();
                    this.textKLayer4.Text = stmReader10.ReadLine();
                    this.textKLayer5.Text = stmReader10.ReadLine();
                    this.textKLayer6.Text = stmReader10.ReadLine();
                    this.textKLayer7.Text = stmReader10.ReadLine();
                    this.textKLayer8.Text = stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.comboSoilSurvey.SelectedIndex = Convert.ToInt16(stmReader10.ReadLine());
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.textLayer1Bottom.Text = stmReader10.ReadLine();
                    this.textLayer2Bottom.Text = stmReader10.ReadLine();
                    this.textLayer3Bottom.Text = stmReader10.ReadLine();
                    this.textLayer4Bottom.Text = stmReader10.ReadLine();
                    this.textLayer5Bottom.Text = stmReader10.ReadLine();
                    this.textLayer6Bottom.Text = stmReader10.ReadLine();
                    this.textLayer7Bottom.Text = stmReader10.ReadLine();
                    this.textLayer8Bottom.Text = stmReader10.ReadLine();
                    this.textLayer1Low.Text = stmReader10.ReadLine();
                    this.textLayer2Low.Text = stmReader10.ReadLine();
                    this.textLayer3Low.Text = stmReader10.ReadLine();
                    this.textLayer4Low.Text = stmReader10.ReadLine();
                    this.textLayer5Low.Text = stmReader10.ReadLine();
                    this.textLayer6Low.Text = stmReader10.ReadLine();
                    this.textLayer7Low.Text = stmReader10.ReadLine();
                    this.textLayer8Low.Text = stmReader10.ReadLine();
                    this.textLayer1High.Text = stmReader10.ReadLine();
                    this.textLayer2High.Text = stmReader10.ReadLine();
                    this.textLayer3High.Text = stmReader10.ReadLine();
                    this.textLayer4High.Text = stmReader10.ReadLine();
                    this.textLayer5High.Text = stmReader10.ReadLine();
                    this.textLayer6High.Text = stmReader10.ReadLine();
                    this.textLayer7High.Text = stmReader10.ReadLine();
                    this.textLayer8High.Text = stmReader10.ReadLine();
                    this.textLayer1Average.Text = stmReader10.ReadLine();
                    this.textLayer2Average.Text = stmReader10.ReadLine();
                    this.textLayer3Average.Text = stmReader10.ReadLine();
                    this.textLayer4Average.Text = stmReader10.ReadLine();
                    this.textLayer5Average.Text = stmReader10.ReadLine();
                    this.textLayer6Average.Text = stmReader10.ReadLine();
                    this.textLayer7Average.Text = stmReader10.ReadLine();
                    this.textLayer8Average.Text = stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.radioExportLow.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    this.radioExportHigh.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    this.radioExportAverage.Checked = Convert.ToBoolean(stmReader10.ReadLine());
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    this.textLateralEffect.Text = stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();
                    stmReader10.ReadLine();


                    //Clean up and close file

                    stmReader10.Close();


                }
            }



        }
        #endregion


        #region "Import Version 1 Proect"

        private void menuImport_Click(object sender, EventArgs e)
        {

            string radio1Inch = "0";
            string radio2Inch = "0";
            string radio1ft = "0";
            string radio2ft = "0";
            string radio3ft = "0";
            string radio4ft = "0";
            string radio5ft = "0";
            string radio6ft = "0";

            this.comboState.Text = "North_Carolina";



            // Display the Open dialog box
            // Find out if the user selected a file and clicked OK
            if (this.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                FileStream strFilename = new FileStream(this.openFileDialog2.FileName, FileMode.Open, FileAccess.Read);
                StreamReader stmReader20 = new StreamReader(strFilename);

                if (File.Exists(this.openFileDialog2.FileName))
                {
                    // Retrieve the values from the file

                    this.textProjectName.Text = stmReader20.ReadLine();
                    this.textSoilSeries.Text = stmReader20.ReadLine();
                    this.textUserName.Text = stmReader20.ReadLine();
                    stmReader20.ReadLine();
                    stmReader20.ReadLine();
                    this.comboCounty.SelectedIndex = Convert.ToInt16(stmReader20.ReadLine());
                    radio1Inch = stmReader20.ReadLine();
                    radio2Inch = stmReader20.ReadLine();
                    radio1ft = stmReader20.ReadLine();
                    radio2ft = stmReader20.ReadLine();
                    radio3ft = stmReader20.ReadLine();
                    radio4ft = stmReader20.ReadLine();
                    radio5ft = stmReader20.ReadLine();
                    radio6ft = stmReader20.ReadLine();
                    this.textDitchImpermeable.Text = stmReader20.ReadLine();
                    this.textDitchPorosity.Text = stmReader20.ReadLine();
                    this.textDepthLayer1.Text = stmReader20.ReadLine();
                    this.textDepthLayer2.Text = stmReader20.ReadLine();
                    this.textDepthLayer3.Text = stmReader20.ReadLine();
                    this.textDepthLayer4.Text = stmReader20.ReadLine();
                    this.textDepthLayer5.Text = stmReader20.ReadLine();
                    this.textKLayer1.Text = stmReader20.ReadLine();
                    this.textKLayer2.Text = stmReader20.ReadLine();
                    this.textKLayer3.Text = stmReader20.ReadLine();
                    this.textKLayer4.Text = stmReader20.ReadLine();
                    this.textKLayer5.Text = stmReader20.ReadLine();
                    this.textLateralEffect.Text = stmReader20.ReadLine();

                    //Clean up and close file

                    stmReader20.Close();
                }

                //determine surface storage
                if (radio1Inch == "True")
                {
                    this.comboStorage.SelectedIndex = 0;
                }else{
                
                    this.comboStorage.SelectedIndex = 1;
                }
                if (radio1ft == "True")
                {
                    this.textDitchDepth.Text = "1";
                }
                if (radio2ft == "True")
                {
                    this.textDitchDepth.Text = "2";
                }
                if (radio3ft == "True")
                {
                    this.textDitchDepth.Text = "3";
                }
                if (radio4ft == "True")
                {
                    this.textDitchDepth.Text = "4";
                }
                if (radio5ft == "True")
                {
                    this.textDitchDepth.Text = "5";
                }
                if (radio6ft == "True")
                {
                    this.textDitchDepth.Text = "6";
                }


            }

        }

        #endregion


        #region "Main Menu Diagrams"

        private void menuDitchDiagram_Click(object sender, System.EventArgs e)
        {
            // Open the Ditch Diagram form in Dialog Mode

            frmDitchDiagram frm = new frmDitchDiagram();

            frm.ShowDialog(this);

            frm.Dispose();
        }



        private void menuPitDiagram_Click(object sender, System.EventArgs e)
        {
            // Open the Borrow Pit Diagram form in Dialog Mode

            //frmBorrowPitDiagram frm = new frmBorrowPitDiagram();

            //frm.ShowDialog(this);

            //frm.Dispose();

        }
        #endregion


        #region "Check for Updates"

        private void menuUpdate_Click(object sender, EventArgs e)
        {
            //This code was created by the following:
            //http://themech.net/2008/05/adding-check-for-update-option-in-csharp/
            //
            // in newVersion variable we will store the
            // version info from xml file
            Version newVersion = null;
            // and in this variable we will put the url we
            // would like to open so that the user can
            // download the new version
            // it can be a homepage or a direct
            // link to zip/exe file
            string url = "http://www.soilwaterresource.com/downloads";
            try
            {
                // provide the XmlTextReader with the URL of
                // our xml document
                string xmlURL = "http://www.soilwaterresource.com/.xmlupdates/lateral_effect_update.xml";
                XmlTextReader reader =
                  new XmlTextReader(xmlURL);
                // simply (and easily) skip the junk at the beginning
                reader.MoveToContent();
                // internal - as the XmlTextReader moves only
                // forward, we save current xml element name
                // in elementName variable. When we parse a
                // text node, we refer to elementName to check
                // what was the node name
                string elementName = "";
                // we check if the xml starts with a proper
                // "ourfancyapp" element node
                if ((reader.NodeType == XmlNodeType.Element) &&
                    (reader.Name == "lateraleffect"))
                {
                    while (reader.Read())
                    {
                        // when we find an element node,
                        // we remember its name
                        if (reader.NodeType == XmlNodeType.Element)
                            elementName = reader.Name;
                        else
                        {
                            // for text nodes...
                            if ((reader.NodeType == XmlNodeType.Text) &&
                                (reader.HasValue))
                            {
                                // we check what the name of the node was
                                switch (elementName)
                                {
                                    case "version":
                                        // thats why we keep the version info
                                        // in xxx.xxx.xxx.xxx format
                                        // the Version class does the
                                        // parsing for us
                                        newVersion = new Version(reader.Value);
                                        break;
                                    case "url":
                                        url = reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
            }

            // get the running version
            Version curVersion =
             System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            // compare the versions
            if (curVersion.CompareTo(newVersion) < 0)
            {
                // ask the user if he would like
                // to download the new version
                string title = "A new version is available to download (" + newVersion + ")";
                string question = "Close program and go to download site?";
                if (DialogResult.Yes ==
                 MessageBox.Show(this, question, title,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question))
                {
                    // navigate the default web
                    // browser to our app
                    // homepage (the url
                    // comes from the xml content)
                    System.Diagnostics.Process.Start(url);
                    //pause 2 seconds and close program
                    Thread.Sleep(2000);
                    this.Close();
                }
            }
            if (curVersion.CompareTo(newVersion) >= 0)
            {
                MessageBox.Show("No new updates are currently available.\n\n You are running version " + curVersion + "\n\n The latest version for download is version " + newVersion, "Congratulations",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return;
            }


        }

        #endregion


        #region "Tutorial and Suppport Menu"

        private void menuTutorials_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://www.soilwaterresource.com");

        }


        #endregion


        #region " Version Info Menu"

        private void menVer_Click(object sender, EventArgs e)
        {
            // Open the About form in Dialog Mode

            frmAbout frm = new frmAbout();

            frm.ShowDialog(this);

            frm.Dispose();


        }

        #endregion


        #region "Clear Cells"

        private void menuClearCells_Click(object sender, System.EventArgs e)
        {

            this.textProjectName.Text = "";
            this.textUserName.Text = "";
            this.textCompany.Text = "";
            this.textDepartment.Text = "";
            this.textLocation.Text = "";
            this.textCoordinates.Text = "";
            this.textSoilSeries.Text = "";
            this.textNotes.Text = "";

            this.comboState.SelectedIndex = 0;
            this.comboCounty.SelectedIndex = 0;
            this.comboStorage.SelectedIndex = 0;

            this.checkBoxOverride.Checked = false;
            this.textT25Override.Text = "";

            this.radioPercent.Checked = true;
            this.radio14Days.Checked = false;
            this.textHydroperiod.Text = "";

            this.textDitchDepth.Text = "";
            this.textDitchImpermeable.Text = "";
            this.textDitchPorosity.Text = "";

            this.radioUserLat.Checked = true;
            this.radioSSLat.Checked = false;

            this.textDepthLayer1.Text = "";
            this.textDepthLayer2.Text = "";
            this.textDepthLayer3.Text = "";
            this.textDepthLayer4.Text = "";
            this.textDepthLayer5.Text = "";
            this.textDepthLayer6.Text = "";
            this.textDepthLayer7.Text = "";
            this.textDepthLayer8.Text = "";
            this.textKLayer1.Text = "";
            this.textKLayer2.Text = "";
            this.textKLayer3.Text = "";
            this.textKLayer4.Text = "";
            this.textKLayer5.Text = "";
            this.textKLayer6.Text = "";
            this.textKLayer7.Text = "";
            this.textKLayer8.Text = "";

            this.radioExportLow.Checked = false;
            this.radioExportHigh.Checked = false;
            this.radioExportAverage.Checked = true;

            this.comboSoilSurvey.SelectedIndex = 0;

            this.textLayer1Bottom.Text = "";
            this.textLayer2Bottom.Text = "";
            this.textLayer3Bottom.Text = "";
            this.textLayer4Bottom.Text = "";
            this.textLayer5Bottom.Text = "";
            this.textLayer6Bottom.Text = "";
            this.textLayer7Bottom.Text = "";
            this.textLayer8Bottom.Text = "";
            this.textLayer1Low.Text = "";
            this.textLayer2Low.Text = "";
            this.textLayer3Low.Text = "";
            this.textLayer4Low.Text = "";
            this.textLayer5Low.Text = "";
            this.textLayer6Low.Text = "";
            this.textLayer7Low.Text = "";
            this.textLayer8Low.Text = "";
            this.textLayer1High.Text = "";
            this.textLayer2High.Text = "";
            this.textLayer3High.Text = "";
            this.textLayer4High.Text = "";
            this.textLayer5High.Text = "";
            this.textLayer6High.Text = "";
            this.textLayer7High.Text = "";
            this.textLayer8High.Text = "";
            this.textLayer1Average.Text = "";
            this.textLayer2Average.Text = "";
            this.textLayer3Average.Text = "";
            this.textLayer4Average.Text = "";
            this.textLayer5Average.Text = "";
            this.textLayer6Average.Text = "";
            this.textLayer7Average.Text = "";
            this.textLayer8Average.Text = "";

            this.textLateralEffect.Text = "";

            return;

        }

        private void menuClearNotProject_Click(object sender, EventArgs e)
        {
            this.comboState.SelectedIndex = 0;
            this.comboCounty.SelectedIndex = 0;
            this.comboStorage.SelectedIndex = 0;

            this.checkBoxOverride.Checked = false;
            this.textT25Override.Text = "";

            this.radioPercent.Checked = true;
            this.radio14Days.Checked = false;
            this.textHydroperiod.Text = "";

            this.textDitchDepth.Text = "";
            this.textDitchImpermeable.Text = "";
            this.textDitchPorosity.Text = "";

            this.radioUserLat.Checked = true;
            this.radioSSLat.Checked = false;


            this.textDepthLayer1.Text = "";
            this.textDepthLayer2.Text = "";
            this.textDepthLayer3.Text = "";
            this.textDepthLayer4.Text = "";
            this.textDepthLayer5.Text = "";
            this.textDepthLayer6.Text = "";
            this.textDepthLayer7.Text = "";
            this.textDepthLayer8.Text = "";
            this.textKLayer1.Text = "";
            this.textKLayer2.Text = "";
            this.textKLayer3.Text = "";
            this.textKLayer4.Text = "";
            this.textKLayer5.Text = "";
            this.textKLayer6.Text = "";
            this.textKLayer7.Text = "";
            this.textKLayer8.Text = "";

            this.radioExportLow.Checked = false;
            this.radioExportHigh.Checked = false;
            this.radioExportAverage.Checked = true;

            this.comboSoilSurvey.SelectedIndex = 0;

            this.textLayer1Bottom.Text = "";
            this.textLayer2Bottom.Text = "";
            this.textLayer3Bottom.Text = "";
            this.textLayer4Bottom.Text = "";
            this.textLayer5Bottom.Text = "";
            this.textLayer6Bottom.Text = "";
            this.textLayer7Bottom.Text = "";
            this.textLayer8Bottom.Text = "";
            this.textLayer1Low.Text = "";
            this.textLayer2Low.Text = "";
            this.textLayer3Low.Text = "";
            this.textLayer4Low.Text = "";
            this.textLayer5Low.Text = "";
            this.textLayer6Low.Text = "";
            this.textLayer7Low.Text = "";
            this.textLayer8Low.Text = "";
            this.textLayer1High.Text = "";
            this.textLayer2High.Text = "";
            this.textLayer3High.Text = "";
            this.textLayer4High.Text = "";
            this.textLayer5High.Text = "";
            this.textLayer6High.Text = "";
            this.textLayer7High.Text = "";
            this.textLayer8High.Text = "";
            this.textLayer1Average.Text = "";
            this.textLayer2Average.Text = "";
            this.textLayer3Average.Text = "";
            this.textLayer4Average.Text = "";
            this.textLayer5Average.Text = "";
            this.textLayer6Average.Text = "";
            this.textLayer7Average.Text = "";
            this.textLayer8Average.Text = "";

            this.textLateralEffect.Text = "";

            return;
        }

        #endregion



        #endregion


        #region "Context sensitive help links"

        private void menuStorageHelp_Click(object sender, System.EventArgs e)
        {
            // Open the Help file to specific location

            Help.ShowHelp(this, "lateral_effect.chm", HelpNavigator.Topic, "general.htm#Storage");
        }

        private void menuDepthHelp_Click(object sender, System.EventArgs e)
        {
            // Open the Help file to specific location

            Help.ShowHelp(this, "lateral_effect.chm", HelpNavigator.Topic, "general.htm#WaterDepth");
        }

        private void menuOtherHelp_Click(object sender, System.EventArgs e)
        {
            // Open the Help file to specific location

            Help.ShowHelp(this, "lateral_effect.chm", HelpNavigator.Topic, "general.htm#Restrictive");
        }

        private void menuConductivityHelp_Click(object sender, System.EventArgs e)
        {
            // Open the Help file to specific location

            Help.ShowHelp(this, "lateral_effect.chm", HelpNavigator.Topic, "general.htm#Conductivity");
        }

        private void menuImpoundmentHelp_Click(object sender, System.EventArgs e)
        {
            // Open the Help file to specific location for Imoundment type help

            Help.ShowHelp(this, "lateral_effect.chm", HelpNavigator.Topic, "general.htm#Type");
        }

        //private void menuImpoundmentHelp_Click(object sender, System.EventArgs e)
        //{
        // Open the Help file to Impoundment Section

        //Help.ShowHelp(this, "lateral_effect.chm", HelpNavigator.Topic, "general.htm#Type");
        //}

        private void menuImpoundmentDitch_Click(object sender, System.EventArgs e)
        {
            // Open the Ditch Diagram form in Dialog Mode

            frmDitchDiagram frm = new frmDitchDiagram();

            frm.ShowDialog(this);

            frm.Dispose();

        }

        // private void menuImpoundmentPit_Click(object sender, System.EventArgs e)
        // {
        // Open the Borrow Pit Diagram form in Dialog Mode

        //   frmBorrowPitDiagram frm = new frmBorrowPitDiagram();

        //    frm.ShowDialog(this);

        //    frm.Dispose();
        // }


        #endregion


        #region "Load County List when State changes"

        private void comboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear Current Lists
            comboCounty.Items.Clear();

            //Load lists of States from XML file, start drop down box with North Carolina

            //Set file name with list of states
            string sStateLabel = this.comboState.Text;
            string sStateLabelLower = sStateLabel.ToLower();

            //Concatenate to get filename
            string sCountyList = "data/" + sStateLabelLower + "_county_list.xml";

            //Set path to location of program
            Directory.SetCurrentDirectory(Application.StartupPath);

            //Throw Message if File Does Not Exists
            if (!File.Exists(sCountyList))
            {

                MessageBox.Show("You are missing the County List for this State or the file has been corrupted .\n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Otherwise load state list to state combo box
            else
            {

                try
                {
                    //Open XML file - located in Data Folder
                    XmlDocument doc = new XmlDocument();
                    doc.Load(sCountyList);

                    //Populate Soil Survey Combo Box
                    XmlNodeList countyList = doc.SelectNodes("counties/county");
                    foreach (XmlNode county in countyList)
                    {
                        comboCounty.Items.Add(county.InnerText);
                    }

                }

                catch (Exception)
                {

                    MessageBox.Show("You're County List for this State has been corrupted .\n\n You will not be able to run the program until the State List file has been repaired or replaced. \n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }


        #endregion


        #region "Hydraulic Conductivity"


        #region "Load County Soil List when County Changes"

        private void comboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear Current List
            comboSoilSurvey.Items.Clear();


            //Determine appropriate Soil List XML file

            string sStateLabel = this.comboState.Text;
            string sCountyLabel = this.comboCounty.Text;
            string sStateLabelLower = sStateLabel.ToLower();
            string sCountyLabelLower = sCountyLabel.ToLower();
            //Concatenate to get filename
            string sStateCountySoilList = "data/" + sStateLabelLower + "_" + sCountyLabelLower + "_SoilList.xml";


            //Set path to location of program
            Directory.SetCurrentDirectory(Application.StartupPath);

            //Throw Message if File Does Not Exists
            if (!File.Exists(sStateCountySoilList))
            {

                MessageBox.Show("You are missing this counties soil files or the file has been corrupted .\n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show(sStateCountySoilList, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                try
                {
                    //Open XML file - located in Data Folder
                    XmlDocument doc = new XmlDocument();
                    doc.Load(sStateCountySoilList);

                    //Populate Soil Survey Combo Box
                    XmlNodeList soilList = doc.SelectNodes("soils/soil");
                    foreach (XmlNode soil in soilList)
                    {
                        comboSoilSurvey.Items.Add(soil.InnerText);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("You're Soil List file has been corrupted .\n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }


            return;
        }




        #endregion


        #region "Populate Soil Survey Conductivity Cells When Soil Choosen"

        private void comboSoilSurvey_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Is it Metric or English Units - Need conversion factor

            //Convert um/sec to cm/hr or in/hr for conductivity
            double dConversionFactor = 1;

            //Convert inches to cm for layer depths
            double dConversionFactorDepth = 1;

            //English
            if (!menuMetric.Checked)
            {
                dConversionFactor = 0.00003937 * 60 * 60;
                dConversionFactorDepth = 1;

            }
            //Metric
            else
            {
                dConversionFactor = 0.0001 * 60 * 60;
                dConversionFactorDepth = 2.54;
            }


            string sSoilName = comboSoilSurvey.Text;
            string sSoilNameLower = sSoilName.ToLower();
            string sSoilNameUpper = sSoilName.ToUpper();

            //Determine appropriate XML file

            string sStateLabel = this.comboState.Text;
            string sCountyLabel = this.comboCounty.Text;
            string sStateLabelLower = sStateLabel.ToLower();
            string sCountyLabelLower = sCountyLabel.ToLower();

            //Concatenate to get filename
            string sStateCountySoilK = "data/" + sStateLabelLower + "_" + sCountyLabelLower + "_SoilK.xml";


            //Set path to location of program
            Directory.SetCurrentDirectory(Application.StartupPath);


            //Throw Message if File Does Not Exists
            if (!File.Exists(sStateCountySoilK))
            {

                MessageBox.Show("You are missing this counties soil files or the file has been corrupted .\n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                try
                {
                    //Read in Values from file based on selections

                    string xbottomdepth1 = "0";
                    string xlowk1 = "0";
                    string xhighk1 = "0";
                    string xbottomdepth2 = "0";
                    string xlowk2 = "0";
                    string xhighk2 = "0";
                    string xbottomdepth3 = "0";
                    string xlowk3 = "0";
                    string xhighk3 = "0";
                    string xbottomdepth4 = "0";
                    string xlowk4 = "0";
                    string xhighk4 = "0";
                    string xbottomdepth5 = "0";
                    string xlowk5 = "0";
                    string xhighk5 = "0";
                    string xbottomdepth6 = "0";
                    string xlowk6 = "0";
                    string xhighk6 = "0";
                    string xbottomdepth7 = "0";
                    string xlowk7 = "0";
                    string xhighk7 = "0";
                    string xbottomdepth8 = "0";
                    string xlowk8 = "0";
                    string xhighk8 = "0";


                    XPathDocument doc = new XPathDocument(sStateCountySoilK);
                    XPathNavigator navigator = doc.CreateNavigator();
                    navigator.MoveToChild("Conductivity", "");
                    navigator.MoveToChild(sSoilName, "");
                    navigator.MoveToFirstChild();
                    string xSoilID = navigator.Value;
                    navigator.MoveToNext();

                    if (navigator.Name == "bottomdepth1")
                    {
                        xbottomdepth1 = navigator.Value;
                        navigator.MoveToNext();
                        xlowk1 = navigator.Value;
                        navigator.MoveToNext();
                        xhighk1 = navigator.Value;
                    }
                    navigator.MoveToNext();

                    if (navigator.Name == "bottomdepth2")
                    {
                        xbottomdepth2 = navigator.Value;
                        navigator.MoveToNext();
                        xlowk2 = navigator.Value;
                        navigator.MoveToNext();
                        xhighk2 = navigator.Value;
                    }

                    navigator.MoveToNext();

                    if (navigator.Name == "bottomdepth3")
                    {
                        xbottomdepth3 = navigator.Value;
                        navigator.MoveToNext();
                        xlowk3 = navigator.Value;
                        navigator.MoveToNext();
                        xhighk3 = navigator.Value;
                    }

                    navigator.MoveToNext();

                    if (navigator.Name == "bottomdepth4")
                    {
                        xbottomdepth4 = navigator.Value;
                        navigator.MoveToNext();
                        xlowk4 = navigator.Value;
                        navigator.MoveToNext();
                        xhighk4 = navigator.Value;

                    }

                    navigator.MoveToNext();

                    if (navigator.Name == "bottomdepth5")
                    {
                        xbottomdepth5 = navigator.Value;
                        navigator.MoveToNext();
                        xlowk5 = navigator.Value;
                        navigator.MoveToNext();
                        xhighk5 = navigator.Value;
                    }

                    navigator.MoveToNext();

                    if (navigator.Name == "bottomdepth6")
                    {
                        xbottomdepth6 = navigator.Value;
                        navigator.MoveToNext();
                        xlowk6 = navigator.Value;
                        navigator.MoveToNext();
                        xhighk6 = navigator.Value;
                    }

                    navigator.MoveToNext();

                    if (navigator.Name == "bottomdepth7")
                    {
                        xbottomdepth7 = navigator.Value;
                        navigator.MoveToNext();
                        xlowk7 = navigator.Value;
                        navigator.MoveToNext();
                        xhighk7 = navigator.Value;
                    }

                    navigator.MoveToNext();

                    if (navigator.Name == "bottomdepth8")
                    {
                        xbottomdepth8 = navigator.Value;
                        navigator.MoveToNext();
                        xlowk8 = navigator.Value;
                        navigator.MoveToNext();
                        xhighk8 = navigator.Value;
                    }

                    //Perform Needed Conversions

                    //Declare variables
                    double dxbottomdepth1 = Convert.ToDouble(xbottomdepth1);
                    double dxlowk1 = Convert.ToDouble(xlowk1);
                    double dxhighk1 = Convert.ToDouble(xhighk1);
                    double dxbottomdepth2 = Convert.ToDouble(xbottomdepth2);
                    double dxlowk2 = Convert.ToDouble(xlowk2);
                    double dxhighk2 = Convert.ToDouble(xhighk2);
                    double dxbottomdepth3 = Convert.ToDouble(xbottomdepth3);
                    double dxlowk3 = Convert.ToDouble(xlowk3);
                    double dxhighk3 = Convert.ToDouble(xhighk3);
                    double dxbottomdepth4 = Convert.ToDouble(xbottomdepth4);
                    double dxlowk4 = Convert.ToDouble(xlowk4);
                    double dxhighk4 = Convert.ToDouble(xhighk4);
                    double dxbottomdepth5 = Convert.ToDouble(xbottomdepth5);
                    double dxlowk5 = Convert.ToDouble(xlowk5);
                    double dxhighk5 = Convert.ToDouble(xhighk5);
                    double dxbottomdepth6 = Convert.ToDouble(xbottomdepth6);
                    double dxlowk6 = Convert.ToDouble(xlowk6);
                    double dxhighk6 = Convert.ToDouble(xhighk6);
                    double dxbottomdepth7 = Convert.ToDouble(xbottomdepth7);
                    double dxlowk7 = Convert.ToDouble(xlowk7);
                    double dxhighk7 = Convert.ToDouble(xhighk7);
                    double dxbottomdepth8 = Convert.ToDouble(xbottomdepth8);
                    double dxlowk8 = Convert.ToDouble(xlowk8);
                    double dxhighk8 = Convert.ToDouble(xhighk8);

                    //Convert Layer Depths
                    dxbottomdepth1 = dxbottomdepth1 * dConversionFactorDepth;
                    dxbottomdepth2 = dxbottomdepth2 * dConversionFactorDepth;
                    dxbottomdepth3 = dxbottomdepth3 * dConversionFactorDepth;
                    dxbottomdepth4 = dxbottomdepth4 * dConversionFactorDepth;
                    dxbottomdepth5 = dxbottomdepth5 * dConversionFactorDepth;
                    dxbottomdepth6 = dxbottomdepth6 * dConversionFactorDepth;
                    dxbottomdepth7 = dxbottomdepth7 * dConversionFactorDepth;
                    dxbottomdepth8 = dxbottomdepth8 * dConversionFactorDepth;



                    //Convert Conductivity
                    dxlowk1 = dxlowk1 * dConversionFactor;
                    dxhighk1 = dxhighk1 * dConversionFactor;
                    dxlowk2 = dxlowk2 * dConversionFactor;
                    dxhighk2 = dxhighk2 * dConversionFactor;
                    dxlowk3 = dxlowk3 * dConversionFactor;
                    dxhighk3 = dxhighk3 * dConversionFactor;
                    dxlowk4 = dxlowk4 * dConversionFactor;
                    dxhighk4 = dxhighk4 * dConversionFactor;
                    dxlowk5 = dxlowk5 * dConversionFactor;
                    dxhighk5 = dxhighk5 * dConversionFactor;
                    dxlowk6 = dxlowk6 * dConversionFactor;
                    dxhighk6 = dxhighk6 * dConversionFactor;
                    dxlowk7 = dxlowk7 * dConversionFactor;
                    dxhighk7 = dxhighk7 * dConversionFactor;
                    dxlowk8 = dxlowk8 * dConversionFactor;
                    dxhighk8 = dxhighk8 * dConversionFactor;

                    //Set Fields in Conductivity Section
                    this.textLayer1Bottom.Text = dxbottomdepth1.ToString("f2");
                    this.textLayer2Bottom.Text = dxbottomdepth2.ToString("f2");
                    this.textLayer3Bottom.Text = dxbottomdepth3.ToString("f2");
                    this.textLayer4Bottom.Text = dxbottomdepth4.ToString("f2");
                    this.textLayer5Bottom.Text = dxbottomdepth5.ToString("f2");
                    this.textLayer6Bottom.Text = dxbottomdepth6.ToString("f2");
                    this.textLayer7Bottom.Text = dxbottomdepth7.ToString("f2");
                    this.textLayer8Bottom.Text = dxbottomdepth8.ToString("f2");
                    this.textLayer1Low.Text = dxlowk1.ToString("f2");
                    this.textLayer2Low.Text = dxlowk2.ToString("f2");
                    this.textLayer3Low.Text = dxlowk3.ToString("f2");
                    this.textLayer4Low.Text = dxlowk4.ToString("f2");
                    this.textLayer5Low.Text = dxlowk5.ToString("f2");
                    this.textLayer6Low.Text = dxlowk6.ToString("f2");
                    this.textLayer7Low.Text = dxlowk7.ToString("f2");
                    this.textLayer8Low.Text = dxlowk8.ToString("f2");
                    this.textLayer1High.Text = dxhighk1.ToString("f2");
                    this.textLayer2High.Text = dxhighk2.ToString("f2");
                    this.textLayer3High.Text = dxhighk3.ToString("f2");
                    this.textLayer4High.Text = dxhighk4.ToString("f2");
                    this.textLayer5High.Text = dxhighk5.ToString("f2");
                    this.textLayer6High.Text = dxhighk6.ToString("f2");
                    this.textLayer7High.Text = dxhighk7.ToString("f2");
                    this.textLayer8High.Text = dxhighk8.ToString("f2");

                }

                catch (Exception)
                {

                    MessageBox.Show("You're Soil K file has been corrupted .\n\n You will not be able to run the program until the State List file has been repaired or replaced. \n\n Please download a new version from the website.\n\n Click 'Tutorials and Support' to go to the website.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }


        }

        #endregion


        #region "Declare Variable"

        //***********************************************************************
        //Declare some Variables
        //***********************************************************************


        double dLayer1Low;
        double dLayer1High;
        double dLayer1Average;

        double dLayer2Low;
        double dLayer2High;
        double dLayer2Average;

        double dLayer3Low;
        double dLayer3High;
        double dLayer3Average;

        double dLayer4Low;
        double dLayer4High;
        double dLayer4Average;

        double dLayer5Low;
        double dLayer5High;
        double dLayer5Average;

        double dLayer6Low;
        double dLayer6High;
        double dLayer6Average;

        double dLayer7Low;
        double dLayer7High;
        double dLayer7Average;

        double dLayer8Low;
        double dLayer8High;
        double dLayer8Average;

        //***********************************************************************
        //***********************************************************************
        #endregion


        #region "Handling non-numerics"
        //The codes below prevent non-numerics from being enetered and allow for 
        //one decimal.

        //I modified the below code from "Solitaire" to exclude the negative sign
        //URL:  http://forums.microsoft.com/MSDN/ShowPost.aspx?PostID=825506&SiteID=1
        //Date 02-17-2007



        private void textLayer1Low_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer1Bottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer1Bottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer1Bottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }


        private void textLayer1High_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer1High.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer1High.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer1High.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }



        private void textLayer2Low_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer2Low.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer2Low.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer2Low.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer2High_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer2High.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer2High.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer2High.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }




        private void textLayer3Low_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer3Low.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer3Low.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer3Low.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer3High_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer3High.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer3High.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer3High.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }



        private void textLayer4Low_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer4Low.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer4Low.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer4Low.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer4High_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer4High.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer4High.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer4High.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }




        private void textLayer5Low_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer5Low.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer5Low.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer5Low.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer5High_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer5High.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer5High.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer5High.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }



        private void textLayer6Low_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer6Low.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer6Low.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer6Low.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer6High_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer6High.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer6High.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer6High.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }


        private void textLayer7Low_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer7Low.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer7Low.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer7Low.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer7High_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer7High.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer7High.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer7High.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }



        private void textLayer8Low_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer8Low.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer8Low.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer8Low.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textLayer8High_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' & textLayer8High.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLayer8High.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLayer8High.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }


        #endregion


        #region "Average Read Only K calcs"

        //***********************************************************************
        //Below code outputs real time K average to screen
        //***********************************************************************


        private void textLayer1Low_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer1Low.Text == "") return;
                if (textLayer1Low.Text == ".") return;


                //Read in Permeability Inputs for Soil Layer 1

                dLayer1Low = Convert.ToDouble(textLayer1Low.Text);
                dLayer1High = Convert.ToDouble(textLayer1High.Text);

                //Calculate real time average
                dLayer1Average = ((dLayer1High + dLayer1Low) / 2);

                //Output real time average to screen
                string sLayer1Average = dLayer1Average.ToString("f2");
                textLayer1Average.Text = sLayer1Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer1High_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer1High.Text == "") return;
                if (textLayer1High.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 1

                dLayer1Low = Convert.ToDouble(textLayer1Low.Text);
                dLayer1High = Convert.ToDouble(textLayer1High.Text);

                //Calculate real time average
                dLayer1Average = ((dLayer1High + dLayer1Low) / 2);

                //Output real time average to screen
                string sLayer1Average = dLayer1Average.ToString("f2");
                textLayer1Average.Text = sLayer1Average;

            }
            catch
            {
                return;
            }
        }

        private void textLayer2Low_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer2Low.Text == "") return;
                if (textLayer2Low.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 2

                dLayer2Low = Convert.ToDouble(textLayer2Low.Text);
                dLayer2High = Convert.ToDouble(textLayer2High.Text);

                //Calculate real time average
                dLayer2Average = ((dLayer2High + dLayer2Low) / 2);

                //Output real time average to screen
                string sLayer2Average = dLayer2Average.ToString("f2");
                textLayer2Average.Text = sLayer2Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer2High_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer2High.Text == "") return;
                if (textLayer2High.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 2

                dLayer2Low = Convert.ToDouble(textLayer2Low.Text);
                dLayer2High = Convert.ToDouble(textLayer2High.Text);

                //Calculate real time average
                dLayer2Average = ((dLayer2High + dLayer2Low) / 2);

                //Output real time average to screen
                string sLayer2Average = dLayer2Average.ToString("f2");
                textLayer2Average.Text = sLayer2Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer3Low_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer3Low.Text == "") return;
                if (textLayer3Low.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 3

                dLayer3Low = Convert.ToDouble(textLayer3Low.Text);
                dLayer3High = Convert.ToDouble(textLayer3High.Text);

                //Calculate real time average
                dLayer3Average = ((dLayer3High + dLayer3Low) / 2);

                //Output real time average to screen
                string sLayer3Average = dLayer3Average.ToString("f2");
                textLayer3Average.Text = sLayer3Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer3High_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer3High.Text == "") return;
                if (textLayer3High.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 3

                dLayer3Low = Convert.ToDouble(textLayer3Low.Text);
                dLayer3High = Convert.ToDouble(textLayer3High.Text);

                //Calculate real time average
                dLayer3Average = ((dLayer3High + dLayer3Low) / 2);

                //Output real time average to screen
                string sLayer3Average = dLayer3Average.ToString("f2");
                textLayer3Average.Text = sLayer3Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer4Low_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer4Low.Text == "") return;
                if (textLayer4Low.Text == ".") return;


                //Read in Permeability Inputs for Soil Layer 4

                dLayer4Low = Convert.ToDouble(textLayer4Low.Text);
                dLayer4High = Convert.ToDouble(textLayer4High.Text);

                //Calculate real time average
                dLayer4Average = ((dLayer4High + dLayer4Low) / 2);

                //Output real time average to screen
                string sLayer4Average = dLayer4Average.ToString("f2");
                textLayer4Average.Text = sLayer4Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer4High_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer4High.Text == "") return;
                if (textLayer4High.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 4

                dLayer4Low = Convert.ToDouble(textLayer4Low.Text);
                dLayer4High = Convert.ToDouble(textLayer4High.Text);

                //Calculate real time average
                dLayer4Average = ((dLayer4High + dLayer4Low) / 2);

                //Output real time average to screen
                string sLayer4Average = dLayer4Average.ToString("f2");
                textLayer4Average.Text = sLayer4Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer5Low_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer5Low.Text == "") return;
                if (textLayer5Low.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 5

                dLayer5Low = Convert.ToDouble(textLayer5Low.Text);
                dLayer5High = Convert.ToDouble(textLayer5High.Text);

                //Calculate real time average
                dLayer5Average = ((dLayer5High + dLayer5Low) / 2);

                //Output real time average to screen
                string sLayer5Average = dLayer5Average.ToString("f2");
                textLayer5Average.Text = sLayer5Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer5High_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer5High.Text == "") return;
                if (textLayer5High.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 5

                dLayer5Low = Convert.ToDouble(textLayer5Low.Text);
                dLayer5High = Convert.ToDouble(textLayer5High.Text);

                //Calculate real time average
                dLayer5Average = ((dLayer5High + dLayer5Low) / 2);

                //Output real time average to screen
                string sLayer5Average = dLayer5Average.ToString("f2");
                textLayer5Average.Text = sLayer5Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer6Low_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer6Low.Text == "") return;
                if (textLayer6Low.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 5

                dLayer6Low = Convert.ToDouble(textLayer6Low.Text);
                dLayer6High = Convert.ToDouble(textLayer6High.Text);

                //Calculate real time average
                dLayer6Average = ((dLayer6High + dLayer6Low) / 2);

                //Output real time average to screen
                string sLayer6Average = dLayer6Average.ToString("f2");
                textLayer6Average.Text = sLayer6Average;
            }
            catch
            {
                return;
            }
        }


        private void textLayer6High_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer6High.Text == "") return;
                if (textLayer6High.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 5

                dLayer6Low = Convert.ToDouble(textLayer6Low.Text);
                dLayer6High = Convert.ToDouble(textLayer6High.Text);

                //Calculate real time average
                dLayer6Average = ((dLayer6High + dLayer6Low) / 2);

                //Output real time average to screen
                string sLayer6Average = dLayer6Average.ToString("f2");
                textLayer6Average.Text = sLayer6Average;
            }
            catch
            {
                return;
            }
        }
        private void textLayer7Low_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer7Low.Text == "") return;
                if (textLayer7Low.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 5

                dLayer7Low = Convert.ToDouble(textLayer7Low.Text);
                dLayer7High = Convert.ToDouble(textLayer7High.Text);

                //Calculate real time average
                dLayer7Average = ((dLayer7High + dLayer7Low) / 2);

                //Output real time average to screen
                string sLayer7Average = dLayer7Average.ToString("f2");
                textLayer7Average.Text = sLayer7Average;
            }
            catch
            {
                return;
            }
        }


        private void textLayer7High_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer7High.Text == "") return;
                if (textLayer7High.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 5

                dLayer7Low = Convert.ToDouble(textLayer7Low.Text);
                dLayer7High = Convert.ToDouble(textLayer7High.Text);

                //Calculate real time average
                dLayer7Average = ((dLayer7High + dLayer7Low) / 2);

                //Output real time average to screen
                string sLayer7Average = dLayer7Average.ToString("f2");
                textLayer7Average.Text = sLayer7Average;
            }
            catch
            {
                return;
            }
        }

        private void textLayer8Low_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer8Low.Text == "") return;
                if (textLayer8Low.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 5

                dLayer8Low = Convert.ToDouble(textLayer8Low.Text);
                dLayer8High = Convert.ToDouble(textLayer8High.Text);

                //Calculate real time average
                dLayer8Average = ((dLayer8High + dLayer8Low) / 2);

                //Output real time average to screen
                string sLayer8Average = dLayer8Average.ToString("f2");
                textLayer8Average.Text = sLayer8Average;
            }
            catch
            {
                return;
            }
        }


        private void textLayer8High_TextChanged(object sender, System.EventArgs e)
        {
            try
            {

                //The below code will prevent an empty cell or a decimal point
                //from stopping the average calculation
                if (textLayer8High.Text == "") return;
                if (textLayer8High.Text == ".") return;

                //Read in Permeability Inputs for Soil Layer 5

                dLayer8Low = Convert.ToDouble(textLayer8Low.Text);
                dLayer8High = Convert.ToDouble(textLayer8High.Text);

                //Calculate real time average
                dLayer8Average = ((dLayer8High + dLayer8Low) / 2);

                //Output real time average to screen
                string sLayer8Average = dLayer8Average.ToString("f2");
                textLayer8Average.Text = sLayer8Average;
            }
            catch
            {
                return;
            }
        }




        //***********************************************************************
        //***********************************************************************

        #endregion


        #endregion


        #region "T25Override CheckBox Status Change"

        private void checkBoxOverride_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxOverride.Checked == true)
            {
                textT25Override.ReadOnly = false;

            }
            else if (checkBoxOverride.Checked == false)
            {
                textT25Override.ReadOnly = true;

            }


        }

        #endregion


        #region "INACTIVE CODE"


        #region "INACTIVE - Soil Survey Utility and PDF"

        //        private void buttonSoilPDF_Click(object sender, EventArgs e)
        //        {

        //**************************************************************
        //  Check for State
        //**************************************************************
        //            if (comboState.Text == "Choose State")
        //            {
        //                MessageBox.Show("Choose State from Dropdown Box", "Error",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //**************************************************************
        //  Check for County
        //**************************************************************
        //            if (comboCounty.Text == "Choose County")
        //            {
        //                MessageBox.Show("Choose County from Dropdown Box", "Error",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //Determine appropriate file based on state-county-surface storage info

        //            string sStateLabel1 = this.comboState.Text;
        //            string sCountyLabel1 = this.comboCounty.Text;

        //Concatenate to get filename
        //            string sStateCountyPDF = sStateLabel1 + sCountyLabel1 + ".pdf";

        //Open PDF
        //            Directory.SetCurrentDirectory(Application.StartupPath+@"\data\");
        //            Process.Start(sStateCountyPDF);

        //Wait 2 seconds
        //            Thread.Sleep(2000);
        //Reset directory

        //            Directory.SetCurrentDirectory(Application.StartupPath);

        //Start utility
        //           frmSoilSurvey oForm2 = new frmSoilSurvey();
        //           oForm2.MyParentForm = this;

        //            if (oForm2.ShowDialog() == DialogResult.OK)
        //          {
        //Open soil survey export file and populate hydraulic conductivity fields
        //Open file using filestream and streamreader
        //                FileStream stmImport = new FileStream("soilsurveyexport.dat", FileMode.Open, FileAccess.Read);
        //                StreamReader stmReader58 = new StreamReader(stmImport);

        //Read in each line of file and assign to appropriate text box

        //              this.textDepthLayer1.Text = stmReader58.ReadLine();
        //              this.textKLayer1.Text = stmReader58.ReadLine();
        //              this.textDepthLayer2.Text = stmReader58.ReadLine();
        //              this.textKLayer2.Text = stmReader58.ReadLine();
        //             this.textDepthLayer3.Text = stmReader58.ReadLine();
        //              this.textKLayer3.Text = stmReader58.ReadLine();
        //              this.textDepthLayer4.Text = stmReader58.ReadLine();
        //               this.textKLayer4.Text = stmReader58.ReadLine();
        //               this.textDepthLayer5.Text = stmReader58.ReadLine();
        //               this.textKLayer5.Text = stmReader58.ReadLine();

        //Clean up and close file
        //               stmImport.Flush();
        //               stmImport.Close();
        //           }



        //        }

        #endregion


        #region "INACTIVE - Soil Survey from Menu"

        //private void menuItem3_Click(object sender, System.EventArgs e)
        // {
        //     frmSoilSurvey oForm2 = new frmSoilSurvey();
        //     oForm2.MyParentForm = this;

        //            if (oForm2.ShowDialog() == DialogResult.OK)
        //    {
        //Open soil survey export file and populate hydraulic conductivity fields
        //Open file using filestream and streamreader
        //              FileStream stmImport = new FileStream("soilsurveyexport.dat", FileMode.Open, FileAccess.Read);
        //            StreamReader stmReader58 = new StreamReader(stmImport);

        //Read in each line of file and assign to appropriate text box

        //          this.textDepthLayer1.Text = stmReader58.ReadLine();
        //        this.textKLayer1.Text = stmReader58.ReadLine();
        //      this.textDepthLayer2.Text = stmReader58.ReadLine();
        //          this.textKLayer2.Text = stmReader58.ReadLine();
        //        this.textDepthLayer3.Text = stmReader58.ReadLine();
        //      this.textKLayer3.Text = stmReader58.ReadLine();
        //          this.textDepthLayer4.Text = stmReader58.ReadLine();
        //         this.textKLayer4.Text = stmReader58.ReadLine();
        //       this.textDepthLayer5.Text = stmReader58.ReadLine();
        //          this.textKLayer5.Text = stmReader58.ReadLine();

        //Clean up and close file
        //         stmImport.Flush();
        //         stmImport.Close();
        //     }
        //  }
        #endregion


        #region "INACTIVE - Soil Survey Button"

        //Below code replaced with passing method 2-20-07
        //---private void button1_Click(object sender, System.EventArgs e)
        //---{
        // Open the Soil Survey Utility Form

        //---frmSoilSurvey frm = new frmSoilSurvey();

        //---frm.ShowDialog(this);

        //---frm.Dispose();
        //---	}

        //---	private void menuItem3_Click(object sender, System.EventArgs e)
        //---{
        // Open the Soil Survey Utility Form

        //---	frmSoilSurvey frm = new frmSoilSurvey();

        //---	frm.ShowDialog(this);

        //---		frm.Dispose();
        //---	}


        #endregion


        #region "INACTIVE - Import Soil Survey File"

        //        private void buttonImport_Click(object sender, System.EventArgs e)
        //        {

        //            
        //            frmSoilSurvey oForm2 = new frmSoilSurvey();
        //            oForm2.MyParentForm = this;

        //            if (oForm2.ShowDialog() == DialogResult.OK)
        //            {
        //Open soil survey export file and populate hydraulic conductivity fields
        //Open file using filestream and streamreader
        //                FileStream stmImport = new FileStream("soilsurveyexport.dat", FileMode.Open, FileAccess.Read);
        //                StreamReader stmReader58 = new StreamReader(stmImport);

        //Read in each line of file and assign to appropriate text box

        //                this.textDepthLayer1.Text = stmReader58.ReadLine();
        //                this.textKLayer1.Text = stmReader58.ReadLine();
        //                this.textDepthLayer2.Text = stmReader58.ReadLine();
        //                this.textKLayer2.Text = stmReader58.ReadLine();
        //                this.textDepthLayer3.Text = stmReader58.ReadLine();
        //                this.textKLayer3.Text = stmReader58.ReadLine();
        //                this.textDepthLayer4.Text = stmReader58.ReadLine();
        //                this.textKLayer4.Text = stmReader58.ReadLine();
        //                this.textDepthLayer5.Text = stmReader58.ReadLine();
        //                this.textKLayer5.Text = stmReader58.ReadLine();

        //Clean up and close file
        //                stmImport.Flush();
        //                stmImport.Close();
        //            }
        //        }

        #endregion

        #endregion


        #region "MAIN PROGRAM - Lateral Effect Solution Code"


        private void btnDitchCalculate_Click(object sender, System.EventArgs e)
        {

            //Set startup directory
            Directory.SetCurrentDirectory(Application.StartupPath);



            #region "Create Required Files"

            //depths.dat
            using (System.IO.FileStream fs101 = System.IO.File.Create("depths.dat", 1024))

                //Clean up and close file
                fs101.Flush();
            //fs101.Close();

            //bousoutput.dat
            using (System.IO.FileStream fs102 = System.IO.File.Create("bousoutput.dat", 1024))

                //Clean up and close file
                fs102.Flush();
            //fs102.Close();

            //boust25.dat
            using (System.IO.FileStream fs103 = System.IO.File.Create("boust25.dat", 1024))

                //Clean up and close file
                fs103.Flush();
            //fs103.Close();

            //bousinput.dat
            using (System.IO.FileStream fs104 = System.IO.File.Create("bousinput.dat", 1024))

                //Clean up and close file
                fs104.Flush();
            //fs104.Close();


            #endregion



            #region "Main block of error checking"

            //**************************************************************
            //  Check for State
            //**************************************************************

            //If T25 Override in Effect, these values become optional
            if (checkBoxOverride.Checked == false)
            {

                if (comboState.Text == "Choose State")
                {
                    MessageBox.Show("Choose State from Dropdown Box", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //**************************************************************
            //  Check for County
            //**************************************************************

            //If T25 Override in Effect, these values become optional
            if (checkBoxOverride.Checked == false)
            {

                if (comboCounty.Text == "Choose County")
                {
                    MessageBox.Show("Choose County from Dropdown Box", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            //**************************************************************
            // Check to make sure Hydroperiod radio checked
            //**************************************************************

            //Check to make sure a radio option choosen
            if (checkBoxOverride.Checked == false)
            {
                if (radioPercent.Checked == false)
                {
                    if (radio14Days.Checked == false)
                    {

                        MessageBox.Show("Choose Hydroperiod Option", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;


                    }

                }
            }

            //**************************************************************
            //  Check Hydroperiod - Right now can only be 5% or 14 days
            //**************************************************************
            string sHydroperiod = this.textHydroperiod.Text;

            //In case has issues converting empty string to double
            if (sHydroperiod == "")
            {
                sHydroperiod = "-999";
            }

            double dHydroperiod = Convert.ToDouble(sHydroperiod);

            //If T25 Override in Effect, these values become optional
            if (checkBoxOverride.Checked == false)
            {

                if (radioPercent.Checked == true)
                {

                    if (dHydroperiod < 5)
                    {
                        MessageBox.Show("UNDER CONSTRUCTION: Currently, T25 values have only been calculate for a hydroperiod of 5%\n\n Please enter 5 for percent hydroperiod", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (dHydroperiod > 5)
                    {
                        MessageBox.Show("UNDER CONSTRUCTION: Currently, T25 values have only been calculate for a hydroperiod of 5%\n\n Please enter 5 for percent hydroperiod", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dHydroperiod == 5)
                    {
                        sHydroperiod = "5percent";
                    }
                }


                if (radio14Days.Checked == true)
                {
                    if (checkBoxOverride.Checked == false)
                    {
                        MessageBox.Show("UNDER CONSTRUCTION: Currently, you must enter your own T25 value to use the 14 day option", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }


            //**************************************************************
            // Check T25 Override
            //**************************************************************

            string sT25Override = this.textT25Override.Text;

            //In case has issues converting empty string to double
            if (sT25Override == "")
            {
                sT25Override = "-999";
            }

            double dT25Override = Convert.ToDouble(sT25Override);


            if (checkBoxOverride.Checked == true)
            {
                if (dT25Override <= 0)
                {
                    MessageBox.Show("Your T25 value must be greater than 0", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (checkBoxOverride.Checked == false)
            {
                sT25Override = "";
                dT25Override = -999;
            }


            //**************************************************************
            // Check Ditch Depth
            //**************************************************************
            string sDitchDepth = this.textDitchDepth.Text;
            double dDitchDepth = 0;

            //???????????????????????????????????????????????
            //DEBUG ADD METRIC OPTIONS


            if (sDitchDepth != "")
            {
                dDitchDepth = Convert.ToDouble(textDitchDepth.Text);
            }

            if (dDitchDepth < 2 && dDitchDepth != 1)
            {
                MessageBox.Show("Ditch Depth / Water in Pit Depth must be either 1 or from 2 to 6 ft (0.3m or from 0.6 to 1.8m)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dDitchDepth > 6)
            {
                MessageBox.Show("Ditch Depth / Water in Pit Depth must be either 1 or from 2 to 6 ft (0.3m or from 0.6 to 1.8m)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //**************************************************************
            //  Depth to Restrictive Layer - Some Handled with Lat K error checking
            //**************************************************************
            //Message Box to pop up if restrictive layer depth negative
            //As of 2-17-07 negative values cannot be entered

            string sImpermeable1 = this.textDitchImpermeable.Text;
            double dImpermeable = 0;

            //???????????????????????????????????????????????
            //DEBUG ADD METRIC OPTIONS

            if (sImpermeable1 != "")
            {
                dImpermeable = Convert.ToDouble(textDitchImpermeable.Text);
            }

            if (dImpermeable < 0)
            {
                MessageBox.Show("Depth to Restrictive Layer Must Be Greater Than 0", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dImpermeable < dDitchDepth)
            {
                MessageBox.Show("Depth to Restrictive Layer Cannot Be Shallower Than Ditch Depth / Depth To Water In Pit", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //**************************************************************
            //  Drainable Porosity
            //**************************************************************

            //Message Box to pop up if drainable porosity negative or >1
            //As of 2-17-07 negative values cannot be entered

            string sPorosity1 = this.textDitchPorosity.Text;
            double dPorosity = 0;

            if (sPorosity1 != "")
            {
                dPorosity = Convert.ToDouble(textDitchPorosity.Text);
            }


            if (dPorosity == 0)
            {
                MessageBox.Show("Drainable Porosity Must Be Greater Than 0. \n\n Please read the Help manual if you are unfamiliar with this term.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dPorosity > 1)
            {
                MessageBox.Show("Drainable Porosity Must Be Less Than 1. \n\n Please read the Help manual if you are unfamiliar with this term.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //**************************************************************
            // Check for Surface Storage
            //**************************************************************

            //If T25 Override in Effect, these values become optional
            if (checkBoxOverride.Checked == false)
            {
                if (comboStorage.Text == "")
                {
                    MessageBox.Show("Please choose either 1 or 2 inches (2.5 or 5cm) for surface depressional storage value.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            //**************************************************************
            // Check to make sure Lateral Conductivities radio checked
            //**************************************************************

            //Check to make sure a radio option choosen
            if (radioUserLat.Checked == false)
            {
                if (radioSSLat.Checked == false)
                {

                    MessageBox.Show("Choose Conductivity Option", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


                }

            }

            //************************************************************************
            // Check to make sure Lateral Conductivities Values of Layer 1 are entered
            //************************************************************************


            //If user inputing K then apply this check
            if (radioUserLat.Checked == true)
            {

                if (textDepthLayer1.Text == "")
                {
                    MessageBox.Show("In the Lateral Conductivity Section, \n\n Enter Depth to Bottom of Soil Layer 1", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textDepthLayer1.Text == "0")
                {
                    MessageBox.Show("In the Lateral Conductivity Section, \n\n Enter Depth to Bottom of Soil Layer 1", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textDepthLayer1.Text == "00")
                {
                    MessageBox.Show("In the Lateral Conductivity Section, \n\n Enter Depth to Bottom of Soil Layer 1", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textKLayer1.Text == "")
                {
                    MessageBox.Show("In the Lateral Conductivity Section, \n\n Enter Conductivity of Soil Layer 1", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textKLayer1.Text == "0")
                {
                    MessageBox.Show("In the Lateral Conductivity Section, \n\n Enter Conductivity of Soil Layer 1", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textKLayer1.Text == "00")
                {
                    MessageBox.Show("In the Lateral Conductivity Section, \n\n Enter Conductivity of Soil Layer 1", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }



            //**************************************************************
            // Soil Survey Conductivity - If True
            //**************************************************************



            //if (radioSSLat.Checked == true)
            //{

            //    if (dLayer1High > 0 & dLayer1High < dLayer1Low)
            //    {
            //        MessageBox.Show("High Value for  Permeabilty Range of Layer 1 must be greater the Low Value", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    if (dLayer2High > 0 & dLayer2High < dLayer2Low)
            //    {
            //        MessageBox.Show("High Value for  Permeabilty Range of Layer 2 must be greater the Low Value", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (dLayer3High > 0 & dLayer3High < dLayer3Low)
            //    {
            //        MessageBox.Show("High Value for  Permeabilty Range of Layer 3 must be greater the Low Value", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (dLayer4High > 0 & dLayer4High < dLayer4Low)
            //    {
            //        MessageBox.Show("High Value for  Permeabilty Range of Layer 4 must be greater the Low Value", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (dLayer5High > 0 & dLayer5High < dLayer5Low)
            //    {
            //        MessageBox.Show("High Value for  Permeabilty Range of Layer 5 must be greater the Low Value", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (dLayer6High > 0 & dLayer6High < dLayer6Low)
            //    {
            //        MessageBox.Show("High Value for  Permeabilty Range of Layer 6 must be greater the Low Value", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (dLayer7High > 0 & dLayer7High < dLayer7Low)
            //    {
            //        MessageBox.Show("High Value for  Permeabilty Range of Layer 7 must be greater the Low Value", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (dLayer8High > 0 & dLayer8High < dLayer8Low)
            //    {
            //        MessageBox.Show("High Value for  Permeabilty Range of Layer 8 must be greater the Low Value", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }


            //Check to make sure a radio option choosen
            if (radioExportLow.Checked == false)
            {
                if (radioExportHigh.Checked == false)
                {
                    if (radioExportAverage.Checked == false)
                    {
                        MessageBox.Show("Choose Low, High, or Average K Option", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

            }



            #region "Depracated - Now Soil Survey Cells are Read Only"

            //*********************************************************
            //If only one value listed in Soil Survey, user will input into low column
            //Need to populate to high column with same value in case they choose high
            //export option

            //if (textLayer1High.Text == "0" & dLayer1Low > 0)
            //{

            //    textLayer1High.Text = textLayer1Low.Text;
            //}
            //if (textLayer2High.Text == "0" & dLayer2Low > 0)
            //{

            //    textLayer2High.Text = textLayer2Low.Text;
            //}
            //if (textLayer3High.Text == "0" & dLayer3Low > 0)
            //{

            //    textLayer3High.Text = textLayer3Low.Text;
            //}
            //if (textLayer4High.Text == "0" & dLayer4Low > 0)
            //{

            //    textLayer4High.Text = textLayer4Low.Text;
            //}
            //if (textLayer5High.Text == "0" & dLayer5Low > 0)
            //{

            //    textLayer5High.Text = textLayer5Low.Text;
            //}

            ////Put zeros in empty numeric fields

            //if (textLayer1Bottom.Text == "")
            //{
            //    textLayer1Bottom.Text = "0";
            //}
            //if (textLayer1Low.Text == "")
            //{
            //    textLayer1Low.Text = "0";
            //}
            //if (textLayer1High.Text == "")
            //{
            //    textLayer1High.Text = "0";
            //}



            //if (textLayer2Bottom.Text == "")
            //{
            //    textLayer2Bottom.Text = "0";
            //}
            //if (textLayer2Low.Text == "")
            //{
            //    textLayer2Low.Text = "0";
            //}
            //if (textLayer2High.Text == "")
            //{
            //    textLayer2High.Text = "0";
            //}



            //if (textLayer3Bottom.Text == "")
            //{
            //    textLayer3Bottom.Text = "0";
            //}
            //if (textLayer3Low.Text == "")
            //{
            //    textLayer3Low.Text = "0";
            //}
            //if (textLayer3High.Text == "")
            //{
            //    textLayer3High.Text = "0";
            //}



            //if (textLayer4Bottom.Text == "")
            //{
            //    textLayer4Bottom.Text = "0";
            //}
            //if (textLayer4Low.Text == "")
            //{
            //    textLayer4Low.Text = "0";
            //}
            //if (textLayer4High.Text == "")
            //{
            //    textLayer4High.Text = "0";
            //}



            //if (textLayer5Bottom.Text == "")
            //{
            //    textLayer5Bottom.Text = "0";
            //}
            //if (textLayer5Low.Text == "")
            //{
            //    textLayer5Low.Text = "0";
            //}
            //if (textLayer5High.Text == "")
            //{
            //    textLayer5High.Text = "0";
            //}

            //if (textLayer1Average.Text == "")
            //{
            //    textLayer1Average.Text = "0";
            //}
            //if (textLayer2Average.Text == "")
            //{
            //    textLayer2Average.Text = "0";
            //}
            //if (textLayer3Average.Text == "")
            //{
            //    textLayer3Average.Text = "0";
            //}
            //if (textLayer4Average.Text == "")
            //{
            //    textLayer4Average.Text = "0";
            //}
            //if (textLayer5Average.Text == "")
            //{
            //    textLayer5Average.Text = "0";
            //}

            #endregion


            //}


            #endregion



            #region "Conductivity , Restrictive layer/Layer depth checking in denominator section"

            #region "Declare Variable - User Entered K"
            //*************************************************
            //Conductivity
            //*************************************************



            //Declare some variables

            //string sKDirect;
            double dDepthLayer1;
            double dKLayer1;
            double dDepthLayer2;
            double dKLayer2;
            double dDepthLayer3;
            double dKLayer3;
            double dDepthLayer4;
            double dKLayer4;
            double dDepthLayer5;
            double dKLayer5;
            double dDepthLayer6;
            double dKLayer6;
            double dDepthLayer7;
            double dKLayer7;
            double dDepthLayer8;
            double dKLayer8;

            double dNumerator;
            double dDenominator;

            double dLayer2;
            double dLayer3;
            double dLayer4;
            double dLayer5;
            double dLayer6;
            double dLayer7;
            double dLayer8;


            //initialize final weighted outputs
            double dKWeighted = 0;
            string sKWeighted = "0";


            //DEBUG
            //MessageBox.Show("Begin Conductivity  Put Zeros in Empty Boxes Block", "Error",
            //MessageBoxButtons.OK, MessageBoxIcon.Error);


            //Put zeros in empty fields
            if (this.textDepthLayer2.Text == "")
            {
                this.textDepthLayer2.Text = "0";
            }
            if (this.textDepthLayer3.Text == "")
            {
                this.textDepthLayer3.Text = "0";
            }
            if (this.textDepthLayer4.Text == "")
            {
                this.textDepthLayer4.Text = "0";
            }
            if (this.textDepthLayer5.Text == "")
            {
                this.textDepthLayer5.Text = "0";

            }

            if (this.textDepthLayer6.Text == "")
            {
                this.textDepthLayer6.Text = "0";

            }

            if (this.textDepthLayer7.Text == "")
            {
                this.textDepthLayer7.Text = "0";

            }

            if (this.textDepthLayer8.Text == "")
            {
                this.textDepthLayer8.Text = "0";
            }
            if (this.textKLayer2.Text == "")
            {
                this.textKLayer2.Text = "0";
            }
            if (this.textKLayer3.Text == "")
            {
                this.textKLayer3.Text = "0";
            }
            if (this.textKLayer4.Text == "")
            {
                this.textKLayer4.Text = "0";
            }
            if (this.textKLayer5.Text == "")
            {
                this.textKLayer5.Text = "0";
            }
            if (this.textKLayer6.Text == "")
            {
                this.textKLayer6.Text = "0";
            }
            if (this.textKLayer7.Text == "")
            {
                this.textKLayer7.Text = "0";
            }
            if (this.textKLayer8.Text == "")
            {
                this.textKLayer8.Text = "0";
            }


                        //Convert strings to doubles
                        dDepthLayer1 = Convert.ToDouble(textDepthLayer1.Text);
                        dKLayer1 = Convert.ToDouble(textKLayer1.Text);
                        dDepthLayer2 = Convert.ToDouble(textDepthLayer2.Text);
                        dKLayer2 = Convert.ToDouble(textKLayer2.Text);
                        dDepthLayer3 = Convert.ToDouble(textDepthLayer3.Text);
                        dKLayer3 = Convert.ToDouble(textKLayer3.Text);
                        dDepthLayer4 = Convert.ToDouble(textDepthLayer4.Text);
                        dKLayer4 = Convert.ToDouble(textKLayer4.Text);
                        dDepthLayer5 = Convert.ToDouble(textDepthLayer5.Text);
                        dKLayer5 = Convert.ToDouble(textKLayer5.Text);
                        dDepthLayer6 = Convert.ToDouble(textDepthLayer6.Text);
                        dKLayer6 = Convert.ToDouble(textKLayer6.Text);
                        dDepthLayer7 = Convert.ToDouble(textDepthLayer7.Text);
                        dKLayer7 = Convert.ToDouble(textKLayer7.Text);
                        dDepthLayer8 = Convert.ToDouble(textDepthLayer8.Text);
                        dKLayer8 = Convert.ToDouble(textKLayer8.Text);


                        //DEBUG
                        //MessageBox.Show("End Conductivity  Put Zeros in Empty Boxes Block", "Error",
                        //MessageBoxButtons.OK, MessageBoxIcon.Error);

            #endregion


                        #region "Declare Variable - Soil Survey K"

                        //DEBUG
                        //Find error with braces
                       // MessageBox.Show("Begin Conductivity Declare Variables Block", "Error",
                         //MessageBoxButtons.OK, MessageBoxIcon.Error);

                        double dLayer1Bottom = Convert.ToDouble(this.textLayer1Bottom.Text);
                        double dLayer2Bottom = Convert.ToDouble(this.textLayer2Bottom.Text);
                        double dLayer3Bottom = Convert.ToDouble(this.textLayer3Bottom.Text);
                        double dLayer4Bottom = Convert.ToDouble(this.textLayer4Bottom.Text);
                        double dLayer5Bottom = Convert.ToDouble(this.textLayer5Bottom.Text);
                        double dLayer6Bottom = Convert.ToDouble(this.textLayer6Bottom.Text);
                        double dLayer7Bottom = Convert.ToDouble(this.textLayer7Bottom.Text);
                        double dLayer8Bottom = Convert.ToDouble(this.textLayer8Bottom.Text);

                        double dLayer1Low = Convert.ToDouble(this.textLayer1Low.Text);
                        double dLayer2Low = Convert.ToDouble(this.textLayer2Low.Text);
                        double dLayer3Low = Convert.ToDouble(this.textLayer3Low.Text);
                        double dLayer4Low = Convert.ToDouble(this.textLayer4Low.Text);
                        double dLayer5Low = Convert.ToDouble(this.textLayer5Low.Text);
                        double dLayer6Low = Convert.ToDouble(this.textLayer6Low.Text);
                        double dLayer7Low = Convert.ToDouble(this.textLayer7Low.Text);
                        double dLayer8Low = Convert.ToDouble(this.textLayer8Low.Text);

                        double dLayer1High = Convert.ToDouble(this.textLayer1High.Text);
                        double dLayer2High = Convert.ToDouble(this.textLayer2High.Text);
                        double dLayer3High = Convert.ToDouble(this.textLayer3High.Text);
                        double dLayer4High = Convert.ToDouble(this.textLayer4High.Text);
                        double dLayer5High = Convert.ToDouble(this.textLayer5High.Text);
                        double dLayer6High = Convert.ToDouble(this.textLayer6High.Text);
                        double dLayer7High = Convert.ToDouble(this.textLayer7High.Text);
                        double dLayer8High = Convert.ToDouble(this.textLayer8High.Text);

                        double dLayer1Average = Convert.ToDouble(this.textLayer1Average.Text);
                        double dLayer2Average = Convert.ToDouble(this.textLayer2Average.Text);
                        double dLayer3Average = Convert.ToDouble(this.textLayer3Average.Text);
                        double dLayer4Average = Convert.ToDouble(this.textLayer4Average.Text);
                        double dLayer5Average = Convert.ToDouble(this.textLayer5Average.Text);
                        double dLayer6Average = Convert.ToDouble(this.textLayer6Average.Text);
                        double dLayer7Average = Convert.ToDouble(this.textLayer7Average.Text);
                        double dLayer8Average = Convert.ToDouble(this.textLayer8Average.Text);


                        #endregion


                        #region "User Entered Conductivity"
                        //if USER input chossen

                        //Find error with braces
                       // MessageBox.Show("Begin User Entered Conductivity Block", "Error",
                         //MessageBoxButtons.OK, MessageBoxIcon.Error);



                        if (radioUserLat.Checked == true)
                        {

                            //Make sure depths are OK, i.e. depth of layer 1 cannot exceed layer 2 depth
                            if (dDepthLayer2 > 0.00 && dDepthLayer2 < dDepthLayer1)
                            {
                                MessageBox.Show("Layer 2 must be deeper than Layer 1", "Layer Depth Issue",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (dDepthLayer3 > 0.00 && dDepthLayer3 < dDepthLayer2)
                            {
                                MessageBox.Show("Layer 3 must be deeper than Layer 2", "Layer Depth Issue",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (dDepthLayer4 > 0.00 && dDepthLayer4 < dDepthLayer3)
                            {
                                MessageBox.Show("Layer 4 must be deeper than Layer 3", "Layer Depth Issue",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (dDepthLayer5 > 0.00 && dDepthLayer5 < dDepthLayer4)
                            {
                                MessageBox.Show("Layer 5 must be deeper than Layer 4", "Layer Depth Issue",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (dDepthLayer6 > 0.00 && dDepthLayer6 < dDepthLayer5)
                            {
                                MessageBox.Show("Layer 6 must be deeper than Layer 5", "Layer Depth Issue",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (dDepthLayer7 > 0.00 && dDepthLayer7 < dDepthLayer6)
                            {
                                MessageBox.Show("Layer 7 must be deeper than Layer 6", "Layer Depth Issue",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (dDepthLayer8 > 0.00 && dDepthLayer8 < dDepthLayer7)
                            {
                                MessageBox.Show("Layer 8 must be deeper than Layer 7", "Layer Depth Issue",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }


                            //Calculate weighted K


                            //Calculate Numerator
                            dNumerator = (dDepthLayer1 * dKLayer1) + ((dDepthLayer2 - dDepthLayer1) * dKLayer2) + ((dDepthLayer3 - dDepthLayer2) * dKLayer3) + ((dDepthLayer4 - dDepthLayer3) * dKLayer4) + ((dDepthLayer5 - dDepthLayer4) * dKLayer5) + ((dDepthLayer6 - dDepthLayer5) * dKLayer6) + ((dDepthLayer7 - dDepthLayer6) * dKLayer7) + ((dDepthLayer8 - dDepthLayer7) * dKLayer8);

                            //Calculate Denominator

                            if (dDepthLayer2 == 0)
                            {
                                dDenominator = dDepthLayer1;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 1 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 1 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }



                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");

                            }
                            else if (dDepthLayer3 == 0)
                            {
                                dLayer2 = dDepthLayer2 - dDepthLayer1;

                                dDenominator = dDepthLayer1 + dLayer2;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 2 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 2 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }
                            else if (dDepthLayer4 == 0)
                            {
                                dLayer2 = dDepthLayer2 - dDepthLayer1;
                                dLayer3 = dDepthLayer3 - dDepthLayer2;


                                dDenominator = dDepthLayer1 + dLayer2 + dLayer3;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 3 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 3 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }
                            else if (dDepthLayer5 == 0)
                            {
                                dLayer2 = dDepthLayer2 - dDepthLayer1;
                                dLayer3 = dDepthLayer3 - dDepthLayer2;
                                dLayer4 = dDepthLayer4 - dDepthLayer3;


                                dDenominator = dDepthLayer1 + dLayer2 + dLayer3 + dLayer4;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 4 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 4 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }


                            else if (dDepthLayer6 == 0)
                            {
                                dLayer2 = dDepthLayer2 - dDepthLayer1;
                                dLayer3 = dDepthLayer3 - dDepthLayer2;
                                dLayer4 = dDepthLayer4 - dDepthLayer3;
                                dLayer5 = dDepthLayer5 - dDepthLayer4;

                                dDenominator = dDepthLayer1 + dLayer2 + dLayer3 + dLayer4 + dLayer5;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }

                            else if (dDepthLayer7 == 0)
                            {
                                dLayer2 = dDepthLayer2 - dDepthLayer1;
                                dLayer3 = dDepthLayer3 - dDepthLayer2;
                                dLayer4 = dDepthLayer4 - dDepthLayer3;
                                dLayer5 = dDepthLayer5 - dDepthLayer4;
                                dLayer6 = dDepthLayer6 - dDepthLayer5;


                                dDenominator = dDepthLayer1 + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 6 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 6 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }

                            else if (dDepthLayer8 == 0)
                            {
                                dLayer2 = dDepthLayer2 - dDepthLayer1;
                                dLayer3 = dDepthLayer3 - dDepthLayer2;
                                dLayer4 = dDepthLayer4 - dDepthLayer3;
                                dLayer5 = dDepthLayer5 - dDepthLayer4;
                                dLayer6 = dDepthLayer6 - dDepthLayer5;
                                dLayer7 = dDepthLayer7 - dDepthLayer6;


                                dDenominator = dDepthLayer1 + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6 + dLayer7;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 7 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 7 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }


                            else if (dDepthLayer8 > 0)
                            {
                                dLayer2 = dDepthLayer2 - dDepthLayer1;
                                dLayer3 = dDepthLayer3 - dDepthLayer2;
                                dLayer4 = dDepthLayer4 - dDepthLayer3;
                                dLayer5 = dDepthLayer5 - dDepthLayer4;
                                dLayer6 = dDepthLayer6 - dDepthLayer5;
                                dLayer7 = dDepthLayer7 - dDepthLayer6;
                                dLayer8 = dDepthLayer8 - dDepthLayer7;

                                dDenominator = dDepthLayer1 + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6 + dLayer7 + dLayer8;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");

                            }
                        }



                        #endregion


                        #region "Soils Survey Option"

                        //Find error with braces
                        //MessageBox.Show("Begin Soil Survey Conductivity Block", "Error",
                         //MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //**************************************************
                        //Use Low End Values
                        //**************************************************

                        if (radioSSLat.Checked == true && radioExportLow.Checked == true)
                        {


                            //Calculate weighted K

                            //Calculate Numerator
                            dNumerator = (dLayer1Bottom * dLayer1Low) + ((dLayer2Bottom - dLayer1Bottom) * dLayer2Low) + ((dLayer3Bottom - dLayer2Bottom) * dLayer3Low) + ((dLayer4Bottom - dLayer3Bottom) * dLayer4Low) + ((dLayer5Bottom - dLayer4Bottom) * dLayer5Low) + ((dLayer6Bottom - dLayer5Bottom) * dLayer6Low) + ((dLayer7Bottom - dLayer6Bottom) * dLayer7Low) + ((dLayer8Bottom - dLayer7Bottom) * dLayer8Low);

                            //Calculate Denominator

                            if (dLayer2Bottom == 0)
                            {
                                dDenominator = dLayer1Bottom;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 1 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 1 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }



                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");

                            }
                            else if (dLayer3Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;

                                dDenominator = dLayer1Bottom + dLayer2;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 2 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 2 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }
                            else if (dLayer4Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 3 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 3 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }
                            else if (dLayer5Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 4 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 4 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }


                            else if (dLayer6Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;

                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }

                            else if (dLayer7Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 6 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 6 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }

                            else if (dLayer8Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;
                                dLayer7 = dLayer7Bottom - dLayer6Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6 + dLayer7;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 7 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 7 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }


                            else if (dLayer8Bottom > 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;
                                dLayer7 = dLayer7Bottom - dLayer6Bottom;
                                dLayer8 = dLayer8Bottom - dLayer7Bottom;

                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6 + dLayer7 + dLayer8;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");

                            }
                        }//end if

                        //**************************************************
                        //Use High End Values
                        //**************************************************

                        if (radioSSLat.Checked == true && radioExportHigh.Checked == true)
                        {


                            //Calculate weighted K

                            //Calculate Numerator
                            dNumerator = (dLayer1Bottom * dLayer1High) + ((dLayer2Bottom - dLayer1Bottom) * dLayer2High) + ((dLayer3Bottom - dLayer2Bottom) * dLayer3High) + ((dLayer4Bottom - dLayer3Bottom) * dLayer4High) + ((dLayer5Bottom - dLayer4Bottom) * dLayer5High) + ((dLayer6Bottom - dLayer5Bottom) * dLayer6High) + ((dLayer7Bottom - dLayer6Bottom) * dLayer7High) + ((dLayer8Bottom - dLayer7Bottom) * dLayer8High);

                            //Calculate Denominator

                            if (dLayer2Bottom == 0)
                            {
                                dDenominator = dLayer1Bottom;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 1 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 1 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }



                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");

                            }
                            else if (dLayer3Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;

                                dDenominator = dLayer1Bottom + dLayer2;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 2 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 2 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }
                            else if (dLayer4Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 3 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 3 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }
                            else if (dLayer5Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 4 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 4 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }


                            else if (dLayer6Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;

                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }

                            else if (dLayer7Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 6 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 6 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }

                            else if (dLayer8Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;
                                dLayer7 = dLayer7Bottom - dLayer6Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6 + dLayer7;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 7 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 7 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }


                            else if (dLayer8Bottom > 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;
                                dLayer7 = dLayer7Bottom - dLayer6Bottom;
                                dLayer8 = dLayer8Bottom - dLayer7Bottom;

                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6 + dLayer7 + dLayer8;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");

                            }
                        }//end if




                        //**************************************************
                        //Use Average End Values
                        //**************************************************

                        if (radioSSLat.Checked == true && radioExportAverage.Checked == true)
                        {


                            //Calculate weighted K

                            //Calculate Numerator
                            dNumerator = (dLayer1Bottom * dLayer1Average) + ((dLayer2Bottom - dLayer1Bottom) * dLayer2Average) + ((dLayer3Bottom - dLayer2Bottom) * dLayer3Average) + ((dLayer4Bottom - dLayer3Bottom) * dLayer4Average) + ((dLayer5Bottom - dLayer4Bottom) * dLayer5Average) + ((dLayer6Bottom - dLayer5Bottom) * dLayer6Average) + ((dLayer7Bottom - dLayer6Bottom) * dLayer7Average) + ((dLayer8Bottom - dLayer7Bottom) * dLayer8Average);

                            //Calculate Denominator

                            if (dLayer2Bottom == 0)
                            {
                                dDenominator = dLayer1Bottom;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 1 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 1 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }



                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");

                            }
                            else if (dLayer3Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;

                                dDenominator = dLayer1Bottom + dLayer2;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 2 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 2 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }
                            else if (dLayer4Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 3 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 3 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }
                            else if (dLayer5Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 4 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 4 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }


                            else if (dLayer6Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;

                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }

                            else if (dLayer7Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 6 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 6 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }

                            else if (dLayer8Bottom == 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;
                                dLayer7 = dLayer7Bottom - dLayer6Bottom;


                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6 + dLayer7;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 7 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 7 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");
                            }


                            else if (dLayer8Bottom > 0)
                            {
                                dLayer2 = dLayer2Bottom - dLayer1Bottom;
                                dLayer3 = dLayer3Bottom - dLayer2Bottom;
                                dLayer4 = dLayer4Bottom - dLayer3Bottom;
                                dLayer5 = dLayer5Bottom - dLayer4Bottom;
                                dLayer6 = dLayer6Bottom - dLayer5Bottom;
                                dLayer7 = dLayer7Bottom - dLayer6Bottom;
                                dLayer8 = dLayer8Bottom - dLayer7Bottom;

                                dDenominator = dLayer1Bottom + dLayer2 + dLayer3 + dLayer4 + dLayer5 + dLayer6 + dLayer7 + dLayer8;

                                //Make sure depth to restrictive layer and bottom depth soil in
                                //agreement

                                if ((dDenominator + 1) / 12 < dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Deeper",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if ((dDenominator - 1) / 12 > dImpermeable)
                                {
                                    MessageBox.Show("Make sure Depth to Restrictive Layer and Bottom Depth of Soil Profile Layer 5 are Equal", "Restrictive Layer is Shallower",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                //Final weighted K calculation
                                dKWeighted = dNumerator / dDenominator;
                                sKWeighted = dKWeighted.ToString("f4");

                            }
                        }//end if

                        #endregion

            #endregion



                        #region "T25 Read File and Value Calculations"

                        //Find error with braces
                        //MessageBox.Show("Begin T25 Block", "Error",
                         //MessageBoxButtons.OK, MessageBoxIcon.Error);



                        //Initialize T25 value to 0. Otherwise throws c# use of unassigned local variable
                        double dt25 = 0;

                        //If override not choosen
                        if (checkBoxOverride.Checked == false)
                        {

                            //*************************************************
                            //Determine T25 Value
                            //Writes T25 value to file called T25.dat
                            //*************************************************


                            //Get State
                            string sState = this.comboState.Text;

                            //Get County
                            string sCounty = this.comboCounty.Text;

                            //Get Hydroperiod
                            //declared in main error checking block as
                            //sHydroperiod and dHydroperiod

                            //Get Ditch Depth 
                            //declared in main error checking block as
                            //sDitchDepth and dDitchDepth

                            //Get Surface Storage
                            string sStorage = this.comboStorage.Text;

                            //Initialize variables for slope intercept calculations
                            //dy is t25 value (y-axes for slope-intercept
                            //dx is ditch depth (x-axes)
                            double dy1 = 0;
                            double dy2 = 0;
                            double dy3 = 0;
                            double dy4 = 0;
                            double dy5 = 0;
                            double dy6 = 0;
                            double dx2 = 0;
                            double dx3 = 0;
                            double dx4 = 0;
                            double dx5 = 0;


                            //Determine appropriate T25 XML file based on state-county-surface storage info

                            string sStateLabel = this.comboState.Text;
                            string sCountyLabel = this.comboCounty.Text;
                            string sCountyLabelLower = sCountyLabel.ToLower();
                            //Surface Storage
                            string sStorageLabel = "0";
                            if (this.comboStorage.SelectedIndex == 0)
                            {
                                sStorageLabel = "1";
                            }
                            if (this.comboStorage.SelectedIndex == 1)
                            {
                                sStorageLabel = "2";
                            }

                            string sHydro = this.textHydroperiod.Text;
                            //Concatenate to get filename
                            string sStateCountyStorage = "data/" + sStateLabel + "_" + sStorageLabel + "inch_" + sHydroperiod + ".xml";


                            //Read in Values from file based on selections

                            //1.Set path to location of program
                            Directory.SetCurrentDirectory(Application.StartupPath);

                            //2.Open T25 XML Doc

                            string xoneft = "";
                            string xtwoft = "";
                            string xthreeft = "";
                            string xfourft = "";
                            string xfiveft = "";
                            string xsixft = "";

                            XPathDocument doc = new XPathDocument(sStateCountyStorage);
                            XPathNavigator navigator = doc.CreateNavigator();
                            navigator.MoveToChild("t25values", "");
                            navigator.MoveToChild(sCountyLabelLower, "");
                            navigator.MoveToFirstChild();
                            xoneft = navigator.Value;
                            navigator.MoveToNext();
                            xtwoft = navigator.Value;
                            navigator.MoveToNext();
                            xthreeft = navigator.Value;
                            navigator.MoveToNext();
                            xfourft = navigator.Value;
                            navigator.MoveToNext();
                            xfiveft = navigator.Value;
                            navigator.MoveToNext();
                            xsixft = navigator.Value;

                            dy1 = Convert.ToDouble(xoneft);
                            dy2 = Convert.ToDouble(xtwoft);
                            dy3 = Convert.ToDouble(xthreeft);
                            dy4 = Convert.ToDouble(xfourft);
                            dy5 = Convert.ToDouble(xfiveft);
                            dy6 = Convert.ToDouble(xsixft);





                            //3.Perform linear interpolations

                            if (dDitchDepth == 1)
                            {
                                dt25 = dy1;
                            }
                            if (dDitchDepth == 2)
                            {
                                dt25 = dy2;
                            }
                            if (dDitchDepth == 3)
                            {
                                dt25 = dy3;
                            }
                            if (dDitchDepth == 4)
                            {
                                dt25 = dy4;
                            }
                            if (dDitchDepth == 5)
                            {
                                dt25 = dy5;
                            }
                            if (dDitchDepth == 6)
                            {
                                dt25 = dy6;
                            }
                            if (dDitchDepth == 1.0)
                            {
                                dt25 = dy1;
                            }
                            if (dDitchDepth == 2.0)
                            {
                                dt25 = dy2;
                            }
                            if (dDitchDepth == 3.0)
                            {
                                dt25 = dy3;
                            }
                            if (dDitchDepth == 4.0)
                            {
                                dt25 = dy4;
                            }
                            if (dDitchDepth == 5.0)
                            {
                                dt25 = dy5;
                            }
                            if (dDitchDepth == 6.0)
                            {
                                dt25 = dy6;
                            }
                            if (dDitchDepth == 1.00)
                            {
                                dt25 = dy1;
                            }
                            if (dDitchDepth == 2.00)
                            {
                                dt25 = dy2;
                            }
                            if (dDitchDepth == 3.00)
                            {
                                dt25 = dy3;
                            }
                            if (dDitchDepth == 4.00)
                            {
                                dt25 = dy4;
                            }
                            if (dDitchDepth == 5.00)
                            {
                                dt25 = dy5;
                            }
                            if (dDitchDepth == 6.00)
                            {
                                dt25 = dy6;
                            }
                            if (dDitchDepth > 2 && dDitchDepth < 3)
                            {

                                double dSlope1 = (dy3 - dy2);
                                dt25 = dSlope1 * (dDitchDepth - 2) + dy2;

                            }
                            if (dDitchDepth > 3 && dDitchDepth < 4)
                            {

                                double dSlope1 = (dy4 - dy3);
                                dt25 = dSlope1 * (dDitchDepth - 3) + dy3;

                            }
                            if (dDitchDepth > 4 && dDitchDepth < 5)
                            {

                                double dSlope1 = (dy5 - dy4);
                                dt25 = dSlope1 * (dDitchDepth - 4) + dy4;

                            }
                            if (dDitchDepth > 5 && dDitchDepth < 6)
                            {

                                double dSlope1 = (dy6 - dy5);
                                dt25 = dSlope1 * (dDitchDepth - 5) + dy5;

                            }

                            //*************************************************
                            //End T25 Determination Subroutine
                            //*************************************************

                        }


                        //*************************************************
                        //T25 Override statement
                        //*************************************************
                        if (checkBoxOverride.Checked == true)
                        {
                            dt25 = Convert.ToDouble(this.textT25Override.Text);
                        }






                        #endregion



                        #region"Convert everything to Metric Units"

                        //Find error with braces
                       // MessageBox.Show("Begin Convert to Metric Block", "Error",
                        // MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //Effective Lat K Conductivity and Depth to Restrictive

                        //User Using Metric
                        double dLateralConductivityMetric = dKWeighted;
                        double dDepthToRestrictiveMetric = dImpermeable;
                        double dDepthOfWaterMetric = dDitchDepth;

                        //User Using English
                        if (!menuMetric.Checked)
                        {
                            dLateralConductivityMetric = dKWeighted * 2.54;
                            dDepthToRestrictiveMetric = dImpermeable * 0.3048;
                            dDepthOfWaterMetric = dDitchDepth * 0.3048;

                        }


                        #endregion


                        #region "TRY RUNNING"

                        try
                        {
                            //DEBUG
                            //Find error with braces
                            //MessageBox.Show("Begin Try Block", "Error",
                             //MessageBoxButtons.OK, MessageBoxIcon.Error);

                            #region "Determine ALEN for Boussinesq Program"

                            //*************************************************
                            //Determines ALEN based on x = Sqrt(k/f * h* t)/0.3
                            //Then set ALEN equal to 2x to make sure w.t does not 
                            //drop. Write to file spacing.dat
                            //*************************************************

                            //Convert T25 from days to hours
                            double dT25InHours = dt25 * 24;

                            //Write T25 value to boust25.dat to be read in by boussinesq program
                            using (StreamWriter sw = new StreamWriter("boust25.dat"))
                            {

                                sw.WriteLine(dT25InHours.ToString("f4"));


                                //Clean up and close file
                                sw.Flush();
                                sw.Close();
                            }


                            //Calculate x

                            double dHalfALEN;

                            dHalfALEN = (Math.Sqrt(((dLateralConductivityMetric * 0.01) / dPorosity) * dDepthToRestrictiveMetric * dT25InHours)) / .3;


                            //Multiply by 2 for ALEN value

                            double dALEN = 2 * dHalfALEN;


                            //For dALENmetric < 200m set equal to 200 m- Otherwise drawdown is too rapid and results skewes
                            if (dALEN <= 200.0)
                            {
                                dALEN = 200.0;

                            }

                            //*************************************************
                            //End ALEN determination subroutine
                            //*************************************************



                            #endregion



                            #region "Linear Interpolation Using Boussinesq"

                            //*************************************************
                            //Run Extended Array Boussinesq application
                            //*************************************************

                            #region "Some Inputs"

                            //Set elevation of ditch bottom
                            double dDitchBottomElevationMetric = dDepthToRestrictiveMetric - dDepthOfWaterMetric;

                            //Set elevation of gw that is 25cm below gound surface
                            double dGroundWaterElevationMetric = dDepthToRestrictiveMetric - 0.25;

                            //Set node spacing such that nodes extend to ALEN

                            //Up to ALEN = 200m, resolution will be 0.2m. Thus nodes are spaced at 0.2
                            //After ALEN = 200m, number of nodes equals 1000. Thus nodes are spaced at
                            // ALEN/1000

                            double dNodeSpacing = 0.2;
                            double dNumberNodes = 1000;

                            //For ALEN > 200m
                            if (dALEN > 200.0)
                            {
                                dNodeSpacing = dALEN / 1000;

                            }


                            //Set time step, rain, slope, convergence and print parameters

                            //Time step has to be changed based on larger T25 Values
                            //Conditions:   T25<240 then use 1 hour
                            //              T25>240 but <500 use 2 hour
                            //              T25 >500 but <750 use 3 hour
                            //              T25 >750 but <1000 use 4 hour
                            //              T25 >1000 use 5 hour  

                            double dTimeStepCalc = 1;

                            if (dT25InHours < 250.000)
                            {

                                dTimeStepCalc = 1;

                            }//end if


                            if (dT25InHours > 250.000 && dT25InHours < 500.000)
                            {

                                dTimeStepCalc = 2;

                            }//end if


                            if (dT25InHours > 500.000 && dT25InHours < 750.000)
                            {

                                dTimeStepCalc = 3;

                            }//end if

                            if (dT25InHours > 750.000 && dT25InHours < 1000.000)
                            {

                                dTimeStepCalc = 4;

                            }//end if

                            if (dT25InHours > 1000.000 && dT25InHours < 1250.000)
                            {

                                dTimeStepCalc = 5;

                            }//end if

                            if (dT25InHours > 1250.000 && dT25InHours < 1500.000)
                            {

                                dTimeStepCalc = 6;

                            }//end if

                            if (dT25InHours > 1500.000)
                            {

                                dTimeStepCalc = 7;

                            }//end if



                            double dRainfallRate = 0;
                            double dRainfallStartTime = 0;
                            double dRainfallEndTime = 1000;

                            double dSlope = 0;

                            double dPrintIncrement = 10;

                            //Set ENDH to less than 0 to assumes no flow at midpoint boundary
                            double dENDH = -2.0;

                            //Set time stop to T25 time plus 24 hours
                            double dTimeStop = dT25InHours + 24;



                            #endregion


                            #region "Declare linear interpolation variables"
                            //Declare elevation variables from depths.dat output data for linear interpolation

                            double dD1;
                            string sD1;
                            double dD2;
                            string sD2;


                            //Declare nodes from depths.dat output to inperpolate
                            double dWell1;
                            string sWell1;
                            double dWell2;
                            string sWell2;



                            #endregion


                            #region "Run Program"



                            //Model General Input Format by line
                            //L(drain to midpoint), slope(0), elevation drain bottom, midpoint level (set at -2)
                            //K, f
                            //well to well distance, time step, numer of increments, time stop
                            //ground elevation ditch , ground elevation midpoint, rainfall(0)
                            //rainfall start time (0), rainfall end time (1000)
                            //convergence criteria(.00001)
                            //Print out time increment(10)


                            //Below writes input data for extended array version of Boussinesq Program
                            using (StreamWriter sw = new StreamWriter("bousinput.dat"))
                            {

                                sw.WriteLine(dALEN);
                                sw.WriteLine(dSlope);
                                sw.WriteLine(dDitchBottomElevationMetric);
                                sw.WriteLine(dENDH);
                                sw.WriteLine("0000000");
                                sw.WriteLine(dLateralConductivityMetric * 0.01);
                                sw.WriteLine(dPorosity);
                                sw.WriteLine("0000000");
                                sw.WriteLine(dNodeSpacing);
                                sw.WriteLine(dTimeStepCalc);
                                sw.WriteLine(dNumberNodes);
                                sw.WriteLine(dTimeStop);
                                sw.WriteLine("0000000");
                                sw.WriteLine(dDepthToRestrictiveMetric);
                                sw.WriteLine(dDepthToRestrictiveMetric);
                                sw.WriteLine(dRainfallRate);
                                sw.WriteLine("0000000");
                                sw.WriteLine(dRainfallStartTime);
                                sw.WriteLine(dRainfallEndTime);
                                sw.WriteLine("0000000");
                                sw.WriteLine(".00001");
                                sw.WriteLine(dPrintIncrement);



                            }




                            //Below runs program - must be in same directory as this program
                            {
                                System.Diagnostics.ProcessStartInfo psi =
                                    new System.Diagnostics.ProcessStartInfo("CMD.exe", "/C boussinesq");
                                psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                                System.Diagnostics.Process Sloped2;
                                Sloped2 = System.Diagnostics.Process.Start(psi);
                                Sloped2.WaitForExit();//Waits for program to exit before continuing
                            }




                            #endregion


                            #region "Linear interpolation sequence and Print Final Solution"


                            //Read in elevation data from each well at T25 time and convert to double

                            //Variables declared above

                            //Open file using filestream and streamreader
                            FileStream stmDepth = new FileStream("depths.dat", FileMode.Open, FileAccess.Read);
                            StreamReader stmReader4 = new StreamReader(stmDepth);

                            //Read in each line of depths.dat and assign variable
                            //Depths.dat output in 4 lines: lines 1,2 are elevations; lines 3,4 are nodes.
                            //Remember node at ditch is node 1
                            sD1 = stmReader4.ReadLine();
                            sD2 = stmReader4.ReadLine();
                            sWell1 = stmReader4.ReadLine();
                            sWell2 = stmReader4.ReadLine();


                            //Clean up and close file
                            stmDepth.Flush();
                            stmDepth.Close();

                            //Convert depths.dat output from string to doubles
                            dD1 = Convert.ToDouble(sD1);
                            dD2 = Convert.ToDouble(sD2);
                            dWell1 = Convert.ToDouble(sWell1);
                            dWell2 = Convert.ToDouble(sWell2);

                            //Perform below because first node is at ditch, this way node 1 = 0 m from ditch
                            double dFirstNode = (dWell1 - 1);
                            double dSecondNode = (dWell2 - 1);



                            //Do linear interpolation do find x between nodes
                            //*******************************

                            //Step 1. Define slope of line connecting node 1 and node 2 elevation

                            double dFunctionSlope = ((dD2 - dD1) / dNodeSpacing);

                            //Step 2. We'll set y intercept to node 1 elevation, 
                            //and then determine X of T25 where X of T25 
                            //is defined as distance from first node to where water table at 25 cm.
                            //This will utilize slope intercept definition of a line where b =0

                            double dXofT25 = ((dGroundWaterElevationMetric - dD1) / dFunctionSlope);


                            //Step 3. Now we have defined distance from first node where water table is at
                            //a depth of 25 cm at T=T25.
                            //Next we need to define distance node 1 is from ditch / pit boundry

                            double dNode1Distance = (dFirstNode * dNodeSpacing);

                            //Step 4. Add distance that node 1 is from ditch and distance X of T25 to get
                            //distance X of T25 is from ditch

                            double dLateralEffect = dNode1Distance + dXofT25;

                            //Possible Step 5. Convert the lateral effect from meters to feet

                            if (!menuMetric.Checked)
                            {
                                dLateralEffect = dLateralEffect / 0.3048;

                            }

                            //Output x to screen
                            string sLateralEffect = dLateralEffect.ToString("f1");
                            textLateralEffect.Text = sLateralEffect;




                            //Old method
                            //Step 1 - Define spacing between nodes 

                            //double dDistanceBetweenNodes = dNodalSpacing;

                            //Step 2 - Define change in wt elevation between nodes
                            //double dXInWaterTableElevation=dD2-dD1;

                            //Step 3 -Intermediate step defining {change in wt / change in spacing)
                            //double dIntermediate=dXInWaterTableElevation/dDistanceBetweenNodes;

                            //Step 4 - Define wt change from T25 depth to depth well1
                            //double dNode2MinusT25Depth=dD2-dBrute25cmDepth;

                            //Step 5 - Intermediate step defining differential spacing 
                            //double dIntermediate2=dNode2MinusT25Depth/dIntermediate;

                            //Define lateral effect and convert to feet
                            //double dBruteLateralEffect =(dSecondNode-dIntermediate2)/.3048;


                            //Output x to screen
                            //string sBruteFinalSolution=dBruteLateralEffect.ToString("f1");
                            //textLateralEffect.Text = sBruteFinalSolution;



                            #endregion


                            //*************************************************
                            //End Boussinesq routine
                            //*************************************************

                            #endregion



                            #region "Write Summary Page"
                            //*************************************************
                            //Write Summary Page
                            //*************************************************


                            string sLatKOption = "USER";
                            if (radioSSLat.Checked == true)
                            {
                                sLatKOption = "SOIL SURVEY";
                            }


                            string scheckBoxOverride = "USER";
                            if (checkBoxOverride.Checked == false)
                            {
                                scheckBoxOverride = "DEFAULT";
                            }


                            string sDaysPercent = "%";
                            string sDaysPercentValue = this.textHydroperiod.Text;
                            if (radioPercent.Checked == false)
                            {
                                sDaysPercent = "days";
                                sDaysPercentValue = "14";

                            }

                            // get the version object for this assembly
                            Version v = System.Reflection.Assembly.GetExecutingAssembly().
                             GetName().Version;

                            string sConductivityUnits = "cm/hr";
                            string sLengthUnitsSmall = "cm";
                            string sLengthUnits = "m";

                            //English
                            if (!menuMetric.Checked)
                            {
                                sConductivityUnits = "in/hr";
                                sLengthUnitsSmall = "in";
                                sLengthUnits = "ft";

                            }


                            using (StreamWriter sw = new StreamWriter("outputs/Lateral_Effect_Summary.txt"))
                            {

                                sw.WriteLine("");
                                sw.WriteLine("	************************************************************************************");
                                sw.WriteLine("	Lateral Effect Program");
                                sw.WriteLine("	    Determination of Lateral Effect of Roadside Ditch or Borrow Pit");
                                sw.WriteLine("	    By Application of Skaggs Method");
                                sw.WriteLine("	Copyright 2006-2009 Brian D Phillips, R Wayne Skaggs");
                                sw.WriteLine("	North Carolina State University Dept of Biological & Agricultural Engineering");
                                sw.WriteLine("");
                                sw.WriteLine("	Version: " + v.ToString());
                                sw.WriteLine("");
                                sw.WriteLine("	************************************************************************************");
                                sw.WriteLine("");
                                sw.Write("	Project Run Date and Time: ");
                                sw.WriteLine(DateTime.Now);
                                sw.WriteLine("");
                                sw.WriteLine("	Project Information");
                                sw.WriteLine("	------------------------------------------------------------------");
                                sw.WriteLine("	Project :  " + this.textProjectName.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	User Name:  " + this.textUserName.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	Company / Agency:  " + this.textCompany.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	Department:  " + this.textDepartment.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	Project Location:  " + this.textLocation.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	Project Coordinates:  " + this.textCoordinates.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	Soil ID:  " + this.textSoilSeries.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	Notes:  " + this.textNotes.Text);
                                sw.WriteLine("");
                                sw.WriteLine("");
                                sw.WriteLine("	Site Parameters");
                                sw.WriteLine("	------------------------------------------------------------------");


                                sw.WriteLine("	------------------------------------------------------------------");
                                sw.WriteLine("	State:  " + this.comboState.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	County:  " + this.comboCounty.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	Surface Storage:  " + this.comboStorage.Text);
                                sw.WriteLine("");
                                sw.WriteLine("	Hydroperiod:  " + sDaysPercentValue + " " + sDaysPercent);
                                sw.WriteLine("");
                                sw.WriteLine("	Ditch Depth or Depth to Water Surface:  " + this.textDitchDepth.Text + " " + sLengthUnits);
                                sw.WriteLine("");
                                sw.WriteLine("	Depth to Restrictive Layer:  " + this.textDitchImpermeable.Text + " " + sLengthUnits);
                                sw.WriteLine("");
                                sw.WriteLine("	Drainable Porosity:  " + this.textDitchPorosity.Text);
                                sw.WriteLine("");
                                sw.WriteLine("  User defined T25 or Default T25:  " + scheckBoxOverride);
                                sw.WriteLine("	  T25 value:  " + dt25 + " days");
                                sw.WriteLine("");
                                sw.WriteLine("  User defined Conductivity or Soil Survey Conductivity:  " + sLatKOption);
                                sw.WriteLine("	Weighted Hydraulic Conductivity:  " + sKWeighted + " " + sConductivityUnits);
                                sw.WriteLine("");
                                if (radioUserLat.Checked == true)
                                {
                                    sw.WriteLine("	Hydraulic Conductivity Data by Layer ");
                                    sw.WriteLine("		Bottom Depth of Layer " + sLengthUnitsSmall + " Conductivity " + sConductivityUnits);
                                    sw.WriteLine("	Layer 1		  " + this.textDepthLayer1.Text + "			" + this.textKLayer1.Text);
                                    sw.WriteLine("	Layer 2		  " + this.textDepthLayer2.Text + "			" + this.textKLayer2.Text);
                                    sw.WriteLine("	Layer 3		  " + this.textDepthLayer3.Text + "			" + this.textKLayer3.Text);
                                    sw.WriteLine("	Layer 4		  " + this.textDepthLayer4.Text + "			" + this.textKLayer4.Text);
                                    sw.WriteLine("	Layer 5		  " + this.textDepthLayer5.Text + "			" + this.textKLayer5.Text);
                                    sw.WriteLine("	Layer 6		  " + this.textDepthLayer6.Text + "			" + this.textKLayer6.Text);
                                    sw.WriteLine("	Layer 7		  " + this.textDepthLayer7.Text + "			" + this.textKLayer7.Text);
                                    sw.WriteLine("	Layer 8		  " + this.textDepthLayer8.Text + "			" + this.textKLayer8.Text);
                                }
                                else
                                {
                                    sw.WriteLine("	Hydraulic Conductivity Data by Layer for Soil: " + this.comboSoilSurvey);
                                    sw.WriteLine("        Bottom Depth of Layer " + sLengthUnitsSmall + " Low Conductivity " + sConductivityUnits + " High Conductivity " + sConductivityUnits + " Average Conductivity " + sConductivityUnits);
                                    sw.WriteLine("	Layer 1\t\t" + this.textLayer1Bottom.Text + "\t\t\t\t" + this.textLayer1Low.Text + "\t\t\t\t" + this.textLayer1High.Text + "\t\t\t\t" + this.textLayer1Average.Text);
                                    sw.WriteLine("	Layer 2\t\t" + this.textLayer2Bottom.Text + "\t\t\t\t" + this.textLayer2Low.Text + "\t\t\t\t" + this.textLayer2High.Text + "\t\t\t\t" + this.textLayer2Average.Text);
                                    sw.WriteLine("	Layer 3\t\t" + this.textLayer3Bottom.Text + "\t\t\t\t" + this.textLayer3Low.Text + "\t\t\t\t" + this.textLayer3High.Text + "\t\t\t\t" + this.textLayer3Average.Text);
                                    sw.WriteLine("	Layer 4\t\t" + this.textLayer4Bottom.Text + "\t\t\t\t" + this.textLayer4Low.Text + "\t\t\t\t" + this.textLayer4High.Text + "\t\t\t\t" + this.textLayer4Average.Text);
                                    sw.WriteLine("	Layer 5\t\t" + this.textLayer5Bottom.Text + "\t\t\t\t" + this.textLayer5Low.Text + "\t\t\t\t" + this.textLayer5High.Text + "\t\t\t\t" + this.textLayer5Average.Text);
                                    sw.WriteLine("	Layer 6\t\t" + this.textLayer6Bottom.Text + "\t\t\t\t" + this.textLayer6Low.Text + "\t\t\t\t" + this.textLayer6High.Text + "\t\t\t\t" + this.textLayer6Average.Text);
                                    sw.WriteLine("	Layer 7\t\t" + this.textLayer7Bottom.Text + "\t\t\t\t" + this.textLayer7Low.Text + "\t\t\t\t" + this.textLayer7High.Text + "\t\t\t\t" + this.textLayer7Average.Text);
                                    sw.WriteLine("	Layer 8\t\t" + this.textLayer8Bottom.Text + "\t\t\t\t" + this.textLayer8Low.Text + "\t\t\t\t" + this.textLayer8High.Text + "\t\t\t\t" + this.textLayer8Average.Text);
                                }
                                sw.WriteLine("");
                                sw.WriteLine("	----------------------------------------------");
                                sw.WriteLine("	----------------------------------------------");
                                sw.WriteLine("	Lateral Effect: " + sLateralEffect + " " + sLengthUnits);
                                sw.WriteLine("	----------------------------------------------");
                                sw.WriteLine("	----------------------------------------------");
                                sw.WriteLine("");



                                //Clean up and close file
                                sw.Flush();
                                sw.Close();
                            }


                            //*************************************************
                            //*************************************************

                            #endregion



                            #region "Write Project GEN File Information at run-time"


                            using (StreamWriter sw = new StreamWriter("temp/temp_info.gen"))
                            {
                                sw.WriteLine("****************************************");
                                sw.WriteLine("***************BEGIN********************");
                                sw.WriteLine("****************************************");
                                sw.WriteLine("Project Information");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.textProjectName.Text);
                                sw.WriteLine(this.textUserName.Text);
                                sw.WriteLine(this.textCompany.Text);
                                sw.WriteLine(this.textDepartment.Text);
                                sw.WriteLine(this.textLocation.Text);
                                sw.WriteLine(this.textCoordinates.Text);
                                sw.WriteLine(this.textSoilSeries.Text);
                                sw.WriteLine(this.textNotes.Text);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("English / Metric");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.menuMetric.Checked);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("State - County - Surface Storage Index");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.comboState.SelectedIndex);
                                sw.WriteLine(this.comboCounty.SelectedIndex);
                                sw.WriteLine(this.comboStorage.SelectedIndex);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("T25 Override");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.checkBoxOverride.Checked);
                                sw.WriteLine(this.textT25Override.Text);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("Hydroperiod");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.radioPercent.Checked);
                                sw.WriteLine(this.radio14Days.Checked);
                                sw.WriteLine(this.textHydroperiod.Text);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("Ditch Depth - Restrictive - Porosity");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.textDitchDepth.Text);
                                sw.WriteLine(this.textDitchImpermeable.Text);
                                sw.WriteLine(this.textDitchPorosity.Text);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("K Option");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.radioUserLat.Checked);
                                sw.WriteLine(this.radioSSLat.Checked);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("User K Data");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.textDepthLayer1.Text);
                                sw.WriteLine(this.textDepthLayer2.Text);
                                sw.WriteLine(this.textDepthLayer3.Text);
                                sw.WriteLine(this.textDepthLayer4.Text);
                                sw.WriteLine(this.textDepthLayer5.Text);
                                sw.WriteLine(this.textDepthLayer6.Text);
                                sw.WriteLine(this.textDepthLayer7.Text);
                                sw.WriteLine(this.textDepthLayer8.Text);
                                sw.WriteLine(this.textKLayer1.Text);
                                sw.WriteLine(this.textKLayer2.Text);
                                sw.WriteLine(this.textKLayer3.Text);
                                sw.WriteLine(this.textKLayer4.Text);
                                sw.WriteLine(this.textKLayer5.Text);
                                sw.WriteLine(this.textKLayer6.Text);
                                sw.WriteLine(this.textKLayer7.Text);
                                sw.WriteLine(this.textKLayer8.Text);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("Soil Survey Soil Index");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.comboSoilSurvey.SelectedIndex);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("Soil Survey K Data");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.textLayer1Bottom.Text);
                                sw.WriteLine(this.textLayer2Bottom.Text);
                                sw.WriteLine(this.textLayer3Bottom.Text);
                                sw.WriteLine(this.textLayer4Bottom.Text);
                                sw.WriteLine(this.textLayer5Bottom.Text);
                                sw.WriteLine(this.textLayer6Bottom.Text);
                                sw.WriteLine(this.textLayer7Bottom.Text);
                                sw.WriteLine(this.textLayer8Bottom.Text);
                                sw.WriteLine(this.textLayer1Low.Text);
                                sw.WriteLine(this.textLayer2Low.Text);
                                sw.WriteLine(this.textLayer3Low.Text);
                                sw.WriteLine(this.textLayer4Low.Text);
                                sw.WriteLine(this.textLayer5Low.Text);
                                sw.WriteLine(this.textLayer6Low.Text);
                                sw.WriteLine(this.textLayer7Low.Text);
                                sw.WriteLine(this.textLayer8Low.Text);
                                sw.WriteLine(this.textLayer1High.Text);
                                sw.WriteLine(this.textLayer2High.Text);
                                sw.WriteLine(this.textLayer3High.Text);
                                sw.WriteLine(this.textLayer4High.Text);
                                sw.WriteLine(this.textLayer5High.Text);
                                sw.WriteLine(this.textLayer6High.Text);
                                sw.WriteLine(this.textLayer7High.Text);
                                sw.WriteLine(this.textLayer8High.Text);
                                sw.WriteLine(this.textLayer1Average.Text);
                                sw.WriteLine(this.textLayer2Average.Text);
                                sw.WriteLine(this.textLayer3Average.Text);
                                sw.WriteLine(this.textLayer4Average.Text);
                                sw.WriteLine(this.textLayer5Average.Text);
                                sw.WriteLine(this.textLayer6Average.Text);
                                sw.WriteLine(this.textLayer7Average.Text);
                                sw.WriteLine(this.textLayer8Average.Text);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("Soil Survey K - Low - High - Average Option");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.radioExportLow.Checked);
                                sw.WriteLine(this.radioExportHigh.Checked);
                                sw.WriteLine(this.radioExportAverage.Checked);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("Final Result");
                                sw.WriteLine("****************************************");
                                sw.WriteLine(this.textLateralEffect.Text);
                                sw.WriteLine("****************************************");
                                sw.WriteLine("****************END*********************");
                                sw.WriteLine("****************************************");

                                //Clean up and close file
                                sw.Flush();
                                sw.Close();

                            }



                            #endregion



                            #region "Clean up .dat files"


                            ////depths.dat
                            //if (File.Exists("depths.dat"))
                            //{
                            //File.Delete("depths.dat");}


                            ////bousoutput.dat
                            //if (File.Exists("bousoutput.dat"))
                            //{
                            //File.Delete("bousoutput.dat");}


                            ////bousinput.dat
                            //if (File.Exists("bousinput.dat"))
                            //{
                            //File.Delete("bousinput.dat");}


                            ////boust25.dat
                            //if (File.Exists("boust25.dat"))
                            //{
                            //File.Delete("boust25.dat");}


                            ////temp/dALENtrial.dat
                            //if (File.Exists("temp/dALENtrial.dat"))
                            //{
                            //File.Delete("temp/dALENtrial.dat");}


                            ////temp/nodenumber.dat
                            //if (File.Exists("temp/nodenumber.dat"))
                            //{
                            //File.Delete("temp/nodenumber.dat");}


                            ////temp/resulution.dat
                            //if (File.Exists("temp/resolution.dat"))
                            //{
                            //File.Delete("temp/resolution.dat");}


                            ////temp/timestepcalc.dat
                            //if (File.Exists("temp/timestepcalc.dat"))
                            //{
                            //File.Delete("temp/timestepcalc.dat");}



                            #endregion


                        }//end try


                    //*************************************************
                        //End Lateral Effect Calculation Routine
                        //*************************************************


                        #endregion


                        #region "CATCH UNHANDLED ERRORS"

                        catch (Exception ex)
                        {
                            MessageBox.Show("Whoops! An error file has been written to your outputs folder.  It is labeled \n\n"
                            + ex.Message + ".err" + "\n\n"
                            + "And has the following information:\n\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace + "\n\n"
                            + "Please email this file to brian_phillips@ncsu.edu  Thank you and my apologies for the error",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                            // get the version object for this assembly
                            Version v = System.Reflection.Assembly.GetExecutingAssembly().
                             GetName().Version;



                            using (StreamWriter swERR = new StreamWriter("outputs/" + ex.Message + ".err"))
                            {

                                swERR.WriteLine(DateTime.Now);
                                swERR.WriteLine("Message****************************************");
                                swERR.WriteLine(ex.Message);
                                swERR.WriteLine("Source****************************************");
                                swERR.WriteLine(ex.Source);
                                swERR.WriteLine("Stack Trace****************************************");
                                swERR.WriteLine(ex.StackTrace);
                                swERR.WriteLine("Assembly****************************************");
                                swERR.WriteLine(v.ToString());
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("***************BEGIN INPUTS*************");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("Project Information");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.textProjectName.Text);
                                swERR.WriteLine(this.textUserName.Text);
                                swERR.WriteLine(this.textCompany.Text);
                                swERR.WriteLine(this.textDepartment.Text);
                                swERR.WriteLine(this.textLocation.Text);
                                swERR.WriteLine(this.textCoordinates.Text);
                                swERR.WriteLine(this.textSoilSeries.Text);
                                swERR.WriteLine(this.textNotes.Text);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("State - County - Surface Storage");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.comboState.SelectedIndex);
                                swERR.WriteLine(this.comboCounty.SelectedIndex);
                                swERR.WriteLine(this.comboStorage.SelectedIndex);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("T25 Override");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.checkBoxOverride.Checked);
                                swERR.WriteLine(this.textT25Override.Text);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("Hydroperiod");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.radioPercent.Checked);
                                swERR.WriteLine(this.radio14Days.Checked);
                                swERR.WriteLine(this.textHydroperiod.Text);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("Ditch Depth - Restrictive - Porosity");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.textDitchDepth.Text);
                                swERR.WriteLine(this.textDitchImpermeable.Text);
                                swERR.WriteLine(this.textDitchPorosity.Text);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("K Option");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.radioUserLat.Checked);
                                swERR.WriteLine(this.radioSSLat.Checked);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("User K Data");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.textDepthLayer1.Text);
                                swERR.WriteLine(this.textDepthLayer2.Text);
                                swERR.WriteLine(this.textDepthLayer3.Text);
                                swERR.WriteLine(this.textDepthLayer4.Text);
                                swERR.WriteLine(this.textDepthLayer5.Text);
                                swERR.WriteLine(this.textKLayer1.Text);
                                swERR.WriteLine(this.textKLayer2.Text);
                                swERR.WriteLine(this.textKLayer3.Text);
                                swERR.WriteLine(this.textKLayer4.Text);
                                swERR.WriteLine(this.textKLayer5.Text);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("Soil Survey K - Low - High - Average");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.radioExportLow.Checked);
                                swERR.WriteLine(this.radioExportHigh.Checked);
                                swERR.WriteLine(this.radioExportAverage.Checked);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("Soil Survey Soil");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.comboSoilSurvey.SelectedIndex);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("Soil Survey Layer Info");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.textLayer1Bottom.Text);
                                swERR.WriteLine(this.textLayer2Bottom.Text);
                                swERR.WriteLine(this.textLayer3Bottom.Text);
                                swERR.WriteLine(this.textLayer4Bottom.Text);
                                swERR.WriteLine(this.textLayer5Bottom.Text);
                                swERR.WriteLine(this.textLayer1Low.Text);
                                swERR.WriteLine(this.textLayer2Low.Text);
                                swERR.WriteLine(this.textLayer3Low.Text);
                                swERR.WriteLine(this.textLayer4Low.Text);
                                swERR.WriteLine(this.textLayer5Low.Text);
                                swERR.WriteLine(this.textLayer1High.Text);
                                swERR.WriteLine(this.textLayer2High.Text);
                                swERR.WriteLine(this.textLayer3High.Text);
                                swERR.WriteLine(this.textLayer4High.Text);
                                swERR.WriteLine(this.textLayer5High.Text);
                                swERR.WriteLine(this.textLayer1Average.Text);
                                swERR.WriteLine(this.textLayer2Average.Text);
                                swERR.WriteLine(this.textLayer3Average.Text);
                                swERR.WriteLine(this.textLayer4Average.Text);
                                swERR.WriteLine(this.textLayer5Average.Text);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("Final Result");
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine(this.textLateralEffect.Text);
                                swERR.WriteLine("****************************************");
                                swERR.WriteLine("****************END*********************");
                                swERR.WriteLine("****************************************");

                                //Clean up and close file
                                swERR.Flush();
                                swERR.Close();
                            }



                        }//end catch

                        #endregion


        }//End Lateral Effect Button Click
            #endregion


    }//End Windows
}//End Namespace
