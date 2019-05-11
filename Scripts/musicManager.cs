using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicManager : MonoBehaviour {

    public AudioSource[] blotchLoop = new AudioSource[3];
    public AudioSource[] bubblesLoop = new AudioSource[3];
    public AudioSource[] checkersLoop = new AudioSource[3];
    public AudioSource wbLoop;

    public bool isStarted;
    public bool isBlotch;
    public bool isBubbles;
    public bool isCheckers;
    public bool isSquiggle;

    public Material yellow;
    public Material blue;
    public Material red;
    public Material purple;

    private int loops;


    // Use this for initialization
    void Start () {
        loops = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (isBlotch || isBubbles || isCheckers || isSquiggle)
        {
            isStarted = true;
        }
        if (isBlotch && isBubbles && isCheckers)
        {
            loops = 3;
        }
        else if ((isBlotch && isBubbles) || (isBlotch && isCheckers) || (isBubbles && isCheckers))
        {
            loops = 2;
        }
        else
        {
            loops = 1;
        }

    }

    void FixedUpdate()
    {
        if (isStarted)
        {
            wbLoop.Stop();

            if (!blotchLoop[0].isPlaying && !blotchLoop[1].isPlaying && !blotchLoop[2].isPlaying && isBubbles)
                {
                    
                    blotchLoop[0].Play();
                    bubblesLoop[0].Play();
                    checkersLoop[0].Play();
                    if (!blotchLoop[0].isPlaying && isCheckers)
                    {
                        blotchLoop[1].Play();
                        bubblesLoop[1].Play();
                        checkersLoop[1].Play();
                        if(!blotchLoop[1].isPlaying && isBlotch)
                        {
                            blotchLoop[2].Play();
                            bubblesLoop[2].Play();
                            checkersLoop[2].Play();
                        }
                    }
                }

                if(!blotchLoop[0].isPlaying && !blotchLoop[1].isPlaying && !blotchLoop[2].isPlaying && isCheckers)
                {
                    blotchLoop[1].Play();
                    bubblesLoop[1].Play();
                    checkersLoop[1].Play();
                    if (!blotchLoop[1].isPlaying && isBlotch)
                    {
                        blotchLoop[2].Play();
                        bubblesLoop[2].Play();
                        checkersLoop[2].Play();
                    }
                }

                if (!blotchLoop[0].isPlaying && !blotchLoop[1].isPlaying && !blotchLoop[2].isPlaying && isBlotch)
                {
                    blotchLoop[2].Play();
                    bubblesLoop[2].Play();
                    checkersLoop[2].Play();
                }
        }

        if (isBlotch)
        {
            blotchLoop[0].volume = 0.5f;
            blotchLoop[1].volume = 0.5f;
            blotchLoop[2].volume = 0.5f;

            Color color = purple.color;
            color.a += 0.01f;
            if (color.a > 1f)
            {
                color.a = 1f;
            }
            purple.color = color;
        }
        else if (!isBlotch)
        {
            blotchLoop[0].volume = 0;
            blotchLoop[1].volume = 0;
            blotchLoop[2].volume = 0;

            Color color = purple.color;
            color.a -= 0.01f;
            if (color.a < 0f)
            {
                color.a = 0f;
            }
            purple.color = color;
        }

        if (isBubbles)
        {
            bubblesLoop[0].volume = 0.5f;
            bubblesLoop[1].volume = 0.5f;
            bubblesLoop[2].volume = 0.5f;

            Color color = yellow.color;
            color.a += 0.01f;
            if(color.a > 1f)
            {
                color.a = 1f;
            }
            yellow.color = color;

            Color color2 = blue.color;
            color2.a += 0.001f;
            if (color2.a > 1f)
            {
                color2.a = 1f;
            }
            blue.color = color2;
        }
        else if (!isBubbles)
        {
            bubblesLoop[0].volume = 0;
            bubblesLoop[1].volume = 0;
            bubblesLoop[2].volume = 0;

            Color color = yellow.color;
            color.a -= 0.01f;
            if (color.a < 0f)
            {
                color.a = 0f;
            }
            yellow.color = color;

            Color color2 = blue.color;
            color2.a -= 0.01f;
            if (color2.a < 0f)
            {
                color2.a = 0f;
            }
            blue.color = color;
        }

        if (isCheckers)
        {
            checkersLoop[0].volume = 0.5f;
            checkersLoop[1].volume = 0.5f;
            checkersLoop[2].volume = 0.5f;

            Color color = red.color;
            color.a += 0.01f;
            if (color.a > 1f)
            {
                color.a = 1f;
            }
            red.color = color;
        }
        else if (!isCheckers)
        {
            checkersLoop[0].volume = 0;
            checkersLoop[1].volume = 0;
            checkersLoop[2].volume = 0;

            Color color = red.color;
            color.a -= 0.01f;
            if (color.a < 0f)
            {
                color.a = 0f;
            }
            red.color = color;
        }

        
    }
    
}
