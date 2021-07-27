using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Prologue");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void ContinueGame(){
        SceneManager.LoadScene("SampleScene");
    }

    public void CreditScene(){
        SceneManager.LoadScene("CreditsScene");
    }

    public void HelpScene(){
        SceneManager.LoadScene("HelpMenu");
    }

    public void ReturnMenu(){
        SceneManager.LoadScene("Menu");
    }
}
