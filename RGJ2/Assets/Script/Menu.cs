using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject credits;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Credits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }

    public void Back()
    {
        menu.SetActive(true);
        credits.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("Hique");
    }

}
