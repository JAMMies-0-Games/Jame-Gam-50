using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private tileManager tilePrefab;
    [SerializeField] private float camOffset;
    [SerializeField] private Transform cam;
    private List<Vector2> specTiles = new List<Vector2>();
    private List<string> specTilesType = new List<string>();
    private Dictionary<Vector2, tileManager> tiles;


    void Start()
    {
        SetTiles();
        generateGrid();
    }

    public void SetTiles()
    {
            specTiles.Add(new Vector2(0, 0));
            specTilesType.Add("babyBlueWhale");
            specTiles.Add(new Vector2(5, 3));
            specTilesType.Add("momBlueWhale");
            specTiles.Add(new Vector2(1, 1));
            specTilesType.Add("wall");
            specTiles.Add(new Vector2(3, 1));
            specTilesType.Add("wall");
    }


    void generateGrid()
    {
        tiles = new Dictionary<Vector2, tileManager>();
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"tileManager {x} {y}";

                if (specTiles.Contains(new Vector2(x, y)))
                {
                    specTiles.IndexOf(new Vector2(x, y));
                    spawnedTile.tag = specTilesType[specTiles.IndexOf(new Vector2(x, y))];
                }
                else
                {
                    spawnedTile.tag = string.Empty;
                }

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                var spawnedTileTag = spawnedTile.tag;
                spawnedTile.Init(isOffset, spawnedTileTag);
                tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        cam.transform.position = new Vector3((float)width / 2 - 0.5f - camOffset, (float)height / 2 - 0.5f, -10);
    }

}