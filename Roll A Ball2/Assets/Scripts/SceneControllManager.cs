using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneControllManager : SingletonBase<SceneControllManager>
{

    public const string START_SCENE_NAME = "Start";
    public const string SELECT_SCENE_NAME = "StageSelect";
    public const string INGAME_SCENE_NAME = "GameMain";
    public const string RESULT_SCENE_NAME = "Result";

    private string CurrentSceneName = string.Empty;
    //public void stage1()
    //{
    //    SceneManager.LoadScene("Start");
    //}
    //public void stage2()
    //{
    //    SceneManager.LoadScene("Select");
    //}
    //public void stage3()
    //{
    //    SceneManager.LoadScene("GameMain");
    //}
    //public void stage4()
    //{
    //    SceneManager.LoadScene("Result");
    //}
    //override protected void Awake()
    //{
    //   base.Awake();
    //  CurrentSceneName = SceneManager.GetActiveScene().name;
    // }

    ///<summary>
    ///シーンの変遷
    ///</summary>
    ///<param name="_nextScene"></param>
    //public void GotoNextScene(string _nextScene)
    //{
    //   SceneManager.LoadScene(_nextScene);
    //}
    public void GotoNextScene(string _nextScene, bool _additive = false, string _additiveScene = null)
    {
        CurrentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(_nextScene);

        //もしadditiveがtrueなら二つ目のシーンを呼ぶ
        if (_additive)
        {
            if (string.IsNullOrEmpty(_additiveScene))
            {
                return;
            }
            //additiveSceneをサブシーンとして呼び出す
            SceneManager.LoadScene(_additiveScene, LoadSceneMode.Additive);

        }
    }

    ///<summary>
    ///シーンの変遷(ボタンでのScene移動）
    ///</summary>
    ///<param name="_nextScene">
    public void GotoNextScene(string _nextScene)
    {
        SceneManager.LoadScene(_nextScene);
    }

    ///<summary>
    ///シーンに戻る
    ///</summary>
    public void ReturnBackScene()
    {
        SceneManager.LoadScene(CurrentSceneName);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
