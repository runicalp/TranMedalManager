namespace TranMedalManager {
    partial class MainForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tranMedalDataGridView = new System.Windows.Forms.DataGridView();
            this.tranMedalColumnCheckBoxDataGridView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tranMedalColumnIdDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranMedalColumnNameDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranMedalColumnCategoryDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranMedalColumnRankDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranMedalColumnConditionDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tranMedalDataGridView)).BeginInit();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tranMedalDataGridView
            // 
            this.tranMedalDataGridView.AllowUserToAddRows = false;
            this.tranMedalDataGridView.AllowUserToDeleteRows = false;
            this.tranMedalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tranMedalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tranMedalColumnCheckBoxDataGridView,
            this.tranMedalColumnIdDataGridView,
            this.tranMedalColumnNameDataGridView,
            this.tranMedalColumnCategoryDataGridView,
            this.tranMedalColumnRankDataGridView,
            this.tranMedalColumnConditionDataGridView});
            this.tranMedalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tranMedalDataGridView.Location = new System.Drawing.Point(0, 24);
            this.tranMedalDataGridView.Name = "tranMedalDataGridView";
            this.tranMedalDataGridView.RowTemplate.Height = 21;
            this.tranMedalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tranMedalDataGridView.Size = new System.Drawing.Size(784, 537);
            this.tranMedalDataGridView.TabIndex = 0;
            this.tranMedalDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tranMedalDataGridView_CellValueChanged);
            this.tranMedalDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.tranMedalDataGridView_CurrentCellDirtyStateChanged);
            this.tranMedalDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tranMedalDataGridView_KeyPress);
            // 
            // tranMedalColumnCheckBoxDataGridView
            // 
            this.tranMedalColumnCheckBoxDataGridView.HeaderText = "達成";
            this.tranMedalColumnCheckBoxDataGridView.Name = "tranMedalColumnCheckBoxDataGridView";
            // 
            // tranMedalColumnIdDataGridView
            // 
            this.tranMedalColumnIdDataGridView.HeaderText = "ID";
            this.tranMedalColumnIdDataGridView.Name = "tranMedalColumnIdDataGridView";
            this.tranMedalColumnIdDataGridView.ReadOnly = true;
            this.tranMedalColumnIdDataGridView.Visible = false;
            // 
            // tranMedalColumnNameDataGridView
            // 
            this.tranMedalColumnNameDataGridView.HeaderText = "名称";
            this.tranMedalColumnNameDataGridView.Name = "tranMedalColumnNameDataGridView";
            this.tranMedalColumnNameDataGridView.ReadOnly = true;
            this.tranMedalColumnNameDataGridView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tranMedalColumnNameDataGridView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tranMedalColumnCategoryDataGridView
            // 
            this.tranMedalColumnCategoryDataGridView.HeaderText = "カテゴリ";
            this.tranMedalColumnCategoryDataGridView.Name = "tranMedalColumnCategoryDataGridView";
            this.tranMedalColumnCategoryDataGridView.ReadOnly = true;
            this.tranMedalColumnCategoryDataGridView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tranMedalColumnCategoryDataGridView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tranMedalColumnRankDataGridView
            // 
            this.tranMedalColumnRankDataGridView.HeaderText = "Rank";
            this.tranMedalColumnRankDataGridView.Name = "tranMedalColumnRankDataGridView";
            this.tranMedalColumnRankDataGridView.ReadOnly = true;
            this.tranMedalColumnRankDataGridView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tranMedalColumnRankDataGridView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tranMedalColumnConditionDataGridView
            // 
            this.tranMedalColumnConditionDataGridView.HeaderText = "条件";
            this.tranMedalColumnConditionDataGridView.Name = "tranMedalColumnConditionDataGridView";
            this.tranMedalColumnConditionDataGridView.ReadOnly = true;
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fillterToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.mainFormMenuStrip.TabIndex = 1;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.quitToolStripMenuItem.Text = "終了";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // fillterToolStripMenuItem
            // 
            this.fillterToolStripMenuItem.Name = "fillterToolStripMenuItem";
            this.fillterToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.fillterToolStripMenuItem.Text = "フィルタ(&L)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tranMedalDataGridView);
            this.Controls.Add(this.mainFormMenuStrip);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "トランメダルを管理するアレ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tranMedalDataGridView)).EndInit();
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tranMedalDataGridView;
        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tranMedalColumnCheckBoxDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnIdDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnNameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnRankDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnConditionDataGridView;

    }
}

