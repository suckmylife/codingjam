using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Screen_Manager : MonoBehaviour
{
    private void Awake()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    void Start()
    {
        
    }
    
    public void LoadScreen1()
    {
        SceneManager.LoadScene("Screen1");
    }
    public void LoadScreen2()
    {
        SceneManager.LoadScene("Screen2");
    }
    public void LoadScreen3()
    {
        SceneManager.LoadScene("Screen3");
    }

    public void End()
    {
        Application.Quit();
    }
    
    void Update()
    {
        
    }
}
