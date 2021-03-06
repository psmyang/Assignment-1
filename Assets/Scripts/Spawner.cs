//*********************************************************************************************************
// GAME2014-F2021-Assignment 1-101235517.C# Unity by Mingkun Yang (C) October 22th 2021 All Rights Reserved.
//
// Name: Mingkun Yang 
//
// StudentID: 101235517
//
// Assignment 1 submission.
//
// Description: select two types of tower and spawn anywhere of the map.
//
// Modified: October 22th 2021
//
// File Name: Spawner.cs
//
// Citation: https://www.youtube.com/watch?v=KC0uO7nQ9pc&list=PLiz4aBfWzNwQpjSKpkJVJwiSl-9UGXdhX&index=41
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    //list of towers (prefabs) that will instantiate
    public List<GameObject> towersPrefabs;
    //Transform of the spawning towers (Root Object)
    public Transform spawnTowerRoot;
    //list of towers (UI)
    public List<Image> towersUI;
    //id of tower to spawn
    int spawnID = -1;
    //SpawnPoints Tilemap
    public Tilemap spawnTilemap;

    void Update()
    {
        if (CanSpawn())
            DetectSpawnPoint();
    }

    bool CanSpawn()
    {
        if (spawnID == -1)
            return false;
        else
            return true;
    }


    void DetectSpawnPoint()
    {
        for (int i =0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                //get the world space postion of the mouse
                var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //get the position of the cell in the tilemap
                var cellPosDefault = spawnTilemap.WorldToCell(mousePos);
                //get the center position of the cell
                var cellPosCentered = spawnTilemap.GetCellCenterWorld(cellPosDefault);
                //check if we can spawn in that cell (collider)
                if (spawnTilemap.GetColliderType(cellPosDefault) == Tile.ColliderType.Sprite)
                {
                    //Spawn the tower
                    SpawnTower(cellPosCentered);
                    //Disable the collider
                    spawnTilemap.SetColliderType(cellPosDefault, Tile.ColliderType.None);
                }
            }
        }

        ////Detect when mouse is clicked (first touch clicked)
        //if (Input.GetMouseButtonDown(0))
        //{
        //    //get the world space postion of the mouse
        //    var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    //get the position of the cell in the tilemap
        //    var cellPosDefault = spawnTilemap.WorldToCell(mousePos);
        //    //get the center position of the cell
        //    var cellPosCentered = spawnTilemap.GetCellCenterWorld(cellPosDefault);
        //    //check if we can spawn in that cell (collider)
        //    if (spawnTilemap.GetColliderType(cellPosDefault) == Tile.ColliderType.Sprite)
        //    {
        //        //Spawn the tower
        //        SpawnTower(cellPosCentered);
        //        //Disable the collider
        //        spawnTilemap.SetColliderType(cellPosDefault, Tile.ColliderType.None);
        //    } 
        //}
    }


    void SpawnTower(Vector3 position)
    {
        GameObject tower = Instantiate(towersPrefabs[spawnID], spawnTowerRoot);
        tower.transform.position = position;

        DeselectTowers();
    }

    public void SelectTower(int id)
    {
        DeselectTowers();
        //Set the spawnID
        spawnID = id;
        //Highlight the tower
        towersUI[spawnID].color = Color.white;
    }

    public void DeselectTowers()
    {
        spawnID = -1;
        foreach (var t in towersUI)
        {
            t.color = new Color(0.5f, 0.5f, 0.5f);
        }
    }



}