using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class IngameMenu : MonoBehaviour
{



    public void PlayAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    public void QuitGame(){
        Application.Quit();
    }

    public void loadlevel()
    {
    SceneManager.LoadScene(1);
    }
}
