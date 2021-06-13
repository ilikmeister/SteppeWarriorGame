using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "" + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Swords)
    {
        if (Swords.tag == "Sword")
        {
            ScoreNum = ScoreNum + 50;
            Destroy(Swords.gameObject);
            MyscoreText.text = "" + ScoreNum;
        }
    }
}