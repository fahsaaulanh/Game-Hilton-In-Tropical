using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Koin : MonoBehaviour
{
    InfoSkor _Skor, _Koin;
    void Start()
    {
        _Skor = GameObject.Find("Player").GetComponent<InfoSkor>();
        _Koin = GameObject.Find("Player").GetComponent<InfoSkor>();
    }

    // Update is called once per frame
    void Update()
    {

    }

  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            _Skor.Skor += 100;
            _Koin.Koin += 1;
            Destroy(gameObject);
            
        }
    }
}
