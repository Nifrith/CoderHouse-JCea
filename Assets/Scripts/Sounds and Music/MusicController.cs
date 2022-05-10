using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public AudioClip[] MainMenuMusic;
    string sceneName;
    string musicPlaying;
    
    void Update()
    {
        sceneName = SceneManager.GetActiveScene().name;
        setSceneMusic(sceneName);
    }

    void setSceneMusic(string sceneName){

        if(musicPlaying != sceneName){
            switch (sceneName)
              {      
                  case "MainMenu": 
                    SoundController.Instance.PlayMusic(MainMenuMusic[0]);
                    musicPlaying = "MainMenu";
                    break;
                  case "Subman - level 1": 
                    SoundController.Instance.PlayMusic(MainMenuMusic[1]);
                    musicPlaying = "Subman - level 1";
                    break;
                  case "Subman - level 2": 
                    SoundController.Instance.PlayMusic(MainMenuMusic[2]);
                    musicPlaying = "Subman - level 2";
                    break;
                  default: break;
              }
        }
        


    }



}
