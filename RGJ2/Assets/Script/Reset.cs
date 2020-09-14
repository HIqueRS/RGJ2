using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject children;
    private NextLevel next;

    private void Start()
    {
        next = GameObject.FindGameObjectWithTag("Controler").GetComponent<NextLevel>();
    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void StartUI()
    {
        children.SetActive(true);
    }

    public void Next()
    {
        next.Next();
    }
}
