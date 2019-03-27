using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameParameter gameParameter;
    public string RFIDtag;

    // Start is called before the first frame update
    void Start()
    {
        gameParameter.characterDic.Add(RFIDtag, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClip()
    {
        GetComponent<AudioSource>().Play();
    }
}
