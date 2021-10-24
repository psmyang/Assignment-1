//*********************************************************************************************************
// GAME2014-F2021-Assignment 1-101235517.C# Unity by Mingkun Yang (C) October 22th 2021 All Rights Reserved.
//
// Name: Mingkun Yang 
//
// StudentID: 101235517
//
// Assignment 1 submission.
//
// Description: adding enemy AI, walk throgh way point index.
//
// Modified: October 22th 2021
//
// File Name: Enemy.cs
//
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    //public Transform enemy;

    private WayPoints Wpoints;

    private int waypointIndex;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Wpoints = GameObject.FindGameObjectWithTag("WayPoints").GetComponent<WayPoints>();
    }
    

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f)
        {
            if (waypointIndex < Wpoints.waypoints.Length - 1)
            {
                waypointIndex++;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
