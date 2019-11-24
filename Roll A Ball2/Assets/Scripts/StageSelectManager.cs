using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectManager : MonoBehaviour
{
    ///<summary>
    ///シーン遷移を設定するボタン
    ///</summary>
    public Button[] StageSelectButton = new Button[3];

    GameLevel lv1 = new GameLevel(60, 5);
    GameLevel lv2 = new GameLevel(30, 10);
    GameLevel lv3 = new GameLevel(20, 12);

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            StageSelectButton[i].onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.INGAME_SCENE_NAME));
        }
        StageSelectButton[0].onClick.AddListener(() => SaveDateManager.Instance.SaveSelectLevelData(lv1.GameTime, lv1.CoinCount));
        StageSelectButton[1].onClick.AddListener(() => SaveDateManager.Instance.SaveSelectLevelData(lv2.GameTime, lv2.CoinCount));
        StageSelectButton[2].onClick.AddListener(() => SaveDateManager.Instance.SaveSelectLevelData(lv3.GameTime, lv3.CoinCount));
    }

    struct GameLevel
    {
        public float GameTime;
        public int CoinCount;

        public GameLevel(float _Gametime, int _CoinCount)
        {
            GameTime = _Gametime;
            CoinCount = _CoinCount;
        }
    }




    // Update is called once per frame
    void Update()
    {

    }
}
