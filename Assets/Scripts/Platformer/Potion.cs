using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    InfoSkor nyawa;
    void Start()
    {
        nyawa = GameObject.Find("Player").GetComponent<InfoSkor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            nyawa.nyawa += 1;
            Destroy(gameObject);

        }
    }
}
