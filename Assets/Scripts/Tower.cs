using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private Vector3 ProjectileShootFromPosition;
    
    private void Awake()
    {
        ProjectileShootFromPosition = transform.Find("ProjectileShootFromPosition").position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }
}
