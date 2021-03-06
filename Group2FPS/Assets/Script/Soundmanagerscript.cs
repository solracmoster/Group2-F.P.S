﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanagerscript : MonoBehaviour {
    // to add a sound put its name use a , after a sound to add another                                           //script set up with "shootp" so you can test if it works
    //ex: public st...shootpSound, JumpSound;
    public static AudioClip Death, Punch1, Punch2, Whiff1, Whiff2, Hit, Hop, Halt, Run, Glass, Coin, Drop ;

    //don't touch
    static AudioSource audioSrc;

	
	void Start () {
    //In order to add another sound (the one you put above) copy, paste and replace and place below.
   //ex:JumpSound = Resources.Load<AudioClip>("Jump");

        Death = Resources.Load<AudioClip>("Death");
        Punch1 = Resources.Load<AudioClip>("Punch1");
        Punch2 = Resources.Load<AudioClip>("Punch2");
        Whiff1 = Resources.Load<AudioClip>("Whiff1");
        Whiff2 = Resources.Load<AudioClip>("Whiff2");
        Hit = Resources.Load<AudioClip>("Hit");
        Hop = Resources.Load<AudioClip>("Hop");
        Halt = Resources.Load<AudioClip>("Halt");
        Run = Resources.Load<AudioClip>("Run");
        Glass = Resources.Load<AudioClip>("Glass");
        Coin = Resources.Load<AudioClip>("Coin");
        Drop = Resources.Load<AudioClip>("Drop");



        // don't touch
        audioSrc = GetComponent<AudioSource>();

	}
	
	
	void Update () {
		
	}


    //copy, paste, replace, place

 //  ex:           switch (clip)
 //             {
 //                 case "JumpSound":
 //                 audioSrc.PlayOneShot(JumpSound);
 //                 break;
 //         }
 

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Death":
                audioSrc.PlayOneShot(Death);
                break;
        }
        switch (clip)
        {
            case "Punch1":
                audioSrc.PlayOneShot(Punch1);
                break;
        }
        switch (clip)
        {
            case "Punch2":
                audioSrc.PlayOneShot(Punch2);
                break;
        }
        switch (clip)
        {
            case "Whiff1":
                audioSrc.PlayOneShot(Whiff1);
                break;
        }
        switch (clip)
        {
            case "Whiff2":
                audioSrc.PlayOneShot(Whiff2);
                break;
        }
        switch (clip)
        {
            case "Hit":
                audioSrc.PlayOneShot(Hit);
                break;
        }
        switch (clip)
        {
            case "Hop":
                audioSrc.PlayOneShot(Hop);
                break;
        }
        switch (clip)
        {
            case "Halt":
                audioSrc.PlayOneShot(Halt);
                break;
        }
        switch (clip)
        {
            case "Run":
                audioSrc.PlayOneShot(Run);
                break;
        }
        switch (clip)
        {
            case "Glass":
                audioSrc.PlayOneShot(Glass);
                break;
        }
        switch (clip)
        {
            case "Coin":
                audioSrc.PlayOneShot(Coin);
                break;
        }
        switch (clip)
        {
            case "Drop":
                audioSrc.PlayOneShot(Drop);
                break;
        }

        //  ex:           switch (clip)
        //             {
        //                 case "JumpSound":
        //                 audioSrc.PlayOneShot(JumpSound);
        //                 break;
        //         }

    }


}
//Use this in another script to have your sound play after something, put it after you jump or when you get hit stuff like that go nuts.
//Soundmanagerscript.PlaySound("shootp");