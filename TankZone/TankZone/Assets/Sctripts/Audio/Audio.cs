using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
    public static Audio Instance; //Khai báo biến trung gian kiểu static
    public static bool isMusic = true;
    public AudioSource aS;
    public AudioClip[] aClip;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this; //gán lớp cho biến instance làm trung gian để truy xuất
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            isMusic = true;
        }
        else { isMusic = false; }
    }

    public void PlayMusicGame(int music)
    {
        if (isMusic)
        {
            aS.PlayOneShot(aClip[music]);
        }
    }

    public static void Pause()
    {
        
        throw new NotImplementedException();
    }
}
