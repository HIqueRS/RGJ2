using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondicional : MonoBehaviour
{
    //public GameObject[] Gameobj_tile;
    private TileFlower[] tile;

    private int flor0;
    private int flor1;

    public GameObject ui;

    public GameObject PaiDasTile;

    public Configs config;

    // Start is called before the first frame update
    void Start()
    {
        flor0 = 0;
        flor1 = 0;

        //Gameobj_tile = GameObject.FindGameObjectsWithTag("Ground");





        //for (int i = 0; i < Gameobj_tile.Length; i++)
        //{
        //    tile[i] = Gameobj_tile[i].GetComponent<TileFlower>();
        //}

        // ui = GameObject.FindGameObjectWithTag("Canvas")

        tile = new TileFlower[PaiDasTile.transform.childCount];

        for (int i = 0; i < PaiDasTile.transform.childCount; i++)
        {
            
             tile[i] = PaiDasTile.transform.GetChild(i).GetComponent<TileFlower>();
            
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
                config.Set_ingame(false);
                return 1;
            }
        }

        return 0;
    }
}
