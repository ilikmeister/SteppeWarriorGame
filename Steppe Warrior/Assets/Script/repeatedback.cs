using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class repeatedback : MonoBehaviour
{

    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
