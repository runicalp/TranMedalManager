/// <summary>
/// トランメダルのデータクラス
/// </summary>
public class TranMedalMasterData {
    //-------------------------------------------------------------------------
    #region // publicプロパティ

    /// <summary>
    /// ID(内部での管理にのみ使用し、表面には出さない)
    /// </summary>
    public int id { get; private set; }

    /// <summary>
    /// カテゴリ
    /// </summary>
    public string category { get; private set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string name { get; private set; }

    /// <summary>
    /// ランク
    /// </summary>
    public string rank { get; private set; }

    /// <summary>
    /// 条件
    /// </summary>
    public string condition { get; private set; }

    #endregion
    //-------------------------------------------------------------------------
    #region // public関数

    /// <summary>
    /// コンストラクタ(引数有りコンストラクタを定義するために、引数無しコンストラクタも明示的に定義)
    /// </summary>
    public TranMedalMasterData() { }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="csvLineData">CSVの行データ</param>
    public TranMedalMasterData( string csvLineData ) {
        // タブ文字で区切る
        var data = csvLineData.Split( '\t' );
        // 区切った文字列たちをそれぞれ適切なデータに格納する
        this.id = System.Convert.ToInt32( data[ 0 ] );
        this.category = data[ 1 ];
        this.name = data[ 2 ];
        this.rank = data[ 3 ];
        this.condition = data[ 4 ];
    }

    /// <summary>
    /// ToStringの実装
    /// </summary>
    /// <returns>このクラスを表す文字列</returns>
    public override string ToString() {
        return string.Format( "{0} {1} {2} {3} {4}", this.id, this.category, this.name, this.rank, this.condition );
    }

    #endregion
    //-------------------------------------------------------------------------
}