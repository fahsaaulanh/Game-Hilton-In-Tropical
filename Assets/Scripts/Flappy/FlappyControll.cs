using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyControll : MonoBehaviour
{
    // pergerakan karakter
    public int speed, jump_speed, move;

    Rigidbody2D jump;

    public GameObject Endpopup;

    private bool EndGame = false;

    public AudioSource koinAudio;

   

    void Start()
    {

       

        EndGame = false;
        
        // mengambil komponen rigidbody2d
        jump = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EndGame == false)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

    }

    public void Melompat()
    {
        jump.velocity = new Vector2(0, jump_speed);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy"  || transform.localPosition.y > 2 )
        {
            EndGame = true;
            Endpopup.SetActive(true);
            StartCoroutine(End());
        }
    }

    private IEnumerator End()
    {
       

        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 0;
    }

    public void UnPause ()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Koin")
        {
            koinAudio.Play();
        }

    }



}
