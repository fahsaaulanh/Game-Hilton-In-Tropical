using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoRun : MonoBehaviour
{
    // pergerakan karakter
    public int speed, jump_speed, move;
    public bool flip;


    Rigidbody2D jump;

    // pendeteksi tanah
    public bool tanah;
    public LayerMask targetlayer;
    public Transform deteksitanah;
    public float jangkauan;
  

    // animasi
    Animator anim;

    public GameObject GameoverPopup;

    public int Skor;
    public Text SkorText;
    public Text HighSkorText;
    public Text EndSkorText;
    private bool end = false;

    public AudioSource koinAudio;

    // Start is called before the first frame update
    void Start()
    {

        // mengambil komponen rigidbody2d
        jump = GetComponent<Rigidbody2D>();

        // mengambil komponen animator
        anim = GetComponent<Animator>();

        HighSkorText.text = PlayerPrefs.GetInt("HighSkorRun").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (end == false)
        {
            Skor += 1;
        }
      

        Vector2 karakter = transform.localPosition;

        // Deteksi Tanah
        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);

        if (tanah == false)
        {
            anim.SetBool("lompat", true);
        }
        else
        {
            anim.SetBool("lompat", false);
        }

        //auto run
        transform.Translate(Vector2.right * speed * Time.deltaTime);
      
        //gameover
        if (karakter.y < -5)
        {
            end = true;
            if(PlayerPrefs.GetInt("HighSkorRun") < Skor)
            {
                PlayerPrefs.SetInt("HighSkorRun", Skor);
            }
            GameoverPopup.SetActive(true);
            StartCoroutine(End());
        }

        SkorText.text = Skor.ToString();
        EndSkorText.text = Skor.ToString();


    }

    


    public void Melompat()
    {
        if (tanah == true)
        {
            jump.velocity = new Vector2(0, jump_speed);
        }


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            end = true;
            if (PlayerPrefs.GetInt("HighSkorRun") < Skor)
            {
                PlayerPrefs.SetInt("HighSkorRun", Skor);
            }
            GameoverPopup.SetActive(true);
            StartCoroutine(End());
        }
    }

    private IEnumerator End ()
    {
        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Koin")
        {
            Skor += 50;
            koinAudio.Play();
        }
    }






}
