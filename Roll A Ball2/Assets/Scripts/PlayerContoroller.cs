using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoroller : MonoBehaviour
{

    // Use this for initialization

    /// <summary>
    ///自分のRigidbady
    ///</summary>
    private Rigidbody m_rigidbody;

    //private float jumpPower = 5f;
    
    ///<summary>
	///移動速度
	///</summary>
	public float MoveSpeed = 5.0f;
    private Vector3 m_moveVector = new Vector3();
    void Start()
    {
        SoundManager.Instance.PlayBGMSound(SoundManager.BGM_NAME);
        m_rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_moveVector.z = Input.GetAxis("Vertical");
        m_moveVector.x = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * MoveSpeed;
            this.GetComponent<Rigidbody>().AddForce(0, 0.5f, 0);
        }
    }

    private void FixedUpdate()
    {
        m_rigidbody.AddForce(m_moveVector * MoveSpeed, ForceMode.Acceleration);
    }
}
