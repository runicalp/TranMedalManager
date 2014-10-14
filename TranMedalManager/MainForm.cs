using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranMedalManager {
    public partial class MainForm : Form {
        //---------------------------------------------------------------------
        #region // private 変数

        /// <summary>
        /// 保存確認フラグ
        /// </summary>
        private bool isSaveConfirm;

        #endregion
        //---------------------------------------------------------------------
        #region // public 関数

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm() {
            InitializeComponent();
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
            // 読み込んだデータ分だけDataGridViewに項目を追加
            foreach( var value in TranMedalMasterDataManager.values ) {
                this.tranMedalDataGridView.Rows.Add( saveIds.Contains( value.id ), value.id, value.name, value.category, value.rank, value.condition );
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
            // チェックの入った行のみ取得
            var list = this.tranMedalDataGridView.Rows.Cast<DataGridViewRow>().Where( _ => _.Cells[ 0 ].Value.Equals( true ) );
            // IDをタブ区切りにした文字列を生成
            var sb = new StringBuilder();
            foreach( var row in list ) {
                sb.AppendFormat( "{0}\t", row.Cells[ 1 ].Value );
            }
            // ファイルに保存
            using( var sw = new System.IO.StreamWriter( Properties.Resources.SaveFileName ) ) {
                sw.Write( sb );
            }
            // 保存確認フラグを下ろす
            this.isSaveConfirm = false;
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
