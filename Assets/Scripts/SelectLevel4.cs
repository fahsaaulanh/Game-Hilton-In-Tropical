using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectLevel4 : MonoBehaviour
{
    public Button button;
    public GameObject _lock;
    void Start()
    {
        button = GetComponent<Button>();

        if (PlayerPrefs.GetInt("LevelUnlock") < 4)
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
