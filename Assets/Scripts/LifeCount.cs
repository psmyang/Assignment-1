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
// File Name: LifeCount.cs
//
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public static int liveAmount;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        liveAmount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Lives: " + liveAmount;
    }
}
