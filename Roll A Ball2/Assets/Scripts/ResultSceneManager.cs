using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneManager : MonoBehaviour
{
    ///>summary>
    ///<シーン遷移を設定するボタン
    ///</summary>
    public Button NextSceneButton;

    /// <summary>
    /// <ゲーム結果を表示するテキスト
    /// </summary>
    public TextMeshProUGUI ResultText;

    /// <summary>
    /// ゲームスコアを表示するテキスト
    /// </summary>
    public TextMeshProUGUI ScoreText;

    /// <summary>
    /// スコアを表示する時の表示物
    /// </summary>
    private string YourScore = "YourScore";

   
    private Material m_ResultMaterial;
    private Color fontColor;
    
    // Start is called before the first frame update
    void Start()
    {
        NextSceneButton.onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.START_SCENE_NAME));

        //表示物の初期化
        ResultText.text = string.Empty;
        ScoreText.text = string.Empty;
        m_ResultMaterial = ResultText.fontMaterial;
        fontColor = m_ResultMaterial.GetColor("_FaceColor");

        //1だったらゲームオーバー
        if(PlayerPrefs.GetInt(SaveDateManager.ResultSavekey) == 1)
        {
            ResultText.text = "GameOver";
        }
        else
        {
            ResultText.text = "GameClear";
            ScoreText.text = string.Format("{0}:{1:00}", YourScore, PlayerPrefs.GetFloat(SaveDateManager.ScoreSavekey));
        }

    }

    // Update is called once per frame
    private void Update()
    {
        m_ResultMaterial.SetColor("_FaceColor", new Color(fontColor.r, fontColor.g, fontColor.b, Mathf.Sin(Time.time) / 0.5f));
        m_ResultMaterial.SetColor("_OutlineColor", new Color(0, 0, 0, Mathf.Sin(Time.time) / 0.5f));
    }
}
