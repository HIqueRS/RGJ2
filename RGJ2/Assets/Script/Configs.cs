using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Config")]
public class Configs : ScriptableObject
{
    public int actual_stage;

    public bool in_game;

    public bool win;
    public bool acho_1;
    public bool acho_2;

    public void Set_ingame(bool boolean)
    {
        in_game = boolean;
    }

    public void Set_win(bool boolean)
    {
        win = boolean;
    }

    public void Set_Achoo(bool boolean,int acho)
    {
        switch (acho)
        {
            case 0: acho_1 = boolean;
                break;
            case 1:
                acho_2 = boolean;
                break;
        }
    }
}
