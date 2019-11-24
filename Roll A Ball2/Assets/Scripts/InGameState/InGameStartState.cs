using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameStartState : IState
{
    public void Enter()
    {
        SoundManager.Instance.PlayBGMSound(SoundManager.BGM_NAME);
    }
    // Use this for initialization
    public void Update()
    {
        InGameStateManager.Instance.stateMachine.SetState(InGameStateManager.GameStateProcessor.GAMEMAIN);
    }

    public void Exit()
    {
        ///抜ける時にしたいことがあればここに記入
    }
}
