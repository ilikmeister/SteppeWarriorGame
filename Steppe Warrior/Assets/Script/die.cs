using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{
    public GameObject respawn;
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = respawn.transform.position;
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }
}
