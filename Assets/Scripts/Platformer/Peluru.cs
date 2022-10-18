using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour
{
   
    float scale_karakter;
    void Start()
    {
        scale_karakter = GameObject.Find("Player").transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(scale_karakter > 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(12f, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-12f, GetComponent<Rigidbody2D>().velocity.y);

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy" )
        {
            Destroy(gameObject);
        }

        if (other.transform.tag == "Box")
        {
            Destroy(gameObject);
        }
    }
}
