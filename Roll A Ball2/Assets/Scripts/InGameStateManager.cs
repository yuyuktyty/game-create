using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InGameStateManager : SingletonBase<InGameStateManager>
{
    ///<summary>
	///ゲームの状態
	///</summary>
	public enum GameStateProcessor
    {
        INIT,//初期化
        START,//スタート	
        GAMEMAIN,//ゲームメイン
        RESULT,//ゲーム結果
        GAMEEND,//ゲーム終了
    }

    

    ///<summary>
    ///ゲームの状態
    ///</summary>
    public GameStateProcessor GameState;

    ///<summary>
    ///ゲームオーバーフラグ
    ///</summary>
    public bool GameOver = false;

    ///<summary>
    ///ゲームの制限時間
    ///</summary>
    public float GameTime = 30f;

    ///<summary>
    ///コインの数
    ///</summary>
    public int CoinCnt = 8;

    ///<summary>
    ///プレイヤー
    ///</summary>
    public GameObject Player = null;

    ///<summary>
    /// StateMachineを作成
    ///</summary>
    public readonly GameStateMachine<GameStateProcessor> stateMachine = new GameStateMachine<GameStateProcessor>();

    protected override void Awake()
    {
        base.Awake();
        ///Statemachineの初期化
        stateMachine.Clear();
        stateMachine.Add(GameStateProcessor.INIT, new InGameInitState());
        stateMachine.Add(GameStateProcessor.START, new InGameStartState());
        stateMachine.Add(GameStateProcessor.GAMEMAIN, new InGameMainState());
        stateMachine.Add(GameStateProcessor.RESULT, new InGameResultState());
    }
   
         


    private void Start()
    {
        GameTime = PlayerPrefs.GetFloat(SaveDateManager.SelectGameTimeSavekey);
        stateMachine.SetState(GameStateProcessor.INIT);

    }


    private void Update()
    {
        stateMachine.Update();
    }
    // Use this for initialization

}
