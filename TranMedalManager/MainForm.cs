using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TranMedalManager {
    public partial class MainForm : Form {
        //---------------------------------------------------------------------
        #region // private 変数

        /// <summary>
        /// このフォームの基本となるText
        /// </summary>
        private string baseText;

        /// <summary>
        /// 保存確認フラグ
        /// </summary>
        private bool _isSaveConfirm;

        /// <summary>
        /// DataGridView用のデータソース
        /// </summary>
        private BindingSource bindingSource;

        #endregion
        //---------------------------------------------------------------------
        #region // private プロパティ

        /// <summary>
        /// 保存確認フラグ
        /// </summary>
        private bool isSaveConfirm {
            get { return this._isSaveConfirm; }
            set {
                // フラグが変更される時、フォームのTextを変更
                if( this._isSaveConfirm != value ) {
                    this.Text = value ? this.baseText + " *" : this.baseText;
                }

                this._isSaveConfirm = value;

            }
        }

        #endregion
        //---------------------------------------------------------------------
        #region // public 関数

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm() {
            InitializeComponent();
            
            // 基本となるTextを保存
            this.baseText = this.Text;
        }

        #endregion
        //---------------------------------------------------------------------
        #region // private 関数

        /// <summary>
        /// トランメダルデータの読み込み
        /// </summary>
        private void LoadTranMedalData() {
            // マネージャでデータを読み込み
            TranMedalMasterDataManager.Load();
            // ファイル保存しているデータ読み込み
            var saveIds = new HashSet<int>();
            if( System.IO.File.Exists( Properties.Resources.SaveFileName ) ) {
                string saveData;
                using( var sr = new System.IO.StreamReader( Properties.Resources.SaveFileName ) ) {
                    saveData = sr.ReadToEnd();
                }
                var ids = saveData.Trim().Split( '\t' );
                foreach( var id in ids ) {
                    saveIds.Add( Convert.ToInt32( id ) );
                }
            }
            // データテーブルを作る
            this.bindingSource = new BindingSource();
            var dt = new DataTable();
            dt.Columns.Add( "達成", typeof( bool ) );
            dt.Columns.Add( "保存前達成フラグ", typeof( bool ) );
            dt.Columns.Add( "ID", typeof( int ) );
            dt.Columns.Add( "名称", typeof( string ) );
            dt.Columns.Add( "カテゴリ", typeof( string ) );
            dt.Columns.Add( "Rank", typeof( string ) );
            dt.Columns.Add( "条件", typeof( string ) );
            var rows = dt.Rows;
            foreach( var value in TranMedalMasterDataManager.values ) {
                var flag = saveIds.Contains( value.id );
                rows.Add( flag, flag, value.id, value.name, value.category, value.rank, value.condition );
            }
            // DataGridViewに今作ったデータテーブルを設定
            this.bindingSource.DataSource = dt;
            this.tranMedalDataGridView.DataSource = this.bindingSource;
            // 保存前達成フラグ、ID は非表示
            this.tranMedalDataGridView.Columns[ 1 ].Visible = false;
            this.tranMedalDataGridView.Columns[ 2 ].Visible = false;
            // 名前以降の項目は編集不可
            for( int i = 3; i < dt.Columns.Count; ++i ) {
                this.tranMedalDataGridView.Columns[ i ].ReadOnly = true;
            }
            // 項目内のテキストに応じて列をリサイズ
            this.tranMedalDataGridView.AutoResizeColumns();
            // 保存確認フラグを初期化
            this.isSaveConfirm = false;
        }

        /// <summary>
        /// 保存処理
        /// </summary>
        private void Save() {
            // フィルタを一旦解除
            var prevFilter = this.bindingSource.Filter;
            this.bindingSource.RemoveFilter();
            // チェックの入った行のみ取得
            var list = this.tranMedalDataGridView.Rows.Cast<DataGridViewRow>().Where( _ => _.Cells[ 0 ].Value.Equals( true ) );
            // IDをタブ区切りにした文字列を生成
            var sb = new StringBuilder();
            foreach( var row in list ) {
                sb.AppendFormat( "{0}\t", row.Cells[ 2 ].Value );
            }
            // ファイルに保存
            using( var sw = new System.IO.StreamWriter( Properties.Resources.SaveFileName ) ) {
                sw.Write( sb );
            }

            // 保存前達成フラグを更新
            foreach( DataGridViewRow row in this.tranMedalDataGridView.Rows ) {
                row.Cells[ 1 ].Value = row.Cells[ 0 ].Value;
            }
            // データテーブルを更新する
            ( (DataTable)this.bindingSource.DataSource ).AcceptChanges();
            
            // 保存確認フラグを下ろす
            this.isSaveConfirm = false;
            // フィルタを戻す
            this.bindingSource.Filter = prevFilter;
        }

        /// <summary>
        /// 終了処理
        /// </summary>
        /// <param name="e">メインフォームの閉じ中イベントデータ</param>
        private void Exit( FormClosingEventArgs e ) {
            // 保存確認フラグが立ってない時は何もしない
            if( !this.isSaveConfirm ) { return; }
            // 保存確認メッセージボックスの表示
            var result = MessageBox.Show( Properties.Resources.QuitConfirmText, Properties.Resources.QuitConfirmCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly );
            switch( result ) {
                case System.Windows.Forms.DialogResult.Yes:
                    Save();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                default:
                    throw new Exception( "Unknow ShowSaveConfirmMessageBox Result: " + result );
            }
        }

        #endregion
        //---------------------------------------------------------------------
        #region // Event Handler

        /// <summary>
        /// メインフォーム読み込み時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load( object sender, EventArgs e ) {
            LoadTranMedalData();
        }

        /// <summary>
        /// メインフォーム閉じ始める時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing( object sender, FormClosingEventArgs e ) {
            Exit( e );
        }

        /// <summary>
        /// 保存 メニュー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click( object sender, EventArgs e ) {
            Save();
        }

        /// <summary>
        /// 終了 メニュー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click( object sender, EventArgs e ) {
            Application.Exit();
        }

        /// <summary>
        /// フィルタ(全て) メニュー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterAllMenuItem_Click( object sender, EventArgs e ) {
            this.bindingSource.RemoveFilter();
        }

        /// <summary>
        /// フィルタ(達成) メニュー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterFlagMenuItem_Click( object sender, EventArgs e ) {
            this.bindingSource.Filter = string.Format( "保存前達成フラグ = '{0}'", ( (ToolStripMenuItem)sender ).Text == "達成済み" );
        }

        /// <summary>
        /// フィルタ(カテゴリ) メニュー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterCategoryMenuItem_Click( object sender, EventArgs e ) {
            this.bindingSource.Filter = string.Format( "カテゴリ = '{0}'", ( (ToolStripMenuItem)sender ).Text );
        }

        /// <summary>
        /// フィルタ(Rank) メニュー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterRankMenuItem_Click( object sender, EventArgs e ) {
            this.bindingSource.Filter = string.Format( "Rank = '{0}'", ( (ToolStripMenuItem)sender ).Text );
        }

        /// <summary>
        /// バージョン情報 メニュー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void versionInformationToolStripMenuItem_Click( object sender, EventArgs e ) {

        }

        /// <summary>
        /// DataGridViewのセル内容の変更に関連して、セル状態が変更する際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tranMedalDataGridView_CurrentCellDirtyStateChanged( object sender, EventArgs e ) {
            if( this.tranMedalDataGridView.CurrentCellAddress.X == 0 && this.tranMedalDataGridView.IsCurrentCellDirty ) {
                // コミットする
                this.tranMedalDataGridView.CommitEdit( DataGridViewDataErrorContexts.Commit );
            }
        }

        /// <summary>
        /// DataGridViewのセルの値が変更する際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tranMedalDataGridView_CellValueChanged( object sender, DataGridViewCellEventArgs e ) {
            // 列のインデックスを確認
            if( e.ColumnIndex == 0 ) {
                // 保存確認フラグを立てる
                this.isSaveConfirm = true;
            }
        }

        /// <summary>
        /// DataGridViewでキーが押された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tranMedalDataGridView_KeyPress( object sender, KeyPressEventArgs e ) {
            if( e.KeyChar == ' ' ) {
                bool flag = (bool)this.tranMedalDataGridView.CurrentRow.Cells[ 0 ].Value;
                foreach( DataGridViewRow row in this.tranMedalDataGridView.SelectedRows ) {
                    row.Cells[ 0 ].Value = !flag;
                }
            }
        }

        #endregion
        //---------------------------------------------------------------------
    }
}
