using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;

    public GameObject pauseMenuUI;
    public GameObject inGameUI;

    private InputActions _inputactions;


    void Awake()
    {
        _inputactions = new InputActions();
       
    }

     void OnPauseGame() {
            if (isGamePaused == true)
            {
                Resume();
            } else if (isGamePaused == false){
                Pause();
            }
     }

    void Resume(){
        inGameUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    
    void Pause(){
        inGameUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public static void BackToMain(){
        Time.timeScale = 1f;
        isGamePaused = false;        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame(){
        Application.Quit();
    }
}