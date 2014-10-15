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
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryVersionAndDifficultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryDjLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryClearLampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryDaniNinteiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryRivalChallengeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryTodaysRecommendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryDjPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryPilgrimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryStepUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterCategoryChronoSeekerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ブロンズToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.シルバーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ゴールドToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プラチナToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterFlagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterFlagClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterFlagNotClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tranMedalColumnCheckBoxDataGridView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // 
            // tranMedalColumnCategoryDataGridView
            // 
            this.tranMedalColumnCategoryDataGridView.HeaderText = "カテゴリ";
            this.tranMedalColumnCategoryDataGridView.Name = "tranMedalColumnCategoryDataGridView";
            this.tranMedalColumnCategoryDataGridView.ReadOnly = true;
            this.tranMedalColumnCategoryDataGridView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tranMedalColumnRankDataGridView
            // 
            this.tranMedalColumnRankDataGridView.HeaderText = "Rank";
            this.tranMedalColumnRankDataGridView.Name = "tranMedalColumnRankDataGridView";
            this.tranMedalColumnRankDataGridView.ReadOnly = true;
            this.tranMedalColumnRankDataGridView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.filterToolStripMenuItem});
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
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAllToolStripMenuItem,
            this.filterFlagToolStripMenuItem,
            this.filterCategoryToolStripMenuItem,
            this.filterRankToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.filterToolStripMenuItem.Text = "フィルタ(&L)";
            // 
            // filterCategoryToolStripMenuItem
            // 
            this.filterCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterCategoryLevelToolStripMenuItem,
            this.filterCategoryVersionAndDifficultToolStripMenuItem,
            this.filterCategoryDjLevelToolStripMenuItem,
            this.filterCategoryClearLampToolStripMenuItem,
            this.filterCategoryDaniNinteiToolStripMenuItem,
            this.filterCategoryRivalChallengeToolStripMenuItem,
            this.filterCategoryTodaysRecommendToolStripMenuItem,
            this.filterCategoryDjPointToolStripMenuItem,
            this.filterCategoryPilgrimageToolStripMenuItem,
            this.filterCategoryStepUpToolStripMenuItem,
            this.filterCategoryChronoSeekerToolStripMenuItem});
            this.filterCategoryToolStripMenuItem.Name = "filterCategoryToolStripMenuItem";
            this.filterCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filterCategoryToolStripMenuItem.Text = "カテゴリ";
            // 
            // filterCategoryLevelToolStripMenuItem
            // 
            this.filterCategoryLevelToolStripMenuItem.Name = "filterCategoryLevelToolStripMenuItem";
            this.filterCategoryLevelToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryLevelToolStripMenuItem.Text = "譜面レベル";
            this.filterCategoryLevelToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryVersionAndDifficultToolStripMenuItem
            // 
            this.filterCategoryVersionAndDifficultToolStripMenuItem.Name = "filterCategoryVersionAndDifficultToolStripMenuItem";
            this.filterCategoryVersionAndDifficultToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryVersionAndDifficultToolStripMenuItem.Text = "バージョン・譜面別";
            this.filterCategoryVersionAndDifficultToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryDjLevelToolStripMenuItem
            // 
            this.filterCategoryDjLevelToolStripMenuItem.Name = "filterCategoryDjLevelToolStripMenuItem";
            this.filterCategoryDjLevelToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryDjLevelToolStripMenuItem.Text = "DJ LEVEL";
            this.filterCategoryDjLevelToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryClearLampToolStripMenuItem
            // 
            this.filterCategoryClearLampToolStripMenuItem.Name = "filterCategoryClearLampToolStripMenuItem";
            this.filterCategoryClearLampToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryClearLampToolStripMenuItem.Text = "クリアランプ";
            this.filterCategoryClearLampToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryDaniNinteiToolStripMenuItem
            // 
            this.filterCategoryDaniNinteiToolStripMenuItem.Name = "filterCategoryDaniNinteiToolStripMenuItem";
            this.filterCategoryDaniNinteiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryDaniNinteiToolStripMenuItem.Text = "段位認定";
            this.filterCategoryDaniNinteiToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryRivalChallengeToolStripMenuItem
            // 
            this.filterCategoryRivalChallengeToolStripMenuItem.Name = "filterCategoryRivalChallengeToolStripMenuItem";
            this.filterCategoryRivalChallengeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryRivalChallengeToolStripMenuItem.Text = "ライバル挑戦状";
            this.filterCategoryRivalChallengeToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryTodaysRecommendToolStripMenuItem
            // 
            this.filterCategoryTodaysRecommendToolStripMenuItem.Name = "filterCategoryTodaysRecommendToolStripMenuItem";
            this.filterCategoryTodaysRecommendToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryTodaysRecommendToolStripMenuItem.Text = "今日のイチオシ";
            this.filterCategoryTodaysRecommendToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryDjPointToolStripMenuItem
            // 
            this.filterCategoryDjPointToolStripMenuItem.Name = "filterCategoryDjPointToolStripMenuItem";
            this.filterCategoryDjPointToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryDjPointToolStripMenuItem.Text = "DJ POINT";
            this.filterCategoryDjPointToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryPilgrimageToolStripMenuItem
            // 
            this.filterCategoryPilgrimageToolStripMenuItem.Name = "filterCategoryPilgrimageToolStripMenuItem";
            this.filterCategoryPilgrimageToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryPilgrimageToolStripMenuItem.Text = "行脚";
            this.filterCategoryPilgrimageToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryStepUpToolStripMenuItem
            // 
            this.filterCategoryStepUpToolStripMenuItem.Name = "filterCategoryStepUpToolStripMenuItem";
            this.filterCategoryStepUpToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryStepUpToolStripMenuItem.Text = "STEP UP";
            this.filterCategoryStepUpToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterCategoryChronoSeekerToolStripMenuItem
            // 
            this.filterCategoryChronoSeekerToolStripMenuItem.Name = "filterCategoryChronoSeekerToolStripMenuItem";
            this.filterCategoryChronoSeekerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.filterCategoryChronoSeekerToolStripMenuItem.Text = "Chrono Seeker";
            this.filterCategoryChronoSeekerToolStripMenuItem.Click += new System.EventHandler(this.filterCategoryMenuItem_Click);
            // 
            // filterRankToolStripMenuItem
            // 
            this.filterRankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ブロンズToolStripMenuItem,
            this.シルバーToolStripMenuItem,
            this.ゴールドToolStripMenuItem,
            this.プラチナToolStripMenuItem});
            this.filterRankToolStripMenuItem.Name = "filterRankToolStripMenuItem";
            this.filterRankToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filterRankToolStripMenuItem.Text = "Rank";
            // 
            // ブロンズToolStripMenuItem
            // 
            this.ブロンズToolStripMenuItem.Name = "ブロンズToolStripMenuItem";
            this.ブロンズToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ブロンズToolStripMenuItem.Text = "ブロンズ";
            this.ブロンズToolStripMenuItem.Click += new System.EventHandler(this.filterRankMenuItem_Click);
            // 
            // シルバーToolStripMenuItem
            // 
            this.シルバーToolStripMenuItem.Name = "シルバーToolStripMenuItem";
            this.シルバーToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.シルバーToolStripMenuItem.Text = "シルバー";
            this.シルバーToolStripMenuItem.Click += new System.EventHandler(this.filterRankMenuItem_Click);
            // 
            // ゴールドToolStripMenuItem
            // 
            this.ゴールドToolStripMenuItem.Name = "ゴールドToolStripMenuItem";
            this.ゴールドToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ゴールドToolStripMenuItem.Text = "ゴールド";
            this.ゴールドToolStripMenuItem.Click += new System.EventHandler(this.filterRankMenuItem_Click);
            // 
            // プラチナToolStripMenuItem
            // 
            this.プラチナToolStripMenuItem.Name = "プラチナToolStripMenuItem";
            this.プラチナToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.プラチナToolStripMenuItem.Text = "プラチナ";
            this.プラチナToolStripMenuItem.Click += new System.EventHandler(this.filterRankMenuItem_Click);
            // 
            // filterAllToolStripMenuItem
            // 
            this.filterAllToolStripMenuItem.Name = "filterAllToolStripMenuItem";
            this.filterAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filterAllToolStripMenuItem.Text = "全て";
            this.filterAllToolStripMenuItem.Click += new System.EventHandler(this.filterAllMenuItem_Click);
            // 
            // filterFlagToolStripMenuItem
            // 
            this.filterFlagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterFlagClearToolStripMenuItem,
            this.filterFlagNotClearToolStripMenuItem});
            this.filterFlagToolStripMenuItem.Name = "filterFlagToolStripMenuItem";
            this.filterFlagToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filterFlagToolStripMenuItem.Text = "達成";
            // 
            // filterFlagClearToolStripMenuItem
            // 
            this.filterFlagClearToolStripMenuItem.Name = "filterFlagClearToolStripMenuItem";
            this.filterFlagClearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filterFlagClearToolStripMenuItem.Text = "達成済み";
            this.filterFlagClearToolStripMenuItem.Click += new System.EventHandler(this.filterFlagMenuItem_Click);
            // 
            // filterFlagNotClearToolStripMenuItem
            // 
            this.filterFlagNotClearToolStripMenuItem.Name = "filterFlagNotClearToolStripMenuItem";
            this.filterFlagNotClearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filterFlagNotClearToolStripMenuItem.Text = "未達成";
            this.filterFlagNotClearToolStripMenuItem.Click += new System.EventHandler(this.filterFlagMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tranMedalColumnCheckBoxDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnIdDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnNameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnRankDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranMedalColumnConditionDataGridView;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterRankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryVersionAndDifficultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryDjLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryClearLampToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryDaniNinteiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryRivalChallengeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryTodaysRecommendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryDjPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryPilgrimageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryStepUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterCategoryChronoSeekerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ブロンズToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem シルバーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ゴールドToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プラチナToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterFlagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterFlagClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterFlagNotClearToolStripMenuItem;

    }
}

