using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void MulaiGame()
    {
        SceneManager.LoadScene("PilihScene");
    }

    public void Option(){
        SceneManager.LoadScene("DoctorScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}