using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUi : MonoBehaviour
{
    public int Skor;
    public Text SkorText;

    public int Koin;
    public Text KoinText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SkorText.text = Skor.ToString();
        KoinText.text = Koin.ToString();
    }
}
