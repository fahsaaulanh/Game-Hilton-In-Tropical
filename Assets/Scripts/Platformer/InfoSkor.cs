using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoSkor : MonoBehaviour
{
    
    public int Skor;
    public Text SkorText;

    public int Koin;
    public Text KoinText;

    public int nyawa = 5;
    public Image fillHp;

    public Text scoreGameover;
    public Text skorWin;

    void Start()
    {
        fillHp.fillAmount = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(nyawa > 5)
        {
            nyawa = 5;
        }
        fillHp.fillAmount = 0.2f * nyawa;
        SkorText.text = Skor.ToString();
        KoinText.text = Koin.ToString();
        scoreGameover.text = Skor.ToString();
        skorWin.text = Skor.ToString();

    }
}
