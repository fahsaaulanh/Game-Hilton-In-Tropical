using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectLevel2 : MonoBehaviour
{
    public Button button;
    public GameObject _lock;
    void Start()
    {
        button = GetComponent<Button>();

        if(PlayerPrefs.GetInt("LevelUnlock") < 2)
        {
            button.interactable = false;
            _lock.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
