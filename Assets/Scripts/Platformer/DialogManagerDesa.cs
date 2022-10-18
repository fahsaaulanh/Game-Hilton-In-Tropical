using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManagerDesa : MonoBehaviour
{
    public GameObject PanelStory;
    public GameObject kuncen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PanelStory.activeSelf == false)
        {
            kuncen.SetActive(false);
        }
    }
}
