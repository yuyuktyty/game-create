﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartSceneManager : MonoBehaviour
{

    ///<summary>
    ///シーン遷移を設定するボタン
    ///</summary>
    public Button NextSceneButton;

    public RawImage VideoRawImage;

    public TextMeshProUGUI TitleText;

    private Material m_titleMaterial;
    private Color fontColor;


    // Start is called before the first frame update
    void Start()
    {
        NextSceneButton.onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.SELECT_SCENE_NAME));
        VideoRawImage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
        m_titleMaterial = TitleText.fontMaterial;
        fontColor = m_titleMaterial.GetColor("_FaceColor");
        
    }

    // Update is called once per frame
    void Update()
    {
        m_titleMaterial.SetColor("_FaceColor", new Color(fontColor.r, fontColor.g, fontColor.b, Mathf.Sin(Time.time) / 0.5f));
        m_titleMaterial.SetColor("_OutlineColor", new Color(0, 0, 0, Mathf.Sin(Time.time) / 0.5f));
    }
}
