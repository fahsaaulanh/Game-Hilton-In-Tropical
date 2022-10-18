using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
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
    public bool jalan;
    public bool left, right, lompat;

    public int minX;
    public int maxX;

    // animasi
    Animator anim;

    //peluru
    public GameObject peluru, pos_peluru;



    public AudioSource audioJalan;

    private bool PindahScene;


    // Start is called before the first frame update
    void Start()
    {

        // mengambil komponen rigidbody2d
        jump = GetComponent<Rigidbody2D>();

        // mengambil komponen animator
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 karakter = transform.localPosition;

        // Deteksi Tanah
        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);

        if (tanah == false) {
            anim.SetBool("lompat", true);
        } else {
            anim.SetBool("lompat", false);
        }


        // Controller
        if (Input.GetKey(KeyCode.D) || (right == true) && karakter.x < maxX) {

            
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            move = -1;
            anim.SetBool("jalan", true);

        } else if (Input.GetKey(KeyCode.A) || (left == true) && karakter.x > minX) {

            
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
            move = 1;
            anim.SetBool("jalan", true);
            
        } else {
           
            anim.SetBool("jalan", false);
            
        }

        if (tanah == true && (Input.GetKey(KeyCode.Space))) {
            jump.AddForce(new Vector2(0, jump_speed));
        }

        // cek kondisi untuk flip
        if (move > 0 && !flip) {
            FlipBody();
        } else if (move < 0 && flip) {
            FlipBody();

        }

    }

    // fungsi flip atau balik badan
    void FlipBody()
    {
        flip = !flip;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;

    }

  
    public void Moveleft ()
    {
        audioJalan.Play();
        left = true;
    }

    public void UnMoveLeft ()
    {
        audioJalan.Stop();
        left = false;
    }

    public void MoveRight()
    {
        audioJalan.Play();
        right = true;
    }

    public void UnMoveRight()
    {
        audioJalan.Stop();
        right = false;
    }

    public void Melompat ()
    {
        if (tanah == true)
        {
            jump.velocity = new Vector2(0, jump_speed);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            anim.SetBool("Hit", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            anim.SetBool("Hit", false);
        }
    }

    public void Menembak()
    {
        anim.SetBool("shoot", true);
        Instantiate(peluru, pos_peluru.transform.position, pos_peluru.transform.rotation);

    }

    public void TidakMenembak()
    {
        anim.SetBool("shoot", false);
    }





}
