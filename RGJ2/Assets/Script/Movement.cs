using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 finalPosition;
    public Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        finalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Vector3.Distance(finalPosition,transform.position) < 0.2)
        {
            transform.position = finalPosition;

            dir.x = Input.GetAxisRaw("Horizontal");
            dir.y = Input.GetAxisRaw("Vertical");

            if (dir.x != 0)
            {
                dir.y = 0;
                RaycastHit2D hit;
                hit = Physics2D.Raycast(transform.position,dir,1f);
                
                
                if(!hit)
                {
                    finalPosition = finalPosition + dir;
                }
               
                
            }
            else if(dir.y != 0)
            {
                dir.x = 0;
                RaycastHit2D hit;
                hit = Physics2D.Raycast(transform.position, dir, 1f);

                if (!hit)
                {

                    finalPosition = finalPosition + dir;
                }
            }



        }
       
        transform.position = Vector3.MoveTowards(transform.position, finalPosition, 5 * Time.deltaTime);
        
        
    }
}
