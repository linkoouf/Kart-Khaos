
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaceClock : MonoBehaviour
{
    private float startTime;
    private bool raceFinished;
    public TMP_Text raceTimeText;
    public CheckpointsAndLaps cal;
    public bool startRace;
    public TMP_Text FinishedTime;
    public GameObject MenuCamera;
    public GameObject WinScreen;
    public GameObject Overlay;
    public GameObject CarSoundSource;
    
    //public ResetLevel rl;
    

    private void Start()
    {
        //startTime = Time.time;
        raceFinished = false;
    }

    private void Update()
    {
        //if (rl.restart)
       // {
        //    startTime = 0;
       // }
        if (!raceFinished && cal.started)
        {
            startRace = true;
            
        }
        if (startRace){
            startTime += Time.deltaTime;
            float currentTime = Time.deltaTime + startTime;
            raceTimeText.text = "00:" + currentTime.ToString("F2");
        }
        if (cal.finished){
             raceFinished = true;
            startRace = false;
            float finalTime = startTime;
            FinishedTime.text = "00:" + finalTime.ToString("F2");
            MenuCamera.SetActive(true);
            WinScreen.SetActive(true);
            Overlay.SetActive(false);
            CarSoundSource.SetActive(false);

        }
    }

   
} 
