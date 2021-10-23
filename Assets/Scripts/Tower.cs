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
// File Name: Tower.cs
//
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private Vector3 ProjectileShootFromPosition;

    public GameObject bulletPrefab;
    public Transform tower;

    private void Awake()
    {
        //ProjectileShootFromPosition = transform.Find("ProjectileShootFromPosition").position;
    }

    private void Update()
    {       
        if (Time.frameCount % 140 == 0)
        {
            shootBullet();
        }
    }

    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = tower.transform.position;
    }
}
