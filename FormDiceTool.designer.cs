namespace DiceTool
{
    partial class FormDiceTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiceTool));
            this.Button4 = new System.Windows.Forms.Button();
            this.ContextMenuStripDiceTool = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripComboBoxDiceTool = new System.Windows.Forms.ToolStripComboBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button20 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.ListViewRolls = new System.Windows.Forms.ListView();
            this.ColumnTicks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDiceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDiceValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageListDiceTool = new System.Windows.Forms.ImageList(this.components);
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSpace = new System.Windows.Forms.Button();
            this.TextBoxSpace = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.FileDialogOpenDiceTool = new System.Windows.Forms.OpenFileDialog();
            this.FileDialogSaveDiceTool = new System.Windows.Forms.SaveFileDialog();
            this.WorkerOpenDiceTool = new System.ComponentModel.BackgroundWorker();
            this.WorkerSaveDiceTool = new System.ComponentModel.BackgroundWorker();
            this.ToolTipDiceTool = new System.Windows.Forms.ToolTip(this.components);
            this.TableLayoutDiceTool = new System.Windows.Forms.TableLayoutPanel();
            this.ContextMenuStripDiceTool.SuspendLayout();
            this.TableLayoutDiceTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutDiceTool.SetColumnSpan(this.Button4, 2);
            this.Button4.ContextMenuStrip = this.ContextMenuStripDiceTool;
            this.Button4.Location = new System.Drawing.Point(79, 3);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(76, 53);
            this.Button4.TabIndex = 1;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.ButtonRollDice_Click);
            // 
            // ContextMenuStripDiceTool
            // 
            this.ContextMenuStripDiceTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripComboBoxDiceTool});
            this.ContextMenuStripDiceTool.Name = "ContextMenuStripDiceTool";
            this.ContextMenuStripDiceTool.Size = new System.Drawing.Size(182, 31);
            // 
            // ToolStripComboBoxDiceTool
            // 
            this.ToolStripComboBoxDiceTool.Name = "ToolStripComboBoxDiceTool";
            this.ToolStripComboBoxDiceTool.Size = new System.Drawing.Size(121, 23);
            // 
            // Button6
            // 
            this.Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button6.ContextMenuStrip = this.ContextMenuStripDiceTool;
            this.Button6.Location = new System.Drawing.Point(161, 3);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(70, 53);
            this.Button6.TabIndex = 2;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.ButtonRollDice_Click);
            // 
            // Button8
            // 
            this.Button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button8.ContextMenuStrip = this.ContextMenuStripDiceTool;
            this.Button8.Location = new System.Drawing.Point(237, 3);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(70, 53);
            this.Button8.TabIndex = 3;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.ButtonRollDice_Click);
            // 
            // Button10
            // 
            this.Button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button10.ContextMenuStrip = this.ContextMenuStripDiceTool;
            this.Button10.Location = new System.Drawing.Point(313, 3);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(70, 53);
            this.Button10.TabIndex = 4;
            this.Button10.Text = "10";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.ButtonRollDice_Click);
            // 
            // Button20
            // 
            this.Button20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button20.ContextMenuStrip = this.ContextMenuStripDiceTool;
            this.Button20.Location = new System.Drawing.Point(389, 3);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(73, 53);
            this.Button20.TabIndex = 5;
            this.Button20.Text = "20";
            this.Button20.UseVisualStyleBackColor = true;
            this.Button20.Click += new System.EventHandler(this.ButtonRollDice_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.ContextMenuStrip = this.ContextMenuStripDiceTool;
            this.Button2.Location = new System.Drawing.Point(3, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(70, 53);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.ButtonRollDice_Click);
            // 
            // ListViewRolls
            // 
            this.ListViewRolls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewRolls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTicks,
            this.ColumnDateTime,
            this.ColumnDiceType,
            this.ColumnDiceValue,
            this.ColumnComment});
            this.TableLayoutDiceTool.SetColumnSpan(this.ListViewRolls, 7);
            this.ListViewRolls.FullRowSelect = true;
            this.ListViewRolls.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewRolls.Location = new System.Drawing.Point(3, 62);
            this.ListViewRolls.Name = "ListViewRolls";
            this.ListViewRolls.Size = new System.Drawing.Size(459, 202);
            this.ListViewRolls.SmallImageList = this.ImageListDiceTool;
            this.ListViewRolls.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.ListViewRolls.TabIndex = 7;
            this.ListViewRolls.UseCompatibleStateImageBehavior = false;
            this.ListViewRolls.View = System.Windows.Forms.View.Details;
            // 
            // ColumnTicks
            // 
            this.ColumnTicks.Text = "";
            this.ColumnTicks.Width = 25;
            // 
            // ColumnDateTime
            // 
            this.ColumnDateTime.Text = "Moment";
            this.ColumnDateTime.Width = 115;
            // 
            // ColumnDiceType
            // 
            this.ColumnDiceType.Text = "Dice";
            this.ColumnDiceType.Width = 40;
            // 
            // ColumnDiceValue
            // 
            this.ColumnDiceValue.Text = "Roll";
            this.ColumnDiceValue.Width = 40;
            // 
            // ColumnComment
            // 
            this.ColumnComment.Text = "Comment";
            this.ColumnComment.Width = 210;
            // 
            // ImageListDiceTool
            // 
            this.ImageListDiceTool.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListDiceTool.ImageStream")));
            this.ImageListDiceTool.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListDiceTool.Images.SetKeyName(0, "emoticon-0106-crying.gif");
            this.ImageListDiceTool.Images.SetKeyName(1, "emoticon-0101-sadsmile.gif");
            this.ImageListDiceTool.Images.SetKeyName(2, "emoticon-0108-speechless.gif");
            this.ImageListDiceTool.Images.SetKeyName(3, "emoticon-0100-smile.gif");
            this.ImageListDiceTool.Images.SetKeyName(4, "emoticon-0103-cool.gif");
            this.ImageListDiceTool.Images.SetKeyName(5, "information.png");
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClear.Location = new System.Drawing.Point(3, 270);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(70, 25);
            this.ButtonClear.TabIndex = 8;
            this.ButtonClear.Text = "Clear log";
            this.ToolTipDiceTool.SetToolTip(this.ButtonClear, "Clear the current Dice Tool log.");
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSpace
            // 
            this.ButtonSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSpace.Location = new System.Drawing.Point(389, 270);
            this.ButtonSpace.Name = "ButtonSpace";
            this.ButtonSpace.Size = new System.Drawing.Size(73, 25);
            this.ButtonSpace.TabIndex = 10;
            this.ButtonSpace.Text = "Title";
            this.ToolTipDiceTool.SetToolTip(this.ButtonSpace, "Adds a comment line with the text specified.");
            this.ButtonSpace.UseVisualStyleBackColor = true;
            this.ButtonSpace.Click += new System.EventHandler(this.ButtonSpace_Click);
            // 
            // TextBoxSpace
            // 
            this.TextBoxSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutDiceTool.SetColumnSpan(this.TextBoxSpace, 3);
            this.TextBoxSpace.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSpace.Location = new System.Drawing.Point(161, 271);
            this.TextBoxSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSpace.Name = "TextBoxSpace";
            this.TextBoxSpace.Size = new System.Drawing.Size(222, 23);
            this.TextBoxSpace.TabIndex = 11;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.Location = new System.Drawing.Point(122, 270);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(31, 25);
            this.ButtonSave.TabIndex = 12;
            this.ToolTipDiceTool.SetToolTip(this.ButtonSave, "Save the current Dice Tool log to file.");
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("ButtonOpen.Image")));
            this.ButtonOpen.Location = new System.Drawing.Point(81, 270);
            this.ButtonOpen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(31, 25);
            this.ButtonOpen.TabIndex = 13;
            this.ToolTipDiceTool.SetToolTip(this.ButtonOpen, "Open a Dice Tool log.");
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // FileDialogOpenDiceTool
            // 
            this.FileDialogOpenDiceTool.DefaultExt = "*.dct";
            this.FileDialogOpenDiceTool.Filter = "Dice Tool File (*.dct)|*.dct";
            this.FileDialogOpenDiceTool.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialogOpenDiceTool_FileOk);
            // 
            // FileDialogSaveDiceTool
            // 
            this.FileDialogSaveDiceTool.Filter = "Dice Tool File (*.dct)|*.dct|Comma Seperated Values (*.csv)|*.csv";
            this.FileDialogSaveDiceTool.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialogSaveDiceTool_FileOk);
            // 
            // WorkerOpenDiceTool
            // 
            this.WorkerOpenDiceTool.WorkerReportsProgress = true;
            this.WorkerOpenDiceTool.WorkerSupportsCancellation = true;
            this.WorkerOpenDiceTool.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerOpenDiceTool_DoWork);
            this.WorkerOpenDiceTool.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerOpenDiceTool_RunWorkerCompleted);
            // 
            // WorkerSaveDiceTool
            // 
            this.WorkerSaveDiceTool.WorkerReportsProgress = true;
            this.WorkerSaveDiceTool.WorkerSupportsCancellation = true;
            this.WorkerSaveDiceTool.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerSaveDiceTool_DoWork);
            this.WorkerSaveDiceTool.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerSaveDiceTool_RunWorkerCompleted);
            // 
            // TableLayoutDiceTool
            // 
            this.TableLayoutDiceTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutDiceTool.ColumnCount = 7;
            this.TableLayoutDiceTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46228F));
            this.TableLayoutDiceTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.84431F));
            this.TableLayoutDiceTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.84431F));
            this.TableLayoutDiceTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46228F));
            this.TableLayoutDiceTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46228F));
            this.TableLayoutDiceTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46228F));
            this.TableLayoutDiceTool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46228F));
            this.TableLayoutDiceTool.Controls.Add(this.Button2, 0, 0);
            this.TableLayoutDiceTool.Controls.Add(this.ButtonSpace, 6, 2);
            this.TableLayoutDiceTool.Controls.Add(this.Button4, 1, 0);
            this.TableLayoutDiceTool.Controls.Add(this.ButtonSave, 2, 2);
            this.TableLayoutDiceTool.Controls.Add(this.ButtonOpen, 1, 2);
            this.TableLayoutDiceTool.Controls.Add(this.ButtonClear, 0, 2);
            this.TableLayoutDiceTool.Controls.Add(this.ListViewRolls, 0, 1);
            this.TableLayoutDiceTool.Controls.Add(this.Button20, 6, 0);
            this.TableLayoutDiceTool.Controls.Add(this.Button10, 5, 0);
            this.TableLayoutDiceTool.Controls.Add(this.Button8, 4, 0);
            this.TableLayoutDiceTool.Controls.Add(this.Button6, 3, 0);
            this.TableLayoutDiceTool.Controls.Add(this.TextBoxSpace, 3, 2);
            this.TableLayoutDiceTool.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayoutDiceTool.Location = new System.Drawing.Point(8, 8);
            this.TableLayoutDiceTool.Name = "TableLayoutDiceTool";
            this.TableLayoutDiceTool.RowCount = 3;
            this.TableLayoutDiceTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutDiceTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutDiceTool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutDiceTool.Size = new System.Drawing.Size(465, 298);
            this.TableLayoutDiceTool.TabIndex = 15;
            this.TableLayoutDiceTool.SizeChanged += new System.EventHandler(this.TableLayoutDiceTool_SizeChanged);
            // 
            // FormDiceTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 313);
            this.Controls.Add(this.TableLayoutDiceTool);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(486, 342);
            this.Name = "FormDiceTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDiceTool_FormClosing);
            this.Load += new System.EventHandler(this.FormDiceTool_Load);
            this.ContextMenuStripDiceTool.ResumeLayout(false);
            this.TableLayoutDiceTool.ResumeLayout(false);
            this.TableLayoutDiceTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button20;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.ListView ListViewRolls;
        private System.Windows.Forms.ColumnHeader ColumnDateTime;
        private System.Windows.Forms.ColumnHeader ColumnDiceType;
        private System.Windows.Forms.ColumnHeader ColumnDiceValue;
        private System.Windows.Forms.ImageList ImageListDiceTool;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSpace;
        private System.Windows.Forms.TextBox TextBoxSpace;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.OpenFileDialog FileDialogOpenDiceTool;
        private System.Windows.Forms.SaveFileDialog FileDialogSaveDiceTool;
        private System.ComponentModel.BackgroundWorker WorkerOpenDiceTool;
        private System.ComponentModel.BackgroundWorker WorkerSaveDiceTool;
        private System.Windows.Forms.ColumnHeader ColumnComment;
        private System.Windows.Forms.ToolTip ToolTipDiceTool;
        private System.Windows.Forms.TableLayoutPanel TableLayoutDiceTool;
        private System.Windows.Forms.ColumnHeader ColumnTicks;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripDiceTool;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBoxDiceTool;
    }
}

