using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource music;
    public bool startPlaying;
    public BeatScroller beatScroller;
    public static GameManager instance;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                beatScroller.hasStarted = true;
                music.Play();
                
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("hit");
        score += 100;
        Debug.Log(score);
    }

    public void NoteMiss()
    {
        Debug.Log("miss");
    }
}
