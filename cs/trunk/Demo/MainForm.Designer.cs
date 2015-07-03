﻿using BrightIdeasSoftware;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ObjectListViewDemo
{
	partial class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "System.Windows.Forms.Control.set_Text(System.String)")]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle1 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle2 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle3 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.CellStyle cellStyle1 = new BrightIdeasSoftware.CellStyle();
            BrightIdeasSoftware.CellStyle cellStyle2 = new BrightIdeasSoftware.CellStyle();
            BrightIdeasSoftware.CellStyle cellStyle3 = new BrightIdeasSoftware.CellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.command1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.command2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.command3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appearOnTheColumnHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabSimple = new ObjectListViewDemo.TabSimpleExample();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabComplex = new ObjectListViewDemo.TabComplexExample();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabDataSet = new ObjectListViewDemo.TabDataSet();
            this.tabPageFileExplorer = new System.Windows.Forms.TabPage();
            this.tabFileExplorer1 = new ObjectListViewDemo.TabFileExplorer();
            this.tabPageFastList = new System.Windows.Forms.TabPage();
            this.tabFastList1 = new ObjectListViewDemo.TabFastList();
            this.tabPageTreeListView = new System.Windows.Forms.TabPage();
            this.tabTreeListView1 = new ObjectListViewDemo.TabTreeListView();
            this.tabPageDataTreeListView = new System.Windows.Forms.TabPage();
            this.tabDataTreeListView1 = new ObjectListViewDemo.TabDataTreeListView();
            this.tabPagePrinting = new System.Windows.Forms.TabPage();
            this.tabPrinting1 = new ObjectListViewDemo.TabPrinting();
            this.tabPageDragAndDrop = new System.Windows.Forms.TabPage();
            this.tabDragAndDrop1 = new ObjectListViewDemo.TabDragAndDrop();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.olvGeeks = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn43 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn44 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn45 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cookingSkillRenderer = new BrightIdeasSoftware.MultiImageRenderer();
            this.yearOfBirthColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn46 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn47 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn48 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn49 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn50 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn51 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvFroods = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn52 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn53 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn54 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn55 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn56 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn57 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn58 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn59 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn60 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label33 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.cbCellGridLines = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rbStyleTooMuch = new System.Windows.Forms.RadioButton();
            this.cbPrintOnlySelection = new System.Windows.Forms.CheckBox();
            this.rbStyleModern = new System.Windows.Forms.RadioButton();
            this.cbShrinkToFit = new System.Windows.Forms.CheckBox();
            this.rbStyleMinimal = new System.Windows.Forms.RadioButton();
            this.cbIncludeImages = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbFooter = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbHeader = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbWatermark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbShowVirtual = new System.Windows.Forms.RadioButton();
            this.rbShowFileExplorer = new System.Windows.Forms.RadioButton();
            this.rbShowDataset = new System.Windows.Forms.RadioButton();
            this.rbShowComplex = new System.Windows.Forms.RadioButton();
            this.rbShowSimple = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.listViewPrinter1 = new BrightIdeasSoftware.ListViewPrinter();
            this.treeColumnFileExtension = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hotItemStyle3 = new BrightIdeasSoftware.HotItemStyle();
            this.hotItemStyle1 = new BrightIdeasSoftware.HotItemStyle();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.textBoxFilterFast = new System.Windows.Forms.TextBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.olvFast = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn18 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn19 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn26 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn27 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn28 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn29 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn31 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn32 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn33 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.buttonSaveState = new System.Windows.Forms.Button();
            this.buttonRestoreState = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.olvFiles = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFileCreated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFileModified = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFileType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAttributes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBoxFilterData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.checkBoxPause = new System.Windows.Forms.CheckBox();
            this.rowHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.olvData = new BrightIdeasSoftware.DataListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.highlightTextRenderer1 = new BrightIdeasSoftware.HighlightTextRenderer();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.salaryColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.salaryRenderer = new BrightIdeasSoftware.MultiImageRenderer();
            this.heightColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.heightRenderer = new BrightIdeasSoftware.BarRenderer();
            this.olvColumn42 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnGif = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageRenderer1 = new BrightIdeasSoftware.ImageRenderer();
            this.olvColumnFiller = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.headerFormatStyleData = new BrightIdeasSoftware.HeaderFormatStyle();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuOfCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appropriateToTheClickedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whichOnlyAppearsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whenYouClickOnColumn0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hyperlinkStyle1 = new BrightIdeasSoftware.HyperlinkStyle();
            this.textWrappingRenderer = new BrightIdeasSoftware.BaseRenderer();
            this.hotItemStyle2 = new BrightIdeasSoftware.HotItemStyle();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn35 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn36 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn37 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn38 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn39 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn40 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn21 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn22 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn23 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn30 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn24 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn25 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn20 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn17 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageRenderer2 = new BrightIdeasSoftware.ImageRenderer();
            this.groupImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabDescribedTasks = new System.Windows.Forms.TabPage();
            this.tabDescribedTask1 = new ObjectListViewDemo.TabDescribedTask();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPageFileExplorer.SuspendLayout();
            this.tabPageFastList.SuspendLayout();
            this.tabPageTreeListView.SuspendLayout();
            this.tabPageDataTreeListView.SuspendLayout();
            this.tabPagePrinting.SuspendLayout();
            this.tabPageDragAndDrop.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvGeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvFroods)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.tabDescribedTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.command1ToolStripMenuItem,
            this.command2ToolStripMenuItem,
            this.command3ToolStripMenuItem,
            this.appearOnTheColumnHeadersToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(263, 92);
            // 
            // command1ToolStripMenuItem
            // 
            this.command1ToolStripMenuItem.Name = "command1ToolStripMenuItem";
            this.command1ToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.command1ToolStripMenuItem.Text = "Dummy commands...";
            // 
            // command2ToolStripMenuItem
            // 
            this.command2ToolStripMenuItem.Name = "command2ToolStripMenuItem";
            this.command2ToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.command2ToolStripMenuItem.Text = "...to test that a context menu...";
            // 
            // command3ToolStripMenuItem
            // 
            this.command3ToolStripMenuItem.Name = "command3ToolStripMenuItem";
            this.command3ToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.command3ToolStripMenuItem.Text = "...appears here and a different one...";
            // 
            // appearOnTheColumnHeadersToolStripMenuItem
            // 
            this.appearOnTheColumnHeadersToolStripMenuItem.Name = "appearOnTheColumnHeadersToolStripMenuItem";
            this.appearOnTheColumnHeadersToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.appearOnTheColumnHeadersToolStripMenuItem.Text = "...appear on the column headers.";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPageFileExplorer);
            this.tabControl1.Controls.Add(this.tabPageFastList);
            this.tabControl1.Controls.Add(this.tabPageTreeListView);
            this.tabControl1.Controls.Add(this.tabPageDataTreeListView);
            this.tabControl1.Controls.Add(this.tabPagePrinting);
            this.tabControl1.Controls.Add(this.tabPageDragAndDrop);
            this.tabControl1.Controls.Add(this.tabDescribedTasks);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 529);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabSimple);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple Example";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabSimple
            // 
            this.tabSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSimple.Location = new System.Drawing.Point(0, 0);
            this.tabSimple.Name = "tabSimple";
            this.tabSimple.Size = new System.Drawing.Size(800, 499);
            this.tabSimple.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabComplex);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complex Example";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabComplex
            // 
            this.tabComplex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabComplex.Location = new System.Drawing.Point(2, 0);
            this.tabComplex.Name = "tabComplex";
            this.tabComplex.Size = new System.Drawing.Size(800, 499);
            this.tabComplex.TabIndex = 0;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.tabDataSet);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(811, 503);
            this.tabPage11.TabIndex = 11;
            this.tabPage11.Text = "DataListView";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabDataSet
            // 
            this.tabDataSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDataSet.Location = new System.Drawing.Point(0, 0);
            this.tabDataSet.Name = "tabDataSet";
            this.tabDataSet.Size = new System.Drawing.Size(811, 503);
            this.tabDataSet.TabIndex = 0;
            // 
            // tabPageFileExplorer
            // 
            this.tabPageFileExplorer.Controls.Add(this.tabFileExplorer1);
            this.tabPageFileExplorer.Location = new System.Drawing.Point(4, 22);
            this.tabPageFileExplorer.Name = "tabPageFileExplorer";
            this.tabPageFileExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFileExplorer.Size = new System.Drawing.Size(811, 503);
            this.tabPageFileExplorer.TabIndex = 12;
            this.tabPageFileExplorer.Text = "File Explorer";
            this.tabPageFileExplorer.UseVisualStyleBackColor = true;
            // 
            // tabFileExplorer1
            // 
            this.tabFileExplorer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFileExplorer1.Location = new System.Drawing.Point(1, 0);
            this.tabFileExplorer1.Name = "tabFileExplorer1";
            this.tabFileExplorer1.Size = new System.Drawing.Size(804, 499);
            this.tabFileExplorer1.TabIndex = 0;
            // 
            // tabPageFastList
            // 
            this.tabPageFastList.Controls.Add(this.tabFastList1);
            this.tabPageFastList.Location = new System.Drawing.Point(4, 22);
            this.tabPageFastList.Name = "tabPageFastList";
            this.tabPageFastList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFastList.Size = new System.Drawing.Size(811, 503);
            this.tabPageFastList.TabIndex = 13;
            this.tabPageFastList.Text = "Fast List";
            this.tabPageFastList.UseVisualStyleBackColor = true;
            // 
            // tabFastList1
            // 
            this.tabFastList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFastList1.Location = new System.Drawing.Point(0, 1);
            this.tabFastList1.Name = "tabFastList1";
            this.tabFastList1.Size = new System.Drawing.Size(804, 499);
            this.tabFastList1.TabIndex = 0;
            // 
            // tabPageTreeListView
            // 
            this.tabPageTreeListView.Controls.Add(this.tabTreeListView1);
            this.tabPageTreeListView.Location = new System.Drawing.Point(4, 22);
            this.tabPageTreeListView.Name = "tabPageTreeListView";
            this.tabPageTreeListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTreeListView.Size = new System.Drawing.Size(811, 503);
            this.tabPageTreeListView.TabIndex = 14;
            this.tabPageTreeListView.Text = "TreeListView";
            this.tabPageTreeListView.UseVisualStyleBackColor = true;
            // 
            // tabTreeListView1
            // 
            this.tabTreeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTreeListView1.Location = new System.Drawing.Point(0, 0);
            this.tabTreeListView1.Name = "tabTreeListView1";
            this.tabTreeListView1.Size = new System.Drawing.Size(804, 499);
            this.tabTreeListView1.TabIndex = 0;
            // 
            // tabPageDataTreeListView
            // 
            this.tabPageDataTreeListView.Controls.Add(this.tabDataTreeListView1);
            this.tabPageDataTreeListView.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataTreeListView.Name = "tabPageDataTreeListView";
            this.tabPageDataTreeListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataTreeListView.Size = new System.Drawing.Size(811, 503);
            this.tabPageDataTreeListView.TabIndex = 15;
            this.tabPageDataTreeListView.Text = "DataTreeListView";
            this.tabPageDataTreeListView.UseVisualStyleBackColor = true;
            // 
            // tabDataTreeListView1
            // 
            this.tabDataTreeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDataTreeListView1.Location = new System.Drawing.Point(0, 0);
            this.tabDataTreeListView1.Name = "tabDataTreeListView1";
            this.tabDataTreeListView1.Size = new System.Drawing.Size(804, 499);
            this.tabDataTreeListView1.TabIndex = 0;
            // 
            // tabPagePrinting
            // 
            this.tabPagePrinting.Controls.Add(this.tabPrinting1);
            this.tabPagePrinting.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrinting.Name = "tabPagePrinting";
            this.tabPagePrinting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrinting.Size = new System.Drawing.Size(811, 503);
            this.tabPagePrinting.TabIndex = 16;
            this.tabPagePrinting.Text = "Printing ListViews";
            this.tabPagePrinting.UseVisualStyleBackColor = true;
            // 
            // tabPrinting1
            // 
            this.tabPrinting1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrinting1.Location = new System.Drawing.Point(0, 0);
            this.tabPrinting1.Name = "tabPrinting1";
            this.tabPrinting1.Size = new System.Drawing.Size(804, 499);
            this.tabPrinting1.TabIndex = 0;
            // 
            // tabPageDragAndDrop
            // 
            this.tabPageDragAndDrop.Controls.Add(this.tabDragAndDrop1);
            this.tabPageDragAndDrop.Location = new System.Drawing.Point(4, 22);
            this.tabPageDragAndDrop.Name = "tabPageDragAndDrop";
            this.tabPageDragAndDrop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDragAndDrop.Size = new System.Drawing.Size(811, 503);
            this.tabPageDragAndDrop.TabIndex = 17;
            this.tabPageDragAndDrop.Text = "Drag and drop";
            this.tabPageDragAndDrop.UseVisualStyleBackColor = true;
            // 
            // tabDragAndDrop1
            // 
            this.tabDragAndDrop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDragAndDrop1.Location = new System.Drawing.Point(0, 0);
            this.tabDragAndDrop1.Name = "tabDragAndDrop1";
            this.tabDragAndDrop1.Size = new System.Drawing.Size(804, 499);
            this.tabDragAndDrop1.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.checkBox22);
            this.tabPage8.Controls.Add(this.checkBox21);
            this.tabPage8.Controls.Add(this.tableLayoutPanel1);
            this.tabPage8.Controls.Add(this.label33);
            this.tabPage8.Controls.Add(this.comboBox13);
            this.tabPage8.Controls.Add(this.label31);
            this.tabPage8.Controls.Add(this.comboBox12);
            this.tabPage8.Controls.Add(this.label30);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(811, 503);
            this.tabPage8.TabIndex = 10;
            this.tabPage8.Text = "Drag and drop";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox22.Location = new System.Drawing.Point(584, 474);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(86, 21);
            this.checkBox22.TabIndex = 21;
            this.checkBox22.Text = "Owner &Draw";
            this.toolTip1.SetToolTip(this.checkBox22, "Should the list use its custom draw facilities (looks shinier)");
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox21.Location = new System.Drawing.Point(6, 474);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(86, 21);
            this.checkBox21.TabIndex = 20;
            this.checkBox21.Text = "Owner &Draw";
            this.toolTip1.SetToolTip(this.checkBox21, "Should the list use its custom draw facilities (looks shinier)");
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label34, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label35, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.olvGeeks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.olvFroods, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 410);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label34.Location = new System.Drawing.Point(3, 3);
            this.label34.Margin = new System.Windows.Forms.Padding(3);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(119, 14);
            this.label34.TabIndex = 17;
            this.label34.Text = "Geeks and Tweebs";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label35.Location = new System.Drawing.Point(402, 3);
            this.label35.Margin = new System.Windows.Forms.Padding(3);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(78, 14);
            this.label35.TabIndex = 18;
            this.label35.Text = "Cool froods";
            // 
            // olvGeeks
            // 
            this.olvGeeks.AllColumns.Add(this.olvColumn43);
            this.olvGeeks.AllColumns.Add(this.olvColumn44);
            this.olvGeeks.AllColumns.Add(this.olvColumn45);
            this.olvGeeks.AllColumns.Add(this.yearOfBirthColumn);
            this.olvGeeks.AllColumns.Add(this.olvColumn46);
            this.olvGeeks.AllColumns.Add(this.olvColumn47);
            this.olvGeeks.AllColumns.Add(this.olvColumn48);
            this.olvGeeks.AllColumns.Add(this.olvColumn49);
            this.olvGeeks.AllColumns.Add(this.olvColumn50);
            this.olvGeeks.AllColumns.Add(this.olvColumn51);
            this.olvGeeks.AllowColumnReorder = true;
            this.olvGeeks.AllowDrop = true;
            this.olvGeeks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvGeeks.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only;
            this.olvGeeks.CheckedAspectName = "";
            this.olvGeeks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn43,
            this.olvColumn44,
            this.olvColumn45,
            this.olvColumn46,
            this.olvColumn47,
            this.olvColumn48,
            this.olvColumn49,
            this.olvColumn50,
            this.olvColumn51});
            this.olvGeeks.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvGeeks.EmptyListMsg = "Drag some cool froods here";
            this.olvGeeks.FullRowSelect = true;
            this.olvGeeks.GroupWithItemCountFormat = "{0} ({1} people)";
            this.olvGeeks.GroupWithItemCountSingularFormat = "{0} ({1} person)";
            this.olvGeeks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.olvGeeks.HideSelection = false;
            this.olvGeeks.Location = new System.Drawing.Point(3, 23);
            this.olvGeeks.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.olvGeeks.Name = "olvGeeks";
            this.olvGeeks.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvGeeks.OverlayText.Text = "";
            this.olvGeeks.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvGeeks.ShowCommandMenuOnRightClick = true;
            this.olvGeeks.ShowGroups = false;
            this.olvGeeks.ShowImagesOnSubItems = true;
            this.olvGeeks.ShowItemToolTips = true;
            this.olvGeeks.Size = new System.Drawing.Size(390, 384);
            this.olvGeeks.TabIndex = 8;
            this.olvGeeks.UseAlternatingBackColors = true;
            this.olvGeeks.UseCompatibleStateImageBehavior = false;
            this.olvGeeks.UseHotItem = true;
            this.olvGeeks.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn43
            // 
            this.olvColumn43.AspectName = "Name";
            this.olvColumn43.Text = "Person";
            this.olvColumn43.UseInitialLetterForGroup = true;
            this.olvColumn43.Width = 114;
            // 
            // olvColumn44
            // 
            this.olvColumn44.AspectName = "Occupation";
            this.olvColumn44.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn44.IsTileViewColumn = true;
            this.olvColumn44.Text = "Occupation";
            this.olvColumn44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn44.Width = 92;
            // 
            // olvColumn45
            // 
            this.olvColumn45.AspectName = "CulinaryRating";
            this.olvColumn45.GroupWithItemCountFormat = "{0} ({1} candidates)";
            this.olvColumn45.GroupWithItemCountSingularFormat = "{0} (only {1} candidate)";
            this.olvColumn45.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn45.Renderer = this.cookingSkillRenderer;
            this.olvColumn45.Text = "Cooking skill";
            this.olvColumn45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn45.Width = 75;
            // 
            // cookingSkillRenderer
            // 
            this.cookingSkillRenderer.ImageName = "star";
            this.cookingSkillRenderer.MaximumValue = 50;
            this.cookingSkillRenderer.MaxNumberImages = 5;
            // 
            // yearOfBirthColumn
            // 
            this.yearOfBirthColumn.AspectName = "YearOfBirth";
            this.yearOfBirthColumn.DisplayIndex = 3;
            this.yearOfBirthColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearOfBirthColumn.IsVisible = false;
            this.yearOfBirthColumn.Text = "Year Of Birth";
            this.yearOfBirthColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearOfBirthColumn.Width = 80;
            // 
            // olvColumn46
            // 
            this.olvColumn46.AspectName = "BirthDate";
            this.olvColumn46.AspectToStringFormat = "{0:D}";
            this.olvColumn46.GroupWithItemCountFormat = "{0} has {1} birthdays";
            this.olvColumn46.GroupWithItemCountSingularFormat = "{0} has only {1} birthday";
            this.olvColumn46.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn46.IsTileViewColumn = true;
            this.olvColumn46.Text = "Birthday";
            this.olvColumn46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn46.Width = 111;
            // 
            // olvColumn47
            // 
            this.olvColumn47.AspectName = "GetRate";
            this.olvColumn47.AspectToStringFormat = "{0:C}";
            this.olvColumn47.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn47.IsTileViewColumn = true;
            this.olvColumn47.Text = "Hourly Rate";
            this.olvColumn47.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn47.Width = 71;
            // 
            // olvColumn48
            // 
            this.olvColumn48.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn48.IsEditable = false;
            this.olvColumn48.Text = "Salary";
            this.olvColumn48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn48.Width = 55;
            // 
            // olvColumn49
            // 
            this.olvColumn49.IsEditable = false;
            this.olvColumn49.Text = "Days Since Birth";
            this.olvColumn49.Width = 81;
            // 
            // olvColumn50
            // 
            this.olvColumn50.AspectName = "CanTellJokes";
            this.olvColumn50.CheckBoxes = true;
            this.olvColumn50.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn50.Text = "Tells Jokes?";
            this.olvColumn50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn50.Width = 74;
            // 
            // olvColumn51
            // 
            this.olvColumn51.AspectName = "MaritalStatus";
            this.olvColumn51.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn51.Text = "Married?";
            this.olvColumn51.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvFroods
            // 
            this.olvFroods.AllColumns.Add(this.olvColumn52);
            this.olvFroods.AllColumns.Add(this.olvColumn53);
            this.olvFroods.AllColumns.Add(this.olvColumn54);
            this.olvFroods.AllColumns.Add(this.yearOfBirthColumn);
            this.olvFroods.AllColumns.Add(this.olvColumn55);
            this.olvFroods.AllColumns.Add(this.olvColumn56);
            this.olvFroods.AllColumns.Add(this.olvColumn57);
            this.olvFroods.AllColumns.Add(this.olvColumn58);
            this.olvFroods.AllColumns.Add(this.olvColumn59);
            this.olvFroods.AllColumns.Add(this.olvColumn60);
            this.olvFroods.AllowColumnReorder = true;
            this.olvFroods.AllowDrop = true;
            this.olvFroods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvFroods.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only;
            this.olvFroods.CheckedAspectName = "";
            this.olvFroods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn52,
            this.olvColumn53,
            this.olvColumn54,
            this.olvColumn55,
            this.olvColumn56,
            this.olvColumn57,
            this.olvColumn58,
            this.olvColumn59,
            this.olvColumn60});
            this.olvFroods.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFroods.EmptyListMsg = "Drag some geeks here";
            this.olvFroods.FullRowSelect = true;
            this.olvFroods.GroupWithItemCountFormat = "{0} ({1} people)";
            this.olvFroods.GroupWithItemCountSingularFormat = "{0} ({1} person)";
            this.olvFroods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.olvFroods.HideSelection = false;
            this.olvFroods.Location = new System.Drawing.Point(405, 23);
            this.olvFroods.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.olvFroods.Name = "olvFroods";
            this.olvFroods.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvFroods.OverlayText.Text = "";
            this.olvFroods.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvFroods.ShowCommandMenuOnRightClick = true;
            this.olvFroods.ShowGroups = false;
            this.olvFroods.ShowImagesOnSubItems = true;
            this.olvFroods.ShowItemToolTips = true;
            this.olvFroods.Size = new System.Drawing.Size(391, 384);
            this.olvFroods.TabIndex = 13;
            this.olvFroods.UseAlternatingBackColors = true;
            this.olvFroods.UseCompatibleStateImageBehavior = false;
            this.olvFroods.UseHotItem = true;
            this.olvFroods.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn52
            // 
            this.olvColumn52.AspectName = "Name";
            this.olvColumn52.Text = "Person";
            this.olvColumn52.UseInitialLetterForGroup = true;
            this.olvColumn52.Width = 114;
            // 
            // olvColumn53
            // 
            this.olvColumn53.AspectName = "Occupation";
            this.olvColumn53.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn53.IsTileViewColumn = true;
            this.olvColumn53.Text = "Occupation";
            this.olvColumn53.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn53.Width = 92;
            // 
            // olvColumn54
            // 
            this.olvColumn54.AspectName = "CulinaryRating";
            this.olvColumn54.GroupWithItemCountFormat = "{0} ({1} candidates)";
            this.olvColumn54.GroupWithItemCountSingularFormat = "{0} (only {1} candidate)";
            this.olvColumn54.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn54.Renderer = this.cookingSkillRenderer;
            this.olvColumn54.Text = "Cooking skill";
            this.olvColumn54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn54.Width = 75;
            // 
            // olvColumn55
            // 
            this.olvColumn55.AspectName = "BirthDate";
            this.olvColumn55.AspectToStringFormat = "{0:D}";
            this.olvColumn55.GroupWithItemCountFormat = "{0} has {1} birthdays";
            this.olvColumn55.GroupWithItemCountSingularFormat = "{0} has only {1} birthday";
            this.olvColumn55.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn55.IsTileViewColumn = true;
            this.olvColumn55.Text = "Birthday";
            this.olvColumn55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn55.Width = 111;
            // 
            // olvColumn56
            // 
            this.olvColumn56.AspectName = "GetRate";
            this.olvColumn56.AspectToStringFormat = "{0:C}";
            this.olvColumn56.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn56.IsTileViewColumn = true;
            this.olvColumn56.Text = "Hourly Rate";
            this.olvColumn56.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn56.Width = 71;
            // 
            // olvColumn57
            // 
            this.olvColumn57.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn57.IsEditable = false;
            this.olvColumn57.Text = "Salary";
            this.olvColumn57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn57.Width = 55;
            // 
            // olvColumn58
            // 
            this.olvColumn58.IsEditable = false;
            this.olvColumn58.Text = "Days Since Birth";
            this.olvColumn58.Width = 81;
            // 
            // olvColumn59
            // 
            this.olvColumn59.AspectName = "CanTellJokes";
            this.olvColumn59.CheckBoxes = true;
            this.olvColumn59.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn59.Text = "Tells Jokes?";
            this.olvColumn59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn59.Width = 74;
            // 
            // olvColumn60
            // 
            this.olvColumn60.AspectName = "MaritalStatus";
            this.olvColumn60.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn60.Text = "Married?";
            this.olvColumn60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(676, 477);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(33, 13);
            this.label33.TabIndex = 16;
            this.label33.Text = "View:";
            // 
            // comboBox13
            // 
            this.comboBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "Small Icon",
            "Large Icon",
            "List",
            "Tile",
            "Details"});
            this.comboBox13.Location = new System.Drawing.Point(715, 474);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(89, 21);
            this.comboBox13.TabIndex = 15;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(95, 477);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(33, 13);
            this.label31.TabIndex = 12;
            this.label31.Text = "View:";
            // 
            // comboBox12
            // 
            this.comboBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "Small Icon",
            "Large Icon",
            "List",
            "Tile",
            "Details"});
            this.comboBox12.Location = new System.Drawing.Point(134, 474);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(97, 21);
            this.comboBox12.TabIndex = 11;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label30.Location = new System.Drawing.Point(6, 7);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(799, 48);
            this.label30.TabIndex = 10;
            this.label30.Text = resources.GetString("label30.Text");
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox5);
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.button12);
            this.tabPage6.Controls.Add(this.button11);
            this.tabPage6.Controls.Add(this.button10);
            this.tabPage6.Controls.Add(this.printPreviewControl1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(811, 503);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Printing ListViews";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown2);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.cbCellGridLines);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.rbStyleTooMuch);
            this.groupBox5.Controls.Add(this.cbPrintOnlySelection);
            this.groupBox5.Controls.Add(this.rbStyleModern);
            this.groupBox5.Controls.Add(this.cbShrinkToFit);
            this.groupBox5.Controls.Add(this.rbStyleMinimal);
            this.groupBox5.Controls.Add(this.cbIncludeImages);
            this.groupBox5.Location = new System.Drawing.Point(144, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(301, 109);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Format";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(200, 84);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Location = new System.Drawing.Point(163, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 19);
            this.label19.TabIndex = 10;
            this.label19.Text = "to:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(99, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Location = new System.Drawing.Point(18, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 19);
            this.label18.TabIndex = 8;
            this.label18.Text = "Page range:";
            // 
            // cbCellGridLines
            // 
            this.cbCellGridLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCellGridLines.AutoSize = true;
            this.cbCellGridLines.Checked = true;
            this.cbCellGridLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCellGridLines.Location = new System.Drawing.Point(200, 62);
            this.cbCellGridLines.Name = "cbCellGridLines";
            this.cbCellGridLines.Size = new System.Drawing.Size(87, 17);
            this.cbCellGridLines.TabIndex = 7;
            this.cbCellGridLines.Text = "Cell grid lines";
            this.cbCellGridLines.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Location = new System.Drawing.Point(19, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Style:";
            // 
            // rbStyleTooMuch
            // 
            this.rbStyleTooMuch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStyleTooMuch.Location = new System.Drawing.Point(200, 15);
            this.rbStyleTooMuch.Name = "rbStyleTooMuch";
            this.rbStyleTooMuch.Size = new System.Drawing.Size(78, 24);
            this.rbStyleTooMuch.TabIndex = 3;
            this.rbStyleTooMuch.Text = "Too much!";
            this.rbStyleTooMuch.UseVisualStyleBackColor = true;
            // 
            // cbPrintOnlySelection
            // 
            this.cbPrintOnlySelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPrintOnlySelection.AutoSize = true;
            this.cbPrintOnlySelection.Location = new System.Drawing.Point(21, 62);
            this.cbPrintOnlySelection.Name = "cbPrintOnlySelection";
            this.cbPrintOnlySelection.Size = new System.Drawing.Size(146, 17);
            this.cbPrintOnlySelection.TabIndex = 6;
            this.cbPrintOnlySelection.Text = "Print Only Selected Rows";
            this.cbPrintOnlySelection.UseVisualStyleBackColor = true;
            // 
            // rbStyleModern
            // 
            this.rbStyleModern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStyleModern.Checked = true;
            this.rbStyleModern.Location = new System.Drawing.Point(133, 15);
            this.rbStyleModern.Name = "rbStyleModern";
            this.rbStyleModern.Size = new System.Drawing.Size(61, 24);
            this.rbStyleModern.TabIndex = 2;
            this.rbStyleModern.TabStop = true;
            this.rbStyleModern.Text = "Modern";
            this.rbStyleModern.UseVisualStyleBackColor = true;
            // 
            // cbShrinkToFit
            // 
            this.cbShrinkToFit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShrinkToFit.AutoSize = true;
            this.cbShrinkToFit.Location = new System.Drawing.Point(200, 41);
            this.cbShrinkToFit.Name = "cbShrinkToFit";
            this.cbShrinkToFit.Size = new System.Drawing.Size(86, 17);
            this.cbShrinkToFit.TabIndex = 5;
            this.cbShrinkToFit.Text = "Shrink To Fit";
            this.cbShrinkToFit.UseVisualStyleBackColor = true;
            // 
            // rbStyleMinimal
            // 
            this.rbStyleMinimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStyleMinimal.Location = new System.Drawing.Point(66, 15);
            this.rbStyleMinimal.Name = "rbStyleMinimal";
            this.rbStyleMinimal.Size = new System.Drawing.Size(61, 24);
            this.rbStyleMinimal.TabIndex = 1;
            this.rbStyleMinimal.Text = "Minimal";
            this.rbStyleMinimal.UseVisualStyleBackColor = true;
            // 
            // cbIncludeImages
            // 
            this.cbIncludeImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIncludeImages.AutoSize = true;
            this.cbIncludeImages.Checked = true;
            this.cbIncludeImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeImages.Location = new System.Drawing.Point(22, 41);
            this.cbIncludeImages.Name = "cbIncludeImages";
            this.cbIncludeImages.Size = new System.Drawing.Size(145, 17);
            this.cbIncludeImages.TabIndex = 4;
            this.cbIncludeImages.Text = "Include Images In Report";
            this.cbIncludeImages.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tbFooter);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbHeader);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tbWatermark);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tbTitle);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(451, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 109);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Print Settings";
            // 
            // tbFooter
            // 
            this.tbFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFooter.Location = new System.Drawing.Point(73, 61);
            this.tbFooter.Name = "tbFooter";
            this.tbFooter.Size = new System.Drawing.Size(275, 20);
            this.tbFooter.TabIndex = 5;
            this.tbFooter.Text = "{1:F}\\t\\tPage: {0}";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Footer:";
            // 
            // tbHeader
            // 
            this.tbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeader.Location = new System.Drawing.Point(73, 39);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Size = new System.Drawing.Size(275, 20);
            this.tbHeader.TabIndex = 3;
            this.tbHeader.Text = "Easy Printing ListView";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(7, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Header:";
            // 
            // tbWatermark
            // 
            this.tbWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWatermark.Location = new System.Drawing.Point(73, 83);
            this.tbWatermark.Name = "tbWatermark";
            this.tbWatermark.Size = new System.Drawing.Size(275, 20);
            this.tbWatermark.TabIndex = 7;
            this.tbWatermark.Text = "SLOTHFUL!";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Watermark:";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(73, 17);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(275, 20);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.Text = "List View printer demo";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(7, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Job title:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbShowVirtual);
            this.groupBox2.Controls.Add(this.rbShowFileExplorer);
            this.groupBox2.Controls.Add(this.rbShowDataset);
            this.groupBox2.Controls.Add(this.rbShowComplex);
            this.groupBox2.Controls.Add(this.rbShowSimple);
            this.groupBox2.Location = new System.Drawing.Point(7, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 108);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List view to print";
            // 
            // rbShowVirtual
            // 
            this.rbShowVirtual.Location = new System.Drawing.Point(6, 67);
            this.rbShowVirtual.Name = "rbShowVirtual";
            this.rbShowVirtual.Size = new System.Drawing.Size(104, 23);
            this.rbShowVirtual.TabIndex = 3;
            this.rbShowVirtual.Text = "Virtual list";
            this.rbShowVirtual.UseVisualStyleBackColor = true;
            // 
            // rbShowFileExplorer
            // 
            this.rbShowFileExplorer.Location = new System.Drawing.Point(6, 86);
            this.rbShowFileExplorer.Name = "rbShowFileExplorer";
            this.rbShowFileExplorer.Size = new System.Drawing.Size(104, 23);
            this.rbShowFileExplorer.TabIndex = 4;
            this.rbShowFileExplorer.Text = "File explorer list";
            this.rbShowFileExplorer.UseVisualStyleBackColor = true;
            // 
            // rbShowDataset
            // 
            this.rbShowDataset.Location = new System.Drawing.Point(6, 48);
            this.rbShowDataset.Name = "rbShowDataset";
            this.rbShowDataset.Size = new System.Drawing.Size(104, 23);
            this.rbShowDataset.TabIndex = 2;
            this.rbShowDataset.Text = "Dataset list";
            this.rbShowDataset.UseVisualStyleBackColor = true;
            // 
            // rbShowComplex
            // 
            this.rbShowComplex.Checked = true;
            this.rbShowComplex.Location = new System.Drawing.Point(6, 29);
            this.rbShowComplex.Name = "rbShowComplex";
            this.rbShowComplex.Size = new System.Drawing.Size(104, 23);
            this.rbShowComplex.TabIndex = 1;
            this.rbShowComplex.TabStop = true;
            this.rbShowComplex.Text = "Complex list";
            this.rbShowComplex.UseVisualStyleBackColor = true;
            // 
            // rbShowSimple
            // 
            this.rbShowSimple.Location = new System.Drawing.Point(6, 10);
            this.rbShowSimple.Name = "rbShowSimple";
            this.rbShowSimple.Size = new System.Drawing.Size(104, 23);
            this.rbShowSimple.TabIndex = 0;
            this.rbShowSimple.Text = "Simple list";
            this.rbShowSimple.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(6, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(799, 30);
            this.label12.TabIndex = 12;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Location = new System.Drawing.Point(706, 224);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(93, 23);
            this.button12.TabIndex = 5;
            this.button12.Text = "Print...";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Location = new System.Drawing.Point(706, 195);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "Print Preview...";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Location = new System.Drawing.Point(706, 166);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Page Setup...";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Columns = 2;
            this.printPreviewControl1.Document = this.listViewPrinter1;
            this.printPreviewControl1.Location = new System.Drawing.Point(7, 154);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(693, 328);
            this.printPreviewControl1.TabIndex = 6;
            this.printPreviewControl1.UseAntiAlias = true;
            this.printPreviewControl1.Zoom = 0.25834046193327631D;
            // 
            // listViewPrinter1
            // 
            // 
            // 
            // 
            this.listViewPrinter1.CellFormat.CanWrap = true;
            this.listViewPrinter1.CellFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPrinter1.Footer = "This is the footers";
            // 
            // 
            // 
            this.listViewPrinter1.FooterFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic);
            // 
            // 
            // 
            this.listViewPrinter1.GroupHeaderFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.listViewPrinter1.Header = "This is the header\t\tRight";
            // 
            // 
            // 
            this.listViewPrinter1.HeaderFormat.Font = new System.Drawing.Font("Verdana", 24F);
            this.listViewPrinter1.IsListHeaderOnEachPage = false;
            // 
            // 
            // 
            this.listViewPrinter1.ListHeaderFormat.CanWrap = true;
            this.listViewPrinter1.ListHeaderFormat.Font = new System.Drawing.Font("Verdana", 12F);
            this.listViewPrinter1.Watermark = "TOP SECRET!";
            this.listViewPrinter1.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // treeColumnFileExtension
            // 
            this.treeColumnFileExtension.AspectName = "Extension";
            this.treeColumnFileExtension.IsVisible = false;
            this.treeColumnFileExtension.Text = "Extension";
            // 
            // hotItemStyle3
            // 
            this.hotItemStyle3.ForeColor = System.Drawing.Color.DarkGreen;
            // 
            // hotItemStyle1
            // 
            this.hotItemStyle1.BackColor = System.Drawing.Color.PeachPuff;
            this.hotItemStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Controls.Add(this.checkBox2);
            this.tabPage7.Controls.Add(this.groupBox11);
            this.tabPage7.Controls.Add(this.checkBox20);
            this.tabPage7.Controls.Add(this.button19);
            this.tabPage7.Controls.Add(this.button18);
            this.tabPage7.Controls.Add(this.label26);
            this.tabPage7.Controls.Add(this.comboBox9);
            this.tabPage7.Controls.Add(this.label25);
            this.tabPage7.Controls.Add(this.comboBox10);
            this.tabPage7.Controls.Add(this.checkBox13);
            this.tabPage7.Controls.Add(this.button15);
            this.tabPage7.Controls.Add(this.button14);
            this.tabPage7.Controls.Add(this.olvFast);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(811, 503);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Fast List";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(233, 480);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Editable:";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.Location = new System.Drawing.Point(151, 476);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(87, 21);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Check&boxes";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.comboBox16);
            this.groupBox11.Controls.Add(this.textBoxFilterFast);
            this.groupBox11.Location = new System.Drawing.Point(591, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(214, 44);
            this.groupBox11.TabIndex = 20;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Filter";
            // 
            // comboBox16
            // 
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "Any text",
            "Prefix",
            "Regex"});
            this.comboBox16.Location = new System.Drawing.Point(114, 18);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(94, 21);
            this.comboBox16.TabIndex = 1;
            // 
            // textBoxFilterFast
            // 
            this.textBoxFilterFast.Location = new System.Drawing.Point(7, 18);
            this.textBoxFilterFast.Name = "textBoxFilterFast";
            this.textBoxFilterFast.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterFast.TabIndex = 0;
            // 
            // checkBox20
            // 
            this.checkBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox20.Location = new System.Drawing.Point(5, 476);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(60, 21);
            this.checkBox20.TabIndex = 18;
            this.checkBox20.Text = "&Groups";
            this.toolTip1.SetToolTip(this.checkBox20, "Cluster the rows into groups");
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.Location = new System.Drawing.Point(495, 474);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(90, 23);
            this.button19.TabIndex = 17;
            this.button19.Text = "Copy Chec&ked";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Location = new System.Drawing.Point(650, 474);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(72, 23);
            this.button18.TabIndex = 7;
            this.button18.Text = "Remove";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Location = new System.Drawing.Point(6, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(579, 45);
            this.label26.TabIndex = 16;
            this.label26.Text = resources.GetString("label26.Text");
            // 
            // comboBox9
            // 
            this.comboBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "No",
            "Single Click",
            "Double Click",
            "F2 Only"});
            this.comboBox9.Location = new System.Drawing.Point(282, 475);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(83, 21);
            this.comboBox9.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(367, 480);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "View:";
            // 
            // comboBox10
            // 
            this.comboBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "Small Icon",
            "Large Icon",
            "List",
            "Tile",
            "Details"});
            this.comboBox10.Location = new System.Drawing.Point(402, 475);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(83, 21);
            this.comboBox10.TabIndex = 5;
            // 
            // checkBox13
            // 
            this.checkBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.Location = new System.Drawing.Point(67, 476);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(87, 21);
            this.checkBox13.TabIndex = 1;
            this.checkBox13.Text = "Owner &Draw";
            this.toolTip1.SetToolTip(this.checkBox13, "Should the list use its custom draw facilities (looks shinier)");
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Location = new System.Drawing.Point(590, 474);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 23);
            this.button15.TabIndex = 6;
            this.button15.Text = "&Clear";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Location = new System.Drawing.Point(728, 474);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(77, 23);
            this.button14.TabIndex = 8;
            this.button14.Text = "&Add 1000";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // olvFast
            // 
            this.olvFast.AllColumns.Add(this.olvColumn18);
            this.olvFast.AllColumns.Add(this.olvColumn19);
            this.olvFast.AllColumns.Add(this.olvColumn26);
            this.olvFast.AllColumns.Add(this.olvColumn27);
            this.olvFast.AllColumns.Add(this.olvColumn28);
            this.olvFast.AllColumns.Add(this.olvColumn29);
            this.olvFast.AllColumns.Add(this.olvColumn31);
            this.olvFast.AllColumns.Add(this.olvColumn32);
            this.olvFast.AllColumns.Add(this.olvColumn33);
            this.olvFast.AllowColumnReorder = true;
            this.olvFast.AllowDrop = true;
            this.olvFast.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.olvFast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvFast.BackgroundImageTiled = true;
            this.olvFast.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvFast.CellEditEnterChangesRows = true;
            this.olvFast.CellEditTabChangesRows = true;
            this.olvFast.CheckBoxes = true;
            this.olvFast.CheckedAspectName = "";
            this.olvFast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn18,
            this.olvColumn19,
            this.olvColumn26,
            this.olvColumn27,
            this.olvColumn28,
            this.olvColumn29,
            this.olvColumn31,
            this.olvColumn32,
            this.olvColumn33});
            this.olvFast.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFast.EmptyListMsg = "This fast list is empty";
            this.olvFast.FullRowSelect = true;
            this.olvFast.GridLines = true;
            this.olvFast.HideSelection = false;
            this.olvFast.Location = new System.Drawing.Point(6, 57);
            this.olvFast.Name = "olvFast";
            this.olvFast.OwnerDraw = true;
            this.olvFast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.olvFast.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvFast.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.olvFast.ShowCommandMenuOnRightClick = true;
            this.olvFast.ShowGroups = false;
            this.olvFast.ShowImagesOnSubItems = true;
            this.olvFast.ShowItemToolTips = true;
            this.olvFast.Size = new System.Drawing.Size(799, 414);
            this.olvFast.SpaceBetweenGroups = 20;
            this.olvFast.TabIndex = 0;
            this.olvFast.TintSortColumn = true;
            this.olvFast.TriStateCheckBoxes = true;
            this.olvFast.UseAlternatingBackColors = true;
            this.olvFast.UseCompatibleStateImageBehavior = false;
            this.olvFast.UseFilterIndicator = true;
            this.olvFast.UseFiltering = true;
            this.olvFast.UseHyperlinks = true;
            this.olvFast.View = System.Windows.Forms.View.Details;
            this.olvFast.VirtualMode = true;
            // 
            // olvColumn18
            // 
            this.olvColumn18.AspectName = "Name";
            this.olvColumn18.Text = "Person";
            this.olvColumn18.UseInitialLetterForGroup = true;
            this.olvColumn18.Width = 114;
            // 
            // olvColumn19
            // 
            this.olvColumn19.AspectName = "Occupation";
            this.olvColumn19.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn19.Hyperlink = true;
            this.olvColumn19.IsTileViewColumn = true;
            this.olvColumn19.Text = "Occupation";
            this.olvColumn19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn19.Width = 92;
            // 
            // olvColumn26
            // 
            this.olvColumn26.AspectName = "CulinaryRating";
            this.olvColumn26.GroupWithItemCountFormat = "{0} ({1} candidates)";
            this.olvColumn26.GroupWithItemCountSingularFormat = "{0} (only {1} candidate)";
            this.olvColumn26.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn26.Text = "Cooking skill";
            this.olvColumn26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn26.Width = 75;
            // 
            // olvColumn27
            // 
            this.olvColumn27.AspectName = "YearOfBirth";
            this.olvColumn27.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn27.Text = "Year Of Birth";
            this.olvColumn27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn27.Width = 80;
            // 
            // olvColumn28
            // 
            this.olvColumn28.AspectName = "BirthDate";
            this.olvColumn28.AspectToStringFormat = "{0:D}";
            this.olvColumn28.FillsFreeSpace = true;
            this.olvColumn28.GroupWithItemCountFormat = "{0} has {1} birthdays";
            this.olvColumn28.GroupWithItemCountSingularFormat = "{0} has only {1} birthday";
            this.olvColumn28.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn28.IsTileViewColumn = true;
            this.olvColumn28.Text = "Birthday";
            this.olvColumn28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn28.Width = 111;
            // 
            // olvColumn29
            // 
            this.olvColumn29.AspectName = "GetRate";
            this.olvColumn29.AspectToStringFormat = "{0:C}";
            this.olvColumn29.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn29.IsTileViewColumn = true;
            this.olvColumn29.Text = "Hourly Rate";
            this.olvColumn29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn29.Width = 71;
            // 
            // olvColumn31
            // 
            this.olvColumn31.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn31.IsEditable = false;
            this.olvColumn31.Text = "Salary";
            this.olvColumn31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn31.Width = 55;
            // 
            // olvColumn32
            // 
            this.olvColumn32.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn32.IsEditable = false;
            this.olvColumn32.Text = "Days Since Birth";
            this.olvColumn32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn32.Width = 81;
            // 
            // olvColumn33
            // 
            this.olvColumn33.AspectName = "CanTellJokes";
            this.olvColumn33.CheckBoxes = true;
            this.olvColumn33.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn33.Text = "Tells Jokes?";
            this.olvColumn33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn33.Width = 74;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(0, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(200, 100);
            this.tabPage5.TabIndex = 0;
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(228, 479);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(50, 13);
            this.label37.TabIndex = 15;
            this.label37.Text = "Hot Item:";
            // 
            // comboBox14
            // 
            this.comboBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "None",
            "Text Color",
            "Border",
            "Translucent",
            "Lightbox"});
            this.comboBox14.Location = new System.Drawing.Point(279, 474);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(86, 21);
            this.comboBox14.TabIndex = 16;
            // 
            // checkBox19
            // 
            this.checkBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox19.Location = new System.Drawing.Point(153, 477);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(65, 19);
            this.checkBox19.TabIndex = 14;
            this.checkBox19.Text = "Tooltips";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // buttonSaveState
            // 
            this.buttonSaveState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveState.Location = new System.Drawing.Point(548, 474);
            this.buttonSaveState.Name = "buttonSaveState";
            this.buttonSaveState.Size = new System.Drawing.Size(87, 23);
            this.buttonSaveState.TabIndex = 10;
            this.buttonSaveState.Text = "Save State";
            this.buttonSaveState.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreState
            // 
            this.buttonRestoreState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestoreState.Enabled = false;
            this.buttonRestoreState.Location = new System.Drawing.Point(641, 474);
            this.buttonRestoreState.Name = "buttonRestoreState";
            this.buttonRestoreState.Size = new System.Drawing.Size(83, 23);
            this.buttonRestoreState.TabIndex = 11;
            this.buttonRestoreState.Text = "Restore State";
            this.buttonRestoreState.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Location = new System.Drawing.Point(730, 474);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = "&Columns...";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.Location = new System.Drawing.Point(730, 55);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.Text = "&Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(649, 55);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "&Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolderPath.Location = new System.Drawing.Point(56, 57);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(579, 20);
            this.textBoxFolderPath.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "&Folder:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "View:";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Small Icon",
            "Large Icon",
            "List",
            "Tile",
            "Details"});
            this.comboBox4.Location = new System.Drawing.Point(405, 474);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(86, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // checkBox10
            // 
            this.checkBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(67, 477);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(90, 19);
            this.checkBox10.TabIndex = 7;
            this.checkBox10.Text = "Owner &Draw";
            this.toolTip1.SetToolTip(this.checkBox10, "Should the list use its custom draw facilities (looks shinier)");
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox12.Location = new System.Drawing.Point(6, 474);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(104, 24);
            this.checkBox12.TabIndex = 5;
            this.checkBox12.Text = "&Groups";
            this.toolTip1.SetToolTip(this.checkBox12, "Cluster the rows into groups");
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(799, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // olvFiles
            // 
            this.olvFiles.AllColumns.Add(this.olvColumnFileName);
            this.olvFiles.AllColumns.Add(this.olvColumnFileCreated);
            this.olvFiles.AllColumns.Add(this.olvColumnFileModified);
            this.olvFiles.AllColumns.Add(this.olvColumnSize);
            this.olvFiles.AllColumns.Add(this.olvColumnFileType);
            this.olvFiles.AllColumns.Add(this.olvColumnAttributes);
            this.olvFiles.AllColumns.Add(this.treeColumnFileExtension);
            this.olvFiles.AllowColumnReorder = true;
            this.olvFiles.AllowDrop = true;
            this.olvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnFileName,
            this.olvColumnFileCreated,
            this.olvColumnFileModified,
            this.olvColumnSize,
            this.olvColumnFileType,
            this.olvColumnAttributes});
            this.olvFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFiles.EmptyListMsg = "This folder is completely empty!";
            this.olvFiles.EmptyListMsgFont = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvFiles.HideSelection = false;
            this.olvFiles.Location = new System.Drawing.Point(6, 83);
            this.olvFiles.Name = "olvFiles";
            this.olvFiles.OwnerDraw = true;
            this.olvFiles.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvFiles.ShowCommandMenuOnRightClick = true;
            this.olvFiles.ShowGroups = false;
            this.olvFiles.ShowItemToolTips = true;
            this.olvFiles.Size = new System.Drawing.Size(799, 385);
            this.olvFiles.TabIndex = 13;
            this.olvFiles.UseCompatibleStateImageBehavior = false;
            this.olvFiles.UseFilterIndicator = true;
            this.olvFiles.UseFiltering = true;
            this.olvFiles.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnFileName
            // 
            this.olvColumnFileName.AspectName = "Name";
            this.olvColumnFileName.IsTileViewColumn = true;
            this.olvColumnFileName.Text = "Name";
            this.olvColumnFileName.UseInitialLetterForGroup = true;
            this.olvColumnFileName.Width = 180;
            // 
            // olvColumnFileCreated
            // 
            this.olvColumnFileCreated.AspectName = "CreationTime";
            this.olvColumnFileCreated.DisplayIndex = 4;
            this.olvColumnFileCreated.Text = "Created";
            this.olvColumnFileCreated.Width = 131;
            // 
            // olvColumnFileModified
            // 
            this.olvColumnFileModified.AspectName = "LastWriteTime";
            this.olvColumnFileModified.DisplayIndex = 1;
            this.olvColumnFileModified.IsTileViewColumn = true;
            this.olvColumnFileModified.Text = "Modified";
            this.olvColumnFileModified.Width = 127;
            // 
            // olvColumnSize
            // 
            this.olvColumnSize.AspectName = "Extension";
            this.olvColumnSize.DisplayIndex = 2;
            this.olvColumnSize.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumnSize.Text = "Size";
            this.olvColumnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumnSize.Width = 80;
            // 
            // olvColumnFileType
            // 
            this.olvColumnFileType.DisplayIndex = 3;
            this.olvColumnFileType.IsTileViewColumn = true;
            this.olvColumnFileType.Text = "File Type";
            this.olvColumnFileType.Width = 148;
            // 
            // olvColumnAttributes
            // 
            this.olvColumnAttributes.FillsFreeSpace = true;
            this.olvColumnAttributes.IsEditable = false;
            this.olvColumnAttributes.MinimumWidth = 20;
            this.olvColumnAttributes.Text = "Attributes";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(811, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DataSet Example";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.textBoxFilterData);
            this.groupBox13.Location = new System.Drawing.Point(688, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(117, 44);
            this.groupBox13.TabIndex = 18;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Filter";
            // 
            // textBoxFilterData
            // 
            this.textBoxFilterData.Location = new System.Drawing.Point(7, 20);
            this.textBoxFilterData.Name = "textBoxFilterData";
            this.textBoxFilterData.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterData.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.comboBox7);
            this.groupBox3.Controls.Add(this.checkBoxPause);
            this.groupBox3.Controls.Add(this.rowHeightUpDown);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.olvData);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Location = new System.Drawing.Point(6, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 234);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data List View";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(689, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "&Editable:";
            // 
            // comboBox7
            // 
            this.comboBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "No",
            "Single Click",
            "Double Click",
            "F2 Only"});
            this.comboBox7.Location = new System.Drawing.Point(689, 148);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(104, 21);
            this.comboBox7.TabIndex = 8;
            // 
            // checkBoxPause
            // 
            this.checkBoxPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPause.Checked = true;
            this.checkBoxPause.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPause.Location = new System.Drawing.Point(689, 73);
            this.checkBoxPause.Name = "checkBoxPause";
            this.checkBoxPause.Size = new System.Drawing.Size(113, 19);
            this.checkBoxPause.TabIndex = 4;
            this.checkBoxPause.Text = "Pause &Animations";
            this.checkBoxPause.UseVisualStyleBackColor = true;
            // 
            // rowHeightUpDown
            // 
            this.rowHeightUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rowHeightUpDown.Location = new System.Drawing.Point(689, 187);
            this.rowHeightUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.rowHeightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.rowHeightUpDown.Name = "rowHeightUpDown";
            this.rowHeightUpDown.Size = new System.Drawing.Size(101, 20);
            this.rowHeightUpDown.TabIndex = 10;
            this.rowHeightUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Row &Height:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "&View:";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Small Icon",
            "Large Icon",
            "List",
            "Tile",
            "Details"});
            this.comboBox3.Location = new System.Drawing.Point(689, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(104, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(689, 55);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 19);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Owner &Draw";
            this.toolTip1.SetToolTip(this.checkBox5, "Should the list use its custom draw facilities (looks shinier)");
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // olvData
            // 
            this.olvData.AllColumns.Add(this.olvColumn1);
            this.olvData.AllColumns.Add(this.olvColumn2);
            this.olvData.AllColumns.Add(this.olvColumn3);
            this.olvData.AllColumns.Add(this.salaryColumn);
            this.olvData.AllColumns.Add(this.heightColumn);
            this.olvData.AllColumns.Add(this.olvColumn42);
            this.olvData.AllColumns.Add(this.olvColumnGif);
            this.olvData.AllColumns.Add(this.olvColumnFiller);
            this.olvData.AllowColumnReorder = true;
            this.olvData.AllowDrop = true;
            this.olvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvData.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.salaryColumn,
            this.heightColumn,
            this.olvColumn42,
            this.olvColumnGif,
            this.olvColumnFiller});
            this.olvData.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvData.DataSource = null;
            this.olvData.EmptyListMsg = "Add rows to the above table to see them here";
            this.olvData.EmptyListMsgFont = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvData.FullRowSelect = true;
            this.olvData.GridLines = true;
            this.olvData.GroupWithItemCountFormat = "{0} ({1} people)";
            this.olvData.GroupWithItemCountSingularFormat = "{0} (1 person)";
            this.olvData.HeaderFormatStyle = this.headerFormatStyleData;
            this.olvData.HideSelection = false;
            this.olvData.HighlightBackgroundColor = System.Drawing.Color.Crimson;
            this.olvData.HighlightForegroundColor = System.Drawing.Color.DarkGreen;
            this.olvData.Location = new System.Drawing.Point(6, 19);
            this.olvData.Name = "olvData";
            this.olvData.OwnerDraw = true;
            this.olvData.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvData.ShowCommandMenuOnRightClick = true;
            this.olvData.ShowGroups = false;
            this.olvData.ShowImagesOnSubItems = true;
            this.olvData.ShowItemToolTips = true;
            this.olvData.Size = new System.Drawing.Size(677, 209);
            this.olvData.TabIndex = 0;
            this.olvData.UseCellFormatEvents = true;
            this.olvData.UseCompatibleStateImageBehavior = false;
            this.olvData.UseFilterIndicator = true;
            this.olvData.UseFiltering = true;
            this.olvData.UseHotItem = true;
            this.olvData.UseTranslucentHotItem = true;
            this.olvData.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.IsTileViewColumn = true;
            this.olvColumn1.Renderer = this.highlightTextRenderer1;
            this.olvColumn1.Text = "Name";
            this.olvColumn1.UseInitialLetterForGroup = true;
            this.olvColumn1.Width = 112;
            // 
            // highlightTextRenderer1
            // 
            this.highlightTextRenderer1.CanWrap = true;
            this.highlightTextRenderer1.UseGdiTextRendering = false;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Company";
            this.olvColumn2.IsTileViewColumn = true;
            this.olvColumn2.Text = "Company";
            this.olvColumn2.Width = 73;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Occupation";
            this.olvColumn3.IsTileViewColumn = true;
            this.olvColumn3.Text = "Occupation";
            this.olvColumn3.Width = 94;
            // 
            // salaryColumn
            // 
            this.salaryColumn.AspectName = "Salary";
            this.salaryColumn.AspectToStringFormat = "{0:C}";
            this.salaryColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.salaryColumn.Renderer = this.salaryRenderer;
            this.salaryColumn.Text = "Salary";
            this.salaryColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // salaryRenderer
            // 
            this.salaryRenderer.ImageName = "tick";
            this.salaryRenderer.MaximumValue = 500000;
            this.salaryRenderer.MaxNumberImages = 5;
            this.salaryRenderer.MinimumValue = 10000;
            // 
            // heightColumn
            // 
            this.heightColumn.AspectName = "Height";
            this.heightColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightColumn.Renderer = this.heightRenderer;
            this.heightColumn.Text = "Height (m)";
            this.heightColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightColumn.Width = 56;
            // 
            // heightRenderer
            // 
            this.heightRenderer.BackgroundColor = System.Drawing.Color.Green;
            this.heightRenderer.MaximumValue = 2D;
            this.heightRenderer.UseStandardBar = false;
            // 
            // olvColumn42
            // 
            this.olvColumn42.AspectName = "TellsJokes";
            this.olvColumn42.CheckBoxes = true;
            this.olvColumn42.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn42.Text = "Joker?";
            this.olvColumn42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn42.Width = 48;
            // 
            // olvColumnGif
            // 
            this.olvColumnGif.AspectName = "GifFileName";
            this.olvColumnGif.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnGif.Renderer = this.imageRenderer1;
            this.olvColumnGif.Text = "Animated GIF";
            this.olvColumnGif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnGif.Width = 96;
            // 
            // olvColumnFiller
            // 
            this.olvColumnFiller.FillsFreeSpace = true;
            this.olvColumnFiller.Text = "";
            // 
            // headerFormatStyleData
            // 
            headerStateStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            headerStateStyle1.ForeColor = System.Drawing.Color.White;
            this.headerFormatStyleData.Hot = headerStateStyle1;
            headerStateStyle2.BackColor = System.Drawing.Color.Black;
            headerStateStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            this.headerFormatStyleData.Normal = headerStateStyle2;
            headerStateStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            headerStateStyle3.ForeColor = System.Drawing.Color.White;
            headerStateStyle3.FrameColor = System.Drawing.Color.WhiteSmoke;
            headerStateStyle3.FrameWidth = 2F;
            this.headerFormatStyleData.Pressed = headerStateStyle3;
            // 
            // checkBox7
            // 
            this.checkBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox7.Location = new System.Drawing.Point(689, 18);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(104, 20);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.Text = "Show &Groups";
            this.toolTip1.SetToolTip(this.checkBox7, "Cluster the rows into groups");
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox8.Location = new System.Drawing.Point(689, 37);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(113, 19);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Text = "Show Item &Counts";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(6, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 201);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Data Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(670, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(689, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "&Reset Data";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(676, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(829, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.Location = new System.Drawing.Point(483, 456);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(87, 23);
            this.button20.TabIndex = 10;
            this.button20.Text = "Save State";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.Enabled = false;
            this.button21.Location = new System.Drawing.Point(576, 456);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(83, 23);
            this.button21.TabIndex = 11;
            this.button21.Text = "Restore State";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.Location = new System.Drawing.Point(665, 456);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(115, 23);
            this.button22.TabIndex = 12;
            this.button22.Text = "&Choose Columns...";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button23.Location = new System.Drawing.Point(705, 55);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 3;
            this.button23.Text = "&Up";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.Location = new System.Drawing.Point(624, 55);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 2;
            this.button24.Text = "&Go";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(56, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "&Folder:";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(303, 461);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 13);
            this.label28.TabIndex = 8;
            this.label28.Text = "View:";
            // 
            // comboBox11
            // 
            this.comboBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "Small Icon",
            "Large Icon",
            "List",
            "Tile",
            "Details"});
            this.comboBox11.Location = new System.Drawing.Point(337, 456);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 21);
            this.comboBox11.TabIndex = 9;
            // 
            // checkBox14
            // 
            this.checkBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox14.Location = new System.Drawing.Point(218, 459);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(90, 19);
            this.checkBox14.TabIndex = 7;
            this.checkBox14.Text = "Owner &Draw";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox16.Location = new System.Drawing.Point(101, 456);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(111, 24);
            this.checkBox16.TabIndex = 6;
            this.checkBox16.Text = "Show Item &Count";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox17.Location = new System.Drawing.Point(6, 456);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(104, 24);
            this.checkBox17.TabIndex = 5;
            this.checkBox17.Text = "Show &Groups";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Location = new System.Drawing.Point(6, 6);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(774, 46);
            this.label29.TabIndex = 6;
            this.label29.Text = resources.GetString("label29.Text");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOfCommandsToolStripMenuItem,
            this.appropriateToTheClickedFileToolStripMenuItem,
            this.whichOnlyAppearsToolStripMenuItem,
            this.whenYouClickOnColumn0ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(231, 92);
            // 
            // menuOfCommandsToolStripMenuItem
            // 
            this.menuOfCommandsToolStripMenuItem.Name = "menuOfCommandsToolStripMenuItem";
            this.menuOfCommandsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.menuOfCommandsToolStripMenuItem.Text = "Menu of commands";
            // 
            // appropriateToTheClickedFileToolStripMenuItem
            // 
            this.appropriateToTheClickedFileToolStripMenuItem.Name = "appropriateToTheClickedFileToolStripMenuItem";
            this.appropriateToTheClickedFileToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.appropriateToTheClickedFileToolStripMenuItem.Text = "Appropriate to the clicked file";
            // 
            // whichOnlyAppearsToolStripMenuItem
            // 
            this.whichOnlyAppearsToolStripMenuItem.Name = "whichOnlyAppearsToolStripMenuItem";
            this.whichOnlyAppearsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.whichOnlyAppearsToolStripMenuItem.Text = "Which only appears";
            // 
            // whenYouClickOnColumn0ToolStripMenuItem
            // 
            this.whenYouClickOnColumn0ToolStripMenuItem.Name = "whenYouClickOnColumn0ToolStripMenuItem";
            this.whenYouClickOnColumn0ToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.whenYouClickOnColumn0ToolStripMenuItem.Text = "When you click on column 0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // hyperlinkStyle1
            // 
            cellStyle1.Font = null;
            cellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.hyperlinkStyle1.Normal = cellStyle1;
            cellStyle2.Font = null;
            cellStyle2.FontStyle = System.Drawing.FontStyle.Underline;
            this.hyperlinkStyle1.Over = cellStyle2;
            this.hyperlinkStyle1.OverCursor = System.Windows.Forms.Cursors.Hand;
            cellStyle3.Font = null;
            cellStyle3.ForeColor = System.Drawing.Color.Purple;
            this.hyperlinkStyle1.Visited = cellStyle3;
            // 
            // textWrappingRenderer
            // 
            this.textWrappingRenderer.CanWrap = true;
            this.textWrappingRenderer.UseGdiTextRendering = false;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn35);
            this.objectListView1.AllColumns.Add(this.olvColumn36);
            this.objectListView1.AllColumns.Add(this.olvColumn37);
            this.objectListView1.AllColumns.Add(this.olvColumn38);
            this.objectListView1.AllColumns.Add(this.olvColumn39);
            this.objectListView1.AllColumns.Add(this.olvColumn40);
            this.objectListView1.AllColumns.Add(this.treeColumnFileExtension);
            this.objectListView1.AllowColumnReorder = true;
            this.objectListView1.AllowDrop = true;
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn35,
            this.olvColumn36,
            this.olvColumn37,
            this.olvColumn38,
            this.olvColumn39,
            this.olvColumn40});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.EmptyListMsg = "This folder is completely empty!";
            this.objectListView1.EmptyListMsgFont = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(6, 83);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.OwnerDraw = true;
            this.objectListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.objectListView1.ShowCommandMenuOnRightClick = true;
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(774, 367);
            this.objectListView1.TabIndex = 13;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseHotItem = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn35
            // 
            this.olvColumn35.AspectName = "Name";
            this.olvColumn35.IsTileViewColumn = true;
            this.olvColumn35.Text = "Name";
            this.olvColumn35.UseInitialLetterForGroup = true;
            this.olvColumn35.Width = 180;
            // 
            // olvColumn36
            // 
            this.olvColumn36.AspectName = "CreationTime";
            this.olvColumn36.DisplayIndex = 4;
            this.olvColumn36.Text = "Created";
            this.olvColumn36.Width = 131;
            // 
            // olvColumn37
            // 
            this.olvColumn37.AspectName = "LastWriteTime";
            this.olvColumn37.DisplayIndex = 1;
            this.olvColumn37.IsTileViewColumn = true;
            this.olvColumn37.Text = "Modified";
            this.olvColumn37.Width = 145;
            // 
            // olvColumn38
            // 
            this.olvColumn38.AspectName = "Extension";
            this.olvColumn38.DisplayIndex = 2;
            this.olvColumn38.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn38.Text = "Size";
            this.olvColumn38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn38.Width = 80;
            // 
            // olvColumn39
            // 
            this.olvColumn39.DisplayIndex = 3;
            this.olvColumn39.IsTileViewColumn = true;
            this.olvColumn39.Text = "File Type";
            this.olvColumn39.Width = 148;
            // 
            // olvColumn40
            // 
            this.olvColumn40.FillsFreeSpace = true;
            this.olvColumn40.IsEditable = false;
            this.olvColumn40.MinimumWidth = 20;
            this.olvColumn40.Text = "Attributes";
            // 
            // olvColumn21
            // 
            this.olvColumn21.AspectName = "StartTime";
            this.olvColumn21.DisplayIndex = 2;
            this.olvColumn21.IsVisible = false;
            this.olvColumn21.Text = "Start Time";
            // 
            // olvColumn22
            // 
            this.olvColumn22.AspectName = "Threads.Count";
            this.olvColumn22.DisplayIndex = 3;
            this.olvColumn22.IsVisible = false;
            this.olvColumn22.Text = "Thread Count";
            // 
            // olvColumn23
            // 
            this.olvColumn23.AspectName = "TotalProcessorTime";
            this.olvColumn23.DisplayIndex = 4;
            this.olvColumn23.IsVisible = false;
            this.olvColumn23.Text = "Processor Time";
            // 
            // olvColumn30
            // 
            this.olvColumn30.AspectName = "PriorityClass";
            this.olvColumn30.DisplayIndex = 9;
            this.olvColumn30.IsVisible = false;
            this.olvColumn30.Text = "Priority Class";
            // 
            // olvColumn24
            // 
            this.olvColumn24.DisplayIndex = 5;
            this.olvColumn24.IsVisible = false;
            // 
            // olvColumn25
            // 
            this.olvColumn25.DisplayIndex = 6;
            this.olvColumn25.IsVisible = false;
            // 
            // olvColumn20
            // 
            this.olvColumn20.DisplayIndex = 2;
            this.olvColumn20.IsVisible = false;
            // 
            // olvColumn17
            // 
            this.olvColumn17.DisplayIndex = 0;
            this.olvColumn17.Text = "Zero";
            // 
            // olvColumn13
            // 
            this.olvColumn13.DisplayIndex = 1;
            this.olvColumn13.Text = "Two";
            // 
            // olvColumn14
            // 
            this.olvColumn14.DisplayIndex = 2;
            this.olvColumn14.Text = "Three";
            // 
            // olvColumn15
            // 
            this.olvColumn15.DisplayIndex = 3;
            this.olvColumn15.Text = "Four";
            // 
            // olvColumn6
            // 
            this.olvColumn6.DisplayIndex = 0;
            // 
            // olvColumn11
            // 
            this.olvColumn11.DisplayIndex = 1;
            this.olvColumn11.IsVisible = false;
            this.olvColumn11.Text = "One";
            // 
            // olvColumn16
            // 
            this.olvColumn16.DisplayIndex = 4;
            this.olvColumn16.IsVisible = false;
            this.olvColumn16.Text = "Five";
            // 
            // groupImageList
            // 
            this.groupImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("groupImageList.ImageStream")));
            this.groupImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.groupImageList.Images.SetKeyName(0, "beef");
            this.groupImageList.Images.SetKeyName(1, "chef");
            this.groupImageList.Images.SetKeyName(2, "toast");
            this.groupImageList.Images.SetKeyName(3, "hamburger");
            this.groupImageList.Images.SetKeyName(4, "not");
            // 
            // tabDescribedTasks
            // 
            this.tabDescribedTasks.Controls.Add(this.tabDescribedTask1);
            this.tabDescribedTasks.Location = new System.Drawing.Point(4, 22);
            this.tabDescribedTasks.Name = "tabDescribedTasks";
            this.tabDescribedTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabDescribedTasks.Size = new System.Drawing.Size(811, 503);
            this.tabDescribedTasks.TabIndex = 18;
            this.tabDescribedTasks.Text = "Tasks";
            this.tabDescribedTasks.UseVisualStyleBackColor = true;
            // 
            // tabDescribedTask1
            // 
            this.tabDescribedTask1.Location = new System.Drawing.Point(0, 0);
            this.tabDescribedTask1.Name = "tabDescribedTask1";
            this.tabDescribedTask1.Size = new System.Drawing.Size(804, 499);
            this.tabDescribedTask1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "ObjectListView Demo";
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPageFileExplorer.ResumeLayout(false);
            this.tabPageFastList.ResumeLayout(false);
            this.tabPageTreeListView.ResumeLayout(false);
            this.tabPageDataTreeListView.ResumeLayout(false);
            this.tabPagePrinting.ResumeLayout(false);
            this.tabPageDragAndDrop.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvGeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvFroods)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.tabDescribedTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private BrightIdeasSoftware.ListViewPrinter listViewPrinter1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BrightIdeasSoftware.OLVColumn yearOfBirthColumn;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox8;
		private GroupBox groupBox1;
		private BrightIdeasSoftware.DataListView olvData;
		private BrightIdeasSoftware.OLVColumn salaryColumn;
		private BrightIdeasSoftware.OLVColumn olvColumn2;
		private BrightIdeasSoftware.OLVColumn olvColumn3;
		private BrightIdeasSoftware.OLVColumn olvColumn1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
        private TabSimpleExample tabSimple;
        private TabComplexExample tabComplex;
        private TabDataSet tabDataSet;

        private System.Windows.Forms.TabControl tabControl1;
        private BrightIdeasSoftware.OLVColumn heightColumn;
        private Label label8;
        private ComboBox comboBox3;
        private OLVColumn olvColumnGif;
        private NumericUpDown rowHeightUpDown;
        private Label label11;
        private CheckBox checkBoxPause;
        private TabPage tabPage6;
        private Label label22;
        private ComboBox comboBox7;
        private OLVColumn olvColumn6;
        private OLVColumn olvColumn17;
        private OLVColumn olvColumn13;
        private OLVColumn olvColumn14;
        private OLVColumn olvColumn15;
        private OLVColumn olvColumn11;
        private OLVColumn olvColumn16;
        private OLVColumn olvColumn20;
        private OLVColumn olvColumn24;
        private OLVColumn olvColumn25;
        private OLVColumn treeColumnFileExtension;
        private OLVColumn olvColumn21;
        private OLVColumn olvColumn22;
        private OLVColumn olvColumn23;
        private OLVColumn olvColumn30;
        private TabPage tabPage7;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem command1ToolStripMenuItem;
        private ToolStripMenuItem command2ToolStripMenuItem;
        private ToolStripMenuItem command3ToolStripMenuItem;
        private ToolStripMenuItem appearOnTheColumnHeadersToolStripMenuItem;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private TextBox textBox1;
        private Label label27;
        private Label label28;
        private ComboBox comboBox11;
        private CheckBox checkBox14;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private Label label29;
        private ObjectListView objectListView1;
        private OLVColumn olvColumn35;
        private OLVColumn olvColumn36;
        private OLVColumn olvColumn37;
        private OLVColumn olvColumn38;
        private OLVColumn olvColumn39;
        private OLVColumn olvColumn40;
        private HotItemStyle hotItemStyle1;
        private BarRenderer heightRenderer;
        private ImageRenderer imageRenderer1;
        private MultiImageRenderer salaryRenderer;
        private OLVColumn olvColumn42;
        private MultiImageRenderer cookingSkillRenderer;
        private TabPage tabPage8;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem menuOfCommandsToolStripMenuItem;
        private ToolStripMenuItem appropriateToTheClickedFileToolStripMenuItem;
        private ToolStripMenuItem whichOnlyAppearsToolStripMenuItem;
        private ToolStripMenuItem whenYouClickOnColumn0ToolStripMenuItem;
        private HotItemStyle hotItemStyle2;
        private HyperlinkStyle hyperlinkStyle1;
        private ImageRenderer imageRenderer2;
        private ImageList imageList3;
        private ToolTip toolTip1;
        private BaseRenderer textWrappingRenderer;
        private HotItemStyle hotItemStyle3;
        private TextBox textBox2;
        private GroupBox groupBox13;
        private TextBox textBoxFilterData;
        private HighlightTextRenderer highlightTextRenderer1;
        private HeaderFormatStyle headerFormatStyleData;
        private OLVColumn olvColumnFiller;
        public ToolStripStatusLabel toolStripStatusLabel3;
        public ToolStripStatusLabel toolStripStatusLabel1;
        private TabPage tabPage11;
        private ImageList groupImageList;
        private Label label37;
        private ComboBox comboBox14;
        private CheckBox checkBox19;
        private Button buttonSaveState;
        private Button buttonRestoreState;
        private Button button13;
        private Button buttonUp;
        private Button buttonGo;
        private TextBox textBoxFolderPath;
        private Label label10;
        private Label label9;
        private ComboBox comboBox4;
        private CheckBox checkBox10;
        private CheckBox checkBox12;
        private Label label5;
        private ObjectListView olvFiles;
        private OLVColumn olvColumnFileName;
        private OLVColumn olvColumnFileCreated;
        private OLVColumn olvColumnFileModified;
        private OLVColumn olvColumnSize;
        private OLVColumn olvColumnFileType;
        private OLVColumn olvColumnAttributes;
        private TabPage tabPageFileExplorer;
        private TabFileExplorer tabFileExplorer1;
        private Label label24;
        private CheckBox checkBox2;
        private GroupBox groupBox11;
        private ComboBox comboBox16;
        private TextBox textBoxFilterFast;
        private CheckBox checkBox20;
        private Button button19;
        private Button button18;
        private Label label26;
        private ComboBox comboBox9;
        private Label label25;
        private ComboBox comboBox10;
        private CheckBox checkBox13;
        private Button button15;
        private Button button14;
        private FastObjectListView olvFast;
        private OLVColumn olvColumn18;
        private OLVColumn olvColumn19;
        private OLVColumn olvColumn26;
        private OLVColumn olvColumn27;
        private OLVColumn olvColumn28;
        private OLVColumn olvColumn29;
        private OLVColumn olvColumn31;
        private OLVColumn olvColumn32;
        private OLVColumn olvColumn33;
        private TabPage tabPageFastList;
        private TabFastList tabFastList1;
        private TabPage tabPageTreeListView;
        private TabTreeListView tabTreeListView1;
        private TabPage tabPageDataTreeListView;
        private TabDataTreeListView tabDataTreeListView1;
        private GroupBox groupBox5;
        private NumericUpDown numericUpDown2;
        private Label label19;
        private NumericUpDown numericUpDown1;
        private Label label18;
        private CheckBox cbCellGridLines;
        private Label label17;
        private RadioButton rbStyleTooMuch;
        private CheckBox cbPrintOnlySelection;
        private RadioButton rbStyleModern;
        private CheckBox cbShrinkToFit;
        private RadioButton rbStyleMinimal;
        private CheckBox cbIncludeImages;
        private GroupBox groupBox4;
        private TextBox tbFooter;
        private Label label15;
        private TextBox tbHeader;
        private Label label16;
        private TextBox tbWatermark;
        private Label label14;
        private TextBox tbTitle;
        private Label label13;
        private GroupBox groupBox2;
        private RadioButton rbShowVirtual;
        private RadioButton rbShowFileExplorer;
        private RadioButton rbShowDataset;
        private RadioButton rbShowComplex;
        private RadioButton rbShowSimple;
        private Label label12;
        private Button button12;
        private Button button11;
        private Button button10;
        private PrintPreviewControl printPreviewControl1;
        private TabPage tabPagePrinting;
        private TabPrinting tabPrinting1;
        private CheckBox checkBox22;
        private CheckBox checkBox21;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label34;
        private Label label35;
        private ObjectListView olvGeeks;
        private OLVColumn olvColumn43;
        private OLVColumn olvColumn44;
        private OLVColumn olvColumn45;
        private OLVColumn olvColumn46;
        private OLVColumn olvColumn47;
        private OLVColumn olvColumn48;
        private OLVColumn olvColumn49;
        private OLVColumn olvColumn50;
        private OLVColumn olvColumn51;
        private ObjectListView olvFroods;
        private OLVColumn olvColumn52;
        private OLVColumn olvColumn53;
        private OLVColumn olvColumn54;
        private OLVColumn olvColumn55;
        private OLVColumn olvColumn56;
        private OLVColumn olvColumn57;
        private OLVColumn olvColumn58;
        private OLVColumn olvColumn59;
        private OLVColumn olvColumn60;
        private Label label33;
        private ComboBox comboBox13;
        private Label label31;
        private ComboBox comboBox12;
        private Label label30;
        private TabPage tabPageDragAndDrop;
        private TabDragAndDrop tabDragAndDrop1;
        private TabPage tabDescribedTasks;
        private TabDescribedTask tabDescribedTask1;

	}
}
