using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public Configs conf;
    public GameObject actual_stage;

    // Start is called before the first frame update
    void Start()
    {
        conf.actual_stage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        conf.actual_stage += 1;
       

        GameObject instance = Resources.Load<GameObject>("Stages/Stage"+conf.actual_stage );

       if(instance == null)
       {
            Debug.Log("EITA");
       }else
       {
            Destroy(actual_stage);

            //actual_stage.SetActive(false);
           
            actual_stage = Instantiate(instance);

        }

       
    }

    public void Restart()
    {
        GameObject instance = Resources.Load<GameObject>("Stages/Stage" + conf.actual_stage);

        if (instance == null)
        {
            Debug.Log("EITA");
        }
        else
        {
            Destroy(actual_stage);

            //actual_stage.SetActive(false);

            actual_stage = Instantiate(instance);

        }
    }
}
