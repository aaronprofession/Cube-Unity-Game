﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CamFollow : MonoBehaviour
{
    
    public GameObject Player, Tutorial;
    float TutorialTime = 0;
    // Start is called before the first frame update
    public static bool isDead = false;
    private void Start()
    {
        isDead = false;
    }
    public Text timerLabel;
    // Update is called once per frame
    void Update()
    {
        Timer();
        if (Player != null)
        {
            Vector3 currentPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, -1);
            transform.position = currentPosition;
        }
        else
        {
            Vector3 DeathPosition = new Vector3(0, 0, 0);
            transform.position = DeathPosition;
            isDead = true;
        }
        if (isDead == true)
        {
            if (Input.GetKey("r"))
            {
                SceneManager.LoadScene("Level");
            }
        }
        if(TutorialTime > 2)
        {
            Tutorial.SetActive(false);
        }
        

    }
    private float time;

    void Timer()
    {
        if(isDead == false)
        {
            time += Time.deltaTime;
            TutorialTime = time;
            var minutes = time / 60;
            var seconds = time % 60;
            var fractionOfSeconds = (time * 100) % 100;
            

            timerLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fractionOfSeconds);
            
        }
        
    }
}
