using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class pers : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool bomba = false;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    void Update()
    {
        if (bomba && Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddForce(Vector2.up * 9000);

    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        bomba = collider.Length > 1;
    }

    public void OnJumpButtonDown()
    {
        if (bomba)
            rb.AddForce(Vector2.up * 9000);
    }
}