using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : SingletonBase<SoundManager>
{

    GameObject player;
    PlayerContoroller script;

    ///<summary>
    ///SEのSoundを再生させるためのコンポーネント
    ///</summary>
    public AudioSource[] SoundEffectSource = new AudioSource[3];

    ///<summary>
    ///BGMのSoundを再生させるためのコンポーネント
    ///</summary>
    public AudioSource BGMSource = null;

    ///<summary>
    ///BGMの名前の定数
    ///</summary>
    public const string BGM_NAME = "DotaBata-Run_Loop";

    public const string CLEAR_BGM_NAME = "Beautiful Dreamer";

    //public const string BGM_NAME2 = "Algorhythm_Loop";
    public const string GAMEOVER_BGM_NAME = "Algorhythm_Loop";

    ///<summary>
    ///SEの名前の定数
    ///</summary>
    public const string COIN_SE_NAME = "decision22";

    ///<summary>
    ///BGMのファイルがある場所のパス
    ///</summary>
    const string BGM_PATH = "BGM/";

    ///<summary>
    ///BGMのファイルがある場所のパス
    ///</summary>
    const string SE_PATH = "SE/";

    ///<summary>
    ///SEを鳴らすAudioSource
    ///</summary>
    private AudioClip SEClip = null;

    ///<summary>
    ///基底クラスのメソッドを拡張(override)して使う
    ///</summary>
    protected override void Awake()
    {
        //基底クラスのawakeを走らせる
        base.Awake();

        //BGM専用のAudioSource(スピーカー)を作成
        Instance.BGMSource = this.gameObject.AddComponent<AudioSource>();

        for (int i = 0; i < SoundEffectSource.Length; i++)
        {
            //SE専用のAudioSource(スピーカー)を作成
            Instance.SoundEffectSource[i] = this.gameObject.AddComponent<AudioSource>();
        }

        ///BGMを再生させる
        PlayBGMSound(BGM_NAME);
    }
    //void Start()
    //{
    // player = GameObject.Find("Player");
    // script = player.GetComponent<PlayerContoroller>();
    // }

    //void Update()
    //{
    // if (player.transform.position.y < -2)
    // {
    //Instance.BGMSource = this.gameObject.AddComponent<AudioSource>();


    // PlayBGMSound(BGM_NAME2);
    //}
    //  }

    ///<summary>
    ///BGMを再生させる
    ///</summary>
    ///<param name="_bgmName">BGMフォルダ直下の再生させるBGMの名前</param>
    public void PlayBGMSound(string _bgmName)
    {
        BGMSource.loop = true;
        BGMSource.clip = Resources.Load(BGM_PATH + _bgmName) as AudioClip;
        BGMSource.volume = 0.1f;
        BGMSource.Play();
    }

    ///<summary>
    ///SEを再生させる
    ///</summary>
    ///<param name"_seName">SEフォルダ直下の再生させるSEの名前</param>
    public void PlaySESound(string _seName)
    {
        //空いているAudioSourceがあるかチェック
        for (int i = 0; i < SoundEffectSource.Length; i++)
        {
            //AudioSource
            if (!SoundEffectSource[i].isPlaying)
            {
                if (SEClip == null || !SEClip.name.Equals(_seName))
                {
                    SEClip = Resources.Load(SE_PATH + _seName) as AudioClip;
                    BGMSource.volume = 0.1f;
                }

                BGMSource.PlayOneShot(SEClip);
                break;
            }
        }

    }

}

// Use this for initialization
