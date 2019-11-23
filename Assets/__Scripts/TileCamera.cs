using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCamera : MonoBehaviour
{

    static private int       W, H;
    static private int[,]    MAP;
    static public Sprite[]   SPRITES;
    static public Transform  TILE_ANCHOR;
    static public Tile[,]    TILES;

    [Header("Set in Inspector")]
    public TextAsset mapData;
    public Texture2D mapTiles;
    public TextAsset mapCollisions;
    public Tile      tilePrefab;

   void Awake()
    {
        LoadMap();
    }

    public void LoadMap()
    
    {
        GameObject go = new GameObject("TILE_ANCHOR");
        TILE_ANCHOR = go.transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
