namespace _2 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextResize = new System.Windows.Forms.ToolStripMenuItem();
            this.contextActual = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCenterImage = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAutoSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActualSize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCenterImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoSize = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextResize,
            this.contextActual,
            this.contextCenterImage,
            this.contextAutoSize});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 92);
            // 
            // contextResize
            // 
            this.contextResize.Name = "contextResize";
            this.contextResize.Size = new System.Drawing.Size(145, 22);
            this.contextResize.Text = "&Resize";
            this.contextResize.Click += new System.EventHandler(this.mnuResize_Click);
            // 
            // contextActual
            // 
            this.contextActual.Name = "contextActual";
            this.contextActual.Size = new System.Drawing.Size(145, 22);
            this.contextActual.Text = "&Actual";
            this.contextActual.Click += new System.EventHandler(this.mnuActualSize_Click);
            // 
            // contextCenterImage
            // 
            this.contextCenterImage.Name = "contextCenterImage";
            this.contextCenterImage.Size = new System.Drawing.Size(145, 22);
            this.contextCenterImage.Text = "&Center image";
            this.contextCenterImage.Click += new System.EventHandler(this.mnuCenterImage_Click);
            // 
            // contextAutoSize
            // 
            this.contextAutoSize.Name = "contextAutoSize";
            this.contextAutoSize.Size = new System.Drawing.Size(145, 22);
            this.contextAutoSize.Text = "&Auto size";
            this.contextAutoSize.Click += new System.EventHandler(this.mnuAutoSize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuPageSetup,
            this.mnuPrintPreview,
            this.mnuPrint,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(146, 22);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(146, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuPageSetup
            // 
            this.mnuPageSetup.Name = "mnuPageSetup";
            this.mnuPageSetup.Size = new System.Drawing.Size(180, 22);
            this.mnuPageSetup.Text = "Page setup";
            this.mnuPageSetup.Click += new System.EventHandler(this.mnuPageSetup_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.Size = new System.Drawing.Size(180, 22);
            this.mnuPrintPreview.Text = "Print preview";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(180, 22);
            this.mnuPrint.Text = "&Print";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuExit.Size = new System.Drawing.Size(146, 22);
            this.mnuExit.Text = "&Exit";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResize,
            this.mnuActualSize,
            this.mnuCenterImage,
            this.mnuAutoSize});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            this.mnuView.DropDownOpening += new System.EventHandler(this.mnuView_DropDownOpening);
            // 
            // mnuResize
            // 
            this.mnuResize.Name = "mnuResize";
            this.mnuResize.Size = new System.Drawing.Size(180, 22);
            this.mnuResize.Text = "&Resize";
            this.mnuResize.Click += new System.EventHandler(this.mnuResize_Click);
            // 
            // mnuActualSize
            // 
            this.mnuActualSize.Name = "mnuActualSize";
            this.mnuActualSize.Size = new System.Drawing.Size(180, 22);
            this.mnuActualSize.Text = "&Actual size";
            this.mnuActualSize.Click += new System.EventHandler(this.mnuActualSize_Click);
            // 
            // mnuCenterImage
            // 
            this.mnuCenterImage.Name = "mnuCenterImage";
            this.mnuCenterImage.Size = new System.Drawing.Size(180, 22);
            this.mnuCenterImage.Text = "&Center image";
            this.mnuCenterImage.Click += new System.EventHandler(this.mnuCenterImage_Click);
            // 
            // mnuAutoSize
            // 
            this.mnuAutoSize.Name = "mnuAutoSize";
            this.mnuAutoSize.Size = new System.Drawing.Size(180, 22);
            this.mnuAutoSize.Text = "&Auto size";
            this.mnuAutoSize.Click += new System.EventHandler(this.mnuAutoSize_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Open image";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Save image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbFile,
            this.sbSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbFile
            // 
            this.sbFile.Name = "sbFile";
            this.sbFile.Size = new System.Drawing.Size(0, 17);
            // 
            // sbSize
            // 
            this.sbSize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sbSize.Name = "sbSize";
            this.sbSize.Size = new System.Drawing.Size(0, 17);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuPageSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuResize;
        private System.Windows.Forms.ToolStripMenuItem mnuActualSize;
        private System.Windows.Forms.ToolStripMenuItem mnuCenterImage;
        private System.Windows.Forms.ToolStripMenuItem mnuAutoSize;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem contextResize;
        private System.Windows.Forms.ToolStripMenuItem contextActual;
        private System.Windows.Forms.ToolStripMenuItem contextCenterImage;
        private System.Windows.Forms.ToolStripMenuItem contextAutoSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbFile;
        private System.Windows.Forms.ToolStripStatusLabel sbSize;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

