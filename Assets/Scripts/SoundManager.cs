//*********************************************************************************************************
// GAME2014-F2021-Assignment 1-101235517.C# Unity by Mingkun Yang (C) October 22th 2021 All Rights Reserved.
//
// Name: Mingkun Yang 
//
// StudentID: 101235517
//
// Assignment 1 submission.
//
// Description: loading sound effect files.
//
// Modified: October 22th 2021
//
// File Name: SoundManager.cs
//
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip explosionSound, EnemyReachPointSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        explosionSound = Resources.Load<AudioClip>("Explosion");
        EnemyReachPointSound = Resources.Load<AudioClip>("CoinCollectAudio");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        audioSrc.PlayOneShot(explosionSound);
        switch (clip)
        {
            case "Explosion":
                audioSrc.PlayOneShot(explosionSound);
                break;
            case "CoinCollectAudio":
                audioSrc.PlayOneShot(EnemyReachPointSound);
                break;
        }
    }
}
