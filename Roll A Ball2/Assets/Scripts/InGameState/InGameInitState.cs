using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameInitState : IState
{
    public void Enter()
    {
        Debug.Log("InitStart");
    }

    public void Update()
    {
        InGameStateManager.Instance.stateMachine.SetState(InGameStateManager.GameStateProcessor.START);
    }
    // Use this for initialization
    public void Exit()
    {
        ///抜ける時にしたいことがあればここに記入
    }
}
