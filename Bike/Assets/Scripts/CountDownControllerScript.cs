using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownControllerScript : MonoBehaviour
{
    public int countdownTime;
    public TMP_Text CountDownText;
    //public ResetLevel rl;
    //ref to the cars controller to be able to stop from moving before the countdown is finished
    public bool startRace;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    private void Update()
    {
       // if (rl.restart)
      //  {

       // }
    }
    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            CountDownText.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }
        startRace = true;
        CountDownText.text = "RACE!";
        //sets the cars controller to active when the RACE! pops up on screen
        
        yield return new WaitForSeconds(1f);

        CountDownText.gameObject.SetActive(false);
        
    }
}
