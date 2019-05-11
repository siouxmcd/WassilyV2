using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchObject : MonoBehaviour {

    public Animator blotch;
    public Animator bubbles;
    public Animator checkers;
    public Animator squiggle;
    /*public Animator triY;
    public Animator triB;
    public Animator gridSphere;*/

    public AudioClip hapticAudioClip;

    public musicManager manager;

    

    // Use this for initialization
    void Start () {
        manager = GameObject.Find("LocalAvatar").GetComponent<musicManager>();
    }

    private void Update()
    {
        
    }
    // Update is called once per frame
    

    
    private void OnTriggerEnter(Collider other)
    {
        OVRHapticsClip hapticsClip = new OVRHapticsClip(hapticAudioClip);
        if(tag == "rightC")
        {
            OVRHaptics.RightChannel.Preempt(hapticsClip);
        }
        else if (tag == "leftC")
        {
            OVRHaptics.LeftChannel.Preempt(hapticsClip);
        }

        if (other.tag == "yrb")
        {
            blotch.SetBool("isYRB", true);
            bubbles.SetBool("isYRB", true);
            checkers.SetBool("isYRB", true);
            squiggle.SetBool("isYRB", true);

            /*triY.SetBool("isMS", false);
            triB.SetBool("isMS", false);
            gridSphere.SetBool("isMS", false);*/
        }
        else if (other.tag == "ms")
        {
            /*triY.SetBool("isMS", true);
            triB.SetBool("isMS", true);
            gridSphere.SetBool("isMS", true);*/

            blotch.SetBool("isYRB", false);
            bubbles.SetBool("isYRB", false);
            checkers.SetBool("isYRB", false);
            squiggle.SetBool("isYRB", false);
        }

        if (other.tag == "blotch")
        {
            if (!manager.isBlotch)
            {
                manager.isBlotch = true;
            } else
            {
                manager.isBlotch = false;
            }
        }
        if (other.tag == "bubbles")
        {
            if (!manager.isBubbles)
            {
                manager.isBubbles = true;
            }
            else
            {
                manager.isBubbles = false;
            }
        }
        if (other.tag == "checkers")
        {
            if (!manager.isCheckers)
            {
                manager.isCheckers = true;
            }
            else
            {
                manager.isCheckers = false;
            }
        }
        if (other.tag == "squiggle")
        {
            if (!manager.isSquiggle)
            {
                manager.isSquiggle = true;
            }
            else
            {
                manager.isSquiggle = false;
            }
        }
    }
}
