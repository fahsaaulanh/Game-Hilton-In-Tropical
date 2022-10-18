using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOption : MonoBehaviour
{
    Animator anim;
    public bool ClickOpsi;

    void Start()
    {
        ClickOpsi = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KlikOption()
    {
        ClickOpsi = !ClickOpsi;
        anim.SetBool("opsi", ClickOpsi);
    }
}
