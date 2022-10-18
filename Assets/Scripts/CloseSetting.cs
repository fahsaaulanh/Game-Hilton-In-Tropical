using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSetting : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    public void CloseSettingAnim ()
    {
        anim.SetBool("CloseSet", true);
    }
   
}
