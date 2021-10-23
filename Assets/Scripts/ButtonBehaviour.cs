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
// File Name: ButtonBehaviour.cs
//
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Level");
    }

    public void OnInstructionButtonPressed()
    {
        SceneManager.LoadScene("Instruction");
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene("End");
    }

}

