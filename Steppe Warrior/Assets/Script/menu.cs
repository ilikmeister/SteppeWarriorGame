using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
 
    public void Scene1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }

    public void Scene2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;

    }

    public void Scene3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }

    public void Scene4()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }

    public void Scene5()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1;
    }
}