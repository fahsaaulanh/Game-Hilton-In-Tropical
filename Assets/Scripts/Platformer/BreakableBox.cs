using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBox : MonoBehaviour
{
    private ParticleSystem particle;
    private SpriteRenderer SR;
    private BoxCollider2D BC;

    public AudioSource breakBox;


    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        SR = GetComponent<SpriteRenderer>();
        BC = GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player" && other.contacts[0].normal.y > 0.5f)
        {
            breakBox.Play();
            StartCoroutine(Break());
        }
    }

    private IEnumerator Break()
    {
        particle.Play();

        SR.enabled = false;
        BC.enabled = false;

        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
        Destroy(gameObject);
    }
}
