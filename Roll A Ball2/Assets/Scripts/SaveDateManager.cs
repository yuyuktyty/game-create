using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDateManager : SingletonBase<SaveDateManager>
{
    public const string ResultSavekey = "Result";
    public const string ScoreSavekey = "Score";

    public const string SelectCoinSavekey = "Coin";
    public const string SelectGameTimeSavekey = "Time";

    protected override void Awake()
    {
        base.Awake();
    }

    ///<summary>
    ///ゲーム結果のセーブをする
    ///</summaru>
    ///<param name="_ResultTime">クリアしたときの残タイム</param>
    ///<param name="_gameOver">0か1を保存する0 =　ゲームクリア,1　= ゲームオーバー</param>
    public void SaveGameData(float _ResultTime, int _gameOver)
    {
        PlayerPrefs.SetInt(ResultSavekey, _gameOver);
        PlayerPrefs.SetFloat(ScoreSavekey, _ResultTime);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// ステージセレクトの難易度設定用データ
    /// </summary>
    /// <param name="_GameTime"></param>
    /// <param name="_CoinCount"></param>
    public void SaveSelectLevelData(float _GameTime, int _CoinCount)
    {
        PlayerPrefs.SetInt(SelectCoinSavekey, _CoinCount);
        PlayerPrefs.SetFloat(SelectGameTimeSavekey, _GameTime);
        PlayerPrefs.Save();
    }

}
// Start is called before the first frame update


