using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilihScene : MonoBehaviour
{
    
    public void Countryside()
    {
        SceneManager.LoadScene("PedesaanScene");
    }

    public void Urban(){
        SceneManager.LoadScene("CityScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void option()
    {
        SceneManager.LoadScene("DoctorScene");
    }
}