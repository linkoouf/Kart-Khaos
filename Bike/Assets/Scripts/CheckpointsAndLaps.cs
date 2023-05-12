using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckpointsAndLaps : MonoBehaviour
{
    [Header("Checkpoints")]
    public GameObject start;
    public GameObject end;
    public GameObject[] checkpoints;
    public TMP_Text CheckpointText;

    [Header("Settings")]
    public float laps = 1;

    [Header("Information")]
    private float currentCheckpoint;
    private float currentLap;
    public bool started;
    public bool finished;
    public ResetLevel RL;
    public GameObject lap1;
    public GameObject lap2;

    private void Start()
    {
        currentCheckpoint = 0;
        currentLap = 1;

        started = false;
        finished = false;
    }
    private void Update(){

       // if (RL.restart)
       // {
       //     currentCheckpoint = 0;
       //     currentLap = 1;
        //    started = false;
        //    finished = false;
       // }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            GameObject thisCheckpoint = other.gameObject;

            // Started the race
            if (thisCheckpoint == start && !started)
            {
                //print("Started");
                started = true;
                Debug.Log("starded");
            }
            // Ended the lap/race
            else if (thisCheckpoint == end && started)
            {
                // if all laps are finished. End the race
                if (currentLap == laps)
                {
                    if (currentCheckpoint == checkpoints.Length)
                    {
                        finished = true;
                        print("finished");
                    }
                    else
                    {
                        currentCheckpoint = 0;
                        print("Did not go through all checkpoints");
                    }
                }
                // if all laps are not finished, start a bew lap
                else if (currentLap < laps)
                {
                    if (currentCheckpoint == checkpoints.Length)
                    {
                        lap1.SetActive(false);
                        lap2.SetActive(true);
                        currentLap++;
                        currentCheckpoint = 0;
                        CheckpointText.text = "Checkpoint " + currentCheckpoint +"/5";
                        print($"Started lap {currentLap}");
                    }
                }
                else
                {
                    print("Did not go through all checkpoints");
                }   
            }

            // Loop through the chekpoints and comparre and check which one the platyer passed through
            for (int i = 0; i < checkpoints.Length; i++)
            {
                if (finished)
                    return;

                // if the checkpoint is correct
                if (thisCheckpoint == checkpoints[i] && i == currentCheckpoint)
                {
                    print("Correct checkpoint");
                    currentCheckpoint++;
                    CheckpointText.text = "Checkpoint " + currentCheckpoint +"/5";
                
                }
                //if the checkpoint is incorrect
                else if (thisCheckpoint == checkpoints[i] && i != currentCheckpoint)
                {
                    print("incorrect checkpoint");
                }
            }
        }
    }
}
