using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFlower : MonoBehaviour
{
    public GameObject[] flower;
    private bool[] active_flower;

    // Start is called before the first frame update
    void Start()
    {
        active_flower = new bool[2];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int ChangeFlower(int f)
    {
        if(0 != f)
        {
            if(active_flower[0])
            {
                return 0;
            }
        }

        if (1 != f)
        {
            if (active_flower[1])
            {
                return 1;
            }
        }

        if (!active_flower[f])
        {
            active_flower[f] = true;
            flower[f].SetActive(true);
            return f;
        }
        else
        {
            active_flower[f] = false;
            flower[f].SetActive(false);
            return f;
        }
    }
}
