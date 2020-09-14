using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource bearsing;
    public Configs config;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(config.in_game)
        {
            if(bearsing.volume < 1)
            {
                bearsing.volume += 0.1f * Time.deltaTime;
            }
        }
        else
        {
            bearsing.volume = 0;
        }
    }
}
