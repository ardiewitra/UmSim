using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void KeStage1()
    {
        SceneManager.LoadScene("Stage1 Ihram");
    }

    public void KeStage2()
    {
        SceneManager.LoadScene("Stage2 Miqat");
    }

    public void KeStage3()
    {
        SceneManager.LoadScene("Stage3 Thawaf");
    }

    public void KeStage4()
    {
        SceneManager.LoadScene("Stage4 Sai");
    }

    public void KeStage5()
    {
        SceneManager.LoadScene("Stage5 Tahallul");
    }

    public void Keluar()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
