using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuScript : MonoBehaviour
{
    public GameObject overlay;
    public GameObject camera2;
    public GameObject mainmenu;
    public GameObject Scene;
    public GameObject Car;
    public GameObject Stand;
    public GameObject CarSoundSource;
    public GameObject EminemSong;
    public GameObject IGSONG;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void doExitGame()
    {
        Debug.Log("quitted");
        Application.Quit();
    }
    // Update is called once per frame

    public void play()
    {
        overlay.SetActive(true);
        camera2.SetActive(false);
        mainmenu.SetActive(false);
        Scene.SetActive(true);
        Car.SetActive(false);
        Stand.SetActive(false);
        CarSoundSource.SetActive(true);
        EminemSong.SetActive(false);
        IGSONG.SetActive(true);
        
    }
}
