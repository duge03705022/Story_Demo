using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public RFIBManager rFIBManager; 
    public GameParameter gameParameter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SenceID();
        KeyPressed();
    }

    public void SenceID()
    {
        foreach (var dic in gameParameter.characterDic)
        {
            if (rFIBManager.tagSensing[dic.Key])
            {
                dic.Value.GetComponent<AudioSource>().Play();
            }
        }
    }

    public void PlaySound()
    {

    }

    public void KeyPressed()
    {
        //if (Input.GetKeyUp("q"))
        //{
        //    audioSource.clip = clips[0];
        //    audioSource.Play();
        //}
        //if (Input.GetKeyUp("w"))
        //{
        //    audioSource.clip = clips[1];
        //    audioSource.Play();
        //}
        //if (Input.GetKeyUp("e"))
        //{
        //    audioSource.clip = clips[2];
        //    audioSource.Play();
        //}
    }
}
