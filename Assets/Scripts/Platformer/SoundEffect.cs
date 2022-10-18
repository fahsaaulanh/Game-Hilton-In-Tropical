using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource Burung, Potion, Koin, BreakBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Potion")
        {
            Potion.Play();
        }

        if (other.transform.tag == "Koin")
        {
            Koin.Play();
        }
    }
}
