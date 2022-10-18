using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    InfoSkor _Nyawa, _Skor;
    public GameObject Player;
    Animator anim;

    void Start()
    {
        _Nyawa = GameObject.Find("Player").GetComponent<InfoSkor>();
        _Skor = GameObject.Find("Player").GetComponent<InfoSkor>();
        anim = Player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            _Nyawa.nyawa -= 1;
            anim.SetBool("Hit", true);

        }

        if (other.transform.tag == "Peluru")
        {
            _Skor.Skor += 50;
            Destroy(gameObject);

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            anim.SetBool("Hit", false);
        }
    }

   
}
