using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    public Transform startCar;
    public Rigidbody car;
    public bool restart;
    public Vector3 restartPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("Car");
    }
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.R))
        {
            //StartCoroutine(REstart(2f)); 
            SceneManager.LoadScene("Car");
        }
    }
    
    IEnumerator REstart(float sec)
    {


        restart = true;
        yield return new WaitForSeconds(sec);
        restart = false;
    }
}
