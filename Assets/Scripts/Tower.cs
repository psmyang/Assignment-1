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
        if (Time.frameCount % 60 == 0)
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
