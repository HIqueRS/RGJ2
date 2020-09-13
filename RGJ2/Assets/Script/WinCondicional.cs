using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondicional : MonoBehaviour
{
    public GameObject[] Gameobj_tile;
    private TileFlower[] tile;

    private int flor0;
    private int flor1;

    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        flor0 = 0;
        flor1 = 0;

        Gameobj_tile = GameObject.FindGameObjectsWithTag("Ground");

        tile = new TileFlower[Gameobj_tile.Length];


        for (int i = 0; i < Gameobj_tile.Length; i++)
        {
            tile[i] = Gameobj_tile[i].GetComponent<TileFlower>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public int Atualize()
    {
        flor0 = 0;
        flor1 = 0;
        foreach (TileFlower flower in tile)
        {
            if(flower.active_flower[0])
            {
                flor0 += 1;
            }
            if (flower.active_flower[1])
            {
                flor1 += 1;
            }
        }

        if(flor0 == tile.Length/2)
        {
            if(flor1 == tile.Length/2)
            {
                ui.SetActive(true);
                return 1;
            }
        }

        return 0;
    }
}
