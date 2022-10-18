using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlappy : MonoBehaviour
{
    ScoreFlappy _Skor;

    // Start is called before the first frame update
    void Start()
    {
        _Skor = GameObject.Find("Main Camera").GetComponent<ScoreFlappy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            _Skor.Score += 50;
            Destroy(gameObject);
        }



    }
}
