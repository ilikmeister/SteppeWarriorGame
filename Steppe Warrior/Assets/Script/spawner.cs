using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject KALUCHKI;
    public float maxX;
    public float minX;
    public float pertime;
    private float spawntime;

    void Update()
    {
        if (Time.time > spawntime)
        {
            Spawn();
            spawntime = Time.time + pertime;
        }
    }
     
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);

        Instantiate(KALUCHKI, transform.position + new Vector3(randomX, 0, 0), transform.rotation);
    }
}
