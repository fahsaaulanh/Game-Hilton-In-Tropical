using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public Image FillIn;
    public GameObject GameoverPopup;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FillIn.fillAmount == 0)
        {
            GameoverPopup.SetActive(true);
        }
    }
}
