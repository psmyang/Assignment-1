//*********************************************************************************************************
// GAME2014-F2021-Assignment 1-101235517.C# Unity by Mingkun Yang (C) October 22th 2021 All Rights Reserved.
//
// Name: Mingkun Yang 
//
// StudentID: 101235517
//
// Assignment 1 submission.
//
// Description: Modify the Space Shooter Demo
//
// Modified: October 22th 2021
//
//  File Name: GameOverCondition.cs
//
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCondition : MonoBehaviour
{
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            LifeCount.liveAmount -= 1;
            SoundManager.PlaySound("CoinCollectAudio");
        }

        

        if (LifeCount.liveAmount == 0)
        {
            StartCoroutine(Timedelay());
            
        }
    }

    public IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(index);
    }
}
