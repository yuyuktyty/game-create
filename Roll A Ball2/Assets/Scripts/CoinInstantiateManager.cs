using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInstantiateManager : MonoBehaviour
{
    ///<summary>
	/// CoinRootを設定
	///</summaru>
	public GameObject CoinRoot = null;

    ///<summary>
    ///CoinRootの位置(Position)を設定する配列を作成
    ///</summary>
    public Vector3[] CoinPos = new Vector3[8];
    // Use this for initialization
    void Start()
    {
        CoinPos = new Vector3[PlayerPrefs.GetInt(SaveDateManager.SelectCoinSavekey)];


        for (int i = 0; i < CoinPos.Length; i++)
        {
            float CoinPosX = Random.Range(-3.0f, 3.0f);
            float CoinPosY = Random.Range(-1.0f, 0.0f);
            float CoinPosZ = Random.Range(-3.0f, 3.0f);
            CoinPos[i].x = CoinPosX;

            CoinPos[i].z = CoinPosZ;
            CoinPos[i].y = CoinPosY;
            ///GameObjectの生成
            Instantiate(CoinRoot, CoinPos[i], Quaternion.identity, this.transform);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
