using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource bearsing;
    public AudioSource win;
    public Configs config;

    

    public AudioSource atcho1;
    public AudioSource atcho2;


    private bool play_music;
    private bool play_atcho1;
    private bool play_atcho2;
    // Start is called before the first frame update
    void Start()
    {
        play_music = false;
        play_atcho1 = false;
        play_atcho2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(config.in_game)
        {
            //config.Set_Achoo(false, 0);
            //config.Set_Achoo(false, 1);

            if(bearsing.volume < 1)
            {
                bearsing.volume += 0.1f * Time.deltaTime;
            }
        }
        else
        {
            bearsing.volume = 0;
        }

        //win.Play();

        if (config.win)
        {
            if(!play_music)
            {
                play_music = true;
                win.Play();
                
            }
        }
        else
        {
            if(win.isPlaying)
            {
                win.Stop();
                //win.volume = 0;
                play_music = false;
            }
        }

        if(config.acho_1)
        {
            if(!play_atcho1)
            {
                play_atcho1 = true;
                atcho1.Play();
            }
        }
        else
        {
            if (atcho1.isPlaying)
            {
                atcho1.Stop();
                //win.volume = 0;
                play_atcho1 = false;
            }
        }

        if (config.acho_2)
        {
            if (!play_atcho2)
            {
                play_atcho2 = true;
                Debug.Log("oi");
                atcho2.Play();
            }
        }
        else
        {
            if (atcho2.isPlaying)
            {
                atcho2.Stop();
                //win.volume = 0;
                Debug.Log("tchau");
                play_atcho2 = false;
            }
        }
    }

    
}
