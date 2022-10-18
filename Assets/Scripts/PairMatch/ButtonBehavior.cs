using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonBehavior : MonoBehaviour
{
    public Scene [] ListScene;
    void Start ()
    {
        config.CreateScoreFile();
    }

   public void LoadScene (string scene_name) 
   { 
       SceneManager.LoadScene(scene_name);
   }

    public void RessetGameSettings ()
    {
        GameSettings.Instance.ResetGameSettings();
    }

    public void UnSillinceBacksound()
    {
        SoundManager.instance.UnMuteBackgroundMusic();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ResetLevel()
    {
        PlayerPrefs.SetInt("LevelUnlock", 1);
    }

    public void randomScene()
    {
        var randomScene = Random.Range(6,9);
        SceneManager.LoadScene(randomScene);
    }
}
