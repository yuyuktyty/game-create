using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InGameTextManager : MonoBehaviour
{
    ///<summary>
    ///結果を表示するText
    ///</summary>
    public TextMeshProUGUI ResultText;

    ///<summary>
	/// InGameTextManagerのインスタンス
	///</summary>
    public static InGameTextManager Instance = null;

    GameObject player;
    PlayerContoroller script;
   
    


    public void GameResultshow(bool _GameOver)
    {
        if (_GameOver)
        {
            ResultText.text = "GAME OVER";
        }
        else
        {
            ResultText.text = "CLEAR";
        }


    }



    void Start()
    {
        player = GameObject.Find("Player");
        script = player.GetComponent<PlayerContoroller>();
    }


    void Update()
    {
        if (player.transform.position.y < -2)
        {
            ResultText.text = "GAME OVER";
        }

    }



    private void Awake()

    {
        Instance = this;
        ResultText.text = string.Format("{0:00}", InGameStateManager.Instance. CoinCnt);


    }




    public void CoinSubtract()
    {
        InGameStateManager.Instance. CoinCnt -= 1;

        if (InGameStateManager.Instance.CoinCnt < 1)
        {
            ResultText.text = "Clear";
        }
       else
        {
            ResultText.text = string.Format("{0:00}", InGameStateManager.Instance.CoinCnt);
        }


    }
}
