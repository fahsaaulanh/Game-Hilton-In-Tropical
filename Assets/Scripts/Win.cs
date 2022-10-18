using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winPopup;
    public int playerLevelUnlock;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            if (PlayerPrefs.GetInt("LevelUnlock") < playerLevelUnlock)
            {
                PlayerPrefs.SetInt("LevelUnlock", playerLevelUnlock);
            }
            
            winPopup.SetActive(true);
        }

       


    }
}
