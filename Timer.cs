using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public Text timerText;
    public int candyCount = 100;
    //public Camera mainCam;
    //public Camera rankCam;
    
    void Start()
    {
        //mainCam.SetActive(true);
        //rankCam.SetActive(false);
        timerText = GetComponent<Text>();
        //rankCam = GameObject.FindGameObjectWithTag("Rank").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString();
        if (timer <= 0)
        {
            //Application.Quit();
            timerText.text = "Candy Count: " + candyCount.ToString();
            Time.timeScale = 0;
            timer = 0; // Clamp the timer to zero
            return;
            //timerText.text = "0"; // Show zero on the UI
            //timerText.text = "'" + candyCount + "'"; // Show zero on the UI
            //mainCam.SetActive(false);
            //rankCam.SetActive(true);
        }
    }

}