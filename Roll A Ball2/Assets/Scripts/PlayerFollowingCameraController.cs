using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowingCameraController : MonoBehaviour
{

    ///<summary>
    ///追うべきプレイヤーの場所
    ///</summary>
    private Transform m_playerTtansform;

    ///<summary>
    ///被写体とカメラとの距離
    ///</summary>
    private Vector3 m_cameraOffset;

    // Use this for initialization
    void Start()
    {
        m_playerTtansform = GameObject.Find("Player").transform;

        m_cameraOffset = this.transform.position - m_playerTtansform.position;
    }


    private void LateUpdate()
    {
        this.transform.position = m_playerTtansform.position + m_cameraOffset;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
