using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactor : MonoBehaviour
{
    [Header("Coughing")]
    public bool Cough = true;   // Master switch to activate explosions
    public float waitTime = 10.0f;   // Initial wait time (in seconds)
    private float timer = 0.0f;     //Initial timer

    [Header("Sound")]
    public AudioClip ExplosionClip;
    public AudioSource Source;

    void Update()
    {
        //Screenshake
        
        timer += Time.deltaTime;

        if (Cough && timer > waitTime)
        
        {
            Source.PlayOneShot(ExplosionClip);      //Plays explosion soundfile
            timer = timer - waitTime;               //Resets timer
            waitTime = Random.Range(10.0f, 20.0f);    //Sets random wait time
        }
    }
}
