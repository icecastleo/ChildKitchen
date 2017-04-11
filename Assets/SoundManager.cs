using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    //To play sound file, create public variable type "SoundManager" in script
    //Drag and drop this "Sounds" gameObject into that variable
    //Call function with that variable
    //eg. 
    //public SoundManager sm;
    //sm.PlaySplash();

    public AudioClip[] audClips;
    private AudioSource sound;
    //public AudioSource cash;

    // Use this for initialization
    void Start () {
        sound = GetComponent<AudioSource>();
    }

    public void PlaySplash()
    {
        sound.PlayOneShot(audClips[0], .5f);

    }

    public void PlayStove()
    {
        sound.PlayOneShot(audClips[1], .5f);

    }


    public void PlayClick()
    {
        sound.PlayOneShot(audClips[2], .5f);

    }

    public void PlayClick2()
    {
        sound.PlayOneShot(audClips[3], .5f);

    }

    public void PlayLoad()
    {
        sound.PlayOneShot(audClips[4], .5f);

    }

    public void PlayMisc_Menu()
    {
        sound.PlayOneShot(audClips[5], .5f);

    }

    public void PlayMisc_Menu2()
    {
        sound.PlayOneShot(audClips[6], .5f);

    }

    public void PlayMisc_Menu3()
    {
        sound.PlayOneShot(audClips[7], .5f);

    }

    public void PlayMisc_Menu4()
    {
        sound.PlayOneShot(audClips[8], .5f);

    }

    public void PlayMisc_Sound()
    {
        sound.PlayOneShot(audClips[9], .5f);

    }

    public void PlayNegative()
    {
        sound.PlayOneShot(audClips[10], .5f);

    }

    public void PlayNegative2()
    {
        sound.PlayOneShot(audClips[11], .5f);

    }

    public void PlayPositive()
    {
        sound.PlayOneShot(audClips[12], .5f);

    }

    public void PlaySave()
    {
        sound.PlayOneShot(audClips[13], .5f);

    }

    public void PlaySharpEcho()
    {
        sound.PlayOneShot(audClips[14], .5f);

    }


    public void PlayFridgeOpen()
    {
        sound.PlayOneShot(audClips[15], .5f);

    }

    public void PlayFridgeClose()
    {
        sound.PlayOneShot(audClips[16], .5f);

    }

    public void PlayRodSplash()
    {
        sound.PlayOneShot(audClips[17], .5f);

    }

    public void PlayStore()
    {
        sound.PlayOneShot(audClips[17], .5f);

    }
    
    //public void PlayRegister()
    //{
    //    if(!cash.isPlaying)
    //    {
    //        cash.Play();
    //    }

    //}



    // Update is called once per frame
    void Update () {
	
	}
}
