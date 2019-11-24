using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameResultState : IState
{
    private InGameStateManager stateManager = InGameStateManager.Instance;


    private bool m_gameEnd = false;

    public void Enter()
    {
        InGameTextManager.Instance.GameResultshow(stateManager.GameOver);

        if (stateManager.GameOver)
        {
            SoundManager.Instance.PlayBGMSound(SoundManager.GAMEOVER_BGM_NAME);
            SceneControllManager.Instance.GotoNextScene(SceneControllManager.RESULT_SCENE_NAME);
        }
        else
        {
            SoundManager.Instance.PlayBGMSound(SoundManager.CLEAR_BGM_NAME);
            SceneControllManager.Instance.GotoNextScene(SceneControllManager.RESULT_SCENE_NAME);
        }  
        
        //データを保存する
        SaveDateManager.Instance.SaveGameData(stateManager.GameTime, System.Convert.ToInt32(stateManager.GameOver));
    }

 
    public void Update()
    {
        if (!m_gameEnd)
        {
            m_gameEnd = true;
        }
    }

    public void Exit()
    {
        //抜ける時にしたいことがあればここに記入
    }
    // Use this for initialization

}
