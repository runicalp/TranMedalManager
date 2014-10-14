using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranMedalManager {
    public static class TranMedalMasterDataManager {
        //-------------------------------------------------------------------------
        #region // private 変数

        /// <summary>
        /// トランメダルデータクラスのディクショナリ
        /// </summary>
        private static Dictionary<int,TranMedalMasterData> dictionary = new Dictionary<int,TranMedalMasterData>();

        public static IEnumerable<TranMedalMasterData> values {
            get {
                return dictionary.Values;
            }
        }

        #endregion
        //-------------------------------------------------------------------------
        #region // public 関数

        /// <summary>
        /// 読み込み
        /// </summary>
        public static void Load() {
            // ディクショナリを初期化
            dictionary.Clear();
            // ResorcesからCSV読み込み
            var csv = Properties.Resources.TranMedalData;
            // 前後の空行を削除した上で、改行コードでSplit
            var lines = csv.Trim().Split( '\n' );
            // 行数分だけ生成してディクショナリに追加
            foreach( var line in lines ) {
                var tmd = new TranMedalMasterData( line );
                dictionary.Add( tmd.id, tmd );
            }
        }

        #endregion
        //-------------------------------------------------------------------------
    }

}
