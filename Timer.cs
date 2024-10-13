using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    
    
    /*void Start()
    {
    
        timerText = GetComponent<Text>();
        
    } */

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0)
        {
            Time.timeScale = 0;
            remainingTime = 0;
            SceneManager.LoadSceneAsync(2);
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        /*timer -= Time.deltaTime;
        timerText.text = timer.ToString();
        if (timer <= 0)
        {
            
            timerText.text = "Candy Count: " + candyCount.ToString();
            Time.timeScale = 0;
            timer = 0; // Clamp the timer to zero
            return;
        } */
    }

}
