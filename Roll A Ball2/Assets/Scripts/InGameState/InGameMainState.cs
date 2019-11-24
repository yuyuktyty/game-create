using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMainState : IState
{
    private InGameStateManager stateManager = InGameStateManager.Instance;

    private TimerController m_timeCont;

    private bool m_stateEnd = false;

    public void Enter()
    {
        Debug.Log("GameMainStart");
        m_timeCont = GameObject.Find("TimeObject").GetComponent<TimerController>();
    }

    public void Update()
    {
        stateManager.GameTime -= Time.deltaTime;
        m_timeCont.TimeCountTextshow(stateManager.GameTime);
        if (stateManager.GameTime < 0)
        {
            stateManager.GameOver = true;
            m_stateEnd = true;
        }
        if (stateManager.Player.transform.position.y < -2)//プレイヤーがStageより下に行ったらGameOver
        {
            stateManager.GameOver = true;
            m_stateEnd = true;
        }
        if (stateManager.CoinCnt == 0)//コインが０になったらクリア
        {
            stateManager.GameOver = false;
            m_stateEnd = true;
        }
        if (m_stateEnd == true)
        {
            InGameStateManager.Instance.stateMachine.SetState(InGameStateManager.GameStateProcessor.RESULT);
        }
    }

    public void Exit()
    {
        //抜ける時にしたいことがあればここに記入
    }
    // Use this for initialization

}
