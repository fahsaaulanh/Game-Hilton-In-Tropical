using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Image BarFiilIn;
    public Text ProgressLoading;
    public float value;
    public string SceneName;

    void Start()
    {
        BarFiilIn.fillAmount = 0;
    }

    void Update()
    {
        BarFiilIn.fillAmount += Time.deltaTime / 5;
        value = BarFiilIn.fillAmount * 100;
        ProgressLoading.text = value.ToString("0");

        if (BarFiilIn.fillAmount == 1)
        {
            SceneManager.LoadScene(SceneName);
        }

    }
}
