using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour 
{

    
    public static AudioClip cut,breakSound, hitSound, coin, firePlace, die, yemis, kristal, swing, chest, tiken;
    static AudioSource audioSrc;




    void Start() {
        cut = Resources.Load<AudioClip>("cut");
        breakSound = Resources.Load<AudioClip>("break pot");
        hitSound = Resources.Load<AudioClip>("hit");
        coin = Resources.Load<AudioClip>("coin");
        firePlace = Resources.Load<AudioClip>("fireplace");
        die = Resources.Load<AudioClip>("die");
        yemis = Resources.Load<AudioClip>("yemis");
        kristal = Resources.Load<AudioClip>("kristal");
        swing = Resources.Load<AudioClip>("swing");
        chest = Resources.Load<AudioClip>("chest");
        tiken = Resources.Load<AudioClip>("tiken");





        audioSrc = GetComponent<AudioSource>();

    }


    void Update() {


    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "cut":
                audioSrc.PlayOneShot(cut);
                break;
            case "breakSound":
                audioSrc.PlayOneShot(breakSound);
                break;
            case "hit":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "coin":
                audioSrc.PlayOneShot(coin);
                break;
            case "fireplace":
                audioSrc.PlayOneShot(firePlace);
                break;
            case "die":
                audioSrc.PlayOneShot(die);
                break;
            case "yemis":
                audioSrc.PlayOneShot(yemis);
                break;
            case "kristal":
                audioSrc.PlayOneShot(kristal);
                break;
            case "swing":
                audioSrc.PlayOneShot(swing);
                break;
            case "chest":
                audioSrc.PlayOneShot(chest);
                break;
            case "tiken":
                audioSrc.PlayOneShot(tiken);
                break;

        }
    
    }
}
