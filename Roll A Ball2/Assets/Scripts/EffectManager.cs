﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    ///<summary>
	/// エフェクトの親オブジェクト
	///</summary>
	public GameObject Effect;

    // Use this for initialization

    ///<summary>
    ///エフェクトのプレイ関数
    ///</summary>
    public void EffectPlay()
    {
        foreach (var particles in Effect.GetComponentsInChildren<ParticleSystem>())
        {
            if (particles == null)
            {
                Debug.Log("エフェクトがありません!");
            }
            else
            {
                particles.Play();
            }
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
