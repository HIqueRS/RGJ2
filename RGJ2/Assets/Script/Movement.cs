﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Vector3 finalPosition;
    private Vector3 dir;
    public Player player;
    public enum Player { Player1, Player2};

    private string horizontal;
    private string vertical;

    public int flower;

    
    private bool atchoo;

    private Reset reset;

    private WinCondicional win;

    private Passing parent;

    private bool wining;

    public SpriteRenderer sprite_atual;
    public Sprite sprite_cima;
    public Sprite sprite_baixo;
    public Sprite sprite_lado;

    public Configs config;
    // Start is called before the first frame update
    void Start()
    {
        finalPosition = transform.position;

        //reset = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Reset>();
        //win = GameObject.FindGameObjectWithTag("Canvas").GetComponent<WinCondicional>();

        parent = transform.parent.GetComponent<Passing>();
        reset = parent.reset;
        win = parent.win;

        wining = false;

        switch ( player)
        {
            case Player.Player1:
                horizontal = "Horizontal_1";
                vertical = "Vertical_1";
                break;
            case Player.Player2:
                horizontal = "Horizontal_2";
                vertical = "Vertical_2";
                break;
        }

        atchoo = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, dir);
        if(!wining)
        if (!atchoo)
        {

            if(Vector3.Distance(finalPosition,transform.position) < 0.2)
            {
                transform.position = finalPosition;

                dir.x = Input.GetAxisRaw(horizontal);
                dir.y = Input.GetAxisRaw(vertical);

                if (dir.x != 0)
                {
                    dir.y = 0;
                    RaycastHit2D hit;
                   
                    
                    hit = Physics2D.Raycast(transform.position ,dir,1f);
                    Debug.DrawRay(transform.position , dir);
                
                    

                    if(!hit)
                    {
                        finalPosition = finalPosition + dir;
                    }
                    else if(hit.transform.gameObject.tag == "Ground")
                    {
                        finalPosition = finalPosition + dir;
                    }

                    if(dir.x > 0)
                    {
                            sprite_atual.sprite = sprite_lado;
                            sprite_atual.flipX = true;
                    }
                    else
                    {
                            sprite_atual.sprite = sprite_lado;
                            sprite_atual.flipX = false;
                        }
                
                }
                else if(dir.y != 0)
                {
                    dir.x = 0;
                    RaycastHit2D hit;
                    hit = Physics2D.Raycast(transform.position, dir, 1f);
                    Debug.DrawRay(transform.position , dir);

                    if (!hit)
                    {
                        finalPosition = finalPosition + dir;
                    }
                    else if (hit.transform.gameObject.tag == "Ground")
                    {
                        finalPosition = finalPosition + dir;
                    }

                        if (dir.y > 0)
                        {
                            sprite_atual.sprite = sprite_cima;
                            
                        }
                        else
                        {
                            sprite_atual.sprite = sprite_baixo;
                            
                        }

                    }



            }
       
            transform.position = Vector3.MoveTowards(transform.position, finalPosition, 4 * Time.deltaTime);
        }
        
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.transform.gameObject.GetComponent<TileFlower>().ChangeFlower(flower) != flower)
        {
            atchoo = true;
            reset.StartUI();
            config.Set_ingame(false);//hmmmm aquii eu já posso passar quem é quem

            config.Set_Achoo(true, (int)player);
        }

        if(win.Atualize() == 1)
        {
            wining = true;
        }

        

    }
}
